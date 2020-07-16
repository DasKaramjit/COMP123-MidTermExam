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


        // CREATE private fields here --------------------------------------------
        private int m_elementNumber;
        private List<int> m_elementList;
        private List<int> m_numberList;
        private Random m_random;
        private int m_setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // CREATE public properties here -----------------------------------------

        public List<int> ElementList
        {
            get;
        }
        public int ElementNumber
        {
            get;
            set;
        }
        public List<int> NumberList
        {
            get;
        }
        public Random random
        {
            get;
        }
        public int SetSize
        {
            get;
            set;
        }

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
            this.m_initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------
        private void m_initialize()
        {
            this.m_elementList = new List<>;
            this.m_numberList = new List<>;
            this.m_random = new List<>;

        }

        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
            for(int i=1;i<SetSize;i++)
            {
                NumberList.Add(i);
                Console.WriteLine(i);
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

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // public LottoGame([int ElementNumber = 6],[int SetSize = 49])

        // CREATE the public PickElements method here ----------------------------
        public void PickElements()
        {
            foreach (var ifelement_number in ElementList)
            {
                if (ifelement_number > 0)
                {
                    ElementList.Clear();
                    NumberList.Clear();
                    _build();
                }
            }
            for (int i = 1; i <= 6; i++)
            {
                ElementList.Add(random.Next(1, 49));
            }
            ElementList.Sort();
        }
    }
    
}
