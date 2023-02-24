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
using System.Net;
using System.Net.Sockets;

namespace nonRecovryableDeleting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            pictureBox1.Image = Image.FromFile(of.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(@"d:\dm\1.txt");
            FileInfo f;
            
            MessageBox.Show(System.IO.Directory.GetLastAccessTime(@"d:\dm").ToString());
           // MarshalByRefObject o;
         //   NetworkStream n;
           // BinaryWriter bw = new BinaryWriter(n);
            string s;
          
            
        }
        class aa : BinaryWriter
        {
           
        }
    }
}
