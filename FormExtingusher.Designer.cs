namespace UPOReu
{
    partial class FormExtingusher
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
            this.dataGridViewEx = new System.Windows.Forms.DataGridView();
            this.buttonInsertEx = new System.Windows.Forms.Button();
            this.buttonDelEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEx
            // 
            this.dataGridViewEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEx.Location = new System.Drawing.Point(18, 18);
            this.dataGridViewEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEx.Name = "dataGridViewEx";
            this.dataGridViewEx.Size = new System.Drawing.Size(1113, 322);
            this.dataGridViewEx.TabIndex = 0;
            // 
            // buttonInsertEx
            // 
            this.buttonInsertEx.Location = new System.Drawing.Point(18, 367);
            this.buttonInsertEx.Name = "buttonInsertEx";
            this.buttonInsertEx.Size = new System.Drawing.Size(239, 52);
            this.buttonInsertEx.TabIndex = 1;
            this.buttonInsertEx.Text = "Добавить огнетушитель";
            this.buttonInsertEx.UseVisualStyleBackColor = true;
            this.buttonInsertEx.Click += new System.EventHandler(this.buttonInsertEx_Click);
            // 
            // buttonDelEx
            // 
            this.buttonDelEx.Location = new System.Drawing.Point(263, 367);
            this.buttonDelEx.Name = "buttonDelEx";
            this.buttonDelEx.Size = new System.Drawing.Size(239, 52);
            this.buttonDelEx.TabIndex = 2;
            this.buttonDelEx.Text = "Удалить огнетушитель";
            this.buttonDelEx.UseVisualStyleBackColor = true;
            // 
            // FormExtingusher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 524);
            this.Controls.Add(this.buttonDelEx);
            this.Controls.Add(this.buttonInsertEx);
            this.Controls.Add(this.dataGridViewEx);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormExtingusher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Огнетушитель";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEx;
        private System.Windows.Forms.Button buttonInsertEx;
        private System.Windows.Forms.Button buttonDelEx;
    }
}