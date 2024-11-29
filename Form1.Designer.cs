namespace _21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.lblDealerCards = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Pink;
            this.btnStartGame.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.btnStartGame.Location = new System.Drawing.Point(590, 53);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(153, 37);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Pink;
            this.btnHit.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.btnHit.Location = new System.Drawing.Point(588, 187);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(155, 37);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Взять карту";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Pink;
            this.btnStand.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.btnStand.Location = new System.Drawing.Point(588, 267);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(155, 37);
            this.btnStand.TabIndex = 2;
            this.btnStand.Text = "Завершить ход";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblBalance.Location = new System.Drawing.Point(16, 41);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(138, 20);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Баланс игрока";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBet.Location = new System.Drawing.Point(17, 235);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(150, 20);
            this.lblBet.TabIndex = 5;
            this.lblBet.Text = "Введите ставку ";
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblPlayerCards.Location = new System.Drawing.Point(209, 319);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(130, 20);
            this.lblPlayerCards.TabIndex = 7;
            this.lblPlayerCards.Text = "Карты игрока";
            // 
            // lblDealerCards
            // 
            this.lblDealerCards.AutoSize = true;
            this.lblDealerCards.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblDealerCards.Location = new System.Drawing.Point(205, 23);
            this.lblDealerCards.Name = "lblDealerCards";
            this.lblDealerCards.Size = new System.Drawing.Size(134, 20);
            this.lblDealerCards.TabIndex = 8;
            this.lblDealerCards.Text = "Карты дилера";
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.LightPink;
            this.txtBet.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.txtBet.Location = new System.Drawing.Point(16, 290);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(151, 24);
            this.txtBet.TabIndex = 9;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblPlayerScore.Location = new System.Drawing.Point(281, 378);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(61, 20);
            this.lblPlayerScore.TabIndex = 10;
            this.lblPlayerScore.Text = "label1";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.lblDealerScore.Location = new System.Drawing.Point(278, 80);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(61, 20);
            this.lblDealerScore.TabIndex = 11;
            this.lblDealerScore.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 530);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.lblDealerCards);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStartGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblPlayerCards;
        private System.Windows.Forms.Label lblDealerCards;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
    }
}

