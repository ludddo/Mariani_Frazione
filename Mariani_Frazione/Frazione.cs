using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private int MCD(int a, int b)
        {
            if (b == 0) return a;

            return MCD(b, a % b);
        }

        private int MCM(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public Frazione Semplifica(Frazione frazione)
        {
            Frazione ritorno = new Frazione();

            int mcd = MCD(frazione.Numeratore, frazione.Denominatore);

            ritorno.Numeratore  = frazione.Numeratore / mcd;
            ritorno.Denominatore = frazione.Denominatore / mcd;

            return ritorno;
        }

        public Frazione Somma(Frazione frazione1, Frazione frazione2)
        {

            Frazione ritorno = new Frazione();

            int numeratore1 = frazione1.Numeratore;
            int denominatore1 = frazione1.Denominatore;

            int numeratore2 = frazione2.Numeratore;
            int denominatore2 = frazione2.Denominatore;

            if (denominatore1 == denominatore2) { numeratore1 += numeratore2; }
            else 
            { 
                int mcm = MCM(denominatore1, denominatore2);
                
                ritorno.Denominatore = mcm;
                ritorno.Numeratore = numeratore1 + numeratore2;
            }

            return Semplifica(ritorno);
        }

        public Frazione Sottrai(Frazione frazione1, Frazione frazione2)
        {
            Frazione ritorno = new Frazione();

            int numeratore1 = frazione1.Numeratore;
            int denominatore1 = frazione1.Denominatore;

            int numeratore2 = frazione2.Numeratore;
            int denominatore2 = frazione2.Denominatore;

            if (denominatore1 == denominatore2) { numeratore1 -= numeratore2; }
            else
            {
                int mcm = MCM(denominatore1, denominatore2);

                ritorno.Denominatore = mcm;
                ritorno.Numeratore = numeratore1 - numeratore2;
            }

            return Semplifica(ritorno);
        }

        public Frazione Moltiplica(Frazione frazione1, Frazione frazione2)
        {
            Frazione ritorno = new Frazione();

            int numeratore1 = frazione1.Numeratore;
            int denominatore1 = frazione1.Denominatore;

            int numeratore2 = frazione2.Numeratore;
            int denominatore2 = frazione2.Denominatore;

            ritorno.Numeratore = frazione1.Numeratore * frazione2.Numeratore;
            ritorno.Denominatore = frazione1.Denominatore * frazione2.Denominatore;

            return Semplifica(ritorno);
        }

        public Frazione Dividi(Frazione frazione1, Frazione frazione2)
        {
            Frazione ritorno = new Frazione();

            int numeratore1 = frazione1.Numeratore;
            int denominatore1 = frazione1.Denominatore;

            int numeratore2 = frazione2.Numeratore;
            int denominatore2 = frazione2.Denominatore;

            ritorno.Numeratore = frazione1.Numeratore * frazione2.Denominatore;
            ritorno.Denominatore = frazione1.Denominatore * frazione2.Numeratore;

            return Semplifica(ritorno);
        }
    }
}