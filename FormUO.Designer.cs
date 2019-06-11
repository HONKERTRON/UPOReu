namespace UPOReu
{
    partial class FormUO
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
            this.dataGridViewUO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUO
            // 
            this.dataGridViewUO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUO.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUO.Name = "dataGridViewUO";
            this.dataGridViewUO.Size = new System.Drawing.Size(1386, 500);
            this.dataGridViewUO.TabIndex = 0;
            this.dataGridViewUO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUO_CellContentClick);
            this.dataGridViewUO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUO_CellDoubleClick);
            // 
            // FormUO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 500);
            this.Controls.Add(this.dataGridViewUO);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUO";
            this.Text = "Учет огнетушителей";
            this.Load += new System.EventHandler(this.FormUO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUO;
    }
}