using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class DiceSet
    {
        private int _score;
        public Dice[] Dices { get; private set; }

        public DiceSet()
        {
            Dices = new Dice[3];
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = new Dice();
            }
            sortSet();
        }

        public SetScores scoreSet()
        {
            SetScores score = SetScores.NoVal;

            //check for loss
            if (Dices[0].Value == Value.one && 
                Dices[1].Value == Value.two &&
                Dices[2].Value == Value.three)
            {
                score = SetScores.Loss; 
            }
            //check for win
            else if (Dices[0].Value == Value.four &&
                    Dices[1].Value == Value.five &&
                    Dices[2].Value == Value.six)
            {
                score = SetScores.Win;
            }
            //check for trip
            else if (Dices[0].Value == Dices[1].Value && 
                    Dices[1].Value == Dices[2].Value)
            {
                //trip 1
                if (Dices[0].Value == Value.one)
                {
                    score = SetScores.Trips_1;
                }
                //trip 2
                else if (Dices[0].Value == Value.two)
                {
                    score = SetScores.Trips_2;
                }
                //trip 3
                else if (Dices[0].Value == Value.three)
                {
                    score = SetScores.Trips_3;
                }
                //trip 4
                else if (Dices[0].Value == Value.four)
                {
                    score = SetScores.Trips_4;
                }
                //trip 5
                else if (Dices[0].Value == Value.five)
                {
                    score = SetScores.Trips_5;
                }
                //trip 6
                else
                {
                    score = SetScores.Trips_6;
                }
            }
            //point
            else
            {
                if (Dices[0].Value == Dices[1].Value)
                {
                    if (Dices[2].Value == Value.two)
                    {
                        score = SetScores.Point_2;
                    }
                    else if (Dices[2].Value == Value.three)
                    {
                        score = SetScores.Point_3;
                    }
                    else if (Dices[2].Value == Value.four)
                    {
                        score = SetScores.Point_4;
                    }
                    else if (Dices[2].Value == Value.five)
                    {
                        score = SetScores.Point_5;
                    }
                    else
                    {
                        score = SetScores.Point_6;
                    }
                }
                else
                {
                    if (Dices[0].Value == Value.one)
                    {
                        score = SetScores.Point_1;
                    }
                    else if (Dices[0].Value == Value.two)
                    {
                        score = SetScores.Point_2;
                    }
                    else if (Dices[0].Value == Value.three)
                    {
                        score = SetScores.Point_3;
                    }
                    else if (Dices[0].Value == Value.four)
                    {
                        score = SetScores.Point_4;
                    }
                    else
                    {
                        score = SetScores.Point_5;
                    }
                }
            }
            return score;
        }

        public void sortSet()
        {
            for (int i = Dices.Length; i > 0; i--)
            {
                for(int j = 0; j < i - 1; j++)
                {
                    if(Dices[j].Value > Dices[j + 1].Value)
                    {
                        Dice temp = Dices[j];
                        Dices[j] = Dices[j + 1];
                        Dices[j + 1] = temp;
                    }
                }
            }
        }
    }
}
