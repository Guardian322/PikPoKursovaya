using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIKPO_KURSACH.FormsFromAdminPanel
{
    public partial class selling_catalog : Form
    {
        private SQLiteCommandBuilder builder = null;
        private SQLiteDataAdapter sqliteDataAdapter = null;
        private SQLiteConnection sQLiteConnection = null;
        private DataSet dataSet = null;
        private bool cmdRow = false;


        //Connection con = new Connection();


        public selling_catalog()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Selling", sQLiteConnection);
                builder = new SQLiteCommandBuilder(sqliteDataAdapter);

                builder.GetInsertCommand();
                builder.GetDeleteCommand();
                builder.GetUpdateCommand();

                dataSet = new DataSet();

                sqliteDataAdapter.Fill(dataSet, "Selling");

                dgvViewer.DataSource = dataSet.Tables["Selling"];

                for (int i = 0; i < dgvViewer.Rows.Count; i++)
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, i] = link;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet.Tables["Selling"].Clear();

                sqliteDataAdapter.Fill(dataSet, "Selling");

                dgvViewer.DataSource = dataSet.Tables["Selling"];

                for (int i = 0; i < dgvViewer.Rows.Count; i++)
                {
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, i] = link;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    string cmd = dgvViewer.Rows[e.RowIndex].Cells[6].Value.ToString(); // Получили текст из линк лейбла

                    if (cmd == "Delete")
                    {
                        if (MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvViewer.Rows.RemoveAt(rowIndex); // Удаляем строку из DataGridView
                            dataSet.Tables["Selling"].Rows[rowIndex].Delete(); // Удаляем строку из датасет
                            sqliteDataAdapter.Update(dataSet, "Selling"); // Обновляем БД

                            Refresh();
                        }
                    }
                    else if (cmd == "Insert")
                    {
                        int rowIndex = dgvViewer.Rows.Count - 2;
                        DataRow row = dataSet.Tables["Selling"].NewRow();

                        row["authors"] = dgvViewer.Rows[rowIndex].Cells["authors"].Value;
                        row["title"] = dgvViewer.Rows[rowIndex].Cells["title"].Value;
                        row["description"] = dgvViewer.Rows[rowIndex].Cells["description"].Value;
                        row["price"] = dgvViewer.Rows[rowIndex].Cells["price"].Value;
                        row["count"] = dgvViewer.Rows[rowIndex].Cells["count"].Value;

                        dataSet.Tables["Selling"].Rows.Add(row);
                        dataSet.Tables["Selling"].Rows.RemoveAt(dataSet.Tables["Selling"].Rows.Count - 1);
                        dgvViewer.Rows.RemoveAt(dgvViewer.Rows.Count - 2);
                        dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Delete";
                        sqliteDataAdapter.Update(dataSet, "Selling");
                        cmdRow = false;

                        Refresh();
                    }
                    else if (cmd == "Update")
                    {
                        dataSet.Tables["Selling"].Rows[e.RowIndex]["authors"] = dgvViewer.Rows[e.RowIndex].Cells["authors"].Value;
                        dataSet.Tables["Selling"].Rows[e.RowIndex]["title"] = dgvViewer.Rows[e.RowIndex].Cells["title"].Value;
                        dataSet.Tables["Selling"].Rows[e.RowIndex]["description"] = dgvViewer.Rows[e.RowIndex].Cells["description"].Value;
                        dataSet.Tables["Selling"].Rows[e.RowIndex]["price"] = dgvViewer.Rows[e.RowIndex].Cells["price"].Value;
                        dataSet.Tables["Selling"].Rows[e.RowIndex]["count"] = dgvViewer.Rows[e.RowIndex].Cells["count"].Value;

                        sqliteDataAdapter.Update(dataSet, "Selling");
                        dgvViewer.Rows[e.RowIndex].Cells[6].Value = "Delete";
                        Refresh();
                    }

                    Refresh();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка подключения к БД " + exp.Message);
            }
        }

        private void dgvViewer_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (cmdRow == false)
                {
                    cmdRow = true;
                    int lastRow = dgvViewer.Rows.Count - 2;
                    DataGridViewRow row = dgvViewer.Rows[lastRow];
                    DataGridViewLinkCell link = new DataGridViewLinkCell();

                    dgvViewer[6, lastRow] = link;
                    row.Cells["Delete"].Value = "Insert";

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: " + exp.Message);
            }
        }

        private void book_catalog_Load(object sender, EventArgs e)
        {
            sQLiteConnection = new SQLiteConnection("Data Source = B:/proj/visualka/Kursovaya-Pikpo/PIKPO_KURSACH/DataBase/database.db");
            sQLiteConnection.Open();
            LoadData();
        }

        private void dgvViewer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cmdRow == false)
                {
                    int rowIndex = dgvViewer.SelectedCells[0].RowIndex;
                    DataGridViewRow edit = dgvViewer.Rows[rowIndex];
                    DataGridViewLinkCell link = new DataGridViewLinkCell();
                    dgvViewer[6, rowIndex] = link;
                    edit.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка: " + exp.Message);
            }
        }

        private void dgvViewer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(columnValue); // Отписываем событие у Control.KeyPress
            if (dgvViewer.CurrentCell.ColumnIndex == 4 || dgvViewer.CurrentCell.ColumnIndex == 5) // Индекс ячейки для валидации
            {
                TextBox txt = e.Control as TextBox; // Приведение типа ячейки к TextBox

                if (txt != null)
                {
                    txt.KeyPress += new KeyPressEventHandler(columnValue); // Если textbox != null, подписываем событие и в кач-ве метода передаем columnValye
                }
            }
        }

        private void columnValue(object sender, KeyPressEventArgs e)
        {
            // Проверка на то, что введена цифра, а не любая другая кнопка
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = $"authors LIKE '%{textBox_search.Text}'";
            }
            else
            {
                (dgvViewer.DataSource as DataTable).DefaultView.RowFilter = null;
            }

        }
    }
}