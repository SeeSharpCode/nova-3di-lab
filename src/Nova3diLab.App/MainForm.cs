﻿using Nova3diLab.Df2;
using Nova3diLab.Mqo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Nova3diLab.App
{
    public partial class MainForm : Form
    {
        private MqoModel mqoModel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadMqoButton_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog { Filter = "Metasequoia Files|*.mqo", Title = "Select .mqo file" })
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                mqoModel = MqoModel.Load(fileDialog.FileName);
                modelNameTextBox.Text = Path.GetFileNameWithoutExtension(fileDialog.SafeFileName);
                mqoModel.TextureNames.ForEach(texture =>
                    textureDataGrid.Rows.Add(new object[] { texture, 512, 512, false }));

                save3diButton.Enabled = true;
            }
        }

        private void save3diButton_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new SaveFileDialog { Title = "Save .3di file", Filter = "DF2 3di Files|*.3di" })
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var textures = new List<Texture>();
                for (short i = 0; i < textureDataGrid.Rows.Count; i++)
                {
                    var row = textureDataGrid.Rows[i];
                    var name = row.Cells[0].Value.ToString();
                    var width = Convert.ToInt16(row.Cells[1].Value);
                    var height = Convert.ToInt16(row.Cells[2].Value);

                    textures.Add(new Texture(name, i, width, height));
                }

                var df2Model = MqoTo3diConverter.Convert(modelNameTextBox.Text, mqoModel, textures);
                df2Model.SaveToFile(fileDialog.FileName);

                MessageBox.Show("3di saved sucessfully!", "Success");
            }
        }
    }
}
