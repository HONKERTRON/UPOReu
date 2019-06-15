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
            this.textBoxDateSOj = new System.Windows.Forms.TextBox();
            this.labelStateOj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // buttonInsertSOj
            // 
            this.buttonInsertSOj.Location = new System.Drawing.Point(360, 273);
            this.buttonInsertSOj.Name = "buttonInsertSOj";
            this.buttonInsertSOj.Size = new System.Drawing.Size(283, 48);
            this.buttonInsertSOj.TabIndex = 26;
            this.buttonInsertSOj.Text = "Добавить объект";
            this.buttonInsertSOj.UseVisualStyleBackColor = true;
            // 
            // labelSOjdes
            // 
            this.labelSOjdes.AutoSize = true;
            this.labelSOjdes.BackColor = System.Drawing.Color.Transparent;
            this.labelSOjdes.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSOjdes.Location = new System.Drawing.Point(158, 87);
            this.labelSOjdes.Name = "labelSOjdes";
            this.labelSOjdes.Size = new System.Drawing.Size(195, 26);
            this.labelSOjdes.TabIndex = 25;
            this.labelSOjdes.Text = "Описание сотояния";
            // 
            // textBoxSOjdes
            // 
            this.textBoxSOjdes.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSOjdes.Location = new System.Drawing.Point(360, 87);
            this.textBoxSOjdes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSOjdes.Multiline = true;
            this.textBoxSOjdes.Name = "textBoxSOjdes";
            this.textBoxSOjdes.Size = new System.Drawing.Size(283, 155);
            this.textBoxSOjdes.TabIndex = 24;
            // 
            // textBoxDateSOj
            // 
            this.textBoxDateSOj.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateSOj.Location = new System.Drawing.Point(360, 43);
            this.textBoxDateSOj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDateSOj.Name = "textBoxDateSOj";
            this.textBoxDateSOj.Size = new System.Drawing.Size(283, 34);
            this.textBoxDateSOj.TabIndex = 23;
            // 
            // labelStateOj
            // 
            this.labelStateOj.AutoSize = true;
            this.labelStateOj.BackColor = System.Drawing.Color.Transparent;
            this.labelStateOj.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStateOj.Location = new System.Drawing.Point(195, 46);
            this.labelStateOj.Name = "labelStateOj";
            this.labelStateOj.Size = new System.Drawing.Size(158, 26);
            this.labelStateOj.TabIndex = 22;
            this.labelStateOj.Text = "Дата состояния";
            // 
            // FormInsertSos_obj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsertSOj);
            this.Controls.Add(this.labelSOjdes);
            this.Controls.Add(this.textBoxSOjdes);
            this.Controls.Add(this.textBoxDateSOj);
            this.Controls.Add(this.labelStateOj);
            this.Name = "FormInsertSos_obj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInsertSos_obj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsertSOj;
        private System.Windows.Forms.Label labelSOjdes;
        private System.Windows.Forms.TextBox textBoxSOjdes;
        private System.Windows.Forms.TextBox textBoxDateSOj;
        private System.Windows.Forms.Label labelStateOj;
    }
}