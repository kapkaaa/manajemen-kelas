namespace Manajemen_kelas
{
    partial class input_kas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Kas = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbsmt = new System.Windows.Forms.ComboBox();
            this.tbktr = new System.Windows.Forms.TextBox();
            this.tbjl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbkd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Kas);
            this.groupBox1.Location = new System.Drawing.Point(468, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search kas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Belum di Bayar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Semester 5",
            "Semester 6"});
            this.comboBox1.Location = new System.Drawing.Point(6, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Semester";
            // 
            // Kas
            // 
            this.Kas.FormattingEnabled = true;
            this.Kas.Location = new System.Drawing.Point(0, 100);
            this.Kas.Name = "Kas";
            this.Kas.Size = new System.Drawing.Size(320, 238);
            this.Kas.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Masukkan Nama Siswa";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtp);
            this.groupBox2.Controls.Add(this.cmbsmt);
            this.groupBox2.Controls.Add(this.tbktr);
            this.groupBox2.Controls.Add(this.tbjl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbnm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbkd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(794, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 387);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bayar Kas";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(115, 163);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(208, 20);
            this.dtp.TabIndex = 10;
            // 
            // cmbsmt
            // 
            this.cmbsmt.FormattingEnabled = true;
            this.cmbsmt.Items.AddRange(new object[] {
            "Semester 5",
            "Semester 6"});
            this.cmbsmt.Location = new System.Drawing.Point(115, 208);
            this.cmbsmt.Name = "cmbsmt";
            this.cmbsmt.Size = new System.Drawing.Size(208, 21);
            this.cmbsmt.TabIndex = 3;
            this.cmbsmt.Text = "Semester 5";
            // 
            // tbktr
            // 
            this.tbktr.Location = new System.Drawing.Point(115, 246);
            this.tbktr.Multiline = true;
            this.tbktr.Name = "tbktr";
            this.tbktr.Size = new System.Drawing.Size(208, 62);
            this.tbktr.TabIndex = 9;
            // 
            // tbjl
            // 
            this.tbjl.Location = new System.Drawing.Point(115, 131);
            this.tbjl.Name = "tbjl";
            this.tbjl.ReadOnly = true;
            this.tbjl.Size = new System.Drawing.Size(208, 20);
            this.tbjl.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tanggal :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Semester :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Keterangan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama :";
            // 
            // tbnm
            // 
            this.tbnm.Location = new System.Drawing.Point(115, 94);
            this.tbnm.Name = "tbnm";
            this.tbnm.Size = new System.Drawing.Size(208, 20);
            this.tbnm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah :";
            // 
            // tbkd
            // 
            this.tbkd.Location = new System.Drawing.Point(115, 53);
            this.tbkd.Name = "tbkd";
            this.tbkd.ReadOnly = true;
            this.tbkd.Size = new System.Drawing.Size(208, 20);
            this.tbkd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Bersih";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_kas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1217, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "input_kas";
            this.Text = "input_kas";
            this.Load += new System.EventHandler(this.input_kas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Kas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbkd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbjl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbsmt;
        private System.Windows.Forms.TextBox tbktr;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}