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

namespace nonRecovryableDeleting
{
    public partial class mainForm2 : Form
    {
        public mainForm2()
        {
            InitializeComponent();
            filesDirsList = new DirectoryContent();
            filesDirsList.ContextMenuStrip = this.contextMenuStrip1;
            filesDirsList.LargeImageList = imageList1;
            filesDirsList.SmallImageList = imageList1;
            filesDirsList.onOpenFolder += open_folder;
           // drivePanel.Paint+=delegate{loadDrives();};
        }
        DirectoryContent filesDirsList;
        DrivesPanel drivePanel;
        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        private void mainForm2_Shown(object sender, EventArgs e)
        {
            drivePanel = new DrivesPanel();
            drivePanel.onDriveClick = driveclick;
            pnlMain.Controls.Add(drivePanel);
            
        }

        private void driveclick(DriveInfo d)
        {
            pnlMain.Controls.Remove(drivePanel);
            drivePanel.Controls.Clear();

            filesDirsList.Path = d.Name;
            open_folder(d.Name);
            pnlMain.Controls.Add(filesDirsList);
        }

        private void open_folder(string fname)
        {
            undoStack.Push(fname);
            txtAddress.Text = fname;
            redoStack.Clear();
            btnRedo.Enabled = false;
        }

        private void undo()
        {
            if (undoStack.Count == 1)
            {
                this.pnlMain.Controls.Remove(filesDirsList);
                filesDirsList.Items.Clear();
                drivePanel.update();
                pnlMain.Controls.Add(drivePanel);

            }
            else
            {
                redoStack.Push(undoStack.Pop());
                btnRedo.Enabled = true;
               txtAddress.Text= filesDirsList.Path = undoStack.Peek();
            }
        }
        private void redo()
        {
           // if (redoStack.Count != 0)
            {
                txtAddress.Text = filesDirsList.Path = redoStack.Pop();
                undoStack.Push(txtAddress.Text);
                if (redoStack.Count == 0)
                    btnRedo.Enabled = false;
            }
        }
        
        //void loadDrives()
        //{
            
        //    Drives=  DriveInfo.GetDrives();
           
        //    for (int i=0;i<Drives.Count();i++)
        //    {
        //        int y = 80;
        //        DriveView dv = new DriveView();
        //        dv.Click += dv_Click;
        //        dv.Drive = Drives[i];
        //        //dv.DriveName = Drives[i].ToString();
        //        if (i ==2)
        //            y += dv.Height + 50;
        //        dv.Location = new Point(drivePanel.Width - (dv.Width*(1+i%2)) , y);
        //        drivePanel.Controls.Add(dv);
        //}
           
        //}

       
        private void mainForm2_Load(object sender, EventArgs e)
        {
            
            //loadDrives();

        }
        
        private void btnUndo_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            redo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deletedfiles="\r\n";
            if (filesDirsList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvi in filesDirsList.SelectedItems)
                {
                    deletedfiles += lvi.Text + "\r\n"; 
                }

                MessageBox.Show("سيتم حذف المجلدات والملفات حذفا نهائيا ..." + "\r\n" +
                        "انتبه لايمكن حتى استرجعاها باقوى برامج استعادة الملفات المذوفة "
                        +deletedfiles);
               
            }
        }
    }
}
