using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ej4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string checkedval = "";
            if (BondDeal.Checked)
            { checkedval = BondDeal.Text; }
            else if (RepoDeal.Checked)
            { checkedval = RepoDeal.Text; }
            else if (Otro.Checked)
            { checkedval = Otro.Text; }

            InventarioDataContext DB = new InventarioDataContext();
            Inventory Registros = new Inventory();

            switch (checkedval)
            {
                case "BondDeal":

                    Registros.DealName = txt_dealnameB.Text;
                    Registros.LocalId = Convert.ToInt16(txt_locId.Text);
                    Registros.Titles = txt_titulos.Text;
                    Registros.AvailableSince = txt_Sett.Text;

                    DB.Inventory.InsertOnSubmit(Registros);
                    DB.SubmitChanges();

                    txt_locId.Text = "";
                    txt_titulos.Text = "";
                    txt_Sett.Text = "";

                    break;

                case "RepoDeal":

                    Registros.DealName = txt_dealnameR.Text;
                    Registros.LocalId = Convert.ToInt16(txt_locId2.Text);
                    Registros.Titles = txt_titles.Text;
                    Registros.AvailableSince =  txt_stard.Text;

                    DB.Inventory.InsertOnSubmit(Registros);
                    DB.SubmitChanges();

                    txt_locId2.Text = "";
                    txt_titles.Text = "";
                    txt_stard.Text = "";

                    break;

                case "Otro":
                    Registros.DealName = txt_dealnameO.Text;
                    Registros.LocalId = Convert.ToInt16(txt_locIdO.Text);
                    Registros.Titles = txt_O_tit.Text;
                    Registros.AvailableSince = txt_OthStart.Text;

                    DB.Inventory.InsertOnSubmit(Registros);
                    DB.SubmitChanges();

                    txt_dealnameO.Text = "";
                    txt_locIdO.Text = "";
                    txt_O_tit.Text = "";
                    txt_OthStart.Text = "";

                    break;
                default:
                    break;
            }
        }
    }
}