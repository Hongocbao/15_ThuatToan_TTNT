namespace ToMauDoThi.UI
{
    partial class FrmThamLam
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMaTranKe = new System.Windows.Forms.DataGridView();
            this.btnTaoMaTran = new System.Windows.Forms.Button();
            this.pnlVeDoThi = new System.Windows.Forms.Panel();
            this.rtbNhatKy = new System.Windows.Forms.RichTextBox();
            this.lblSoSac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoDinh
            // 
            this.txtSoDinh.Location = new System.Drawing.Point(93, 397);
            this.txtSoDinh.Name = "txtSoDinh";
            this.txtSoDinh.Size = new System.Drawing.Size(116, 20);
            this.txtSoDinh.TabIndex = 0;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(93, 511);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(116, 52);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tinh to mau";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(636, 6);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(468, 197);
            this.dgvKetQua.TabIndex = 2;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(254, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÔ MÀU THAM LAM";
            // 
            // dgvMaTranKe
            // 
            this.dgvMaTranKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaTranKe.Location = new System.Drawing.Point(5, 12);
            this.dgvMaTranKe.Name = "dgvMaTranKe";
            this.dgvMaTranKe.Size = new System.Drawing.Size(625, 191);
            this.dgvMaTranKe.TabIndex = 4;
            // 
            // btnTaoMaTran
            // 
            this.btnTaoMaTran.Location = new System.Drawing.Point(93, 435);
            this.btnTaoMaTran.Name = "btnTaoMaTran";
            this.btnTaoMaTran.Size = new System.Drawing.Size(116, 59);
            this.btnTaoMaTran.TabIndex = 5;
            this.btnTaoMaTran.Text = "TaoMaTran";
            this.btnTaoMaTran.UseVisualStyleBackColor = true;
            this.btnTaoMaTran.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlVeDoThi
            // 
            this.pnlVeDoThi.Location = new System.Drawing.Point(636, 220);
            this.pnlVeDoThi.Name = "pnlVeDoThi";
            this.pnlVeDoThi.Size = new System.Drawing.Size(468, 361);
            this.pnlVeDoThi.TabIndex = 6;
            this.pnlVeDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVeDoThi_Paint);
            // 
            // rtbNhatKy
            // 
            this.rtbNhatKy.Location = new System.Drawing.Point(257, 420);
            this.rtbNhatKy.Name = "rtbNhatKy";
            this.rtbNhatKy.Size = new System.Drawing.Size(380, 161);
            this.rtbNhatKy.TabIndex = 7;
            this.rtbNhatKy.Text = "";
            this.rtbNhatKy.TextChanged += new System.EventHandler(this.rtbNhatKy_TextChanged);
            // 
            // lblSoSac
            // 
            this.lblSoSac.AutoSize = true;
            this.lblSoSac.Location = new System.Drawing.Point(93, 268);
            this.lblSoSac.Name = "lblSoSac";
            this.lblSoSac.Size = new System.Drawing.Size(0, 13);
            this.lblSoSac.TabIndex = 8;
            // 
            // FrmThamLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 593);
            this.Controls.Add(this.lblSoSac);
            this.Controls.Add(this.rtbNhatKy);
            this.Controls.Add(this.pnlVeDoThi);
            this.Controls.Add(this.btnTaoMaTran);
            this.Controls.Add(this.dgvMaTranKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSoDinh);
            this.Name = "FrmThamLam";
            this.Text = "FrmThamLam";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTranKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDinh;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMaTranKe;
        private System.Windows.Forms.Button btnTaoMaTran;
        private System.Windows.Forms.Panel pnlVeDoThi;
        private System.Windows.Forms.RichTextBox rtbNhatKy;
        private System.Windows.Forms.Label lblSoSac;
    }
}