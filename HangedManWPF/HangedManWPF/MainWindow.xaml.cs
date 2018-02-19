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

        IHangedManGame hangedManGame;

        public MainWindow()
        {
            InitializeComponent();
            hangedManGame = new HangedManGame();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            HideLabels();
            hangedManGame.Start();
            updateGameStatus(hangedManGame);
        }

        private void HideLabels()
        {
            winConditionLabel.Content = "";
            statusLabel.Content = "";
            livesLabel.Content = "";
            seacretWordLabel.Content = "";
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (hangedManGame.GetGameState() != EGameState.Playing)
            {
                return;
            }
            hangedManGame.GuessKey(e.Key);

            updateGameStatus(hangedManGame);
            updateStatusLabel(hangedManGame.GetKeyGuessState(), e.Key.ToString());
        }

        private void ChangeWinStatus(EGameState gameState)
        {
            switch (gameState)
            {
                case EGameState.Lost:
                    winConditionLabel.Content = "You Lost";
                    break;
                case EGameState.Won:
                    winConditionLabel.Content = "You Won";
                    break;
            }
        }

        private void updateGameStatus(IHangedManGame hangedManGame)
        {
            seacretWordLabel.Content = hangedManGame.GetHiddenWord();
            livesLabel.Content = "Lives: " + hangedManGame.GetLivesCount();
            ChangeWinStatus(hangedManGame.GetGameState());
        }

        private void updateStatusLabel(KeyGuessState kgs, string key)
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
                case (KeyGuessState.Invalid):
                    temp += " is invalid";
                    break;
                default:
                    temp += " is a the answer to life, universe and everything";
                    break;
            }
            statusLabel.Content = temp;
        }
    }
}
