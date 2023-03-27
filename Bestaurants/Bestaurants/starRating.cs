using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestaurants
{
    public partial class starRating : UserControl
    {
        public starRating()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void starRating_Load(object sender, EventArgs e)
        {

        }

        public void SetRating(Double dRating)
        {
           
            for (int i = 1; i < dRating+1; i++)
            {
                PictureBox pStar = new PictureBox();
                pStar.Width = picStar.Width;
                pStar.Height = picStar.Height;
                pStar.Visible = true;
                pStar.Left =picStar1.Left + (i - 1) * picStar1.Width;
                pStar.Image = picStar.Image;
              
                this.Controls.Add(pStar);
            }

            for (int i = 1; i < 6- dRating; i++)
            {
                PictureBox pStar = new PictureBox();
                pStar.Width = picGrayStar.Width;
                pStar.Height = picGrayStar.Height;
                pStar.Image = picGrayStar.Image;
                pStar.Visible = true;
                pStar.Left = picStar1.Left + (5 - i) * picGrayStar.Width;
                
                
                this.Controls.Add(pStar);
            }
        }
    }
}
