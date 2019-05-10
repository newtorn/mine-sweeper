# mine sweeper
namespace YcPackageTool.Widgets
{
    class RoundButton : Button
    {
        private int radius;//�뾶 
 
        //Բ�ΰ�ť�İ뾶����
        [CategoryAttribute("����"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public int Radius
        {
            set
            {
                radius = value;
                this.Height = this.Width = Radius;
            }
            get
            {
                return radius;
            }
        }
 
        private Image imageEnter;
        [CategoryAttribute("���"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public Image ImageEnter
        {
            set
            {
                imageEnter = value;
            }
            get
            {
                return imageEnter;
            }
        }
 
        private Image imageNormal;
        [CategoryAttribute("���"), BrowsableAttribute(true), ReadOnlyAttribute(false)]
        public Image ImageNormal
        {
            set
            {
                imageNormal = value;
                BackgroundImage = imageNormal;
            }
            get
            {
                return imageNormal;
            }
        }
 
        //���´���������VS������BackgroundImage���ԣ�ʹ��ֻ��ͨ��Diameter����Height��Width
        [BrowsableAttribute(false)]
        public new Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
 
            }
        }
 
        //���´���������VS������Size���ԣ�ʹ��ֻ��ͨ��Diameter����Height��Width
        [BrowsableAttribute(false)]
        public new Size Size
        {
            get
            {
                return base.Size;
            }
            set
            {
                base.Size = value;
 
            }
        }
 
        public RoundButton()
        {
            Radius = 64;
            this.Height = this.Width = Radius;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackgroundImage = imageEnter;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
 
        //��дOnPaint
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, Radius, Radius);
            this.Region = new Region(path);
        }
 
        //��дOnMouseEnter
        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    Graphics g = this.CreateGraphics();
        //    g.DrawEllipse(new Pen(Color.Blue), 0, 0, this.Width, this.Height);
        //    g.Dispose();
        //}
 
        //��дOnSizeChanged
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Height != Radius)
            {
                Radius = Width = Height;
            }
            else if (Width != Radius)
            {
                Radius = Height = Width;
            }
 
        }
 
        //��дOnMouseEnter
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackgroundImage = ImageEnter;
        }
 
        //��дOnMouseLeave
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackgroundImage = ImageNormal;
        }
    }
}
