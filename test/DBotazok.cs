using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DBotazok
    {
        public DBotazok()
        {
            singleotazka o = new singleotazka();
            o.text = "kolko je 1+1?";
            o.Moznosti = new moznost[]
            {
                new moznost("1",false),
                new moznost("2",true),
                new moznost("50",false)
            };
            otazky.Add(o);
            {
                multipleotazka m = new multipleotazka();
                m.text = "co je cislo?";
                m.Moznosti = new moznost[]
                {
                new moznost("oznac ano",false),
                new moznost("2",true),
                new moznost("50",true)
                };
                otazky.Add(m);
            }
            {
                o = new singleotazka();
                o.text = "kolko je 1+2?";
                o.Moznosti = new moznost[]
                {
                new moznost("1",false),
                new moznost("2",false),
                new moznost("50",true)
                };
                otazky.Add(o);
            }
        }
        public ArrayList otazky = new ArrayList();

    }
}
