namespace TTNT_GUI
{
    partial class FrmCayHopGiai
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
            this.lblSoDinh = new System.Windows.Forms.Label();
            this.txtSoDinh = new System.Windows.Forms.TextBox();
            this.lblSoMau = new System.Windows.Forms.Label();
            this.txtSoMau = new System.Windows.Forms.TextBox();
            this.btnTaoDoThi = new System.Windows.Forms.Button();
            this.btnCayHopGiai = new System.Windows.Forms.Button();
            this.treeCay = new System.Windows.Forms.TreeView();
            this.dgvMaTran = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTran)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoDinh
            // 
            this.lblSoDinh.AutoSize = true;
            this.lblSoDinh.Location = new System.Drawing.Point(6, 28);
            this.lblSoDinh.Name = "lblSoDinh";
            this.lblSoDinh.Size = new System.Drawing.Size(44, 13);
            this.lblSoDinh.TabIndex = 0;
            this.lblSoDinh.Text = "Số đỉnh";
            // 
            // txtSoDinh
            // 
            this.txtSoDinh.Location = new System.Drawing.Point(56, 25);
            this.txtSoDinh.Name = "txtSoDinh";
            this.txtSoDinh.Size = new System.Drawing.Size(100, 20);
            this.txtSoDinh.TabIndex = 1;
            this.txtSoDinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSoMau
            // 
            this.lblSoMau.AutoSize = true;
            this.lblSoMau.Location = new System.Drawing.Point(6, 63);
            this.lblSoMau.Name = "lblSoMau";
            this.lblSoMau.Size = new System.Drawing.Size(43, 13);
            this.lblSoMau.TabIndex = 2;
            this.lblSoMau.Text = "Số màu";
            // 
            // txtSoMau
            // 
            this.txtSoMau.Location = new System.Drawing.Point(56, 63);
            this.txtSoMau.Name = "txtSoMau";
            this.txtSoMau.Size = new System.Drawing.Size(100, 20);
            this.txtSoMau.TabIndex = 3;
            // 
            // btnTaoDoThi
            // 
            this.btnTaoDoThi.Location = new System.Drawing.Point(6, 119);
            this.btnTaoDoThi.Name = "btnTaoDoThi";
            this.btnTaoDoThi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoDoThi.TabIndex = 4;
            this.btnTaoDoThi.Text = "Tạo đồ thị";
            this.btnTaoDoThi.UseVisualStyleBackColor = true;
            this.btnTaoDoThi.Click += new System.EventHandler(this.btnTaoDoThi_Click);
            // 
            // btnCayHopGiai
            // 
            this.btnCayHopGiai.Location = new System.Drawing.Point(104, 119);
            this.btnCayHopGiai.Name = "btnCayHopGiai";
            this.btnCayHopGiai.Size = new System.Drawing.Size(75, 23);
            this.btnCayHopGiai.TabIndex = 5;
            this.btnCayHopGiai.Text = "Chạy cây hợp giải";
            this.btnCayHopGiai.UseVisualStyleBackColor = true;
            this.btnCayHopGiai.Click += new System.EventHandler(this.btnCayHopGiai_Click);
            // 
            // treeCay
            // 
            this.treeCay.Location = new System.Drawing.Point(396, 402);
            this.treeCay.Name = "treeCay";
            this.treeCay.Size = new System.Drawing.Size(293, 174);
            this.treeCay.TabIndex = 6;
            // 
            // dgvMaTran
            // 
            this.dgvMaTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaTran.Location = new System.Drawing.Point(695, 402);
            this.dgvMaTran.Name = "dgvMaTran";
            this.dgvMaTran.Size = new System.Drawing.Size(393, 174);
            this.dgvMaTran.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.lblSoDinh);
            this.groupBox1.Controls.Add(this.txtSoDinh);
            this.groupBox1.Controls.Add(this.lblSoMau);
            this.groupBox1.Controls.Add(this.btnCayHopGiai);
            this.groupBox1.Controls.Add(this.txtSoMau);
            this.groupBox1.Controls.Add(this.btnTaoDoThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Diều Khiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cây Hợp Giải";
            // 
            // FrmCayHopGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMaTran);
            this.Controls.Add(this.treeCay);
            this.Name = "FrmCayHopGiai";
            this.Text = "FmCayHopGiai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaTran)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoDinh;
        private System.Windows.Forms.TextBox txtSoDinh;
        private System.Windows.Forms.Label lblSoMau;
        private System.Windows.Forms.TextBox txtSoMau;
        private System.Windows.Forms.Button btnTaoDoThi;
        private System.Windows.Forms.Button btnCayHopGiai;
        private System.Windows.Forms.TreeView treeCay;
        private System.Windows.Forms.DataGridView dgvMaTran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}