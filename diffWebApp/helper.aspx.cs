using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace diffWebApp
{
    public partial class helper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sButton_Click(object sender, EventArgs e)
        {
            string img1 = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string img2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
            Application["file1"] = img1;
            Application["file2"] = img2;
            img1 = FileUpload1.PostedFile.FileName;
            img2 = FileUpload2.PostedFile.FileName;

             Bitmap bmp1 = new Bitmap(img1);
             Bitmap bmp2 = new Bitmap(img2);
   

             Stopwatch watch = new Stopwatch();
             watch.Start();
             List<Rectangle> rects = Core.ImageComparer.Compare(bmp1, bmp2);
             watch.Stop();

             if (rects.Count != 0)
             {
                 using (Graphics g = Graphics.FromImage(bmp1))
                 {
                     g.DrawRectangles(new Pen(Brushes.Blue, 2f), rects.ToArray());
                     g.Save();
                     bmp1.Save("D:\\Project\\diffWebApp\\diffWebApp\\out\\out1.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                   
                 }
                 using (Graphics g = Graphics.FromImage(bmp2))
                 {
                     g.DrawRectangles(new Pen(Brushes.Red, 2f), rects.ToArray());
                     g.Save();
                     bmp2.Save("D:\\Project\\diffWebApp\\diffWebApp\\out\\out2.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                 }
             }

             Response.Redirect("out.aspx");

        }



    }
}