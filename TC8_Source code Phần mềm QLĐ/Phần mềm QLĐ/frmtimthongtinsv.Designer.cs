namespace Phần_mềm_QLĐ
{
    partial class frmtimthongtinsv
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
            this.qLDDataSet4 = new Phần_mềm_QLĐ.QLDDataSet4();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new Phần_mềm_QLĐ.QLDDataSet4TableAdapters.SinhVienTableAdapter();
            this.dtgsinhvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtdiachisv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsodtsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtemailsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.datetimengaysinh = new System.Windows.Forms.DateTimePicker();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtnoisinhsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdantocsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtgioitinhsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttensinhvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmasinhvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txttimsv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDDataSet4
            // 
            this.qLDDataSet4.DataSetName = "QLDDataSet4";
            this.qLDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLDDataSet4;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // dtgsinhvien
            // 
            this.dtgsinhvien.AutoGenerateColumns = false;
            this.dtgsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DanToc,
            this.NoiSinh,
            this.MaLop,
            this.Email,
            this.Sdt,
            this.DiaChi,
            this.maSVDataGridViewTextBoxColumn});
            this.dtgsinhvien.DataSource = this.sinhVienBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgsinhvien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgsinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgsinhvien.Location = new System.Drawing.Point(72, 282);
            this.dtgsinhvien.Name = "dtgsinhvien";
            this.dtgsinhvien.Size = new System.Drawing.Size(714, 100);
            this.dtgsinhvien.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtdiachisv);
            this.groupPanel1.Controls.Add(this.txtsodtsv);
            this.groupPanel1.Controls.Add(this.txtemailsv);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.datetimengaysinh);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txtnoisinhsv);
            this.groupPanel1.Controls.Add(this.txtdantocsv);
            this.groupPanel1.Controls.Add(this.txtgioitinhsv);
            this.groupPanel1.Controls.Add(this.txttensinhvien);
            this.groupPanel1.Controls.Add(this.txtmasinhvien);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txttimsv);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel1.Location = new System.Drawing.Point(72, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(714, 264);
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
            this.groupPanel1.Text = "Tìm kiếm thông tin sinh viên";
            // 
            // txtdiachisv
            // 
            // 
            // 
            // 
            this.txtdiachisv.Border.Class = "TextBoxBorder";
            this.txtdiachisv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdiachisv.Location = new System.Drawing.Point(446, 206);
            this.txtdiachisv.Name = "txtdiachisv";
            this.txtdiachisv.Size = new System.Drawing.Size(134, 27);
            this.txtdiachisv.TabIndex = 45;
            // 
            // txtsodtsv
            // 
            // 
            // 
            // 
            this.txtsodtsv.Border.Class = "TextBoxBorder";
            this.txtsodtsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsodtsv.Location = new System.Drawing.Point(249, 206);
            this.txtsodtsv.Name = "txtsodtsv";
            this.txtsodtsv.Size = new System.Drawing.Size(184, 27);
            this.txtsodtsv.TabIndex = 44;
            // 
            // txtemailsv
            // 
            // 
            // 
            // 
            this.txtemailsv.Border.Class = "TextBoxBorder";
            this.txtemailsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemailsv.Location = new System.Drawing.Point(40, 206);
            this.txtemailsv.Name = "txtemailsv";
            this.txtemailsv.Size = new System.Drawing.Size(203, 27);
            this.txtemailsv.TabIndex = 43;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(446, 177);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(124, 23);
            this.labelX10.TabIndex = 42;
            this.labelX10.Text = "Địa chỉ: ";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(249, 179);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(135, 23);
            this.labelX9.TabIndex = 41;
            this.labelX9.Text = "Số điện thoại: ";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(40, 179);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(124, 23);
            this.labelX8.TabIndex = 40;
            this.labelX8.Text = "Email: ";
            // 
            // datetimengaysinh
            // 
            this.datetimengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimengaysinh.Location = new System.Drawing.Point(446, 78);
            this.datetimengaysinh.Name = "datetimengaysinh";
            this.datetimengaysinh.Size = new System.Drawing.Size(143, 27);
            this.datetimengaysinh.TabIndex = 39;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(309, 81);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(124, 23);
            this.labelX7.TabIndex = 38;
            this.labelX7.Text = "Ngày sinh: ";
            // 
            // txtnoisinhsv
            // 
            // 
            // 
            // 
            this.txtnoisinhsv.Border.Class = "TextBoxBorder";
            this.txtnoisinhsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnoisinhsv.Location = new System.Drawing.Point(571, 144);
            this.txtnoisinhsv.Name = "txtnoisinhsv";
            this.txtnoisinhsv.Size = new System.Drawing.Size(134, 27);
            this.txtnoisinhsv.TabIndex = 37;
            // 
            // txtdantocsv
            // 
            // 
            // 
            // 
            this.txtdantocsv.Border.Class = "TextBoxBorder";
            this.txtdantocsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdantocsv.Location = new System.Drawing.Point(446, 144);
            this.txtdantocsv.Name = "txtdantocsv";
            this.txtdantocsv.Size = new System.Drawing.Size(119, 27);
            this.txtdantocsv.TabIndex = 36;
            // 
            // txtgioitinhsv
            // 
            // 
            // 
            // 
            this.txtgioitinhsv.Border.Class = "TextBoxBorder";
            this.txtgioitinhsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtgioitinhsv.Location = new System.Drawing.Point(446, 111);
            this.txtgioitinhsv.Name = "txtgioitinhsv";
            this.txtgioitinhsv.Size = new System.Drawing.Size(118, 27);
            this.txtgioitinhsv.TabIndex = 35;
            // 
            // txttensinhvien
            // 
            // 
            // 
            // 
            this.txttensinhvien.Border.Class = "TextBoxBorder";
            this.txttensinhvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttensinhvien.Location = new System.Drawing.Point(446, 45);
            this.txttensinhvien.Name = "txttensinhvien";
            this.txttensinhvien.Size = new System.Drawing.Size(196, 27);
            this.txttensinhvien.TabIndex = 34;
            // 
            // txtmasinhvien
            // 
            // 
            // 
            // 
            this.txtmasinhvien.Border.Class = "TextBoxBorder";
            this.txtmasinhvien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmasinhvien.Location = new System.Drawing.Point(446, 12);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(196, 27);
            this.txtmasinhvien.TabIndex = 33;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(570, 115);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(124, 23);
            this.labelX6.TabIndex = 32;
            this.labelX6.Text = "Nơi sinh: ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(309, 148);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(124, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Dân tộc: ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(309, 115);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 23);
            this.labelX4.TabIndex = 30;
            this.labelX4.Text = "Giới tính:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(309, 49);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(141, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Tên sinh viên: ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(309, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 28;
            this.labelX2.Text = "Mã sinh viên: ";
            // 
            // txttimsv
            // 
            // 
            // 
            // 
            this.txttimsv.Border.Class = "TextBoxBorder";
            this.txttimsv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttimsv.Location = new System.Drawing.Point(3, 26);
            this.txttimsv.Name = "txttimsv";
            this.txttimsv.Size = new System.Drawing.Size(262, 27);
            this.txttimsv.TabIndex = 1;
            this.txttimsv.TextChanged += new System.EventHandler(this.txttimsv_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(40, -3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(193, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Nhập tên sinh viên: ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.dtgsinhvien);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(865, 394);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Text = "panelEx1";
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
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh(0:Nam/1:Nữ)";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "DanToc";
            this.DanToc.Name = "DanToc";
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "NoiSinh";
            this.NoiSinh.Name = "NoiSinh";
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "MaLop";
            this.MaLop.Name = "MaLop";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Sdt";
            this.Sdt.Name = "Sdt";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            // 
            // frmtimthongtinsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 394);
            this.Controls.Add(this.panelEx1);
            this.Name = "frmtimthongtinsv";
            this.Text = "Tìm kiếm sinh viên";
            this.Load += new System.EventHandler(this.frmtimthongtinsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhvien)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QLDDataSet4 qLDDataSet4;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLDDataSet4TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dtgsinhvien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttimsv;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiachisv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsodtsv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtemailsv;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.DateTimePicker datetimengaysinh;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnoisinhsv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdantocsv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtgioitinhsv;
        private DevComponents.DotNetBar.Controls.TextBoxX txttensinhvien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmasinhvien;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
    }
}