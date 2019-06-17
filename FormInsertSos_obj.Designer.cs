namespace UPOReu
{
    partial class FormInsertSos_obj
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsertSOj = new System.Windows.Forms.Button();
            this.labelSOjdes = new System.Windows.Forms.Label();
            this.textBoxSOjdes = new System.Windows.Forms.TextBox();
            this.labelStateOj = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // buttonInsertSOj
            // 
            this.buttonInsertSOj.Location = new System.Drawing.Point(240, 164);
            this.buttonInsertSOj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInsertSOj.Name = "buttonInsertSOj";
            this.buttonInsertSOj.Size = new System.Drawing.Size(189, 31);
            this.buttonInsertSOj.TabIndex = 26;
            this.buttonInsertSOj.Text = "Добавить объект";
            this.buttonInsertSOj.UseVisualStyleBackColor = true;
            this.buttonInsertSOj.Click += new System.EventHandler(this.buttonInsertSOj_Click);
            // 
            // labelSOjdes
            // 
            this.labelSOjdes.AutoSize = true;
            this.labelSOjdes.BackColor = System.Drawing.Color.Transparent;
            this.labelSOjdes.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSOjdes.Location = new System.Drawing.Point(105, 57);
            this.labelSOjdes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSOjdes.Name = "labelSOjdes";
            this.labelSOjdes.Size = new System.Drawing.Size(140, 19);
            this.labelSOjdes.TabIndex = 25;
            this.labelSOjdes.Text = "Описание сотояния";
            // 
            // textBoxSOjdes
            // 
            this.textBoxSOjdes.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSOjdes.Location = new System.Drawing.Point(240, 57);
            this.textBoxSOjdes.Multiline = true;
            this.textBoxSOjdes.Name = "textBoxSOjdes";
            this.textBoxSOjdes.Size = new System.Drawing.Size(190, 102);
            this.textBoxSOjdes.TabIndex = 24;
            // 
            // labelStateOj
            // 
            this.labelStateOj.AutoSize = true;
            this.labelStateOj.BackColor = System.Drawing.Color.Transparent;
            this.labelStateOj.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStateOj.Location = new System.Drawing.Point(130, 30);
            this.labelStateOj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStateOj.Name = "labelStateOj";
            this.labelStateOj.Size = new System.Drawing.Size(112, 19);
            this.labelStateOj.TabIndex = 22;
            this.labelStateOj.Text = "Дата состояния";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(240, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker.TabIndex = 28;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormInsertSos_obj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertSOj);
            this.Controls.Add(this.labelSOjdes);
            this.Controls.Add(this.textBoxSOjdes);
            this.Controls.Add(this.labelStateOj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInsertSos_obj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertSos_obj";
            this.Load += new System.EventHandler(this.FormInsertSos_obj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsertSOj;
        private System.Windows.Forms.Label labelSOjdes;
        private System.Windows.Forms.TextBox textBoxSOjdes;
        private System.Windows.Forms.Label labelStateOj;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}