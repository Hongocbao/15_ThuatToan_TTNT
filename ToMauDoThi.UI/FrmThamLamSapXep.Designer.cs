namespace ToMauDoThi.UI
{
    partial class FrmThamLamSapXep
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
            this.txtSoDinh = new System.Windows.Forms.TextBox();
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            this.dgvMaTranKe = new System.Windows.Forms.DataGridView();
            this.btnTinh = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.rtbNhatKy = new System.Windows.Forms.RichTextBox();
            this.lblSoSac = new System.Windows.Forms.Label();
            this.pnlVeDoThi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoDinh
            // 
            this.txtSoDinh.Location = new System.Drawing.Point(493, 473);
            this.txtSoDinh.Name = "txtSoDinh";
            this.txtSoDinh.Size = new System.Drawing.Size(91, 20);
            this.txtSoDinh.TabIndex = 0;
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.Location = new System.Drawing.Point(493, 513);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(75, 63);
            this.btnTaoMaTran.TabIndex = 1;
            this.btnTaoMaTran.Text = "TaoMaTran";
            this.btnTaoMaTran.UseVisualStyleBackColor = true;
            this.btnTaoMaTran.Click += new System.EventHandler(this.btnTaoMaTran_Click);
            // 
            // dgvMaTranKe
            // 
            this.dgvMaTranKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaTranKe.Location = new System.Drawing.Point(299, 12);
            this.dgvMaTranKe.Name = "dgvMaTranKe";
            this.dgvMaTranKe.Size = new System.Drawing.Size(415, 206);
            this.dgvMaTranKe.TabIndex = 2;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(628, 513);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 63);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "\tTinh to mau (sap xep theo bac)";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(720, 12);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(421, 206);
            this.dgvKetQua.TabIndex = 4;
            // 
            // rtbNhatKy
            // 
            this.rtbNhatKy.Location = new System.Drawing.Point(289, 224);
            this.rtbNhatKy.Name = "rtbNhatKy";
            this.rtbNhatKy.Size = new System.Drawing.Size(425, 138);
            this.rtbNhatKy.TabIndex = 5;
            this.rtbNhatKy.Text = "";
            // 
            // lblSoSac
            // 
            this.lblSoSac.AutoSize = true;
            this.lblSoSac.Location = new System.Drawing.Point(320, 435);
            this.lblSoSac.Name = "lblSoSac";
            this.lblSoSac.Size = new System.Drawing.Size(0, 13);
            this.lblSoSac.TabIndex = 6;
            // 
            // pnlVeDoThi
            // 
            this.pnlVeDoThi.Location = new System.Drawing.Point(720, 224);
            this.pnlVeDoThi.Name = "pnlVeDoThi";
            this.pnlVeDoThi.Size = new System.Drawing.Size(431, 360);
            this.pnlVeDoThi.TabIndex = 7;
            this.pnlVeDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVeDoThi_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "nhập số đỉnh N";
            // 
            // FrmThamLamSapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlVeDoThi);
            this.Controls.Add(this.lblSoSac);
            this.Controls.Add(this.rtbNhatKy);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.dgvMaTranKe);
            this.Controls.Add(this.btnTaoMaTran);
            this.Controls.Add(this.txtSoDinh);
            this.Name = "FrmThamLamSapXep";
            this.Text = "FrmThamLamSapXep";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDinh;
        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.DataGridView dgvMaTranKe;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.RichTextBox rtbNhatKy;
        private System.Windows.Forms.Label lblSoSac;
        private System.Windows.Forms.Panel pnlVeDoThi;
        private System.Windows.Forms.Label label1;
    }
}