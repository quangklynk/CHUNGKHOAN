namespace CHUNGKHOAN
{
	partial class frmCoPhieu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label mACPLabel;
			System.Windows.Forms.Label tENCTLabel;
			System.Windows.Forms.Label dIACHILabel;
			System.Windows.Forms.Label dIENTHOAILabel;
			System.Windows.Forms.Label fAXLabel;
			System.Windows.Forms.Label eMAILLabel;
			System.Windows.Forms.Label sOLUONGLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoPhieu));
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barButtonTHEM = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonSUA = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonGHI = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonXOA = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonPHUCHOI = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonREFRESH = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonTHOAT = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.cHUNGKHOANDataSet = new CHUNGKHOAN.CHUNGKHOANDataSet();
			this.cOPHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cOPHIEUTableAdapter = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.COPHIEUTableAdapter();
			this.tableAdapterManager = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
			this.cOPHIEUGridControl = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.MACP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TENCT = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.FAX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSOLUONG = new System.Windows.Forms.TextBox();
			this.txtEMAIL = new DevExpress.XtraEditors.TextEdit();
			this.txtFAX = new DevExpress.XtraEditors.TextEdit();
			this.txtDIENTHOAI = new DevExpress.XtraEditors.TextEdit();
			this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
			this.txtTENCT = new DevExpress.XtraEditors.TextEdit();
			this.txtMACP = new DevExpress.XtraEditors.TextEdit();
			this.sOHUUBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sOHUUTableAdapter = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.SOHUUTableAdapter();
			this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lENHDATTableAdapter = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
			mACPLabel = new System.Windows.Forms.Label();
			tENCTLabel = new System.Windows.Forms.Label();
			dIACHILabel = new System.Windows.Forms.Label();
			dIENTHOAILabel = new System.Windows.Forms.Label();
			fAXLabel = new System.Windows.Forms.Label();
			eMAILLabel = new System.Windows.Forms.Label();
			sOLUONGLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cOPHIEUBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cOPHIEUGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEMAIL.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFAX.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDIENTHOAI.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTENCT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMACP.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mACPLabel
			// 
			mACPLabel.AutoSize = true;
			mACPLabel.Location = new System.Drawing.Point(63, 84);
			mACPLabel.Name = "mACPLabel";
			mACPLabel.Size = new System.Drawing.Size(77, 25);
			mACPLabel.TabIndex = 0;
			mACPLabel.Text = "MACP:";
			// 
			// tENCTLabel
			// 
			tENCTLabel.AutoSize = true;
			tENCTLabel.Location = new System.Drawing.Point(54, 127);
			tENCTLabel.Name = "tENCTLabel";
			tENCTLabel.Size = new System.Drawing.Size(86, 25);
			tENCTLabel.TabIndex = 2;
			tENCTLabel.Text = "TENCT:";
			// 
			// dIACHILabel
			// 
			dIACHILabel.AutoSize = true;
			dIACHILabel.Location = new System.Drawing.Point(55, 179);
			dIACHILabel.Name = "dIACHILabel";
			dIACHILabel.Size = new System.Drawing.Size(85, 25);
			dIACHILabel.TabIndex = 4;
			dIACHILabel.Text = "DIACHI:";
			// 
			// dIENTHOAILabel
			// 
			dIENTHOAILabel.AutoSize = true;
			dIENTHOAILabel.Location = new System.Drawing.Point(14, 231);
			dIENTHOAILabel.Name = "dIENTHOAILabel";
			dIENTHOAILabel.Size = new System.Drawing.Size(126, 25);
			dIENTHOAILabel.TabIndex = 6;
			dIENTHOAILabel.Text = "DIENTHOAI:";
			// 
			// fAXLabel
			// 
			fAXLabel.AutoSize = true;
			fAXLabel.Location = new System.Drawing.Point(82, 276);
			fAXLabel.Name = "fAXLabel";
			fAXLabel.Size = new System.Drawing.Size(58, 25);
			fAXLabel.TabIndex = 8;
			fAXLabel.Text = "FAX:";
			// 
			// eMAILLabel
			// 
			eMAILLabel.AutoSize = true;
			eMAILLabel.Location = new System.Drawing.Point(332, 84);
			eMAILLabel.Name = "eMAILLabel";
			eMAILLabel.Size = new System.Drawing.Size(78, 25);
			eMAILLabel.TabIndex = 10;
			eMAILLabel.Text = "EMAIL:";
			// 
			// sOLUONGLabel
			// 
			sOLUONGLabel.AutoSize = true;
			sOLUONGLabel.Location = new System.Drawing.Point(292, 127);
			sOLUONGLabel.Name = "sOLUONGLabel";
			sOLUONGLabel.Size = new System.Drawing.Size(118, 25);
			sOLUONGLabel.TabIndex = 12;
			sOLUONGLabel.Text = "SOLUONG:";
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonTHEM,
            this.barButtonXOA,
            this.barButtonSUA,
            this.barButtonPHUCHOI,
            this.barButtonREFRESH,
            this.barButtonGHI,
            this.barButtonTHOAT});
			this.barManager1.MaxItemId = 7;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonTHEM),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonSUA),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonGHI),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonXOA),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonPHUCHOI),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonREFRESH),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonTHOAT)});
			this.bar1.Text = "Tools";
			// 
			// barButtonTHEM
			// 
			this.barButtonTHEM.Caption = "Thêm";
			this.barButtonTHEM.Id = 0;
			this.barButtonTHEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTHEM.ImageOptions.Image")));
			this.barButtonTHEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonTHEM.ImageOptions.LargeImage")));
			this.barButtonTHEM.Name = "barButtonTHEM";
			this.barButtonTHEM.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTHEM_ItemClick);
			// 
			// barButtonSUA
			// 
			this.barButtonSUA.Caption = "Sửa";
			this.barButtonSUA.Id = 2;
			this.barButtonSUA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSUA.ImageOptions.Image")));
			this.barButtonSUA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSUA.ImageOptions.LargeImage")));
			this.barButtonSUA.Name = "barButtonSUA";
			this.barButtonSUA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonSUA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSUA_ItemClick);
			// 
			// barButtonGHI
			// 
			this.barButtonGHI.Caption = "Ghi";
			this.barButtonGHI.Id = 5;
			this.barButtonGHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonGHI.ImageOptions.Image")));
			this.barButtonGHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonGHI.ImageOptions.LargeImage")));
			this.barButtonGHI.Name = "barButtonGHI";
			this.barButtonGHI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonGHI_ItemClick);
			// 
			// barButtonXOA
			// 
			this.barButtonXOA.Caption = "Xóa";
			this.barButtonXOA.Id = 1;
			this.barButtonXOA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonXOA.ImageOptions.Image")));
			this.barButtonXOA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonXOA.ImageOptions.LargeImage")));
			this.barButtonXOA.Name = "barButtonXOA";
			this.barButtonXOA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXOA_ItemClick);
			// 
			// barButtonPHUCHOI
			// 
			this.barButtonPHUCHOI.Caption = "Phục hồi";
			this.barButtonPHUCHOI.Id = 3;
			this.barButtonPHUCHOI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPHUCHOI.ImageOptions.Image")));
			this.barButtonPHUCHOI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonPHUCHOI.ImageOptions.LargeImage")));
			this.barButtonPHUCHOI.Name = "barButtonPHUCHOI";
			this.barButtonPHUCHOI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonPHUCHOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPHUCHOI_ItemClick);
			// 
			// barButtonREFRESH
			// 
			this.barButtonREFRESH.Caption = "Refresh";
			this.barButtonREFRESH.Id = 4;
			this.barButtonREFRESH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonREFRESH.ImageOptions.Image")));
			this.barButtonREFRESH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonREFRESH.ImageOptions.LargeImage")));
			this.barButtonREFRESH.Name = "barButtonREFRESH";
			this.barButtonREFRESH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonREFRESH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonREFRESH_ItemClick);
			// 
			// barButtonTHOAT
			// 
			this.barButtonTHOAT.Caption = "Thoát";
			this.barButtonTHOAT.Id = 6;
			this.barButtonTHOAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTHOAT.ImageOptions.Image")));
			this.barButtonTHOAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonTHOAT.ImageOptions.LargeImage")));
			this.barButtonTHOAT.Name = "barButtonTHOAT";
			this.barButtonTHOAT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barButtonTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTHOAT_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(1200, 37);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 710);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(1200, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 673);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1200, 37);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 673);
			// 
			// cHUNGKHOANDataSet
			// 
			this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
			this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cOPHIEUBindingSource
			// 
			this.cOPHIEUBindingSource.DataMember = "COPHIEU";
			this.cOPHIEUBindingSource.DataSource = this.cHUNGKHOANDataSet;
			// 
			// cOPHIEUTableAdapter
			// 
			this.cOPHIEUTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CONGTYTableAdapter = null;
			this.tableAdapterManager.COPHIEUTableAdapter = this.cOPHIEUTableAdapter;
			this.tableAdapterManager.DANGKYTableAdapter = null;
			this.tableAdapterManager.LENHDATTableAdapter = null;
			this.tableAdapterManager.LENHKHOPTableAdapter = null;
			this.tableAdapterManager.LICHSU_GIATableAdapter = null;
			this.tableAdapterManager.LICHSU_QDTableAdapter = null;
			this.tableAdapterManager.LOAILENHTableAdapter = null;
			this.tableAdapterManager.NGANHANGTableAdapter = null;
			this.tableAdapterManager.NHADAUTUTableAdapter = null;
			this.tableAdapterManager.NHANVIENTableAdapter = null;
			this.tableAdapterManager.QUIDINHTableAdapter = null;
			this.tableAdapterManager.SOHUUTableAdapter = null;
			this.tableAdapterManager.TAIKHOANTableAdapter = null;
			this.tableAdapterManager.TRANGTHAITableAdapter = null;
			this.tableAdapterManager.UpdateOrder = CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// cOPHIEUGridControl
			// 
			this.cOPHIEUGridControl.DataSource = this.cOPHIEUBindingSource;
			this.cOPHIEUGridControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.cOPHIEUGridControl.Location = new System.Drawing.Point(0, 37);
			this.cOPHIEUGridControl.MainView = this.gridView1;
			this.cOPHIEUGridControl.MenuManager = this.barManager1;
			this.cOPHIEUGridControl.Name = "cOPHIEUGridControl";
			this.cOPHIEUGridControl.Size = new System.Drawing.Size(1200, 347);
			this.cOPHIEUGridControl.TabIndex = 5;
			this.cOPHIEUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACP,
            this.TENCT,
            this.DIACHI,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.SOLUONG});
			this.gridView1.GridControl = this.cOPHIEUGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// MACP
			// 
			this.MACP.FieldName = "MÃ CỔ PHIẾU";
			this.MACP.MinWidth = 25;
			this.MACP.Name = "MACP";
			this.MACP.Visible = true;
			this.MACP.VisibleIndex = 0;
			this.MACP.Width = 94;
			// 
			// TENCT
			// 
			this.TENCT.FieldName = "TÊN CỔ PHIẾU";
			this.TENCT.MinWidth = 25;
			this.TENCT.Name = "TENCT";
			this.TENCT.Visible = true;
			this.TENCT.VisibleIndex = 1;
			this.TENCT.Width = 94;
			// 
			// DIACHI
			// 
			this.DIACHI.FieldName = "ĐỊA CHỈ";
			this.DIACHI.MinWidth = 25;
			this.DIACHI.Name = "DIACHI";
			this.DIACHI.Visible = true;
			this.DIACHI.VisibleIndex = 2;
			this.DIACHI.Width = 94;
			// 
			// DIENTHOAI
			// 
			this.DIENTHOAI.FieldName = "ĐIỆN THOẠI";
			this.DIENTHOAI.MinWidth = 25;
			this.DIENTHOAI.Name = "DIENTHOAI";
			this.DIENTHOAI.Visible = true;
			this.DIENTHOAI.VisibleIndex = 3;
			this.DIENTHOAI.Width = 94;
			// 
			// FAX
			// 
			this.FAX.FieldName = "FAX";
			this.FAX.MinWidth = 25;
			this.FAX.Name = "FAX";
			this.FAX.Visible = true;
			this.FAX.VisibleIndex = 4;
			this.FAX.Width = 94;
			// 
			// EMAIL
			// 
			this.EMAIL.FieldName = "EMAIL";
			this.EMAIL.MinWidth = 25;
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.Visible = true;
			this.EMAIL.VisibleIndex = 5;
			this.EMAIL.Width = 94;
			// 
			// SOLUONG
			// 
			this.SOLUONG.FieldName = "SỐ LƯỢNG";
			this.SOLUONG.MinWidth = 25;
			this.SOLUONG.Name = "SOLUONG";
			this.SOLUONG.Visible = true;
			this.SOLUONG.VisibleIndex = 6;
			this.SOLUONG.Width = 94;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(sOLUONGLabel);
			this.groupBox1.Controls.Add(this.txtSOLUONG);
			this.groupBox1.Controls.Add(eMAILLabel);
			this.groupBox1.Controls.Add(this.txtEMAIL);
			this.groupBox1.Controls.Add(fAXLabel);
			this.groupBox1.Controls.Add(this.txtFAX);
			this.groupBox1.Controls.Add(dIENTHOAILabel);
			this.groupBox1.Controls.Add(this.txtDIENTHOAI);
			this.groupBox1.Controls.Add(dIACHILabel);
			this.groupBox1.Controls.Add(this.txtDIACHI);
			this.groupBox1.Controls.Add(tENCTLabel);
			this.groupBox1.Controls.Add(this.txtTENCT);
			this.groupBox1.Controls.Add(mACPLabel);
			this.groupBox1.Controls.Add(this.txtMACP);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 384);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1200, 326);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// txtSOLUONG
			// 
			this.txtSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOPHIEUBindingSource, "SOLUONG", true));
			this.txtSOLUONG.Location = new System.Drawing.Point(416, 124);
			this.txtSOLUONG.Name = "txtSOLUONG";
			this.txtSOLUONG.Size = new System.Drawing.Size(100, 30);
			this.txtSOLUONG.TabIndex = 13;
			// 
			// txtEMAIL
			// 
			this.txtEMAIL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "EMAIL", true));
			this.txtEMAIL.Location = new System.Drawing.Point(416, 81);
			this.txtEMAIL.MenuManager = this.barManager1;
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(125, 22);
			this.txtEMAIL.TabIndex = 11;
			// 
			// txtFAX
			// 
			this.txtFAX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "FAX", true));
			this.txtFAX.Location = new System.Drawing.Point(146, 273);
			this.txtFAX.MenuManager = this.barManager1;
			this.txtFAX.Name = "txtFAX";
			this.txtFAX.Size = new System.Drawing.Size(125, 22);
			this.txtFAX.TabIndex = 9;
			// 
			// txtDIENTHOAI
			// 
			this.txtDIENTHOAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "DIENTHOAI", true));
			this.txtDIENTHOAI.Location = new System.Drawing.Point(146, 228);
			this.txtDIENTHOAI.MenuManager = this.barManager1;
			this.txtDIENTHOAI.Name = "txtDIENTHOAI";
			this.txtDIENTHOAI.Size = new System.Drawing.Size(125, 22);
			this.txtDIENTHOAI.TabIndex = 7;
			// 
			// txtDIACHI
			// 
			this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "DIACHI", true));
			this.txtDIACHI.Location = new System.Drawing.Point(146, 176);
			this.txtDIACHI.MenuManager = this.barManager1;
			this.txtDIACHI.Name = "txtDIACHI";
			this.txtDIACHI.Size = new System.Drawing.Size(125, 22);
			this.txtDIACHI.TabIndex = 5;
			// 
			// txtTENCT
			// 
			this.txtTENCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "TENCT", true));
			this.txtTENCT.Location = new System.Drawing.Point(146, 124);
			this.txtTENCT.MenuManager = this.barManager1;
			this.txtTENCT.Name = "txtTENCT";
			this.txtTENCT.Size = new System.Drawing.Size(125, 22);
			this.txtTENCT.TabIndex = 3;
			// 
			// txtMACP
			// 
			this.txtMACP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cOPHIEUBindingSource, "MACP", true));
			this.txtMACP.Location = new System.Drawing.Point(146, 81);
			this.txtMACP.MenuManager = this.barManager1;
			this.txtMACP.Name = "txtMACP";
			this.txtMACP.Size = new System.Drawing.Size(125, 22);
			this.txtMACP.TabIndex = 1;
			// 
			// sOHUUBindingSource
			// 
			this.sOHUUBindingSource.DataMember = "FK_SOHUU_COPHIEU";
			this.sOHUUBindingSource.DataSource = this.cOPHIEUBindingSource;
			// 
			// sOHUUTableAdapter
			// 
			this.sOHUUTableAdapter.ClearBeforeFill = true;
			// 
			// lENHDATBindingSource
			// 
			this.lENHDATBindingSource.DataMember = "FK_LENHDAT_COPHIEU";
			this.lENHDATBindingSource.DataSource = this.cOPHIEUBindingSource;
			// 
			// lENHDATTableAdapter
			// 
			this.lENHDATTableAdapter.ClearBeforeFill = true;
			// 
			// frmCoPhieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 710);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cOPHIEUGridControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmCoPhieu";
			this.Text = "frmCoPhieu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmCoPhieu_Load);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cOPHIEUBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cOPHIEUGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEMAIL.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFAX.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDIENTHOAI.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTENCT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMACP.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sOHUUBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.BarButtonItem barButtonTHEM;
		private DevExpress.XtraBars.BarButtonItem barButtonSUA;
		private DevExpress.XtraBars.BarButtonItem barButtonGHI;
		private DevExpress.XtraBars.BarButtonItem barButtonXOA;
		private DevExpress.XtraBars.BarButtonItem barButtonPHUCHOI;
		private DevExpress.XtraBars.BarButtonItem barButtonREFRESH;
		private DevExpress.XtraBars.BarButtonItem barButtonTHOAT;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private System.Windows.Forms.BindingSource cOPHIEUBindingSource;
		private CHUNGKHOANDataSet cHUNGKHOANDataSet;
		private CHUNGKHOANDataSetTableAdapters.COPHIEUTableAdapter cOPHIEUTableAdapter;
		private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSOLUONG;
		private DevExpress.XtraEditors.TextEdit txtEMAIL;
		private DevExpress.XtraEditors.TextEdit txtFAX;
		private DevExpress.XtraEditors.TextEdit txtDIENTHOAI;
		private DevExpress.XtraEditors.TextEdit txtDIACHI;
		private DevExpress.XtraEditors.TextEdit txtTENCT;
		private DevExpress.XtraEditors.TextEdit txtMACP;
		private DevExpress.XtraGrid.GridControl cOPHIEUGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn MACP;
		private DevExpress.XtraGrid.Columns.GridColumn TENCT;
		private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
		private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
		private DevExpress.XtraGrid.Columns.GridColumn FAX;
		private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
		private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
		private System.Windows.Forms.BindingSource sOHUUBindingSource;
		private CHUNGKHOANDataSetTableAdapters.SOHUUTableAdapter sOHUUTableAdapter;
		private System.Windows.Forms.BindingSource lENHDATBindingSource;
		private CHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
	}
}