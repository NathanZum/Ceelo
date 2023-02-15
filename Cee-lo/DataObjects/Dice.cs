using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataObjects
{
    public class Dice
    {
        private Value _value;
        private static Random _rand = new Random();
        

        public Value Value
        {
            get
            {
                return this._value;
            }
            private set { }
        }

        public Dice(Value value)
        {
            _value = value;
        }


        public Dice()
        {
            int num = _rand.Next(1,7);
            switch (num)
            {
                case 1:
                    _value = Value.one;
                    break;
                case 2:
                    _value = Value.two;
                    break;
                case 3:
                    _value = Value.three;
                    break;
                case 4:
                    _value = Value.four;
                    break;
                case 5:
                    _value = Value.five;
                    break;
                case 6:
                    _value = Value.six;
                    break;
            }
        }

        public override string ToString()
        {
            string name;
            name = Enum.GetName(typeof(Value), this.Value);
            return name;
        }

        public string ImageName
        {
            get
            {
                return this._value.ToString();
            }
        }
    }
}
