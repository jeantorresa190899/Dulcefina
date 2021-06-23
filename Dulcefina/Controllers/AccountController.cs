using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dulcefina.Models;

namespace Dulcefina.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "Data Source=LENOVO-X220;Initial Catalog=PASTELERIA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        [HttpPost]
        public ActionResult Verify(Cliente acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            
            com.CommandText = "select correo, contrasena from Cliente where correo='" + acc.Correo + "' and contrasena='" + acc.Contrasena + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
               /* var nom = com.CommandText;
                nom= "select nombre from cliente where correo='" + acc.Correo + "'";
                HttpContext.Session.SetString("nom", nom);*/

                con.Close();
                return RedirectToAction("Index","Principal");
            }
            else
            {
                con.Close();
                return RedirectToAction("log", "Principal");
            }
        }
    }
}
