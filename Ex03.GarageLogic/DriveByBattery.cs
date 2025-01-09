using System;
namespace Ex03.GarageLogic
{
    public class DriveByBattery
    {
        private float m_TimeRemain;
        private float m_MaxTime;

        public DriveByBattery(float maxTime)
        {
            m_MaxTime = maxTime;
            m_TimeRemain = 0;
        }

        public void Charge(float timeToCharge)
        {
            if (m_TimeRemain + timeToCharge > m_MaxTime)
            {
                throw new ArgumentException("Battery cannot exceed max charge time.");
            }
            m_TimeRemain += timeToCharge;
        }
    }
}
