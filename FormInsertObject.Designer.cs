namespace UPOReu
{
    partial class FormInsertObject
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
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxNameObject = new System.Windows.Forms.TextBox();
            this.labelNameObject = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.buttonInsertObject = new System.Windows.Forms.Button();
            this.labelInfoInsertObject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAdres.Location = new System.Drawing.Point(299, 114);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(283, 150);
            this.textBoxAdres.TabIndex = 11;
            // 
            // textBoxNameObject
            // 
            this.textBoxNameObject.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameObject.Location = new System.Drawing.Point(299, 68);
            this.textBoxNameObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameObject.Name = "textBoxNameObject";
            this.textBoxNameObject.Size = new System.Drawing.Size(283, 34);
            this.textBoxNameObject.TabIndex = 10;
            // 
            // labelNameObject
            // 
            this.labelNameObject.AutoSize = true;
            this.labelNameObject.BackColor = System.Drawing.Color.Transparent;
            this.labelNameObject.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameObject.Location = new System.Drawing.Point(62, 71);
            this.labelNameObject.Name = "labelNameObject";
            this.labelNameObject.Size = new System.Drawing.Size(230, 26);
            this.labelNameObject.TabIndex = 12;
            this.labelNameObject.Text = "Наименование объекта";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.Color.Transparent;
            this.labelAdres.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdres.Location = new System.Drawing.Point(143, 117);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(149, 26);
            this.labelAdres.TabIndex = 13;
            this.labelAdres.Text = "Адрес объекта";
            this.labelAdres.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonInsertObject
            // 
            this.buttonInsertObject.Location = new System.Drawing.Point(299, 295);
            this.buttonInsertObject.Name = "buttonInsertObject";
            this.buttonInsertObject.Size = new System.Drawing.Size(283, 48);
            this.buttonInsertObject.TabIndex = 14;
            this.buttonInsertObject.Text = "Добавить объект";
            this.buttonInsertObject.UseVisualStyleBackColor = true;
            this.buttonInsertObject.Click += new System.EventHandler(this.buttonInsertObject_Click);
            // 
            // labelInfoInsertObject
            // 
            this.labelInfoInsertObject.AutoSize = true;
            this.labelInfoInsertObject.Location = new System.Drawing.Point(30, 410);
            this.labelInfoInsertObject.Name = "labelInfoInsertObject";
            this.labelInfoInsertObject.Size = new System.Drawing.Size(51, 20);
            this.labelInfoInsertObject.TabIndex = 15;
            this.labelInfoInsertObject.Text = "label1";
            this.labelInfoInsertObject.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormInsertObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.labelInfoInsertObject);
            this.Controls.Add(this.buttonInsertObject);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxNameObject);
            this.Controls.Add(this.labelNameObject);
            this.Controls.Add(this.labelAdres);
            this.Name = "FormInsertObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавлении объектов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxNameObject;
        private System.Windows.Forms.Label labelNameObject;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Button buttonInsertObject;
        private System.Windows.Forms.Label labelInfoInsertObject;
    }
}