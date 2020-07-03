namespace Daily_Bugle
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonOrg = new System.Windows.Forms.Button();
            this.buttonGaz = new System.Windows.Forms.Button();
            this.buttonAds = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOrg
            // 
            this.buttonOrg.Location = new System.Drawing.Point(13, 174);
            this.buttonOrg.Name = "buttonOrg";
            this.buttonOrg.Size = new System.Drawing.Size(272, 44);
            this.buttonOrg.TabIndex = 0;
            this.buttonOrg.Text = "Организации";
            this.buttonOrg.UseVisualStyleBackColor = true;
            this.buttonOrg.Click += new System.EventHandler(this.buttonOrg_Click);
            // 
            // buttonGaz
            // 
            this.buttonGaz.Location = new System.Drawing.Point(12, 252);
            this.buttonGaz.Name = "buttonGaz";
            this.buttonGaz.Size = new System.Drawing.Size(272, 44);
            this.buttonGaz.TabIndex = 1;
            this.buttonGaz.Text = "Газеты";
            this.buttonGaz.UseVisualStyleBackColor = true;
            this.buttonGaz.Click += new System.EventHandler(this.buttonGaz_Click);
            // 
            // buttonAds
            // 
            this.buttonAds.Location = new System.Drawing.Point(12, 333);
            this.buttonAds.Name = "buttonAds";
            this.buttonAds.Size = new System.Drawing.Size(272, 44);
            this.buttonAds.TabIndex = 2;
            this.buttonAds.Text = "Реклама";
            this.buttonAds.UseVisualStyleBackColor = true;
            this.buttonAds.Click += new System.EventHandler(this.buttonAds_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAds);
            this.Controls.Add(this.buttonGaz);
            this.Controls.Add(this.buttonOrg);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrg;
        private System.Windows.Forms.Button buttonGaz;
        private System.Windows.Forms.Button buttonAds;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

