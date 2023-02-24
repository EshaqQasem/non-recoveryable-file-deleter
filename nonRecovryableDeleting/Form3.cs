using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonRecovryableDeleting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListViewItem lst;
           lst= listView1.Items.Add("eshaq",0);
           lst.SubItems.Add("data");
           lst.SubItems.Add("type");
           lst.SubItems.Add("size"); 

            listView1.Items.Add("eshaq2",0);
            listView1.Items.Add("eshaq3",0);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex  )
            {
                case 0:
                listView1.View = View.LargeIcon;
                break;
                case 1:
                listView1.View = View.Details;
                break;
                case 2:
                listView1.View = View.SmallIcon;
                break;
                case 3:
                listView1.View = View.List;
                break;

                default:
                listView1.View = View.Tile;
                break;
            }
        }

        private void directoryContent1_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show("item active" + this.directoryContent1.SelectedItems.Count.ToString());
        }

        private void حذفنهائيToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
