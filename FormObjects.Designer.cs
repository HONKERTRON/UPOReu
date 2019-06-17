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
            this.PersonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PPSPPZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RRTOSZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UPPPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChosePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDobObject = new System.Windows.Forms.Button();
            this.addStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridViewState.Location = new System.Drawing.Point(375, 9);
            this.dataGridViewState.Name = "dataGridViewState";
            this.dataGridViewState.Size = new System.Drawing.Size(345, 290);
            this.dataGridViewState.TabIndex = 1;
            // 
            // dataGridViewObjects
            // 
            this.dataGridViewObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObjects.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewObjects.Location = new System.Drawing.Point(9, 9);
            this.dataGridViewObjects.Name = "dataGridViewObjects";
            this.dataGridViewObjects.Size = new System.Drawing.Size(345, 291);
            this.dataGridViewObjects.TabIndex = 0;
            this.dataGridViewObjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewObjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewObjects_CellDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonsToolStripMenuItem,
            this.UOToolStripMenuItem,
            this.PPSPPZToolStripMenuItem,
            this.RRTOSZToolStripMenuItem,
            this.UPPPTToolStripMenuItem,
            this.ChosePersonToolStripMenuItem,
            this.addStateToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(270, 180);
            // 
            // PersonsToolStripMenuItem
            // 
            this.PersonsToolStripMenuItem.Name = "PersonsToolStripMenuItem";
            this.PersonsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.PersonsToolStripMenuItem.Text = "Ответственные лица";
            this.PersonsToolStripMenuItem.Click += new System.EventHandler(this.PersonToolStripMenuItem_Click);
            // 
            // UOToolStripMenuItem
            // 
            this.UOToolStripMenuItem.Name = "UOToolStripMenuItem";
            this.UOToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.UOToolStripMenuItem.Text = "Журнал учета огнетушителей";
            this.UOToolStripMenuItem.Click += new System.EventHandler(this.UOToolStripMenuItem_Click);
            // 
            // PPSPPZToolStripMenuItem
            // 
            this.PPSPPZToolStripMenuItem.Name = "PPSPPZToolStripMenuItem";
            this.PPSPPZToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.PPSPPZToolStripMenuItem.Text = "ППСППЗ";
            this.PPSPPZToolStripMenuItem.Click += new System.EventHandler(this.PPSPPZToolStripMenuItem_Click);
            // 
            // RRTOSZToolStripMenuItem
            // 
            this.RRTOSZToolStripMenuItem.Name = "RRTOSZToolStripMenuItem";
            this.RRTOSZToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.RRTOSZToolStripMenuItem.Text = "РРТОСЗ";
            this.RRTOSZToolStripMenuItem.Click += new System.EventHandler(this.RRTOSZToolStripMenuItem_Click);
            // 
            // UPPPTToolStripMenuItem
            // 
            this.UPPPTToolStripMenuItem.Name = "UPPPTToolStripMenuItem";
            this.UPPPTToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.UPPPTToolStripMenuItem.Text = "УПППТ";
            this.UPPPTToolStripMenuItem.Click += new System.EventHandler(this.UPPPTToolStripMenuItem_Click);
            // 
            // ChosePersonToolStripMenuItem
            // 
            this.ChosePersonToolStripMenuItem.Name = "ChosePersonToolStripMenuItem";
            this.ChosePersonToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ChosePersonToolStripMenuItem.Text = "Добавить ответственное лицо";
            this.ChosePersonToolStripMenuItem.Click += new System.EventHandler(this.ChosePersonToolStripMenuItem_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(750, 44);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 33);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(750, 84);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 33);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDobObject
            // 
            this.buttonDobObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDobObject.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDobObject.Location = new System.Drawing.Point(750, 123);
            this.buttonDobObject.Name = "buttonDobObject";
            this.buttonDobObject.Size = new System.Drawing.Size(96, 84);
            this.buttonDobObject.TabIndex = 4;
            this.buttonDobObject.Text = "Добавить объект";
            this.buttonDobObject.UseVisualStyleBackColor = false;
            this.buttonDobObject.Click += new System.EventHandler(this.buttonDobObject_Click);
            // 
            // addStateToolStripMenuItem
            // 
            this.addStateToolStripMenuItem.Name = "addStateToolStripMenuItem";
            this.addStateToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.addStateToolStripMenuItem.Text = "Добавить новое состояние объекта";
            this.addStateToolStripMenuItem.Click += new System.EventHandler(this.addStateToolStripMenuItem_Click);
            // 
            // FormObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPOReu.Properties.Resources.Фон_v11;
            this.ClientSize = new System.Drawing.Size(874, 315);
            this.Controls.Add(this.buttonDobObject);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewState);
            this.Controls.Add(this.dataGridViewObjects);
            this.Name = "FormObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem PersonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PPSPPZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RRTOSZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UPPPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChosePersonToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDobObject;
        private System.Windows.Forms.ToolStripMenuItem addStateToolStripMenuItem;
    }
}