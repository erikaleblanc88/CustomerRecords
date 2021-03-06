﻿namespace CustomerRecordsApp
{
    partial class formCustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomerView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomerData = new System.Windows.Forms.DataGridView();
            this.lblCustomerRecords = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.lblDoubleClick = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btViewAlerts = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.cbPYSelector = new System.Windows.Forms.ComboBox();
            this.lblPYSelector = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvCustomerData);
            this.panel1.Location = new System.Drawing.Point(12, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 298);
            this.panel1.TabIndex = 0;
            // 
            // dgvCustomerData
            // 
            this.dgvCustomerData.AllowUserToAddRows = false;
            this.dgvCustomerData.AllowUserToDeleteRows = false;
            this.dgvCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerData.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerData.MultiSelect = false;
            this.dgvCustomerData.Name = "dgvCustomerData";
            this.dgvCustomerData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerData.Size = new System.Drawing.Size(883, 294);
            this.dgvCustomerData.TabIndex = 0;
            this.dgvCustomerData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerData_CellDoubleClick);
            this.dgvCustomerData.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerData_CellLeave);
            this.dgvCustomerData.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomerData_ColumnHeaderMouseClick);
            this.dgvCustomerData.SelectionChanged += new System.EventHandler(this.DgvCustomerData_SelectionChanged);
            // 
            // lblCustomerRecords
            // 
            this.lblCustomerRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerRecords.AutoSize = true;
            this.lblCustomerRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRecords.Location = new System.Drawing.Point(359, 4);
            this.lblCustomerRecords.Name = "lblCustomerRecords";
            this.lblCustomerRecords.Size = new System.Drawing.Size(183, 24);
            this.lblCustomerRecords.TabIndex = 1;
            this.lblCustomerRecords.Text = "Customer Records";
            this.lblCustomerRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Location = new System.Drawing.Point(134, 8);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(111, 23);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Location = new System.Drawing.Point(648, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 34);
            this.panel2.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(11, 8);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.Location = new System.Drawing.Point(12, 440);
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(140, 13);
            this.lblDoubleClick.TabIndex = 4;
            this.lblDoubleClick.Text = "Double Click to View Details";
            // 
            // btRefresh
            // 
            this.btRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRefresh.Location = new System.Drawing.Point(13, 46);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 25);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // btViewAlerts
            // 
            this.btViewAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btViewAlerts.Location = new System.Drawing.Point(719, 46);
            this.btViewAlerts.Name = "btViewAlerts";
            this.btViewAlerts.Size = new System.Drawing.Size(150, 26);
            this.btViewAlerts.TabIndex = 6;
            this.btViewAlerts.Text = "View/Add Alerts";
            this.btViewAlerts.UseVisualStyleBackColor = true;
            this.btViewAlerts.Click += new System.EventHandler(this.BtViewAlerts_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(495, 53);
            this.tbSearch.MinimumSize = new System.Drawing.Size(180, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(180, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(442, 55);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search: ";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleBar.Controls.Add(this.cbPYSelector);
            this.panelTitleBar.Controls.Add(this.lblPYSelector);
            this.panelTitleBar.Controls.Add(this.lblSearch);
            this.panelTitleBar.Controls.Add(this.btViewAlerts);
            this.panelTitleBar.Controls.Add(this.tbSearch);
            this.panelTitleBar.Controls.Add(this.btRefresh);
            this.panelTitleBar.Controls.Add(this.lblCustomerRecords);
            this.panelTitleBar.Location = new System.Drawing.Point(12, 27);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(887, 84);
            this.panelTitleBar.TabIndex = 9;
            // 
            // cbPYSelector
            // 
            this.cbPYSelector.FormattingEnabled = true;
            this.cbPYSelector.Location = new System.Drawing.Point(242, 52);
            this.cbPYSelector.Name = "cbPYSelector";
            this.cbPYSelector.Size = new System.Drawing.Size(121, 21);
            this.cbPYSelector.TabIndex = 10;
            this.cbPYSelector.Visible = false;
            this.cbPYSelector.SelectedIndexChanged += new System.EventHandler(this.cbPYSelector_SelectedIndexChanged);
            // 
            // lblPYSelector
            // 
            this.lblPYSelector.AutoSize = true;
            this.lblPYSelector.Location = new System.Drawing.Point(144, 56);
            this.lblPYSelector.Name = "lblPYSelector";
            this.lblPYSelector.Size = new System.Drawing.Size(83, 13);
            this.lblPYSelector.TabIndex = 9;
            this.lblPYSelector.Text = "Show for PY ID:";
            this.lblPYSelector.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // formCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 474);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lblDoubleClick);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formCustomerView";
            this.Text = "Customer Management System";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomerData;
        private System.Windows.Forms.Label lblCustomerRecords;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblDoubleClick;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btViewAlerts;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbPYSelector;
        private System.Windows.Forms.Label lblPYSelector;
    }
}

