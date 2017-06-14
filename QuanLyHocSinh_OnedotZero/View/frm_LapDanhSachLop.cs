using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QuanLyHocSinh_OnedotZero
{
    public partial class frm_LapDanhSachLop : Form
    {
        DanhSachLopOBJ objLop = new DanhSachLopOBJ();

        public frm_LapDanhSachLop()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_LapDanhSachLop_Load(object sender, EventArgs e)
        {
            cbo_Khoi.DataSource = objLop.GetKhoi();
            cbo_Khoi.ValueMember = "MAKHOI";
            cbo_Khoi.DisplayMember = "TENKHOI";

        
            cbo_HoTen.DataSource = objLop.GetHS();
            cbo_HoTen.ValueMember = "MAHS";
            cbo_HoTen.DisplayMember = "HOTEN";
        }

        private void cbo_Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaKhoi = cbo_Khoi.SelectedValue.ToString();
            cbo_Lop.DataSource = objLop.GetLop(MaKhoi);
            cbo_Lop.ValueMember = "MALOP";
            cbo_Lop.DisplayMember = "TENLOP";
        }

        private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLop = cbo_Lop.SelectedValue.ToString();
            cbo_HoTen.DataSource = objLop.GetHS();
            cbo_HoTen.ValueMember = "MAHS";
            cbo_HoTen.DisplayMember = "HOTEN";
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            if (objLop.UpDateMaLop_HS(cbo_Lop.SelectedValue.ToString(), cbo_HoTen.SelectedValue.ToString()))
                gc_DanhSachHocSinhLop.DataSource = objLop.GetHS_ID(cbo_HoTen.SelectedValue.ToString());
                /* public DataTable GetHS_ID(string ID)
        {
            string str = "SELECT * FROM HOCSINH WHERE MAHS= '"+ ID + "'";
            return objLop.GetAll(str);

        }*/
            else
                MessageBox.Show("CÓ LỖI TRONG QUÁ TRÌNH THÊM!");
        }

    }
}
