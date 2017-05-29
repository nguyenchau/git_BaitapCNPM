namespace Phần_mềm_QLĐ
{
    partial class HK_HP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dtgDiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnLuumon = new DevComponents.DotNetBar.ButtonX();
            this.btnXoamon = new DevComponents.DotNetBar.ButtonX();
            this.btnThemmon = new DevComponents.DotNetBar.ButtonX();
            this.txtTenmon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbomonhp = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cboHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThoatHK = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.cboLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnCapnhatdulieu1 = new DevComponents.DotNetBar.ButtonX();
            this.txtSoTC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMamon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnLuuhk = new DevComponents.DotNetBar.ButtonX();
            this.btnXoahk = new DevComponents.DotNetBar.ButtonX();
            this.btnThemhk = new DevComponents.DotNetBar.ButtonX();
            this.txtMaHK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.qLDDataSet5 = new Phần_mềm_QLĐ.QLDDataSet5();
            this.diemHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemHPTableAdapter = new Phần_mềm_QLĐ.QLDDataSet5TableAdapters.DiemHPTableAdapter();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemGKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dtgDiem);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(915, 414);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // dtgDiem
            // 
            this.dtgDiem.AllowUserToAddRows = false;
            this.dtgDiem.AutoGenerateColumns = false;
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.diemCCDataGridViewTextBoxColumn,
            this.diemGKDataGridViewTextBoxColumn,
            this.diemCKDataGridViewTextBoxColumn});
            this.dtgDiem.DataSource = this.diemHPBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgDiem.Location = new System.Drawing.Point(142, 198);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.Size = new System.Drawing.Size(698, 213);
            this.dtgDiem.TabIndex = 3;
            this.dtgDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiem_CellContentClick);
            this.dtgDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiem_CellEndEdit);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnLuumon);
            this.groupPanel1.Controls.Add(this.btnXoamon);
            this.groupPanel1.Controls.Add(this.btnThemmon);
            this.groupPanel1.Controls.Add(this.txtTenmon);
            this.groupPanel1.Controls.Add(this.cbomonhp);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.cboHK);
            this.groupPanel1.Controls.Add(this.btnThoatHK);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.cboLop);
            this.groupPanel1.Controls.Add(this.btnCapnhatdulieu1);
            this.groupPanel1.Controls.Add(this.txtSoTC);
            this.groupPanel1.Controls.Add(this.txtMamon);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btnLuuhk);
            this.groupPanel1.Controls.Add(this.btnXoahk);
            this.groupPanel1.Controls.Add(this.btnThemhk);
            this.groupPanel1.Controls.Add(this.txtMaHK);
            this.groupPanel1.Controls.Add(this.txtTenHK);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel1.Location = new System.Drawing.Point(142, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(695, 195);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "Cập nhật học kỳ- môn học phần- điểm";
            // 
            // btnLuumon
            // 
            this.btnLuumon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuumon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuumon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuumon.Location = new System.Drawing.Point(540, 94);
            this.btnLuumon.Name = "btnLuumon";
            this.btnLuumon.Size = new System.Drawing.Size(73, 23);
            this.btnLuumon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuumon.TabIndex = 33;
            this.btnLuumon.Text = "Lưu lại";
            this.btnLuumon.Click += new System.EventHandler(this.btnLuumon_Click);
            // 
            // btnXoamon
            // 
            this.btnXoamon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoamon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoamon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoamon.Location = new System.Drawing.Point(619, 94);
            this.btnXoamon.Name = "btnXoamon";
            this.btnXoamon.Size = new System.Drawing.Size(73, 23);
            this.btnXoamon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoamon.TabIndex = 32;
            this.btnXoamon.Text = "Xóa";
            this.btnXoamon.Click += new System.EventHandler(this.btnXoamon_Click);
            // 
            // btnThemmon
            // 
            this.btnThemmon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemmon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemmon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemmon.Location = new System.Drawing.Point(461, 94);
            this.btnThemmon.Name = "btnThemmon";
            this.btnThemmon.Size = new System.Drawing.Size(73, 23);
            this.btnThemmon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemmon.TabIndex = 31;
            this.btnThemmon.Text = "Thêm mới";
            this.btnThemmon.Click += new System.EventHandler(this.btnThemmon_Click);
            // 
            // txtTenmon
            // 
            // 
            // 
            // 
            this.txtTenmon.Border.Class = "TextBoxBorder";
            this.txtTenmon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenmon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenmon.Location = new System.Drawing.Point(249, 94);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(136, 23);
            this.txtTenmon.TabIndex = 30;
            // 
            // cbomonhp
            // 
            this.cbomonhp.DisplayMember = "Text";
            this.cbomonhp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbomonhp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbomonhp.FormattingEnabled = true;
            this.cbomonhp.ItemHeight = 17;
            this.cbomonhp.Location = new System.Drawing.Point(3, 94);
            this.cbomonhp.Name = "cbomonhp";
            this.cbomonhp.Size = new System.Drawing.Size(161, 23);
            this.cbomonhp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbomonhp.TabIndex = 29;
            this.cbomonhp.SelectedIndexChanged += new System.EventHandler(this.cbomonhp_SelectedIndexChanged);
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX11.Location = new System.Drawing.Point(361, 12);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(80, 23);
            this.labelX11.TabIndex = 28;
            this.labelX11.Text = "Tên học kỳ:";
            // 
            // cboHK
            // 
            this.cboHK.DisplayMember = "Text";
            this.cboHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboHK.FormattingEnabled = true;
            this.cboHK.ItemHeight = 17;
            this.cboHK.Location = new System.Drawing.Point(170, 36);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(86, 23);
            this.cboHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHK.TabIndex = 27;
            this.cboHK.SelectedIndexChanged += new System.EventHandler(this.cboHK_SelectedIndexChanged);
            // 
            // btnThoatHK
            // 
            this.btnThoatHK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatHK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatHK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatHK.Location = new System.Drawing.Point(613, 140);
            this.btnThoatHK.Name = "btnThoatHK";
            this.btnThoatHK.Size = new System.Drawing.Size(73, 23);
            this.btnThoatHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoatHK.TabIndex = 26;
            this.btnThoatHK.Text = "Thoát";
            this.btnThoatHK.Click += new System.EventHandler(this.btnThoatHK_Click);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX9.Location = new System.Drawing.Point(3, 12);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(99, 23);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.DisplayMember = "Text";
            this.cboLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLop.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.ItemHeight = 17;
            this.cboLop.Location = new System.Drawing.Point(3, 36);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(161, 23);
            this.cboLop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLop.TabIndex = 22;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // btnCapnhatdulieu1
            // 
            this.btnCapnhatdulieu1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapnhatdulieu1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapnhatdulieu1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapnhatdulieu1.Location = new System.Drawing.Point(3, 140);
            this.btnCapnhatdulieu1.Name = "btnCapnhatdulieu1";
            this.btnCapnhatdulieu1.Size = new System.Drawing.Size(161, 23);
            this.btnCapnhatdulieu1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapnhatdulieu1.TabIndex = 19;
            this.btnCapnhatdulieu1.Text = "Cập nhật dữ liệu";
            this.btnCapnhatdulieu1.Click += new System.EventHandler(this.btnCapnhatdulieu1_Click);
            // 
            // txtSoTC
            // 
            // 
            // 
            // 
            this.txtSoTC.Border.Class = "TextBoxBorder";
            this.txtSoTC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoTC.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTC.Location = new System.Drawing.Point(391, 94);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(69, 23);
            this.txtSoTC.TabIndex = 16;
            // 
            // txtMamon
            // 
            // 
            // 
            // 
            this.txtMamon.Border.Class = "TextBoxBorder";
            this.txtMamon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMamon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMamon.Location = new System.Drawing.Point(170, 94);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(71, 23);
            this.txtMamon.TabIndex = 14;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.Location = new System.Drawing.Point(390, 65);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(70, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Số TC:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.Location = new System.Drawing.Point(247, 65);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Tên môn:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(170, 65);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(71, 23);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Mã môn:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(3, 65);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Môn học phần:";
            // 
            // btnLuuhk
            // 
            this.btnLuuhk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuhk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuhk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuuhk.Location = new System.Drawing.Point(540, 36);
            this.btnLuuhk.Name = "btnLuuhk";
            this.btnLuuhk.Size = new System.Drawing.Size(73, 23);
            this.btnLuuhk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuhk.TabIndex = 6;
            this.btnLuuhk.Text = "Lưu lại";
            this.btnLuuhk.Click += new System.EventHandler(this.btnLuuhk_Click);
            // 
            // btnXoahk
            // 
            this.btnXoahk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoahk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoahk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoahk.Location = new System.Drawing.Point(619, 36);
            this.btnXoahk.Name = "btnXoahk";
            this.btnXoahk.Size = new System.Drawing.Size(73, 23);
            this.btnXoahk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoahk.TabIndex = 5;
            this.btnXoahk.Text = "Xóa";
            this.btnXoahk.Click += new System.EventHandler(this.btnXoahk_Click);
            // 
            // btnThemhk
            // 
            this.btnThemhk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemhk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemhk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemhk.Location = new System.Drawing.Point(461, 36);
            this.btnThemhk.Name = "btnThemhk";
            this.btnThemhk.Size = new System.Drawing.Size(73, 23);
            this.btnThemhk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemhk.TabIndex = 4;
            this.btnThemhk.Text = "Thêm mới";
            this.btnThemhk.Click += new System.EventHandler(this.btnThemhk_Click);
            // 
            // txtMaHK
            // 
            // 
            // 
            // 
            this.txtMaHK.Border.Class = "TextBoxBorder";
            this.txtMaHK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaHK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHK.Location = new System.Drawing.Point(265, 36);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(67, 23);
            this.txtMaHK.TabIndex = 3;
            // 
            // txtTenHK
            // 
            // 
            // 
            // 
            this.txtTenHK.Border.Class = "TextBoxBorder";
            this.txtTenHK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenHK.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHK.Location = new System.Drawing.Point(361, 36);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(70, 23);
            this.txtTenHK.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(265, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(80, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã học kỳ:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(170, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Học kỳ:";
            // 
            // qLDDataSet5
            // 
            this.qLDDataSet5.DataSetName = "QLDDataSet5";
            this.qLDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diemHPBindingSource
            // 
            this.diemHPBindingSource.DataMember = "DiemHP";
            this.diemHPBindingSource.DataSource = this.qLDDataSet5;
            // 
            // diemHPTableAdapter
            // 
            this.diemHPTableAdapter.ClearBeforeFill = true;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MaSV";
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // diemCCDataGridViewTextBoxColumn
            // 
            this.diemCCDataGridViewTextBoxColumn.DataPropertyName = "DiemCC";
            this.diemCCDataGridViewTextBoxColumn.HeaderText = "DiemCC";
            this.diemCCDataGridViewTextBoxColumn.Name = "diemCCDataGridViewTextBoxColumn";
            // 
            // diemGKDataGridViewTextBoxColumn
            // 
            this.diemGKDataGridViewTextBoxColumn.DataPropertyName = "DiemGK";
            this.diemGKDataGridViewTextBoxColumn.HeaderText = "DiemGK";
            this.diemGKDataGridViewTextBoxColumn.Name = "diemGKDataGridViewTextBoxColumn";
            // 
            // diemCKDataGridViewTextBoxColumn
            // 
            this.diemCKDataGridViewTextBoxColumn.DataPropertyName = "DiemCK";
            this.diemCKDataGridViewTextBoxColumn.HeaderText = "DiemCK";
            this.diemCKDataGridViewTextBoxColumn.Name = "diemCKDataGridViewTextBoxColumn";
            // 
            // HK_HP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 414);
            this.Controls.Add(this.panelEx1);
            this.Name = "HK_HP";
            this.Text = "HK_HP";
            this.Load += new System.EventHandler(this.HK_HP_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgDiem;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnLuumon;
        private DevComponents.DotNetBar.ButtonX btnXoamon;
        private DevComponents.DotNetBar.ButtonX btnThemmon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenmon;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbomonhp;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHK;
        private DevComponents.DotNetBar.ButtonX btnThoatHK;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLop;
        private DevComponents.DotNetBar.ButtonX btnCapnhatdulieu1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoTC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMamon;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnLuuhk;
        private DevComponents.DotNetBar.ButtonX btnXoahk;
        private DevComponents.DotNetBar.ButtonX btnThemhk;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHK;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private QLDDataSet5 qLDDataSet5;
        private System.Windows.Forms.BindingSource diemHPBindingSource;
        private QLDDataSet5TableAdapters.DiemHPTableAdapter diemHPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemGKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemCKDataGridViewTextBoxColumn;
    }
}