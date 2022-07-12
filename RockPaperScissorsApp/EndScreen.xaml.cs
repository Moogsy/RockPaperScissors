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

namespace RockPaperScissorsApp
{
    /// <summary>
    /// Interaction logic for EndScreen.xaml
    /// </summary>
    /// 



    public partial class EndScreen : Window
    {
        public string OutcomeMessage { get; set; }
        public string YourChoiceMessage { get; set; }
        public string CpuChoiceMessage { get; set; }

        private static string GetEndMessage(RPSChoice userChoice, RPSChoice cpuChoice)
        {
            if (userChoice > cpuChoice)
            {
                return "You won !";
            }
            else if (userChoice < cpuChoice)
            {
                return "You lost !";
            }
            else
            {
                return "Draw !";
            }
        }

        public EndScreen(RPSChoice userChoice, RPSChoice cpuChoice)
        {
            this.OutcomeMessage = GetEndMessage(userChoice, cpuChoice);
            this.YourChoiceMessage = $"You: {userChoice}";
            this.CpuChoiceMessage = $"Cpu: {cpuChoice.choice}";

            this.DataContext = this;

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();

            this.Close();
        }
    }
}
