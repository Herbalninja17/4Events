using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.Data.DataClasses;

namespace EyeCT4Events.GUI
{
    public partial class ImageForm : Form
    {
        public ImageForm(int imageId)
        {
            InitializeComponent();
            Image img = DataFile.GetImageToDisplay(imageId);
            pbImage.Image = img;
        }
    }
}
