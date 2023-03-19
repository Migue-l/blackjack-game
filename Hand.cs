using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLblackjack
{
    class Hand
    {
        Card[] MyCards = new Card[5];
        int totalvalue = 0;
        int numberofcards = 0;
        string NameOfPlayer;

        public Hand(string Name)
        {
            NameOfPlayer = Name;
        }

        public void DealACardtoMe(Card ACard)
        {
            if (numberofcards < 5)
            {
                MyCards[numberofcards] = ACard;
                totalvalue += ACard.GetCardValue();
                numberofcards++;
            }
        }

        public Card GetaCard(int index)
        {
            if (index < numberofcards)
                return MyCards[index];
            else return null;
        }

        public int GetNumberofCards()
        {
            return numberofcards;
        }

        public int GetTotalValueofCards()
        {
            totalvalue = 0;
            for (int i = 0; i < numberofcards; i++)
            {
                totalvalue += MyCards[i].GetCardValue();
            }
            return totalvalue;
        }

        public void ResetHand()
        {
            totalvalue = 0;
            numberofcards = 0;
            for (int i = 0; i < 5; i++)
            {
                MyCards[i] = null;
            }
        }

        //------------------
        //    PHASE 2
        //------------------

        public void SetAceValueto1(int index)
        {
            MyCards[index].SetCardToAceValue1();
            GetTotalValueofCards();
        }

        public int aceValueSwitch1()
        {
            int aceIndex = -1;
            for (int i = 0; i < numberofcards; ++i)
            {
                if (MyCards[i].GetCardisanAce())
                {
                    if (MyCards[i].GetCardValue() == 11)
                    {
                        MyCards[i].SetCardToAceValue1();
                        GetTotalValueofCards();
                        aceIndex = i;
                        return aceIndex;
                    }
                    


                }
            }
            return aceIndex;
        }

        public void SetAceValueto11(int index)
        {
            MyCards[index].SetCardToAceValue11();
            GetTotalValueofCards();
        }

        public bool GetIsanAce(int index)
        {
            if (index < numberofcards)
            {
                if (MyCards[index].GetCardisanAce())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
