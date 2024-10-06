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

// キャラクター情報を格納するクラスを定義
public class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Initiative { get; set; }

    public override string ToString()
    {
        return $"{Name} - HP: {HP} - 行動値: {Initiative}";
    }
}


namespace character_database
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

        // キャラクターリストを格納する
        private List<Character> characters = new List<Character>();

        // キャラクターを追加するボタンクリックイベント
        private void AddCharacter_Click(object sender, RoutedEventArgs e)
        {
            // 入力された名前とHPを取得
            string name = characterNameTextBox.Text;
            int hp;
            int initiative;

            // HPが数値であるか確認し、キャラクターをリストに追加
            if (int.TryParse(characterHPTextBox.Text, out hp))
            {
                if (int.TryParse(characterInitiativeTextBox.Text, out initiative))
                {

                    Character newCharacter = new Character { Name = name, HP = hp, Initiative = initiative};
                    characters.Add(newCharacter);

                    // リストボックスに表示を更新
                    characterListBox.Items.Add(newCharacter);

                    // テキストボックスをクリア
                    characterNameTextBox.Clear();
                    characterHPTextBox.Clear();
                    characterInitiativeTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("行動値は数値を入力してください。");
                }
            }
            else
            {
                MessageBox.Show("HPは数値を入力してください。");
            }
        }


        }
    }