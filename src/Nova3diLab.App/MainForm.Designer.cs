namespace Nova3diLab.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loadMqoButton = new System.Windows.Forms.Button();
            this.save3diButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.addCollisionButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.placeholderLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vertexCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.faceCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.collisionPlaneCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.collisionVolumeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textureDataGrid = new System.Windows.Forms.DataGridView();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TextureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texturePanel = new System.Windows.Forms.Panel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.placeholderContentLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureDataGrid)).BeginInit();
            this.texturePanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadMqoButton
            // 
            this.loadMqoButton.AutoSize = true;
            this.loadMqoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadMqoButton.Location = new System.Drawing.Point(12, 15);
            this.loadMqoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadMqoButton.Name = "loadMqoButton";
            this.loadMqoButton.Size = new System.Drawing.Size(91, 27);
            this.loadMqoButton.TabIndex = 0;
            this.loadMqoButton.Text = "Import .mqo";
            this.loadMqoButton.UseVisualStyleBackColor = true;
            this.loadMqoButton.Click += new System.EventHandler(this.loadMqoButton_Click);
            // 
            // save3diButton
            // 
            this.save3diButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save3diButton.AutoSize = true;
            this.save3diButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save3diButton.Enabled = false;
            this.save3diButton.Location = new System.Drawing.Point(196, 273);
            this.save3diButton.Name = "save3diButton";
            this.save3diButton.Size = new System.Drawing.Size(70, 27);
            this.save3diButton.TabIndex = 3;
            this.save3diButton.Text = "Save .3di";
            this.save3diButton.UseVisualStyleBackColor = true;
            this.save3diButton.Click += new System.EventHandler(this.save3diButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Name";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(3, 20);
            this.modelNameTextBox.MaxLength = 8;
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(108, 25);
            this.modelNameTextBox.TabIndex = 5;
            // 
            // addCollisionButton
            // 
            this.addCollisionButton.AutoSize = true;
            this.addCollisionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCollisionButton.Enabled = false;
            this.addCollisionButton.Location = new System.Drawing.Point(111, 14);
            this.addCollisionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCollisionButton.Name = "addCollisionButton";
            this.addCollisionButton.Size = new System.Drawing.Size(95, 27);
            this.addCollisionButton.TabIndex = 6;
            this.addCollisionButton.Text = "Add Collision";
            this.addCollisionButton.UseVisualStyleBackColor = true;
            this.addCollisionButton.Click += new System.EventHandler(this.addCollisionButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderLabel,
            this.vertexCountLabel,
            this.faceCountLabel,
            this.collisionPlaneCountLabel,
            this.collisionVolumeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(282, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(105, 17);
            this.placeholderLabel.Text = "Waiting for import";
            // 
            // vertexCountLabel
            // 
            this.vertexCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.vertexCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.vertexCountLabel.Name = "vertexCountLabel";
            this.vertexCountLabel.Size = new System.Drawing.Size(63, 19);
            this.vertexCountLabel.Text = "Vertices: 0";
            this.vertexCountLabel.Visible = false;
            // 
            // faceCountLabel
            // 
            this.faceCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.faceCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.faceCountLabel.Name = "faceCountLabel";
            this.faceCountLabel.Size = new System.Drawing.Size(52, 19);
            this.faceCountLabel.Text = "Faces: 0";
            this.faceCountLabel.Visible = false;
            // 
            // collisionPlaneCountLabel
            // 
            this.collisionPlaneCountLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.collisionPlaneCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.collisionPlaneCountLabel.Name = "collisionPlaneCountLabel";
            this.collisionPlaneCountLabel.Size = new System.Drawing.Size(106, 19);
            this.collisionPlaneCountLabel.Text = "Collision Planes: 0";
            this.collisionPlaneCountLabel.Visible = false;
            // 
            // collisionVolumeLabel
            // 
            this.collisionVolumeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.collisionVolumeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.collisionVolumeLabel.Name = "collisionVolumeLabel";
            this.collisionVolumeLabel.Size = new System.Drawing.Size(117, 19);
            this.collisionVolumeLabel.Text = "Collision Volumes: 0";
            this.collisionVolumeLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Textures";
            // 
            // textureDataGrid
            // 
            this.textureDataGrid.AllowUserToAddRows = false;
            this.textureDataGrid.AllowUserToDeleteRows = false;
            this.textureDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.textureDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.textureDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.textureDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textureDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextureName,
            this.Material,
            this.Width,
            this.Height});
            this.textureDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textureDataGrid.Location = new System.Drawing.Point(0, 17);
            this.textureDataGrid.Name = "textureDataGrid";
            this.textureDataGrid.RowHeadersVisible = false;
            this.textureDataGrid.Size = new System.Drawing.Size(251, 120);
            this.textureDataGrid.TabIndex = 1;
            // 
            // Height
            // 
            this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Height.Width = 52;
            // 
            // Width
            // 
            this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Width.Width = 48;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Material.HeaderText = "Material";
            this.Material.Items.AddRange(new object[] {
            "Cloth",
            "Glass",
            "ThickMetal",
            "ThinMetal",
            "Sand",
            "Stone",
            "Straw",
            "Vapor",
            "Wood"});
            this.Material.Name = "Material";
            this.Material.Width = 62;
            // 
            // TextureName
            // 
            this.TextureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TextureName.HeaderText = "Name";
            this.TextureName.Name = "TextureName";
            this.TextureName.ReadOnly = true;
            this.TextureName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TextureName.Width = 49;
            // 
            // texturePanel
            // 
            this.texturePanel.AutoSize = true;
            this.texturePanel.Controls.Add(this.textureDataGrid);
            this.texturePanel.Controls.Add(this.label1);
            this.texturePanel.Location = new System.Drawing.Point(15, 130);
            this.texturePanel.Name = "texturePanel";
            this.texturePanel.Size = new System.Drawing.Size(251, 137);
            this.texturePanel.TabIndex = 8;
            this.texturePanel.Visible = false;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.label2);
            this.namePanel.Controls.Add(this.modelNameTextBox);
            this.namePanel.Location = new System.Drawing.Point(12, 59);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(131, 53);
            this.namePanel.TabIndex = 9;
            this.namePanel.Visible = false;
            // 
            // placeholderContentLabel
            // 
            this.placeholderContentLabel.AutoSize = true;
            this.placeholderContentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderContentLabel.Location = new System.Drawing.Point(72, 162);
            this.placeholderContentLabel.Name = "placeholderContentLabel";
            this.placeholderContentLabel.Size = new System.Drawing.Size(138, 21);
            this.placeholderContentLabel.TabIndex = 10;
            this.placeholderContentLabel.Text = "No model loaded";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 344);
            this.Controls.Add(this.placeholderContentLabel);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.texturePanel);
            this.Controls.Add(this.save3diButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.addCollisionButton);
            this.Controls.Add(this.loadMqoButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Nova 3di Lab";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureDataGrid)).EndInit();
            this.texturePanel.ResumeLayout(false);
            this.texturePanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadMqoButton;
        private System.Windows.Forms.Button save3diButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.Button addCollisionButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel placeholderLabel;
        private System.Windows.Forms.ToolStripStatusLabel vertexCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel faceCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel collisionPlaneCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel collisionVolumeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView textureDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextureName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Panel texturePanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label placeholderContentLabel;
    }
}

