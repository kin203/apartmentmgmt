namespace quanlychungcu
{
    partial class BackupRestore
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDuongDan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChonDDRestore = new System.Windows.Forms.Button();
            this.lbduongDanRestore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnRestore = new Guna.UI.WinForms.GunaButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gunaButton1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lbDuongDan);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn đường dẫn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDuongDan
            // 
            this.lbDuongDan.AutoSize = true;
            this.lbDuongDan.Location = new System.Drawing.Point(172, 54);
            this.lbDuongDan.Name = "lbDuongDan";
            this.lbDuongDan.Size = new System.Drawing.Size(154, 13);
            this.lbDuongDan.TabIndex = 1;
            this.lbDuongDan.Text = "Vui lòng chọn đường dẫn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn lưu trữ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRestore);
            this.tabPage2.Controls.Add(this.btnChonDDRestore);
            this.tabPage2.Controls.Add(this.lbduongDanRestore);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChonDDRestore
            // 
            this.btnChonDDRestore.Location = new System.Drawing.Point(343, 48);
            this.btnChonDDRestore.Name = "btnChonDDRestore";
            this.btnChonDDRestore.Size = new System.Drawing.Size(75, 23);
            this.btnChonDDRestore.TabIndex = 6;
            this.btnChonDDRestore.Text = "Chọn đường dẫn";
            this.btnChonDDRestore.UseVisualStyleBackColor = true;
            this.btnChonDDRestore.Click += new System.EventHandler(this.btnChonDDRestore_Click);
            // 
            // lbduongDanRestore
            // 
            this.lbduongDanRestore.AutoSize = true;
            this.lbduongDanRestore.Location = new System.Drawing.Point(176, 53);
            this.lbduongDanRestore.Name = "lbduongDanRestore";
            this.lbduongDanRestore.Size = new System.Drawing.Size(154, 13);
            this.lbduongDanRestore.TabIndex = 5;
            this.lbduongDanRestore.Text = "Vui lòng chọn đường dẫn ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đường dẫn lưu trữ";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Gray;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::quanlychungcu.Properties.Resources.backup__1_;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(146, 173);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 5;
            this.gunaButton1.Size = new System.Drawing.Size(143, 39);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Backup";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.AnimationHoverSpeed = 0.07F;
            this.btnRestore.AnimationSpeed = 0.03F;
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BaseColor = System.Drawing.Color.Gray;
            this.btnRestore.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestore.FocusedColor = System.Drawing.Color.Empty;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = global::quanlychungcu.Properties.Resources.history;
            this.btnRestore.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRestore.Location = new System.Drawing.Point(125, 167);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRestore.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRestore.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRestore.OnHoverImage = null;
            this.btnRestore.OnPressedColor = System.Drawing.Color.Black;
            this.btnRestore.Radius = 5;
            this.btnRestore.Size = new System.Drawing.Size(143, 39);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.tabControl1);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaButton btnRestore;
        private System.Windows.Forms.Button btnChonDDRestore;
        private System.Windows.Forms.Label lbduongDanRestore;
        private System.Windows.Forms.Label label3;
    }
}