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

namespace RockPaperScissorsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Random rng = new();
        private static readonly RPSChoice[] choices = { new Rock(), new Paper(), new Scissors() };

        public MainWindow()
        {
            InitializeComponent();
        }
        private void RockButton1_Click(object sender, RoutedEventArgs e)
        {
            SubmitUserChoice(new Rock());
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            SubmitUserChoice(new Paper());
        }

        private void ScissorsButton_Click(object sender, RoutedEventArgs e)
        {
            SubmitUserChoice(new Scissors());
        }

        private static RPSChoice GetCPUChoice()
        {
            int index = rng.Next(choices.Length);
            return choices[index];
        }

        private void SubmitUserChoice(RPSChoice userChoice)
        {
            var cpuChoice = GetCPUChoice();
            EndScreen endScreen = new(userChoice, cpuChoice);
            endScreen.Show();

            this.Close();
        }

    }

}
