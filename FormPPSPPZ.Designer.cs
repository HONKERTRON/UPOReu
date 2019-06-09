namespace UPOReu
{
    partial class FormPPSPPZ
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
            this.dataGridViewPPSPPZ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPPSPPZ)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPPSPPZ
            // 
            this.dataGridViewPPSPPZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPPSPPZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPPSPPZ.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPPSPPZ.Name = "dataGridViewPPSPPZ";
            this.dataGridViewPPSPPZ.Size = new System.Drawing.Size(284, 261);
            this.dataGridViewPPSPPZ.TabIndex = 0;
            this.dataGridViewPPSPPZ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPPSPPZ_CellContentClick);
            // 
            // FormPPSPPZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridViewPPSPPZ);
            this.Name = "FormPPSPPZ";
            this.Text = "FormPPSPPZ";
            this.Load += new System.EventHandler(this.FormPPSPPZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPPSPPZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPPSPPZ;
    }
}