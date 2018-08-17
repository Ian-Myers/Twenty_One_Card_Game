using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOnePlayer : Player
    {
        public TwentyOnePlayer(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public bool Stay { get; set; }
        public bool isBusted { set; get; }
    }
}
