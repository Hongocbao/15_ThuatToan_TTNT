namespace TTNT_GUI
{
    partial class frmVH
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
            this.txtBT = new System.Windows.Forms.TextBox();
            this.btnTC = new System.Windows.Forms.Button();
            this.btnXC = new System.Windows.Forms.Button();
            this.pnlDT = new System.Windows.Forms.Panel();
            this.lblTB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBT
            // 
            this.txtBT.Location = new System.Drawing.Point(160, 26);
            this.txtBT.Multiline = true;
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(341, 22);
            this.txtBT.TabIndex = 0;
            this.txtBT.TextChanged += new System.EventHandler(this.txtBT_TextChanged);
            // 
            // btnTC
            // 
            this.btnTC.Location = new System.Drawing.Point(543, 25);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(75, 23);
            this.btnTC.TabIndex = 1;
            this.btnTC.Text = "Tạo Cây";
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // btnXC
            // 
            this.btnXC.Location = new System.Drawing.Point(661, 25);
            this.btnXC.Name = "btnXC";
            this.btnXC.Size = new System.Drawing.Size(75, 23);
            this.btnXC.TabIndex = 2;
            this.btnXC.Text = "Xóa Cây";
            this.btnXC.UseVisualStyleBackColor = true;
            this.btnXC.Click += new System.EventHandler(this.btnXC_Click);
            // 
            // pnlDT
            // 
            this.pnlDT.Location = new System.Drawing.Point(12, 65);
            this.pnlDT.Name = "pnlDT";
            this.pnlDT.Size = new System.Drawing.Size(1607, 677);
            this.pnlDT.TabIndex = 3;
            this.pnlDT.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDT_Paint);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Location = new System.Drawing.Point(24, 745);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(76, 20);
            this.lblTB.TabIndex = 4;
            this.lblTB.Text = "Kết Luận";
            this.lblTB.Click += new System.EventHandler(this.lblHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập Biểu Thức";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(980, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập ! <=> ¬, | <=> ∨, ^ <=> ∧, -> <=> →";
            // 
            // frmVH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 770);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.pnlDT);
            this.Controls.Add(this.btnXC);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.txtBT);
            this.Name = "frmVH";
            this.Text = "frmVH";
            this.Load += new System.EventHandler(this.frmVH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBT;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Button btnXC;
        private System.Windows.Forms.Panel pnlDT;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}