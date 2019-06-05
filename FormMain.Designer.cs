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
            this.buttonPeople = new System.Windows.Forms.Button();
            this.buttonCreateAccs = new System.Windows.Forms.Button();
            this.buttonObjects = new System.Windows.Forms.Button();
            this.buttonJournalRR = new System.Windows.Forms.Button();
            this.buttonJUO = new System.Windows.Forms.Button();
            this.buttonPPS = new System.Windows.Forms.Button();
            this.buttonJUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPeople
            // 
            this.buttonPeople.Location = new System.Drawing.Point(12, 12);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(260, 30);
            this.buttonPeople.TabIndex = 0;
            this.buttonPeople.Text = "Люди";
            this.buttonPeople.UseVisualStyleBackColor = true;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // buttonCreateAccs
            // 
            this.buttonCreateAccs.Location = new System.Drawing.Point(12, 48);
            this.buttonCreateAccs.Name = "buttonCreateAccs";
            this.buttonCreateAccs.Size = new System.Drawing.Size(260, 23);
            this.buttonCreateAccs.TabIndex = 1;
            this.buttonCreateAccs.Text = "Создать учетные записи";
            this.buttonCreateAccs.UseVisualStyleBackColor = true;
            this.buttonCreateAccs.Click += new System.EventHandler(this.buttonCreateAccs_Click);
            // 
            // buttonObjects
            // 
            this.buttonObjects.Location = new System.Drawing.Point(12, 77);
            this.buttonObjects.Name = "buttonObjects";
            this.buttonObjects.Size = new System.Drawing.Size(260, 23);
            this.buttonObjects.TabIndex = 2;
            this.buttonObjects.Text = "Объекты";
            this.buttonObjects.UseVisualStyleBackColor = true;
            this.buttonObjects.Click += new System.EventHandler(this.buttonObjects_Click);
            // 
            // buttonJournalRR
            // 
            this.buttonJournalRR.Location = new System.Drawing.Point(12, 106);
            this.buttonJournalRR.Name = "buttonJournalRR";
            this.buttonJournalRR.Size = new System.Drawing.Size(260, 23);
            this.buttonJournalRR.TabIndex = 3;
            this.buttonJournalRR.Text = "Журнал РРТОСЗ";
            this.buttonJournalRR.UseVisualStyleBackColor = true;
            this.buttonJournalRR.Click += new System.EventHandler(this.buttonJournal_Click);
            // 
            // buttonJUO
            // 
            this.buttonJUO.Location = new System.Drawing.Point(12, 135);
            this.buttonJUO.Name = "buttonJUO";
            this.buttonJUO.Size = new System.Drawing.Size(260, 23);
            this.buttonJUO.TabIndex = 4;
            this.buttonJUO.Text = "Журнал УО";
            this.buttonJUO.UseVisualStyleBackColor = true;
            this.buttonJUO.Click += new System.EventHandler(this.buttonJUO_Click);
            // 
            // buttonPPS
            // 
            this.buttonPPS.Location = new System.Drawing.Point(12, 164);
            this.buttonPPS.Name = "buttonPPS";
            this.buttonPPS.Size = new System.Drawing.Size(260, 23);
            this.buttonPPS.TabIndex = 5;
            this.buttonPPS.Text = "Журнал ППСППЗ";
            this.buttonPPS.UseVisualStyleBackColor = true;
            this.buttonPPS.Click += new System.EventHandler(this.buttonPPS_Click);
            // 
            // buttonJUP
            // 
            this.buttonJUP.Location = new System.Drawing.Point(12, 193);
            this.buttonJUP.Name = "buttonJUP";
            this.buttonJUP.Size = new System.Drawing.Size(260, 23);
            this.buttonJUP.TabIndex = 6;
            this.buttonJUP.Text = "Журнал УПППТ";
            this.buttonJUP.UseVisualStyleBackColor = true;
            this.buttonJUP.Click += new System.EventHandler(this.buttonJUP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonJUP);
            this.Controls.Add(this.buttonPPS);
            this.Controls.Add(this.buttonJUO);
            this.Controls.Add(this.buttonJournalRR);
            this.Controls.Add(this.buttonObjects);
            this.Controls.Add(this.buttonCreateAccs);
            this.Controls.Add(this.buttonPeople);
            this.Name = "FormMain";
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPeople;
        private System.Windows.Forms.Button buttonCreateAccs;
        private System.Windows.Forms.Button buttonObjects;
        private System.Windows.Forms.Button buttonJournalRR;
        private System.Windows.Forms.Button buttonJUO;
        private System.Windows.Forms.Button buttonPPS;
        private System.Windows.Forms.Button buttonJUP;
    }
}