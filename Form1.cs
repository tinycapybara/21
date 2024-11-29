using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
   
    public partial class Form1 : Form
    {
        private Deck deck;
        private List<Card> playerHand;
        private List<Card> dealerHand;
        private int playerBalance = 1000; // Начальный баланс
        private int playerBet = 0;

        public Form1()
        {
            InitializeComponent();
            ResetGame(fullReset: true); // Полный сброс игры при запуске
        }

        private void ResetGame(bool fullReset = false)
        {
            deck = new Deck(); // Создаём новую колоду
            playerHand = new List<Card>();
            dealerHand = new List<Card>();
            lblPlayerCards.Text = "Карты игрока: ";
            lblDealerCards.Text = "Карты дилера: ";
          //  lblResult.Text = "Результат: ";
            lblPlayerScore.Text = "Очки игрока: 0";
            lblDealerScore.Text = "Очки дилера: 0";
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            if (fullReset)
            {
                playerBalance = 1000; // Сбрасываем баланс при полном перезапуске
                lblBalance.Text = $"Баланс: {playerBalance}";
            }

            // Очистка текстового поля для ставки
            txtBet.Clear();
            txtBet.Visible = true; // Показать текстбокс для новой игры
            lblBet.Visible = true; // Показать поясняющий лейбл для текстбокса

            // Скрываем остальные элементы управления, чтобы избежать визуального шума
            lblPlayerCards.Visible = false;
            lblDealerCards.Visible = false;
            lblPlayerScore.Visible = false;
            lblDealerScore.Visible = false;
            btnHit.Visible = false;
            btnStand.Visible = false;
          //  lblResult.Visible = false;
            btnStartGame.Visible = true;

            btnStartGame.Enabled = true; // Включить кнопку старта игры
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Если баланс равен 0, предлагать начать игру заново
            if (playerBalance <= 0)
            {
                MessageBox.Show("Ваш баланс равен 0. Игра начинается заново.");
                ResetGame(fullReset: true); // Полный сброс игры
                return;
            }

            // Проверка корректности ставки
            if (!int.TryParse(txtBet.Text, out playerBet) || playerBet <= 0 || playerBet > playerBalance)
            {
                MessageBox.Show("Введите корректную ставку.");
                return;
            }

            // Снимаем ставку с баланса
            playerBalance -= playerBet;
            lblBalance.Text = $"Баланс: {playerBalance}";

            // Скрыть текстбокс и лейбл после начала игры
            txtBet.Visible = false;
            lblBet.Visible = false;

            // Показываем элементы для игрового процесса
            lblPlayerCards.Visible = true;
            lblDealerCards.Visible = true;
            lblPlayerScore.Visible = true;
            lblDealerScore.Visible = true;
            btnHit.Visible = true;
            btnStand.Visible = true;
          //  lblResult.Visible = true;
            btnStartGame.Visible = false;

            // Очищаем руки игроков
            playerHand.Clear();
            dealerHand.Clear();

            // Раздача карт
            playerHand.Add(deck.DrawCard());
            playerHand.Add(deck.DrawCard());

            dealerHand.Add(deck.DrawCard());
            dealerHand.Add(deck.DrawCard());

            UpdateHands(false); // Обновление отображения (карты дилера скрыты)
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnStartGame.Enabled = false; // Отключить кнопку старта до конца раунда
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerHand.Add(deck.DrawCard());
            UpdateHands(false); // Обновление отображения (карты дилера скрыты)

            if (GetHandValue(playerHand) > 21)
            {
                EndGame("Перебор! Вы проиграли.");
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (GetHandValue(dealerHand) < 17)
            {
                dealerHand.Add(deck.DrawCard());
            }

            int playerScore = GetHandValue(playerHand);
            int dealerScore = GetHandValue(dealerHand);

            if (dealerScore > 21 || playerScore > dealerScore)
            {
                playerBalance += playerBet * 2;
                EndGame("Вы выиграли!");
            }
            else if (playerScore < dealerScore)
            {
                EndGame("Вы проиграли.");
            }
            else
            {
                playerBalance += playerBet;
                EndGame("Ничья.");
            }
        }

        private void EndGame(string result)
        {
            MessageBox.Show(result); // Сообщение о результате игры
            lblBalance.Text = $"Баланс: {playerBalance}";
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            UpdateHands(true); // Раскрываем карты дилера после завершения игры

            // Проверка на окончание игры
            if (deck.IsEmpty() || playerBalance <= 0)
            {
                if (playerBalance <= 0)
                {
                    MessageBox.Show("Ваш баланс равен 0. Игра начинается заново.");
                    ResetGame(fullReset: true); // Полный сброс игры
                }
                else
                {
                    MessageBox.Show("Игра окончена. Начните заново.");
                    ResetGame(false);
                }
            }

            // Показать текстбокс и лейбл для новой ставки
            txtBet.Visible = true;
            lblBet.Visible = true;

            // Включить кнопку старта игры, чтобы игрок мог начать новый раунд
            btnStartGame.Visible = true; // Показываем кнопку Start
            btnStartGame.Enabled = true; // Разрешаем кнопку Start
        }

        private void UpdateHands(bool revealDealer)
        {
            lblPlayerCards.Text = "Карты игрока: " + string.Join(", ", playerHand);
            lblPlayerScore.Text = "Очки игрока: " + GetHandValue(playerHand);

            if (revealDealer)
            {
                lblDealerCards.Text = "Карты дилера: " + string.Join(", ", dealerHand);
                lblDealerScore.Text = "Очки дилера: " + GetHandValue(dealerHand);
            }
            else
            {
                lblDealerCards.Text = "Карты дилера: " + string.Join(", ", dealerHand.Take(1)) + ", [скрыто]";
                lblDealerScore.Text = "Очки дилера: ?";
            }
        }

        private int GetHandValue(List<Card> hand)
        {
            int value = hand.Sum(card => card.Value);
            int aceCount = hand.Count(card => card.Rank == "Туз");

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }

    public class Card
    {
        public string Rank { get; }
        public string Suit { get; }
        public int Value { get; }

        public Card(string rank, string suit, int value)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Rank} {Suit}";
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            InitializeDeck(); // Инициализация колоды при создании
        }

        private void InitializeDeck()
        {
            cards = new List<Card>();

            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            foreach (var suit in suits)
            {
                for (int i = 0; i < ranks.Length; i++)
                {
                    cards.Add(new Card(ranks[i], suit, values[i]));
                }
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                // Перезапуск колоды, если она пуста
                InitializeDeck();
                MessageBox.Show("Колода пуста. Колода перезапущена.");
            }

            // После перезапуска колоды или если колода не пуста, возвращаем карту
            int index = random.Next(cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public bool IsEmpty() => cards.Count == 0;
    }
}
