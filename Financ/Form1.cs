using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeFinanceApp
{
    public partial class MainForm : Form
    {
        private SqlConnection connection;
        private DataSet dataSet;
        private SqlDataAdapter categoriesAdapter;
        private SqlDataAdapter transactionsAdapter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["HomeFinanceConnection"].ConnectionString;
                connection = new SqlConnection(connectionString);

                InitializeDataAdapters();
                LoadData();
                SetupDataGridViews();

                dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimePickerEnd.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataAdapters()
        {
            categoriesAdapter = new SqlDataAdapter("SELECT * FROM Категории", connection);
            new SqlCommandBuilder(categoriesAdapter);

            transactionsAdapter = new SqlDataAdapter("SELECT * FROM Транзакции", connection);
            new SqlCommandBuilder(transactionsAdapter);
        }

        private void LoadData()
        {
            try
            {
                dataSet = new DataSet();

                categoriesAdapter.Fill(dataSet, "Категории");
                transactionsAdapter.Fill(dataSet, "Транзакции");

                // Проверка, что данные загружены
                if (dataSet.Tables["Категории"].Rows.Count == 0)
                {
                    MessageBox.Show("Таблица категорий пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dataSet.Tables["Транзакции"].Rows.Count == 0)
                {
                    MessageBox.Show("Таблица транзакций пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataRelation relation = new DataRelation("КатегорияТранзакция",
                    dataSet.Tables["Категории"].Columns["Id"],
                    dataSet.Tables["Транзакции"].Columns["КатегорияId"]);
                dataSet.Relations.Add(relation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridViews()
        {
            // Настройка DataGridView для Категорий
            dataGridViewCategories.DataSource = dataSet.Tables["Категории"];
            dataGridViewCategories.Columns["Id"].ReadOnly = true;
            dataGridViewCategories.Columns["Id"].HeaderText = "ID";
            dataGridViewCategories.Columns["Название"].HeaderText = "Название категории";
            dataGridViewCategories.Columns["Тип"].HeaderText = "Тип";

            // Настройка DataGridView для Транзакций
            dataGridViewTransactions.DataSource = dataSet.Tables["Транзакции"];
            dataGridViewTransactions.Columns["Id"].ReadOnly = true;
            dataGridViewTransactions.Columns["Id"].HeaderText = "ID";
            dataGridViewTransactions.Columns["КатегорияId"].HeaderText = "ID категории";
            dataGridViewTransactions.Columns["Сумма"].HeaderText = "Сумма";
            dataGridViewTransactions.Columns["Дата"].HeaderText = "Дата";
            dataGridViewTransactions.Columns["Описание"].HeaderText = "Описание";

            // Добавляем выпадающий список категорий
            DataGridViewComboBoxColumn categoryColumn = new DataGridViewComboBoxColumn();
            categoryColumn.HeaderText = "Категория";
            categoryColumn.DataSource = dataSet.Tables["Категории"];
            categoryColumn.DisplayMember = "Название";
            categoryColumn.ValueMember = "Id";
            categoryColumn.DataPropertyName = "КатегорияId";
            dataGridViewTransactions.Columns.Add(categoryColumn);

            // Скрываем столбец с ID категории
            dataGridViewTransactions.Columns["КатегорияId"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем изменения в базе данных
                categoriesAdapter.Update(dataSet, "Категории");
                transactionsAdapter.Update(dataSet, "Транзакции");
                MessageBox.Show("Изменения сохранены успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecuteStoredProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("ОтчетПоКатегориям", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@НачалоДаты", dateTimePickerStart.Value.Date);
                    command.Parameters.AddWithValue("@КонецДаты", dateTimePickerEnd.Value.Date);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewStoredProcedure.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении хранимой процедуры: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            // Обработчик изменения даты начала периода
        }
    }
}