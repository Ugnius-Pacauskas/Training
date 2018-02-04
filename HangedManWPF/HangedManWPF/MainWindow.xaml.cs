using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HangedManWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Lives lives;
        WordsContainer words;
        SeacretWord seacretWord;

        public MainWindow()
        {
            InitializeComponent();
            lives = new Lives(6);
            words = new WordsContainer();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            lives.ResetLives();
            seacretWord = new SeacretWord(words.GetRandomWord());
            updateGameStatus();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            KeyGuessState guessState = KeyGuessState.None;
            if (!lives.IsAlive())
            {
                return;
            }
            char key = e.Key.ToString().ToLower()[0];
            if (Char.IsLetter(key))
            {
                guessState = seacretWord.GuessKey(key);
                if (guessState == KeyGuessState.Incorect)
                {
                    lives.LoseLive();
                }
            }

            updateGameStatus();
            updateStatusLabel(guessState, key);
        }

        private void ChangeWinStatus(bool isAlive, bool isGuesed)
        {
            if (!isAlive)
            {
                winConditionLabel.Content = "You Lost";
                return;
            }
            if (isGuesed)
            {
                winConditionLabel.Content = "You Won";
                return;
            }
        }

        private void updateGameStatus()
        {
            seacretWordLabel.Content = seacretWord.GetHiddenWord();
            livesLabel.Content = "Lives: " + lives.ToString();
            ChangeWinStatus(lives.IsAlive(), seacretWord.IsGuesed());
        }

        private void updateStatusLabel(KeyGuessState kgs, char key)
        {
            string temp = "Your guess: " + key;
            switch (kgs)
            {
                case (KeyGuessState.AlreadyGuessed):
                    temp += " is already guessed";
                    break;
                case (KeyGuessState.Correct):
                    temp += " is correct";
                    break;
                case (KeyGuessState.Incorect):
                    temp += " is incorrect";
                    break;
                default:
                    temp += " is a the answer to life, universe and everything";
                    break;
            }
            statusLabel.Content = temp;
        }
    }
}
