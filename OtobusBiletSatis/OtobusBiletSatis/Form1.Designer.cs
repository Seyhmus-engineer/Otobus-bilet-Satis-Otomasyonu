namespace OtobusBiletSatis
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            cmbOtobus = new ComboBox();
            cmbNereden = new ComboBox();
            cmbNereye = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpTarih = new DateTimePicker();
            nudFiyat = new NumericUpDown();
            label5 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rezerveEtToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ScrollBar;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.ForeColor = SystemColors.Desktop;
            listView1.GridLines = true;
            listView1.Location = new Point(798, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(733, 825);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefon";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cinsiyet";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nereden";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nereye";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Koltuk no";
            columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tarih";
            columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(469, 118);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Otobüs seçiniz";
            // 
            // cmbOtobus
            // 
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.FormattingEnabled = true;
            cmbOtobus.Items.AddRange(new object[] { "Travego", "setra", "neoplan" });
            cmbOtobus.Location = new Point(585, 115);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(139, 28);
            cmbOtobus.TabIndex = 2;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            // 
            // cmbNereden
            // 
            cmbNereden.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Items.AddRange(new object[] { "Diyarbakır", "Elazığ", "Malatya", "İstanbul", "Ankara", "İzmir", "Mersin", "Tunceli", "Adana", "Duhok", "Erbil", "Kerkük", "Zaho" });
            cmbNereden.Location = new Point(96, 34);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(139, 28);
            cmbNereden.TabIndex = 3;
            // 
            // cmbNereye
            // 
            cmbNereye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNereye.FormattingEnabled = true;
            cmbNereye.Items.AddRange(new object[] { "Diyarbakır", "Elazığ", "Malatya", "İstanbul", "Ankara", "İzmir", "Mersin", "Tunceli", "Adana", "Duhok", "Erbil", "Kerkük", "Zaho" });
            cmbNereye.Location = new Point(96, 77);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(139, 28);
            cmbNereye.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(5, 34);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Nereden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ScrollBar;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(5, 77);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Nereye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ScrollBar;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(509, 265);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(600, 265);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(139, 27);
            dtpTarih.TabIndex = 8;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(600, 308);
            nudFiyat.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudFiyat.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(139, 27);
            nudFiyat.TabIndex = 9;
            nudFiyat.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ScrollBar;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(509, 308);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 10;
            label5.Text = "Fiyat";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(564, 368);
            button1.Name = "button1";
            button1.Size = new Size(128, 45);
            button1.TabIndex = 11;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbNereden);
            groupBox1.Controls.Add(cmbNereye);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(489, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 110);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "İstikamet";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { rezerveEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 28);
            // 
            // rezerveEtToolStripMenuItem
            // 
            rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            rezerveEtToolStripMenuItem.Size = new Size(147, 24);
            rezerveEtToolStripMenuItem.Text = "Rezerve et";
            rezerveEtToolStripMenuItem.Click += rezerveEtToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1543, 845);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(nudFiyat);
            Controls.Add(dtpTarih);
            Controls.Add(label4);
            Controls.Add(cmbOtobus);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ComboBox cmbOtobus;
        private ComboBox cmbNereden;
        private ComboBox cmbNereye;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTarih;
        private NumericUpDown nudFiyat;
        private Label label5;
        private Button button1;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}
