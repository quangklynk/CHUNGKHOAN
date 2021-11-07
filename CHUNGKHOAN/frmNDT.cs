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
    public partial class frmNDT : Form
    {
        Int32 vitri;
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

        public frmNDT()
        {
            InitializeComponent();
        }

        private void nHADAUTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHADAUTUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHUNGKHOANDataSet);

        }

        private void frmNDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.NHADAUTU' table. You can move, or remove it, as needed.
            this.nHADAUTUTableAdapter.Fill(this.cHUNGKHOANDataSet.NHADAUTU);

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
            this.nHADAUTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHADAUTUTableAdapter.Fill(this.cHUNGKHOANDataSet.NHADAUTU);
            nHADAUTUGridControl.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void barButtonPHUCHOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nHADAUTUBindingSource.CancelEdit();
            if (barButtonTHEM.Enabled == false) nHADAUTUBindingSource.Position = this.vitri;
            this.nHADAUTUGridControl.Enabled = true;
            this.accessPermitted();
        }

        private void barButtonXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
