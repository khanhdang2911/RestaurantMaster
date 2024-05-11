namespace winform_project
{
    partial class goimon_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goimon_form));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_TenMon = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_SoLuong = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtg_danhsachmonOrder = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_xoaNhanVien = new System.Windows.Forms.Button();
            this.btn_goimon = new System.Windows.Forms.Button();
            this.lbl_TenBan = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_soluong = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_tenmon = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachmonOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_TenMon
            // 
            this.lbl_TenMon.AllowParentOverrides = false;
            this.lbl_TenMon.AutoEllipsis = false;
            this.lbl_TenMon.AutoSize = false;
            this.lbl_TenMon.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbl_TenMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TenMon.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TenMon.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TenMon.Location = new System.Drawing.Point(70, 76);
            this.lbl_TenMon.Name = "lbl_TenMon";
            this.lbl_TenMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TenMon.Size = new System.Drawing.Size(79, 24);
            this.lbl_TenMon.TabIndex = 0;
            this.lbl_TenMon.Text = "Tên món";
            this.lbl_TenMon.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TenMon.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AllowParentOverrides = false;
            this.lbl_SoLuong.AutoEllipsis = false;
            this.lbl_SoLuong.AutoSize = false;
            this.lbl_SoLuong.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbl_SoLuong.CursorType = null;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(70, 147);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_SoLuong.Size = new System.Drawing.Size(79, 24);
            this.lbl_SoLuong.TabIndex = 2;
            this.lbl_SoLuong.Text = "Quantity";
            this.lbl_SoLuong.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SoLuong.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtg_danhsachmonOrder
            // 
            this.dtg_danhsachmonOrder.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachmonOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_danhsachmonOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_danhsachmonOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_danhsachmonOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_danhsachmonOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_danhsachmonOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_danhsachmonOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_danhsachmonOrder.ColumnHeadersHeight = 40;
            this.dtg_danhsachmonOrder.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.dtg_danhsachmonOrder.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachmonOrder.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachmonOrder.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dtg_danhsachmonOrder.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachmonOrder.CurrentTheme.BackColor = System.Drawing.Color.Orange;
            this.dtg_danhsachmonOrder.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dtg_danhsachmonOrder.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.dtg_danhsachmonOrder.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachmonOrder.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_danhsachmonOrder.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.dtg_danhsachmonOrder.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_danhsachmonOrder.CurrentTheme.Name = null;
            this.dtg_danhsachmonOrder.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.dtg_danhsachmonOrder.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachmonOrder.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachmonOrder.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.dtg_danhsachmonOrder.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_danhsachmonOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_danhsachmonOrder.EnableHeadersVisualStyles = false;
            this.dtg_danhsachmonOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.dtg_danhsachmonOrder.HeaderBackColor = System.Drawing.Color.Orange;
            this.dtg_danhsachmonOrder.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_danhsachmonOrder.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_danhsachmonOrder.Location = new System.Drawing.Point(12, 258);
            this.dtg_danhsachmonOrder.Name = "dtg_danhsachmonOrder";
            this.dtg_danhsachmonOrder.ReadOnly = true;
            this.dtg_danhsachmonOrder.RowHeadersVisible = false;
            this.dtg_danhsachmonOrder.RowTemplate.Height = 40;
            this.dtg_danhsachmonOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_danhsachmonOrder.Size = new System.Drawing.Size(505, 169);
            this.dtg_danhsachmonOrder.TabIndex = 4;
            this.dtg_danhsachmonOrder.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            this.dtg_danhsachmonOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachmonOrder_CellContentClick);
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoaNhanVien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(287, 195);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(84, 34);
            this.btn_xoaNhanVien.TabIndex = 23;
            this.btn_xoaNhanVien.Text = "Xóa món";
            this.btn_xoaNhanVien.UseVisualStyleBackColor = false;
            this.btn_xoaNhanVien.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // btn_goimon
            // 
            this.btn_goimon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_goimon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goimon.Location = new System.Drawing.Point(70, 195);
            this.btn_goimon.Name = "btn_goimon";
            this.btn_goimon.Size = new System.Drawing.Size(121, 34);
            this.btn_goimon.TabIndex = 22;
            this.btn_goimon.Text = "Chọn món này";
            this.btn_goimon.UseVisualStyleBackColor = false;
            this.btn_goimon.Click += new System.EventHandler(this.btn_themNhanVien_Click);
            // 
            // lbl_TenBan
            // 
            this.lbl_TenBan.AllowParentOverrides = false;
            this.lbl_TenBan.AutoEllipsis = false;
            this.lbl_TenBan.AutoSize = false;
            this.lbl_TenBan.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_TenBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TenBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_TenBan.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_TenBan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TenBan.Location = new System.Drawing.Point(12, 26);
            this.lbl_TenBan.Name = "lbl_TenBan";
            this.lbl_TenBan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TenBan.Size = new System.Drawing.Size(153, 35);
            this.lbl_TenBan.TabIndex = 24;
            this.lbl_TenBan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TenBan.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_soluong
            // 
            this.txt_soluong.AcceptsReturn = false;
            this.txt_soluong.AcceptsTab = false;
            this.txt_soluong.AnimationSpeed = 200;
            this.txt_soluong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_soluong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_soluong.BackColor = System.Drawing.Color.Transparent;
            this.txt_soluong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_soluong.BackgroundImage")));
            this.txt_soluong.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_soluong.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_soluong.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_soluong.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_soluong.BorderRadius = 1;
            this.txt_soluong.BorderThickness = 1;
            this.txt_soluong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_soluong.DefaultText = "";
            this.txt_soluong.FillColor = System.Drawing.Color.White;
            this.txt_soluong.HideSelection = true;
            this.txt_soluong.IconLeft = null;
            this.txt_soluong.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.IconPadding = 10;
            this.txt_soluong.IconRight = null;
            this.txt_soluong.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.Lines = new string[0];
            this.txt_soluong.Location = new System.Drawing.Point(208, 147);
            this.txt_soluong.MaxLength = 32767;
            this.txt_soluong.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_soluong.Modified = false;
            this.txt_soluong.Multiline = false;
            this.txt_soluong.Name = "txt_soluong";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_soluong.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_soluong.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_soluong.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_soluong.OnIdleState = stateProperties12;
            this.txt_soluong.Padding = new System.Windows.Forms.Padding(3);
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_soluong.PlaceholderText = "";
            this.txt_soluong.ReadOnly = false;
            this.txt_soluong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.SelectionLength = 0;
            this.txt_soluong.SelectionStart = 0;
            this.txt_soluong.ShortcutsEnabled = true;
            this.txt_soluong.Size = new System.Drawing.Size(174, 24);
            this.txt_soluong.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_soluong.TabIndex = 3;
            this.txt_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_soluong.TextMarginBottom = 0;
            this.txt_soluong.TextMarginLeft = 3;
            this.txt_soluong.TextMarginTop = 0;
            this.txt_soluong.TextPlaceholder = "";
            this.txt_soluong.UseSystemPasswordChar = false;
            this.txt_soluong.WordWrap = true;
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.AcceptsReturn = false;
            this.txt_tenmon.AcceptsTab = false;
            this.txt_tenmon.AnimationSpeed = 200;
            this.txt_tenmon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_tenmon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_tenmon.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenmon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tenmon.BackgroundImage")));
            this.txt_tenmon.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_tenmon.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_tenmon.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_tenmon.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_tenmon.BorderRadius = 1;
            this.txt_tenmon.BorderThickness = 1;
            this.txt_tenmon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tenmon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenmon.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_tenmon.DefaultText = "";
            this.txt_tenmon.FillColor = System.Drawing.Color.White;
            this.txt_tenmon.HideSelection = true;
            this.txt_tenmon.IconLeft = null;
            this.txt_tenmon.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenmon.IconPadding = 10;
            this.txt_tenmon.IconRight = null;
            this.txt_tenmon.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenmon.Lines = new string[0];
            this.txt_tenmon.Location = new System.Drawing.Point(208, 76);
            this.txt_tenmon.MaxLength = 32767;
            this.txt_tenmon.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tenmon.Modified = false;
            this.txt_tenmon.Multiline = false;
            this.txt_tenmon.Name = "txt_tenmon";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tenmon.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnIdleState = stateProperties16;
            this.txt_tenmon.Padding = new System.Windows.Forms.Padding(3);
            this.txt_tenmon.PasswordChar = '\0';
            this.txt_tenmon.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tenmon.PlaceholderText = "";
            this.txt_tenmon.ReadOnly = true;
            this.txt_tenmon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenmon.SelectedText = "";
            this.txt_tenmon.SelectionLength = 0;
            this.txt_tenmon.SelectionStart = 0;
            this.txt_tenmon.ShortcutsEnabled = true;
            this.txt_tenmon.Size = new System.Drawing.Size(174, 24);
            this.txt_tenmon.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tenmon.TabIndex = 1;
            this.txt_tenmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenmon.TextMarginBottom = 0;
            this.txt_tenmon.TextMarginLeft = 3;
            this.txt_tenmon.TextMarginTop = 0;
            this.txt_tenmon.TextPlaceholder = "";
            this.txt_tenmon.UseSystemPasswordChar = false;
            this.txt_tenmon.WordWrap = true;
            // 
            // goimon_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 463);
            this.Controls.Add(this.lbl_TenBan);
            this.Controls.Add(this.btn_xoaNhanVien);
            this.Controls.Add(this.btn_goimon);
            this.Controls.Add(this.dtg_danhsachmonOrder);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.lbl_TenMon);
            this.Name = "goimon_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi món";
            this.Load += new System.EventHandler(this.goimon_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachmonOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView dtg_danhsachmonOrder;
        private Bunifu.UI.WinForms.BunifuTextBox txt_soluong;
        private Bunifu.UI.WinForms.BunifuLabel lbl_SoLuong;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tenmon;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TenMon;
        private System.Windows.Forms.Button btn_xoaNhanVien;
        private System.Windows.Forms.Button btn_goimon;
        private Bunifu.UI.WinForms.BunifuLabel lbl_TenBan;
    }
}