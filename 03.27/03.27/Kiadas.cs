using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._27
{
    internal class Kiadas
    {
        public int ev;
        public string orszag;
        public string cim;
        public int darab;
        

        public string Cim { get => cim; set => cim = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int Darab { get => darab; set => darab = value; }
        public int Ev{ get => ev; set => ev = value; }


        public Kiadas(string cim,string szerzo,int darab, int ev)
        {
            this.ev = ev;
            this.orszag = orszag;
            this.cim = cim;
            this.darab = darab;
           
        } 
        

    }
}
