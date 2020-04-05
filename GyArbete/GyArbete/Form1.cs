using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;


namespace GyArbete
{
    public partial class Form1 : Form
    {





        /* 
          TODO:
          man ska kunna välda vilket år, men det ska automatiskt välja det nuvarande året, samma med månad och dag. Det skå också stå i rutorna.
          När man stänger programmet ska alarmen sparas. KOLLA PÅ KAPITEL 4 I BOKEN

          Det ska inte gå att skapa alarmet utan att lägga till alla delar (År, Månad, Dag, timme, minut). 
          Det ska inte gå att ha fler än 12 månader, 31 dagar, 24, timmar, 60 min.
          Det ska vara en lista som visar alla alarm och det ska gå att ta bort dem
          Det ska gå att ändra alarm 
          Ifall man lägger ett alarm på en tid som redan hänt eller den nuvarande tiden ska det inte fungera


          Hitta ett sätt att skriva ut alarmen som stringar, ex 22 Februari 2020 Kl 19.00
          Hitta ett sätt att inte inkludera sekunder.


          // ANVÄND SETTINGS.settings ??????
          Programmet ska köra hela tiden, även om man stänger av datorn ska programmet starta automatiskt och komma ihåg alla alarm
          Du måste hitta ett sätt att läsa in alarm i variabler som inte tömms efter programmet stängs
          Använd Windows Service? https://docs.microsoft.com/en-us/dotnet/framework/windows-services/introduction-to-windows-service-applications?redirectedfrom=MSDN 
          https://www.youtube.com/watch?v=JcJ047nm41Q 

          När alarmet går av ska det poppa upp en ruta och göra ett ljud.


          /*
          DateTime tidd = Convert.ToDateTime("2019-11-20 9:48:20"); // Ställ in vilken tid som alarmet ska gå av
          for (int i = 0; i < 1;)
          {
              DateTime tid = DateTime.Now;
              int s = DateTime.Compare(tid, tidd);

              if (s == 1) // När det är ett är tiden = alarmet eller senare än alarmet
              {
                  MessageBox.Show("ALARM");
                  break;
              }

          }
          */

        List<tid> alarmLista = new List<tid>();


        public Form1()
        {
            InitializeComponent();
        }

        public void uppdatera()
        {
            lbxalarmLista.Items.Clear();
            for (int i = 0; i < alarmLista.Count; i++)
            {

                lbxalarmLista.Items.Add(alarmLista[i].toString());
            }
        }

        private void bntNyttAlarm_Click(object sender, EventArgs e)
        {
            if (pnlNyttAlarm.Height == 38)
            {
                pnlNyttAlarm.Height = 193;
            }
            else
            {
                pnlNyttAlarm.Height = 38;
            }

            tbxNyÅr.Text = DateTime.Now.Year.ToString();
            tbxNyMånad.Text = DateTime.Now.Month.ToString();
            tbxNyDag.Text = DateTime.Now.Day.ToString();

            // Fixa så att år, månad och dag automatiskt väljer den nuvarnde dagen OCH att de inte kan sättas som tidigare än idag
        }


        private void tbxStällAlarm_Click(object sender, EventArgs e)
        {
        
            // Fixa så att det inte går att ha felaktiga värden, ex månad 23

            // Kollar ifall alla rutor har ett värde eller inte
            if (tbxNyÅr.Text == "" || tbxNyMånad.Text == "" || tbxNyDag.Text == "" || tbxNyTimme.Text == "" || tbxNyMinut.Text == "")
            {
                MessageBox.Show("Alla rutor måste vara ifyllda");
            }

            // Om alla rutor har ett värde körs resten av koden
            else
            {
                int år = int.Parse(tbxNyÅr.Text);
                int månad = int.Parse(tbxNyMånad.Text);
                int dag = int.Parse(tbxNyDag.Text);
                int timme = int.Parse(tbxNyTimme.Text);
                int minut = int.Parse(tbxNyMinut.Text);

                // Konverterar värderna till en användbar datetime variabel
                DateTime Alarm = Convert.ToDateTime(år + "-" + månad + "-" + dag + " " + timme + ":" + minut);

                // Kollar ifall den nuvarande tiden är senare än det nya alarmet. ex det går inte att ställa ett alarm år 1843
                if (DateTime.Now < Alarm)
                {
                    //Lägger in alarmet i listan och lägger fram det i textrutan
                    tid nyttAlarm = new tid(år, månad, dag, timme, minut);
                    alarmLista.Add(nyttAlarm);
                    lbxalarmLista.Items.Add(nyttAlarm.toString());


                }
                else
                {
                    // Fixa en ett snyggare flemedelande
                    // Ifall tiden är tidigare än nu avslutas funktionen och användaren får ett errormedelande
                    MessageBox.Show("Du kan inte väja ett alarm på en dag som redan varigt");
                }
            }
        }

        // När exit knappen trycks stängs programmet av
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
        private void lbxalarmLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnTaBort.Enabled = true;
        }


        private void BtnTaBort_Click(object sender, EventArgs e)
        {
            // Fixa så att knappen stängs av igen om ett alarm inte är valt 
            int index = lbxalarmLista.SelectedIndex;        
            alarmLista.RemoveAt(index);
            uppdatera();            
        }

        private void btnTaBortAlla_Click(object sender, EventArgs e)
        {
            // Fixa så att det inte går att ta bort alla om det inte finns någon
            alarmLista.Clear();
            uppdatera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
