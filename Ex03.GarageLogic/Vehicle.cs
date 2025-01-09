using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_Model;
        private string m_LicensePlate;
        private float m_EnergyPercentage; // כאן מוגדר המשתנה שחסר

        public string Model
        {
            get { return m_Model; }
            set { m_Model = value; }
        }

        public string LicensePlate
        {
            get { return m_LicensePlate; }
            set { m_LicensePlate = value; }
        }

        public float EnergyPercentage
        {
            get { return m_EnergyPercentage; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Energy percentage must be between 0 and 100.");
                }
                m_EnergyPercentage = value;
            }
        }

        public Vehicle(string model, string licensePlate, float energyPercentage)
        {
            m_Model = model;
            m_LicensePlate = licensePlate;
            EnergyPercentage = energyPercentage;
        }
    }
}

