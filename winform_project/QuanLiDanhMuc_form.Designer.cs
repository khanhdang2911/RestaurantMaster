namespace winform_project
{
    partial class QuanLiDanhMuc
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiDanhMuc));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_tenDanhMuc = new Bunifu.UI.WinForms.BunifuTextBox();
            this.list_danhmuc = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbl_tenDanhMuc = new Bunifu.UI.WinForms.BunifuLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xoaDanhMuc = new System.Windows.Forms.Button();
            this.btn_themDanhMuc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_danhmuc)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_tenDanhMuc
            // 
            this.txt_tenDanhMuc.AcceptsReturn = false;
            this.txt_tenDanhMuc.AcceptsTab = false;
            this.txt_tenDanhMuc.AnimationSpeed = 200;
            this.txt_tenDanhMuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_tenDanhMuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_tenDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenDanhMuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tenDanhMuc.BackgroundImage")));
            this.txt_tenDanhMuc.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_tenDanhMuc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_tenDanhMuc.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_tenDanhMuc.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_tenDanhMuc.BorderRadius = 1;
            this.txt_tenDanhMuc.BorderThickness = 1;
            this.txt_tenDanhMuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenDanhMuc.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDanhMuc.DefaultText = "";
            this.txt_tenDanhMuc.FillColor = System.Drawing.Color.White;
            this.txt_tenDanhMuc.HideSelection = true;
            this.txt_tenDanhMuc.IconLeft = null;
            this.txt_tenDanhMuc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenDanhMuc.IconPadding = 10;
            this.txt_tenDanhMuc.IconRight = null;
            this.txt_tenDanhMuc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenDanhMuc.Lines = new string[0];
            this.txt_tenDanhMuc.Location = new System.Drawing.Point(127, 66);
            this.txt_tenDanhMuc.MaxLength = 32767;
            this.txt_tenDanhMuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tenDanhMuc.Modified = false;
            this.txt_tenDanhMuc.Multiline = false;
            this.txt_tenDanhMuc.Name = "txt_tenDanhMuc";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenDanhMuc.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tenDanhMuc.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenDanhMuc.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenDanhMuc.OnIdleState = stateProperties4;
            this.txt_tenDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.txt_tenDanhMuc.PasswordChar = '\0';
            this.txt_tenDanhMuc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tenDanhMuc.PlaceholderText = "";
            this.txt_tenDanhMuc.ReadOnly = false;
            this.txt_tenDanhMuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenDanhMuc.SelectedText = "";
            this.txt_tenDanhMuc.SelectionLength = 0;
            this.txt_tenDanhMuc.SelectionStart = 0;
            this.txt_tenDanhMuc.ShortcutsEnabled = true;
            this.txt_tenDanhMuc.Size = new System.Drawing.Size(298, 41);
            this.txt_tenDanhMuc.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tenDanhMuc.TabIndex = 2;
            this.txt_tenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenDanhMuc.TextMarginBottom = 0;
            this.txt_tenDanhMuc.TextMarginLeft = 3;
            this.txt_tenDanhMuc.TextMarginTop = 0;
            this.txt_tenDanhMuc.TextPlaceholder = "";
            this.txt_tenDanhMuc.UseSystemPasswordChar = false;
            this.txt_tenDanhMuc.WordWrap = true;
            // 
            // list_danhmuc
            // 
            this.list_danhmuc.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.list_danhmuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.list_danhmuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_danhmuc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.list_danhmuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_danhmuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list_danhmuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_danhmuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.list_danhmuc.ColumnHeadersHeight = 40;
            this.list_danhmuc.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.list_danhmuc.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.list_danhmuc.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list_danhmuc.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.list_danhmuc.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list_danhmuc.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.list_danhmuc.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.list_danhmuc.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.list_danhmuc.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.list_danhmuc.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list_danhmuc.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.list_danhmuc.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.list_danhmuc.CurrentTheme.Name = null;
            this.list_danhmuc.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list_danhmuc.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.list_danhmuc.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list_danhmuc.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.list_danhmuc.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_danhmuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.list_danhmuc.EnableHeadersVisualStyles = false;
            this.list_danhmuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.list_danhmuc.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.list_danhmuc.HeaderBgColor = System.Drawing.Color.Empty;
            this.list_danhmuc.HeaderForeColor = System.Drawing.Color.White;
            this.list_danhmuc.Location = new System.Drawing.Point(12, 203);
            this.list_danhmuc.Name = "list_danhmuc";
            this.list_danhmuc.ReadOnly = true;
            this.list_danhmuc.RowHeadersVisible = false;
            this.list_danhmuc.RowTemplate.Height = 40;
            this.list_danhmuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_danhmuc.Size = new System.Drawing.Size(438, 254);
            this.list_danhmuc.TabIndex = 3;
            this.list_danhmuc.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.list_danhmuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_danhmuc_CellContentClick);
            // 
            // lbl_tenDanhMuc
            // 
            this.lbl_tenDanhMuc.AllowParentOverrides = false;
            this.lbl_tenDanhMuc.AutoEllipsis = false;
            this.lbl_tenDanhMuc.AutoSize = false;
            this.lbl_tenDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_tenDanhMuc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_tenDanhMuc.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_tenDanhMuc.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.lbl_tenDanhMuc.Location = new System.Drawing.Point(21, 66);
            this.lbl_tenDanhMuc.Name = "lbl_tenDanhMuc";
            this.lbl_tenDanhMuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tenDanhMuc.Size = new System.Drawing.Size(100, 41);
            this.lbl_tenDanhMuc.TabIndex = 20;
            this.lbl_tenDanhMuc.Text = "Tên danh mục";
            this.lbl_tenDanhMuc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tenDanhMuc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(228, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sửa danh mục";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_xoaDanhMuc
            // 
            this.btn_xoaDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoaDanhMuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaDanhMuc.Location = new System.Drawing.Point(156, 146);
            this.btn_xoaDanhMuc.Name = "btn_xoaDanhMuc";
            this.btn_xoaDanhMuc.Size = new System.Drawing.Size(57, 34);
            this.btn_xoaDanhMuc.TabIndex = 24;
            this.btn_xoaDanhMuc.Text = "Xóa";
            this.btn_xoaDanhMuc.UseVisualStyleBackColor = false;
            this.btn_xoaDanhMuc.Click += new System.EventHandler(this.btn_xoaNhanVien_Click);
            // 
            // btn_themDanhMuc
            // 
            this.btn_themDanhMuc.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_themDanhMuc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themDanhMuc.Location = new System.Drawing.Point(12, 146);
            this.btn_themDanhMuc.Name = "btn_themDanhMuc";
            this.btn_themDanhMuc.Size = new System.Drawing.Size(127, 34);
            this.btn_themDanhMuc.TabIndex = 23;
            this.btn_themDanhMuc.Text = "Thêm danh mục";
            this.btn_themDanhMuc.UseVisualStyleBackColor = false;
            this.btn_themDanhMuc.Click += new System.EventHandler(this.btn_themDanhMuc_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(363, 146);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 34);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // QuanLiDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(462, 460);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_xoaDanhMuc);
            this.Controls.Add(this.btn_themDanhMuc);
            this.Controls.Add(this.lbl_tenDanhMuc);
            this.Controls.Add(this.list_danhmuc);
            this.Controls.Add(this.txt_tenDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLiDanhMuc";
            this.Text = "Quản lí danh mục";
            this.Load += new System.EventHandler(this.QuanLiDanhMuc_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_danhmuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tenDanhMuc;
        private Bunifu.UI.WinForms.BunifuDataGridView list_danhmuc;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tenDanhMuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_xoaDanhMuc;
        private System.Windows.Forms.Button btn_themDanhMuc;
        private System.Windows.Forms.Button btn_clear;
    }
}