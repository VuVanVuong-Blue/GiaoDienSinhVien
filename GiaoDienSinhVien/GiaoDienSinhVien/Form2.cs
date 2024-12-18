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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text) ||
                cbmMaKhoa.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            dgvLop.Rows.Add(txtMaLop.Text, txtTenLop.Text, cbmMaKhoa.SelectedItem.ToString(), textBox3.Text);

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update selected row
            var selectedRow = dgvLop.SelectedRows[0];
            selectedRow.Cells[0].Value = txtMaLop.Text;
            selectedRow.Cells[1].Value = txtTenLop.Text;
            selectedRow.Cells[2].Value = cbmMaKhoa.SelectedItem?.ToString();
            selectedRow.Cells[3].Value = textBox3.Text;

            // Clear input fields
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLop.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Remove selected row
            dgvLop.Rows.RemoveAt(dgvLop.SelectedRows[0].Index);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            cbmMaKhoa.SelectedIndex = -1;
            textBox3.Clear();
        }
    }
}
