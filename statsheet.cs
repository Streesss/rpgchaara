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
        private CharacterClasses _characterClasses;

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
        private List<statsheet> Partymembers = new List<statsheet>;
        private CharacterClasses _characterClasses = Class.None;
        private Random rng = new Random();
        #endregion

        #region properties
        public CharacterClasses Class
        {
            get { return _characterClasses; }
            set { _characterClasses = value; }
        }
        public string name { get; set; }
        public long XP { get; set; }
        public int level { get; set; }
        /*public int CharacterClasses Class
            {
                
            }*/

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

        public static int rolldice (int numberofdice, int numberofsides)
        {

        }
    }

    public enum CharacterClasses
    {
        none = 0,
        clreic = 1,
        rouge = 2,
        tank = 3,
        mage = 4,
        barbarian = 5,

    }
}
