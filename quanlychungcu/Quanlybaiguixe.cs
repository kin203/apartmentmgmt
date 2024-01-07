using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlychungcu
{
    public partial class Quanlybaiguixe : Form
    {
        Connect cn = new Connect();
        public Quanlybaiguixe()
        {
            InitializeComponent();
            GetDataVeXe();
            GetDataBaiXe();
        }

        private void GetDataVeXe()
        {
            string query = "SELECT * FROM vexethang";
            DataSet ds = cn.LayDuLieu(query);
            dgvBaiXe.DataSource = ds.Tables[0];
        }
        public void clearTextVeXe()
        {
            txtMaTheXe.Enabled = true;
            txtMaTheXe.Clear();
            txtChuXe.Clear();
            txtHangXe.Clear();
            txtBienSo.Clear();
            txtMauXe.Clear();
            txtCCCD.Clear();
            txtLoaiXe.Clear();
            txtthoihan.Clear();
            pickerNgayKH.Value = DateTime.Now;
        }

        private void txtDiaChiNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO vexethang (mathexe, chuxe, mauxe, cccd, loaixe, thoihan, hangxe, bienso, ngaykichhoat) " +
                        "VALUES (@mathexe, @chuxe, @mauxe, @cccd, @loaixe, @thoihan, @hangxe, @bienso, @ngaykichhoat)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@mathexe", txtMaTheXe.Text },
                    { "@chuxe", txtChuXe.Text },
                    { "@mauxe", txtMauXe.Text },
                    { "@cccd", txtCCCD.Text },
                    { "@loaixe", txtLoaiXe.Text },
                    { "@thoihan", txtthoihan.Text },
                    { "@hangxe", txtHangXe.Text },
                    { "@bienso", txtBienSo.Text },
                    { "@ngaykichhoat", pickerNgayKH.Value.ToString("yyyy/MM/dd") },
                };

            if (cn.ThucThi(query, parameters))
            {
                MessageBox.Show("Thêm mới vé xe thành công.");
                btnHienThiVeThang.PerformClick();
            }
            else
            {
                MessageBox.Show("Lỗi thêm mới thông tin vé xe.");
            }
        }

        private void dgvBaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (e.RowIndex >= 0 && e.RowIndex < dgvBaiXe.Rows.Count)
            {
                txtMaTheXe.Text = dgvBaiXe.Rows[r].Cells["mathexe"].Value.ToString();
                txtChuXe.Text = dgvBaiXe.Rows[r].Cells["chuxe"].Value.ToString();
                txtMauXe.Text = dgvBaiXe.Rows[r].Cells["mauxe"].Value.ToString();
                txtCCCD.Text = dgvBaiXe.Rows[r].Cells["cccd"].Value.ToString();
                txtLoaiXe.Text = dgvBaiXe.Rows[r].Cells["loaixe"].Value.ToString();
                txtthoihan.Text = dgvBaiXe.Rows[r].Cells["thoihan"].Value.ToString();
                txtHangXe.Text = dgvBaiXe.Rows[r].Cells["hangxe"].Value.ToString();
                txtBienSo.Text = dgvBaiXe.Rows[r].Cells["bienso"].Value.ToString();
                string a = dgvBaiXe.Rows[r].Cells["ngaykichhoat"].Value.ToString();
                if (!string.IsNullOrEmpty(a))
                {
                    pickerNgayKH.Value = DateTime.Parse(a);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSuaVeThang_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@mathexe", txtMaTheXe.Text },
                            { "@chuxe", txtChuXe.Text },
                            { "@mauxe", txtMauXe.Text },
                            { "@cccd", txtCCCD.Text },
                            { "@loaixe", txtLoaiXe.Text },
                            { "@thoihan", txtthoihan.Text },
                            { "@hangxe", txtHangXe.Text },
                            { "@bienso", txtBienSo.Text },
                            { "@ngaykichhoat", pickerNgayKH.Value.ToString("yyyy/MM/dd") },
                        };

                string query = "UPDATE vexethang SET bienso=@bienso, mauxe=@mauxe, hangxe=@hangxe, loaixe=@loaixe, chuxe=@chuxe, cccd=@cccd, thoihan=@thoihan, ngaykichhoat=@ngaykichhoat WHERE mathexe=@mathexe";

                if (cn.ThucThi(query, parameters))
                {
                    MessageBox.Show("Cập nhật vé xe thành công.");
                    btnHienThiVeThang.PerformClick();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật vé xe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaVeThang_Click(object sender, EventArgs e)
        {
            if (dgvBaiXe.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vé xe này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM vexethang WHERE mathexe=@mathexe";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@mathexe", txtMaTheXe.Text }
                        };

                    if (cn.ThucThi(query, parameters))
                    {
                        MessageBox.Show("Xóa vé xe thành công.");
                        btnHienThiVeThang.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xóa vé xe.");
                    }
                }
            }
        }

        private void btnHienThiVeThang_Click(object sender, EventArgs e)
        {
            GetDataVeXe();
            clearTextVeXe();
        }

        private void btnTKVeThang_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM vexethang WHERE mathexe LIKE '%{0}%' OR chuxe LIKE N'%{0}%'", txtTimKiemVeThang.Text);
            DataSet ds = cn.LayDuLieu(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvBaiXe.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin !!!");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //THÔNG TIN BÃI XE
        string imagePath;
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(result))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }
        private void GetDataBaiXe()
        {
            string query = "SELECT * FROM baixe";
            DataSet ds = cn.LayDuLieu(query);
            dgvTTXebaixe.DataSource = ds.Tables[0];
            imagePath = null;
        }
        public void clearTextBaiXe()
        {
            txtChuxebaixe.Enabled = true;
            BtnThemBaixe.Enabled = true;
            txtBiensobaixe.Clear();
            txtHangXe.Clear();
            txtChuxebaixe.Clear();
            txtMathebaixe.Clear();
            ptXeRa.Image = null;
            ptXeVao.Image = null;
            dateTgra.Value = DateTime.Now;
            dateTgvao.Value = DateTime.Now;
        }

        // Biến đường dẫn hình ảnh cho sự kiện thêm xe
        private string imagePathForAdding;

       private void BtnThemBaixe_Click(object sender, EventArgs e)
        {
            if (imagePathForAdding != null)
            {
                try
                {
                    Image originalImageVao = Image.FromFile(imagePathForAdding);
                    Image resizedImageVao = ResizeImage(originalImageVao, ptXeVao.Width, ptXeVao.Height);
                    byte[] imageByteArrayVao = ImageToByteArray(resizedImageVao);

                    // Sử dụng tham số trong câu lệnh SQL để tránh SQL Injection
                    string query = "INSERT INTO baixe (chuxe, bienso, mathe, thoigianvao, thoigianra, hinhanhvao) " +
                                   "VALUES (@chuxe, @bienso, @mathe, @thoigianvao, @thoigianra, @hinhanhvao)";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@chuxe", txtChuxebaixe.Text },
                        { "@bienso", txtBiensobaixe.Text },
                        { "@mathe", txtMathebaixe.Text },
                        { "@thoigianvao", dateTgvao.Value.ToString("yyyy/MM/dd HH:mm") },
                        { "@thoigianra", dateTgra.Value.ToString("yyyy/MM/dd HH:mm") },
                        { "@hinhanhvao", imageByteArrayVao }
                    };

                    if (cn.ThucThi(query, parameters))
                    {
                        MessageBox.Show("Lưu thông tin thành công.");
                        GetDataBaiXe();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi .");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xử lý hình ảnh: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đối chiếu hình ảnh trước khi lưu thông tin vé.");
            }
        }
      
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                return ms.ToArray();
            }
        }

        private void ptXeVao_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // ... (Các thiết lập cho hộp thoại mở file)

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathForAdding = openFileDialog.FileName; // Cập nhật đường dẫn hình ảnh cho việc thêm xe vào
                                                              // Đọc và hiển thị hình ảnh trong PictureBox
                Image originalImage = Image.FromFile(imagePathForAdding);
                ptXeVao.Image = ResizeImage(originalImage, ptXeVao.Width, ptXeVao.Height);
            }
        }

        private void ptXeRa_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // ... (Các thiết lập cho hộp thoại mở file)

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathForAdding = openFileDialog.FileName; // Cập nhật đường dẫn hình ảnh cho việc thêm xe ra
                                                              // Đọc và hiển thị hình ảnh trong PictureBox
                Image originalImage = Image.FromFile(imagePathForAdding);
                ptXeRa.Image = ResizeImage(originalImage, ptXeRa.Width, ptXeRa.Height);
            }
        }

        private void dgvTTXebaixe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDataBaiXe();
        }

        private void dgvTTXebaixe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (e.RowIndex >= 0 && e.RowIndex < dgvTTXebaixe.Rows.Count)
            {
                BtnThemBaixe.Enabled = false;

                // Hiển thị hình ảnh vào ptXeVao
                object cellValueVao = dgvTTXebaixe.Rows[e.RowIndex].Cells["hinhanhvao"].Value;

                if (cellValueVao != DBNull.Value && cellValueVao != null)
                {
                    byte[] imageByteArrayVao = (byte[])cellValueVao;

                    using (MemoryStream ms = new MemoryStream(imageByteArrayVao))
                    {
                        Image originalImageVao = Image.FromStream(ms);
                        ptXeVao.Image = ResizeImage(originalImageVao, ptXeVao.Width, ptXeVao.Height);
                    }
                }
                else
                {
                    ptXeVao.Image = null;
                }
                txtXevao.Text = dgvTTXebaixe.Rows[r].Cells["bienso"].Value.ToString();
                txtChuxebaixe.Text = dgvTTXebaixe.Rows[r].Cells["chuxe"].Value.ToString();
                txtBiensobaixe.Text = dgvTTXebaixe.Rows[r].Cells["bienso"].Value.ToString();
                txtMathebaixe.Text = dgvTTXebaixe.Rows[r].Cells["mathe"].Value.ToString();
                string a = dgvTTXebaixe.Rows[r].Cells["thoigianvao"].Value.ToString();
                if (!string.IsNullOrEmpty(a))
                {
                    dateTgvao.Value = DateTime.Parse(a);
                }
                else
                {
                    dateTgvao.Value = DateTime.Now; // hoặc giá trị mặc định khác
                }
                string b = dgvTTXebaixe.Rows[r].Cells["thoigianra"].Value.ToString();
                if (!string.IsNullOrEmpty(b))
                {
                    dateTgra.Value = DateTime.Parse(b);
                }
                else
                {
                    dateTgra.Value = DateTime.Now; // hoặc giá trị mặc định khác
                }
            }


        }

        private void BtnXoaBaixe_Click(object sender, EventArgs e)
        {
            if (dgvTTXebaixe.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin vé này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xóa nhân viên
                    string query = "DELETE FROM baixe WHERE mathe=@mathe";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                        {
                            { "@mathe", txtMathebaixe.Text }
                        };

                    if (cn.ThucThi(query, parameters))
                    {
                        MessageBox.Show("Xóa thành công.");
                        GetDataBaiXe();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn để xóa.");
            }
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            string bienSoVao = txtXevao.Text;
            string bienSoRa = txtXera.Text;

            // Kiểm tra xem hai chuỗi có giống nhau không
            if (bienSoVao.Equals(bienSoRa, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Biển số vào và biển số ra trùng nhau.");
            }
            else
            {
                MessageBox.Show("Biển số vào và biển số ra khác nhau. Vui lòng kiểm tra lại.");
            }
        }

        private void BtnSuaBaixe_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@chuxe", txtChuxebaixe.Text },
                        { "@bienso", txtBiensobaixe.Text },
                        { "@mathe", txtMathebaixe.Text },
                        { "@thoigianvao", dateTgvao.Value.ToString("yyyy/MM/dd HH:mm") },
                        { "@thoigianra", dateTgra.Value.ToString("yyyy/MM/dd HH:mm") },
                    };


                // Kiểm tra xem người dùng đã chọn ảnh mới hay chưa
                if (!string.IsNullOrEmpty(imagePath))
                {
                    Image originalImageVao = Image.FromFile(imagePathForAdding);
                    Image resizedImageVao = ResizeImage(originalImageVao, ptXeVao.Width, ptXeVao.Height);
                    byte[] imageByteArrayVao = ImageToByteArray(resizedImageVao);
                    parameters.Add("@hinhanhvao", imageByteArrayVao);
                }


                // Sử dụng tham số trong câu lệnh SQL để tránh SQL Injection
                string query = "update baixe set chuxe=@chuxe,bienso=@bienso,thoigianvao=@thoigianvao,thoigianra=@thoigianra where mathe=@mathe";

                // Kiểm tra xem có thêm điều kiện update ảnh không
                if (!string.IsNullOrEmpty(imagePath))
                {
                    query += ", hinhanhvao=@hinhanhvao";
                }

                if (cn.ThucThi(query, parameters))
                {
                    MessageBox.Show("Lưu thông tin thành công.");
                    GetDataBaiXe();
                }
                else
                {
                    MessageBox.Show("Lỗi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý hình ảnh: " + ex.Message);
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thời gian vào và thời gian ra từ giao diện
                DateTime thoiGianVao = dateTgvao.Value; // Lấy cả ngày và giờ
                DateTime thoiGianRa = dateTgra.Value; // Lấy cả ngày và giờ

                if (thoiGianVao == thoiGianRa)
                {
                    MessageBox.Show("Vé tháng: Đã thanh toán trước.");
                    return;
                }

                // Tính số giờ giữa thời gian vào và thời gian ra
                TimeSpan timeDifference = thoiGianRa - thoiGianVao;
                int soGioGui = (int)timeDifference.TotalHours;

                // Tính số tiền cần thanh toán dựa trên số giờ
                if (soGioGui <= 0)
                {
                    MessageBox.Show("Yêu cầu xem lại thời gian xe ra. ");
                }
                else
                {
                    int mucPhi = soGioGui * 5000;
                    MessageBox.Show($"Thông tin gửi xe:\nThời gian vào: {thoiGianVao}\nThời gian ra: {thoiGianRa}\nTổng số giờ gửi: {soGioGui} giờ\nSố tiền thanh toán: {mucPhi} VNĐ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTextBaiXe();
            GetDataBaiXe();
        }
    }
}


