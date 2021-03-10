using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing; 

namespace app2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = " "; 
            if(RadioButton1.Checked==true)
            {
                a = " tu est choose la couleur  rouge";
                Panel1.BackColor = Color.Red; 
            }
            if (RadioButton2.Checked == true)
            {
                a = " tu est choose la couleur blue";
                Panel1.BackColor = Color.Blue; 
            } 
            if (RadioButton3.Checked == true)
            {
                a = " tu est choose la couleur green";
                Panel1.BackColor = Color.Green; 
            }
            if (RadioButton4.Checked == true)
            {
                a = " tu est choose la couleur  yellow";
                Panel1.BackColor = Color.Yellow; 
            }
            if (RadioButton1.Checked == false && RadioButton2.Checked == false && RadioButton3.Checked == false && RadioButton4.Checked == false)
            {
                a = "please choose a color "; 
            }
            Response.Write(""+a); 
        }
    }
}