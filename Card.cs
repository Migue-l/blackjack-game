using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLblackjack
{
    public class Card
    {
        Image image;
        int value;
        Boolean IsAce;

        public Card(Image myimage, int myvalue)
        {
            image = myimage;
            value = myvalue;
            IsAce = false;
        }

        public Image GetCardImage()
        {
            return image;
        }

        public int GetCardValue()
        {
            return value;
        }

        //---------------
        //PHASE 2
        //---------------

        public void SetCardToAce()
        {
            IsAce = true;
        }

        public bool GetCardisanAce()
        {
            return IsAce;
        }

        public void SetCardToAceValue1()
        {
            if (IsAce)
            {
                value = 1;
                
            }
        }

        public void SetCardToAceValue11()
        {
            if (IsAce)
            {
                value = 11;
                
            }
        }


    }
}
