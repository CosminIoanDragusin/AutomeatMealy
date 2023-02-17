using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP_L01_AutomatMealy
{
    class AutomatMealy : AutomatMealyAbstract
    {
        public AutomatMealy(functie fi, functie gi) : base(fi, gi) { }

        public override string evolutie(string stareInitiala, string stringIntrare)
        {
            String stare, sir = null;
            int lungime = stringIntrare.Length;

            for (int i = 0; i < lungime; i++)
            {
                sir += stareInitiala;
                sir += "-> ";
                sir += stringIntrare.Substring(0, 1);
                sir += "-> f=";
                stare = f(stareInitiala, stringIntrare);
                sir += stare;
                sir += ",g=";
                sir += g(stareInitiala, stringIntrare.Substring(0, 1));
                sir += "\n";
                stringIntrare = stringIntrare.Substring(1);
                stareInitiala = stare;
            }
            return sir;
        }

        public override string f(string stare, string intrare)
        {
            return ff.calcul(ref stare, intrare);
        }

        public override string g(string stare, string intrare)
        {
            return gg.calcul(ref stare, intrare);
        }
    }
}
