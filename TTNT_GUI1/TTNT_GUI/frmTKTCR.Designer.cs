namespace TTNT_GUI
{
    partial class frmTKTCR
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
            this.ckbHTCT = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBD = new System.Windows.Forms.ComboBox();
            this.cboKT = new System.Windows.Forms.ComboBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnLKQ = new System.Windows.Forms.Button();
            this.pnlDoThi = new System.Windows.Forms.Panel();
            this.btnR = new System.Windows.Forms.Button();
            this.lsvHT = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ckbHTCT
            // 
            this.ckbHTCT.AutoSize = true;
            this.ckbHTCT.Location = new System.Drawing.Point(722, 398);
            this.ckbHTCT.Name = "ckbHTCT";
            this.ckbHTCT.Size = new System.Drawing.Size(113, 20);
            this.ckbHTCT.TabIndex = 0;
            this.ckbHTCT.Text = "Hiển thị chi tiết";
            this.ckbHTCT.UseVisualStyleBackColor = true;
            this.ckbHTCT.CheckedChanged += new System.EventHandler(this.ckbHTCT_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm Kết Thúc";
            // 
            // cboBD
            // 
            this.cboBD.FormattingEnabled = true;
            this.cboBD.Location = new System.Drawing.Point(286, 20);
            this.cboBD.Name = "cboBD";
            this.cboBD.Size = new System.Drawing.Size(121, 24);
            this.cboBD.TabIndex = 4;
            // 
            // cboKT
            // 
            this.cboKT.FormattingEnabled = true;
            this.cboKT.Location = new System.Drawing.Point(286, 65);
            this.cboKT.Name = "cboKT";
            this.cboKT.Size = new System.Drawing.Size(121, 24);
            this.cboKT.TabIndex = 5;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(113, 398);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "Chạy";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnLKQ
            // 
            this.btnLKQ.Location = new System.Drawing.Point(370, 398);
            this.btnLKQ.Name = "btnLKQ";
            this.btnLKQ.Size = new System.Drawing.Size(101, 23);
            this.btnLKQ.TabIndex = 7;
            this.btnLKQ.Text = "Lưu kết quả";
            this.btnLKQ.UseVisualStyleBackColor = true;
            this.btnLKQ.Click += new System.EventHandler(this.btnLKQ_Click);
            // 
            // pnlDoThi
            // 
            this.pnlDoThi.Location = new System.Drawing.Point(12, 95);
            this.pnlDoThi.Name = "pnlDoThi";
            this.pnlDoThi.Size = new System.Drawing.Size(530, 287);
            this.pnlDoThi.TabIndex = 8;
            this.pnlDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDoThi_Paint);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(245, 398);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 9;
            this.btnR.Text = "Reset";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // lsvHT
            // 
            this.lsvHT.FullRowSelect = true;
            this.lsvHT.GridLines = true;
            this.lsvHT.HideSelection = false;
            this.lsvHT.Location = new System.Drawing.Point(548, 95);
            this.lsvHT.Name = "lsvHT";
            this.lsvHT.Size = new System.Drawing.Size(399, 287);
            this.lsvHT.TabIndex = 10;
            this.lsvHT.UseCompatibleStateImageBehavior = false;
            this.lsvHT.View = System.Windows.Forms.View.Details;
            this.lsvHT.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frmTKTCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.lsvHT);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.pnlDoThi);
            this.Controls.Add(this.btnLKQ);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.cboKT);
            this.Controls.Add(this.cboBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbHTCT);
            this.Name = "frmTKTCR";
            this.Text = "Tìm Kiếm Theo Chiều Rộng";
            this.Load += new System.EventHandler(this.frmTKTCR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbHTCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBD;
        private System.Windows.Forms.ComboBox cboKT;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnLKQ;
        private System.Windows.Forms.Panel pnlDoThi;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.ListView lsvHT;
    }
}