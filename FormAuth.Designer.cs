namespace UPOReu
{
    partial class FormAuth
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
            this.buttonAuth = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAuth
            // 
            this.buttonAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAuth.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.Location = new System.Drawing.Point(38, 194);
            this.buttonAuth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(343, 60);
            this.buttonAuth.TabIndex = 0;
            this.buttonAuth.Text = "Войти в систему";
            this.buttonAuth.UseVisualStyleBackColor = false;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.Location = new System.Drawing.Point(38, 42);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(343, 34);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(38, 121);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(343, 34);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "\'";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonAuth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(212, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 268);
            this.panel1.TabIndex = 6;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPOReu.Properties.Resources.Фон_v11;
            this.ClientSize = new System.Drawing.Size(850, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

