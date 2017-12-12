using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diffWebApp
{
    public partial class _out : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file1 = Application["file1"].ToString();
            string file2 = Application["file2"].ToString();

            Image3.ImageUrl = "/in/" + file1;
            Image4.ImageUrl = "/in/" + file2;
        }
    }
}