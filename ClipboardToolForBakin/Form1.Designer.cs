namespace ClipboardToolForBakin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addNewRowToolStripMenuItem = new ToolStripMenuItem();
            copyToClipboardToolStripMenuItem = new ToolStripMenuItem();
            pasteFromClipboardToolStripMenuItem = new ToolStripMenuItem();
            deleteSelectedRowsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            CopyToClipboardButton = new Button();
            toggleColumnsCheckBox = new CheckBox();
            PasteFromClipboardButton = new Button();
            deleteButton = new Button();
            addRowButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowDrop = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ContextMenuStrip = contextMenuStrip1;
            dataGridView.Location = new Point(12, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(620, 411);
            dataGridView.TabIndex = 0;
            dataGridView.CellEndEdit += DataGridView_CellEndEdit;
            dataGridView.CellValidating += DataGridView_CellValidating;
            dataGridView.DragDrop += dataGridView_DragDrop;
            dataGridView.DragOver += dataGridView_DragOver;
            dataGridView.MouseDown += dataGridView_MouseDown;
            dataGridView.MouseMove += dataGridView_MouseMove;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addNewRowToolStripMenuItem, copyToClipboardToolStripMenuItem, pasteFromClipboardToolStripMenuItem, deleteSelectedRowsToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 92);
            contextMenuStrip1.Opening += contextMenuStrip_Opening;
            // 
            // addNewRowToolStripMenuItem
            // 
            addNewRowToolStripMenuItem.Name = "addNewRowToolStripMenuItem";
            addNewRowToolStripMenuItem.Size = new Size(184, 22);
            addNewRowToolStripMenuItem.Text = "Add new Row";
            addNewRowToolStripMenuItem.Click += addNewRowToolStripMenuItem_Click;
            // 
            // copyToClipboardToolStripMenuItem
            // 
            copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            copyToClipboardToolStripMenuItem.Size = new Size(184, 22);
            copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            copyToClipboardToolStripMenuItem.Click += copyToClipboardToolStripMenuItem_Click;
            // 
            // pasteFromClipboardToolStripMenuItem
            // 
            pasteFromClipboardToolStripMenuItem.Name = "pasteFromClipboardToolStripMenuItem";
            pasteFromClipboardToolStripMenuItem.Size = new Size(184, 22);
            pasteFromClipboardToolStripMenuItem.Text = "Paste from Clipboard";
            pasteFromClipboardToolStripMenuItem.Click += copyFromClipboardToolStripMenuItem_Click;
            // 
            // deleteSelectedRowsToolStripMenuItem
            // 
            deleteSelectedRowsToolStripMenuItem.Name = "deleteSelectedRowsToolStripMenuItem";
            deleteSelectedRowsToolStripMenuItem.Size = new Size(184, 22);
            deleteSelectedRowsToolStripMenuItem.Text = "Delete selected Rows";
            deleteSelectedRowsToolStripMenuItem.Click += deleteSelectedRowsToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, clearToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(45, 20);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += btnClearDataGridView_Click;
            // 
            // CopyToClipboardButton
            // 
            CopyToClipboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CopyToClipboardButton.Location = new Point(638, 332);
            CopyToClipboardButton.Name = "CopyToClipboardButton";
            CopyToClipboardButton.Size = new Size(150, 50);
            CopyToClipboardButton.TabIndex = 2;
            CopyToClipboardButton.Text = "Copy to Clipboard";
            CopyToClipboardButton.UseVisualStyleBackColor = true;
            CopyToClipboardButton.Click += CopyToClipboardButton_Click;
            // 
            // toggleColumnsCheckBox
            // 
            toggleColumnsCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggleColumnsCheckBox.Appearance = Appearance.Button;
            toggleColumnsCheckBox.Location = new Point(638, 27);
            toggleColumnsCheckBox.Name = "toggleColumnsCheckBox";
            toggleColumnsCheckBox.Size = new Size(150, 50);
            toggleColumnsCheckBox.TabIndex = 3;
            toggleColumnsCheckBox.Text = "View Change";
            toggleColumnsCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            toggleColumnsCheckBox.UseVisualStyleBackColor = true;
            toggleColumnsCheckBox.CheckedChanged += toggleColumnsCheckBox_CheckedChanged;
            // 
            // PasteFromClipboardButton
            // 
            PasteFromClipboardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PasteFromClipboardButton.Location = new Point(638, 388);
            PasteFromClipboardButton.Name = "PasteFromClipboardButton";
            PasteFromClipboardButton.Size = new Size(150, 50);
            PasteFromClipboardButton.TabIndex = 4;
            PasteFromClipboardButton.Text = "Paste from Clipboard";
            PasteFromClipboardButton.UseVisualStyleBackColor = true;
            PasteFromClipboardButton.Click += PasteFromClipboardButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Location = new Point(638, 139);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 50);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete selected Rows";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // addRowButton
            // 
            addRowButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addRowButton.Location = new Point(638, 83);
            addRowButton.Name = "addRowButton";
            addRowButton.Size = new Size(150, 50);
            addRowButton.TabIndex = 6;
            addRowButton.Text = "Add new Row";
            addRowButton.UseVisualStyleBackColor = true;
            addRowButton.Click += AddRowButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addRowButton);
            Controls.Add(deleteButton);
            Controls.Add(PasteFromClipboardButton);
            Controls.Add(toggleColumnsCheckBox);
            Controls.Add(CopyToClipboardButton);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Clipboard Tool for Bakin v1.0.1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button CopyToClipboardButton;
        private CheckBox toggleColumnsCheckBox;
        private Button PasteFromClipboardButton;
        private Button deleteButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pasteFromClipboardToolStripMenuItem;
        private ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedRowsToolStripMenuItem;
        private Button addRowButton;
        private ToolStripMenuItem addNewRowToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}