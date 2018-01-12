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
                o.vypisotazku();
                do
                {
                    string uzivodpoved = Console.ReadLine();


                } while ();
            }
            Console.ReadKey();
        }
        private bool zkontrolujvstup(string uzivstup,otazka otazka)
        {
            if(otazka is singleotazka)
            {
                int indexodpovede;
                bool jecislo = int.TryParse(uzivstup, out indexodpovede);
                if (!jecislo)
                {
                    return false;
                }
                else
                {
                    return (indexodpovede > 0 && indexodpovede < otazka.Moznosti.Length);
                }
            }
            else
            {
                
            }
        }
        
    }
}
