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
            this.textureDataGrid = new System.Windows.Forms.DataGridView();
            this.TextureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.save3diButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textureDataGrid)).BeginInit();
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
            // textureDataGrid
            // 
            this.textureDataGrid.AllowUserToAddRows = false;
            this.textureDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.textureDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textureDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextureName,
            this.Width,
            this.Height});
            this.textureDataGrid.Location = new System.Drawing.Point(11, 145);
            this.textureDataGrid.Name = "textureDataGrid";
            this.textureDataGrid.RowHeadersVisible = false;
            this.textureDataGrid.Size = new System.Drawing.Size(329, 159);
            this.textureDataGrid.TabIndex = 1;
            // 
            // TextureName
            // 
            this.TextureName.HeaderText = "Name";
            this.TextureName.Name = "TextureName";
            this.TextureName.Width = 108;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            this.Width.Width = 109;
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Textures";
            // 
            // save3diButton
            // 
            this.save3diButton.AutoSize = true;
            this.save3diButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save3diButton.Enabled = false;
            this.save3diButton.Location = new System.Drawing.Point(110, 15);
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
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Name";
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(15, 81);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(165, 25);
            this.modelNameTextBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(370, 335);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save3diButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textureDataGrid);
            this.Controls.Add(this.loadMqoButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Nova 3di Lab";
            ((System.ComponentModel.ISupportInitialize)(this.textureDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadMqoButton;
        private System.Windows.Forms.DataGridView textureDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save3diButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
    }
}

