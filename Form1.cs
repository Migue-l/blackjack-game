using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLblackjack
{
    public partial class Form1 : Form
    {
        Cards DeckofCards = new Cards();
        Hand PlayerHand;
        Hand DealerHand;
        Card BackCard;
        Boolean dealtcards = false;
        Bet myfunds = new Bet(5000);

        Image HitD = new Bitmap(@"ButtonImages\HitD3.png");
        Image StayD = new Bitmap(@"ButtonImages\StayD3.png");

        public Form1()
        {
            InitializeComponent();
            DeckofCards.shuffleCards();
            PlayerHand = new Hand("Player");
            DealerHand = new Hand("Dealer");
            BackCard = DeckofCards.GetBackCard();
            ResetAllHands();
            Size = new Size(1000, 700);
            StartButton.AutoSize = true;
            GameTitle.Text = "Miguel Llanes' Black Jack";
            numericUpDown1.Minimum = 100;
            numericUpDown1.Increment = 10;
            BetLabel.Text = "Money: $" + myfunds.GetTotalMoney();

            HitButton.BackgroundImage = HitD;
            StayButton.BackgroundImage = StayD;


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            Image Hit = new Bitmap(@"ButtonImages\Hit.png");
            Image Stay = new Bitmap(@"ButtonImages\Stay.png");

            HitButton.BackgroundImage = Hit;
            StayButton.BackgroundImage = Stay;

            ResetAllHands();
            Boolean emptyHand = DealACardtoDealer();
            emptyHand = DealACardtoDealer();
            DealACardtoPlayer();
            DealACardtoPlayer();
            dealtcards = true;
            if (PlayerHand.GetTotalValueofCards() == 21)
            {
                BlackJack();
            }

            else if (DealerHand.GetTotalValueofCards() == 21)
            {
                FlipDealerCard();
                MessageBox.Show("Dealer has Black Jack, you LOSE.");
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
                LostBet();
            }
        }

        private void BlackJack()
        {
            int totalValueofCards1 = DealerHand.GetTotalValueofCards();
            int totalValueofCards2 = PlayerHand.GetTotalValueofCards();
            FlipDealerCard();
            if (totalValueofCards1 != 21)
            {
                MessageBox.Show("You have Black Jack, you WIN.");
                WonBet();
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
            }
            else
            {
                MessageBox.Show("It's a TIE.");
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
            }
            dealtcards = false;
        }

        private void ResetAllHands()
        {
            DealerHand.ResetHand();
            PlayerHand.ResetHand();
            ResetHandsGUI();
        }

        public void ResetHandsGUI()
        {
            PCard1.BackgroundImage = BackCard.GetCardImage();
            PCard1Value.Text = " ";
            PCard2.BackgroundImage = BackCard.GetCardImage();
            PCard2Value.Text = " ";
            PCard3.BackgroundImage = BackCard.GetCardImage();
            PCard3Value.Text = " ";
            PCard4.BackgroundImage = BackCard.GetCardImage();
            PCard4Value.Text = " ";
            PCard5.BackgroundImage = BackCard.GetCardImage();
            PCard5Value.Text = " ";
            DCard3.BackgroundImage = BackCard.GetCardImage();
            DCard3Value.Text = " ";
            DCard4.BackgroundImage = BackCard.GetCardImage();
            DCard4Value.Text = " ";
            DCard5.BackgroundImage = BackCard.GetCardImage();
            DCard5Value.Text = " ";
        }

        private void FlipDealerCard()
        {
            Card ACard = DealerHand.GetaCard(1);
            DCard2.BackgroundImage = ACard.GetCardImage();
            DCard2Value.Text = " " + ACard.GetCardValue().ToString();
            DCvalue.Text = "Total: " + DealerHand.GetTotalValueofCards().ToString();
        }

        //--------------------------
        //   START of HIT BUTTON
        //--------------------------
        private void HitButton_Click(object sender, EventArgs e)
        {
            if (dealtcards)
            {
                DealACardtoPlayer();
                if (PlayerHand.GetTotalValueofCards() == 21)
                {
                    PlayerHas21();
                }
            }
        }

        //--------------------------
        //   END of HIT BUTTON
        //--------------------------

        //--------------------------
        //   START of STAY BUTTON
        //--------------------------

        private void StayButton_Click_1(object sender, EventArgs e)
        {
            if (dealtcards)
            {
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;

                FlipDealerCard();
                EvaluateCardsPlayer();
            }
            dealtcards = false;
        }

        //--------------------------
        //   END of STAY BUTTON
        //--------------------------

        private void PlayerHas21()
        {
            FlipDealerCard();
            EvaluateCardsPlayer();
            dealtcards = false;
        }

        private void DealACardtoPlayer()
        {
            int cardnumber = PlayerHand.GetNumberofCards();
            if (cardnumber < 5)
            {
                Card ACard = DeckofCards.GetNextCard();
                PlayerHand.DealACardtoMe(ACard);
                UpdatePlayerGraphics(cardnumber);
                HitLock();

            }
        }

        private void HitLock()
        {
            int cardnumber = PlayerHand.GetNumberofCards();
            if (cardnumber == 5)
            {
                HitButton.BackgroundImage = HitD;
            }
        }
           
               

        private void UpdatePlayerGraphics(int index)
        {
            Card card = PlayerHand.GetaCard(index);
            int num;
            switch (index)
            {
                case 0:
                    PCard1.BackgroundImage = card.GetCardImage();
                    Label PCard1Value = this.PCard1Value;
                    num = card.GetCardValue();
                    string str1 = " " + num.ToString();
                    PCard1Value.Text = str1;
                    break;
                case 1:
                    PCard2.BackgroundImage = card.GetCardImage();
                    Label PCard2Value = this.PCard2Value;
                    num = card.GetCardValue();
                    string str2 = " " + num.ToString();
                    PCard2Value.Text = str2;
                    break;
                case 2:
                    PCard3.BackgroundImage = card.GetCardImage();
                    Label PCard3Value = this.PCard3Value;
                    num = card.GetCardValue();
                    string str3 = " " + num.ToString();
                    PCard3Value.Text = str3;
                    break;
                case 3:
                    PCard4.BackgroundImage = card.GetCardImage();
                    Label PCard4Value = this.PCard4Value;
                    num = card.GetCardValue();
                    string str4 = " " + num.ToString();
                    PCard4Value.Text = str4;
                    break;
                case 4:
                    PCard5.BackgroundImage = card.GetCardImage();
                    Label PCard5Value = this.PCard5Value;
                    num = card.GetCardValue();
                    string str5 = " " + num.ToString();
                    PCard5Value.Text = str5;
                    break;
            }
            Label PCvalue = this.PCvalue;
            num = PlayerHand.GetTotalValueofCards();
            string str6 = num.ToString();
            PCvalue.Text = "Total: " + str6;
        }

        private Boolean DealACardtoDealer()
        {
            Boolean emptyHand = true;
            int cardnumber = DealerHand.GetNumberofCards();
            if (cardnumber < 5)
            {
                Boolean HideLabel = true;
                Card ACard = DeckofCards.GetNextCard();
                DealerHand.DealACardtoMe(ACard);
                UpdateDealerGraphics(cardnumber, HideLabel);
            }
            else
                emptyHand = false;
            return emptyHand;
        }

        private void UpdateDealerGraphics(int cardnumber, Boolean HideLabel)
        {
            Card ACard = DealerHand.GetaCard(cardnumber);
            int num;

            switch (cardnumber)
            {
                case 0:
                    DCard1.BackgroundImage = ACard.GetCardImage();
                    Label DCard1Value = this.DCard1Value;
                    num = ACard.GetCardValue();
                    string str1 = " " + num.ToString();
                    DCard1Value.Text = str1;
                    break;
                case 1:
                    if (HideLabel)
                    {
                        DCard2.BackgroundImage = BackCard.GetCardImage();
                        DCard2Value.Text = " ";
                        break;
                    }
                    DCard2.BackgroundImage = ACard.GetCardImage();
                    DCard2Value.Text = " " + ACard.GetCardValue().ToString();
                    break;
                case 2:
                    DCard3.BackgroundImage = ACard.GetCardImage();
                    Label DCard3Value = this.DCard3Value;
                    num = ACard.GetCardValue();
                    string str2 = " " + num.ToString();
                    DCard3Value.Text = str2;
                    break;
                case 3:
                    DCard4.BackgroundImage = ACard.GetCardImage();
                    Label DCard4Value = this.DCard4Value;
                    num = ACard.GetCardValue();
                    string str3 = " " + num.ToString();
                    DCard4Value.Text = str3;
                    break;
                case 4:
                    DCard5.BackgroundImage = ACard.GetCardImage();
                    Label DCard5Value = this.DCard5Value;
                    num = ACard.GetCardValue();
                    string str4 = " " + num.ToString();
                    DCard5Value.Text = str4;
                    break;
            }
            Label DCvalue = this.DCvalue;
            num = DealerHand.GetTotalValueofCards();
            string str5 = num.ToString();

            int HideLabelCount = ACard.GetCardValue();
            int result = num - HideLabelCount;
            int cardnn = PlayerHand.GetNumberofCards();

            if (HideLabel == true && cardnn < 2)
            {
                DCvalue.Text = "Total: " + result;
            }

            else
            {
                DCvalue.Text = "Total: " + str5;
            }
        }

        private void EvaluateCardsPlayer()
        {
            
            
            int totalPlayerValue = PlayerHand.GetTotalValueofCards();
            int totalDealerValue = DealerHand.GetTotalValueofCards();

            Boolean hit = DealerTurn(totalPlayerValue);
            totalDealerValue = DealerHand.GetTotalValueofCards();         

            if (totalPlayerValue > 21)
            {
                
                MessageBox.Show("Over 21 - YOU LOSE");
                LostBet();
            }
           
            else if (totalPlayerValue == totalDealerValue)
            {
                MessageBox.Show("It's a TIE.");
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
            }
            else if (hit)
            {
                MessageBox.Show("You WIN");
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
                WonBet();
            }
            else
            {
                MessageBox.Show("You LOSE");
                HitButton.BackgroundImage = HitD;
                StayButton.BackgroundImage = StayD;
                LostBet();
            }
        }

        private Boolean DealerTurn(int totalPlayerValue)
        {
            Boolean hit = true;
            int totalDealerValue = DealerHand.GetTotalValueofCards();
            Boolean KeepDealing = true;

            if (totalDealerValue > 21)
            {
                int AcesIndex = dealerAceSwitch();
                Boolean HideLabel = false;
                UpdateDealerGraphics(AcesIndex, HideLabel);
            }

            while (KeepDealing)
            {
                totalDealerValue = DealerHand.GetTotalValueofCards();
                if (totalDealerValue <= 20 && totalPlayerValue <= 21 && totalDealerValue < totalPlayerValue || totalDealerValue == totalPlayerValue && totalDealerValue <= 17 || totalPlayerValue < totalDealerValue && totalDealerValue < 17)
                {
                    KeepDealing = DealACardtoDealer();
                    totalDealerValue = DealerHand.GetTotalValueofCards();
                    if (totalDealerValue > 21)
                    {
                        int AcesIndex = dealerAceSwitch(); //dealer switches aces when total value > 21
                        if (AcesIndex == -1)
                        {
                            KeepDealing = false;
                            return true;
                        }
                        else
                        {
                            totalDealerValue = DealerHand.GetTotalValueofCards();
                            Boolean HideLabel = false;
                            UpdateDealerGraphics(AcesIndex, HideLabel);
                        }                        
                    }
                }

                else
                {
                    KeepDealing = false;
                }
            }
            if (totalDealerValue > totalPlayerValue)
            {
                hit = false;
            }
            return hit;
        }

        //PHASE II

        private int dealerAceSwitch()
        {
            return DealerHand.aceValueSwitch1();
        }

        //Give Aces Button (2 to player, 2 to dealer)
        private void GiveAcesButton_Click(object sender, EventArgs e)
        {
            DeckofCards.LoadCards();
            DeckofCards.PutAcesFirst();
            start();
   
        }


        private bool SetCardtopAceValue1(int index)
        {
            Card card = PlayerHand.GetaCard(index);
            

            if (card == null) //Don't do anything if card is not dealt
            {
                return false;
            }

            int cardVace = card.GetCardValue();

            if (!PlayerHand.GetIsanAce(index)) //Don't do anything if card != ace
            {
                return false;
            }

            else if (PlayerHand.GetIsanAce(index) && cardVace == 11) //turn 11 > 1
            {
                PlayerHand.SetAceValueto1(index);
                return true;
            }

            else
            {
                PlayerHand.SetAceValueto11(index); //1 > 11
                return true;
            }
        }

        private void PCard1_Click(object sender, EventArgs e)
        {
            if (SetCardtopAceValue1(0))
            {
                UpdatePlayerGraphics(0);
            }
        }

        private void PCard2_Click(object sender, EventArgs e)
        {
            if (SetCardtopAceValue1(1))
            {
                UpdatePlayerGraphics(1);
            }
        }

        private void PCard3_Click(object sender, EventArgs e)
        {
            if (SetCardtopAceValue1(2))
            {
                UpdatePlayerGraphics(2);
            }
        }

        private void PCard4_Click(object sender, EventArgs e)
        {
            if (SetCardtopAceValue1(3))
            {
                UpdatePlayerGraphics(3);
            }
        }

        private void PCard5_Click(object sender, EventArgs e)
        {
            if (SetCardtopAceValue1(4))
            {
                UpdatePlayerGraphics(4);
            }
        }

        private void DealerAcesButton_Click(object sender, EventArgs e)
        {
            DeckofCards.LoadCards();
            DeckofCards.Dealall4AcestoDealer();
            start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myfunds.SetBetAmount((int)numericUpDown1.Value);
        }

        private void LostBet()
        {
            myfunds.LostBet();
            BetLabel.Text = "Money: $" + myfunds.GetTotalMoney();
        }
        private void WonBet()
        {
            myfunds.WonBet();
            BetLabel.Text = "Money: $" + myfunds.GetTotalMoney();
        }

        private void DealerTitle_Click(object sender, EventArgs e)
        {

        }

        private void DCvalue_Click(object sender, EventArgs e)
        {

        }

        private void DCard1_Click(object sender, EventArgs e)
        {

        }

        private void DCard2_Click(object sender, EventArgs e)
        {

        }

        private void DCard3_Click(object sender, EventArgs e)
        {

        }

        private void DCard4_Click(object sender, EventArgs e)
        {

        }

        private void DCard5_Click(object sender, EventArgs e)
        {

        }

        private void PlayerTitle_Click(object sender, EventArgs e)
        {

        }

        private void PCvalue_Click(object sender, EventArgs e)
        {

        }
    }
}