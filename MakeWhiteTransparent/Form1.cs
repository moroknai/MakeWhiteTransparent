using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeWhiteTransparent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MakeWhiteTP_v02();
        }


        void MakeWhiteTP_v02()
        {
            int thresholdd = 215;

            Bitmap img = new Bitmap(@"C:\Users\Athletron\Desktop\cbc_sq.png");
            Bitmap img4byte1 = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            //Bitmap img4byte2 = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);


            for (int cols = 0; cols < img.Width; cols++)
            {
                bool flag = true;
                for (int rows = 0; rows < img.Height; rows++)
                {
                    Color c = img.GetPixel(cols, rows);

                    if (c.B > thresholdd && flag)
                    {
                        img4byte1.SetPixel(cols, rows, Color.Transparent);
                    }
                    else
                    {
                        img4byte1.SetPixel(cols, rows, c);
                        //flag = false;
                    }
                }
            }

            img4byte1.Save(@"C:\Users\Athletron\Desktop\cbc_sq_edited.png");

        }

        void MakeWhiteTP()
        {
            int thresholdd = 150;

            Bitmap img = new Bitmap(@"C:\Users\Athletron\Pictures\igazolvany\ig_kep_KoroknaiMate.png");
            Bitmap img4byte1 = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bitmap img4byte2 = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bitmap img4byte3 = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bitmap img4byte = new Bitmap(img.Width, img.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            for (int cols = 0; cols < img.Width; cols++)
            {
                bool flag = true;
                for (int rows = 0; rows < img.Height; rows++)
                {
                    Color c = img.GetPixel(cols, rows);
                    //if (c.A == 255 && c.R == 255 && c.G == 255 && c.B == 255)
                    //{
                    //    img4byte.SetPixel(cols, rows, Color.Transparent);
                    //}

                    if (c.G > thresholdd && flag)
                    {
                        img4byte1.SetPixel(cols, rows, Color.LightGray);
                    }
                    else
                    {
                        img4byte1.SetPixel(cols, rows, c);
                        flag = false;
                    }
                }
            }


            //for (int rows = 0; rows < img.Height; rows++)
            //{
            //    bool flag = true;
            //    for (int cols = 0; cols < img.Width; cols++)
            //    {
            //        Color c = img4byte1.GetPixel(cols, rows);
            //        //if (c.A == 255 && c.R == 255 && c.G == 255 && c.B == 255)
            //        //{
            //        //    img4byte.SetPixel(cols, rows, Color.Transparent);
            //        //}

            //        if (c.G > thresholdd && flag)
            //        {
            //            img4byte2.SetPixel(cols, rows, Color.LightGray);
            //        }
            //        else
            //        {
            //            img4byte2.SetPixel(cols, rows, c);
            //            flag = false;
            //        }
            //    }
            //}

            //for (int rows = 0; rows < img.Height; rows++)
            //{
            //    bool flag = true;
            //    for (int cols = img.Width - 1; cols >= 0; cols--)
            //    {
            //        Color c = img4byte2.GetPixel(cols, rows);
            //        //if (c.A == 255 && c.R == 255 && c.G == 255 && c.B == 255)
            //        //{
            //        //    img4byte.SetPixel(cols, rows, Color.Transparent);
            //        //}

            //        if (c.G > thresholdd && flag)
            //        {
            //            img4byte.SetPixel(cols, rows, Color.LightGray);
            //        }
            //        else
            //        {
            //            img4byte.SetPixel(cols, rows, c);
            //            flag = false;
            //        }
            //    }
            //}

            Bitmap resized = new Bitmap(img, new Size(img.Width / 2, img.Height / 2));

            resized.Save(@"C:\Users\Athletron\Pictures\igazolvany\ig_kep_KoroknaiMate_resized.png");
        }

    }
}
