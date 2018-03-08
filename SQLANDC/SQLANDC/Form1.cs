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

namespace SQLANDC
{
    public partial class vendorDataGrid : Form
    {

       

        public vendorDataGrid()
        {
            InitializeComponent();
        }
      

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            // Define connection string. 
            string connString = @"Server=PL6\MTCDB;Database=AdventureWorks2012;Trusted_Connection=True;";

            // Define the connection using the connection string.
            SqlConnection sqlConn = new SqlConnection(connString);

            // Define a data adapter to pull the data from the server using the connection
            // and a stored procedure.
            SqlDataAdapter sqlDA = new SqlDataAdapter("spAllVendors", sqlConn);

            // Declare an empty data table to hold the data.
            DataTable vendorsDT = new DataTable();

            // Fill the data table using the data adapter.
            sqlDA.Fill(vendorsDT);

            // Use the data table as the data source for a data grid control.
            vendorDG.DataSource = vendorsDT;
        }
    }
}
