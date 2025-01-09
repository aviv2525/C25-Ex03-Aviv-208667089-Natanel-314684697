using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsTransportRefrigeratedMaterials;
        private float m_CargoVolume;

        public Truck(string model, string licensePlate, float energyPercentage, bool isRefrigerated, float cargoVolume)
            : base(model, licensePlate, energyPercentage) // קריאה לבנאי של Vehicle
        {
            m_IsTransportRefrigeratedMaterials = isRefrigerated;
            CargoVolume = cargoVolume;
        }

        public bool IsTransportRefrigeratedMaterials
        {
            get { return m_IsTransportRefrigeratedMaterials; }
            set { m_IsTransportRefrigeratedMaterials = value; }
        }

        public float CargoVolume
        {
            get { return m_CargoVolume; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cargo volume cannot be negative.");
                }
                m_CargoVolume = value;
            }
        }
    }

}
