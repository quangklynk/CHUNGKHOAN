using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string status = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }
 
        private void accessDeny()
        {
            barButtonTHEM.Enabled = false;
            barButtonXOA.Enabled = false;
            barButtonSUA.Enabled = false;
            barButtonREFRESH.Enabled = false;
            barButtonTHOAT.Enabled = false;
            barButtonGHI.Enabled = true;
            barButtonPHUCHOI.Enabled = true;
        }

        private void accessPermitted()
        {
            barButtonTHEM.Enabled = true;
            barButtonXOA.Enabled = true;
            barButtonSUA.Enabled = true;
            barButtonREFRESH.Enabled = true;
            barButtonTHOAT.Enabled = true;
            barButtonGHI.Enabled = false;
            barButtonPHUCHOI.Enabled = false;
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
            this.groupBox1.Enabled = false;
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
            nHANVIENGC.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void barButtonPHUCHOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nHANVIENBindingSource.CancelEdit();
            if (barButtonTHEM.Enabled == false) nHANVIENBindingSource.Position = this.vitri;
            this.nHANVIENGC.Enabled = true;
            this.accessPermitted();
        }

        private void barButtonTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.status = "add";
            this.groupBox1.Enabled = true;
            this.accessDeny();
            vitri = this.nHANVIENBindingSource.Position;
            this.nHANVIENBindingSource.AddNew();
            this.nHANVIENGC.Enabled = false;
        }

        private void barButtonSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nHANVIENBindingSource.Position;
            groupBox1.Enabled = true;
            this.accessDeny();
            nHANVIENGC.Enabled = false;
            this.status = "edit";
        }

        private void barButtonGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.txtTen.Text.Trim() == "" || this.txtHO.Text.Trim() == "" || this.txtCMND.Text.Trim() == ""|| this.txtDIACHI.Text.Trim() == ""|| this.txtNGAYSINH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dầy đủ", "", MessageBoxButtons.OK);
                return;
            }
            if (this.status == "add")
            {
                try
                {
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    //current_row = (DataRowView)nHANVIENBindingSource.Current;
                    //current_row["DANGHI"] = 0;
                    //current_row["MACT"] = Program.mChinhanh;
                    this.nHANVIENTableAdapter.Update(this.cHUNGKHOANDataSet.NHANVIEN);
                    //SqlDataReader myReader;
                    //String strLenh = "INSERT INTO dbo.NHANVIEN( HO, TEN, PHAI, NGAYSINH, DIACHI, SDT, DANGHI, MACT, CMND) VALUES ( N'" + this.txtHO.Text.Trim() + "', "
                    //                                                                                                             + "N'" + txtTen.Text.Trim() + "',  " 
                    //                                                                                                             + this.cbPHAI.Checked.ToString() + ",  " 
                    //                                                                                                             + "'"  + this.txtNGAYSINH.Text.Trim() + "',  " 
                    //                                                                                                             + "N'" + txtDIACHI.Text.Trim() + "',  " 
                    //                                                                                                             + "N'" + txtSDT.Text.Trim() + "',  " 
                    //                                                                                                             + "1," 
                    //                                                                                                             + "'" + Program.mChinhanh + " ')  ";
                    //myReader = Program.ExecSqlDataReader(strLenh);
                    //myReader.Close();

                    this.status = "";
                    MessageBox.Show("Đã thêm nhân viên mới mới");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                nHANVIENBindingSource.EndEdit();
                nHANVIENBindingSource.ResetCurrentItem();
                this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nHANVIENTableAdapter.Update(this.cHUNGKHOANDataSet.NHANVIEN);
                MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
                accessPermitted();
            }
        }

        private void barButtonXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (MessageBox.Show("Bạn có thật sự muốn cho nhân viên này nghỉ việc ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    current_row = (DataRowView)nHANVIENBindingSource.Current;
                    current_row["DANGHI"] = 1;
                    nHANVIENTableAdapter.Update(this.cHUNGKHOANDataSet.NHANVIEN);
                    MessageBox.Show("Xóa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nHANVIENTableAdapter.Fill(this.cHUNGKHOANDataSet.NHANVIEN);
                    nHANVIENBindingSource.Position = vitri;
                    return;
                }

            }
            if (nHANVIENBindingSource.Count == 0)
            {
                barButtonXOA.Enabled = false;
            }
        }

    }
}
