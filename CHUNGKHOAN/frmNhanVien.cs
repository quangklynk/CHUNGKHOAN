using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOAN
{

    public partial class frmNhanVien : Form
    {
        Int32 vitri;
        DataRowView current_row; // dòng hiện tại
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUNGKHOANDataSet);

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cHUNGKHOANDataSet.EnforceConstraints = false;
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.cHUNGKHOANDataSet.NHANVIEN);

        }

        private void barButtonTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát khỏi form?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void barButtonREFRESH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.cHUNGKHOANDataSet.NHANVIEN);
            //gc_BoDe.Enabled = true;
            //btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            //btnGhi.Enabled = btnPhucHoi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void barButtonPHUCHOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nHANVIENBindingSource.CancelEdit();
            if (barButtonTHEM.Enabled == false) nHANVIENBindingSource.Position = this.vitri;
            //gc_BoDe.Enabled = true;
            //btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            //btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void barButtonTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nHANVIENBindingSource.EndEdit();
            nHANVIENBindingSource.ResetCurrentItem();
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            current_row = (DataRowView)nHANVIENBindingSource.Current;
            current_row["DANGHI"] = 1;
            nHANVIENTableAdapter.Update(this.cHUNGKHOANDataSet.NHANVIEN);
            MessageBox.Show("Ok !!");
        }
    }
}
