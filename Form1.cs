using System.Text;

namespace LegeHenne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPath.Text = "kolophonium.csv";
        }

        private string createPulseForm(int hour, int minute)
        {
            // Hilfsroutine zur Erzeugung eines Pulses in Abhaengigkeit der Zeit.
            string strOpen;

            if (hour == 10 && (minute >= 20 && minute <= 30))
                strOpen = "202.000\t";
            else
                strOpen = "200.000\t";
            return strOpen;
        }
        private string createCosForm(int hour, int minute)
        {
            // Hilfsroutine zur Erzeugung eines cosinus in Abhaengigkeit der Zeit.

            int maxMinutes = 24 * 60; // Anzahl Minuten im 24 h Tag.
            int minutes;
            double angle;
            double erg;
            string strOpen;

            minutes = 60 * hour + minute;
            angle = 2 * Math.PI * minutes / maxMinutes;

            erg = Math.Cos(angle); // Schwankt zwischen -1 und +1

            // Werte sollen schwanken zwischen 202 und 198, Amplitude == 2
            erg *= 2 ;
            erg += 200;

            //´strOpen = erg.ToString() + ".000\t"; // 3 Nachkommastellen und Tab.
            strOpen = Convert.ToString(erg, System.Globalization.CultureInfo.InvariantCulture) + "\t";
            return strOpen;
        }
        private void cmdReadFromFile_Click(object sender, EventArgs e)
        {
            string ueberschrift = "<DATE>\t<TIME>\t<OPEN>\t<HIGH>\t<LOW>\t<CLOSE>\t<TICKVOL>\t<VOL>\t<SPREAD>";
            string strDayPrefix = "2025.02.";
            string strDayComplete;
            string strHour;
            string strMinute;
            string strSecond = "00";
            string strOpen;
            string strFormat = "00"; // Std, Minuten u. Secs sollen zweistellig sein.

            StringBuilder sb = new StringBuilder();

            List<string> list1 = new List<string>();
            list1.Add(ueberschrift);

            int erzeugteTicks = 0;

            for (int theDay = 18; theDay < 21; theDay++)
            {
                // Erzeuge die Tage 18 19 20.
                strDayComplete = strDayPrefix + theDay.ToString() + "\t";

                for (int hour = 0; hour < 24; hour++)
                {
                    for (int minute = 0; minute < 60; minute += 1)
                    {
                        sb.Clear();

                        sb.Append(strDayComplete);

                        strHour = hour.ToString(strFormat);

                        sb.Append(strHour).Append(':');

                        strMinute = minute.ToString(strFormat);

                        sb.Append(strMinute).Append(':');
                        sb.Append(strSecond).Append('\t');

                        // strOpen = createPulseForm( hour, minute );
                        strOpen = createCosForm(hour, minute);

                        for (int i = 0; i < 4; i++)
                            sb.Append(strOpen);
                        // sb.Append("280\t0\t30"); Fuer Spread == 30
                        sb.Append("280\t0\t00"); // Fuer Spread == 00

                        list1.Add(sb.ToString());
                        sb.Clear();
                    } // minute
                } // hour
            } // theDay

            erzeugteTicks = list1.Count;
            txtTicks.Text = erzeugteTicks.ToString();

            string myPath = txtPath.Text;
            File.WriteAllLines(myPath, list1);
        }
    }
}
