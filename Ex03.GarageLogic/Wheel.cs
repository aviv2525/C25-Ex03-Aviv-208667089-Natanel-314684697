using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrentAirPressure;
        private readonly float m_MaxAirPressure;

        public Wheel(string manufacturerName, float maxAirPressure)
        {
            m_ManufacturerName = manufacturerName;
            m_MaxAirPressure = maxAirPressure;
            m_CurrentAirPressure = 0;
        }

        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set
            {
                if (value < 0 || value > m_MaxAirPressure)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Air pressure must be within valid range.");
                }
                m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
        }

        public void AddAir(float airAmount)
        {
            if (m_CurrentAirPressure + airAmount > m_MaxAirPressure)
            {
                throw new ArgumentException("Cannot exceed max air pressure.");
            }
            m_CurrentAirPressure += airAmount;
        }
    }
}
