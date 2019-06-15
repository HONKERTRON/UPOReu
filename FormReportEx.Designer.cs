namespace UPOReu
{
    partial class FormReportEx
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewReport);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewResult);
            this.splitContainer1.Size = new System.Drawing.Size(882, 525);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 490);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(294, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(294, 525);
            this.dataGridViewReport.TabIndex = 0;
            this.dataGridViewReport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReport_CellDoubleClick);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(582, 525);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // FormReportEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 525);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReportEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportEx";
            this.Load += new System.EventHandler(this.FormReportEx_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonSave;
    }
}