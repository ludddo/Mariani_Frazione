using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_Frazione
{
    internal class FrazioneEstesa : Frazione
    {
        public FrazioneEstesa() : base() { }

        public int FrazioneToDecimale(Frazione frazione)
        {
            int decimale = frazione.Numeratore / frazione.Denominatore;

            return decimale;
        }

        public Frazione DecimaleToFrazione(int decimale)
        {
            Frazione ritorno = new Frazione();

            string stringaDec = decimale.ToString();
            string a = "0," + stringaDec.Split(',')[1];

            ritorno.Denominatore = int.Parse(Math.Round(1 / double.Parse(a)).ToString());
            ritorno.Numeratore = (int.Parse(stringaDec.Split(',')[0]) * ritorno.Denominatore) + 1;

            return ritorno;
        }

        public Frazione Potenza(int potenza, Frazione frazione) 
        {
            Frazione ritorno = new Frazione();

            ritorno.Numeratore = frazione.Numeratore^potenza;
            ritorno.Denominatore = frazione.Denominatore^potenza;

            return ritorno;

        }
    }
}