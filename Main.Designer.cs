namespace SMART_Table_Activty_Exporter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.transferActivites = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(13, 13);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(339, 23);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export a SMART Table Activity";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(13, 42);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(339, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import an activity to a Toolkit file";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // transferActivites
            // 
            this.transferActivites.Location = new System.Drawing.Point(12, 71);
            this.transferActivites.Name = "transferActivites";
            this.transferActivites.Size = new System.Drawing.Size(339, 23);
            this.transferActivites.TabIndex = 2;
            this.transferActivites.Text = "Transfer activities between projects directly";
            this.transferActivites.UseVisualStyleBackColor = true;
            this.transferActivites.Click += new System.EventHandler(this.transferActivites_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "© TJ Horner 2014";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transferActivites);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "SMART Table Activity Importer/Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button transferActivites;
        private System.Windows.Forms.Label label1;
    }
}