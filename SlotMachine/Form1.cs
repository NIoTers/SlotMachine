using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        int currentBalance = 0;
        int betAmount = 0;
        Random rng = new Random();
        Timer spinTimer = new Timer();
        int spinDuration = 3000;
        DateTime spinStartTime;
        string[] imageNames = { "bar.png", "bell.png", "cherry.png", "diamond.png", "lemon.png", "seven.png" };
        string imagePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Images\\");
        string[] slotResults = new string[3];

        public Form1()
        {
            InitializeComponent();
            Point balanceScreenPos = PointToScreen(balance.Location);
            Point moneyScreenPos = PointToScreen(money.Location);
            Point betAmountScreenPos = PointToScreen(BetAmount.Location);
            Point betTotalScreenPos = PointToScreen(betTotal.Location);
            Point spinScreenPos = PointToScreen(Spin.Location);
            Point addMoneyScreenPos = PointToScreen(addMoney.Location);
            Point bettingScreenPos = PointToScreen(betting.Location);
            Point slot1ScreenPos = PointToScreen(slot1.Location);
            Point slot2ScreenPos = PointToScreen(slot2.Location);
            Point slot3ScreenPos = PointToScreen(slot3.Location);

            balance.Parent = backgroundimg;
            money.Parent = backgroundimg;
            BetAmount.Parent = backgroundimg;
            betTotal.Parent = backgroundimg;
            Spin.Parent = backgroundimg;
            addMoney.Parent = backgroundimg;
            betting.Parent = backgroundimg;
            slot1.Parent = backgroundimg;
            slot2.Parent = backgroundimg;
            slot3.Parent = backgroundimg;

            balance.Location = backgroundimg.PointToClient(balanceScreenPos);
            money.Location = backgroundimg.PointToClient(moneyScreenPos);
            BetAmount.Location = backgroundimg.PointToClient(betAmountScreenPos);
            betTotal.Location = backgroundimg.PointToClient(betTotalScreenPos);
            Spin.Location = backgroundimg.PointToClient(spinScreenPos);
            addMoney.Location = backgroundimg.PointToClient(addMoneyScreenPos);
            betting.Location = backgroundimg.PointToClient(bettingScreenPos);
            slot1.Location = backgroundimg.PointToClient(slot1ScreenPos);
            slot2.Location = backgroundimg.PointToClient(slot2ScreenPos);
            slot3.Location = backgroundimg.PointToClient(slot3ScreenPos);

            Spin.Cursor = Cursors.Hand;
            addMoney.Cursor = Cursors.Hand;
            betting.Cursor = Cursors.Hand;

            Spin.MouseEnter += (s, e) => { Spin.ForeColor = Color.Red; };
            Spin.MouseLeave += (s, e) => { Spin.ForeColor = Color.Black; };
            addMoney.MouseEnter += (s, e) => { addMoney.ForeColor = Color.Red; };
            addMoney.MouseLeave += (s, e) => { addMoney.ForeColor = Color.Black; };
            betting.MouseEnter += (s, e) => { betting.ForeColor = Color.Red; };
            betting.MouseLeave += (s, e) => { betting.ForeColor = Color.Black; };

            spinTimer.Interval = 100;
            spinTimer.Tick += SpinTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(backgroundimg.Image);
            bmp.MakeTransparent(Color.White);
            backgroundimg.Image = bmp;
            backgroundimg.BackColor = Color.Transparent;
        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            slot2.SizeMode = PictureBoxSizeMode.StretchImage;
            slot3.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                slotResults[0] = imageNames[rng.Next(imageNames.Length)];
                slotResults[1] = imageNames[rng.Next(imageNames.Length)];
                slotResults[2] = imageNames[rng.Next(imageNames.Length)];

                Bitmap bmp1 = new Bitmap(Path.Combine(imagePath, slotResults[0]));
                bmp1.MakeTransparent(Color.White);
                slot1.Image = bmp1;

                Bitmap bmp2 = new Bitmap(Path.Combine(imagePath, slotResults[1]));
                bmp2.MakeTransparent(Color.White);
                slot2.Image = bmp2;

                Bitmap bmp3 = new Bitmap(Path.Combine(imagePath, slotResults[2]));
                bmp3.MakeTransparent(Color.White);
                slot3.Image = bmp3;
            }
            catch (Exception ex)
            {
                spinTimer.Stop();
                MessageBox.Show("Error loading images: " + ex.Message);
            }
            if ((DateTime.Now - spinStartTime).TotalMilliseconds >= spinDuration)
            {
                spinTimer.Stop();
                CheckWin();
            }
        }

        private void CheckWin()
        {
            if (slotResults[0] == slotResults[1] && slotResults[1] == slotResults[2])
            {
                if (slotResults[0] == "seven.png")
                {
                    currentBalance += betAmount * 2;
                    MessageBox.Show("You won double! Current balance: " + currentBalance, "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    currentBalance += betAmount;
                    MessageBox.Show("You won the full bet! Current balance: " + currentBalance, "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (slotResults[0] == slotResults[1] || slotResults[1] == slotResults[2] || slotResults[0] == slotResults[2])
            {
                currentBalance += betAmount / 2;
                MessageBox.Show("You won half of the bet! Current balance: " + currentBalance, "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentBalance -= betAmount;
                MessageBox.Show("You lost the bet! Current balance: " + currentBalance, "Loss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            money.Text = currentBalance.ToString("N0");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (betAmount == 0)
            {
                MessageBox.Show("Please add a bet amount first", "No Bet Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (currentBalance <= 0)
            {
                MessageBox.Show("You don't have enough balance to place a bet.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (betAmount > currentBalance && currentBalance > 0)
            {
                MessageBox.Show("You cannot bet more than your current balance.", "Not Enough Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            spinStartTime = DateTime.Now;
            spinTimer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter amount to add:", "Add Balance", "100", -1, -1);
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out int amount) && amount > 0)
                {
                    MessageBox.Show("You added " + amount + " money!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentBalance += amount;
                    money.Text = currentBalance.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter amount to bet:", "Bet", "100", -1, -1);
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out int amount) && amount > 0)
                {
                    if (amount > currentBalance)
                    {
                        MessageBox.Show("You cannot bet more than your current balance.", "Not Enough Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    betAmount = amount;
                    betTotal.Text = betAmount.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
