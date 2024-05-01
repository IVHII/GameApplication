using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class TwentySidedDice : Dice
    {
        public override void GenerateNumber()
        {
            _Num = random.Next(1, 20); //a
        } // end of GenerateNumber method
        
        public TwentySidedDice(string inColour)
            : base(inColour) //a
        {
            GenerateNumber(); //b
        } //end of TwentySidedDice Constructor

    }   // end of TwentySidedDice Dice class

        
}
