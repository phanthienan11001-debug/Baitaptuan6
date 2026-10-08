using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==================== FORM LOAD ====================
        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Sẵn sàng. Đang tải dữ liệu...";
            await TaiDanhSach();
        }

        // ==================== READ ====================
        private async Task TaiDanhSach()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> danhSach = await context.Students.ToListAsync();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = danhSach;
                    lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
                    lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        // ==================== CHỌN DÒNG -> ĐỔ LÊN Ô NHẬP ====================
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Student sv)
            {
                txtHoTen.Text = sv.FullName;
                txtDiem.Text = sv.Grade.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cần xử lý
        }

        // ==================== CREATE ====================
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm không hợp lệ!", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Students.Add(new Student
                    {
                        FullName = txtHoTen.Text,
                        Grade = diem
                    });
                    await context.SaveChangesAsync();
                }

                lblTrangThai.Text = "Đã thêm sinh viên mới!";
                lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        // ==================== UPDATE ====================
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diemMoi))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students.FindAsync(svDangChon.Id);
                    if (sv != null)
                    {
                        sv.FullName = txtHoTen.Text;
                        sv.Grade = diemMoi;
                        await context.SaveChangesAsync();
                    }
                }

                lblTrangThai.Text = "Đã cập nhật thông tin!";
                lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        // ==================== DELETE ====================
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Student svDangChon)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{svDangChon.FullName}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    Student sv = await context.Students.FindAsync(svDangChon.Id);
                    if (sv != null)
                    {
                        context.Students.Remove(sv);
                        await context.SaveChangesAsync();
                    }
                }

                lblTrangThai.Text = "Đã xóa sinh viên!";
                lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        // ==================== LINQ: LỌC SV ĐẠT ====================
        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    List<Student> ketQua = await context.Students
                        .Where(sv => sv.Grade >= 5)
                        .OrderByDescending(sv => sv.Grade)
                        .ToListAsync();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ketQua;

                    lblTrangThai.Text = $"Tìm thấy {ketQua.Count} sinh viên đạt (>=5).";
                    lblTrangThai.ForeColor = System.Drawing.Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}