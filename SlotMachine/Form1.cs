using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            ApplyRoundedCorners(AddBalance, 10);
            ApplyRoundedCorners(Spin, 10);
            ApplyRoundedCorners(Bet, 10);
            this.AddBalance.MouseEnter += (s, e) => { AddBalance.BackColor = ColorTranslator.FromHtml("#FF8C00"); };
            this.AddBalance.MouseLeave += (s, e) => { AddBalance.BackColor = ColorTranslator.FromHtml("#FFA500"); };
            this.Spin.MouseEnter += (s, e) => { Spin.BackColor = ColorTranslator.FromHtml("#FF8C00"); };
            this.Spin.MouseLeave += (s, e) => { Spin.BackColor = ColorTranslator.FromHtml("#FFA500"); };
            this.Bet.MouseEnter += (s, e) => { Bet.BackColor = ColorTranslator.FromHtml("#0056b3"); };
            this.Bet.MouseLeave += (s, e) => { Bet.BackColor = ColorTranslator.FromHtml("#007BFF"); };
            spinTimer.Interval = 100;
            spinTimer.Tick += SpinTimer_Tick;
            this.Spin.Click += Spin_Click;
        }

        private void ApplyRoundedCorners(Button btn, int radius)
        {
            Rectangle bounds = btn.ClientRectangle;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void AddBalance_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter amount to add:", "Add Balance", "100", -1, -1);
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out int amount) && amount > 0)
                {
                    MessageBox.Show($"You added {amount} money!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentBalance += amount;
                    money.Text = currentBalance.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Bet_Click(object sender, EventArgs e)
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

        private void Spin_Click(object sender, EventArgs e)
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

                slot1.Image = Image.FromFile(imagePath + slotResults[0]);
                slot2.Image = Image.FromFile(imagePath + slotResults[1]);
                slot3.Image = Image.FromFile(imagePath + slotResults[2]);
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
                    MessageBox.Show($"You won double! Current balance: {currentBalance}", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    currentBalance += betAmount;
                    MessageBox.Show($"You won the full bet! Current balance: {currentBalance}", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (slotResults[0] == slotResults[1] || slotResults[1] == slotResults[2] || slotResults[0] == slotResults[2])
            {
                currentBalance += betAmount / 2; 
                MessageBox.Show($"You won half of the bet! Current balance: {currentBalance}", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentBalance -= betAmount;
                MessageBox.Show($"You lost the bet! Current balance: {currentBalance}", "Loss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            money.Text = currentBalance.ToString("N0");
        }

    }
}
