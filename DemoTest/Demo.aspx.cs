using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTest
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLClass B = new BLClass();
            try
            {
                txtresult.Text = (B.Divide(txtnum.Text,txtdenom.Text)).ToString();
            }
            catch (DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
            catch(FormatException E)
            {
                Response.Write(E.Message);
            }


            //try
            //{
            //    txtresult.Text = (int.Parse(txtnum.Text) / int.Parse(txtdenom.Text)).ToString();
            //}
            //catch(DivideByZeroException e1)
            //{
            //    Response.Write(e1.Message);
            //}
        }
    }
}