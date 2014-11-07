using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_Table_Activty_Exporter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Exporter exporter = new Exporter();
            exporter.Show();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Importer importer = new Importer();
            importer.Show();
        }

        private void transferActivites_Click(object sender, EventArgs e)
        {
            DirectTransfer transfer = new DirectTransfer();
            transfer.Show();
        }
    }
}
