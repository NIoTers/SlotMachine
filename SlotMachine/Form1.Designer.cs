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
            this.background = new System.Windows.Forms.PictureBox();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBalance = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Bet = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.Label();
            this.betTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(206, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(557, 378);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // slot1
            // 
            this.slot1.Location = new System.Drawing.Point(267, 212);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(133, 131);
            this.slot1.TabIndex = 1;
            this.slot1.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Location = new System.Drawing.Point(430, 212);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(132, 131);
            this.slot2.TabIndex = 2;
            this.slot2.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.Location = new System.Drawing.Point(592, 212);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(132, 131);
            this.slot3.TabIndex = 3;
            this.slot3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(238, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance:";
            // 
            // AddBalance
            // 
            this.AddBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.AddBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBalance.FlatAppearance.BorderSize = 0;
            this.AddBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBalance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.AddBalance.ForeColor = System.Drawing.Color.White;
            this.AddBalance.Location = new System.Drawing.Point(260, 396);
            this.AddBalance.Name = "AddBalance";
            this.AddBalance.Size = new System.Drawing.Size(140, 45);
            this.AddBalance.TabIndex = 5;
            this.AddBalance.Text = "➕ Add Balance";
            this.AddBalance.UseVisualStyleBackColor = false;
            this.AddBalance.Click += new System.EventHandler(this.AddBalance_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.Spin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spin.FlatAppearance.BorderSize = 0;
            this.Spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Spin.ForeColor = System.Drawing.Color.White;
            this.Spin.Location = new System.Drawing.Point(422, 396);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(140, 45);
            this.Spin.TabIndex = 6;
            this.Spin.Text = "🎰 Spin";
            this.Spin.UseVisualStyleBackColor = false;
            // 
            // Bet
            // 
            this.Bet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.Bet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bet.FlatAppearance.BorderSize = 0;
            this.Bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Bet.ForeColor = System.Drawing.Color.White;
            this.Bet.Location = new System.Drawing.Point(592, 396);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(140, 45);
            this.Bet.TabIndex = 7;
            this.Bet.Text = "💵 Bet";
            this.Bet.UseVisualStyleBackColor = false;
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.money.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.ForeColor = System.Drawing.Color.Black;
            this.money.Location = new System.Drawing.Point(343, 354);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(24, 27);
            this.money.TabIndex = 4;
            this.money.Text = "0";
            // 
            // BetAmount
            // 
            this.BetAmount.AutoSize = true;
            this.BetAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.BetAmount.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetAmount.ForeColor = System.Drawing.Color.Black;
            this.BetAmount.Location = new System.Drawing.Point(587, 354);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(58, 27);
            this.BetAmount.TabIndex = 8;
            this.BetAmount.Text = "Bet:";
            // 
            // betTotal
            // 
            this.betTotal.AutoSize = true;
            this.betTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.betTotal.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betTotal.ForeColor = System.Drawing.Color.Black;
            this.betTotal.Location = new System.Drawing.Point(643, 355);
            this.betTotal.Name = "betTotal";
            this.betTotal.Size = new System.Drawing.Size(24, 27);
            this.betTotal.TabIndex = 9;
            this.betTotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 482);
            this.Controls.Add(this.betTotal);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.money);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.AddBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox background;
        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private Label label1;
        private Button AddBalance;
        private Button Spin;
        private Button Bet;
        private Label money;
        private Label BetAmount;
        private Label betTotal;
    }
}

