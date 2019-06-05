namespace UPOReu
{
    partial class FormObjects
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewState = new System.Windows.Forms.DataGridView();
            this.dataGridViewObjects = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.огнетушителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ответственныеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewState
            // 
            this.dataGridViewState.AllowUserToAddRows = false;
            this.dataGridViewState.AllowUserToDeleteRows = false;
            this.dataGridViewState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewState.Location = new System.Drawing.Point(335, 12);
            this.dataGridViewState.Name = "dataGridViewState";
            this.dataGridViewState.Size = new System.Drawing.Size(345, 290);
            this.dataGridViewState.TabIndex = 1;
            // 
            // dataGridViewObjects
            // 
            this.dataGridViewObjects.AllowUserToAddRows = false;
            this.dataGridViewObjects.AllowUserToDeleteRows = false;
            this.dataGridViewObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjects.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewObjects.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewObjects.Name = "dataGridViewObjects";
            this.dataGridViewObjects.Size = new System.Drawing.Size(317, 291);
            this.dataGridViewObjects.TabIndex = 0;
            this.dataGridViewObjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewObjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjects_CellDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.огнетушителиToolStripMenuItem,
            this.ответственныеЛицаToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(188, 48);
            // 
            // огнетушителиToolStripMenuItem
            // 
            this.огнетушителиToolStripMenuItem.Name = "огнетушителиToolStripMenuItem";
            this.огнетушителиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.огнетушителиToolStripMenuItem.Text = "Огнетушители";
            this.огнетушителиToolStripMenuItem.Click += new System.EventHandler(this.ExtingusherToolStripMenuItem_Click);
            // 
            // ответственныеЛицаToolStripMenuItem
            // 
            this.ответственныеЛицаToolStripMenuItem.Name = "ответственныеЛицаToolStripMenuItem";
            this.ответственныеЛицаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ответственныеЛицаToolStripMenuItem.Text = "Ответственные лица";
            this.ответственныеЛицаToolStripMenuItem.Click += new System.EventHandler(this.PersonToolStripMenuItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(611, 280);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 315);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewState);
            this.Controls.Add(this.dataGridViewObjects);
            this.Name = "FormObjects";
            this.Text = "Список объектов";
            this.Load += new System.EventHandler(this.FormObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObjects)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewState;
        private System.Windows.Forms.DataGridView dataGridViewObjects;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem огнетушителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ответственныеЛицаToolStripMenuItem;
    }
}