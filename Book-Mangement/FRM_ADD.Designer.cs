namespace Book_Mangement
{
    partial class FRM_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox7 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Inserting Book";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(639, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 596);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.bunifuMaterialTextbox7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.bunifuMaterialTextbox6);
            this.groupBox2.Controls.Add(this.bunifuMaterialTextbox8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(23, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(301, 556);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBox1
            // 
            this.bunifuTransition1.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 36);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuMaterialTextbox7
            // 
            this.bunifuMaterialTextbox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox7.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox7.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox7.HintText = "";
            this.bunifuMaterialTextbox7.isPassword = false;
            this.bunifuMaterialTextbox7.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox7.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox7.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox7.LineThickness = 4;
            this.bunifuMaterialTextbox7.Location = new System.Drawing.Point(0, 228);
            this.bunifuMaterialTextbox7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox7.Name = "bunifuMaterialTextbox7";
            this.bunifuMaterialTextbox7.Size = new System.Drawing.Size(301, 34);
            this.bunifuMaterialTextbox7.TabIndex = 18;
            this.bunifuMaterialTextbox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox7.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(6, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bunifuMaterialTextbox6
            // 
            this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox6.HintText = "";
            this.bunifuMaterialTextbox6.isPassword = false;
            this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox6.LineThickness = 4;
            this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(0, 340);
            this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
            this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(301, 34);
            this.bunifuMaterialTextbox6.TabIndex = 20;
            this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox6.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // bunifuMaterialTextbox8
            // 
            this.bunifuMaterialTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox8.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox8.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox8.HintText = "";
            this.bunifuMaterialTextbox8.isPassword = false;
            this.bunifuMaterialTextbox8.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox8.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox8.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox8.LineThickness = 4;
            this.bunifuMaterialTextbox8.Location = new System.Drawing.Point(0, 116);
            this.bunifuMaterialTextbox8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox8.Name = "bunifuMaterialTextbox8";
            this.bunifuMaterialTextbox8.Size = new System.Drawing.Size(301, 34);
            this.bunifuMaterialTextbox8.TabIndex = 16;
            this.bunifuMaterialTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox8.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox8_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(6, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Auther";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bunifuRating1);
            this.groupBox1.Controls.Add(this.bunifuDatepicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(354, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(301, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secondery Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Location = new System.Drawing.Point(69, 519);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 28);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Upload Photo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuRating1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuRating1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(11, 215);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(290, 47);
            this.bunifuRating1.TabIndex = 14;
            this.bunifuRating1.Value = 0;
            this.bunifuRating1.onValueChanged += new System.EventHandler(this.bunifuRating1_onValueChanged);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.bunifuDatepicker1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(0, 116);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(301, 44);
            this.bunifuDatepicker1.TabIndex = 13;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 6, 16, 20, 42, 54, 271);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cover";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 116);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(301, 34);
            this.bunifuMaterialTextbox1.TabIndex = 8;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuThinButton22);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 120);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Insert";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.DarkCyan;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.bunifuThinButton22.Location = new System.Drawing.Point(140, 17);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(401, 80);
            this.bunifuThinButton22.TabIndex = 5;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(246, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 38);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 4;
            // 
            // FRM_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 772);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRM_ADD";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}