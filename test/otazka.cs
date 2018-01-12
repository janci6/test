using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class otazka
    {
        public string text;
        private moznost[] moznosti;

        public moznost[] Moznosti
        {
            get
            {
                return moznosti;
            }
            set
            {
                moznosti = value;
            }
        }
        public moznost[] odpovede;
        public void vypisotazku()
        {
            Console.WriteLine(text);
            Console.WriteLine("--------------");
            foreach(moznost m in moznosti)
            {
                Console.WriteLine(m.text);
            }
        }
    }
    class singleotazka : otazka
    {
    }
    class multipleotazka : otazka
    {

    }
}
