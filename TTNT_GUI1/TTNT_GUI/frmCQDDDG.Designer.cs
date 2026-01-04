namespace TTNT_GUI
{
    partial class frmCQDDDG
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
            this.btnChonFile = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cboTarget = new System.Windows.Forms.ComboBox();
            this.btnBuildTree = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tvDecisionTree = new System.Windows.Forms.TreeView();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(51, 31);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(75, 23);
            this.btnChonFile.TabIndex = 0;
            this.btnChonFile.Text = "Chọn File";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 77);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(777, 188);
            this.dgvData.TabIndex = 1;
            // 
            // cboTarget
            // 
            this.cboTarget.FormattingEnabled = true;
            this.cboTarget.Location = new System.Drawing.Point(170, 31);
            this.cboTarget.Name = "cboTarget";
            this.cboTarget.Size = new System.Drawing.Size(121, 24);
            this.cboTarget.TabIndex = 2;
            // 
            // btnBuildTree
            // 
            this.btnBuildTree.Location = new System.Drawing.Point(362, 31);
            this.btnBuildTree.Name = "btnBuildTree";
            this.btnBuildTree.Size = new System.Drawing.Size(75, 23);
            this.btnBuildTree.TabIndex = 3;
            this.btnBuildTree.Text = "Chạy";
            this.btnBuildTree.UseVisualStyleBackColor = true;
            this.btnBuildTree.Click += new System.EventHandler(this.btnBuildTree_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Hiển Thị";
            // 
            // tvDecisionTree
            // 
            this.tvDecisionTree.Location = new System.Drawing.Point(15, 287);
            this.tvDecisionTree.Name = "tvDecisionTree";
            this.tvDecisionTree.Size = new System.Drawing.Size(391, 301);
            this.tvDecisionTree.TabIndex = 5;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(412, 287);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(377, 301);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 31);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCQDDDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 597);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tvDecisionTree);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBuildTree);
            this.Controls.Add(this.cboTarget);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnChonFile);
            this.Name = "frmCQDDDG";
            this.Text = "Cây Quyết Định - Độ Đo Gain";
            this.Load += new System.EventHandler(this.frmCQDDDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cboTarget;
        private System.Windows.Forms.Button btnBuildTree;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TreeView tvDecisionTree;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnReset;
    }
}