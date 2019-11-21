using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace Test_API_JSON_Pull
{
    public partial class Form1 : Form

        
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        



        
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable jsonDataDisplay()
            {
                using (var webClient = new WebClient())
                {
                    String rawJSON = webClient.DownloadString("http://10.10.0.28:9000/api/v1/cameras");
                    var table = JsonConvert.DeserializeObject<DataTable>(rawJSON);
                    return table;
                }
            }

            dataGridView1.DataSource = jsonDataDisplay();

            lb_cameras.DataSource = jsonDataDisplay();
            lb_cameras.DisplayMember = "Name";
            lb_cameras.ValueMember = "ID";
        }
    }        
}
