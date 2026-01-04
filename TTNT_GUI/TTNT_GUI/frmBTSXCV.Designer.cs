namespace TTNT_GUI
{
    partial class frmBTSXCV
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
            this.lsvQL = new System.Windows.Forms.ListView();
            this.lsvBD = new System.Windows.Forms.ListView();
            this.btnT = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.txtTCV = new System.Windows.Forms.TextBox();
            this.txtTGCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBT = new System.Windows.Forms.ComboBox();
            this.btnXKQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvQL
            // 
            this.lsvQL.HideSelection = false;
            this.lsvQL.Location = new System.Drawing.Point(159, 230);
            this.lsvQL.Name = "lsvQL";
            this.lsvQL.Size = new System.Drawing.Size(695, 208);
            this.lsvQL.TabIndex = 4;
            this.lsvQL.UseCompatibleStateImageBehavior = false;
            // 
            // lsvBD
            // 
            this.lsvBD.HideSelection = false;
            this.lsvBD.Location = new System.Drawing.Point(159, 76);
            this.lsvBD.Name = "lsvBD";
            this.lsvBD.Size = new System.Drawing.Size(695, 148);
            this.lsvBD.TabIndex = 5;
            this.lsvBD.UseCompatibleStateImageBehavior = false;
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(277, 33);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 6;
            this.btnT.Text = "Thêm";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(698, 33);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "Xóa";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(779, 33);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "Chạy";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtTCV
            // 
            this.txtTCV.Location = new System.Drawing.Point(461, 33);
            this.txtTCV.Name = "txtTCV";
            this.txtTCV.Size = new System.Drawing.Size(57, 22);
            this.txtTCV.TabIndex = 9;
            // 
            // txtTGCV
            // 
            this.txtTGCV.Location = new System.Drawing.Point(638, 33);
            this.txtTGCV.Name = "txtTGCV";
            this.txtTGCV.Size = new System.Drawing.Size(54, 22);
            this.txtTGCV.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thời gian CV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên CV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Biểu Thức";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ban đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sau khi sắp xếp";
            // 
            // cboBT
            // 
            this.cboBT.FormattingEnabled = true;
            this.cboBT.Location = new System.Drawing.Point(125, 34);
            this.cboBT.Name = "cboBT";
            this.cboBT.Size = new System.Drawing.Size(121, 24);
            this.cboBT.TabIndex = 16;
            // 
            // btnXKQ
            // 
            this.btnXKQ.Location = new System.Drawing.Point(16, 394);
            this.btnXKQ.Name = "btnXKQ";
            this.btnXKQ.Size = new System.Drawing.Size(123, 23);
            this.btnXKQ.TabIndex = 17;
            this.btnXKQ.Text = "Xóa Kết Quả";
            this.btnXKQ.UseVisualStyleBackColor = true;
            this.btnXKQ.Click += new System.EventHandler(this.btnXKQ_Click);
            // 
            // frmBTSXCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.btnXKQ);
            this.Controls.Add(this.cboBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTGCV);
            this.Controls.Add(this.txtTCV);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.lsvBD);
            this.Controls.Add(this.lsvQL);
            this.Name = "frmBTSXCV";
            this.Text = "Bài Toán Sắp Xếp Công Việc";
            this.Load += new System.EventHandler(this.frmBTSXCV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvQL;
        private System.Windows.Forms.ListView lsvBD;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtTCV;
        private System.Windows.Forms.TextBox txtTGCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBT;
        private System.Windows.Forms.Button btnXKQ;
    }
}