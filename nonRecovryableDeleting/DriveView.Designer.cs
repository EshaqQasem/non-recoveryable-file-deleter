namespace nonRecovryableDeleting
{
    partial class DriveView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSizeInfo = new System.Windows.Forms.Label();
            this.lblDriveName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.proBarSize = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSizeInfo
            // 
            this.lblSizeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeInfo.AutoSize = true;
            this.lblSizeInfo.Font = new System.Drawing.Font("Tahoma", 7F);
            this.lblSizeInfo.Location = new System.Drawing.Point(-3, 40);
            this.lblSizeInfo.Name = "lblSizeInfo";
            this.lblSizeInfo.Size = new System.Drawing.Size(8, 12);
            this.lblSizeInfo.TabIndex = 7;
            this.lblSizeInfo.Text = " ";
            // 
            // lblDriveName
            // 
            this.lblDriveName.AutoSize = true;
            this.lblDriveName.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblDriveName.Location = new System.Drawing.Point(55, 4);
            this.lblDriveName.Name = "lblDriveName";
            this.lblDriveName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDriveName.Size = new System.Drawing.Size(90, 16);
            this.lblDriveName.TabIndex = 5;
            this.lblDriveName.Text = "Local disk (C:)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::nonRecovryableDeleting.Properties.Resources.icons8_ssd_32;
            this.pictureBox3.Location = new System.Drawing.Point(164, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // proBarSize
            // 
            this.proBarSize.Location = new System.Drawing.Point(3, 23);
            this.proBarSize.Name = "proBarSize";
            this.proBarSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.proBarSize.RightToLeftLayout = true;
            this.proBarSize.Size = new System.Drawing.Size(155, 14);
            this.proBarSize.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.proBarSize.TabIndex = 6;
            // 
            // DriveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblSizeInfo);
            this.Controls.Add(this.proBarSize);
            this.Controls.Add(this.lblDriveName);
            this.Controls.Add(this.pictureBox3);
            this.Name = "DriveView";
            this.Size = new System.Drawing.Size(201, 54);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSizeInfo;
        private System.Windows.Forms.Label lblDriveName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar proBarSize;
    }
}
