using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyArbete
{
    class tid
    {
        int år = 0;
        int månad = 0;
        int dag = 0;
        int timme = 0;
        int minut = 0;



        public tid(int År, int Månad, int Dag, int Timme, int Minut)
        {
            år = År;
            månad = Månad;
            dag = Dag;
            timme = Timme;
            minut = Minut;
        }


        public string toString()
        {
            DateTime alarm = DateTime.Parse(år + "-" + månad + "-" + dag + " " + timme + ":" + minut);
            return alarm.ToString();
            
        }

        public int År
        {
            get { return år; }
            set { år = År; }
        }

        public int Månad
        {
            get { return månad; }
            set { månad = Månad; }
        }

        public int Dag
        {
            get { return dag; }
            set { dag = Dag; }
        }

        public int Timme
        {
            get { return timme; }
            set { timme = Timme; }
        }

        public int Minut
        {
            get { return minut; }
            set { minut = Minut; }
        }
    }
}
