
namespace Eyeshot.BlendSurface
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.Control.CancelToolBarButton cancelToolBarButton3 = new devDept.Eyeshot.Control.CancelToolBarButton("Cancel", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ProgressBar progressBar3 = new devDept.Eyeshot.Control.ProgressBar(devDept.Eyeshot.Control.ProgressBar.styleType.Speedometer, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton3, false, 0.1D, 0.333D, true);
            devDept.Eyeshot.Control.BackgroundSettings backgroundSettings3 = new devDept.Eyeshot.Control.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Eyeshot.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera3 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Eyeshot.projectionType.Perspective, 40D, 3.0200001972191952D, false, 0.001D);
            devDept.Eyeshot.Control.HomeToolBarButton homeToolBarButton3 = new devDept.Eyeshot.Control.HomeToolBarButton("Home", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton3 = new devDept.Eyeshot.Control.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomWindowToolBarButton zoomWindowToolBarButton3 = new devDept.Eyeshot.Control.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomToolBarButton zoomToolBarButton3 = new devDept.Eyeshot.Control.ZoomToolBarButton("Zoom", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.PanToolBarButton panToolBarButton3 = new devDept.Eyeshot.Control.PanToolBarButton("Pan", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.RotateToolBarButton rotateToolBarButton3 = new devDept.Eyeshot.Control.RotateToolBarButton("Rotate", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomFitToolBarButton zoomFitToolBarButton3 = new devDept.Eyeshot.Control.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.ToolBar toolBar3 = new devDept.Eyeshot.Control.ToolBar(devDept.Eyeshot.Control.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.Control.ToolBarButton[] {
            ((devDept.Eyeshot.Control.ToolBarButton)(homeToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(magnifyingGlassToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomWindowToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(panToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(rotateToolBarButton3)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomFitToolBarButton3))}, 5, 0, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D);
            devDept.Eyeshot.Control.Legend legend3 = new devDept.Eyeshot.Control.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:+0.###;-0.###;0}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, null, null, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, true, false);
            devDept.Eyeshot.Control.Histogram histogram3 = new devDept.Eyeshot.Control.Histogram(30, 80, "Title", System.Drawing.Color.Blue, System.Drawing.Color.Gray, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.LightYellow, false, true, false, "{0:+0.###;-0.###;0}");
            devDept.Eyeshot.Control.Grid grid3 = new devDept.Eyeshot.Control.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.Control.OriginSymbol originSymbol3 = new devDept.Eyeshot.Control.OriginSymbol(10, devDept.Eyeshot.Control.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.Control.RotateSettings rotateSettings3 = new devDept.Eyeshot.Control.RotateSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.Control.ZoomSettings zoomSettings3 = new devDept.Eyeshot.Control.ZoomSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.Control.PanSettings panSettings3 = new devDept.Eyeshot.Control.PanSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.Control.NavigationSettings navigationSettings3 = new devDept.Eyeshot.Control.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Left, devDept.Eyeshot.Control.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Control.CoordinateSystemIcon coordinateSystemIcon3 = new devDept.Eyeshot.Control.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.Control.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.Control.ViewCubeIcon viewCubeIcon3 = new devDept.Eyeshot.Control.ViewCubeIcon(devDept.Eyeshot.Control.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D), true);
            devDept.Eyeshot.Control.Viewport viewport3 = new devDept.Eyeshot.Control.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(610, 302), backgroundSettings3, camera3, new devDept.Eyeshot.Control.ToolBar[] {
            toolBar3}, new devDept.Eyeshot.Control.Legend[] {
            legend3}, histogram3, devDept.Eyeshot.displayType.Rendered, true, false, false, new devDept.Eyeshot.Control.Grid[] {
            grid3}, new devDept.Eyeshot.Control.OriginSymbol[] {
            originSymbol3}, false, rotateSettings3, zoomSettings3, panSettings3, navigationSettings3, coordinateSystemIcon3, viewCubeIcon3, devDept.Eyeshot.viewType.Trimetric);
            this.trkbInfluenceEdge2 = new System.Windows.Forms.TrackBar();
            this.trkbInfluenceEdge1 = new System.Windows.Forms.TrackBar();
            this.tbInfluenceEdge1 = new System.Windows.Forms.TextBox();
            this.tbInfluenceEdge2 = new System.Windows.Forms.TextBox();
            this.chkExtend = new System.Windows.Forms.CheckBox();
            this.chkBlend = new System.Windows.Forms.CheckBox();
            this.gbExtension = new System.Windows.Forms.GroupBox();
            this.gbBlend = new System.Windows.Forms.GroupBox();
            this.lbInfluenceEdge2 = new System.Windows.Forms.Label();
            this.lbInfluenceEdge1 = new System.Windows.Forms.Label();
            this.design1 = new Eyeshot.BlendSurface.MyDesign();
            ((System.ComponentModel.ISupportInitialize)(this.trkbInfluenceEdge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbInfluenceEdge1)).BeginInit();
            this.gbExtension.SuspendLayout();
            this.gbBlend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).BeginInit();
            this.SuspendLayout();
            // 
            // trkbInfluenceEdge2
            // 
            this.trkbInfluenceEdge2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkbInfluenceEdge2.Location = new System.Drawing.Point(106, 108);
            this.trkbInfluenceEdge2.Maximum = 20;
            this.trkbInfluenceEdge2.Minimum = 4;
            this.trkbInfluenceEdge2.Name = "trkbInfluenceEdge2";
            this.trkbInfluenceEdge2.Size = new System.Drawing.Size(346, 45);
            this.trkbInfluenceEdge2.TabIndex = 5;
            this.trkbInfluenceEdge2.Value = 4;
            this.trkbInfluenceEdge2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkbInfluenceEdge2_MouseUp);
            // 
            // trkbInfluenceEdge1
            // 
            this.trkbInfluenceEdge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkbInfluenceEdge1.Location = new System.Drawing.Point(106, 51);
            this.trkbInfluenceEdge1.Maximum = 20;
            this.trkbInfluenceEdge1.Minimum = 4;
            this.trkbInfluenceEdge1.Name = "trkbInfluenceEdge1";
            this.trkbInfluenceEdge1.Size = new System.Drawing.Size(346, 45);
            this.trkbInfluenceEdge1.TabIndex = 2;
            this.trkbInfluenceEdge1.Value = 4;
            this.trkbInfluenceEdge1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trkbInfluenceEdge1_MouseUp);
            // 
            // tbInfluenceEdge1
            // 
            this.tbInfluenceEdge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfluenceEdge1.Location = new System.Drawing.Point(458, 63);
            this.tbInfluenceEdge1.Name = "tbInfluenceEdge1";
            this.tbInfluenceEdge1.Size = new System.Drawing.Size(48, 21);
            this.tbInfluenceEdge1.TabIndex = 3;
            this.tbInfluenceEdge1.Text = "1.0";
            this.tbInfluenceEdge1.TextChanged += new System.EventHandler(this.tbInfluenceEdge1_TextChanged);
            // 
            // tbInfluenceEdge2
            // 
            this.tbInfluenceEdge2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInfluenceEdge2.Location = new System.Drawing.Point(458, 120);
            this.tbInfluenceEdge2.Name = "tbInfluenceEdge2";
            this.tbInfluenceEdge2.Size = new System.Drawing.Size(48, 21);
            this.tbInfluenceEdge2.TabIndex = 6;
            this.tbInfluenceEdge2.Text = "1.0";
            this.tbInfluenceEdge2.TextChanged += new System.EventHandler(this.tbInfluenceEdge2_TextChanged);
            // 
            // chkExtend
            // 
            this.chkExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkExtend.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkExtend.AutoSize = true;
            this.chkExtend.Location = new System.Drawing.Point(6, 23);
            this.chkExtend.Name = "chkExtend";
            this.chkExtend.Size = new System.Drawing.Size(79, 22);
            this.chkExtend.TabIndex = 8;
            this.chkExtend.Text = "늘리기 모드";
            this.chkExtend.UseVisualStyleBackColor = true;
            this.chkExtend.Click += new System.EventHandler(this.chkExtend_Click);
            // 
            // chkBlend
            // 
            this.chkBlend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBlend.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlend.AutoSize = true;
            this.chkBlend.Location = new System.Drawing.Point(6, 23);
            this.chkBlend.Name = "chkBlend";
            this.chkBlend.Size = new System.Drawing.Size(67, 22);
            this.chkBlend.TabIndex = 9;
            this.chkBlend.Text = "혼합 모드";
            this.chkBlend.UseVisualStyleBackColor = true;
            this.chkBlend.CheckedChanged += new System.EventHandler(this.chkBlend_Click);
            // 
            // gbExtension
            // 
            this.gbExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExtension.Controls.Add(this.chkExtend);
            this.gbExtension.Location = new System.Drawing.Point(530, 320);
            this.gbExtension.Name = "gbExtension";
            this.gbExtension.Size = new System.Drawing.Size(92, 168);
            this.gbExtension.TabIndex = 11;
            this.gbExtension.TabStop = false;
            this.gbExtension.Text = "곡면 늘리기";
            // 
            // gbBlend
            // 
            this.gbBlend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBlend.Controls.Add(this.lbInfluenceEdge2);
            this.gbBlend.Controls.Add(this.lbInfluenceEdge1);
            this.gbBlend.Controls.Add(this.chkBlend);
            this.gbBlend.Controls.Add(this.tbInfluenceEdge2);
            this.gbBlend.Controls.Add(this.tbInfluenceEdge1);
            this.gbBlend.Controls.Add(this.trkbInfluenceEdge1);
            this.gbBlend.Controls.Add(this.trkbInfluenceEdge2);
            this.gbBlend.Location = new System.Drawing.Point(12, 320);
            this.gbBlend.Name = "gbBlend";
            this.gbBlend.Size = new System.Drawing.Size(512, 168);
            this.gbBlend.TabIndex = 12;
            this.gbBlend.TabStop = false;
            this.gbBlend.Text = "곡면 연결";
            // 
            // lbInfluenceEdge2
            // 
            this.lbInfluenceEdge2.AutoSize = true;
            this.lbInfluenceEdge2.Location = new System.Drawing.Point(6, 124);
            this.lbInfluenceEdge2.Name = "lbInfluenceEdge2";
            this.lbInfluenceEdge2.Size = new System.Drawing.Size(96, 12);
            this.lbInfluenceEdge2.TabIndex = 11;
            this.lbInfluenceEdge2.Text = "Edge2 영향 거리";
            // 
            // lbInfluenceEdge1
            // 
            this.lbInfluenceEdge1.AutoSize = true;
            this.lbInfluenceEdge1.Location = new System.Drawing.Point(4, 67);
            this.lbInfluenceEdge1.Name = "lbInfluenceEdge1";
            this.lbInfluenceEdge1.Size = new System.Drawing.Size(96, 12);
            this.lbInfluenceEdge1.TabIndex = 10;
            this.lbInfluenceEdge1.Text = "Edge1 영향 거리";
            // 
            // design1
            // 
            this.design1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.design1.Cursor = System.Windows.Forms.Cursors.Default;
            this.design1.Location = new System.Drawing.Point(12, 12);
            this.design1.Name = "design1";
            this.design1.ProgressBar = progressBar3;
            this.design1.Size = new System.Drawing.Size(610, 302);
            this.design1.TabIndex = 10;
            this.design1.Text = "myDesign1";
            this.design1.Viewports.Add(viewport3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 500);
            this.Controls.Add(this.gbBlend);
            this.Controls.Add(this.gbExtension);
            this.Controls.Add(this.design1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkbInfluenceEdge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbInfluenceEdge1)).EndInit();
            this.gbExtension.ResumeLayout(false);
            this.gbExtension.PerformLayout();
            this.gbBlend.ResumeLayout(false);
            this.gbBlend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trkbInfluenceEdge2;
        private System.Windows.Forms.TrackBar trkbInfluenceEdge1;
        private System.Windows.Forms.TextBox tbInfluenceEdge1;
        private System.Windows.Forms.TextBox tbInfluenceEdge2;
        private System.Windows.Forms.CheckBox chkExtend;
        private System.Windows.Forms.CheckBox chkBlend;
        private MyDesign design1;
        private System.Windows.Forms.GroupBox gbExtension;
        private System.Windows.Forms.GroupBox gbBlend;
        private System.Windows.Forms.Label lbInfluenceEdge2;
        private System.Windows.Forms.Label lbInfluenceEdge1;
    }
}

