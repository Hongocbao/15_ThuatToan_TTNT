namespace TTNT_GUI
{
    partial class FrmCayQuyetDinhV
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.lblRoot = new System.Windows.Forms.Label();
            this.treeQuyetDinh = new System.Windows.Forms.TreeView();
            this.btnMoFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(248, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÂY QUYẾT ĐỊNH – ĐỘ ĐO V";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(688, 282);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(481, 303);
            this.dgvData.TabIndex = 1;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Location = new System.Drawing.Point(688, 126);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(481, 150);
            this.dgvKetQua.TabIndex = 3;
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(252, 325);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(81, 13);
            this.lblRoot.TabIndex = 4;
            this.lblRoot.Text = "Thuộc tính gốc";
            // 
            // treeQuyetDinh
            // 
            this.treeQuyetDinh.Location = new System.Drawing.Point(255, 378);
            this.treeQuyetDinh.Name = "treeQuyetDinh";
            this.treeQuyetDinh.Size = new System.Drawing.Size(427, 207);
            this.treeQuyetDinh.TabIndex = 5;
            this.treeQuyetDinh.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeQuyetDinh_AfterSelect);
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(2, 2);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(75, 23);
            this.btnMoFile.TabIndex = 6;
            this.btnMoFile.Text = "Mở file Word";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // FrmCayQuyetDinhV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 597);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.treeQuyetDinh);
            this.Controls.Add(this.lblRoot);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmCayQuyetDinhV";
            this.Text = "FrmCayQuyetDinh";
            this.Load += new System.EventHandler(this.FrmCayQuyetDinhV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.TreeView treeQuyetDinh;
        private System.Windows.Forms.Button btnMoFile;
    }
}