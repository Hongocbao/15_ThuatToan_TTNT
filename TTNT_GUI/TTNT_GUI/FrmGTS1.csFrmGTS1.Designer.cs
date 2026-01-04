namespace TTNT_GUI
{
    partial class FrmGTS1
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
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            this.txtSoDinh = new System.Windows.Forms.TextBox();
            this.dgvMaTranKe = new System.Windows.Forms.DataGridView();
            this.btnTinh = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.rtbNhatKy = new System.Windows.Forms.RichTextBox();
            this.lblSoSac = new System.Windows.Forms.Label();
            this.pnlVeDoThi = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.Location = new System.Drawing.Point(39, 135);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(75, 49);
            this.btnTaoMaTran.TabIndex = 0;
            this.btnTaoMaTran.Text = "Tao ma tran ke";
            this.btnTaoMaTran.UseVisualStyleBackColor = true;
            this.btnTaoMaTran.Click += new System.EventHandler(this.btnTaoMaTran_Click);
            // 
            // txtSoDinh
            // 
            this.txtSoDinh.Location = new System.Drawing.Point(74, 63);
            this.txtSoDinh.Name = "txtSoDinh";
            this.txtSoDinh.Size = new System.Drawing.Size(100, 20);
            this.txtSoDinh.TabIndex = 1;
            this.txtSoDinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvMaTranKe
            // 
            this.dgvMaTranKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaTranKe.Location = new System.Drawing.Point(785, 399);
            this.dgvMaTranKe.Name = "dgvMaTranKe";
            this.dgvMaTranKe.Size = new System.Drawing.Size(362, 187);
            this.dgvMaTranKe.TabIndex = 2;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(181, 135);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 49);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Chay GTS1";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(785, 173);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(362, 213);
            this.dgvKetQua.TabIndex = 4;
            // 
            // rtbNhatKy
            // 
            this.rtbNhatKy.Location = new System.Drawing.Point(306, 399);
            this.rtbNhatKy.Name = "rtbNhatKy";
            this.rtbNhatKy.Size = new System.Drawing.Size(464, 187);
            this.rtbNhatKy.TabIndex = 5;
            this.rtbNhatKy.Text = "";
            // 
            // lblSoSac
            // 
            this.lblSoSac.AutoSize = true;
            this.lblSoSac.Location = new System.Drawing.Point(75, 97);
            this.lblSoSac.Name = "lblSoSac";
            this.lblSoSac.Size = new System.Drawing.Size(0, 13);
            this.lblSoSac.TabIndex = 6;
            // 
            // pnlVeDoThi
            // 
            this.pnlVeDoThi.Location = new System.Drawing.Point(306, 10);
            this.pnlVeDoThi.Name = "pnlVeDoThi";
            this.pnlVeDoThi.Size = new System.Drawing.Size(464, 376);
            this.pnlVeDoThi.TabIndex = 7;
            this.pnlVeDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVeDoThi_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoDinh);
            this.groupBox1.Controls.Add(this.lblSoSac);
            this.groupBox1.Controls.Add(this.btnTaoMaTran);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Location = new System.Drawing.Point(12, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng diều Khiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giải Thuật GTS1";
            // 
            // FrmGTS1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 588);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbNhatKy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlVeDoThi);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dgvMaTranKe);
            this.Name = "FrmGTS1";
            this.Text = "FrmGTS1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.TextBox txtSoDinh;
        private System.Windows.Forms.DataGridView dgvMaTranKe;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.RichTextBox rtbNhatKy;
        private System.Windows.Forms.Label lblSoSac;
        private System.Windows.Forms.Panel pnlVeDoThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}