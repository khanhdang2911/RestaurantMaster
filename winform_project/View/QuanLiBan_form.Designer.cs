namespace winform_project
{
    partial class QuanLiBan_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiBan_form));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dtg_danhsachBan = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_suaBan = new System.Windows.Forms.Button();
            this.btn_xoaBan = new System.Windows.Forms.Button();
            this.btn_themBan = new System.Windows.Forms.Button();
            this.txt_tenBan = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_tenban = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_danhsachBan
            // 
            this.dtg_danhsachBan.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_danhsachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_danhsachBan.BackgroundColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_danhsachBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtg_danhsachBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_danhsachBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_danhsachBan.ColumnHeadersHeight = 40;
            this.dtg_danhsachBan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtg_danhsachBan.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachBan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachBan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtg_danhsachBan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachBan.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtg_danhsachBan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtg_danhsachBan.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachBan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtg_danhsachBan.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.CurrentTheme.Name = null;
            this.dtg_danhsachBan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtg_danhsachBan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtg_danhsachBan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtg_danhsachBan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_danhsachBan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_danhsachBan.EnableHeadersVisualStyles = false;
            this.dtg_danhsachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtg_danhsachBan.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtg_danhsachBan.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtg_danhsachBan.HeaderForeColor = System.Drawing.Color.White;
            this.dtg_danhsachBan.Location = new System.Drawing.Point(4, 204);
            this.dtg_danhsachBan.Name = "dtg_danhsachBan";
            this.dtg_danhsachBan.ReadOnly = true;
            this.dtg_danhsachBan.RowHeadersVisible = false;
            this.dtg_danhsachBan.RowTemplate.Height = 40;
            this.dtg_danhsachBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_danhsachBan.Size = new System.Drawing.Size(638, 234);
            this.dtg_danhsachBan.TabIndex = 0;
            this.dtg_danhsachBan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtg_danhsachBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachBan_CellContentClick);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(313, 164);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(79, 34);
            this.btn_clear.TabIndex = 29;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_suaBan
            // 
            this.btn_suaBan.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_suaBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaBan.Location = new System.Drawing.Point(435, 164);
            this.btn_suaBan.Name = "btn_suaBan";
            this.btn_suaBan.Size = new System.Drawing.Size(107, 34);
            this.btn_suaBan.TabIndex = 28;
            this.btn_suaBan.Text = "Sửa thông tin bàn";
            this.btn_suaBan.UseVisualStyleBackColor = false;
            this.btn_suaBan.Click += new System.EventHandler(this.btn_suaBan_Click);
            // 
            // btn_xoaBan
            // 
            this.btn_xoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoaBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaBan.Location = new System.Drawing.Point(173, 164);
            this.btn_xoaBan.Name = "btn_xoaBan";
            this.btn_xoaBan.Size = new System.Drawing.Size(84, 34);
            this.btn_xoaBan.TabIndex = 27;
            this.btn_xoaBan.Text = "Xóa bàn";
            this.btn_xoaBan.UseVisualStyleBackColor = false;
            this.btn_xoaBan.Click += new System.EventHandler(this.btn_xoaBan_Click);
            // 
            // btn_themBan
            // 
            this.btn_themBan.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_themBan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themBan.Location = new System.Drawing.Point(12, 164);
            this.btn_themBan.Name = "btn_themBan";
            this.btn_themBan.Size = new System.Drawing.Size(121, 34);
            this.btn_themBan.TabIndex = 26;
            this.btn_themBan.Text = "Thêm bàn";
            this.btn_themBan.UseVisualStyleBackColor = false;
            this.btn_themBan.Click += new System.EventHandler(this.btn_themBan_Click);
            // 
            // txt_tenBan
            // 
            this.txt_tenBan.AcceptsReturn = false;
            this.txt_tenBan.AcceptsTab = false;
            this.txt_tenBan.AnimationSpeed = 200;
            this.txt_tenBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_tenBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_tenBan.BackColor = System.Drawing.Color.Transparent;
            this.txt_tenBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tenBan.BackgroundImage")));
            this.txt_tenBan.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_tenBan.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_tenBan.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_tenBan.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_tenBan.BorderRadius = 1;
            this.txt_tenBan.BorderThickness = 1;
            this.txt_tenBan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenBan.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenBan.DefaultText = "";
            this.txt_tenBan.FillColor = System.Drawing.Color.White;
            this.txt_tenBan.HideSelection = true;
            this.txt_tenBan.IconLeft = null;
            this.txt_tenBan.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenBan.IconPadding = 10;
            this.txt_tenBan.IconRight = null;
            this.txt_tenBan.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenBan.Lines = new string[0];
            this.txt_tenBan.Location = new System.Drawing.Point(205, 41);
            this.txt_tenBan.MaxLength = 32767;
            this.txt_tenBan.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_tenBan.Modified = false;
            this.txt_tenBan.Multiline = false;
            this.txt_tenBan.Name = "txt_tenBan";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenBan.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_tenBan.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenBan.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_tenBan.OnIdleState = stateProperties8;
            this.txt_tenBan.Padding = new System.Windows.Forms.Padding(3);
            this.txt_tenBan.PasswordChar = '\0';
            this.txt_tenBan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_tenBan.PlaceholderText = "";
            this.txt_tenBan.ReadOnly = false;
            this.txt_tenBan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_tenBan.SelectedText = "";
            this.txt_tenBan.SelectionLength = 0;
            this.txt_tenBan.SelectionStart = 0;
            this.txt_tenBan.ShortcutsEnabled = true;
            this.txt_tenBan.Size = new System.Drawing.Size(235, 40);
            this.txt_tenBan.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_tenBan.TabIndex = 31;
            this.txt_tenBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenBan.TextMarginBottom = 0;
            this.txt_tenBan.TextMarginLeft = 3;
            this.txt_tenBan.TextMarginTop = 0;
            this.txt_tenBan.TextPlaceholder = "";
            this.txt_tenBan.UseSystemPasswordChar = false;
            this.txt_tenBan.WordWrap = true;
            // 
            // lbl_tenban
            // 
            this.lbl_tenban.AllowParentOverrides = false;
            this.lbl_tenban.AutoEllipsis = false;
            this.lbl_tenban.AutoSize = false;
            this.lbl_tenban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_tenban.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_tenban.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_tenban.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenban.Location = new System.Drawing.Point(73, 41);
            this.lbl_tenban.Name = "lbl_tenban";
            this.lbl_tenban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tenban.Size = new System.Drawing.Size(101, 37);
            this.lbl_tenban.TabIndex = 30;
            this.lbl_tenban.Text = "Tên bàn";
            this.lbl_tenban.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tenban.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // QuanLiBan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(649, 443);
            this.Controls.Add(this.txt_tenBan);
            this.Controls.Add(this.lbl_tenban);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_suaBan);
            this.Controls.Add(this.btn_xoaBan);
            this.Controls.Add(this.btn_themBan);
            this.Controls.Add(this.dtg_danhsachBan);
            this.Name = "QuanLiBan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí bàn";
            this.Load += new System.EventHandler(this.QuanLiBan_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtg_danhsachBan;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_suaBan;
        private System.Windows.Forms.Button btn_xoaBan;
        private System.Windows.Forms.Button btn_themBan;
        private Bunifu.UI.WinForms.BunifuTextBox txt_tenBan;
        private Bunifu.UI.WinForms.BunifuLabel lbl_tenban;
    }
}