using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace flatDesign1
{
    class richPrograssBar : Control
    {
        public richPrograssBar()
            : base()
        {
            this.Minimum = 0;
            this.Maximum = 100;
            this.value = 0;
            this.Type = PrograssBarType.Normal;
            this.ValueColor = Color.Green;
            this.BaseSize = new Size(100, 15);
            this.BackGroundHeight = this.BaseSize.Height;
        }

        /* protected override void OnResize(EventArgs e)
         {
             base.OnResize(e);
             if (this.Type == PrograssBarType.withValue)
             {
                 this.BaseSize = new Size(this.Width, this.Height / 2 - 2);
                 this.ValueSize = new Size(this.ValueSize.Width, this.Height / 2 - 2);
             }
         }
         * */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            //جلب حجم الاداة سيتم الرسم اغنمادا على هذا المستطسل في حالة البرجرس بار الغادية  
            Rectangle tmpRect = this.ClientRectangle;
            tmpRect = new Rectangle(new Point(0, this.ValueSize.Height + 4 + (this.BaseSize.Height - BackGroundHeight) / 2), new Size(this.Size.Width, BackGroundHeight));
            int drawenValue = (int)(((float)this.Width / (float)(this.Maximum - this.Minimum)) * this.value);
            if (this.Type == PrograssBarType.withValue)
            {
                // تغيير حجم الاداه ككل 
                this.Size = new Size(this.Width, this.baseSize.Height + this.ValueSize.Height + 4);
                //


                path.AddRectangle(tmpRect);

                Rectangle valueRect;
                if (ValueType == ValueShowerType.Moved)
                {
                    valueRect = new Rectangle(new Point(drawenValue - this.ValueSize.Width, 0), this.ValueSize);
                }
                else
                {
                    valueRect = new Rectangle(new Point(this.Width / 2 - this.ValueSize.Width / 2, 0), this.ValueSize);
                }
                path.AddRectangle(valueRect);
                e.Graphics.FillRectangle(new SolidBrush(ValueColor), valueRect);
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.White), valueRect);

                //  e.Graphics.FillRectangle(new SolidBrush(ForeColor), new Rectangle(new Point(0, this.ValueSize.Height + 4), new Size((int)(((float)this.Width / (float)(this.Maximum - this.Minimum)) * this.value), BaseSize.Height)));

            }

            else
            {

                path.AddRectangle(tmpRect);
            }


            // 
            tmpRect = new Rectangle(new Point(0, this.ValueSize.Height + 4), new Size(drawenValue, (this.BaseSize.Height - BackGroundHeight) / 2));

            path.AddRectangle(tmpRect);
            tmpRect = new Rectangle(new Point(0, this.ValueSize.Height + 4 + (this.BaseSize.Height - BackGroundHeight) / 2 + this.BackGroundHeight), new Size(drawenValue, (this.BaseSize.Height - BackGroundHeight) / 2));
            path.AddRectangle(tmpRect);
            e.Graphics.FillRectangle(new SolidBrush(ForeColor), new Rectangle(new Point(0, this.ValueSize.Height + 4), new Size((int)(((float)this.Width / (float)(this.Maximum - this.Minimum)) * this.value), BaseSize.Height)));

            this.Region = new Region(path);


















            //base.OnPaint(e);

            /* Graphics g = this.CreateGraphics();

             Rectangle rect = this.ClientRectangle;

             GraphicsPath path = new GraphicsPath();

             path.AddEllipse(rect);

             this.Region = new Region(path);
          
           // e.Graphics.FillRectangle(new SolidBrush(this.BackColor), new Rectangle(new Point(this.Location.X,this.Location.Y-5),new Size(this.Width,this.Height-5)));
            e.Graphics.FillRectangle(new SolidBrush(this.ForeColor)
                ,new Rectangle(new Point(0,5)
                ,new Size( (int) ( ( (float)this.Width/(float)(this.Maximum-this.Minimum) )*this.value),this.Height-10)
                )
                  );
               
        */
            /*            Rectangle rect = this.ClientRectangle;

                        GraphicsPath path = new GraphicsPath();

                        //path.AddRectangle(new Rectangle(new Point(0,-10),new Size(this.Width,(int)((float)this.Height/3.0))));
                        path.AddRectangle(new Rectangle(new Point(0, (int)((float)this.Height / 3.0) ), new Size(this.Width, (int)((float)this.Height / 3.0))));
                        path.AddRectangle(new Rectangle(new Point(0,2* (int)((float)this.Height / 3.0)), new Size(this.Width, (int)((float)this.Height / 3.0))));

                        this.Region = new Region(path);
              */
        }

        private int value;

        public int Value
        {
            get { return this.value; }
            set
            {

                this.value = value;
                this.Text = this.value.ToString() + "%";
                this.Invalidate();
            }
        }

        private int maximum;

        public int Maximum
        {
            get { return maximum; }
            set { maximum = value; }
        }
        private int minimum;

        public int Minimum
        {
            get { return minimum; }
            set { minimum = value; }
        }

        public enum PrograssBarType
        {
            Normal, withValue
        }

        private PrograssBarType type;

        public PrograssBarType Type
        {
            get { return type; }
            set
            {
                type = value;
                if (value == PrograssBarType.withValue)
                {
                    this.BaseSize = new Size(this.Width, this.Height / 2 - 2);
                    this.ValueSize = new Size(60, this.Height / 2 - 2);
                }
                else
                {
                    this.ValueSize = new Size(0, 0);

                }
                this.Invalidate();
            }
        }

        protected Size baseSize;

        public Size BaseSize
        {
            get
            {
                if (Type == PrograssBarType.Normal)
                    return base.Size;
                else
                {
                    return new Size(this.Width, baseSize.Height);
                }
            }
            set
            {
                if (Type == PrograssBarType.Normal)
                    base.Size = value;
                else
                {

                    baseSize.Height = value.Height;
                    baseSize.Width = this.Width;
                }


                this.Invalidate();
            }
        }

        private Size valueSize;

        public Size ValueSize
        {
            get { return valueSize; }
            set
            {
                if (Type == PrograssBarType.withValue)
                {
                    valueSize = value;
                }
                else
                    valueSize = new Size(0, 0);
                this.Invalidate();

            }
        }

        private Color valueColor;

        public Color ValueColor
        {
            get { return valueColor; }
            set
            {
                valueColor = value;
                this.Invalidate();

            }
        }

        public enum ValueShowerType
        {
            Moved, Fixed
        }

        private ValueShowerType valueType;

        public ValueShowerType ValueType
        {
            get { return valueType; }
            set
            {
                valueType = value;
                this.Invalidate();

            }
        }

        private int backGroundHeight;

        public int BackGroundHeight
        {
            get { return backGroundHeight; }
            set
            {
                backGroundHeight = value;
                this.Invalidate();
            }
        }


    }
}
