using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net.Mime;

public partial class Switchemail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
 try
      {
          System.IO.File.Delete(Server.MapPath(@"/") + "PraNKMSG" + "0" + ".JPG");
          System.IO.File.Move(Server.MapPath(@"/") + "PraNKMSG" + "1" + ".JPG", Server.MapPath(@"/") + "PraNKMSG" + "0" + ".JPG");
      }
        catch (Exception ex)
      {
        Response.Write(ex.Message);
      }

    }
}

