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
	public partial class frmCoPhieu : Form
	{

		int vitri = 0;
		string macs = "";
		DataRowView current_row; // dòng hiện tại
		string status = "";

		public frmCoPhieu()
		{
			InitializeComponent();
		}

		private void accessDeny()
		{
			this.barButtonTHEM.Enabled = false;
			this.barButtonXOA.Enabled = false;
			this.barButtonSUA.Enabled = false;

			this.barButtonREFRESH.Enabled = false;
			this.barButtonTHOAT.Enabled = false;
		}

		private void accessPermitted()
		{
			this.barButtonTHEM.Enabled = true;
			barButtonXOA.Enabled = true;
			barButtonSUA.Enabled = true;
		}

		private void cOPHIEUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.cOPHIEUBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.cHUNGKHOANDataSet);

		}

		private void frmCoPhieu_Load(object sender, EventArgs e)
		{
			cHUNGKHOANDataSet.EnforceConstraints = false;
			this.cOPHIEUTableAdapter.Connection.ConnectionString = Program.connstr;
			this.cOPHIEUTableAdapter.Fill(this.cHUNGKHOANDataSet.COPHIEU);

			this.lENHDATTableAdapter.Connection.ConnectionString = Program.connstr;
			this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);

			this.sOHUUTableAdapter.Connection.ConnectionString = Program.connstr;
			this.sOHUUTableAdapter.Fill(this.cHUNGKHOANDataSet.SOHUU);
		}

		private void barButtonTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.status = "add";
			vitri = this.cOPHIEUBindingSource.Position;
			groupBox1.Enabled = true;
			this.cOPHIEUBindingSource.AddNew();

			this.accessDeny();
			this.barButtonGHI.Enabled = this.barButtonPHUCHOI.Enabled = true;
			this.cOPHIEUGridControl.Enabled = false;
		}

		private void barButtonPHUCHOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.cOPHIEUBindingSource.CancelEdit();
			if (barButtonTHEM.Enabled == false) cOPHIEUBindingSource.Position = this.vitri;
			this.cOPHIEUGridControl.Enabled = true;
			groupBox1.Enabled = false;
			this.barButtonTHEM.Enabled = this.barButtonXOA.Enabled = this.barButtonSUA.Enabled = this.barButtonREFRESH.Enabled = this.barButtonTHOAT.Enabled = true;
			this.barButtonGHI.Enabled = barButtonPHUCHOI.Enabled = false;
		}

		private void barButtonSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.status = "edit";
			vitri = this.cOPHIEUBindingSource.Position;
			groupBox1.Enabled = true;
			this.barButtonTHEM.Enabled = this.barButtonXOA.Enabled = this.barButtonSUA.Enabled = this.barButtonREFRESH.Enabled = this.barButtonTHOAT.Enabled = false;
			this.barButtonGHI.Enabled = barButtonPHUCHOI.Enabled = true;
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
			try
			{
				this.cOPHIEUTableAdapter.Fill(this.cHUNGKHOANDataSet.COPHIEU);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi tải lại: " + ex.Message, "", MessageBoxButtons.OK);
				return;
			}  
		}

		private void barButtonXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			string macp = "";
			if (this.sOHUUBindingSource.Count > 0) 
			{
				MessageBox.Show("Không thể xóa cổ phiếu vì đã có nhà đầu tư sở hữu!", "", MessageBoxButtons.OK);
				return;
			}
			if (this.lENHDATBindingSource.Count > 0)
			{
				MessageBox.Show("Không thể xóa cổ phiếu vì đã có lệnh đặt trên cổ phiếu này!", "", MessageBoxButtons.OK);
				return;
			}
			if (MessageBox.Show("Bạn có thật sự muốn xóa cổ phiếu này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				try
				{
					macp = ((DataRowView)cOPHIEUBindingSource[cOPHIEUBindingSource.Position])["MACP"].ToString();
					cOPHIEUBindingSource.RemoveCurrent();
					this.cOPHIEUTableAdapter.Connection.ConnectionString = Program.connstr;
					this.cOPHIEUTableAdapter.Update(this.cHUNGKHOANDataSet.COPHIEU);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi xóa cổ phiếu,hãy xóa lại!\n" + ex.Message, "", MessageBoxButtons.OK);
					this.cOPHIEUTableAdapter.Fill(this.cHUNGKHOANDataSet.COPHIEU);
					this.cOPHIEUBindingSource.Position = this.cOPHIEUBindingSource.Find("MACP", macp);
					return;
				}
			}
			if (cOPHIEUBindingSource.Count == 0) this.barButtonXOA.Enabled = false;
		}

		private void barButtonGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (this.txtMACP.Text.Trim() == "")
			{
				MessageBox.Show("Mã cổ phiếu không được thiếu!", "", MessageBoxButtons.OK);
				this.txtMACP.Focus();
				return;
			}
			if (this.txtTENCT.Text.Trim() == "")
			{
				MessageBox.Show("Tên công ty không được thiếu!", "", MessageBoxButtons.OK);
				this.txtTENCT.Focus();
				return;
			}
			if (this.txtDIACHI.Text.Trim() == "")
			{
				MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
				this.txtDIACHI.Focus();
				return;
			}
			if (this.txtDIENTHOAI.Text.Trim() == "")
			{
				MessageBox.Show("Điện thoại không được thiếu!", "", MessageBoxButtons.OK);
				this.txtDIENTHOAI.Focus();
				return;
			}
			if (this.txtFAX.Text.Trim() == "")
			{
				MessageBox.Show("Số Fax không được thiếu!", "", MessageBoxButtons.OK);
				this.txtFAX.Focus();
				return;
			}
			if (this.txtEMAIL.Text.Trim() == "")
			{
				MessageBox.Show("Email không được thiếu!", "", MessageBoxButtons.OK);
				this.txtEMAIL.Focus();
				return;
			}
			if (this.txtSOLUONG.Text.Trim() == "")
			{
				MessageBox.Show("Số lượng không được thiếu!", "", MessageBoxButtons.OK);
				this.txtSOLUONG.Focus();
				return;
			}

			if (this.status == "add")
			{
				SqlConnection sqlConnection = new SqlConnection(Program.connstr);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
				sqlCommand.CommandText = "sp_CheckMACPExists";
				sqlCommand.Parameters.Add(new SqlParameter("@MACP", this.txtMACP.Text.Trim()));
				SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
				sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
				sqlCommand.Parameters.Add(sqlParameter);
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				int result = (int)sqlCommand.Parameters["@return"].Value;
				if (result == 0)
				{
					try
					{
						this.cOPHIEUBindingSource.EndEdit();
						this.cOPHIEUBindingSource.ResetCurrentItem();
						this.cOPHIEUTableAdapter.Connection.ConnectionString = Program.connstr;
						this.cOPHIEUTableAdapter.Update(this.cHUNGKHOANDataSet.COPHIEU);

						this.status = "";
						MessageBox.Show("Đã thêm mới!");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
						return;
					}

					sqlConnection.Close();
				}
				else
				{
					MessageBox.Show("Mã bị trùng!");
					return;
				}
			}
			else if (this.status == "edit")
			{
				


				try
				{
					this.cOPHIEUBindingSource.EndEdit();
					this.cOPHIEUBindingSource.ResetCurrentItem();
					this.cOPHIEUTableAdapter.Connection.ConnectionString = Program.connstr;
					this.cOPHIEUTableAdapter.Update(this.cHUNGKHOANDataSet.COPHIEU);
					MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK);
					accessPermitted();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi sửa. \n" + ex.Message, "", MessageBoxButtons.OK);
					return;
				}
			}

			this.barButtonTHEM.Enabled = this.barButtonXOA.Enabled = this.barButtonSUA.Enabled = this.barButtonREFRESH.Enabled = this.barButtonTHOAT.Enabled = true;
			this.barButtonGHI.Enabled = barButtonPHUCHOI.Enabled = false;

			this.groupBox1.Enabled = false;
		}
	}
}
