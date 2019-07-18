using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public bool  ValidationXML(string fileName)
    {
        string fileNameWithoutExtention = fileName.Split('.')[0];

        if (fileNameWithoutExtention == "valid")
        {
            Context.Response.Status = "200 ok";
            Context.Response.StatusCode = 200;
            Context.ApplicationInstance.CompleteRequest();
            return true;
        }
        else
        {
            Context.Response.Status = "500 !internal serval error";
            Context.Response.StatusCode = 500;
            Context.ApplicationInstance.CompleteRequest();
            return false;
        }
    }
}