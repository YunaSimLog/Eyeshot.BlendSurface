using devDept.Eyeshot;
using devDept.Eyeshot.Control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyeshot.BlendSurface
{
    public class MyDesign : Design
    {
        private string _text;
        private System.Drawing.Point _mouseLocation;

        protected override void DrawOverlay(DrawSceneParams data)
        {
            // 텍스트 그리기
            DrawText(_mouseLocation.X, Size.Height - _mouseLocation.Y + 10, _text, new System.Drawing.Font("Tahoma", 8.25f), Color.Black, ContentAlignment.BottomLeft);

            base.DrawOverlay(data);
        }

        public void SetTipText(string text)
        {
            _text = text;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            _mouseLocation = e.Location;

            // 뷰포트 곡면을 칠한다.
            PaintBackBuffer();

            // Drawings을 통합한다.
            SwapBuffers();

            base.OnMouseMove(e);
        }
    }
}
