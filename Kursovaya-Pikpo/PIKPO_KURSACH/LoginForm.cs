using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIKPO_KURSACH
{
    public partial class LoginForm : Form
    {
        //private SQLiteConnection login = new SQLiteConnection("Data Source = B:/proj/visualka/Kursovaya-Pikpo/PIKPO_KURSACH/DataBase/database.db");
        Connection con = new Connection();
        string id, login, password;
        public string profilelogin, profilepassword;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                if (textBox_login.Text != "" && textBox_password.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Логин пользователя и пароль будут добавленны в БД\nПодтвердить?", "Регистрация", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            string add = "INSERT INTO Users ('login', 'password', 'buy') VALUES ('" + textBox_login.Text + "' , '" + textBox_password.Text + "', '" + 0 + "')";
                            con.ExecuteNonQuery(add);
                            MessageBox.Show("Пользователь успешно зарегестрирован");
                            row.Close();
                            con.Close();
                            btn_login_Click(this, e);
                            return;
                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message + "\n");
                        }
                    }

                    else if (dialogResult == DialogResult.No)
                    {
                        textBox_login.Text = ""; textBox_password.Text = "";
                        error.Text = "Для входа или регистрации заполните поля «Логин» и «Пароль»";
                        error.ForeColor = Color.Red;
                    }
                }
            }
            
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
            row.Close();
            con.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);

            try
            {
                error.Text = "";
                AdminPanel adminForm = new AdminPanel();
                UserPanel userForm = new UserPanel();

                if (textBox_login.Text != "" && textBox_password.Text != "")
                {
                    if (row.HasRows)
                    {
                        bool passed = false;
                        string admin = "admin";
                        string adminPass = "123";
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            login = row["login"].ToString();
                            password = row["password"].ToString();

                             if (textBox_login.Text.Trim() == admin && textBox_password.Text.Trim() == adminPass)
                            {
                                userForm.Close();
                                adminForm.Show();
                                passed = true;
                                break;
                            }

                            else if (textBox_login.Text.Trim() == login && textBox_password.Text.Trim() == password)
                            {
                                profilelogin = textBox_login.Text;
                                profilepassword = textBox_password.Text;
                                userForm.import(login, password);
                                userForm.Show();
                                passed = true;
                                break;
                            }
                        }
                        if (!passed)
                        {
                            error.Text = "Неверный логин или пароль";
                            error.ForeColor = Color.Red;
                            passed = false;
                        }
                    }
                }
                else
                {
                    error.Text = "Заполните поля «Логин» и «Пароль»";
                    error.ForeColor = Color.Red;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
            row.Close();
            con.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
