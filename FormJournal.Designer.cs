namespace UPOReu
{
    partial class FormJournal
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
            this.dataGridViewJ = new System.Windows.Forms.DataGridView();
            this.dataGridViewJTT = new System.Windows.Forms.DataGridView();
            this.dataGridViewJD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJ
            // 
            this.dataGridViewJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJ.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewJ.Name = "dataGridViewJ";
            this.dataGridViewJ.Size = new System.Drawing.Size(529, 147);
            this.dataGridViewJ.TabIndex = 0;
            this.dataGridViewJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewJTT
            // 
            this.dataGridViewJTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJTT.Location = new System.Drawing.Point(12, 165);
            this.dataGridViewJTT.Name = "dataGridViewJTT";
            this.dataGridViewJTT.Size = new System.Drawing.Size(279, 95);
            this.dataGridViewJTT.TabIndex = 1;
            // 
            // dataGridViewJD
            // 
            this.dataGridViewJD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJD.Location = new System.Drawing.Point(297, 165);
            this.dataGridViewJD.Name = "dataGridViewJD";
            this.dataGridViewJD.Size = new System.Drawing.Size(244, 95);
            this.dataGridViewJD.TabIndex = 2;
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 267);
            this.Controls.Add(this.dataGridViewJD);
            this.Controls.Add(this.dataGridViewJTT);
            this.Controls.Add(this.dataGridViewJ);
            this.Name = "FormJournal";
            this.Text = "FormJournal";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJ;
        private System.Windows.Forms.DataGridView dataGridViewJTT;
        private System.Windows.Forms.DataGridView dataGridViewJD;
    }
}