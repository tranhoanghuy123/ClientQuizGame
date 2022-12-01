using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Quiz_Project
{
    public   enum TextPosition
    {
        Left,
        Right,
        Center,
        Sliding,
        None

    }
    internal class ControlProgressBar:ProgressBar
    {
        // Fields
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private Color foreBackColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;

        // Others
        private bool paintBack = false;  
        private bool stopPainting = false;
        
        // Constructor
        public  ControlProgressBar ()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;

        }

        public Color ChannelColor 
        { 
            get => channelColor; 
            set => channelColor = value; 
        }

        //Properties
        [Category("HuyPC^_^")]
        public Color SliderColor 
        { get => sliderColor; set => sliderColor = value; }
        [Category("HuyPC^_^")]
        public Color ForeBackColor 
        { get => foreBackColor; set => foreBackColor = value; }
        [Category("HuyPC^_^")]
        public int ChannelHeight 
        { get => channelHeight; set => channelHeight = value; }
        [Category("HuyPC^_^")]
        public int SliderHeight 
        { get => sliderHeight; set => sliderHeight = value; }
        [Category("HuyPC^_^")]
        public TextPosition ShowValue 
        { get => showValue; set => showValue = value; }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("HuyPC^_^")]
        public override Font Font
        { get => base.Font; set => base.Font = value;}
        [Category("HuyPC^_^")]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        // -> Paint the bg & channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if(!stopPainting)
            {
                if(!paintBack)
                {
                    // Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, ChannelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                        {
                            rectChannel.Y = this.Height - channelHeight;
                        }
                        else
                            rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                        // Painting
                        graph.Clear(this.Parent.BackColor); // Surface
                        graph.FillRectangle(brushChannel, rectChannel); // channel
                        if(!this.DesignMode)
                        {
                            paintBack = true;
                        }
                    }
                }
                if(this.Value ==this.Maximum || this.Value == this.Minimum)
                {
                    paintBack = false;
                }
            }
        }
        // -> Paint Slider
        protected override void OnPaint(PaintEventArgs e)
        {
            if(!stopPainting)
            {
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / (double)this.Maximum);
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if(sliderWidth >= channelHeight)
                        rectSlider.Y = this.Height - sliderHeight;
                    else
                        rectSlider.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                    // Painting
                    if(sliderHeight > 1) // SLIDER
                    {
                        graph.FillRectangle(brushSlider, rectSlider);

                    }
                    if (showValue != TextPosition.None) // Text
                        DrawValueTex(graph, sliderWidth, rectSlider);

                }
            }
        }

        // -> Paint Value Text
        private void DrawValueTex(Graphics graph, int sliderWidth, Rectangle rectSlider)
        {
            string text = this.Value.ToString();
        }
    }
}
