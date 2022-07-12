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
using System.Windows.Shapes;

public enum RPSChoices { Rock, Paper, Scissors };

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for DefaultRPSUserChoice.xaml
    /// </summary>
    public partial class DefaultRPSUserChoice : Window
    {
        private void Finalize(RPSChoices userChoice) 
        {
            Console.WriteLine(userChoice.ToString());
        }

        public void RPSUserChoice()
        {
            InitializeComponent();
        }

        private void RockButton_Click(object sender, RoutedEventArgs e)
        {
            Finalize(RPSChoices.Rock);
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            Finalize(RPSChoices.Paper);
        }

        private void ScissorsButton_Click(object sender, RoutedEventArgs e)
        {
            Finalize(RPSChoices.Scissors);
        }
    }
}
