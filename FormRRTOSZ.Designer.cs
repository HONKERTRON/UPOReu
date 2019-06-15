namespace UPOReu
{
    partial class FormRRTOSZ
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
            this.dataGridViewRRTOSZ = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRRTOSZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewRRTOSZ);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewDetails);
            this.splitContainer1.Size = new System.Drawing.Size(830, 411);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewRRTOSZ
            // 
            this.dataGridViewRRTOSZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRRTOSZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRRTOSZ.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRRTOSZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRRTOSZ.Name = "dataGridViewRRTOSZ";
            this.dataGridViewRRTOSZ.Size = new System.Drawing.Size(442, 411);
            this.dataGridViewRRTOSZ.TabIndex = 0;
            this.dataGridViewRRTOSZ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRRTOSZ_CellContentClick);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(382, 411);
            this.dataGridViewDetails.TabIndex = 0;
            // 
            // FormRRTOSZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 411);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRRTOSZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJournal";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRRTOSZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewRRTOSZ;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
    }
}