namespace TUUNGANE
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.MinimizepictureBox = new System.Windows.Forms.PictureBox();
            this.MaxpictureBox = new System.Windows.Forms.PictureBox();
            this.ClosepictureBox = new System.Windows.Forms.PictureBox();
            this.RestorepictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DigitClock = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblHrs = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblSecs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.SlideReduce = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestorepictureBox)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideReduce)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.MinimizepictureBox);
            this.panel2.Controls.Add(this.MaxpictureBox);
            this.panel2.Controls.Add(this.ClosepictureBox);
            this.panel2.Controls.Add(this.RestorepictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 38);
            this.panel2.TabIndex = 6;
            // 
            // MinimizepictureBox
            // 
            this.MinimizepictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizepictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizepictureBox.Image = global::TUUNGANE.Properties.Resources.Minimize_Window_64px;
            this.MinimizepictureBox.Location = new System.Drawing.Point(1046, 7);
            this.MinimizepictureBox.Name = "MinimizepictureBox";
            this.MinimizepictureBox.Size = new System.Drawing.Size(25, 25);
            this.MinimizepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizepictureBox.TabIndex = 5;
            this.MinimizepictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizepictureBox, "Minimiser");
            this.MinimizepictureBox.Click += new System.EventHandler(this.MinimizepictureBox_Click);
            // 
            // MaxpictureBox
            // 
            this.MaxpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxpictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxpictureBox.Image = global::TUUNGANE.Properties.Resources.Maximize_Window_50px;
            this.MaxpictureBox.Location = new System.Drawing.Point(1077, 7);
            this.MaxpictureBox.Name = "MaxpictureBox";
            this.MaxpictureBox.Size = new System.Drawing.Size(25, 25);
            this.MaxpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxpictureBox.TabIndex = 4;
            this.MaxpictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.MaxpictureBox, "Etendre");
            this.MaxpictureBox.Click += new System.EventHandler(this.MaxpictureBox_Click);
            // 
            // ClosepictureBox
            // 
            this.ClosepictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClosepictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ClosepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosepictureBox.Image = global::TUUNGANE.Properties.Resources.Close_Window_96px;
            this.ClosepictureBox.Location = new System.Drawing.Point(1109, 7);
            this.ClosepictureBox.Name = "ClosepictureBox";
            this.ClosepictureBox.Size = new System.Drawing.Size(25, 25);
            this.ClosepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosepictureBox.TabIndex = 2;
            this.ClosepictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.ClosepictureBox, "Fermer");
            this.ClosepictureBox.Click += new System.EventHandler(this.ClosepictureBox_Click);
            // 
            // RestorepictureBox
            // 
            this.RestorepictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorepictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RestorepictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestorepictureBox.Image = global::TUUNGANE.Properties.Resources.Restore_Window_50px;
            this.RestorepictureBox.Location = new System.Drawing.Point(1077, 7);
            this.RestorepictureBox.Name = "RestorepictureBox";
            this.RestorepictureBox.Size = new System.Drawing.Size(25, 25);
            this.RestorepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestorepictureBox.TabIndex = 3;
            this.RestorepictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.RestorepictureBox, "Maximiser");
            this.RestorepictureBox.Visible = false;
            this.RestorepictureBox.Click += new System.EventHandler(this.RestorepictureBox_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.DigitClock;
            // 
            // DigitClock
            // 
            this.DigitClock.BackgroundImage = global::TUUNGANE.Properties.Resources.tuungane;
            this.DigitClock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DigitClock.Location = new System.Drawing.Point(446, 84);
            this.DigitClock.Name = "DigitClock";
            this.DigitClock.Size = new System.Drawing.Size(501, 341);
            this.DigitClock.TabIndex = 2;
            this.DigitClock.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Institut TUUNGANE";
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.BackgroundImage = global::TUUNGANE.Properties.Resources._2057a497b07718f;
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.Controls.Add(this.label5);
            this.mainpanel.Controls.Add(this.DigitClock);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Location = new System.Drawing.Point(250, 38);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1126, 692);
            this.mainpanel.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(183, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(847, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "\"A l\'Ecole Primaire TUUNGANE l\'Education et la Formation de vos Enfants c\'est not" +
    "re priorite\"";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "powered by Genius Team";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "       Accueil";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::TUUNGANE.Properties.Resources.Home_50px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 122);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 62);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "       Accueil";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "       Eleves";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::TUUNGANE.Properties.Resources.Students_100px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 222);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 62);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "       Eleves";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "       Payement";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::TUUNGANE.Properties.Resources.Purchase_Order_104px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 319);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(241, 62);
            this.bunifuFlatButton3.TabIndex = 5;
            this.bunifuFlatButton3.Text = "       Payement";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // lblHrs
            // 
            this.lblHrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHrs.AutoSize = true;
            this.lblHrs.BackColor = System.Drawing.Color.Transparent;
            this.lblHrs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHrs.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrs.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblHrs.Location = new System.Drawing.Point(16, 658);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(152, 59);
            this.lblHrs.TabIndex = 6;
            this.lblHrs.Text = "00:00";
            this.toolTip1.SetToolTip(this.lblHrs, "Heure & Minutes");
            this.lblHrs.Click += new System.EventHandler(this.lblHrs_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "       A propos";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::TUUNGANE.Properties.Resources.About1_52px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 430);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(170)))), ((int)(((byte)(245)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(241, 62);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Text = "       A propos";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // lblSecs
            // 
            this.lblSecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSecs.AutoSize = true;
            this.lblSecs.BackColor = System.Drawing.Color.Transparent;
            this.lblSecs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecs.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecs.ForeColor = System.Drawing.Color.Gold;
            this.lblSecs.Location = new System.Drawing.Point(157, 672);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(42, 30);
            this.lblSecs.TabIndex = 7;
            this.lblSecs.Text = "00";
            this.toolTip1.SetToolTip(this.lblSecs, "Secondes");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TUUNGANE.Properties.Resources.Menu_64px;
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("Franklin Gothic Demi", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(43)))));
            this.lblDay.Location = new System.Drawing.Point(84, 537);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(52, 39);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "JJJ";
            this.toolTip1.SetToolTip(this.lblDay, "Jour");
            // 
            // SlideReduce
            // 
            this.SlideReduce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlideReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SlideReduce.Image = global::TUUNGANE.Properties.Resources.Menu_2_50px;
            this.SlideReduce.Location = new System.Drawing.Point(193, 12);
            this.SlideReduce.Name = "SlideReduce";
            this.SlideReduce.Size = new System.Drawing.Size(33, 50);
            this.SlideReduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SlideReduce.TabIndex = 8;
            this.SlideReduce.TabStop = false;
            this.SlideReduce.Visible = false;
            this.SlideReduce.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Yellow;
            this.lblDate.Location = new System.Drawing.Point(16, 593);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(181, 43);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "JJ-MM-AAA";
            this.toolTip1.SetToolTip(this.lblDate, "Jour-mois-annee");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.SlideReduce);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSecs);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.lblHrs);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 730);
            this.panel1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1376, 730);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestorepictureBox)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlideReduce)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MinimizepictureBox;
        private System.Windows.Forms.PictureBox MaxpictureBox;
        private System.Windows.Forms.PictureBox RestorepictureBox;
        private System.Windows.Forms.PictureBox ClosepictureBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel DigitClock;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Label lblHrs;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.PictureBox SlideReduce;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
    }
}