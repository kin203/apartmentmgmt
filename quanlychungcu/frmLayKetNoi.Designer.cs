namespace quanlychungcu
{
    partial class frmLayKetNoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLayKetNoi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.btnThietLap = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Source";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(117, 224);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(117, 110);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(100, 20);
            this.txtDS.TabIndex = 5;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(117, 143);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 20);
            this.txtDB.TabIndex = 6;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(117, 188);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(100, 20);
            this.txtUID.TabIndex = 7;
            // 
            // btnThietLap
            // 
            this.btnThietLap.AnimationHoverSpeed = 0.07F;
            this.btnThietLap.AnimationSpeed = 0.03F;
            this.btnThietLap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThietLap.BorderColor = System.Drawing.Color.Black;
            this.btnThietLap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThietLap.FocusedColor = System.Drawing.Color.Empty;
            this.btnThietLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThietLap.ForeColor = System.Drawing.Color.White;
            this.btnThietLap.Image = ((System.Drawing.Image)(resources.GetObject("btnThietLap.Image")));
            this.btnThietLap.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThietLap.Location = new System.Drawing.Point(77, 278);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThietLap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThietLap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThietLap.OnHoverImage = null;
            this.btnThietLap.OnPressedColor = System.Drawing.Color.Black;
            this.btnThietLap.Size = new System.Drawing.Size(160, 42);
            this.btnThietLap.TabIndex = 8;
            this.btnThietLap.Text = "Thiết lập";
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // frmLayKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 348);
            this.Controls.Add(this.btnThietLap);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.txtDS);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLayKetNoi";
            this.Text = "frmLayKetNoi";
            this.Load += new System.EventHandler(this.frmLayKetNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtUID;
        private Guna.UI.WinForms.GunaButton btnThietLap;
    }
}