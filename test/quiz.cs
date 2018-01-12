using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class quiz
    {
        private otazka[] otazky;

        public quiz()
        {
            otazky = new otazka[2];
            DBotazok db = new DBotazok();
            Random r = new Random();
            ArrayList vybranecisla = new ArrayList();
            for(int i = 0; i < 2; i++)
            {
                int index;
                do
                {
                    index = r.Next(2);
                }
                while (vybranecisla.Contains(index));
                otazky[i] = (otazka)db.otazky[index];
                vybranecisla.Add(index);     
            }
        }
        public void spustquiz()
        {
            foreach (otazka o in otazky)
            {
                string uzivodpoved;
                o.vypisotazku();
                int[] poleuzivatelskychindexov;
                do
                {
                     uzivodpoved = Console.ReadLine();


                } while (!zkontrolujvstup(uzivodpoved,o,out poleuzivatelskychindexov));
                o.odpovede
            };
            Console.ReadKey();
        }
        private bool zkontrolujvstup(string uzivstup,otazka otazka,out int[] poleindexov)
        {
            poleindexov = null;
            int index;
            if(otazka is singleotazka)
            {
                bool res = jecisloajevindexe(uzivstup, otazka,out index);
                poleindexov = new int[] { index };
                return res;
            }
            else
            {
                string[] poleodpovediuziv = uzivstup.Split(' ');
                poleindexov = new int[poleodpovediuziv.Length];
                for(int i = 0; i < poleodpovediuziv.Length; i++)
                {
                    if (!jecisloajevindexe(poleodpovediuziv[i], otazka,out index)) return false;
                    poleindexov[i] = index;
                }
                return true;
            }
        }
        private bool jecisloajevindexe(string uzivatelskecislo,otazka otazka,out int index)
        {
            bool jecislo = int.TryParse(uzivatelskecislo, out index);
            if (!jecislo)
            {
                return false;
            }
            else
            {
                return (index > 0 && index < otazka.Moznosti.Length);
            }
        }
        
    }
}
