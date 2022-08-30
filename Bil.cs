using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Bil
    {
        private string modell;
        private string tillverkare;
        private int årsmodell;
        private int vikt;

        public Bil(string m, string t, int å, int v)
        {
            modell = m;
            tillverkare = t;
            årsmodell = å;
            vikt = v;
        }

        public string Modell {

            set{ modell = value; }
            get{ return modell; }

        }
        
        public string Tillverkare {

            set{ tillverkare = value; }
            get{ return tillverkare; }
        }

        public int Årsmodell {

            set{ årsmodell = value; }
            get{ return årsmodell; }
        }

        public int Vikt {

            set{ vikt = value; }
            get{ return vikt; }
        }


       /* public void setModell(string M) { modell = M; }
        public string getModell() { return modell; }
        public void setTillverkare(string t) { tillverkare = t; }
        public string getTillverkare() {return tillverkare; }
        public void setÅrsmodell(int å) { årsmodell = å; }
        public int getÅrsmodell() { return årsmodell; }
        public void setVikt(int v) { vikt = v; }
        public int getVikt() { return vikt;}*/
    }