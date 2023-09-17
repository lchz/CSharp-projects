using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PekingMastersGameApp
{
    public static class StatsDB
    {
        private const string dir = @"C:\Users\TestiPC\Documents\Study\CSharp\";
        private const string FILE_PATH = dir + "PekingMastersGameStats.txt";

        public static List<PkMatch> GetMatches()
        {
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Not exist");
                Directory.CreateDirectory(dir);
            }

            StreamReader textIn = new StreamReader(
                new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Read));

            List<PkMatch> matches = new List<PkMatch>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('\t');

                if (columns[0] == "" || !Int32.TryParse(columns[0], out int o))
                {
                    continue;
                }

                int season = Int32.Parse(columns[0]);
                int episode = Int32.Parse(columns[1]);
                DateTime date = DateTime.Parse(columns[2]);
                string day = columns[3];
                int matchNumber = Int32.Parse(columns[4]);
                string matchName = columns[5];
                int status= Int32.Parse(columns[6]);

                int love = Convert.ToInt32(Int32.TryParse(columns[7], out int i));
                string site = columns[8];
                string info = columns[9];

                PkMatch match = new PkMatch(season, episode, date, day, matchNumber, matchName, status, love);
                matches.Add(match);
            }

            textIn.Close();

            return matches;
        }

        // TODO: Write new match to File, and keep the format

    }
}
