using ConsumiendoAPI.Controlador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumiendoAPI
{
    public partial class Form1 : Form
    {
        DBAPI dbApi = new DBAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dbApi.Get("https://sandbox.api.payulatam.com/payments-api/rest/v4.9/customers/60bb7tpho9i");
            nombreRecibir.Text = respuesta.fullName.ToString();
            correoRecibir.Text = respuesta.email.ToString(); 
            idRecibir.Text = respuesta.id.ToString(); 
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            /**usando variables**/
            //string json = "{\"fullName\": \""+nombreEnviar.Text+"\",\"email\": \""+correoEnviar.Text + "\"}";  

            /**usando la clase modelo para el json**/
            JsonCliente cliente = new JsonCliente
            {
                fullName = nombreEnviar.Text,
                email = correoEnviar.Text
            };
            string json = JsonConvert.SerializeObject(cliente);

            dynamic respuesta = dbApi.Post("https://sandbox.api.payulatam.com/payments-api/rest/v4.9/customers/", json);
            MessageBox.Show(respuesta.ToString());
            nombreRecibir.Text = respuesta.fullName.ToString();
            correoRecibir.Text = respuesta.email.ToString();
            idRecibir.Text = respuesta.id.ToString();
        }
    }

    /**clase que nos sirve de modelo para crear json**/
    public class JsonCliente
    {
        public string fullName { get; set; }
        public string email { get; set; }
    }
}
