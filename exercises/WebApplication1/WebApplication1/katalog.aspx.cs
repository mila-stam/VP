using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class katalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbKategorii.Items.Add(new ListItem("StruchnaLiteratura"));
                lbKategorii.Items.Add(new ListItem("NauchnaFantastika"));
                lbKategorii.Items.Add(new ListItem("Spisanija"));
            }
        }

        protected void btOdberi_Click(object sender, EventArgs e)
        {
            
            switch (lbKategorii.SelectedIndex)
            {
                case 0:
                    string[] sl =
                {
                    "Kniga1",
                    "Kniga2",
                    "Kniga3",
                    "Kniga4",
                    "Kniga5",
                };
                    string[] sl_c =
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                };

                    Session[lbKategorii.SelectedValue.ToString()] = sl;
                    Session[lbKategorii.SelectedValue.ToString() + "1"] = sl_c;
                    Response.Redirect("proizvodi.aspx?name=" + lbKategorii.SelectedValue);
                    break;
                case 1:
                    string[] nf =
                {
                    "Kniga11",
                    "Kniga22",
                    "Kniga33",
                    "Kniga44",
                    "Kniga55",
                };

                    string[] nf_c =
                    {
                    "11",
                    "22",
                    "33",
                    "44",
                    "55",
                };
                    Session[lbKategorii.SelectedValue.ToString()] = nf;
                    Session[lbKategorii.SelectedValue.ToString() + "1"] = nf_c;
                    Response.Redirect("proizvodi.aspx?name=" + lbKategorii.SelectedValue);
                    break;
                case 2:
                    string[] sp =
                {
                    "Kniga111",
                    "Kniga222",
                    "Kniga333",
                    "Kniga444",
                    "Kniga555",
                };

                    string[] sp_c =
                    {
                    "111",
                    "222",
                    "333",
                    "444",
                    "555",
                };
                    Session[lbKategorii.SelectedValue.ToString()] = sp;
                    Session[lbKategorii.SelectedValue.ToString() + "1"] = sp_c;
                    Response.Redirect("proizvodi.aspx?name=" + lbKategorii.SelectedValue);
                    break;
            }
        }
    }
}