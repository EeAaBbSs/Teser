using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Teser
{
    public class DataBase
    {
        public SqlConnection sqlConnection =
            new SqlConnection(
                @"Data Source=DESKTOP-ANT0TMK\SQLEXPRESS;Initial Catalog=RU18;Integrated Security=True");
        public SqlCommand command = new SqlCommand();
        public SqlDataAdapter adapter = new SqlDataAdapter();

        public static string obj = String.Empty;
        public static string cost = String.Empty;
        public static string KDNumber = String.Empty;
        public static string KDDateDetermenation = String.Empty;
        public static int taxYear = 20000;
        public static int dropTax = 550000;
        public static int dropTaxYear = 11000;
        public static int saving = 9000;
        public static string notes = String.Empty;

        public void OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Подключение выполнено успешно");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!", "Невозможно подключиться к Базе Данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                    MessageBox.Show("Connection are closed");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!", "Невозможно закрыть соединение с Базой данных", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public void PostInfo(string abc)
        {
            try
            {
                var scanDoc = new ScanDoc();
                obj = scanDoc.FindObject(abc);
                KDNumber = scanDoc.FindKadNumber(abc);
                cost = scanDoc.FindKadCost(abc);
                KDDateDetermenation = scanDoc.FindKDdateDetermenation(KDNumber);
                string sqlExpression =
                    $"INSERT INTO testTable (Object, KDNumber, KDcost, KDdateDetermenation, taxYear, dropTax, dropTaxYear, saving, notes) VALUES ('{obj}', '{KDNumber}', '{cost}', '{KDDateDetermenation}', '{taxYear}', '{dropTax}', '{dropTaxYear}', '{saving}', '{notes}')";
                sqlConnection.Open();
                command = new SqlCommand(sqlExpression, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Данные занесены в таблицу");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}