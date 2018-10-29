using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_API_JSON_Pull
{
    class ApiObjects
    {

        public class CameraTransferObject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string IPAddress { get; set; }
            public int ServerID { get; set; }
            public string CameraType { get; set; }
            public string DataType { get; set; }
            public bool Is360 { get; set; }
            public bool IsPtz { get; set; }
        }

    }
}
