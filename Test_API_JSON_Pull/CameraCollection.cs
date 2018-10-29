using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_API_JSON_Pull
{
    class CameraCollection
    {

        private List<Camera> cameras;

        internal List<Camera> Cameras { get => cameras; set => cameras = value; }
    }
}
