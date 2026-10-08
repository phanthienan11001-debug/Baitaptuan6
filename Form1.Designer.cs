namespace WinFormsApp1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnLocDat = new Button();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 191);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(790, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 48);
            label1.TabIndex = 2;
            label1.Text = "QLSV EF CORE(CRUD DAY DU)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 3;
            label2.Text = "Ho Ten";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 68);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Diem";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(88, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(324, 31);
            txtHoTen.TabIndex = 5;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(572, 68);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(150, 31);
            txtDiem.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(27, 121);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 47);
            btnThem.TabIndex = 8;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(682, 121);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(135, 47);
            btnLocDat.TabIndex = 9;
            btnLocDat.Text = "Loc SV dat (LINQ)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(522, 121);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(135, 47);
            btnTaiLai.TabIndex = 10;
            btnTaiLai.Text = "TaiLai";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(360, 121);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 47);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(181, 121);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 47);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(41, 478);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 25);
            lblTrangThai.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 522);
            Controls.Add(lblTrangThai);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnTaiLai);
            Controls.Add(btnLocDat);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "QLSV";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHoTen;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnLocDat;
        private Button btnTaiLai;
        private Button btnXoa;
        private Button btnSua;
        private Label lblTrangThai;
    }
}
