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
using myControls;

namespace nonRecovryableDeleting
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        FileInfo selectedFile;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = of.FileName;
                selectedFile = new FileInfo(of.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()=="" )
            {
                MessageBox.Show("قم بتحديد ملف ");
            }
            else
            {
                if (selectedFile == null)
                    selectedFile = new FileInfo(textBox1.Text);

                if (selectedFile.Exists)
                {
                    progressBar1.Visible = label1.Visible = true;
                    progressBar1.Value = 0;
                    damageFile(selectedFile);
                    selectedFile.Delete();
                    selectedFile = null;
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("الملف المدخل ليس موجود ");
                }
            }
        }

        //RichProgressBar.mProgreesBar
        //private void damageFile(FileInfo selectedFile)
        //{
        //    FileStream file = new FileStream(selectedFile.FullName,FileMode.Open, FileAccess.ReadWrite);
        //    Stream s;
            
        //    progressBar1.Maximum = 101;// (file.Length > Int32.MaxValue ? Int32.MaxValue : (int)file.Length);
        //    int rate =(int) file.Length/100;
           
        //    for (long i = 0; i < file.Length; i++) 
        //    {
        //        file.WriteByte(255);
        //       if(i%rate == 0)
        //        progressBar1.Value += 1;
                
        //    }
            
        //    file.Close();
        //}
        private void damageFile(FileInfo selectedFile)
        {
            FileStream file = new FileStream(selectedFile.FullName, FileMode.Open, FileAccess.ReadWrite);
            byte [] bytes=new byte[1024];
            long kbytes=file.Length / 1024;
            long j=0;
            for (j = 0; j <kbytes ; j++)
            {
                file.Write(bytes, 0, 1024);
            }
                            //progressBar1.Maximum = 101;// (file.Length > Int32.MaxValue ? Int32.MaxValue : (int)file.Length);
                            //int rate = (int)file.Length / 100;

            for (long i = kbytes*1024 ; i < file.Length; i++)
            {
                file.WriteByte(0);
                
            }

            file.Close();
        }
    }
}
