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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblDay.Text = DateTime.Now.ToShortDateString();
            this.lblHour.Text = DateTime.Now.ToShortTimeString();
            this.pictureBox2.Show();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.MdiParent = this; // Đặt Form1 làm Form cha
            childForm.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền Form2
            childForm.TopLevel = false; // Không để Form2 hoạt động độc lập
            childForm.Dock = DockStyle.Fill; // Form2 lấp đầy groupBox3

            // Thêm Form2 vào groupBox3
            this.groupBox3.Controls.Clear();
            this.groupBox3.Controls.Add(childForm);
            groupBox3.Size = new Size(childForm.Width, childForm.Height);
            childForm.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            groupBox3.Controls.Clear();

            // Tạo một instance của Form3
            Form3 form3 = new Form3();

            // Thiết lập Form3 như một control bên trong GroupBox3
            form3.TopLevel = false; // Không chạy như cửa sổ riêng
            form3.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền form
            form3.Dock = DockStyle.Fill; // Phủ toàn bộ groupBox3
            groupBox3.Size = new Size(form3.Width, form3.Height);
            // Thêm Form3 vào groupBox3
            this.groupBox3.Controls.Clear();
            this.groupBox3.Controls.Add(form3);
            groupBox3.Size = new Size(form3.Width, form3.Height);
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
