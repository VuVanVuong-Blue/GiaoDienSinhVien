using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienSinhVien
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSinhVien = txtMaSinhVien.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDC.Text;
            string heDaoTao = txtHeDT.Text;
            string sdt = txtSDT.Text;
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            string lop = cmbLop.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(maSinhVien) || string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSinhVien.Rows.Add(maSinhVien, hoTen, diaChi, heDaoTao, sdt, ngaySinh, gioiTinh, lop);

            ClearFields();
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện khi nhấn nút Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
                {
                    dgvSinhVien.Rows.Remove(row);
                }
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

  

        // Hàm xóa trắng các trường nhập liệu
        private void ClearFields()
        {
            txtMaSinhVien.Clear();
            txtHoTen.Clear();
            txtDC.Clear();
            txtHeDT.Clear();
            txtSDT.Clear();
            rbNam.Checked = true;
            cmbLop.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSinhVien.SelectedRows[0];

                selectedRow.Cells[0].Value = txtMaSinhVien.Text;
                selectedRow.Cells[1].Value = txtHoTen.Text;
                selectedRow.Cells[2].Value = txtDC.Text;
                selectedRow.Cells[3].Value = txtHeDT.Text;
                selectedRow.Cells[4].Value = txtSDT.Text;
                selectedRow.Cells[5].Value = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
                selectedRow.Cells[6].Value = rbNam.Checked ? "Nam" : "Nữ";
                selectedRow.Cells[7].Value = cmbLop.SelectedItem?.ToString();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


    }
}

