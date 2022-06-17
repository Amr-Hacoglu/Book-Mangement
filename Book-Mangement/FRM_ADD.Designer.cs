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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_CAT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_AUTHER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TXT_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IMAGE_COVER = new System.Windows.Forms.PictureBox();
            this.TXT_RATE = new Bunifu.Framework.UI.BunifuRating();
            this.TXT_DATE = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTBInsertIntoInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_COVER)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(726, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 9);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(684, 15);
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
            this.panel3.Size = new System.Drawing.Size(726, 596);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_CAT);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TXT_AUTHER);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TXT_PRICE);
            this.groupBox2.Controls.Add(this.TXT_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.bunifuTransition1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(39, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(301, 556);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TXT_CAT
            // 
            this.bunifuTransition1.SetDecoration(this.TXT_CAT, BunifuAnimatorNS.DecorationType.None);
            this.TXT_CAT.FormattingEnabled = true;
            this.TXT_CAT.Location = new System.Drawing.Point(0, 444);
            this.TXT_CAT.Name = "TXT_CAT";
            this.TXT_CAT.Size = new System.Drawing.Size(301, 36);
            this.TXT_CAT.TabIndex = 24;
            this.TXT_CAT.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // TXT_AUTHER
            // 
            this.TXT_AUTHER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.TXT_AUTHER, BunifuAnimatorNS.DecorationType.None);
            this.TXT_AUTHER.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AUTHER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_AUTHER.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_AUTHER.HintText = "";
            this.TXT_AUTHER.isPassword = false;
            this.TXT_AUTHER.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_AUTHER.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_AUTHER.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_AUTHER.LineThickness = 4;
            this.TXT_AUTHER.Location = new System.Drawing.Point(0, 228);
            this.TXT_AUTHER.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_AUTHER.Name = "TXT_AUTHER";
            this.TXT_AUTHER.Size = new System.Drawing.Size(301, 34);
            this.TXT_AUTHER.TabIndex = 18;
            this.TXT_AUTHER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_AUTHER.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
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
            // TXT_PRICE
            // 
            this.TXT_PRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.TXT_PRICE, BunifuAnimatorNS.DecorationType.None);
            this.TXT_PRICE.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_PRICE.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_PRICE.HintText = "";
            this.TXT_PRICE.isPassword = false;
            this.TXT_PRICE.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_PRICE.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineThickness = 4;
            this.TXT_PRICE.Location = new System.Drawing.Point(0, 340);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(301, 34);
            this.TXT_PRICE.TabIndex = 20;
            this.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_PRICE.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // TXT_name
            // 
            this.TXT_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.TXT_name, BunifuAnimatorNS.DecorationType.None);
            this.TXT_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_name.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_name.HintText = "";
            this.TXT_name.isPassword = false;
            this.TXT_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_name.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_name.LineThickness = 4;
            this.TXT_name.Location = new System.Drawing.Point(0, 116);
            this.TXT_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(301, 34);
            this.TXT_name.TabIndex = 16;
            this.TXT_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXT_name.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox8_OnValueChanged);
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
            this.groupBox1.Controls.Add(this.IMAGE_COVER);
            this.groupBox1.Controls.Add(this.TXT_RATE);
            this.groupBox1.Controls.Add(this.TXT_DATE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(380, 18);
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
            // IMAGE_COVER
            // 
            this.bunifuTransition1.SetDecoration(this.IMAGE_COVER, BunifuAnimatorNS.DecorationType.None);
            this.IMAGE_COVER.Image = ((System.Drawing.Image)(resources.GetObject("IMAGE_COVER.Image")));
            this.IMAGE_COVER.Location = new System.Drawing.Point(11, 318);
            this.IMAGE_COVER.Name = "IMAGE_COVER";
            this.IMAGE_COVER.Size = new System.Drawing.Size(280, 192);
            this.IMAGE_COVER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMAGE_COVER.TabIndex = 15;
            this.IMAGE_COVER.TabStop = false;
            this.IMAGE_COVER.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXT_RATE
            // 
            this.TXT_RATE.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.TXT_RATE, BunifuAnimatorNS.DecorationType.None);
            this.TXT_RATE.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_RATE.ForeColor = System.Drawing.Color.SeaGreen;
            this.TXT_RATE.Location = new System.Drawing.Point(11, 215);
            this.TXT_RATE.Margin = new System.Windows.Forms.Padding(7);
            this.TXT_RATE.Name = "TXT_RATE";
            this.TXT_RATE.Size = new System.Drawing.Size(290, 47);
            this.TXT_RATE.TabIndex = 14;
            this.TXT_RATE.Value = 0;
            this.TXT_RATE.onValueChanged += new System.EventHandler(this.bunifuRating1_onValueChanged);
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.BackColor = System.Drawing.Color.SeaGreen;
            this.TXT_DATE.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.TXT_DATE, BunifuAnimatorNS.DecorationType.None);
            this.TXT_DATE.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DATE.ForeColor = System.Drawing.Color.White;
            this.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TXT_DATE.FormatCustom = null;
            this.TXT_DATE.Location = new System.Drawing.Point(0, 116);
            this.TXT_DATE.Margin = new System.Windows.Forms.Padding(7);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.Size = new System.Drawing.Size(301, 44);
            this.TXT_DATE.TabIndex = 13;
            this.TXT_DATE.Value = new System.DateTime(2022, 6, 16, 20, 42, 54, 271);
            this.TXT_DATE.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
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
            this.panel2.Controls.Add(this.BTBInsertIntoInsert);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 120);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BTBInsertIntoInsert
            // 
            this.BTBInsertIntoInsert.ActiveBorderThickness = 1;
            this.BTBInsertIntoInsert.ActiveCornerRadius = 20;
            this.BTBInsertIntoInsert.ActiveFillColor = System.Drawing.Color.DarkCyan;
            this.BTBInsertIntoInsert.ActiveForecolor = System.Drawing.Color.White;
            this.BTBInsertIntoInsert.ActiveLineColor = System.Drawing.Color.DarkCyan;
            this.BTBInsertIntoInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTBInsertIntoInsert.BackColor = System.Drawing.Color.White;
            this.BTBInsertIntoInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTBInsertIntoInsert.BackgroundImage")));
            this.BTBInsertIntoInsert.ButtonText = "Insert";
            this.BTBInsertIntoInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BTBInsertIntoInsert, BunifuAnimatorNS.DecorationType.None);
            this.BTBInsertIntoInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBInsertIntoInsert.ForeColor = System.Drawing.Color.DarkCyan;
            this.BTBInsertIntoInsert.IdleBorderThickness = 1;
            this.BTBInsertIntoInsert.IdleCornerRadius = 20;
            this.BTBInsertIntoInsert.IdleFillColor = System.Drawing.Color.White;
            this.BTBInsertIntoInsert.IdleForecolor = System.Drawing.Color.DarkCyan;
            this.BTBInsertIntoInsert.IdleLineColor = System.Drawing.Color.DarkCyan;
            this.BTBInsertIntoInsert.Location = new System.Drawing.Point(163, 17);
            this.BTBInsertIntoInsert.Margin = new System.Windows.Forms.Padding(6);
            this.BTBInsertIntoInsert.Name = "BTBInsertIntoInsert";
            this.BTBInsertIntoInsert.Size = new System.Drawing.Size(401, 80);
            this.BTBInsertIntoInsert.TabIndex = 5;
            this.BTBInsertIntoInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTBInsertIntoInsert.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 4;
            // 
            // FRM_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 772);
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
            this.Load += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_COVER)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_PRICE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker TXT_DATE;
        private Bunifu.Framework.UI.BunifuRating TXT_RATE;
        private System.Windows.Forms.PictureBox IMAGE_COVER;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TXT_AUTHER;
        private System.Windows.Forms.ComboBox TXT_CAT;
        public Bunifu.Framework.UI.BunifuThinButton2 BTBInsertIntoInsert;
    }
}