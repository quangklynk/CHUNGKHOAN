using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CHUNGKHOAN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Form Parent;
        private Form currentForm = null;
        public frmMain(Form form)
        {
            InitializeComponent();
            Parent = form;
        }
        private Form FindForm<T>() where T : Form
        {
            var Temps = typeof(T);
            return this.MdiChildren.FirstOrDefault(x => x.GetType() == Temps);
        }
        private void ShowForm<T>() where T : Form
        {
            if (currentForm != null)
            {
                currentForm.Hide();
            }

            currentForm = FindForm<T>();

            if (currentForm == null)
            {
                currentForm = Activator.CreateInstance<T>();
                currentForm.MdiParent = this;
            }
            currentForm.Show();
        }
        public void HienThiMenu()
        {
            MANV.Text = "Mã NV : " + Program.username;
            HOTEN.Text = "Họ Tên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;

            rib_CT.Visible = rib_NDT.Visible = rib_SGD.Visible = true;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<frmNhanVien>();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<frmTaiKhoan>();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<frmCoPhieu>();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm<frmNDT>();
        }
    }
}
