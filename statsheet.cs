using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppg
{
    internal class statsheet// : INotifyPropertyChanged
    {
        #region fields

        #region stats
        private int _mindexerity = 1;
        private int _dexerity;
        private int _maxdexerity = 20;
        private int _minintelligence = 1;
        private int _intelligence;
        private int _maxintelligence = 20;
        private int _minstrength = 1;
        private int _strength;
        private int _maxstrength = 20;
        private int _minwisdom = 1;
        private int _wisdom;
        private int _maxwisdom = 20;
        private int _minluck = 1;
        private int _luck;
        private int _maxluck = 20;
        private int _mincharizzma = 1;
        private int _charizzma;
        private int _maxcharizzma = 20;
        #endregion
        private List<statsheet> _partyMembers = new List<statsheet>();

        private CharacterClasses _characterClass = CharacterClasses.None;
        private Random rng = new Random();
        #endregion

        #region properties
        public string name { get; set; }
        public long XP { get; set; }
        public int level { get; set; }
        public CharacterClasses Class
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public List<statsheet> Partymembers
        {
            get { return _partyMembers; }
            set { _partyMembers = value; }
        }

        public int strength { get { return _strength; } }
        public int dexerity { get { return _dexerity; } }
        public int intelligence { get { return _intelligence; } }
        public int wisdom { get { return _wisdom; } }
        public int luck { get { return _luck; } }
        public int charizzma { get { return _charizzma; } }
        #endregion

        public statsheet()
        {
            roll();
        }

        public void roll()
        {
            _charizzma = rng.Next(_mincharizzma, _maxcharizzma);
            _intelligence = rng.Next(_minintelligence, _maxintelligence);
            _strength = rng.Next(_minstrength, _maxstrength);
            _wisdom = rng.Next(_minwisdom, _maxwisdom);
            _luck = rng.Next(_minluck, _maxluck);
            _dexerity = rng.Next(_mindexerity, _maxdexerity);
        }

        public static int Rolldice(int numberOfDice, int numberOfSides)
        {
            Random r = new Random();
            int total = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                total += r.Next(1, numberOfSides + 1);
            }

            return total;
        }
    }

    public enum CharacterClasses
    {
        None = 0,
        Clreic = 1,
        Rouge = 2,
        Tank = 3,
        Mage = 4,
        Barbarian = 5,

    }
}
