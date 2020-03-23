using Nova3diLab.Df2;
using Nova3diLab.Mqo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Nova3diLab.App
{
    public partial class MainForm : Form
    {
        private MqoModel mqoModel;
        private MqoModel collision;

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

                var modelName = Path.GetFileNameWithoutExtension(fileDialog.SafeFileName);
                modelNameTextBox.Text = modelName.Length > 8 ? modelName.Substring(0, 8) : modelName;

                mqoModel.TextureNames.ForEach(texture =>
                    textureDataGrid.Rows.Add(new object[] { texture, "Stone", 512, 512, false }));

                namePanel.Visible = true;
                placeholderContentLabel.Visible = false;
                texturePanel.Visible = true;
                addCollisionButton.Enabled = true;
                save3diButton.Enabled = true;
                placeholderLabel.Visible = false;
                vertexCountLabel.Visible = true;
                faceCountLabel.Visible = true;

                var mqoObject = mqoModel.Objects[0];
                vertexCountLabel.Text = $"Vertices: {mqoObject.Vertices.Count}";
                faceCountLabel.Text = $"Faces: {mqoObject.Faces.Count}";
            }
        }

        private void addCollisionButton_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog { Filter = "Metasequoia Files|*.mqo", Title = "Select collision .mqo file" })
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                collision = MqoModel.Load(fileDialog.FileName);

                collisionPlaneCountLabel.Visible = true;
                collisionVolumeLabel.Visible = true;

                collisionPlaneCountLabel.Text = $"CPs: {collision.Objects.SelectMany(obj => obj.Faces).Count()}";
                collisionVolumeLabel.Text = $"CVs: {collision.Objects.Count}";
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

                var df2Model = MqoTo3diConverter.Convert(modelNameTextBox.Text, mqoModel, textures, collision);
                df2Model.SaveToFile(fileDialog.FileName);

                MessageBox.Show("3di saved sucessfully!", "Success");
            }
        }
    }
}
