namespace winform_project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_quanliban = new System.Windows.Forms.Panel();
            this.btn_ChonMon = new System.Windows.Forms.Button();
            this.btn_thanhtien = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.lbl_table = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtg_danhsachban = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_close = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txt_thanhtien = new Bunifu.UI.WinForms.BunifuTextBox();
            this.list_order = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btn_quanliNhanVien = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_quanliDoAn = new System.Windows.Forms.Button();
            this.btn_quanliDanhMuc = new System.Windows.Forms.Button();
            this.btn_thaydoiThongTin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_quanliban = new System.Windows.Forms.Button();
            this.lbl_yourName = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel_quanliban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_quanliban
            // 
            this.panel_quanliban.BackColor = System.Drawing.SystemColors.Control;
            this.panel_quanliban.Controls.Add(this.btn_ChonMon);
            this.panel_quanliban.Controls.Add(this.btn_thanhtien);
            this.panel_quanliban.Controls.Add(this.btn_thanhToan);
            this.panel_quanliban.Controls.Add(this.lbl_table);
            this.panel_quanliban.Controls.Add(this.dtg_danhsachban);
            this.panel_quanliban.Controls.Add(this.btn_close);
            this.panel_quanliban.Controls.Add(this.txt_thanhtien);
            this.panel_quanliban.Controls.Add(this.list_order);
            this.panel_quanliban.Location = new System.Drawing.Point(191, 2);
            this.panel_quanliban.Name = "panel_quanliban";
            this.panel_quanliban.Size = new System.Drawing.Size(690, 561);
            this.panel_quanliban.TabIndex = 1;
            this.panel_quanliban.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_quanliban_Paint);
            // 
            // btn_ChonMon
            // 
            this.btn_ChonMon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ChonMon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonMon.Location = new System.Drawing.Point(37, 262);
            this.btn_ChonMon.Name = "btn_ChonMon";
            this.btn_ChonMon.Size = new System.Drawing.Size(98, 34);
            this.btn_ChonMon.TabIndex = 25;
            this.btn_ChonMon.Text = "Chọn món";
            this.btn_ChonMon.UseVisualStyleBackColor = false;
            this.btn_ChonMon.Click += new System.EventHandler(this.btn_ChonMon_Click);
            // 
            // btn_thanhtien
            // 
            this.btn_thanhtien.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_thanhtien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtien.Location = new System.Drawing.Point(219, 302);
            this.btn_thanhtien.Name = "btn_thanhtien";
            this.btn_thanhtien.Size = new System.Drawing.Size(117, 34);
            this.btn_thanhtien.TabIndex = 24;
            this.btn_thanhtien.Text = "Thành tiền";
            this.btn_thanhtien.UseVisualStyleBackColor = false;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_thanhToan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.Location = new System.Drawing.Point(37, 302);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(98, 34);
            this.btn_thanhToan.TabIndex = 23;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // lbl_table
            // 
            this.lbl_table.AllowParentOverrides = false;
            this.lbl_table.AutoEllipsis = false;
            this.lbl_table.AutoSize = false;
            this.lbl_table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_table.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_table.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_table.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_table.Location = new System.Drawing.Point(38, 13);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_table.Size = new System.Drawing.Size(121, 29);
            this.lbl_table.TabIndex = 18;
            this.lbl_table.Text = "Tình trạng bàn";
            this.lbl_table.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_table.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtg_danhsachban
            // 
            this.dtg_danhsachban.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_danhsachban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_danhsachban.BackgroundColor = System.Drawing.Color.White;
            this.dtg_danhsachban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_danhsachban.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_danhsachban.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_danhsachban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_danhsachban.ColumnHeadersHeight = 40;
            this.dtg_danhsachban.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dtg_danhsachban.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachban.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachban.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dtg_danhsachban.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_danhsachban.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dtg_danhsachban.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dtg_danhsachban.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dtg_danhsachban.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachban.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_danhsachban.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dtg_danhsachban.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_danhsachban.CurrentTheme.Name = null;
            this.dtg_danhsachban.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dtg_danhsachban.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachban.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachban.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dtg_danhsachban.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_danhsachban.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_danhsachban.EnableHeadersVisualStyles = false;
            this.dtg_danhsachban.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dtg_danhsachban.HeaderBackColor = System.Drawing.Color.Teal;
            this.dtg_danhsachban.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_danhsachban.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_danhsachban.Location = new System.Drawing.Point(37, 48);
            this.dtg_danhsachban.Name = "dtg_danhsachban";
            this.dtg_danhsachban.ReadOnly = true;
            this.dtg_danhsachban.RowHeadersVisible = false;
            this.dtg_danhsachban.RowTemplate.Height = 40;
            this.dtg_danhsachban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_danhsachban.Size = new System.Drawing.Size(614, 208);
            this.dtg_danhsachban.TabIndex = 17;
            this.dtg_danhsachban.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.dtg_danhsachban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachban_CellContentClick);
            // 
            // btn_close
            // 
            this.btn_close.AllowFocused = false;
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.AutoSizeHeight = true;
            this.btn_close.BorderRadius = 12;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.IsCircle = true;
            this.btn_close.Location = new System.Drawing.Point(660, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 12;
            this.btn_close.TabStop = false;
            this.btn_close.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.AcceptsReturn = false;
            this.txt_thanhtien.AcceptsTab = false;
            this.txt_thanhtien.AnimationSpeed = 200;
            this.txt_thanhtien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_thanhtien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_thanhtien.BackColor = System.Drawing.Color.Transparent;
            this.txt_thanhtien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_thanhtien.BackgroundImage")));
            this.txt_thanhtien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_thanhtien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_thanhtien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_thanhtien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_thanhtien.BorderRadius = 1;
            this.txt_thanhtien.BorderThickness = 1;
            this.txt_thanhtien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_thanhtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thanhtien.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_thanhtien.DefaultText = "";
            this.txt_thanhtien.FillColor = System.Drawing.Color.White;
            this.txt_thanhtien.HideSelection = true;
            this.txt_thanhtien.IconLeft = null;
            this.txt_thanhtien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thanhtien.IconPadding = 10;
            this.txt_thanhtien.IconRight = null;
            this.txt_thanhtien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thanhtien.Lines = new string[0];
            this.txt_thanhtien.Location = new System.Drawing.Point(342, 302);
            this.txt_thanhtien.MaxLength = 32767;
            this.txt_thanhtien.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_thanhtien.Modified = false;
            this.txt_thanhtien.Multiline = false;
            this.txt_thanhtien.Name = "txt_thanhtien";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thanhtien.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_thanhtien.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thanhtien.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_thanhtien.OnIdleState = stateProperties8;
            this.txt_thanhtien.Padding = new System.Windows.Forms.Padding(3);
            this.txt_thanhtien.PasswordChar = '\0';
            this.txt_thanhtien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_thanhtien.PlaceholderText = "";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_thanhtien.SelectedText = "";
            this.txt_thanhtien.SelectionLength = 0;
            this.txt_thanhtien.SelectionStart = 0;
            this.txt_thanhtien.ShortcutsEnabled = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(212, 29);
            this.txt_thanhtien.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_thanhtien.TabIndex = 16;
            this.txt_thanhtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_thanhtien.TextMarginBottom = 0;
            this.txt_thanhtien.TextMarginLeft = 3;
            this.txt_thanhtien.TextMarginTop = 0;
            this.txt_thanhtien.TextPlaceholder = "";
            this.txt_thanhtien.UseSystemPasswordChar = false;
            this.txt_thanhtien.WordWrap = true;
            // 
            // list_order
            // 
            this.list_order.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.list_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.list_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_order.BackgroundColor = System.Drawing.Color.White;
            this.list_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.list_order.ColumnHeadersHeight = 40;
            this.list_order.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.list_order.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.list_order.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list_order.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.list_order.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list_order.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.list_order.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.list_order.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.list_order.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.list_order.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list_order.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.list_order.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.list_order.CurrentTheme.Name = null;
            this.list_order.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list_order.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.list_order.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list_order.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.list_order.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_order.DefaultCellStyle = dataGridViewCellStyle12;
            this.list_order.EnableHeadersVisualStyles = false;
            this.list_order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.list_order.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.list_order.HeaderBgColor = System.Drawing.Color.Empty;
            this.list_order.HeaderForeColor = System.Drawing.Color.White;
            this.list_order.Location = new System.Drawing.Point(38, 342);
            this.list_order.Name = "list_order";
            this.list_order.ReadOnly = true;
            this.list_order.RowHeadersVisible = false;
            this.list_order.RowTemplate.Height = 40;
            this.list_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_order.Size = new System.Drawing.Size(613, 219);
            this.list_order.TabIndex = 13;
            this.list_order.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.list_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_order_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::winform_project.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(72, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DarkGray;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(29, 105);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(111, 14);
            this.bunifuSeparator1.TabIndex = 4;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.DarkGray;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(10, 368);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(147, 14);
            this.bunifuSeparator2.TabIndex = 6;
            // 
            // btn_quanliNhanVien
            // 
            this.btn_quanliNhanVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_quanliNhanVien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanliNhanVien.Location = new System.Drawing.Point(29, 125);
            this.btn_quanliNhanVien.Name = "btn_quanliNhanVien";
            this.btn_quanliNhanVien.Size = new System.Drawing.Size(129, 34);
            this.btn_quanliNhanVien.TabIndex = 24;
            this.btn_quanliNhanVien.Text = "Quản lí nhân viên";
            this.btn_quanliNhanVien.UseVisualStyleBackColor = false;
            this.btn_quanliNhanVien.Click += new System.EventHandler(this.btn_quanliNhanVien_Click_1);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_dangxuat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(46, 399);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(81, 34);
            this.btn_dangxuat.TabIndex = 28;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click_1);
            // 
            // btn_quanliDoAn
            // 
            this.btn_quanliDoAn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_quanliDoAn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanliDoAn.Location = new System.Drawing.Point(28, 228);
            this.btn_quanliDoAn.Name = "btn_quanliDoAn";
            this.btn_quanliDoAn.Size = new System.Drawing.Size(129, 34);
            this.btn_quanliDoAn.TabIndex = 29;
            this.btn_quanliDoAn.Text = "Quản lí sản phẩm";
            this.btn_quanliDoAn.UseVisualStyleBackColor = false;
            this.btn_quanliDoAn.Click += new System.EventHandler(this.btn_quanliDoAn_Click);
            // 
            // btn_quanliDanhMuc
            // 
            this.btn_quanliDanhMuc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_quanliDanhMuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanliDanhMuc.Location = new System.Drawing.Point(28, 277);
            this.btn_quanliDanhMuc.Name = "btn_quanliDanhMuc";
            this.btn_quanliDanhMuc.Size = new System.Drawing.Size(129, 34);
            this.btn_quanliDanhMuc.TabIndex = 30;
            this.btn_quanliDanhMuc.Text = "Quản lí danh mục";
            this.btn_quanliDanhMuc.UseVisualStyleBackColor = false;
            this.btn_quanliDanhMuc.Click += new System.EventHandler(this.btn_quanliDanhMuc_Click_1);
            // 
            // btn_thaydoiThongTin
            // 
            this.btn_thaydoiThongTin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_thaydoiThongTin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thaydoiThongTin.Location = new System.Drawing.Point(28, 328);
            this.btn_thaydoiThongTin.Name = "btn_thaydoiThongTin";
            this.btn_thaydoiThongTin.Size = new System.Drawing.Size(129, 34);
            this.btn_thaydoiThongTin.TabIndex = 31;
            this.btn_thaydoiThongTin.Text = "Thay đổi thông tin";
            this.btn_thaydoiThongTin.UseVisualStyleBackColor = false;
            this.btn_thaydoiThongTin.Click += new System.EventHandler(this.btn_thaydoiThongTin_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.btn_quanliban);
            this.panel1.Controls.Add(this.btn_thaydoiThongTin);
            this.panel1.Controls.Add(this.btn_quanliDanhMuc);
            this.panel1.Controls.Add(this.btn_quanliDoAn);
            this.panel1.Controls.Add(this.btn_dangxuat);
            this.panel1.Controls.Add(this.btn_quanliNhanVien);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lbl_yourName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 561);
            this.panel1.TabIndex = 0;
            // 
            // btn_quanliban
            // 
            this.btn_quanliban.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_quanliban.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanliban.Location = new System.Drawing.Point(28, 178);
            this.btn_quanliban.Name = "btn_quanliban";
            this.btn_quanliban.Size = new System.Drawing.Size(129, 34);
            this.btn_quanliban.TabIndex = 32;
            this.btn_quanliban.Text = "Quản lí bàn";
            this.btn_quanliban.UseVisualStyleBackColor = false;
            // 
            // lbl_yourName
            // 
            this.lbl_yourName.AllowParentOverrides = false;
            this.lbl_yourName.AutoEllipsis = false;
            this.lbl_yourName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_yourName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_yourName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.lbl_yourName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_yourName.Location = new System.Drawing.Point(63, 80);
            this.lbl_yourName.Name = "lbl_yourName";
            this.lbl_yourName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_yourName.Size = new System.Drawing.Size(61, 19);
            this.lbl_yourName.TabIndex = 3;
            this.lbl_yourName.Text = "Xin chào !";
            this.lbl_yourName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_yourName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_yourName.Click += new System.EventHandler(this.lbl_yourName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_quanliban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_quanliban.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_quanliban;
        private Bunifu.UI.WinForms.BunifuDataGridView list_order;
        private Bunifu.UI.WinForms.BunifuTextBox txt_thanhtien;
        private Bunifu.UI.WinForms.BunifuDataGridView dtg_danhsachban;
        private Bunifu.UI.WinForms.BunifuLabel lbl_table;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_close;
        private System.Windows.Forms.Button btn_thanhtien;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Button btn_ChonMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thaydoiThongTin;
        private System.Windows.Forms.Button btn_quanliDanhMuc;
        private System.Windows.Forms.Button btn_quanliDoAn;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Button btn_quanliNhanVien;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_yourName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_quanliban;
    }
}

