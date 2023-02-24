using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace nonRecovryableDeleting
{
    public delegate void onclick(DriveInfo d);
    public partial class DriveView : UserControl
    {
        public DriveView()
        {
            InitializeComponent();
            lblSizeInfo.ForeColor = Color.FromArgb(125, Color.Black);
            this.Click += delegate { onclick(drive); };
        }
       
        public onclick onclick;
       public static string getSize(long inByte)
        {
            long inKByte = inByte / 1024;
            if (inKByte==0)
                return inByte.ToString() + " بايت";
            long inMByte = inKByte / 1024;
            if(inMByte ==0)
                return inKByte.ToString() + "كيلو بايت";
            long inGByte = inMByte / 1024;
            if (inGByte == 0)
                return inMByte.ToString() + "ميجا بايت";
            return inGByte.ToString() +"."+ ((inMByte %1024)/100 ).ToString() + "جيجا بايت";


        }
        private DriveInfo drive;

        public DriveInfo Drive
        {
            get { return drive; }
            set
            {
                drive = value;
                try
                {

                    if(drive.IsReady)
                    {lblDriveName.Text = "Local Drive (" + drive.Name + ")";
                    
                    
                        proBarSize.Value =(int) ((drive.TotalSize-drive.AvailableFreeSpace)/(drive.TotalSize/100));
                        lblSizeInfo.Text =  getSize(drive.AvailableFreeSpace) + " حرة من " + getSize(drive.TotalSize);
                    }
                   else
                    {
                        lblDriveName.Text = drive.VolumeLabel;
                        this.Controls.Remove(proBarSize);
                    }
                }
                catch (IOException ex)
                {

                    // MessageBox.Show(ex.Message);

                }
            }
        }
        

        public string DriveName
        {
            get { return this.drive.Name; }
            
        }
    }
}
