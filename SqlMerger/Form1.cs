using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlMerger
{
    public partial class FormSqlMerger : Form
    {
        public FormSqlMerger()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            var folders = new FolderBrowserDialog()
            {
                SelectedPath = txtSourceDirectory.Text,
                ShowNewFolderButton = false
            };
            var result = folders.ShowDialog();

            if (result == DialogResult.OK)
                txtSourceDirectory.Text = folders.SelectedPath;
        }

        private void txtSourceDirectory_TextChanged(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(txtSourceDirectory.Text);
            txtSourceDirectory.BackColor = directory.Exists ? SystemColors.Window : Color.LightPink;
            if (!directory.Exists)
                return;

            // display the sql files in the folder
            var writer = new StringWriter();
            foreach (var file in directory.GetFiles("*.sql").OrderBy(f => f.Name))
            {
                writer.WriteLine("- {0}", file.Name);
            }
            txtFiles.AppendText(writer.ToString());
        }

        private void btnBrowseTargetFile_Click(object sender, EventArgs e)
        {
            var dir = txtSourceDirectory.Text;
            if (!string.IsNullOrWhiteSpace(txtTargetFile.Text))
            {
                var file = new FileInfo(txtTargetFile.Text);
                dir = file.DirectoryName;
            }


            var fileDialog = new SaveFileDialog()
            {
                AddExtension = true,
                CheckFileExists = false,
                CheckPathExists = true,
                InitialDirectory = dir,
                Filter = @"SQL|*.sql",
                OverwritePrompt = true,
                Title = @"Select Target File"
            };
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
                txtTargetFile.Text = fileDialog.FileName;
        }
    }
}
