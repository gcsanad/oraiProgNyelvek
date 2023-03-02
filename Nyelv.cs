using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public enum Nyelvcsaladok {moduláris, struktúrált, funkcionális, objektumorientált};
    public class Nyelv
    {
        public string neve;
        public bool forditosE;
        public int megjelenesEve;
        Nyelvcsaladok nyelvcsalad;
        public bool alacsonyszintesE;
        private int nepszeruseg2022;

        public Nyelv(string neve, bool forditosE, int megjelenesEve, Nyelvcsaladok nyelvcsalad, bool alacsonyszintesE, int nepszeruseg2022)
        {
            this.neve = neve;
            this.forditosE = forditosE;
            this.megjelenesEve = megjelenesEve;
            this.nyelvcsalad = nyelvcsalad;
            this.alacsonyszintesE = alacsonyszintesE;
            this.Nepszeruseg2022 = nepszeruseg2022;
        }

        public string Neve { get => neve; set => neve = value; }
        public bool ForditosE { get => forditosE; set => forditosE = value; }
        public int MegjelenesEve { get => megjelenesEve; set => megjelenesEve = value; }
        public Nyelvcsaladok Nyelvcsalad { get => nyelvcsalad; set => nyelvcsalad = value; }
        public bool AlacsonyszintesE { get => alacsonyszintesE; set => alacsonyszintesE = value; }
        public int Nepszeruseg2022 { get => nepszeruseg2022; set => nepszeruseg2022 = value; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns>Ha a legnépszerűbb 3ba tartozik</returns>
        public bool NepszeruE()
        {
            return this.Nepszeruseg2022 <= 3;

        }

    }
}
