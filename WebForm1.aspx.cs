using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 


namespace app2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // request >>> ask  pour quelque choose 
            // response >>> afficher
            string a = TextBox1.Text;
            string b = a.Substring(3, 4); 
            Response.Write(" bienvenue "+a);
            Response.Write(" bienvenue with a cut  " +b);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string b = a.Substring(int.Parse(TextBox2.Text), int.Parse(TextBox3.Text));

            Response.Write("part you cut is " + b); 

        }
    }
}