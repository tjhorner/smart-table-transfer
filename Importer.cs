using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ionic.Zip;

namespace SMART_Table_Activty_Exporter
{
    public partial class Importer : Form
    {
        public Importer()
        {
            InitializeComponent();
        }

        private string contentFilePath;
        private string activityDir;

        private void pickFileButton_Click(object sender, EventArgs e)
        {
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                if (fileOpener.SafeFileName.EndsWith(".tableContent"))
                {
                    contentFilePath = fileOpener.FileName;
                    pickFileButton.Text = fileOpener.SafeFileName;
                    pickFileButton.Enabled = false;
                    pickFolderButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Must be a .tableContent file!");
                }
            }
        }

        private void pickFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowser.Description = "Pick the folder that was exported, i.e. \"HotSpots\" or \"AdditionPlus\".";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                activityDir = folderBrowser.SelectedPath;
                importButton.Enabled = true;
                pickFolderButton.Enabled = false;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            ZipFile zip = ZipFile.Read(contentFilePath);
            // make sure the earlier activity is removed
            string activityId = TableTools.GetActivityName(activityDir);
            // make sure the earlier activity is removed
            // TODO handle no directory
            try
            {
                for (int x = zip.Count - 1; x >= 0; x--)
                {
                    ZipEntry entry = zip[x];
                    if (entry.FileName.Substring(0, 9) == activityId + "/")
                        zip.RemoveEntry(entry.FileName);
                }
            }
            catch (Exception exception)
            {

            }
            // import
            using (ZipFile zipDest = zip)
            {
                zipDest.AddFiles((System.IO.Directory.EnumerateFiles(activityDir)), false, activityId);
                zipDest.Save();
                MessageBox.Show("Imported successfully!");
                this.Close();
            }
        }
    }
}
