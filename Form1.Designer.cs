namespace SayıBulmaOyunu
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
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.lblSayilar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblislem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullanici.Location = new System.Drawing.Point(378, 50);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(177, 32);
            this.txtKullanici.TabIndex = 0;
            this.txtKullanici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSayilar.Location = new System.Drawing.Point(12, 9);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(0, 25);
            this.lblSayilar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 105);
            this.button1.TabIndex = 2;
            this.button1.Text = "KONTROL ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(534, 9);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(75, 25);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "label2";
            // 
            // lblislem
            // 
            this.lblislem.AutoSize = true;
            this.lblislem.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblislem.Location = new System.Drawing.Point(193, 53);
            this.lblislem.Name = "lblislem";
            this.lblislem.Size = new System.Drawing.Size(170, 25);
            this.lblislem.TabIndex = 4;
            this.lblislem.Text = "İşlemi Gİriniz : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 256);
            this.Controls.Add(this.lblislem);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSayilar);
            this.Controls.Add(this.txtKullanici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label lblSayilar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblislem;
    }
}

