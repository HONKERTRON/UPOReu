namespace UPOReu
{
    partial class FormUPPPT
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
            this.dataGridViewUPPPT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUPPPT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUPPPT
            // 
            this.dataGridViewUPPPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUPPPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUPPPT.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUPPPT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUPPPT.Name = "dataGridViewUPPPT";
            this.dataGridViewUPPPT.Size = new System.Drawing.Size(1407, 402);
            this.dataGridViewUPPPT.TabIndex = 0;
            this.dataGridViewUPPPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUPPPT_CellContentClick);
            // 
            // FormUPPPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 402);
            this.Controls.Add(this.dataGridViewUPPPT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUPPPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUPPPT";
            this.Load += new System.EventHandler(this.FormUPPPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUPPPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUPPPT;
    }
}