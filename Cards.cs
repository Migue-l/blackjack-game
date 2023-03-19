using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLblackjack
{
    public class Cards
    {
        Card[] AllCards = new Card[52];
        Card ACardBack;
        Random ranNumberGenerator = new Random();
        private int currentcardnumber = 0;

        public Cards()
        {
            LoadCards();
            ranNumberGenerator = new Random();
        }

        public Card GetBackCard()
        {
            return ACardBack;
        }

        public int GetCurrentCardNumber()
        {
            return currentcardnumber;
        }

        public void LoadCards()
        {
            Card ACard;
            string[] list = System.IO.Directory.GetFiles(@"cards", "*.gif");

            for (int index = 0; index < 52; index++)
            {
                int value = GetNextCardValue(index);
                Image image = Image.FromFile(list[index]);

                ACard = new Card(image, value);
                if (index > 31 && index < 36)
                {
                    ACard.SetCardToAce();

                }
                AllCards[index] = ACard;
            }


            string[] list2 = System.IO.Directory.GetFiles(@"cards", "WFSWcardback*.gif");
            Image Backimage = Image.FromFile(list2[0]);
            ACardBack = new Card(Backimage, 0);

        }

        private int GetNextCardValue(int currentcardnumber)
        {
            int cardvalue = 0;
            if (currentcardnumber < 33)
                cardvalue = (currentcardnumber / 4) + 2;
            else
            {
                cardvalue = 10;
            }
            if (currentcardnumber > 31 && currentcardnumber < 36)
                cardvalue = 11;//aces
            return cardvalue;
        }

        public Card GetNextCard()
        {
            if (currentcardnumber >= 52)
            {
                currentcardnumber = 0;
                shuffleCards();
            }
            return AllCards[currentcardnumber++];
        }


        public void shuffleCards()
        {
            int timetoshuffle = ranNumberGenerator.Next(100, 500);
            for (int i = 0; i < timetoshuffle; i++)
            {
                int num1 = ranNumberGenerator.Next(0, 52);
                int num2 = ranNumberGenerator.Next(0, 52);

                Card Card1 = AllCards[num1];
                Card Card2 = AllCards[num2];

                AllCards[num1] = Card2;
                AllCards[num2] = Card1;

            }
        }

        //PHASE II

        public void PutAcesFirst() //RWW Code
        {
            int aceindex = 0;
            int card9index = 0;
            int card5index = 0;
            int card6index = 0;

            Boolean keepgoing = true;
            shuffleCards();

            for (int index = 0; index < 52; index++)
            {
                Card TempCard1 = AllCards[index];

                if (TempCard1.GetCardisanAce())
                {
                    Card OriginalCard = AllCards[aceindex];
                    TempCard1.SetCardToAceValue11();
                    AllCards[aceindex] = TempCard1;
                    AllCards[index] = OriginalCard;
                    aceindex++;
                }

            }
            // find a 9
            card9index = aceindex = 4;
            while (keepgoing)
            {
                Card TempCard1 = AllCards[aceindex];

                if (TempCard1.GetCardValue() == 9)
                {
                    Card OriginalCard = AllCards[card9index];// original card spot to swap

                    AllCards[card9index] = TempCard1;//put the 9 in the 5th card spot
                    AllCards[aceindex] = OriginalCard;
                    keepgoing = false;
                }
                aceindex++;

            }

            // find a 5
            card5index = aceindex = 5;
            keepgoing = true;
            while (keepgoing)
            {
                Card TempCard1 = AllCards[aceindex];

                if (TempCard1.GetCardValue() == 5)
                {
                    Card OriginalCard = AllCards[card5index];// original card spot to swap

                    AllCards[card5index] = TempCard1;//put the 5 in the 6th card spot
                    AllCards[aceindex] = OriginalCard;
                    keepgoing = false;
                }
                aceindex++;

            }

            // find a 6 put it in the 7th card spot
            card6index = aceindex = 6;
            keepgoing = true;
            while (keepgoing)
            {
                Card TempCard1 = AllCards[aceindex];

                if (TempCard1.GetCardValue() == 6)
                {
                    Card OriginalCard = AllCards[card6index];// original card spot to swap

                    AllCards[card6index] = TempCard1;//put the 6 in the 7th card spot
                    AllCards[aceindex] = OriginalCard;
                    keepgoing = false;
                }
                aceindex++;
            }
            currentcardnumber = 0;
        }


        public void Dealall4AcestoDealer()
        {
            int aceindex = 0;

            shuffleCards();
            for (int index = 0; index < 52; index++)
            {
                Card TempCard1 = AllCards[index];

                if (TempCard1.GetCardisanAce())
                {
                    Card OriginalCard = AllCards[aceindex];
                    TempCard1.SetCardToAceValue11();
                    AllCards[aceindex] = TempCard1;
                    AllCards[index] = OriginalCard;
                    aceindex = aceindex + 2;

                }
            }
            currentcardnumber = 0;//RWW
        }
    }
}
