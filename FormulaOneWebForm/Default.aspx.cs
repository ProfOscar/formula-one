using FormulaOneDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulaOneWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Inizializzazioni che vengono eseguite solo la prima volta che carico la pagina
                // lblMessaggio.Text = "DIGITA USERNAME E PASSWORD, POI PREMI IL PULSANTE INVIA";
                lbxNazioni.Visible = false;
                lblMessaggio.Text = "Premi il pulsante INVIA, apparirà la griglia dei team e la lista delle nazioni gestite.";
            }
            else
            {
                // Elaborazioni da eseguire tutte le volte che la pagina viene ricaricata
                // lblMessaggio.Text = "Benvenuto al sig. " + txtUserName.Text;
                // Riempio la lista nazioni
                DBtools myTools = new DBtools();
                dgvTabella.DataSource = myTools.GetDataTable("Team");
                dgvTabella.DataBind();
                lbxNazioni.DataSource = myTools.GetCountries();
                lbxNazioni.DataBind();
                lbxNazioni.Visible = true;
            }
        }
    }
}