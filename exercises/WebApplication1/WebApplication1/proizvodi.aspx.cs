using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class proizvodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblKategorija.Text = Request.QueryString["name"];

                string[] naslovi = Session[Request.QueryString["name"]] as string[];
                string[] ceni = Session[Request.QueryString["name"] + "1"] as string[];

                lbNaslovi.DataSource = naslovi;
                lbNaslovi.DataBind();

                lbCeni.DataSource = ceni;
                lbCeni.DataBind();

            }
        }

        protected void btnDodadi_Click(object sender, EventArgs e)
        {
            ArrayList list;
            if (Session["korpa"] == null)   //proveruva dali postoi sesija korpa
            {
                list = new ArrayList();     //ako ne postoi kreira nova lista
            }
            else
            {
                list = (ArrayList)Session["korpa"];   //ako sesijata postoi podatocite od taa sesija gi smestuva vo lista
            }
            lbCeni.SelectedIndex = lbNaslovi.SelectedIndex;
            list.Add(new ListItem(lbNaslovi.SelectedItem.Text, lbCeni.SelectedIndex.ToString()));   //vo listata se dodava novo selektiraniot element so vradnosta
            lbKorpa.DataTextField = "Text";  //vo listBoxot Korpa kazhuvame deka Text poleto od ListItem treba da se prikazhuva
            lbKorpa.DataValueField = "Value";  //a toa shto e vrednost na ListItem da se chuva kako value

            lbKorpa.DataSource = list;    //se zemaat vrednostite od list
            lbKorpa.DataBind();          //se stavaat vo list boxot korpa za da se prikazhuvaat

            Session["korpa"] = list;    //novata lista so dodadeniot element se stava vo sessijata

            if (Session["total"] == null)
            {
                Session["total"] = Convert.ToInt32(lbCeni.SelectedValue);
            }
            else
            {
                Session["total"] = Convert.ToInt32(Session["total"]) + Convert.ToInt32(lbCeni.SelectedValue);
            }
            lblVkupno.Text = Session["total"].ToString();
        }

        protected void lbNaslovi_selectedIndex(object sender, EventArgs e)
        {
            if (ViewState["selected"] == null)
            {
                ViewState["selected"] = 1;
            }
            else
            {
                ViewState["selected"] = (int)ViewState["selected"] + 1;
            }
            lblSelected.Text = ViewState["selected"].ToString();

            lbCeni.SelectedIndex = lbNaslovi.SelectedIndex;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("katalog.aspx");
        }
    }
}