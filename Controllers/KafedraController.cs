using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using ISCW_MVC.Models;

namespace ISCW_MVC.Controllers
{
    public class KafedraController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Kafedra
        [HttpGet]
        public ActionResult Main()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=localhost; database=ISCW_MVC_DB; integrated security = SSPI;";
        }
        [HttpPost]

        public ActionResult GetNameKafedra(Kafedra kafName)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Kafedra where id_kaf='"+kafName.Id_kaf+"' kaf_name='"+kafName.KafName+"'";
            dr = com.ExecuteReader();




            return View();
            
        }
    }
}