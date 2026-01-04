namespace TTNT_GUI
{
    partial class frmGTA
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
            this.btnR = new System.Windows.Forms.Button();
            this.pnlDoThi = new System.Windows.Forms.Panel();
            this.btnLKQ = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.cboKT = new System.Windows.Forms.ComboBox();
            this.cboBD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbHTCT = new System.Windows.Forms.CheckBox();
            this.lstPath = new System.Windows.Forms.ListBox();
            this.lvSteps = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(325, 406);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 18;
            this.btnR.Text = "Reset";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // pnlDoThi
            // 
            this.pnlDoThi.Location = new System.Drawing.Point(0, 105);
            this.pnlDoThi.Name = "pnlDoThi";
            this.pnlDoThi.Size = new System.Drawing.Size(620, 292);
            this.pnlDoThi.TabIndex = 17;
            this.pnlDoThi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDoThi_Paint);
            // 
            // btnLKQ
            // 
            this.btnLKQ.Location = new System.Drawing.Point(194, 406);
            this.btnLKQ.Name = "btnLKQ";
            this.btnLKQ.Size = new System.Drawing.Size(101, 23);
            this.btnLKQ.TabIndex = 16;
            this.btnLKQ.Text = "Lưu kết quả";
            this.btnLKQ.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(80, 406);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 15;
            this.btnC.Text = "Chạy";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // cboKT
            // 
            this.cboKT.FormattingEnabled = true;
            this.cboKT.Location = new System.Drawing.Point(221, 67);
            this.cboKT.Name = "cboKT";
            this.cboKT.Size = new System.Drawing.Size(121, 24);
            this.cboKT.TabIndex = 14;
            // 
            // cboBD
            // 
            this.cboBD.FormattingEnabled = true;
            this.cboBD.Location = new System.Drawing.Point(221, 25);
            this.cboBD.Name = "cboBD";
            this.cboBD.Size = new System.Drawing.Size(121, 24);
            this.cboBD.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Điểm Kết Thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Điểm Bắt Đầu";
            // 
            // ckbHTCT
            // 
            this.ckbHTCT.AutoSize = true;
            this.ckbHTCT.Location = new System.Drawing.Point(742, 406);
            this.ckbHTCT.Name = "ckbHTCT";
            this.ckbHTCT.Size = new System.Drawing.Size(113, 20);
            this.ckbHTCT.TabIndex = 10;
            this.ckbHTCT.Text = "Hiển thị chi tiết";
            this.ckbHTCT.UseVisualStyleBackColor = true;
            this.ckbHTCT.CheckedChanged += new System.EventHandler(this.ckbHTCT_CheckedChanged);
            // 
            // lstPath
            // 
            this.lstPath.FormattingEnabled = true;
            this.lstPath.ItemHeight = 16;
            this.lstPath.Location = new System.Drawing.Point(617, 105);
            this.lstPath.Name = "lstPath";
            this.lstPath.Size = new System.Drawing.Size(50, 292);
            this.lstPath.TabIndex = 19;
            // 
            // lvSteps
            // 
            this.lvSteps.FullRowSelect = true;
            this.lvSteps.GridLines = true;
            this.lvSteps.HideSelection = false;
            this.lvSteps.Location = new System.Drawing.Point(660, 105);
            this.lvSteps.Name = "lvSteps";
            this.lvSteps.Size = new System.Drawing.Size(412, 292);
            this.lvSteps.TabIndex = 21;
            this.lvSteps.UseCompatibleStateImageBehavior = false;
            this.lvSteps.View = System.Windows.Forms.View.Details;
            // 
            // frmGTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.lvSteps);
            this.Controls.Add(this.lstPath);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.pnlDoThi);
            this.Controls.Add(this.btnLKQ);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.cboKT);
            this.Controls.Add(this.cboBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbHTCT);
            this.Name = "frmGTA";
            this.Text = "Giải Thuật A*";
            this.Load += new System.EventHandler(this.frmGTA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Panel pnlDoThi;
        private System.Windows.Forms.Button btnLKQ;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.ComboBox cboKT;
        private System.Windows.Forms.ComboBox cboBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbHTCT;
        private System.Windows.Forms.ListBox lstPath;
        private System.Windows.Forms.ListView lvSteps;
    }
}