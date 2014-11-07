namespace SMART_Table_Activty_Exporter
{
    partial class DirectTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectTransfer));
            this.label3 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.activityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.fileOpener = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "STEP 3";
            // 
            // exportButton
            // 
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(279, 39);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(128, 218);
            this.exportButton.TabIndex = 10;
            this.exportButton.Text = "Pick destination .tableContentFile";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label2.Location = new System.Drawing.Point(168, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "STEP 2";
            // 
            // activityBox
            // 
            this.activityBox.Enabled = false;
            this.activityBox.FormattingEnabled = true;
            this.activityBox.Location = new System.Drawing.Point(146, 139);
            this.activityBox.MaxDropDownItems = 50;
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(121, 21);
            this.activityBox.TabIndex = 8;
            this.activityBox.Text = "Pick activity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "STEP 1";
            // 
            // pickFileButton
            // 
            this.pickFileButton.Location = new System.Drawing.Point(12, 39);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(128, 218);
            this.pickFileButton.TabIndex = 6;
            this.pickFileButton.Text = "Pick .tableContent file";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.pickFileButton_Click);
            // 
            // DirectTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectTransfer";
            this.Text = "SMART Table Activity Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox activityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.OpenFileDialog fileOpener;

    }
}