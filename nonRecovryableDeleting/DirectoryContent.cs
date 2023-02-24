using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nonRecovryableDeleting
{
    public delegate void onOpenFolder(string fname);
    class DirectoryContent:ListView
    {

        public DirectoryContent()
        {
            Init();
            this.ItemActivate += DirectoryContent_ItemActivate;
        }
        public onOpenFolder onOpenFolder;
        void DirectoryContent_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = (ListViewItem)((ListView)sender).SelectedItems[0];
            string fname = (string)item.Tag;
            if (Directory.Exists(fname))
            {
               onOpenFolder( this.Path = fname);
            }
            else if (File.Exists(fname))
            {
                try
                {
                    System.Diagnostics.Process.Start(fname);
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Init()
        {
            this.FullRowSelect = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.Dock = DockStyle.Fill;
            this.View = System.Windows.Forms.View.Details;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.colhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhModDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colhType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colhName,
            this.colhModDate,
            this.colhType,
            this.colhSize});
            this.colhName.Width = 120;
            this.colhModDate.Width = 150;
            this.colhType
                .Width = 100;
            // 
            // colhName
            // 
            this.colhName.Text = "الاسم";
            // 
            // colhModDate
            // 
            this.colhModDate.Text = "ناريخ التعديل";
            // 
            // colhSize
            // 
            this.colhSize.DisplayIndex = 3;
            this.colhSize.Text = "الحجم";
            // 
            // colhType
            // 
            this.colhType.DisplayIndex = 2;
            this.colhType.Text = "النوع";

            
        }
        private System.Windows.Forms.ColumnHeader colhName;
        private System.Windows.Forms.ColumnHeader colhModDate;
        private System.Windows.Forms.ColumnHeader colhType;
        private System.Windows.Forms.ColumnHeader colhSize;
        
        private string path;

        public string Path
        {
            get { return path; }
            set {
                path = value;
                if (Directory.Exists(path))
                {
                    this.Items.Clear();
                    this.BeginUpdate();
                    DirectoryInfo drf = new DirectoryInfo(path);
                    DirectoryInfo[] drfs = drf.GetDirectories();
                    foreach (DirectoryInfo dir in drfs)
                    {
                        ListViewItem lsv =
                    this.Items.Add(dir.Name, 1);
                        lsv.SubItems.Add(dir.LastAccessTime.ToShortDateString()+dir.LastAccessTime.ToShortTimeString());
                        lsv.SubItems.Add("مجلد ملفات");
                        lsv.Tag = dir.FullName;
                        
                    }
                    FileInfo[] files = drf.GetFiles();
                    foreach (FileInfo f in files)
                    {
                        ListViewItem lsv =
                        this.Items.Add(f.Name, 2);
                        lsv.SubItems.Add(f.LastAccessTime.ToLongDateString());
                        lsv.SubItems.Add(f.Extension);
                        lsv.SubItems.Add(getSize(f.Length));
                        lsv.Tag = f.FullName;
                    }

                    this.EndUpdate();
                }
                else
                {
                    MessageBox.Show("hh");
                }
               
            }
        }
        string getSize(long inByte)
        {
            long inKByte = inByte / 1024;
            if (inKByte == 0)
                return inByte.ToString() + " بايت";
            long inMByte = inKByte / 1024;
            if (inMByte == 0)
                return inKByte.ToString() + "كيلو بايت";
            long inGByte = inMByte / 1024;
            if (inGByte == 0)
                return inMByte.ToString() + "ميجا بايت";
            return inGByte.ToString() + "." + ((inMByte % 1024) / 100).ToString() + "جيجا بايت";


        }
        public void UpDate()
        {
            this.Path = this.path;
        }
    }
}
