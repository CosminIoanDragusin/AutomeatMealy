using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP_L01_AutomatMealy
{
    public abstract class AutomatMealyAbstract
    {
        public functie ff;
        public functie gg;
        public AutomatMealyAbstract(functie fi, functie gi)
        {
            ff = fi;
            gg = gi;
        }
        public abstract String f(String stare, String intrare);
        public abstract String g(String stare, String intrare);

        public abstract String evolutie(String stareInitiala, String stringIntrare);
    }
}
