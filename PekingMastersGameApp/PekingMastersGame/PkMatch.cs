using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace PekingMastersGameApp
{
    public class PkMatch
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public int MatchNumber { get; set; }
        public string MatchName { get; set; }
        public int Status { get; set; }
        public int Love { get; set; }
        public string Site { get; set; }
        public string Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="season"></param>
        /// <param name="episode"></param>
        /// <param name="date"></param>
        /// <param name="day">第X天</param>
        /// <param name="matchNumber">第X局</param>
        /// <param name="matchName">板子</param>
        /// <param name="status">输赢状态，赢=1, 输=0</param>
        /// <param name="love">是否喜爱</param>
        /// <param name="site">网站</param>
        /// <param name="info">Additional info</param>
        public PkMatch(int season, int episode, DateTime date, string day, int matchNumber, string matchName, int status, int love=0, string site="", string info = "")
        {
            this.Season = season;
            this.Episode = episode; 
            this.Date = date;
            this.Day = day;
            this.MatchNumber = matchNumber;
            this.MatchName = matchName;
            this.Status = status;
            this.Love = love;
            this.Site = site;
            this.Info = info;
        }
    }
}
