using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.balance = new System.Windows.Forms.Label();
            this.backgroundimg = new System.Windows.Forms.PictureBox();
            this.money = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.Label();
            this.betTotal = new System.Windows.Forms.Label();
            this.Spin = new System.Windows.Forms.Label();
            this.addMoney = new System.Windows.Forms.Label();
            this.betting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundimg)).BeginInit();
            this.SuspendLayout();
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.Color.Transparent;
            this.slot1.Location = new System.Drawing.Point(229, 197);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(133, 201);
            this.slot1.TabIndex = 1;
            this.slot1.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.Color.Transparent;
            this.slot2.Location = new System.Drawing.Point(429, 197);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(132, 201);
            this.slot2.TabIndex = 2;
            this.slot2.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.Color.Transparent;
            this.slot3.Location = new System.Drawing.Point(627, 197);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(132, 201);
            this.slot3.TabIndex = 3;
            this.slot3.TabStop = false;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.BackColor = System.Drawing.Color.Transparent;
            this.balance.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(308, 425);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(78, 20);
            this.balance.TabIndex = 4;
            this.balance.Text = "Balance";
            // 
            // backgroundimg
            // 
            this.backgroundimg.BackColor = System.Drawing.Color.Transparent;
            this.backgroundimg.Image = ((System.Drawing.Image)(resources.GetObject("backgroundimg.Image")));
            this.backgroundimg.Location = new System.Drawing.Point(164, 33);
            this.backgroundimg.Name = "backgroundimg";
            this.backgroundimg.Size = new System.Drawing.Size(665, 551);
            this.backgroundimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundimg.TabIndex = 10;
            this.backgroundimg.TabStop = false;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.Transparent;
            this.money.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Black;
            this.money.Location = new System.Drawing.Point(284, 453);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(24, 27);
            this.money.TabIndex = 4;
            this.money.Text = "0";
            // 
            // BetAmount
            // 
            this.BetAmount.AutoSize = true;
            this.BetAmount.BackColor = System.Drawing.Color.Transparent;
            this.BetAmount.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetAmount.ForeColor = System.Drawing.Color.Black;
            this.BetAmount.Location = new System.Drawing.Point(327, 481);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(39, 20);
            this.BetAmount.TabIndex = 8;
            this.BetAmount.Text = "Bet";
            // 
            // betTotal
            // 
            this.betTotal.AutoSize = true;
            this.betTotal.BackColor = System.Drawing.Color.Transparent;
            this.betTotal.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betTotal.ForeColor = System.Drawing.Color.Black;
            this.betTotal.Location = new System.Drawing.Point(285, 507);
            this.betTotal.Name = "betTotal";
            this.betTotal.Size = new System.Drawing.Size(24, 27);
            this.betTotal.TabIndex = 9;
            this.betTotal.Text = "0";
            // 
            // Spin
            // 
            this.Spin.AutoSize = true;
            this.Spin.BackColor = System.Drawing.Color.Transparent;
            this.Spin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(434, 466);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(140, 45);
            this.Spin.TabIndex = 11;
            this.Spin.Text = "🎰 Spin";
            this.Spin.Click += new System.EventHandler(this.label2_Click);
            // 
            // addMoney
            // 
            this.addMoney.AutoSize = true;
            this.addMoney.BackColor = System.Drawing.Color.Transparent;
            this.addMoney.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addMoney.Location = new System.Drawing.Point(604, 483);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(29, 19);
            this.addMoney.TabIndex = 12;
            this.addMoney.Text = "➕";
            this.addMoney.Click += new System.EventHandler(this.label3_Click);
            // 
            // betting
            // 
            this.betting.AutoSize = true;
            this.betting.BackColor = System.Drawing.Color.Transparent;
            this.betting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.betting.Location = new System.Drawing.Point(682, 482);
            this.betting.Name = "betting";
            this.betting.Size = new System.Drawing.Size(29, 19);
            this.betting.TabIndex = 13;
            this.betting.Text = "💵";
            this.betting.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1032, 707);
            this.Controls.Add(this.betting);
            this.Controls.Add(this.addMoney);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.betTotal);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.money);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.backgroundimg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private Label balance;
        private Label money;
        private Label BetAmount;
        private Label betTotal;
        private PictureBox backgroundimg;
        private Label Spin;
        private Label addMoney;
        private Label betting;
    }
}

