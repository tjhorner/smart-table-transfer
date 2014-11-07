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
    public partial class DirectTransfer : Form
    {
        public DirectTransfer()
        {
            InitializeComponent();
        }

        private string sourceContentFilePath;
        private string destinationContentFilePath;

        private void pickFileButton_Click(object sender, EventArgs e)
        {
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                if (fileOpener.SafeFileName.EndsWith(".tableContent"))
                {
                    sourceContentFilePath = fileOpener.FileName;
                    List<string> activityList = TableTools.GetActivitiesFromContentFile(sourceContentFilePath);
                    for (int i = 0; i < activityList.Count; i++)
                    {
                        activityBox.Items.Add(activityList[i]);
                    }
                    pickFileButton.Text = fileOpener.SafeFileName;
                    pickFileButton.Enabled = false;
                    activityBox.Enabled = true;
                    exportButton.Enabled = true;
                    activityBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Must be a .tableContent file!");
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // get second .tableContent file
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                if (fileOpener.SafeFileName.EndsWith(".tableContent"))
                {
                    destinationContentFilePath = fileOpener.FileName;
                    string activityId = (string)activityBox.Items[activityBox.SelectedIndex];
                    string tempDir = Environment.GetEnvironmentVariable("APPDATA") + "/" + Program.PROGRAM_IDENTIFIER + "/_temp";
                    Directory.CreateDirectory(tempDir);
                    // make sure other temp directory was removed
                    try
                    {
                        Directory.Delete(tempDir + "/" + activityId, true);
                    }
                    catch (Exception exception)
                    {
                        Program.HandleError(exception);
                        return;
                    }
                    TableTools.ExtractActivityDirectory(activityId, sourceContentFilePath, tempDir);
                    string tempActivityDir = tempDir + "/" + activityId;
                    ZipFile zip = ZipFile.Read(destinationContentFilePath);
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
                        Program.HandleError(exception);
                        return;
                    }
                    // import
                    using (ZipFile zipDest = zip)
                    {
                        zipDest.AddFiles((System.IO.Directory.EnumerateFiles(tempActivityDir)), false, TableTools.GetActivityName(tempActivityDir));
                        zipDest.Save();
                        // cleanup!
                        Directory.Delete(tempDir + "/" + activityId, true);
                        MessageBox.Show("Transferred successfully!");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Must be a .tableContent file!");
                }
            }
        }
    }
}
