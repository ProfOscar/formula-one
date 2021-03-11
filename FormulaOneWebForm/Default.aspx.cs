using FormulaOneDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
                GetCountry();
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

        public void GetCountry(string isoCode = "")
        {
            HttpWebRequest apiRequest = WebRequest.Create("https://localhost:44308/api/Country/" + isoCode + "") as HttpWebRequest;
            string apiResponse = "";
            try
            {
                using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    apiResponse = reader.ReadToEnd();
                    // var oCountry = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(apiResponse);
                    Country[] oCountry = Newtonsoft.Json.JsonConvert.DeserializeObject<Country[]>(apiResponse);
                    lbxNazioni.DataSource = oCountry;
                    lbxNazioni.DataBind();
                    lbxNazioni.Visible = true;
                }
            }
            catch (System.Net.WebException ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}