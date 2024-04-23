
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
            devDept.Eyeshot.Control.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.Control.CancelToolBarButton("Cancel", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ProgressBar progressBar1 = new devDept.Eyeshot.Control.ProgressBar(devDept.Eyeshot.Control.ProgressBar.styleType.Speedometer, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, 0.333D, true);
            devDept.Eyeshot.Control.BackgroundSettings backgroundSettings1 = new devDept.Eyeshot.Control.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Eyeshot.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Eyeshot.projectionType.Perspective, 40D, 3.1399999906012548D, false, 0.001D);
            devDept.Eyeshot.Control.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.Control.HomeToolBarButton("Home", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.Control.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.Control.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.Control.ZoomToolBarButton("Zoom", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.Control.PanToolBarButton("Pan", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.Control.RotateToolBarButton("Rotate", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.Control.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.ToolBar toolBar1 = new devDept.Eyeshot.Control.ToolBar(devDept.Eyeshot.Control.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.Control.ToolBarButton[] {
            ((devDept.Eyeshot.Control.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomFitToolBarButton1))}, 5, 0, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D);
            devDept.Eyeshot.Control.Legend legend1 = new devDept.Eyeshot.Control.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:+0.###;-0.###;0}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, null, null, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, true, false);
            devDept.Eyeshot.Control.Histogram histogram1 = new devDept.Eyeshot.Control.Histogram(30, 80, "Title", System.Drawing.Color.Blue, System.Drawing.Color.Gray, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.LightYellow, false, true, false, "{0:+0.###;-0.###;0}");
            devDept.Eyeshot.Control.Grid grid1 = new devDept.Eyeshot.Control.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.Control.OriginSymbol originSymbol1 = new devDept.Eyeshot.Control.OriginSymbol(10, devDept.Eyeshot.Control.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.Control.RotateSettings rotateSettings1 = new devDept.Eyeshot.Control.RotateSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.Control.ZoomSettings zoomSettings1 = new devDept.Eyeshot.Control.ZoomSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.Control.PanSettings panSettings1 = new devDept.Eyeshot.Control.PanSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.Control.NavigationSettings navigationSettings1 = new devDept.Eyeshot.Control.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Left, devDept.Eyeshot.Control.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Control.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.Control.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.Control.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.Control.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.Control.ViewCubeIcon(devDept.Eyeshot.Control.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D), true);
            devDept.Eyeshot.Control.Viewport viewport1 = new devDept.Eyeshot.Control.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(610, 314), backgroundSettings1, camera1, new devDept.Eyeshot.Control.ToolBar[] {
            toolBar1}, new devDept.Eyeshot.Control.Legend[] {
            legend1}, histogram1, devDept.Eyeshot.displayType.Rendered, true, false, false, new devDept.Eyeshot.Control.Grid[] {
            grid1}, new devDept.Eyeshot.Control.OriginSymbol[] {
            originSymbol1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, coordinateSystemIcon1, viewCubeIcon1, devDept.Eyeshot.viewType.Trimetric);
            this.design1 = new devDept.Eyeshot.Control.Design();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnBlend = new System.Windows.Forms.Button();
            this.trkbExtend = new System.Windows.Forms.TrackBar();
            this.trkbBlend = new System.Windows.Forms.TrackBar();
            this.tbBlend = new System.Windows.Forms.TextBox();
            this.tbExtend = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbExtend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbBlend)).BeginInit();
            this.SuspendLayout();
            // 
            // design1
            // 
            this.design1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.design1.Cursor = System.Windows.Forms.Cursors.Default;
            this.design1.Location = new System.Drawing.Point(12, 12);
            this.design1.Name = "design1";
            this.design1.ProgressBar = progressBar1;
            this.design1.Size = new System.Drawing.Size(610, 314);
            this.design1.TabIndex = 0;
            this.design1.Text = "design1";
            this.design1.Viewports.Add(viewport1);
            // 
            // btnExtend
            // 
            this.btnExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExtend.Location = new System.Drawing.Point(12, 397);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(112, 28);
            this.btnExtend.TabIndex = 4;
            this.btnExtend.Text = "늘리기";
            this.btnExtend.UseVisualStyleBackColor = true;
            // 
            // btnBlend
            // 
            this.btnBlend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlend.Location = new System.Drawing.Point(12, 346);
            this.btnBlend.Name = "btnBlend";
            this.btnBlend.Size = new System.Drawing.Size(112, 28);
            this.btnBlend.TabIndex = 1;
            this.btnBlend.Text = "곡면 연결";
            this.btnBlend.UseVisualStyleBackColor = true;
            // 
            // trkbExtend
            // 
            this.trkbExtend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkbExtend.Location = new System.Drawing.Point(130, 397);
            this.trkbExtend.Name = "trkbExtend";
            this.trkbExtend.Size = new System.Drawing.Size(438, 45);
            this.trkbExtend.TabIndex = 5;
            // 
            // trkbBlend
            // 
            this.trkbBlend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkbBlend.Location = new System.Drawing.Point(130, 346);
            this.trkbBlend.Name = "trkbBlend";
            this.trkbBlend.Size = new System.Drawing.Size(438, 45);
            this.trkbBlend.TabIndex = 2;
            // 
            // tbBlend
            // 
            this.tbBlend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBlend.Location = new System.Drawing.Point(574, 346);
            this.tbBlend.Name = "tbBlend";
            this.tbBlend.Size = new System.Drawing.Size(48, 21);
            this.tbBlend.TabIndex = 3;
            this.tbBlend.Text = "1.0";
            // 
            // tbExtend
            // 
            this.tbExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtend.Location = new System.Drawing.Point(574, 401);
            this.tbExtend.Name = "tbExtend";
            this.tbExtend.Size = new System.Drawing.Size(48, 21);
            this.tbExtend.TabIndex = 6;
            this.tbExtend.Text = "1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tbExtend);
            this.Controls.Add(this.tbBlend);
            this.Controls.Add(this.trkbBlend);
            this.Controls.Add(this.trkbExtend);
            this.Controls.Add(this.btnBlend);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.design1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.design1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbExtend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbBlend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private devDept.Eyeshot.Control.Design design1;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnBlend;
        private System.Windows.Forms.TrackBar trkbExtend;
        private System.Windows.Forms.TrackBar trkbBlend;
        private System.Windows.Forms.TextBox tbBlend;
        private System.Windows.Forms.TextBox tbExtend;
    }
}

