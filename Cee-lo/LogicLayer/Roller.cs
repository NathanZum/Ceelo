using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace LogicLayer
{
    public class Roller
    {
        public DiceSet NewSet()
        {
            bool _valid = false;
            DiceSet diceSet = null;
            while (!_valid) { 
                diceSet = new DiceSet();
                _valid = validateSet(diceSet);
            }
            return diceSet;
        }

        public bool validateSet(DiceSet diceSet)
        {
            Dice dice1 = diceSet.Dices[0];
            Dice dice2 = diceSet.Dices[1];
            Dice dice3 = diceSet.Dices[2];

            if (dice1.Value == Value.one && dice2.Value == Value.two && dice3.Value == Value.three)
            {
                return true;
            }
            else if (dice1.Value == Value.four && dice2.Value == Value.five && dice3.Value == Value.six)
            {
                return true;
            }
            else if (dice1.Value == dice2.Value || dice2.Value == dice3.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
