using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_API_JSON_Pull
{
    class Camera
    {
        //Declare JSON fields
        int ID;
        string Name;
        string IPAddress;
        int ServerID;
        string CameraType;
        string DataType;
        bool Is360;
        bool IsPtz;

        //Encapsulate fields
        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string IPAddress1 { get => IPAddress; set => IPAddress = value; }
        public int ServerID1 { get => ServerID; set => ServerID = value; }
        public string CameraType1 { get => CameraType; set => CameraType = value; }
        public string DataType1 { get => DataType; set => DataType = value; }
        public bool Is3601 { get => Is360; set => Is360 = value; }
        public bool IsPtz1 { get => IsPtz; set => IsPtz = value; }
    }
}
