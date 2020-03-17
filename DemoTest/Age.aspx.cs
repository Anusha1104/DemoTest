using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTest
{
    public partial class Age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            BLClass b = new BLClass();
            try
            {
                txtage.Text = (b.Age(dtdob.Text)).ToString();
            }
            catch(CustomException E)
            {
                Response.Write(E.Message);
            }

        }
    }
}