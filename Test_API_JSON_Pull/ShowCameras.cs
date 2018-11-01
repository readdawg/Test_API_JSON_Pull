using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_API_JSON_Pull
{
    class ShowCameras
    {

        static ShowCameras()
        {

            using (var webClient = new System.Net.WebClient())
            {
                String rawJSON = webClient.DownloadString("http://10.10.0.28:9000/api/v1/cameras");
                CameraCollection cameraCollection = JsonConvert.DeserializeObject<CameraCollection>(rawJSON);
                //return table;
                Console.WriteLine(cameraCollection.Cameras.Count);

                //Parsed objects from JSON to static collection
                AllCameras = cameraCollection.Cameras;
            }
        }




        private static List<Camera> allCameras;

        internal static List<Camera> AllCameras { get => allCameras; set => allCameras = value; }

        public static List<Camera> GetCameras()
        {
            return AllCameras;          
        }


    }
}
