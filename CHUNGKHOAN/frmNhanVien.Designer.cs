namespace CHUNGKHOAN
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
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
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENGC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DANGHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(383, 47);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(37, 20);
            hOLabel.TabIndex = 0;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(84, 47);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(44, 20);
            tENLabel.TabIndex = 2;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(369, 175);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(51, 20);
            pHAILabel.TabIndex = 4;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(322, 115);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(98, 20);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(59, 236);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 20);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(83, 173);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(45, 20);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "SDT:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(68, 110);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(60, 20);
            cMNDLabel.TabIndex = 14;
            cMNDLabel.Text = "CMND:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 692);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 661);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 661);
            // 
            // cHUNGKHOANDataSet
            // 
            this.cHUNGKHOANDataSet.DataSetName = "CHUNGKHOANDataSet";
            this.cHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.cHUNGKHOANDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONGTYTableAdapter = null;
            this.tableAdapterManager.COPHIEUTableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = null;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.LICHSU_GIATableAdapter = null;
            this.tableAdapterManager.LICHSU_QDTableAdapter = null;
            this.tableAdapterManager.LOAILENHTableAdapter = null;
            this.tableAdapterManager.NGANHANGTableAdapter = null;
            this.tableAdapterManager.NHADAUTUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.QUIDINHTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.TRANGTHAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CHUNGKHOAN.CHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENGC
            // 
            this.nHANVIENGC.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGC.Dock = System.Windows.Forms.DockStyle.Top;
            this.nHANVIENGC.Location = new System.Drawing.Point(0, 31);
            this.nHANVIENGC.MainView = this.gridView1;
            this.nHANVIENGC.MenuManager = this.barManager1;
            this.nHANVIENGC.Name = "nHANVIENGC";
            this.nHANVIENGC.Size = new System.Drawing.Size(1200, 244);
            this.nHANVIENGC.TabIndex = 5;
            this.nHANVIENGC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.HO,
            this.TEN,
            this.PHAI,
            this.NGAYSINH,
            this.DIACHI,
            this.SDT,
            this.DANGHI,
            this.MACT,
            this.CMND});
            this.gridView1.GridControl = this.nHANVIENGC;
            this.gridView1.Name = "gridView1";
            // 
            // MANV
            // 
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            this.MANV.Width = 53;
            // 
            // HO
            // 
            this.HO.FieldName = "HO";
            this.HO.Name = "HO";
            this.HO.Visible = true;
            this.HO.VisibleIndex = 1;
            this.HO.Width = 70;
            // 
            // TEN
            // 
            this.TEN.FieldName = "TEN";
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 2;
            this.TEN.Width = 70;
            // 
            // PHAI
            // 
            this.PHAI.FieldName = "PHAI";
            this.PHAI.Name = "PHAI";
            this.PHAI.Visible = true;
            this.PHAI.VisibleIndex = 3;
            this.PHAI.Width = 44;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Visible = true;
            this.NGAYSINH.VisibleIndex = 4;
            this.NGAYSINH.Width = 74;
            // 
            // DIACHI
            // 
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 5;
            this.DIACHI.Width = 74;
            // 
            // SDT
            // 
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 7;
            this.SDT.Width = 74;
            // 
            // DANGHI
            // 
            this.DANGHI.FieldName = "DANGHI";
            this.DANGHI.Name = "DANGHI";
            this.DANGHI.Visible = true;
            this.DANGHI.VisibleIndex = 8;
            this.DANGHI.Width = 74;
            // 
            // MACT
            // 
            this.MACT.FieldName = "MACT";
            this.MACT.Name = "MACT";
            this.MACT.Visible = true;
            this.MACT.VisibleIndex = 9;
            this.MACT.Width = 74;
            // 
            // CMND
            // 
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 6;
            this.CMND.Width = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Controls.Add(this.cMNDTextEdit);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextEdit);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.dIACHITextEdit);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.nGAYSINHDateEdit);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(tENLabel);
            this.groupBox1.Controls.Add(this.tENTextEdit);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 417);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nam);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(426, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 69);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(74, 35);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(60, 24);
            this.Nam.TabIndex = 17;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nữ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(134, 112);
            this.cMNDTextEdit.MenuManager = this.barManager1;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(138, 20);
            this.cMNDTextEdit.TabIndex = 15;
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(134, 173);
            this.sDTTextEdit.MenuManager = this.barManager1;
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(138, 20);
            this.sDTTextEdit.TabIndex = 11;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(134, 238);
            this.dIACHITextEdit.MenuManager = this.barManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(138, 20);
            this.dIACHITextEdit.TabIndex = 9;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(426, 112);
            this.nGAYSINHDateEdit.MenuManager = this.barManager1;
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(134, 20);
            this.nGAYSINHDateEdit.TabIndex = 7;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(134, 44);
            this.tENTextEdit.MenuManager = this.barManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Size = new System.Drawing.Size(138, 20);
            this.tENTextEdit.TabIndex = 3;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(426, 49);
            this.hOTextEdit.MenuManager = this.barManager1;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Size = new System.Drawing.Size(134, 20);
            this.hOTextEdit.TabIndex = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nHANVIENGC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUNGKHOANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private CHUNGKHOANDataSet cHUNGKHOANDataSet;
        private CHUNGKHOANDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private CHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem barButtonTHEM;
        private DevExpress.XtraBars.BarButtonItem barButtonSUA;
        private DevExpress.XtraBars.BarButtonItem barButtonGHI;
        private DevExpress.XtraBars.BarButtonItem barButtonXOA;
        private DevExpress.XtraBars.BarButtonItem barButtonPHUCHOI;
        private DevExpress.XtraBars.BarButtonItem barButtonREFRESH;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraGrid.GridControl nHANVIENGC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn PHAI;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn DANGHI;
        private DevExpress.XtraGrid.Columns.GridColumn MACT;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Nam;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraBars.BarButtonItem barButtonTHOAT;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
    }
}