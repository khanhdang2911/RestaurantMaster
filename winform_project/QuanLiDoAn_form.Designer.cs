namespace winform_project
{
    partial class QuanLiDoAn_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiDoAn_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl_address = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_phone = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_monAn = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_giatien = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_tenmon = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbb_danhmuc = new System.Windows.Forms.ComboBox();
            this.btn_themMon = new System.Windows.Forms.Button();
            this.btn_xoamon = new System.Windows.Forms.Button();
            this.btn_suamon = new System.Windows.Forms.Button();
            this.lbl_tinhtrang = new Bunifu.UI.WinForms.BunifuLabel();
            this.checkbox_tinhtrang = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_address
            // 
            this.lbl_address.AllowParentOverrides = false;
            this.lbl_address.AutoEllipsis = false;
            this.lbl_address.AutoSize = false;
            this.lbl_address.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_address.CursorType = null;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(37, 71);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_address.Size = new System.Drawing.Size(72, 25);
            this.lbl_address.TabIndex = 28;
            this.lbl_address.Text = "Giá tiền";
            this.lbl_address.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_address.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AllowParentOverrides = false;
            this.lbl_phone.AutoEllipsis = true;
            this.lbl_phone.AutoSize = false;
            this.lbl_phone.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_phone.CursorType = null;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_phone.Location = new System.Drawing.Point(411, 15);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_phone.Size = new System.Drawing.Size(108, 24);
            this.lbl_phone.TabIndex = 21;
            this.lbl_phone.Text = "Danh mục";
            this.lbl_phone.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_phone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_monAn
            // 
            this.lbl_monAn.AllowParentOverrides = false;
            this.lbl_monAn.AutoEllipsis = false;
            this.lbl_monAn.AutoSize = false;
            this.lbl_monAn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_monAn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_monAn.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_monAn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monAn.ForeColor = System.Drawing.Color.Black;
            this.lbl_monAn.Location = new System.Drawing.Point(37, 12);
            this.lbl_monAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_monAn.Name = "lbl_monAn";
            this.lbl_monAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_monAn.Size = new System.Drawing.Size(87, 27);
            this.lbl_monAn.TabIndex = 19;
            this.lbl_monAn.Text = "Tên món";
            this.lbl_monAn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_monAn.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(2, 178);
            this.bunifuDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(752, 233);
            this.bunifuDataGridView1.TabIndex = 18;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.bunifuDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_giatien
            // 
            this.txt_giatien.AcceptsReturn = false;
            this.txt_giatien.AcceptsTab = false;
            this.txt_giatien.AnimationSpeed = 200;
            this.txt_giatien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_giatien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_giatien.BackColor = System.Drawing.Color.Transparent;
            this.txt_giatien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_giatien.BackgroundImage")));
            this.txt_giatien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_giatien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_giatien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_giatien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_giatien.BorderRadius = 1;
            this.txt_giatien.BorderThickness = 1;
            this.txt_giatien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_giatien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giatien.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_giatien.DefaultText = "";
            this.txt_giatien.FillColor = System.Drawing.Color.White;
            this.txt_giatien.HideSelection = true;
            this.txt_giatien.IconLeft = null;
            this.txt_giatien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giatien.IconPadding = 10;
            this.txt_giatien.IconRight = null;
            this.txt_giatien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giatien.Lines = new string[0];
            this.txt_giatien.Location = new System.Drawing.Point(132, 71);
            this.txt_giatien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_giatien.MaxLength = 32767;
            this.txt_giatien.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_giatien.Modified = false;
            this.txt_giatien.Multiline = false;
            this.txt_giatien.Name = "txt_giatien";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_giatien.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_giatien.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_giatien.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_giatien.OnIdleState = stateProperties4;
            this.txt_giatien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_giatien.PasswordChar = '\0';
            this.txt_giatien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_giatien.PlaceholderText = "";
            this.txt_giatien.ReadOnly = false;
            this.txt_giatien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_giatien.SelectedText = "";
            this.txt_giatien.SelectionLength = 0;
            this.txt_giatien.SelectionStart = 0;
            this.txt_giatien.ShortcutsEnabled = true;
            this.txt_giatien.Size = new System.Drawing.Size(196, 25);
            this.txt_giatien.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_giatien.TabIndex = 26;
            this.txt_giatien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_giatien.TextMarginBottom = 0;
            this.txt_giatien.TextMarginLeft = 3;
            this.txt_giatien.TextMarginTop = 0;
            this.txt_giatien.TextPlaceholder = "";
            this.txt_giatien.UseSystemPasswordChar = false;
            this.txt_giatien.WordWrap = true;
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
            this.txt_tenmon.Location = new System.Drawing.Point(132, 12);
            this.txt_tenmon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenmon.MaxLength = 32767;
            this.txt_tenmon.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tenmon.Modified = false;
            this.txt_tenmon.Multiline = false;
            this.txt_tenmon.Name = "txt_tenmon";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tenmon.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenmon.OnIdleState = stateProperties8;
            this.txt_tenmon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenmon.PasswordChar = '\0';
            this.txt_tenmon.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tenmon.PlaceholderText = "";
            this.txt_tenmon.ReadOnly = false;
            this.txt_tenmon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenmon.SelectedText = "";
            this.txt_tenmon.SelectionLength = 0;
            this.txt_tenmon.SelectionStart = 0;
            this.txt_tenmon.ShortcutsEnabled = true;
            this.txt_tenmon.Size = new System.Drawing.Size(251, 34);
            this.txt_tenmon.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tenmon.TabIndex = 22;
            this.txt_tenmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tenmon.TextMarginBottom = 0;
            this.txt_tenmon.TextMarginLeft = 3;
            this.txt_tenmon.TextMarginTop = 0;
            this.txt_tenmon.TextPlaceholder = "";
            this.txt_tenmon.UseSystemPasswordChar = false;
            this.txt_tenmon.WordWrap = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // cbb_danhmuc
            // 
            this.cbb_danhmuc.BackColor = System.Drawing.Color.White;
            this.cbb_danhmuc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_danhmuc.FormattingEnabled = true;
            this.cbb_danhmuc.Location = new System.Drawing.Point(527, 15);
            this.cbb_danhmuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_danhmuc.Name = "cbb_danhmuc";
            this.cbb_danhmuc.Size = new System.Drawing.Size(188, 27);
            this.cbb_danhmuc.TabIndex = 33;
            // 
            // btn_themMon
            // 
            this.btn_themMon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_themMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themMon.Location = new System.Drawing.Point(108, 136);
            this.btn_themMon.Name = "btn_themMon";
            this.btn_themMon.Size = new System.Drawing.Size(83, 35);
            this.btn_themMon.TabIndex = 34;
            this.btn_themMon.Text = "Thêm món";
            this.btn_themMon.UseVisualStyleBackColor = false;
            this.btn_themMon.Click += new System.EventHandler(this.btn_themMon_Click);
            // 
            // btn_xoamon
            // 
            this.btn_xoamon.BackColor = System.Drawing.Color.LightCoral;
            this.btn_xoamon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoamon.ForeColor = System.Drawing.Color.Black;
            this.btn_xoamon.Location = new System.Drawing.Point(335, 136);
            this.btn_xoamon.Name = "btn_xoamon";
            this.btn_xoamon.Size = new System.Drawing.Size(82, 35);
            this.btn_xoamon.TabIndex = 35;
            this.btn_xoamon.Text = "Xóa";
            this.btn_xoamon.UseVisualStyleBackColor = false;
            this.btn_xoamon.Click += new System.EventHandler(this.btn_xoamon_Click);
            // 
            // btn_suamon
            // 
            this.btn_suamon.BackColor = System.Drawing.Color.Turquoise;
            this.btn_suamon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suamon.Location = new System.Drawing.Point(527, 136);
            this.btn_suamon.Name = "btn_suamon";
            this.btn_suamon.Size = new System.Drawing.Size(84, 35);
            this.btn_suamon.TabIndex = 36;
            this.btn_suamon.Text = "Sửa món";
            this.btn_suamon.UseVisualStyleBackColor = false;
            this.btn_suamon.Click += new System.EventHandler(this.btn_suamon_Click);
            // 
            // lbl_tinhtrang
            // 
            this.lbl_tinhtrang.AllowParentOverrides = false;
            this.lbl_tinhtrang.AutoEllipsis = false;
            this.lbl_tinhtrang.AutoSize = false;
            this.lbl_tinhtrang.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_tinhtrang.CursorType = null;
            this.lbl_tinhtrang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tinhtrang.ForeColor = System.Drawing.Color.Black;
            this.lbl_tinhtrang.Location = new System.Drawing.Point(411, 71);
            this.lbl_tinhtrang.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_tinhtrang.Name = "lbl_tinhtrang";
            this.lbl_tinhtrang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tinhtrang.Size = new System.Drawing.Size(108, 25);
            this.lbl_tinhtrang.TabIndex = 37;
            this.lbl_tinhtrang.Text = "Tình trạng";
            this.lbl_tinhtrang.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tinhtrang.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // checkbox_tinhtrang
            // 
            this.checkbox_tinhtrang.Location = new System.Drawing.Point(527, 71);
            this.checkbox_tinhtrang.Name = "checkbox_tinhtrang";
            this.checkbox_tinhtrang.Size = new System.Drawing.Size(23, 25);
            this.checkbox_tinhtrang.TabIndex = 38;
            this.checkbox_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // QuanLiDoAn_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(755, 428);
            this.Controls.Add(this.checkbox_tinhtrang);
            this.Controls.Add(this.lbl_tinhtrang);
            this.Controls.Add(this.btn_suamon);
            this.Controls.Add(this.btn_xoamon);
            this.Controls.Add(this.btn_themMon);
            this.Controls.Add(this.cbb_danhmuc);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_giatien);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_monAn);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLiDoAn_form";
            this.Text = "Quản lí đồ ăn";
            this.Load += new System.EventHandler(this.QuanLiDoAn_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel lbl_address;
        private Bunifu.UI.WinForms.BunifuTextBox txt_giatien;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tenmon;
        private Bunifu.UI.WinForms.BunifuLabel lbl_phone;
        private Bunifu.UI.WinForms.BunifuLabel lbl_monAn;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button btn_suamon;
        private System.Windows.Forms.Button btn_xoamon;
        private System.Windows.Forms.Button btn_themMon;
        private System.Windows.Forms.ComboBox cbb_danhmuc;
        private System.Windows.Forms.CheckBox checkbox_tinhtrang;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tinhtrang;
    }
}