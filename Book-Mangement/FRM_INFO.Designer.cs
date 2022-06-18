namespace Book_Mangement
{
    partial class FRM_INFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_INFO));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IMAGE_COVER = new System.Windows.Forms.PictureBox();
            this.TXT_RATE = new Bunifu.Framework.UI.BunifuRating();
            this.TXT_DATE = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_AUTHER = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_PRICE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TXT_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_CAT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_COVER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.Location = new System.Drawing.Point(1037, 890);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 35);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Upload Photo";
            // 
            // IMAGE_COVER
            // 
            this.IMAGE_COVER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IMAGE_COVER.Location = new System.Drawing.Point(834, 486);
            this.IMAGE_COVER.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.IMAGE_COVER.Name = "IMAGE_COVER";
            this.IMAGE_COVER.Size = new System.Drawing.Size(560, 384);
            this.IMAGE_COVER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMAGE_COVER.TabIndex = 30;
            this.IMAGE_COVER.TabStop = false;
            // 
            // TXT_RATE
            // 
            this.TXT_RATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_RATE.BackColor = System.Drawing.Color.Transparent;
            this.TXT_RATE.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_RATE.ForeColor = System.Drawing.Color.SeaGreen;
            this.TXT_RATE.Location = new System.Drawing.Point(834, 317);
            this.TXT_RATE.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TXT_RATE.Name = "TXT_RATE";
            this.TXT_RATE.Size = new System.Drawing.Size(580, 94);
            this.TXT_RATE.TabIndex = 29;
            this.TXT_RATE.Value = 0;
            // 
            // TXT_DATE
            // 
            this.TXT_DATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_DATE.BackColor = System.Drawing.Color.SeaGreen;
            this.TXT_DATE.BorderRadius = 0;
            this.TXT_DATE.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DATE.ForeColor = System.Drawing.Color.White;
            this.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TXT_DATE.FormatCustom = null;
            this.TXT_DATE.Location = new System.Drawing.Point(834, 155);
            this.TXT_DATE.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.TXT_DATE.Name = "TXT_DATE";
            this.TXT_DATE.Size = new System.Drawing.Size(602, 87);
            this.TXT_DATE.TabIndex = 28;
            this.TXT_DATE.Value = new System.DateTime(2022, 6, 16, 20, 42, 54, 271);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(828, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cover";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(828, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(828, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date";
            // 
            // TXT_AUTHER
            // 
            this.TXT_AUTHER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_AUTHER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_AUTHER.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AUTHER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_AUTHER.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_AUTHER.HintText = "";
            this.TXT_AUTHER.isPassword = false;
            this.TXT_AUTHER.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_AUTHER.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_AUTHER.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_AUTHER.LineThickness = 4;
            this.TXT_AUTHER.Location = new System.Drawing.Point(67, 352);
            this.TXT_AUTHER.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.TXT_AUTHER.Name = "TXT_AUTHER";
            this.TXT_AUTHER.Size = new System.Drawing.Size(602, 68);
            this.TXT_AUTHER.TabIndex = 35;
            this.TXT_AUTHER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(67, 625);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 35);
            this.label5.TabIndex = 38;
            this.label5.Text = "Category";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(67, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 35);
            this.label8.TabIndex = 31;
            this.label8.Text = "Book Name";
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_PRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_PRICE.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PRICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_PRICE.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_PRICE.HintText = "";
            this.TXT_PRICE.isPassword = false;
            this.TXT_PRICE.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_PRICE.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_PRICE.LineThickness = 4;
            this.TXT_PRICE.Location = new System.Drawing.Point(67, 523);
            this.TXT_PRICE.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(602, 68);
            this.TXT_PRICE.TabIndex = 37;
            this.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TXT_name
            // 
            this.TXT_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_name.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_name.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_name.HintText = "";
            this.TXT_name.isPassword = false;
            this.TXT_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_name.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_name.LineThickness = 4;
            this.TXT_name.Location = new System.Drawing.Point(67, 181);
            this.TXT_name.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(602, 68);
            this.TXT_name.TabIndex = 33;
            this.TXT_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(67, 454);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(67, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 35);
            this.label7.TabIndex = 34;
            this.label7.Text = "Auther";
            // 
            // TXT_CAT
            // 
            this.TXT_CAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_CAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXT_CAT.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXT_CAT.HintForeColor = System.Drawing.Color.Empty;
            this.TXT_CAT.HintText = "";
            this.TXT_CAT.isPassword = false;
            this.TXT_CAT.LineFocusedColor = System.Drawing.Color.Blue;
            this.TXT_CAT.LineIdleColor = System.Drawing.Color.Gray;
            this.TXT_CAT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TXT_CAT.LineThickness = 4;
            this.TXT_CAT.Location = new System.Drawing.Point(67, 700);
            this.TXT_CAT.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.TXT_CAT.Name = "TXT_CAT";
            this.TXT_CAT.Size = new System.Drawing.Size(602, 68);
            this.TXT_CAT.TabIndex = 39;
            this.TXT_CAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1464, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 40;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FRM_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1502, 1077);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.TXT_CAT);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.IMAGE_COVER);
            this.Controls.Add(this.TXT_RATE);
            this.Controls.Add(this.TXT_DATE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_AUTHER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_PRICE);
            this.Controls.Add(this.TXT_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FRM_INFO";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_COVER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.PictureBox IMAGE_COVER;
        public Bunifu.Framework.UI.BunifuRating TXT_RATE;
        public Bunifu.Framework.UI.BunifuDatepicker TXT_DATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_AUTHER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_PRICE;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuMaterialTextbox TXT_CAT;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}