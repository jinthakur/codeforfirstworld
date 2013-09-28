using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net.Mime;
using System.Drawing;
using System.Drawing.Imaging;

public partial class draftemail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
      {
   //  Declare some variables that will control the behavior and color of the image.


        MailMessage mailMsg = new MailMessage();

        // To
        mailMsg.To.Add(new MailAddress(Text2.Value, Text2.Value));

        // From
        mailMsg.From = new MailAddress(Text1.Value, " Jin Name");

        // Subject and multipart/alternative Body
        mailMsg.Subject = sub.Value;
        string text = PraNKMSG.Value;
         Createimage (  text ,"0");
         text = rEALMSG.Value;
         Createimage(text, "1");
         string textimage = "";
         string html = @"<p>  <img  src =" + "'http://webemail.askurquestions.info/" + "PraNKMSG" + "0" + ".JPG'" + " width ='100' height='20' border ='0'/></p>";
       // mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(text, null, MediaTypeNames.Text.Plain));
        mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));
      
        // Init SmtpClient and send
        SmtpClient smtpClient = new SmtpClient("smtp.sendgrid.net");
         smtpClient = new SmtpClient();
        //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("username@domain.com", "yourpassword");
        //smtpClient.Credentials = credentials;

        smtpClient.Send(mailMsg);
        Response.Redirect("Switchemail.aspx");
      }
        catch (Exception ex)
      {
        Response.Write(ex.Message);
      }

    }

    public void Createimage ( string text ,string number){
    string Text = text;
Color FontColor = Color.Black;
Color BackColor = Color.Transparent;
String FontName = "Times New Roman";
int FontSize = 12;
int Height = 20;
int Width = 100;

////STEP 2 - Create a Bitmap Object to Hold The Image

Bitmap bitmap = new Bitmap(Width, Height);
////STEP 3 - Create a Graphics object using this Bitmap object

Graphics graphics = Graphics.FromImage(bitmap);
//STEP 4 - Create Color, Font, and  PointF objects.

Color color = Color.Transparent; ;
Font font = new Font(FontName, FontSize);
//define where the text will be displayed in the specified area of the image
PointF point = new PointF(5.0F, 5.0F);
//STEP 5 - Create Brushes and Pen

SolidBrush BrushForeColor = new SolidBrush(FontColor);
SolidBrush BrushBackColor = new SolidBrush(BackColor);
Pen BorderPen = new Pen(color);
//STEP 6 - Draw Rectangle using Graphics object

Rectangle displayRectangle = new Rectangle(new Point(0, 0), new Size(Width - 1, Height - 1));
graphics.FillRectangle(BrushBackColor, displayRectangle);
graphics.DrawRectangle(BorderPen, displayRectangle);
//STEP 7 - Draw Text string on the specified rectangle using Graphics object
//Define string format
StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
StringFormat format2 = new StringFormat(format1);
//Draw text string using the text format
graphics.DrawString(Text, font, Brushes.Black, (RectangleF)displayRectangle, format2);
//STEP 8 - Send the bitmap to page output stream in JPEG format

        
bitmap.Save( Server.MapPath(@"/")+"PraNKMSG"+ number+".JPG");
}
}



