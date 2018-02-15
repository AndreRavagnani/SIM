using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strJSON = JSONHelper.GetJSONString(
            ConfigurationManager.AppSettings[
                "URLClinicaSIM"]);

        RootObject roots = JsonConvert.DeserializeObject<RootObject>(strJSON);

        DropDownList1.DataSource = roots.specialtiesByClass[0].specialties;
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataBind();

        DropDownList2.DataSource = roots.specialtiesByClass[1].specialties;
        DropDownList2.DataTextField = "Name";
        DropDownList2.DataBind();

        int rxs = roots.specialtiesByClass[1].specialties.Where(x => x.name.ToUpper().Contains("RX")).Count();

        int us = roots.specialtiesByClass[1].specialties.Where(x => x.name.ToUpper().Contains("ULTRASSOM")).Count();

        Label1.Text = String.Format("Quantidade de RX's = {0}", rxs);

        Label2.Text = String.Format("Quantidade de Ultrassom's = {0}", us);


    }
}

