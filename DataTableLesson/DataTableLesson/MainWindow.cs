using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableLesson
{
    public partial class MainWindow : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;

        public MainWindow()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<MainWindow>();

            var config = builder.Build();

            var connectionString = config["DefaultConnection"];

            conn = new SqlConnection(connectionString);

            conn.Open();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using SqlCommand cmd = new("select [name] from sys.tables", conn);
            using SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                tablesBox.Items.Add(reader["name"]);
            }
        }

        private void getAllDatabtn_Click(object sender, EventArgs e)
        {
            if (tablesBox.SelectedItem == null)
            {
                MessageBox.Show("Select table first", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            adapter = new($"select * from {tablesBox.SelectedItem.ToString()}", conn);

            DataSet ds = new();
            adapter.Fill(ds);

            dbDataGridView.DataSource = ds.Tables[0];
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using SqlCommandBuilder builder = new(adapter);

            DataTable table = (DataTable)dbDataGridView.DataSource;

            adapter.Update(table);
        }
    }
}
