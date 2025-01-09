using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType { A1, A2, B1, B2 }

        private eLicenseType m_LicenseType;
        private int m_EngineDisplacementCc;

        public Motorcycle(string model, string licensePlate, float energyPercentage, eLicenseType licenseType, int engineDisplacement)
            : base(model, licensePlate, energyPercentage)
        {
            m_LicenseType = licenseType;
            m_EngineDisplacementCc = engineDisplacement;
        }

        public eLicenseType LicenseType => m_LicenseType;
        public int EngineDisplacementCc => m_EngineDisplacementCc;
    }

}