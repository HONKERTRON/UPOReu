namespace UPOReu
{
    partial class FormMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreateAccs = new System.Windows.Forms.Button();
            this.buttonObjects = new System.Windows.Forms.Button();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCreateAccs
            // 
            this.buttonCreateAccs.Location = new System.Drawing.Point(12, 139);
            this.buttonCreateAccs.Name = "buttonCreateAccs";
            this.buttonCreateAccs.Size = new System.Drawing.Size(260, 23);
            this.buttonCreateAccs.TabIndex = 1;
            this.buttonCreateAccs.Text = "Создать учетные записи";
            this.buttonCreateAccs.UseVisualStyleBackColor = true;
            this.buttonCreateAccs.Click += new System.EventHandler(this.buttonCreateAccs_Click);
            // 
            // buttonObjects
            // 
            this.buttonObjects.Location = new System.Drawing.Point(12, 168);
            this.buttonObjects.Name = "buttonObjects";
            this.buttonObjects.Size = new System.Drawing.Size(260, 23);
            this.buttonObjects.TabIndex = 2;
            this.buttonObjects.Text = "Объекты";
            this.buttonObjects.UseVisualStyleBackColor = true;
            this.buttonObjects.Click += new System.EventHandler(this.buttonObjects_Click);
            // 
            // buttonJournal
            // 
            this.buttonJournal.Location = new System.Drawing.Point(12, 197);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(260, 23);
            this.buttonJournal.TabIndex = 3;
            this.buttonJournal.Text = "Журнал";
            this.buttonJournal.UseVisualStyleBackColor = true;
            this.buttonJournal.Click += new System.EventHandler(this.buttonJournal_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonJournal);
            this.Controls.Add(this.buttonObjects);
            this.Controls.Add(this.buttonCreateAccs);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreateAccs;
        private System.Windows.Forms.Button buttonObjects;
        private System.Windows.Forms.Button buttonJournal;
        private System.Windows.Forms.Button button5;
    }
}