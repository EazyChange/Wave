namespace Wave
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.光标前置零ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.marksTip1 = new Steema.TeeChart.Tools.MarksTip();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.cursorTool2 = new Steema.TeeChart.Tools.CursorTool();
            this.marksTip2 = new Steema.TeeChart.Tools.MarksTip();
            this.colorBand1 = new Steema.TeeChart.Tools.ColorBand();
            this.bannerTool1 = new Steema.TeeChart.Tools.BannerTool();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.光标前置零ToolStripMenuItem,
            this.切除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 光标前置零ToolStripMenuItem
            // 
            this.光标前置零ToolStripMenuItem.Name = "光标前置零ToolStripMenuItem";
            this.光标前置零ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.光标前置零ToolStripMenuItem.Text = "光标前置零";
            this.光标前置零ToolStripMenuItem.Click += new System.EventHandler(this.光标前置零ToolStripMenuItem_Click);
            // 
            // 切除ToolStripMenuItem
            // 
            this.切除ToolStripMenuItem.Name = "切除ToolStripMenuItem";
            this.切除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.切除ToolStripMenuItem.Text = "切除";
            this.切除ToolStripMenuItem.Click += new System.EventHandler(this.切除ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采集列表：";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(6, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(231, 320);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件信息：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.richTextBox1.Location = new System.Drawing.Point(6, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(231, 213);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "测试按钮可以去除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 623);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(237, 37);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "应用操作到其他文件";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ColorPaletteIndex = 20;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            this.tChart1.Axes.Automatic = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Caption = "s/时间";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "s/时间"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.DrawEvery = 2;
            this.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Angle = 0;
            this.tChart1.Axes.Left.Title.Caption = "V";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Left.Title.Lines = new string[] {
        "V"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Right.Labels.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Top.Labels.Visible = false;
            this.tChart1.ContextMenuStrip = this.contextMenuStrip1;
            this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            this.tChart1.Header.Lines = new string[] {
        "全程波形图"};
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Legend.Transparent = true;
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(270, 12);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.Visible = false;
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(1276, 214);
            this.tChart1.TabIndex = 7;
            this.tChart1.Tools.Add(this.cursorTool1);
            this.tChart1.Tools.Add(this.marksTip1);
            this.tChart1.Tools.Add(this.colorBand1);
            this.tChart1.Tools.Add(this.bannerTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Visible = false;
            this.tChart1.Walls.Back.Transparent = true;
            this.tChart1.Walls.Back.Visible = false;
            // 
            // 
            // 
            this.tChart1.Zoom.Direction = Steema.TeeChart.ZoomDirections.None;
            this.tChart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseDown);
            this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
            this.tChart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseUp);
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.ColorEach = false;
            this.line1.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.line1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.line1.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.line1.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.line1.Marks.TailParams.Margin = 0F;
            this.line1.Marks.TailParams.PointerHeight = 5D;
            this.line1.Marks.TailParams.PointerWidth = 8D;
            this.line1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.line1.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
            this.line1.Title = "线条图1";
            this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // cursorTool1
            // 
            this.cursorTool1.CursorClickTolerance = 0;
            this.cursorTool1.FollowMouse = true;
            this.cursorTool1.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.cursorTool1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            // 
            // marksTip1
            // 
            this.marksTip1.Series = this.line1;
            this.marksTip1.Style = Steema.TeeChart.Styles.MarksStyles.XY;
            // 
            // tChart2
            // 
            // 
            // 
            // 
            this.tChart2.Aspect.ColorPaletteIndex = 20;
            this.tChart2.Aspect.View3D = false;
            // 
            // 
            // 
            this.tChart2.Axes.Automatic = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Grid.DrawEvery = 2;
            this.tChart2.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Caption = "s/时间";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Bottom.Title.Font.Size = 11;
            this.tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Bottom.Title.Lines = new string[] {
        "s/时间"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Grid.DrawEvery = 2;
            this.tChart2.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart2.Axes.Left.Labels.Font.Size = 9;
            this.tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart2.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Angle = 0;
            this.tChart2.Axes.Left.Title.Caption = "V";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Left.Title.Font.Size = 11;
            this.tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Left.Title.Lines = new string[] {
        "V"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Right.Labels.Font.Size = 9;
            this.tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Right.Labels.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Top.Labels.Font.Size = 9;
            this.tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Top.Labels.Visible = false;
            this.tChart2.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            this.tChart2.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart2.Header.Font.Size = 12;
            this.tChart2.Header.Font.SizeFloat = 12F;
            this.tChart2.Header.Lines = new string[] {
        "波形图"};
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Legend.Font.Size = 9;
            this.tChart2.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart2.Legend.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Legend.Shadow.Visible = false;
            this.tChart2.Legend.Transparent = true;
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(270, 232);
            this.tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Gradient.Visible = false;
            this.tChart2.Series.Add(this.line2);
            this.tChart2.Size = new System.Drawing.Size(1276, 371);
            this.tChart2.TabIndex = 8;
            this.tChart2.Tools.Add(this.cursorTool2);
            this.tChart2.Tools.Add(this.marksTip2);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.Brush.Visible = false;
            this.tChart2.Walls.Back.Transparent = true;
            this.tChart2.Walls.Back.Visible = false;
            // 
            // 
            // 
            this.tChart2.Zoom.Animated = true;
            this.tChart2.Zoom.Direction = Steema.TeeChart.ZoomDirections.Horizontal;
            this.tChart2.Zoom.History = true;
            // 
            // line2
            // 
            // 
            // 
            // 
            this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.line2.ColorEach = false;
            this.line2.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Both;
            // 
            // 
            // 
            this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.line2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.line2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.line2.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.line2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            // 
            // 
            // 
            this.line2.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.line2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line2.Marks.TailParams.Margin = 0F;
            this.line2.Marks.TailParams.PointerHeight = 5D;
            this.line2.Marks.TailParams.PointerWidth = 8D;
            this.line2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.line2.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.line2.Pointer.SizeDouble = 0D;
            this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line2.RecalcOptions = ((Steema.TeeChart.Styles.RecalcOptions)((((Steema.TeeChart.Styles.RecalcOptions.OnDelete | Steema.TeeChart.Styles.RecalcOptions.OnModify) 
            | Steema.TeeChart.Styles.RecalcOptions.OnInsert) 
            | Steema.TeeChart.Styles.RecalcOptions.OnClear)));
            this.line2.Title = "线条图1";
            this.line2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Both;
            // 
            // 
            // 
            this.line2.XValues.DataMember = "X";
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line2.YValues.DataMember = "Y";
            // 
            // cursorTool2
            // 
            this.cursorTool2.CursorClickTolerance = 0;
            this.cursorTool2.FollowMouse = true;
            this.cursorTool2.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.cursorTool2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cursorTool2.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            // 
            // marksTip2
            // 
            this.marksTip2.Series = this.line2;
            this.marksTip2.Style = Steema.TeeChart.Styles.MarksStyles.XY;
            // 
            // colorBand1
            // 
            this.colorBand1.Axis = this.tChart1.Axes.Bottom;
            // 
            // 
            // 
            this.colorBand1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.colorBand1.Brush.Solid = false;
            this.colorBand1.Brush.Style = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.colorBand1.End = 0D;
            // 
            // 
            // 
            this.colorBand1.Pen.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.colorBand1.ResizeEnd = true;
            this.colorBand1.ResizeStart = true;
            this.colorBand1.Start = 0D;
            // 
            // bannerTool1
            // 
            this.bannerTool1.Active = false;
            this.bannerTool1.AutoSize = true;
            // 
            // 
            // 
            this.bannerTool1.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.bannerTool1.Callout.ArrowHeadDirection = Steema.TeeChart.Styles.ArrowHeadDirection.FromPoint;
            this.bannerTool1.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.bannerTool1.Callout.Brush.Color = System.Drawing.Color.Black;
            this.bannerTool1.Callout.Distance = 0;
            this.bannerTool1.Callout.Draw3D = false;
            this.bannerTool1.Callout.SizeDouble = 0D;
            this.bannerTool1.Callout.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.bannerTool1.Callout.XPosition = 0;
            this.bannerTool1.Callout.YPosition = 0;
            this.bannerTool1.Callout.ZPosition = 0;
            this.bannerTool1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bannerTool1.Left = 10;
            // 
            // 
            // 
            this.bannerTool1.Shape.Bottom = 27;
            this.bannerTool1.Shape.CustomPosition = true;
            this.bannerTool1.Shape.Left = 10;
            this.bannerTool1.Shape.Right = 23;
            this.bannerTool1.Shape.Top = 8;
            this.bannerTool1.Top = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 672);
            this.Controls.Add(this.tChart2);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 光标前置零ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切除ToolStripMenuItem;
        private System.Windows.Forms.Button btnApply;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Tools.CursorTool cursorTool1;
        private Steema.TeeChart.Tools.MarksTip marksTip1;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Tools.CursorTool cursorTool2;
        private Steema.TeeChart.Tools.MarksTip marksTip2;
        private Steema.TeeChart.Tools.ColorBand colorBand1;
        private Steema.TeeChart.Tools.BannerTool bannerTool1;
    }
}