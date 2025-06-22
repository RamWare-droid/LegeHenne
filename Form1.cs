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

                        if (hour == 10 && (minute >= 20 && minute <= 30))
                            strOpen = "202.000\t";
                        else
                            strOpen = "200.000\t";

                        for (int i = 0; i < 4; i++)
                            sb.Append(strOpen);

                        sb.Append("280\t0\t30");
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
