namespace nonRecovryableDeleting
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richPrograssBar1 = new flatDesign1.richPrograssBar();
            this.prbOneFile = new flatDesign1.richPrograssBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.Location = new System.Drawing.Point(173, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(464, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "جاري حذف 2050 عنصر /عناصر (500 مغيا بايت)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button1.Location = new System.Drawing.Point(9, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "الغاء الأمر";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(179, 240);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(340, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "سيؤدي الغاء الامر الى ايقاف عملية حذف الملفات المتبقية ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(495, 18);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم:";
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFileName.Location = new System.Drawing.Point(12, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFileName.Size = new System.Drawing.Size(421, 14);
            this.lblFileName.TabIndex = 0;
            // 
            // lblFilePath
            // 
            this.lblFilePath.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFilePath.Location = new System.Drawing.Point(12, 44);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilePath.Size = new System.Drawing.Size(421, 14);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(495, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "المسار:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(449, 111);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "العناصر المتبقية :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richPrograssBar1);
            this.panel2.Controls.Add(this.prbOneFile);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblFilePath);
            this.panel2.Controls.Add(this.lblFileName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 189);
            this.panel2.TabIndex = 1;
            // 
            // richPrograssBar1
            // 
            this.richPrograssBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richPrograssBar1.BackGroundHeight = 12;
            this.richPrograssBar1.BaseSize = new System.Drawing.Size(492, 19);
            this.richPrograssBar1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.richPrograssBar1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.richPrograssBar1.Location = new System.Drawing.Point(9, 128);
            this.richPrograssBar1.Maximum = 100;
            this.richPrograssBar1.Minimum = 0;
            this.richPrograssBar1.Name = "richPrograssBar1";
            this.richPrograssBar1.Size = new System.Drawing.Size(492, 43);
            this.richPrograssBar1.TabIndex = 2;
            this.richPrograssBar1.Text = "0%";
            this.richPrograssBar1.Type = flatDesign1.richPrograssBar.PrograssBarType.withValue;
            this.richPrograssBar1.Value = 0;
            this.richPrograssBar1.ValueColor = System.Drawing.Color.OrangeRed;
            this.richPrograssBar1.ValueSize = new System.Drawing.Size(30, 20);
            this.richPrograssBar1.ValueType = flatDesign1.richPrograssBar.ValueShowerType.Fixed;
            // 
            // prbOneFile
            // 
            this.prbOneFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prbOneFile.BackGroundHeight = 12;
            this.prbOneFile.BaseSize = new System.Drawing.Size(492, 19);
            this.prbOneFile.Font = new System.Drawing.Font("Tahoma", 9F);
            this.prbOneFile.ForeColor = System.Drawing.Color.LimeGreen;
            this.prbOneFile.Location = new System.Drawing.Point(9, 61);
            this.prbOneFile.Maximum = 100;
            this.prbOneFile.Minimum = 0;
            this.prbOneFile.Name = "prbOneFile";
            this.prbOneFile.Size = new System.Drawing.Size(492, 43);
            this.prbOneFile.TabIndex = 2;
            this.prbOneFile.Text = "0%";
            this.prbOneFile.Type = flatDesign1.richPrograssBar.PrograssBarType.withValue;
            this.prbOneFile.Value = 0;
            this.prbOneFile.ValueColor = System.Drawing.Color.OrangeRed;
            this.prbOneFile.ValueSize = new System.Drawing.Size(30, 20);
            this.prbOneFile.ValueType = flatDesign1.richPrograssBar.ValueShowerType.Fixed;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(552, 274);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Shown += new System.EventHandler(this.Form4_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private flatDesign1.richPrograssBar prbOneFile;
        private System.Windows.Forms.Panel panel2;
        private flatDesign1.richPrograssBar richPrograssBar1;
    }
}