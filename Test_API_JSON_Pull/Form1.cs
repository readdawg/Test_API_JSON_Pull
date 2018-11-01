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
            //dataGridView1.DataSource = jsonDataDisplay();


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


            //Create web client
            //using (var webClient = new WebClient())
            //{
            //    // Get string of JSON
            //    String rawJSON = webClient.DownloadString("http://10.10.0.28:9000/api/v1/cameras");

            //    //JavaScriptSerializer js = new JavaScriptSerializer();
            //    //ApiObjects[] persons = js.Deserialize<ApiObjects[]>(rawJSON);

            //    ////DataTable dtTmp = ConvertListToDataTable(persons);

            //    //List<KeyValuePair<string, string>> obj = persons//JavaScriptSerializer.Deserialize<List<KeyValuePair<string, string>>>(persons);

            //    //int j = 1;
            //    //for (j = 1; j < 10; j++)
            //    //{

            //    //    Console.WriteLine("Camera[{1}], Address[{2}]", j);

            //    //}

            //    //Convert JSON string to series of objects
            //    var objResponse1 = JsonConvert.DeserializeObject<List<RetrieveMultipleResponse>>(JsonStr);

            //    var objResponse2 = JsonConvert.DeserializeObject<List<List<People>>>


            //    var cameraCollection = JsonConvert.DeserializeObject<ApiObjects>(rawJSON);

            //    //var[] cameraArray = cameraCollection

            //    ////Do something with series of objects
            //    //Console.WriteLine(cameraCollection.Cameras.Count);
            //}

            //DataTable ConvertListToDataTable(List<string[]> persons)
            //{
            //    // New table.
            //    DataTable table = new DataTable();

            //    // Get max columns.
            //    int columns = 0;
            //    foreach (var array in persons)
            //    {
            //        if (array.Length > columns)
            //        {
            //            columns = array.Length;
            //        }
            //    }

            //    // Add columns.
            //    for (int i = 0; i < columns; i++)
            //    {
            //        table.Columns.Add();
            //    }

            //    // Add rows.
            //    foreach (var array in persons)
            //    {
            //        table.Rows.Add(array);
            //    }

            //    return table;
            //}


            //WebRequest request = WebRequest.Create("http://10.10.0.28:9000/api/v1/cameras");

            //WebResponse response = request.GetResponse();

            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            //// Get the stream containing content returned by the server.  
            //Stream dataStream = response.GetResponseStream();
            //// Open the stream using a StreamReader for easy access.  
            //StreamReader reader = new StreamReader(dataStream);
            //// Read the content.  
            //string responseFromServer = reader.ReadToEnd();
            //// Display the content.  
            //Console.WriteLine(responseFromServer);
            //// Clean up the streams and the response.  
            //reader.Close();
            //response.Close();
        }

        //private DataTable ConvertListToDataTable(ApiObjects[] persons)
        //{
        //    throw new NotImplementedException();
        //}
    }

        
    }
