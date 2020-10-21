using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ConsumiendoAPI.Controlador
{
    class DBAPI
    {
        public dynamic Post(string url, string json)
        {
            try
            {
                var cliente = new RestClient(url);
                var solicitud = new RestRequest(Method.POST);
                solicitud.AddHeader("Content-Type", "application/json; charset=utf-8");
                solicitud.AddHeader("Accept", "application/json");
                solicitud.AddHeader("Authorization", "Basic cFJSWEtPbDhpa01tdDl1OjRWajhlSzRybG9VZDI3Mkw0OGhzcmFyblVB");
                solicitud.AddParameter("application/json",json, ParameterType.RequestBody);

                IRestResponse respuesta = cliente.Execute(solicitud);

                dynamic datos = JsonConvert.DeserializeObject(respuesta.Content);

                return datos;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public dynamic Get(string url)
        {
            
            try
            {
                var cliente = new RestClient(url);
                var solicitud = new RestRequest(Method.GET);
                solicitud.AddHeader("Content-Type", "application/json; charset=utf-8");
                solicitud.AddHeader("Accept", "application/json");
                solicitud.AddHeader("Authorization", "Basic cFJSWEtPbDhpa01tdDl1OjRWajhlSzRybG9VZDI3Mkw0OGhzcmFyblVB");
                

                IRestResponse respuesta = cliente.Execute(solicitud);

                dynamic datos = JsonConvert.DeserializeObject(respuesta.Content);

                return datos;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
