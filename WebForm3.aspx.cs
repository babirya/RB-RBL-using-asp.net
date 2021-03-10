using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing; 

namespace app2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedValue=="rouge")
            {
                Panel1.BackColor = Color.Red; 
            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                Panel1.BackColor = Color.Green;
            }
            if (RadioButtonList1.SelectedValue == "blue")
            {
                Panel1.BackColor = Color.Blue; 

            }  

           

        }
    }
}