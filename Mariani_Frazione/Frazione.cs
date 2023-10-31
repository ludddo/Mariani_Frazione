using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Frazione
{
    internal class Frazione
    {

        int _numeratore;
        int _denominatore;

        public int Numeratore { get { return _numeratore; } set { _numeratore = value; } }
        public int Denominatore { get { return _denominatore;} set { if (value != 0) _denominatore = value;} }

        public Frazione() { Numeratore = 0; Denominatore = 0; }

        public Frazione(int numeratore, int denominatore) { Numeratore = numeratore; Denominatore= denominatore; }

        public void Semplifica()
        {
            if((Numeratore/Denominatore))
        }
    }
}
