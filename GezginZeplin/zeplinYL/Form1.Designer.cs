namespace zeplinYL
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nereden = new System.Windows.Forms.Label();
            this.Nereye = new System.Windows.Forms.Label();
            this.CbNereden = new System.Windows.Forms.ComboBox();
            this.CbNereye = new System.Windows.Forms.ComboBox();
            this.cozumList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProb1 = new System.Windows.Forms.Button();
            this.BtnProb2 = new System.Windows.Forms.Button();
            this.lblProb1 = new System.Windows.Forms.Label();
            this.LblProb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nereden
            // 
            this.Nereden.AutoSize = true;
            this.Nereden.Location = new System.Drawing.Point(12, 41);
            this.Nereden.Name = "Nereden";
            this.Nereden.Size = new System.Drawing.Size(48, 13);
            this.Nereden.TabIndex = 2;
            this.Nereden.Text = "Nereden";
            // 
            // Nereye
            // 
            this.Nereye.AutoSize = true;
            this.Nereye.Location = new System.Drawing.Point(12, 99);
            this.Nereye.Name = "Nereye";
            this.Nereye.Size = new System.Drawing.Size(41, 13);
            this.Nereye.TabIndex = 3;
            this.Nereye.Text = "Nereye";
            // 
            // CbNereden
            // 
            this.CbNereden.BackColor = System.Drawing.SystemColors.Window;
            this.CbNereden.FormattingEnabled = true;
            this.CbNereden.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.CbNereden.Location = new System.Drawing.Point(12, 57);
            this.CbNereden.Name = "CbNereden";
            this.CbNereden.Size = new System.Drawing.Size(155, 21);
            this.CbNereden.TabIndex = 4;
            this.CbNereden.SelectedIndexChanged += new System.EventHandler(this.CbNereden_SelectedIndexChanged);
            // 
            // CbNereye
            // 
            this.CbNereye.FormattingEnabled = true;
            this.CbNereye.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.CbNereye.Location = new System.Drawing.Point(12, 115);
            this.CbNereye.Name = "CbNereye";
            this.CbNereye.Size = new System.Drawing.Size(155, 21);
            this.CbNereye.TabIndex = 5;
            this.CbNereye.SelectedIndexChanged += new System.EventHandler(this.CbNereye_SelectedIndexChanged);
            // 
            // cozumList
            // 
            this.cozumList.FormattingEnabled = true;
            this.cozumList.Location = new System.Drawing.Point(15, 261);
            this.cozumList.Name = "cozumList";
            this.cozumList.Size = new System.Drawing.Size(155, 186);
            this.cozumList.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(188, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 356);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BtnProb1
            // 
            this.BtnProb1.Location = new System.Drawing.Point(12, 157);
            this.BtnProb1.Name = "BtnProb1";
            this.BtnProb1.Size = new System.Drawing.Size(155, 23);
            this.BtnProb1.TabIndex = 8;
            this.BtnProb1.Text = "Çözüm Problem 1";
            this.BtnProb1.UseVisualStyleBackColor = true;
            this.BtnProb1.Click += new System.EventHandler(this.BtnProb1_Click);
            // 
            // BtnProb2
            // 
            this.BtnProb2.Location = new System.Drawing.Point(15, 208);
            this.BtnProb2.Name = "BtnProb2";
            this.BtnProb2.Size = new System.Drawing.Size(155, 23);
            this.BtnProb2.TabIndex = 9;
            this.BtnProb2.Text = "Çözüm Problem 2";
            this.BtnProb2.UseVisualStyleBackColor = true;
            this.BtnProb2.Click += new System.EventHandler(this.BtnProb2_Click);
            // 
            // lblProb1
            // 
            this.lblProb1.AutoSize = true;
            this.lblProb1.Location = new System.Drawing.Point(12, 183);
            this.lblProb1.Name = "lblProb1";
            this.lblProb1.Size = new System.Drawing.Size(132, 13);
            this.lblProb1.TabIndex = 10;
            this.lblProb1.Text = "Kişi Başı 20 TL ile Max Kâr";
            // 
            // LblProb2
            // 
            this.LblProb2.AutoSize = true;
            this.LblProb2.Location = new System.Drawing.Point(12, 234);
            this.LblProb2.Name = "LblProb2";
            this.LblProb2.Size = new System.Drawing.Size(124, 13);
            this.LblProb2.TabIndex = 11;
            this.LblProb2.Text = "1,5 Kâr ile Kişi Başı Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(188, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 356);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1254, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblProb2);
            this.Controls.Add(this.lblProb1);
            this.Controls.Add(this.BtnProb2);
            this.Controls.Add(this.BtnProb1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cozumList);
            this.Controls.Add(this.CbNereye);
            this.Controls.Add(this.CbNereden);
            this.Controls.Add(this.Nereye);
            this.Controls.Add(this.Nereden);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nereden;
        private System.Windows.Forms.Label Nereye;
        private System.Windows.Forms.ComboBox CbNereden;
        private System.Windows.Forms.ComboBox CbNereye;
        private System.Windows.Forms.ListBox cozumList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProb1;
        private System.Windows.Forms.Button BtnProb2;
        private System.Windows.Forms.Label lblProb1;
        private System.Windows.Forms.Label LblProb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

