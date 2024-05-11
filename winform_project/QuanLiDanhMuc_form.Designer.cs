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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiDanhMuc));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_userName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lbl_tenDanhMuc = new Bunifu.UI.WinForms.BunifuLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xoaNhanVien = new System.Windows.Forms.Button();
            this.btn_themDanhMuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_userName
            // 
            this.txt_userName.AcceptsReturn = false;
            this.txt_userName.AcceptsTab = false;
            this.txt_userName.AnimationSpeed = 200;
            this.txt_userName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_userName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_userName.BackColor = System.Drawing.Color.Transparent;
            this.txt_userName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_userName.BackgroundImage")));
            this.txt_userName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_userName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_userName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_userName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_userName.BorderRadius = 1;
            this.txt_userName.BorderThickness = 1;
            this.txt_userName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_userName.DefaultText = "";
            this.txt_userName.FillColor = System.Drawing.Color.White;
            this.txt_userName.HideSelection = true;
            this.txt_userName.IconLeft = null;
            this.txt_userName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userName.IconPadding = 10;
            this.txt_userName.IconRight = null;
            this.txt_userName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userName.Lines = new string[0];
            this.txt_userName.Location = new System.Drawing.Point(127, 76);
            this.txt_userName.MaxLength = 32767;
            this.txt_userName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_userName.Modified = false;
            this.txt_userName.Multiline = false;
            this.txt_userName.Name = "txt_userName";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_userName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_userName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_userName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_userName.OnIdleState = stateProperties12;
            this.txt_userName.Padding = new System.Windows.Forms.Padding(3);
            this.txt_userName.PasswordChar = '\0';
            this.txt_userName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_userName.PlaceholderText = "";
            this.txt_userName.ReadOnly = false;
            this.txt_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userName.SelectedText = "";
            this.txt_userName.SelectionLength = 0;
            this.txt_userName.SelectionStart = 0;
            this.txt_userName.ShortcutsEnabled = true;
            this.txt_userName.Size = new System.Drawing.Size(178, 31);
            this.txt_userName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_userName.TabIndex = 2;
            this.txt_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_userName.TextMarginBottom = 0;
            this.txt_userName.TextMarginLeft = 3;
            this.txt_userName.TextMarginTop = 0;
            this.txt_userName.TextPlaceholder = "";
            this.txt_userName.UseSystemPasswordChar = false;
            this.txt_userName.WordWrap = true;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(25, 201);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(290, 215);
            this.bunifuDataGridView1.TabIndex = 3;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lbl_tenDanhMuc
            // 
            this.lbl_tenDanhMuc.AllowParentOverrides = false;
            this.lbl_tenDanhMuc.AutoEllipsis = false;
            this.lbl_tenDanhMuc.AutoSize = false;
            this.lbl_tenDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_tenDanhMuc.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_tenDanhMuc.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_tenDanhMuc.Font = new System.Drawing.Font("Constantia", 9F);
            this.lbl_tenDanhMuc.Location = new System.Drawing.Point(25, 76);
            this.lbl_tenDanhMuc.Name = "lbl_tenDanhMuc";
            this.lbl_tenDanhMuc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tenDanhMuc.Size = new System.Drawing.Size(96, 31);
            this.lbl_tenDanhMuc.TabIndex = 20;
            this.lbl_tenDanhMuc.Text = "Tên danh mục";
            this.lbl_tenDanhMuc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tenDanhMuc.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(212, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sửa danh mục";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_xoaNhanVien
            // 
            this.btn_xoaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoaNhanVien.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaNhanVien.Location = new System.Drawing.Point(145, 146);
            this.btn_xoaNhanVien.Name = "btn_xoaNhanVien";
            this.btn_xoaNhanVien.Size = new System.Drawing.Size(57, 34);
            this.btn_xoaNhanVien.TabIndex = 24;
            this.btn_xoaNhanVien.Text = "Xóa";
            this.btn_xoaNhanVien.UseVisualStyleBackColor = false;
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
            // 
            // QuanLiDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(339, 459);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_xoaNhanVien);
            this.Controls.Add(this.btn_themDanhMuc);
            this.Controls.Add(this.lbl_tenDanhMuc);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.txt_userName);
            this.Name = "QuanLiDanhMuc";
            this.Text = "Quản lí danh mục";
            this.Load += new System.EventHandler(this.QuanLiDanhMuc_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_userName;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tenDanhMuc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_xoaNhanVien;
        private System.Windows.Forms.Button btn_themDanhMuc;
    }
}