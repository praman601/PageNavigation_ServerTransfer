using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageNavigation_ServerTransfer
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection previousFormCollections = Request.Form;
            lblName.Text = previousFormCollections["txtName"];
            lblEmail.Text = previousFormCollections["txtEmail"];
        }
    }
}