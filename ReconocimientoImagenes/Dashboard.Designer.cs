namespace ReconocimientoImagenes
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Menu_Top = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Sidebar_Wrapper = new System.Windows.Forms.Panel();
            this.Menu_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Maximize_btn = new System.Windows.Forms.PictureBox();
            this.Minimize_btn = new System.Windows.Forms.PictureBox();
            this.Restore_btn = new System.Windows.Forms.PictureBox();
            this.Sidebar_gradient = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sidebar_line = new Bunifu.Framework.UI.BunifuSeparator();
            this.Img_Or_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Img_Draw_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Start_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Graphic_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Curve_Sidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Sidebar_Animation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Sidebar_Animation_Back = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Panel_Chart = new System.Windows.Forms.Panel();
            this.Curve_Panel_Chart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Graphic_Comp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Img_Draw_Pb = new System.Windows.Forms.PictureBox();
            this.Img_Or_Pb = new System.Windows.Forms.PictureBox();
            this.Menu_Top.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.Sidebar_Wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restore_btn)).BeginInit();
            this.Sidebar_gradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Draw_Pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Or_Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Top
            // 
            this.Menu_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Menu_Top.Controls.Add(this.Restore_btn);
            this.Menu_Top.Controls.Add(this.Minimize_btn);
            this.Menu_Top.Controls.Add(this.Maximize_btn);
            this.Menu_Top.Controls.Add(this.Close_btn);
            this.Menu_Top.Controls.Add(this.label1);
            this.Menu_Top.Controls.Add(this.Menu_btn);
            this.Sidebar_Animation_Back.SetDecoration(this.Menu_Top, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Menu_Top, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_Top.Location = new System.Drawing.Point(0, 0);
            this.Menu_Top.Name = "Menu_Top";
            this.Menu_Top.Size = new System.Drawing.Size(1386, 58);
            this.Menu_Top.TabIndex = 0;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.Panel_Chart);
            this.Sidebar_Animation_Back.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 58);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1086, 730);
            this.Wrapper.TabIndex = 1;
            this.Wrapper.Click += new System.EventHandler(this.Restore_Click);
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // Sidebar_Wrapper
            // 
            this.Sidebar_Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar_Wrapper.Controls.Add(this.Sidebar_gradient);
            this.Sidebar_Animation_Back.SetDecoration(this.Sidebar_Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Sidebar_Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Wrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar_Wrapper.Location = new System.Drawing.Point(0, 58);
            this.Sidebar_Wrapper.Name = "Sidebar_Wrapper";
            this.Sidebar_Wrapper.Size = new System.Drawing.Size(300, 730);
            this.Sidebar_Wrapper.TabIndex = 1;
            // 
            // Menu_btn
            // 
            this.Sidebar_Animation.SetDecoration(this.Menu_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Menu_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("Menu_btn.Image")));
            this.Menu_btn.Location = new System.Drawing.Point(12, 12);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(30, 30);
            this.Menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.TabStop = false;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_Sidebar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Sidebar_Animation.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar_Animation.SetDecoration(this.Close_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Close_btn, BunifuAnimatorNS.DecorationType.None);
            this.Close_btn.Image = ((System.Drawing.Image)(resources.GetObject("Close_btn.Image")));
            this.Close_btn.Location = new System.Drawing.Point(1344, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(30, 30);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_btn.TabIndex = 2;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_Click);
            // 
            // Maximize_btn
            // 
            this.Maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar_Animation.SetDecoration(this.Maximize_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Maximize_btn, BunifuAnimatorNS.DecorationType.None);
            this.Maximize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_btn.Image")));
            this.Maximize_btn.Location = new System.Drawing.Point(1308, 12);
            this.Maximize_btn.Name = "Maximize_btn";
            this.Maximize_btn.Size = new System.Drawing.Size(30, 30);
            this.Maximize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize_btn.TabIndex = 3;
            this.Maximize_btn.TabStop = false;
            this.Maximize_btn.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar_Animation.SetDecoration(this.Minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Minimize_btn, BunifuAnimatorNS.DecorationType.None);
            this.Minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_btn.Image")));
            this.Minimize_btn.Location = new System.Drawing.Point(1272, 12);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(30, 30);
            this.Minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_btn.TabIndex = 4;
            this.Minimize_btn.TabStop = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Restore_btn
            // 
            this.Restore_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar_Animation.SetDecoration(this.Restore_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Restore_btn, BunifuAnimatorNS.DecorationType.None);
            this.Restore_btn.Image = ((System.Drawing.Image)(resources.GetObject("Restore_btn.Image")));
            this.Restore_btn.Location = new System.Drawing.Point(1308, 12);
            this.Restore_btn.Name = "Restore_btn";
            this.Restore_btn.Size = new System.Drawing.Size(30, 30);
            this.Restore_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restore_btn.TabIndex = 5;
            this.Restore_btn.TabStop = false;
            this.Restore_btn.Visible = false;
            this.Restore_btn.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Sidebar_gradient
            // 
            this.Sidebar_gradient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar_gradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar_gradient.BackgroundImage")));
            this.Sidebar_gradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar_gradient.Controls.Add(this.Graphic_btn);
            this.Sidebar_gradient.Controls.Add(this.Start_btn);
            this.Sidebar_gradient.Controls.Add(this.Img_Draw_btn);
            this.Sidebar_gradient.Controls.Add(this.Img_Or_btn);
            this.Sidebar_gradient.Controls.Add(this.Sidebar_line);
            this.Sidebar_gradient.Controls.Add(this.label2);
            this.Sidebar_gradient.Controls.Add(this.pictureBox1);
            this.Sidebar_Animation_Back.SetDecoration(this.Sidebar_gradient, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Sidebar_gradient, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_gradient.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar_gradient.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar_gradient.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.Sidebar_gradient.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Sidebar_gradient.Location = new System.Drawing.Point(12, 6);
            this.Sidebar_gradient.Name = "Sidebar_gradient";
            this.Sidebar_gradient.Quality = 10;
            this.Sidebar_gradient.Size = new System.Drawing.Size(282, 712);
            this.Sidebar_gradient.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar_Animation.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar_Animation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colonia de abejas";
            // 
            // Sidebar_line
            // 
            this.Sidebar_line.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar_Animation_Back.SetDecoration(this.Sidebar_line, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Sidebar_line, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_line.LineColor = System.Drawing.Color.White;
            this.Sidebar_line.LineThickness = 1;
            this.Sidebar_line.Location = new System.Drawing.Point(3, 63);
            this.Sidebar_line.Name = "Sidebar_line";
            this.Sidebar_line.Size = new System.Drawing.Size(276, 32);
            this.Sidebar_line.TabIndex = 3;
            this.Sidebar_line.Transparency = 255;
            this.Sidebar_line.Vertical = false;
            // 
            // Img_Or_btn
            // 
            this.Img_Or_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Img_Or_btn.BackColor = System.Drawing.Color.Transparent;
            this.Img_Or_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img_Or_btn.BorderRadius = 0;
            this.Img_Or_btn.ButtonText = "    IMAGEN ORIGINAL";
            this.Img_Or_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sidebar_Animation_Back.SetDecoration(this.Img_Or_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Img_Or_btn, BunifuAnimatorNS.DecorationType.None);
            this.Img_Or_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Img_Or_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Img_Or_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Img_Or_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Img_Or_btn.Iconimage")));
            this.Img_Or_btn.Iconimage_right = null;
            this.Img_Or_btn.Iconimage_right_Selected = null;
            this.Img_Or_btn.Iconimage_Selected = null;
            this.Img_Or_btn.IconMarginLeft = 0;
            this.Img_Or_btn.IconMarginRight = 0;
            this.Img_Or_btn.IconRightVisible = true;
            this.Img_Or_btn.IconRightZoom = 0D;
            this.Img_Or_btn.IconVisible = true;
            this.Img_Or_btn.IconZoom = 60D;
            this.Img_Or_btn.IsTab = false;
            this.Img_Or_btn.Location = new System.Drawing.Point(12, 119);
            this.Img_Or_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Img_Or_btn.Name = "Img_Or_btn";
            this.Img_Or_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Img_Or_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Img_Or_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Img_Or_btn.selected = false;
            this.Img_Or_btn.Size = new System.Drawing.Size(248, 34);
            this.Img_Or_btn.TabIndex = 4;
            this.Img_Or_btn.Text = "    IMAGEN ORIGINAL";
            this.Img_Or_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Img_Or_btn.Textcolor = System.Drawing.Color.White;
            this.Img_Or_btn.TextFont = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Img_Or_btn.Click += new System.EventHandler(this.Open_FileDialog);
            // 
            // Img_Draw_btn
            // 
            this.Img_Draw_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Img_Draw_btn.BackColor = System.Drawing.Color.Transparent;
            this.Img_Draw_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img_Draw_btn.BorderRadius = 0;
            this.Img_Draw_btn.ButtonText = "    IMAGEN MODIFICADA";
            this.Img_Draw_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sidebar_Animation_Back.SetDecoration(this.Img_Draw_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Img_Draw_btn, BunifuAnimatorNS.DecorationType.None);
            this.Img_Draw_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Img_Draw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Img_Draw_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Img_Draw_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Img_Draw_btn.Iconimage")));
            this.Img_Draw_btn.Iconimage_right = null;
            this.Img_Draw_btn.Iconimage_right_Selected = null;
            this.Img_Draw_btn.Iconimage_Selected = null;
            this.Img_Draw_btn.IconMarginLeft = 0;
            this.Img_Draw_btn.IconMarginRight = 0;
            this.Img_Draw_btn.IconRightVisible = true;
            this.Img_Draw_btn.IconRightZoom = 0D;
            this.Img_Draw_btn.IconVisible = true;
            this.Img_Draw_btn.IconZoom = 60D;
            this.Img_Draw_btn.IsTab = false;
            this.Img_Draw_btn.Location = new System.Drawing.Point(12, 165);
            this.Img_Draw_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Img_Draw_btn.Name = "Img_Draw_btn";
            this.Img_Draw_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Img_Draw_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Img_Draw_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Img_Draw_btn.selected = false;
            this.Img_Draw_btn.Size = new System.Drawing.Size(248, 34);
            this.Img_Draw_btn.TabIndex = 5;
            this.Img_Draw_btn.Text = "    IMAGEN MODIFICADA";
            this.Img_Draw_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Img_Draw_btn.Textcolor = System.Drawing.Color.White;
            this.Img_Draw_btn.TextFont = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Img_Draw_btn.Click += new System.EventHandler(this.Open_FileDialog);
            // 
            // Start_btn
            // 
            this.Start_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Start_btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start_btn.BorderRadius = 0;
            this.Start_btn.ButtonText = "    INICIAR";
            this.Start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sidebar_Animation_Back.SetDecoration(this.Start_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Start_btn, BunifuAnimatorNS.DecorationType.None);
            this.Start_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Start_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Start_btn.Iconimage")));
            this.Start_btn.Iconimage_right = null;
            this.Start_btn.Iconimage_right_Selected = null;
            this.Start_btn.Iconimage_Selected = null;
            this.Start_btn.IconMarginLeft = 0;
            this.Start_btn.IconMarginRight = 0;
            this.Start_btn.IconRightVisible = true;
            this.Start_btn.IconRightZoom = 0D;
            this.Start_btn.IconVisible = true;
            this.Start_btn.IconZoom = 60D;
            this.Start_btn.IsTab = false;
            this.Start_btn.Location = new System.Drawing.Point(12, 211);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Start_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Start_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Start_btn.selected = false;
            this.Start_btn.Size = new System.Drawing.Size(248, 34);
            this.Start_btn.TabIndex = 6;
            this.Start_btn.Text = "    INICIAR";
            this.Start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_btn.Textcolor = System.Drawing.Color.White;
            this.Start_btn.TextFont = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Graphic_btn
            // 
            this.Graphic_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Graphic_btn.BackColor = System.Drawing.Color.Transparent;
            this.Graphic_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Graphic_btn.BorderRadius = 0;
            this.Graphic_btn.ButtonText = "    RENDIMIENTO";
            this.Graphic_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sidebar_Animation_Back.SetDecoration(this.Graphic_btn, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Graphic_btn, BunifuAnimatorNS.DecorationType.None);
            this.Graphic_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Graphic_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphic_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Graphic_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Graphic_btn.Iconimage")));
            this.Graphic_btn.Iconimage_right = null;
            this.Graphic_btn.Iconimage_right_Selected = null;
            this.Graphic_btn.Iconimage_Selected = null;
            this.Graphic_btn.IconMarginLeft = 0;
            this.Graphic_btn.IconMarginRight = 0;
            this.Graphic_btn.IconRightVisible = true;
            this.Graphic_btn.IconRightZoom = 0D;
            this.Graphic_btn.IconVisible = true;
            this.Graphic_btn.IconZoom = 60D;
            this.Graphic_btn.IsTab = false;
            this.Graphic_btn.Location = new System.Drawing.Point(12, 257);
            this.Graphic_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Graphic_btn.Name = "Graphic_btn";
            this.Graphic_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Graphic_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Graphic_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Graphic_btn.selected = false;
            this.Graphic_btn.Size = new System.Drawing.Size(248, 34);
            this.Graphic_btn.TabIndex = 7;
            this.Graphic_btn.Text = "    RENDIMIENTO";
            this.Graphic_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Graphic_btn.Textcolor = System.Drawing.Color.White;
            this.Graphic_btn.TextFont = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graphic_btn.Click += new System.EventHandler(this.Hidden_Show_Graphics);
            // 
            // Curve_Sidebar
            // 
            this.Curve_Sidebar.ElipseRadius = 6;
            this.Curve_Sidebar.TargetControl = this.Sidebar_gradient;
            // 
            // Sidebar_Animation
            // 
            this.Sidebar_Animation.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Sidebar_Animation.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.Sidebar_Animation.DefaultAnimation = animation9;
            // 
            // Sidebar_Animation_Back
            // 
            this.Sidebar_Animation_Back.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Sidebar_Animation_Back.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.Sidebar_Animation_Back.DefaultAnimation = animation10;
            // 
            // Panel_Chart
            // 
            this.Panel_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Chart.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Chart.Controls.Add(this.Img_Or_Pb);
            this.Panel_Chart.Controls.Add(this.Img_Draw_Pb);
            this.Panel_Chart.Controls.Add(this.Graphic_Comp);
            this.Sidebar_Animation_Back.SetDecoration(this.Panel_Chart, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Panel_Chart, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Chart.Location = new System.Drawing.Point(18, 6);
            this.Panel_Chart.Name = "Panel_Chart";
            this.Panel_Chart.Size = new System.Drawing.Size(1056, 712);
            this.Panel_Chart.TabIndex = 0;
            // 
            // Curve_Panel_Chart
            // 
            this.Curve_Panel_Chart.ElipseRadius = 6;
            this.Curve_Panel_Chart.TargetControl = this.Panel_Chart;
            // 
            // Graphic_Comp
            // 
            this.Graphic_Comp.BackColor = System.Drawing.Color.Transparent;
            this.Graphic_Comp.BorderlineWidth = 0;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.Graphic_Comp.ChartAreas.Add(chartArea5);
            this.Sidebar_Animation_Back.SetDecoration(this.Graphic_Comp, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation.SetDecoration(this.Graphic_Comp, BunifuAnimatorNS.DecorationType.None);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.Graphic_Comp.Legends.Add(legend5);
            this.Graphic_Comp.Location = new System.Drawing.Point(12, 80);
            this.Graphic_Comp.Name = "Graphic_Comp";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            series5.Legend = "Legend1";
            series5.Name = "Chart_Graphic";
            this.Graphic_Comp.Series.Add(series5);
            this.Graphic_Comp.Size = new System.Drawing.Size(1027, 576);
            this.Graphic_Comp.TabIndex = 0;
            this.Graphic_Comp.Text = "chart1";
            this.Graphic_Comp.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Img_Draw_Pb
            // 
            this.Sidebar_Animation.SetDecoration(this.Img_Draw_Pb, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Img_Draw_Pb, BunifuAnimatorNS.DecorationType.None);
            this.Img_Draw_Pb.Location = new System.Drawing.Point(12, 11);
            this.Img_Draw_Pb.Name = "Img_Draw_Pb";
            this.Img_Draw_Pb.Size = new System.Drawing.Size(510, 510);
            this.Img_Draw_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Draw_Pb.TabIndex = 1;
            this.Img_Draw_Pb.TabStop = false;
            // 
            // Img_Or_Pb
            // 
            this.Sidebar_Animation.SetDecoration(this.Img_Or_Pb, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this.Img_Or_Pb, BunifuAnimatorNS.DecorationType.None);
            this.Img_Or_Pb.Location = new System.Drawing.Point(533, 11);
            this.Img_Or_Pb.Name = "Img_Or_Pb";
            this.Img_Or_Pb.Size = new System.Drawing.Size(510, 510);
            this.Img_Or_Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Or_Pb.TabIndex = 2;
            this.Img_Or_Pb.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.Sidebar_Wrapper);
            this.Controls.Add(this.Menu_Top);
            this.Sidebar_Animation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Animation_Back.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconocimiento de imagenes";
            this.Menu_Top.ResumeLayout(false);
            this.Menu_Top.PerformLayout();
            this.Wrapper.ResumeLayout(false);
            this.Sidebar_Wrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restore_btn)).EndInit();
            this.Sidebar_gradient.ResumeLayout(false);
            this.Sidebar_gradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graphic_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Draw_Pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Or_Pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Top;
        private System.Windows.Forms.PictureBox Restore_btn;
        private System.Windows.Forms.PictureBox Minimize_btn;
        private System.Windows.Forms.PictureBox Maximize_btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Menu_btn;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel Sidebar_Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar_gradient;
        private Bunifu.Framework.UI.BunifuSeparator Sidebar_line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton Graphic_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Start_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Img_Draw_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Img_Or_btn;
        private Bunifu.Framework.UI.BunifuElipse Curve_Sidebar;
        private BunifuAnimatorNS.BunifuTransition Sidebar_Animation;
        private BunifuAnimatorNS.BunifuTransition Sidebar_Animation_Back;
        private System.Windows.Forms.Panel Panel_Chart;
        private Bunifu.Framework.UI.BunifuElipse Curve_Panel_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic_Comp;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Img_Or_Pb;
        private System.Windows.Forms.PictureBox Img_Draw_Pb;
    }
}

