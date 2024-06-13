namespace OtobusBiletSatis
{
    partial class kayıtFormu
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
            label1 = new Label();
            txtİsim = new TextBox();
            txtSoyisim = new TextBox();
            label2 = new Label();
            label3 = new Label();
            mskdTelefon = new MaskedTextBox();
            rdbBay = new RadioButton();
            rdbBayan = new RadioButton();
            btnİptal = new Button();
            btnTamam = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(142, 73);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // txtİsim
            // 
            txtİsim.Location = new Point(241, 73);
            txtİsim.Name = "txtİsim";
            txtİsim.Size = new Size(208, 27);
            txtİsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Location = new Point(241, 126);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(208, 27);
            txtSoyisim.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(142, 126);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(142, 178);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefon";
            // 
            // mskdTelefon
            // 
            mskdTelefon.Location = new Point(241, 178);
            mskdTelefon.Mask = "(999) 000-0000";
            mskdTelefon.Name = "mskdTelefon";
            mskdTelefon.Size = new Size(208, 27);
            mskdTelefon.TabIndex = 5;
            // 
            // rdbBay
            // 
            rdbBay.AutoSize = true;
            rdbBay.Checked = true;
            rdbBay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbBay.Location = new Point(142, 224);
            rdbBay.Name = "rdbBay";
            rdbBay.Size = new Size(56, 24);
            rdbBay.TabIndex = 6;
            rdbBay.TabStop = true;
            rdbBay.Text = "Bay";
            rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            rdbBayan.AutoSize = true;
            rdbBayan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdbBayan.Location = new Point(283, 224);
            rdbBayan.Name = "rdbBayan";
            rdbBayan.Size = new Size(73, 24);
            rdbBayan.TabIndex = 7;
            rdbBayan.Text = "Bayan";
            rdbBayan.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnİptal.Location = new Point(142, 266);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(94, 40);
            btnİptal.TabIndex = 8;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnTamam
            // 
            btnTamam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTamam.Location = new Point(283, 266);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(94, 40);
            btnTamam.TabIndex = 9;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // kayıtFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 427);
            Controls.Add(btnTamam);
            Controls.Add(btnİptal);
            Controls.Add(rdbBayan);
            Controls.Add(rdbBay);
            Controls.Add(mskdTelefon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSoyisim);
            Controls.Add(txtİsim);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "kayıtFormu";
            Text = "kayıtFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnİptal;
        private Button btnTamam;
        public TextBox txtİsim;
        public TextBox txtSoyisim;
        public MaskedTextBox mskdTelefon;
        public RadioButton rdbBay;
        public RadioButton rdbBayan;
    }
}