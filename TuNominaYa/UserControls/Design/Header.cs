using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TuNominaYa.UserControls.Design
{
    public partial class Header : UserControl
    {
        [Category("Components")]
        [Description("Use it to change the background color of the main panel")]
        [DefaultValue(typeof(Color), $"{nameof(Color.DeepSkyBlue)}")]
        public Color MainBackColor
        {
            get => main.BackColor;
            set => main.BackColor = value;
        }

        [Category("Components")]
        [Description("Use it to change the background color of the bottom panel")]
        [DefaultValue(typeof(Color), $"{nameof(Color.DarkViolet)}")]
        public Color BottomBackColor
        {
            get => bottom.BackColor;
            set => bottom.BackColor = value;
        }

        [Category("Components")]
        [Description("Use it to change the background color of the picturebox")]
        [DefaultValue(typeof(Color), $"{nameof(Color.Transparent)}")]
        public Color PictureBoxBackColor
        {
            get => picturebox.BackColor;
            set => picturebox.BackColor = value;
        }

        [Category("Components")]
        [Description("Use it to set or change the background image of the picturebox")]
        [DefaultValue(null)]
        public Image? PictureBoxBackgroundImage
        {
            get => picturebox.BackgroundImage;
            set => picturebox.BackgroundImage = value;
        }

        [Category("Components")]
        [Description("Use it to change the font color of the label")]
        [DefaultValue(typeof(Color), $"{nameof(Color.DarkViolet)}")]
        public Color LabelFontColor
        {
            get => label.ForeColor;
            set => label.ForeColor = value;
        }

        [Category("Components")]
        [Description("Use it to set or change the value of the label")]
        [DefaultValue("")]
        public string LabelText
        {
            get => label.Text;
            set => label.Text = value;
        }

        public Header()
        {
            InitializeComponent();
        }
    }
}
