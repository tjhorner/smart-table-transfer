namespace SMART_Table_Activty_Exporter
{
    partial class Importer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importer));
            this.label1 = new System.Windows.Forms.Label();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pickFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.importButton = new System.Windows.Forms.Button();
            this.fileOpener = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "STEP 1";
            // 
            // pickFileButton
            // 
            this.pickFileButton.Location = new System.Drawing.Point(12, 41);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(128, 218);
            this.pickFileButton.TabIndex = 2;
            this.pickFileButton.Text = "Pick .tableContent file";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.pickFileButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(184, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "STEP 2";
            // 
            // pickFolderButton
            // 
            this.pickFolderButton.Enabled = false;
            this.pickFolderButton.Location = new System.Drawing.Point(162, 41);
            this.pickFolderButton.Name = "pickFolderButton";
            this.pickFolderButton.Size = new System.Drawing.Size(128, 218);
            this.pickFolderButton.TabIndex = 4;
            this.pickFolderButton.Text = "Pick exported activity folder";
            this.pickFolderButton.UseVisualStyleBackColor = true;
            this.pickFolderButton.Click += new System.EventHandler(this.pickFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label3.Location = new System.Drawing.Point(328, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "STEP 3";
            // 
            // importButton
            // 
            this.importButton.Enabled = false;
            this.importButton.Location = new System.Drawing.Point(306, 41);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(128, 218);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import!";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickFolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Importer";
            this.Text = "SMART Table Activity Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pickFolderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.OpenFileDialog fileOpener;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}