using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace nonRecovryableDeleting
{
    public class DrivesPanel:Panel
    {
        public DrivesPanel():base()
        {
            this.Size = new Size(710, 527);
            this.Location = new Point(0, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
          
            loadDrives();
           
            // this.AutoScroll = true;
            //this.BackColor = Color.Red;
            
        }

        public onclick onDriveClick;
        DriveInfo []Drives;
         void loadDrives()
        {
             Drives=  DriveInfo.GetDrives();
             
            for (int i = 0; i < Drives.Count();i++ )
            {
                
                    int y = 80;
                    DriveView dv = new DriveView();

                    dv.Drive = new DriveInfo(Drives[i].Name); 
                    //dv.DriveName = Drives[i].ToString();
                    dv.onclick = (d) => { onDriveClick(d); };
                    dv.Location = new Point(this.Width - (dv.Width + 20) * (i % 3 + 1), (dv.Height + 40) * (i / 3 + 1));
                    dv.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                    this.Controls.Add(dv);
                  //  j += dv.Width;
                
               
            }
           
        }
         public void update()
         {
             this.Controls.Clear();
             loadDrives();
         }
    }
}
