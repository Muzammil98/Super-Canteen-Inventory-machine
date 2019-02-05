using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System_2
{
    class Foods_Drinks
    {
        double MnC_Fries, GnS_Fries, Cus_Fries, Zinger, Rice, Ice_Tea, Green_Tea, Coffee, Water, ColdDrink;

        public Foods_Drinks()
        {
            MnC_Fries = 0.0;
            GnS_Fries = 0.0;
            Cus_Fries = 0.0;
            Zinger = 0.0;
            Rice = 0.0;
            Ice_Tea = 0.0;
            Green_Tea = 0.0;
            Coffee = 0.0;
            Water = 0.0;
            ColdDrink = 0.0;
        }
        public Foods_Drinks(double MacNFries, double GarlFries, double CustmFries, double zinger, double rice, double iTea, double gTea, double coffe, double water, double drink)
        {
            MnC_Fries = MacNFries;
            GnS_Fries = GarlFries;
            Cus_Fries = CustmFries;
            Zinger = zinger;
            Rice = rice;
            Ice_Tea = iTea;
            Green_Tea = gTea;
            Coffee = coffe;
            Water = water;
            ColdDrink = drink;
        }
        
       

        
    }
}
