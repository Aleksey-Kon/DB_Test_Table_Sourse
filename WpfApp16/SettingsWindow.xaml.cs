using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Input;

namespace WpfApp16
{
    public partial class SettingsWindow : Window
    {
        private string DBFile;
        private SQLiteConnection Sqlcon;
        private SQLiteCommand SQLCommand;
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DBFile = "MainDB.db";
            List<User> users = new List<User>();

            Sqlcon = new SQLiteConnection();
            SQLCommand = new SQLiteCommand();
            Sqlcon = new SQLiteConnection("Data Source=MainDB.db;Version=3;");
            Sqlcon.Open();
            SQLCommand = Sqlcon.CreateCommand();
            SQLCommand.CommandText = "Insert into TestTable (Surname, Name, Patronomic, Birthday, Place, Number, Age) values" +
                "('"+Tb0.Text+ "', '"+Tb1.Text+ "', '"+Tb2.Text+ "', '"+Tb3.Text+ "', '"+Tb4.Text+ "', '"+Tb5.Text+ "', '"+Tb6.Text+ "')";
            SQLCommand.ExecuteNonQuery();
            
            Sqlcon.Close();
            MessageBox.Show("Данные записаны");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DBFile = "MainDB.db";
            List<User> users = new List<User>();

            Sqlcon = new SQLiteConnection();
            SQLCommand = new SQLiteCommand();
            Sqlcon = new SQLiteConnection("Data Source=MainDB.db;Version=3;");
            Sqlcon.Open();
            SQLCommand = Sqlcon.CreateCommand();
            SQLCommand.CommandText = "Delete from TestTable where id like '"+Tb7.Text+"'";
            SQLCommand.ExecuteNonQuery();

            Sqlcon.Close();
            MessageBox.Show("Данные удалены");
        }
    }
}
