using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class emlak
    {
        private string semt;
        private string renk;
        private int odaSayisi;
        private int katNo;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string RENK
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int ODA_SAYISI
        {
            get { return odaSayisi; }
            set { odaSayisi = Math.Abs(value); }
        }
        public int KAT_NO
        {
            get { return katNo; }
            set { katNo = Math.Abs(value); }
        }
        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }


    }
}
