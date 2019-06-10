namespace UPOReu
{
    partial class FormPeople
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
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLastname);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewPeople);
            this.splitContainer1.Size = new System.Drawing.Size(822, 485);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(18, 58);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(172, 26);
            this.textBoxLastname.TabIndex = 1;
            this.textBoxLastname.TextChanged += new System.EventHandler(this.textBoxLastname_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 18);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 26);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPeople.MultiSelect = false;
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.Size = new System.Drawing.Size(620, 485);
            this.dataGridViewPeople.TabIndex = 0;
            this.dataGridViewPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeople_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать новую учетную запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPeople";
            this.Text = "FormPeople";
            this.Load += new System.EventHandler(this.FormPeople_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Button button1;
    }
}