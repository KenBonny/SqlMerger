using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlMerger.Properties;

namespace SqlMerger
{
    public partial class FormSqlMerger : Form
    {
        public FormSqlMerger()
        {
            InitializeComponent();
            chkAddGo.Checked = Settings.Default.AddGo;
            chkRemoveUse.Checked = Settings.Default.RemoveUse;
            txtSourceDirectory.Text = Settings.Default.Source;
        }

        private void FormSqlMerger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.AddGo = chkAddGo.Checked;
            Settings.Default.RemoveUse = chkRemoveUse.Checked;
            Settings.Default.Source = txtSourceDirectory.Text;
            Settings.Default.Save();
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
            // reset controls
            btnMerge.Enabled = false;
            txtFiles.Text = string.Empty;
            txtFiles.Update();

            // check directory
            var directory = new DirectoryInfo(txtSourceDirectory.Text);
            txtSourceDirectory.BackColor = directory.Exists ? SystemColors.Window : Color.LightPink;
            if (!directory.Exists)
                return;

            // list the sql files in the folder
            var writer = new StringBuilder();
            foreach (var file in directory.GetFiles("*.sql").OrderBy(f => f.Name))
            {
                btnMerge.Enabled = true;
                writer.AppendFormat("- {0}{1}", file.Name, Environment.NewLine);
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
                OverwritePrompt = false,
                Title = @"Select Target File"
            };
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
                txtTargetFile.Text = fileDialog.FileName;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTargetFile.Text))
                return;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var source = new DirectoryInfo(txtSourceDirectory.Text);
                var target = new FileInfo(txtTargetFile.Text);

                var merger = new SqlMerger(chkRemoveUse.Checked, chkAddGo.Checked);
                var merged = merger.Merge(source, target.Name);

                using (var writer = new StreamWriter(target.FullName, chkAppend.Checked))
                {
                    writer.Write(merged);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
