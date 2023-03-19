using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLblackjack
{
    class Bet
    {
        private int playerMoney = 0;
        private int betAmount = 10;

        public Bet(int initialfunds)
        {
            playerMoney = initialfunds;
        }

        public int GetBetAmount()
        {
            return betAmount;
        }

        public void SetBetAmount(int betAmnt)
        {
            betAmount = betAmnt;
        }

        public void WonBet()
        {
            playerMoney = playerMoney + betAmount;
        }

        public void LostBet()
        {
            playerMoney = playerMoney - betAmount;
        }

        public int GetTotalMoney()
        {
            return playerMoney;
        }
    }
}
