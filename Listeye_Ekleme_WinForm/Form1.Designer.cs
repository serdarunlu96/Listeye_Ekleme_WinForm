namespace Listeye_Ekleme_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSehir = new TextBox();
            btnEkle = new Button();
            KisiListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Sehir:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(85, 25);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(85, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(85, 112);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(100, 23);
            txtSehir.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 154);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(164, 40);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // KisiListBox
            // 
            KisiListBox.FormattingEnabled = true;
            KisiListBox.ItemHeight = 15;
            KisiListBox.Location = new Point(228, 25);
            KisiListBox.Name = "KisiListBox";
            KisiListBox.Size = new Size(171, 169);
            KisiListBox.TabIndex = 7;
            KisiListBox.SelectedIndexChanged += KisiListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 235);
            Controls.Add(KisiListBox);
            Controls.Add(btnEkle);
            Controls.Add(txtSehir);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Listeye Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSehir;
        private Button btnEkle;
        private ListBox KisiListBox;
    }
}