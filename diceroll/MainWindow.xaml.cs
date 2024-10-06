using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace diceroll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RollDice_Click(object sender, RoutedEventArgs e)
        {
            int sides = int.Parse(diceSidesComboBox.Text);  // ドロップダウンで選ばれた面数
            int numberOfRolls = int.Parse(rollCountTextBox.Text);  // 入力されたロールの個数
            Random random = new Random();

            resultTextBox.Clear();  // 前の結果を消す
            int rollsum = 0;

            for (int i = 0; i < numberOfRolls; i++) 
            {
                int roll = random.Next(1, sides + 1);
                resultTextBox.AppendText($"Roll {i + 1}: {roll}\n");
                rollsum = rollsum + roll;
            }

            resultTextBox.AppendText($"sum: {rollsum}\n");

        }

    }
}