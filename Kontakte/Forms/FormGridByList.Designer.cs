namespace KontakteApp
{
    partial class FormGridByList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.personenDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Kontakt_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kunde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Anruf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit,
            this.toolStripMenuItemFill,
            this.toolStripMenuItemUpdate,
            this.toolStripMenuItemDelete,
            this.toolStripMenuItemTest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItemExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemExit.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemFill
            // 
            this.toolStripMenuItemFill.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItemFill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemFill.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripMenuItemFill.Name = "toolStripMenuItemFill";
            this.toolStripMenuItemFill.Size = new System.Drawing.Size(34, 20);
            this.toolStripMenuItemFill.Text = "Fill";
            this.toolStripMenuItemFill.Click += new System.EventHandler(this.toolStripMenuItemFill_Click);
            // 
            // toolStripMenuItemUpdate
            // 
            this.toolStripMenuItemUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItemUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemUpdate.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripMenuItemUpdate.Name = "toolStripMenuItemUpdate";
            this.toolStripMenuItemUpdate.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItemUpdate.Text = "Update";
            this.toolStripMenuItemUpdate.Click += new System.EventHandler(this.toolStripMenuItemUpdate_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItemDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemDelete.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemDelete.Text = "Delete";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
            // 
            // toolStripMenuItemTest
            // 
            this.toolStripMenuItemTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItemTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemTest.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStripMenuItemTest.Name = "toolStripMenuItemTest";
            this.toolStripMenuItemTest.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItemTest.Text = "Test";
            this.toolStripMenuItemTest.Click += new System.EventHandler(this.toolStripMenuItemTest_Click);
            // 
            // personenDataGridView
            // 
            this.personenDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kontakt_Id,
            this.Vorname,
            this.Nachname,
            this.Firma,
            this.Telefon,
            this.Email,
            this.Kunde,
            this.Anruf});
            this.personenDataGridView.Location = new System.Drawing.Point(12, 55);
            this.personenDataGridView.Name = "personenDataGridView";
            this.personenDataGridView.Size = new System.Drawing.Size(556, 194);
            this.personenDataGridView.TabIndex = 2;
            this.personenDataGridView.VirtualMode = true;
            this.personenDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.personenDataGridView_CellBeginEdit);
            this.personenDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.personenDataGridView_CellEndEdit);
            this.personenDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.personenDataGridView_CellLeave);
            this.personenDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.personenDataGridView_CellValueNeeded);
            this.personenDataGridView.NewRowNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.personenDataGridView_NewRowNeeded);
            this.personenDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.personenDataGridView_RowHeaderMouseClick);
            this.personenDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.personenDataGridView_RowLeave);
            this.personenDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.personenDataGridView_RowsAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contacts:";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNext.Location = new System.Drawing.Point(78, 264);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(28, 20);
            this.buttonNext.TabIndex = 24;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrevious.Location = new System.Drawing.Point(14, 264);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(28, 20);
            this.buttonPrevious.TabIndex = 23;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(582, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // Kontakt_Id
            // 
            this.Kontakt_Id.HeaderText = "Kontakt_Id";
            this.Kontakt_Id.Name = "Kontakt_Id";
            this.Kontakt_Id.ReadOnly = true;
            // 
            // Vorname
            // 
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            // 
            // Nachname
            // 
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Kunde
            // 
            this.Kunde.HeaderText = "Kunde";
            this.Kunde.Name = "Kunde";
            // 
            // Anruf
            // 
            this.Anruf.HeaderText = "Anruf";
            this.Anruf.Name = "Anruf";
            this.Anruf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anruf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormGridByList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 316);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personenDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGridByList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGridByList";
            this.Load += new System.EventHandler(this.FormGridByList_Load);
            this.Resize += new System.EventHandler(this.FormGridByList_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.DataGridView personenDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFill;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Kunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anruf;
    }
}