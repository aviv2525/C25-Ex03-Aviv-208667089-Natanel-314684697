using System;
namespace Ex03.GarageLogic
{
    public class DriveByFuel
    {
        public enum eFuelType { Octan95, Octan96, Octan98, Soler }
        private eFuelType m_FuelType;
        private float m_FuelRemain;
        private float m_FuelMax;
        public DriveByFuel(eFuelType fuelType, float fuelMax)
        {
            m_FuelType = fuelType;
            m_FuelMax = fuelMax;
            m_FuelRemain = 0;
        }

        public void AddFuel(float amount)
        {
            if (m_FuelRemain + amount > m_FuelMax)
            {
                throw new ArgumentException("Cannot exceed max fuel capacity.");
            }
            m_FuelRemain += amount;
        }
    }
}
