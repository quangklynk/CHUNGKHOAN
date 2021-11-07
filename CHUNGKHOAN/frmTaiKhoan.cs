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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void bntTAO_Click(object sender, EventArgs e)
        {
            if (this.txtMATKHAU.Text.Trim() == "" || this.txtTAIKHOAN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dầy đủ", "", MessageBoxButtons.OK);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(Program.connstr);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_TaoTaiKhoan";
            sqlCommand.Parameters.Add(new SqlParameter("@LGNAME", txtTAIKHOAN.Text.Trim()));
            sqlCommand.Parameters.Add(new SqlParameter("@PASS", txtMATKHAU.Text.Trim()));
            sqlCommand.Parameters.Add(new SqlParameter("@USERNAME", cmbMANV.SelectedValue));
            sqlCommand.Parameters.Add(new SqlParameter("@ROLE", cmbQUYEN.SelectedItem.ToString()));
            SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            int result = (int)sqlCommand.Parameters["@return"].Value;
            if (result == 0)
            {
                sqlConnection.Close();
                MessageBox.Show("Tạo thành công");
            }
            else
            {
                MessageBox.Show("Tạo Thất Bại");
                return;
            }

        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            this.load_MaNV();
        }

        private void creatRole()
        {
            DataTable level = new DataTable();
            DataColumn column = new DataColumn("SYMBOL");
            level.Columns.Add(column);
            column = new DataColumn("DISCRIPTION");
            level.Columns.Add(column);
            DataRow row;
            if (Program.mGroup == "SGD")
            {
                row = level.NewRow();
                row.ItemArray = new object[] { "SGD", "SGD" };
                level.Rows.Add(row);
            }
            else if (Program.mGroup == "CONGTY")
            {
                row = level.NewRow();
                row.ItemArray = new object[] { "CONGTY", "CONGTY" };
                level.Rows.Add(row);
                row = level.NewRow();
                row.ItemArray = new object[] { "NDT", "NDT" };
                level.Rows.Add(row);
            }

            this.cmbQUYEN.DataSource = level;
            this.cmbQUYEN.DisplayMember = "DISCRIPTION";
            this.cmbQUYEN.ValueMember = "SYMBOL";
        }

        public void load_MaNV()
        {
            SqlDataReader myReader;
            String strLenh = "SELECT MANV FROM dbo.NHANVIEN LEFT OUTER JOIN sys.database_principals sq ON CAST(dbo.NHANVIEN.MANV AS varchar(9)) = sq.name WHERE sq.name IS NULL";
            myReader = Program.ExecSqlDataReader(strLenh);

            if (myReader == null)
            {
                MessageBox.Show("Không tìm nhân viên nào");
            }
            DataTable nhanvien = new DataTable();
            DataColumn column = new DataColumn("MAGV");
            nhanvien.Columns.Add(column);
            while (myReader.Read())
            {
                DataRow row = nhanvien.NewRow();
                row.ItemArray = new object[] { myReader.GetString(0) };
                nhanvien.Rows.Add(row);
            }

            //gán môn học vào cmbMôn Học
            this.cmbMANV.DataSource = nhanvien;
            this.cmbMANV.DisplayMember = "MAGV";
            this.cmbMANV.ValueMember = "MAGV";
            myReader.Close();

            this.cmbMANV.SelectedIndex = 0;


            this.creatRole();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
