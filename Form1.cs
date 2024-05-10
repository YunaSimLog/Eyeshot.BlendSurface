using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyeshot.BlendSurface
{
    public partial class Form1 : Form
    {
        Surface _loft1, _loft2;                         // 합칠 곡면들
        int _indexEdge1, _indexEdge2, _indexSurf = -1;    // 합칠 모서리의 인덱스와 합쳐진 곡면 인덱스

        bool _extendU;
        bool _surfaceEnd;

        public Form1()
        {
            InitializeComponent();

            design1.ObjectManipulator.MouseDrag += ObjectManipulator_MouseDrag;
            design1.SelectionChanged += Design1_SelectionChanged;
            design1.MouseClick += Design1_MouseClick;
        }

        protected override void OnLoad(EventArgs e)
        {
            // 첫 번째 곡면의 곡선을 보간한다.
            List<Point3D> array = new List<Point3D>
            {
                new Point3D(0,60,0),
                new Point3D(0,40,5),
                new Point3D(0,20,+15),
                new Point3D(0,0,0)
            };

            Curve first = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(40, 60, 0));
            array.Add(new Point3D(40, 20, 10));
            array.Add(new Point3D(40, 5, 10));
            array.Add(new Point3D(40, -5, 5));

            Curve second = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(80, 70, 0));
            array.Add(new Point3D(80, 50, 10));
            array.Add(new Point3D(80, 30, 20));
            array.Add(new Point3D(80, 10, 10));
            array.Add(new Point3D(80, 0, 0));

            Curve third = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(120, 75, 2));
            array.Add(new Point3D(120, 65, 0));
            array.Add(new Point3D(120, 60, 10));
            array.Add(new Point3D(120, 20, 20));
            array.Add(new Point3D(120, 5, 15));
            array.Add(new Point3D(120, 0, 0));

            Curve fourth = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(160, 60, 0));
            array.Add(new Point3D(160, 30, 10));
            array.Add(new Point3D(160, 0, 10));
            array.Add(new Point3D(160, 0, 0));

            Curve fifth = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(180, 60, 0));
            array.Add(new Point3D(180, 30, 10));
            array.Add(new Point3D(180, 0, 5));
            array.Add(new Point3D(180, -5, 0));

            Curve sixth = Curve.GlobalInterpolation(array, 3);

            array.Clear();
            array.Add(new Point3D(140, 80, -10));
            array.Add(new Point3D(130, 30, -10));
            array.Add(new Point3D(125, 0, -10));
            array.Add(new Point3D(140, -10, -10));

            Curve cv = Curve.GlobalInterpolation(array, 3);
            Surface extrude = cv.ExtrudeAsSurface(0, 0, 60)[0];

            // 로프트 곡면 1
            _loft1 = Surface.Loft(new ICurve[] { fourth, fifth, sixth }, 3)[0];
            _loft1.TrimBy(extrude, 0.01, false);

            // 로프트 곡면 2
            _loft2 = Surface.Loft(new ICurve[] { first, second, third }, 3)[0];

            _indexEdge1 = 0;
            _indexEdge2 = 1;
            Curve edge1 = (Curve)_loft1.ExtractEdges()[_indexEdge1];
            Curve edge2 = (Curve)_loft2.ExtractEdges()[_indexEdge2];

            // 모서리의 라벨 추가
            design1.ActiveViewport.Labels.Add(new devDept.Eyeshot.Control.Labels.LeaderAndText(edge1.PointAt(edge1.Domain.ParameterAt(0.5)), "Edge1", new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 20)));
            design1.ActiveViewport.Labels.Add(new devDept.Eyeshot.Control.Labels.LeaderAndText(edge2.PointAt(edge1.Domain.ParameterAt(0.5)), "Edge2", new Font("Tahoma", 8.25f), Color.Black, new Vector2D(0, 20)));

            _loft2.ShowControl = true;

            design1.Entities.Add(_loft1, Color.Teal);
            design1.Entities.Add(_loft2, Color.Teal);

            design1.ActiveViewport.DisplayMode = devDept.Eyeshot.displayType.Shaded;

            design1.Shaded.SilhouettesDrawingMode = devDept.Eyeshot.silhouettesDrawingType.Never;

            design1.Shaded.ShowEdges = false;

            design1.ZoomFit();

            base.OnLoad(e);
        }

        private void chkExtend_Click(object sender, EventArgs e)
        {
            if (!chkExtend.Enabled)
                return;

            design1.SetTipText("늘리기 할 곡면 모서리를 선택하세요.");

            chkExtend.Enabled = false;

            // 보이는 요소 선택 모드
            design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByPick;

            List<Entity> edges = new List<Entity>();

            _loft2.Selectable = false;

            List<Tuple<Stack<BlockReference>, Entity>> isolated = new List<Tuple<Stack<BlockReference>, Entity>>();

            foreach (ICurve icurve in _loft2.ExtractEdges())
            {
                Entity edge = icurve as Entity;
                if (edge == null)
                    continue;
                edge.Color = Color.Red;
                edge.ColorMethod = colorMethodType.byEntity;
                edge.LineWeightMethod = colorMethodType.byEntity;
                edge.LineWeight = 3;
                edges.Add(edge);
                isolated.Add(new Tuple<Stack<BlockReference>, Entity>(new Stack<BlockReference>(), edge));
            }

            isolated.Add(new Tuple<Stack<BlockReference>, Entity>(new Stack<BlockReference>(), _loft2));

            design1.Entities.AddRange(edges);

            // 투명도 처리
            if (design1.IsolateAvailable)
                design1.IsolateInstances(isolated);

            design1.Invalidate();
        }

        private void trkbExtend_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Design1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || design1.TempEntities.Count <= 0 || !(design1.TempEntities[0] is Surface))
                return;

            _loft2.Selectable = true;

            // 투명도 처리 초기화
            if (design1.IsolateAvailable)
                design1.IsolateInstances(null);

            design1.TempEntities.Clear();
            design1.ObjectManipulator.Cancel();

            Surface surface = design1.TempEntities[0] as Surface;
            if (surface != null)
            {
                _loft2.ExtendAtU(surface.DomainU.High);
                _loft2.ExtendAtU(surface.DomainU.Low);
                _loft2.ExtendAtV(surface.DomainV.High);
                _loft2.ExtendAtV(surface.DomainV.Low);
            }

            design1.Entities.Regen();
            chkExtend.Enabled = true;
            design1.SetTipText(string.Empty);
            design1.Invalidate();
        }

        private void Design1_SelectionChanged(object sender, devDept.Eyeshot.Control.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0)
                return;

            if (!(e.AddedItems[0].Item is Curve))
                return;

            design1.ActionMode = devDept.Eyeshot.actionType.None;
            Curve curve = e.AddedItems[0].Item as Curve;
            design1.Entities.RemoveAll(ent => ent is ICurve);
            EnableSurfaceExtension(curve);
        }

        private void EnableSurfaceExtension(Curve curve)
        {
            // Loft2의 곡면을 복사하여, 임시 엔티티에 추가한다.
            Surface surface = (Surface)_loft2.Clone();
            surface.Regen(0.2);
            design1.TempEntities.Add(surface);

            // 원본 엔티티를 선택하지 못하게 막기
            foreach (Entity design1Entity in design1.Entities)
            {
                design1Entity.SetSelection(false);
            }

            // 커브의 중간점을 곡면에 투영
            Point3D midPoint = curve.PointAt(curve.Domain.Mid);
            double u, v;
            _loft2.Project(midPoint, out u, out v);

            SetExtensionSide(u, v);
            EnableObjectManipulator(u, v);
        }

        private void EnableObjectManipulator(double u, double v)
        {
            design1.SetTipText("확장하려면 우 클릭 하세요.");
            double dir = _surfaceEnd ? 1 : -1;
            Vector3D[,] surfaceFrame = _loft2.Evaluate(u, v, 1);
            Align3D align = new Align3D(Plane.XY, new Plane(surfaceFrame[0, 0].AsPoint, dir * surfaceFrame[1, 0], dir * surfaceFrame[0, 1]));

            // 곡면 늘리기 조정자 나타나게
            design1.ObjectManipulator.Enable(align, false);

            // 곡면 늘리기 방향에서만 화살표 표시
            design1.ObjectManipulator.TranslateX.Visible = _extendU;
            design1.ObjectManipulator.TranslateY.Visible = !_extendU;
            design1.ObjectManipulator.TranslateZ.Visible = false;

            // 회전 화살표 숨기기
            design1.ObjectManipulator.RotateX.Visible = false;
            design1.ObjectManipulator.RotateY.Visible = false;
            design1.ObjectManipulator.RotateZ.Visible = false;

            design1.CompileUserInterfaceElements();
        }

        private void SetExtensionSide(double u, double v)
        {
            if (Math.Abs(u - _loft2.DomainU.Low) < Utility.TOL6)
            {
                _extendU = true;
                _surfaceEnd = false;
            }

            if (Math.Abs(u - _loft2.DomainU.High) < Utility.TOL6)
            {
                _extendU = true;
                _surfaceEnd = true;
                return;
            }

            if (Math.Abs(v - _loft2.DomainV.Low) < Utility.TOL6)
            {
                _extendU = false;
                _surfaceEnd = false;
                return;
            }

            if (Math.Abs(v - _loft2.DomainV.High) < Utility.TOL6)
            {
                _extendU = false;
                _surfaceEnd = true;
            }
        }

        private void ObjectManipulator_MouseDrag(object sender, devDept.Eyeshot.Control.ObjectManipulator.ObjectManipulatorEventArgs e)
        {
            Surface surface = (Surface)_loft2.Clone();
            design1.TempEntities.Clear();
            surface.Color = Color.FromArgb(150, Color.Beige);
            surface.ColorMethod = colorMethodType.byEntity;
            ExtendSurface(surface);
            surface.Regen(0.1);
            design1.TempEntities.Add(surface);
            design1.Invalidate();
        }

        private void ExtendSurface(Surface surface)
        {
            int index = _extendU ? 0 : 1;
            double dir = _surfaceEnd ? 1 : -1;

            // 100 나누는 이유는 늘리기 값을 부드럽게 처리하기 위함.
            double extensionFraction = Math.Abs(design1.ObjectManipulator.Transformation.Matrix[index, 3] - design1.ObjectManipulator.InitialTransformation.Matrix[index, 3]) / 100;

            if (_extendU)
            {
                if (_surfaceEnd)
                    surface.ExtendAtU(_loft2.DomainU.High + dir * extensionFraction * _loft2.DomainU.Length);
                else
                    surface.ExtendAtU(_loft2.DomainU.Low + dir * extensionFraction * _loft2.DomainU.Length);
            }
            else
            {
                if (_surfaceEnd)
                    surface.ExtendAtV(_loft2.DomainV.High + dir * extensionFraction * _loft2.DomainV.Length);
                else
                    surface.ExtendAtV(_loft2.DomainV.Low + dir * extensionFraction * _loft2.DomainV.Length);
            }
        }
    }
}
