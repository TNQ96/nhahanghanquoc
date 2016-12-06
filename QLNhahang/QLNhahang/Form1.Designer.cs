namespace QLNhahang
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btQuanLy = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ NHÀ HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btQuanLy
            // 
            this.btQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLy.ForeColor = System.Drawing.Color.Red;
            this.btQuanLy.Location = new System.Drawing.Point(193, 249);
            this.btQuanLy.Name = "btQuanLy";
            this.btQuanLy.Size = new System.Drawing.Size(228, 43);
            this.btQuanLy.TabIndex = 1;
            this.btQuanLy.Text = "QUẢN LÝ";
            this.btQuanLy.UseVisualStyleBackColor = true;
            this.btQuanLy.Click += new System.EventHandler(this.btQuanLy_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btThanhToan.Location = new System.Drawing.Point(193, 151);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(228, 43);
            this.btThanhToan.TabIndex = 1;
            this.btThanhToan.Text = "THANH TOÁN";
            this.btThanhToan.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(633, 422);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btQuanLy);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuanLy;
        private System.Windows.Forms.Button btThanhToan;
    }
}

