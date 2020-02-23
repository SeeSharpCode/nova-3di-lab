using Nova3diLab.Df2;
using Nova3diLab.Mqo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nova3diLab.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadMqoButton_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog { Filter = "Metasequoia Files|*.mqo", Title = "Select .mqo file" })
            {
                var result = fileDialog.ShowDialog();       
                if (result == DialogResult.OK)
                {
                    var mqoModel = MqoModel.Load(fileDialog.FileName);
                    MqoTo3diConverter.Convert(fileDialog.SafeFileName,mqoModel, null);
                }
            }
        }
    }
}
