using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace SMART_Table_Activty_Exporter
{
    public partial class Exporter : Form
    {
        public Exporter()
        {
            InitializeComponent();
        }

        private string contentFilePath;

        private void activityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pickFileButton_Click(object sender, EventArgs e)
        {
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                if (fileOpener.SafeFileName.EndsWith(".tableContent"))
                {
                    contentFilePath = fileOpener.FileName;
                    List<string> activityList = TableTools.GetActivitiesFromContentFile(contentFilePath);
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
            if (activityBox.SelectedIndex.Equals(-1)){
                MessageBox.Show("Please select a valid activity!");
                return;
            }
            string activityId = (string) activityBox.Items[activityBox.SelectedIndex];
            folderBrowser.Description = "Select the export location for the " + activityBox.Items[activityBox.SelectedIndex] + " activity.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderBrowser.SelectedPath))
                {
                    DialogResult dialog = MessageBox.Show("This will overwrite your existing export, continue?", "Folder already exists!", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        Directory.Delete(folderBrowser.SelectedPath + "/" + activityId, true);
                    }
                    else
                    {
                        return;
                    }
                }
                TableTools.ExtractActivityDirectory(activityId, contentFilePath, folderBrowser.SelectedPath);
                MessageBox.Show("Exported successfully!");
                this.Close();
            }
        }
    }
}
