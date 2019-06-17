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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUO
            // 
            this.dataGridViewUO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUO.GridColor = System.Drawing.Color.Tomato;
            this.dataGridViewUO.Location = new System.Drawing.Point(4, 1);
            this.dataGridViewUO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewUO.Name = "dataGridViewUO";
            this.dataGridViewUO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewUO.Size = new System.Drawing.Size(1639, 328);
            this.dataGridViewUO.TabIndex = 0;
            this.dataGridViewUO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUO_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonUO);
            this.panel1.Location = new System.Drawing.Point(12, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 151);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUO
            // 
            this.buttonUO.Location = new System.Drawing.Point(52, 32);
            this.buttonUO.Name = "buttonUO";
            this.buttonUO.Size = new System.Drawing.Size(209, 50);
            this.buttonUO.TabIndex = 0;
            this.buttonUO.Text = "button1";
            this.buttonUO.UseVisualStyleBackColor = true;
            this.buttonUO.Click += new System.EventHandler(this.buttonUO_Click);
            // 
            // FormUO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewUO);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет огнетушителей";
            this.Load += new System.EventHandler(this.FormUO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewUO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUO;
        private System.Windows.Forms.Button button1;
    }
}