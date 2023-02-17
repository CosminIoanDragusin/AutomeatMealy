using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP_L01_AutomatMealy
{
    class fc : functie
    {
        public string calcul(ref string stare, string intrare)
        {
            switch (Convert.ToInt16(stare))
            {
                case 1:
                    if (intrare.Substring(0, 1).Equals("a"))
                    {
                        stare = 2.ToString();
                    }
                    break;
                case 2:
                    if (intrare.Substring(0, 1).Equals("a"))
                    {
                        stare = 3.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("b"))
                    {
                        stare = 4.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("c"))
                    {
                        stare = 5.ToString();
                    }
                    break;
                case 3:
                    if (intrare.Substring(0, 1).Equals("a"))
                    {
                        stare = 3.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("b"))
                    {
                        stare = 4.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("c"))
                    {
                        stare = 5.ToString();
                    }
                    break;
                case 4:
                    if (intrare.Substring(0, 1).Equals("a"))
                    {
                        stare = 3.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("b"))
                    {
                        stare = 4.ToString();
                    }
                    if (intrare.Substring(0, 1).Equals("c"))
                    {
                        stare = 5.ToString();
                    }
                    break;
                case 5:
                    break;
            }
            return stare;
        }
    }
}
