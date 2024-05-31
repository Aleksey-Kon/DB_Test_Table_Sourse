using System;
using System.Collections.Generic;
using System.Windows;
using System.Data.SQLite;

namespace WpfApp16
{
    public class User {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronomic { get; set; }
        public string Birthday { get; set; }
        public string Place { get; set; }
        public string Number { get; set; }
        public string Age { get; set; }
    }

    public partial class MainWindow : Window
    {
        private static string DBFile;
        private static SQLiteConnection Sqlcon;
        private static SQLiteCommand SQLCommand;

        public MainWindow()
        {
            InitializeComponent();
            AutoSelect();
        }

        public void AutoSelect()
        {
            DBFile = "MainDB.db";
            List<User> users = new List<User>();

            Sqlcon = new SQLiteConnection();
            SQLCommand = new SQLiteCommand();
            Sqlcon = new SQLiteConnection("Data Source=MainDB.db;Version=3;");
            Sqlcon.Open();
            SQLiteDataReader sqlData;
            SQLCommand = Sqlcon.CreateCommand();
            SQLCommand.CommandText = "Select * From TestTable";
            sqlData = SQLCommand.ExecuteReader();
            while(sqlData.Read())
            {
                users.Add(new User() { ID = Convert.ToInt32(sqlData["id"]), Surname = sqlData["Surname"].ToString(), 
                    Name = sqlData["Name"].ToString(), Patronomic = sqlData["Patronomic"].ToString(),
                    Birthday = sqlData["Birthday"].ToString(), Place = sqlData["Place"].ToString(),
                    Number = sqlData["Number"].ToString(), Age = sqlData["Age"].ToString() });
            }
            MainDG.ItemsSource = users;
            Sqlcon.Close();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow SW = new SettingsWindow();
            SW.Show();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            AutoSelect();
        }
    }
}


