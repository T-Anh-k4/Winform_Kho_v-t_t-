namespace GUI
{
    partial class BAOCAOHANGNHAPKHO_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_timkiem = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.check_Hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.k_datagrview_hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Check_TenNcc = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kbtn_timkiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_tu_ngay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.date_den_ngay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_timkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(549, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(438, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "BÁO CÁO HÀNG HÓA NHẬP KHO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.k_datagrview_hang_hoa);
            this.panel1.Location = new System.Drawing.Point(310, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 620);
            this.panel1.TabIndex = 4;
            // 
            // cbx_timkiem
            // 
            this.cbx_timkiem.DropDownWidth = 184;
            this.cbx_timkiem.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cbx_timkiem.Location = new System.Drawing.Point(6, 152);
            this.cbx_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_timkiem.Name = "cbx_timkiem";
            this.cbx_timkiem.Size = new System.Drawing.Size(246, 33);
            this.cbx_timkiem.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.cbx_timkiem.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
            this.cbx_timkiem.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbx_timkiem.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbx_timkiem.StateCommon.ComboBox.Border.Rounding = 20;
            this.cbx_timkiem.StateCommon.ComboBox.Border.Width = 1;
            this.cbx_timkiem.TabIndex = 81;
            this.cbx_timkiem.DropDown += new System.EventHandler(this.cbx_timkiem_DropDown);
            // 
            // check_Hang_hoa
            // 
            this.check_Hang_hoa.Location = new System.Drawing.Point(7, 87);
            this.check_Hang_hoa.Margin = new System.Windows.Forms.Padding(4);
            this.check_Hang_hoa.Name = "check_Hang_hoa";
            this.check_Hang_hoa.Size = new System.Drawing.Size(148, 20);
            this.check_Hang_hoa.TabIndex = 82;
            this.check_Hang_hoa.Values.Text = "Tìm theo tên hàng hóa";
            this.check_Hang_hoa.CheckedChanged += new System.EventHandler(this.check_Hang_hoa_CheckedChanged);
            // 
            // k_datagrview_hang_hoa
            // 
            this.k_datagrview_hang_hoa.AllowUserToAddRows = false;
            this.k_datagrview_hang_hoa.AllowUserToResizeColumns = false;
            this.k_datagrview_hang_hoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.k_datagrview_hang_hoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.k_datagrview_hang_hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.k_datagrview_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k_datagrview_hang_hoa.Location = new System.Drawing.Point(0, 0);
            this.k_datagrview_hang_hoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.k_datagrview_hang_hoa.Name = "k_datagrview_hang_hoa";
            this.k_datagrview_hang_hoa.RowHeadersVisible = false;
            this.k_datagrview_hang_hoa.RowHeadersWidth = 51;
            this.k_datagrview_hang_hoa.RowTemplate.Height = 24;
            this.k_datagrview_hang_hoa.Size = new System.Drawing.Size(1089, 620);
            this.k_datagrview_hang_hoa.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Width = 0;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Width = 0;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
            this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.k_datagrview_hang_hoa.TabIndex = 2;
            // 
            // Check_TenNcc
            // 
            this.Check_TenNcc.Location = new System.Drawing.Point(7, 120);
            this.Check_TenNcc.Margin = new System.Windows.Forms.Padding(4);
            this.Check_TenNcc.Name = "Check_TenNcc";
            this.Check_TenNcc.Size = new System.Drawing.Size(170, 20);
            this.Check_TenNcc.TabIndex = 83;
            this.Check_TenNcc.Values.Text = "Tìm theo tên nhà cung cấp";
            this.Check_TenNcc.CheckedChanged += new System.EventHandler(this.Check_TenNcc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_den_ngay);
            this.groupBox1.Controls.Add(this.date_tu_ngay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kbtn_timkiem);
            this.groupBox1.Controls.Add(this.check_Hang_hoa);
            this.groupBox1.Controls.Add(this.Check_TenNcc);
            this.groupBox1.Controls.Add(this.cbx_timkiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 679);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // kbtn_timkiem
            // 
            this.kbtn_timkiem.Location = new System.Drawing.Point(63, 604);
            this.kbtn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.kbtn_timkiem.Name = "kbtn_timkiem";
            this.kbtn_timkiem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.OverrideDefault.Back.ColorAngle = 45F;
            this.kbtn_timkiem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.OverrideDefault.Border.ColorAngle = 45F;
            this.kbtn_timkiem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_timkiem.OverrideDefault.Border.Rounding = 20;
            this.kbtn_timkiem.OverrideDefault.Border.Width = 1;
            this.kbtn_timkiem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kbtn_timkiem.Size = new System.Drawing.Size(131, 57);
            this.kbtn_timkiem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateCommon.Border.ColorAngle = 45F;
            this.kbtn_timkiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_timkiem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kbtn_timkiem.StateCommon.Border.Rounding = 25;
            this.kbtn_timkiem.StateCommon.Border.Width = 1;
            this.kbtn_timkiem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kbtn_timkiem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kbtn_timkiem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtn_timkiem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StatePressed.Back.ColorAngle = 135F;
            this.kbtn_timkiem.StatePressed.Border.ColorAngle = 135F;
            this.kbtn_timkiem.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_timkiem.StatePressed.Border.Rounding = 25;
            this.kbtn_timkiem.StatePressed.Border.Width = 1;
            this.kbtn_timkiem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateTracking.Back.ColorAngle = 45F;
            this.kbtn_timkiem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kbtn_timkiem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtn_timkiem.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kbtn_timkiem.StateTracking.Border.Rounding = 25;
            this.kbtn_timkiem.StateTracking.Border.Width = 1;
            this.kbtn_timkiem.TabIndex = 84;
            this.kbtn_timkiem.Values.Text = "Tìm kiếm";
            this.kbtn_timkiem.Click += new System.EventHandler(this.kbtn_timkiem_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(310, 84);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(131, 43);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 25;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 85;
            this.kryptonButton1.Values.Text = "hiện thị tất cả";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Đến ngày";
            // 
            // date_tu_ngay
            // 
            this.date_tu_ngay.Location = new System.Drawing.Point(18, 336);
            this.date_tu_ngay.Name = "date_tu_ngay";
            this.date_tu_ngay.Size = new System.Drawing.Size(234, 21);
            this.date_tu_ngay.TabIndex = 87;
            // 
            // date_den_ngay
            // 
            this.date_den_ngay.Location = new System.Drawing.Point(18, 421);
            this.date_den_ngay.Name = "date_den_ngay";
            this.date_den_ngay.Size = new System.Drawing.Size(234, 21);
            this.date_den_ngay.TabIndex = 88;
            // 
            // BAOCAOHANGNHAPKHO_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 775);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "BAOCAOHANGNHAPKHO_GUI";
            this.Text = "BAOCAOHANGNHAPKHO_GUI";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_timkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_hang_hoa;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox check_Hang_hoa;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Check_TenNcc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_timkiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker date_den_ngay;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker date_tu_ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}