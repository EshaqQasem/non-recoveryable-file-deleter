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
using System.Threading;

namespace nonRecovryableDeleting
{
    public delegate void setText(string str);
    public delegate void incProBar();
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       public string[] paths;
        Thread thread;
        private void Form4_Shown(object sender, EventArgs e)
        {
            int count = 0;
            long size = 0;
            foreach (string p in paths)
            {
                if (Directory.Exists(p))
                {
                    getDirInfo(p, ref size, ref count);
                }
                else if (File.Exists(p))
                {
                    count++;
                    size += (new FileInfo(p)).Length;
                } 

            }
            label1.Text = "جاري حذف " + count.ToString() + " عنصر (" + DriveView.getSize(size) + " )";
            thread = new Thread(() => delete(paths));
            thread.Start();
            
        }

        bool stopThread = false;
        bool threadStoped = false;
        void getDirInfo(string p, ref long size, ref int count)
        {
            
            
                string[] dir = Directory.GetDirectories(p);
                foreach (string d in dir)
                {
                    getDirInfo(d, ref size, ref count);
                }
                string[] files = Directory.GetFiles(p);
                foreach (string f in files)
                {
                    count++;
                    size += (new FileInfo(f)).Length;
                }
                count++;
            
        }

        void delete(string[] pth)
        {
           
            
            foreach (string p in pth)
            {
                if (stopThread)
                {
                    threadStoped = true;
                    return;
                }
                if (Directory.Exists(p))
                {
                    string[] indir = Directory.GetDirectories(p);
                    if(indir.Length>0)
                    delete(indir);
                    delete(Directory.GetFiles(p));
                   
                }
                else if (File.Exists(p))
                {
                    this.Invoke(new setText((str) => { lblFilePath.Text = str; lblFileName.Text = Path.GetFileName(str); }), new object[] { p });
                    this.Invoke(new incProBar(() => { prbOneFile.Value=0; }));
                    damageFile(p);   
                }
            }


        }
        private void damageFile(string selectedFile)
        {
            FileStream file = new FileStream(selectedFile, FileMode.Open, FileAccess.ReadWrite);
            byte[] bytes = new byte[1024];
            long kbytes = file.Length / 1024;
            long progressbarInc = kbytes / 100;
            if (progressbarInc == 0) progressbarInc++;
            long j = 0;
            for (j = 0; j < kbytes; j++)
            {
                file.Write(bytes, 0, 1024);
                if(j%progressbarInc ==0)
                {
                   // progressbarInc += progressbarInc;
                    this.Invoke(new incProBar(() => { prbOneFile.Value++; }));
                }
                if (stopThread)
                {
                    threadStoped = true;
                    file.Close();
                    return;
                }

            }
            //progressBar1.Maximum = 101;// (file.Length > Int32.MaxValue ? Int32.MaxValue : (int)file.Length);
            //int rate = (int)file.Length / 100;

            for (long i = kbytes * 1024; i < file.Length; i++)
            {
                file.WriteByte(0);

            }

            file.Close();
           // File.Copy(selectedFile,Path.
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }

   
}

