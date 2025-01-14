using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    class Garage 
    {
    private Dictionary<string, Garage> m_Vehicles; // מס רכב ו VEHICLE
        public Garage()
        {
            m_Vehicles = new Dictionary<string, Garage>();
        }
    }
}
