using System.Data.SQLite;
using System.Windows;

using Telegram.Bot;

namespace TELEBOT_GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static TelegramBotClient client;
        static string path = "botDB.sqlite";
        public MainWindow()
        {
            client = new TelegramBotClient("1149248725:AAG8ECl7OECLm7TOz6ob2yU1CFVks3LkroA");
            InitializeComponent();
        }
    }
}
