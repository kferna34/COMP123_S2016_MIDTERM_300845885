using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {



        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private list<int> _elementList;
        private int _elementNumber;
        private list<int> _numberList;
        private Random _random;
        private int _setSize;
        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        public List<int> ElementList
        {
            get
            {
                return this.ElementList;
            }


        }

        public int ElementNumber
        {
            get
            {
                return this.ElementNumber;
            }

            set
            {
                this.ElementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return this.NumberList;
            }

        }

        public Random random
        {
            get
            {
                return this.random;
            }

            set
            {
                this.random = value;
            }
        }

        public int SetSize
        {
            get
            {
                return this.SetSize;
            }

            set
            {
                this.SetSize = value;
            }
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {

            this._numberList = NumberList;
            this._elementList = ElementList;
            this._random = random;
        }
        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
            for (int index = 1; index < SetSize; index++)
            {
                Console.WriteLine("{0}: {1} ", index, NumberList[index]);
            }
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }



        public void PickElements()
        {
            Random random = new Random(); // pseudo number object
            List<int> numbers = new List<int>();
            int[] tally = new int[13];
            int maxRolls = 5000000;

            // builds the list
            for (int index = 0; index < maxRolls; index++)
            {
                int firstDie = random.Next(1, 7);
                int secondDie = random.Next(1, 7);
                int dice = firstDie + secondDie;
                tally[dice]++;
                diceRolls.Add(dice);
            }

            diceRolls.Sort();

        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
    }
}
