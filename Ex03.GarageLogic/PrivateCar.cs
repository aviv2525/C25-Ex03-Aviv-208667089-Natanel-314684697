using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*namespace Ex03.GarageLogic
{
    class PrivateCar 
    {
        string[] m_Color = {"blue", "black","white","gray" };
        int[] m_DorsNumber = { 2, 3, 4, 5 };
        private Wheel[] m_PrivateWheels = new Wheel[4];


    }
}
*/

namespace Ex03.GarageLogic
{
    public class PrivateCar : Vehicle
    {
        public enum eColor { Blue, Black, White, Gray }
        public enum eDoorsNumber { Two = 2, Three, Four, Five }

        private eColor m_Color;
        private eDoorsNumber m_DoorsNumber;

        public PrivateCar(string model, string licensePlate, float energyPercentage, eColor color, eDoorsNumber doorsNumber)
            : base(model, licensePlate, energyPercentage)
        {
            m_Color = color;
            m_DoorsNumber = doorsNumber;
        }

        public eColor Color => m_Color;
        public eDoorsNumber DoorsNumber => m_DoorsNumber;
    }

}