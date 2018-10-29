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

namespace HW_2
{
    public partial class MainForm : Form
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        
        string SQLQueryOrders;
        string SQLQueryEmployees;
        string SQLQueryProducts;
        string SQLQueryCountClients;
        string SQLQueryClientOrderInfo;
        
        public MainForm()
        {
            InitializeComponent();
            InitSQLQuery();
            AddQueryToButtons();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string SQLQuery = (string)btn.Tag;
            TabPage tpParent = (TabPage)btn.Parent;
            Control.ControlCollection ctrlColl = tpParent.Controls;
            DataGridView dg = null;
            ProgressBar pBar = null;
            foreach (var item in ctrlColl)
            {
                if (item.GetType().Name == "DataGridView")
                {
                    dg = (DataGridView)item;
                }
                if (item.GetType().Name == "ProgressBar")
                {
                    pBar = (ProgressBar)item;
                }
            }
           
            if (dg != null && pBar!=null)
            {
                QueryConnect(SQLQuery, dg, pBar);
            }

        }

        async private void QueryConnect(string SQLQuery, DataGridView dgOut, ProgressBar prgOut )
        {
            SqlConnection connection = new SqlConnection
            {
                ConnectionString = ConnectionString
            };
            prgOut.Style = ProgressBarStyle.Marquee;
            prgOut.MarqueeAnimationSpeed = 2;
            prgOut.Value = 0;
            prgOut.Visible = true;
            try
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(SQLQuery, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                int CountColums = reader.FieldCount;
                List<string> IteamsDB = new List<string>();
                StringBuilder sbStr = new StringBuilder();
                if (CountColums > 0)
                {
                    dgOut.ColumnCount = CountColums;
                    for (int i = 0; i < CountColums; i++)
                    {
                        dgOut.Columns[i].Name = reader.GetName(i);
                    }
                    
                    while (await reader.ReadAsync())
                    {
                        IteamsDB.Clear();
                        for (int i = 0; i < CountColums; i++)
                        {
                            IteamsDB.Add(reader[i].ToString());
                        }
                        dgOut.Rows.Add(IteamsDB.ToArray());
                    }
                    
                }
                prgOut.Style = ProgressBarStyle.Blocks;
                prgOut.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prgOut.Style = ProgressBarStyle.Blocks;
                prgOut.Value = 0;

            }
            finally
            {
                connection.Close();
            }
        }

        private void InitSQLQuery() 
        {
            SQLQueryOrders = 
                "SELECT [TAB].[CompanyName], [TAB].[ContactName], [TAB].[Address], [TAB].[City],[TAB].[Country], [TAB].[Phone],"
                + "TAB.OrderDate, TAB.ShippedDate, TAB.Freight, TAB.ShipAddress, TAB.ShipCity, TAB.ShipCountry, "
                + "TAB.ShipRegion, [Order Details].UnitPrice, [Order Details].Quantity,  [Order Details].Discount, "
                + "([Order Details].UnitPrice * [Order Details].Quantity * (1 - [Order Details].Discount) ) "
                + "as Cost FROM  [Order Details] INNER JOIN (SELECT "
                + "ORDERS.OrderID, ORDERS.OrderDate, ORDERS.ShippedDate, ORDERS.Freight, ORDERS.ShipAddress, ORDERS.ShipCity, "
                + "ORDERS.ShipCountry, ORDERS.ShipRegion, [Customers].[CompanyName], "
                + "[Customers].[ContactName], [Customers].[Address], [Customers].[City], "
                + "[Customers].[Country], [Customers].[Phone]"
                + "FROM [ORDERS] INNER JOIN [Customers] "
                + "ON ORDERS.CustomerID = Customers.CustomerID) AS TAB "
                + "ON [Order Details].OrderID = TAB.OrderID ";
            SQLQueryEmployees =                                           
                "SELECT LastName, FirstName, BirthDate, Address, HomePhone FROM Employees";
            SQLQueryProducts =
                "SELECT ProductName, UnitPrice, Discontinued, UnitsInStock, CategoryName FROM Products "
                + "INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID "
                + "WHERE (UnitPrice BETWEEN 10 AND 60) AND Discontinued = 0";
            SQLQueryCountClients =
                "SELECT City, Count(CustomerID) as CountCustomer  FROM Customers GROUP BY City";
            SQLQueryClientOrderInfo =
                 "SELECT [TAB].[CompanyName],  [TAB].[City], [TAB].[Country], TAB.OrderDate, "
                + " SUM (([Order Details].UnitPrice * [Order Details].Quantity * (1 - [Order Details].Discount) )) "
                + "as TotalCost FROM  [Order Details] INNER JOIN (SELECT "
                + "ORDERS.OrderID, ORDERS.OrderDate, [Customers].[CompanyName], "
                + "[Customers].[City], [Customers].[Country] "
                + "FROM [ORDERS] INNER JOIN [Customers] "
                + "ON ORDERS.CustomerID = Customers.CustomerID) AS TAB "
                + "ON [Order Details].OrderID = TAB.OrderID " 
                + "GROUP BY [TAB].[CompanyName], [TAB].[City], [TAB].[Country], TAB.OrderDate";
        }
        private void AddQueryToButtons()
        {
            btnOrders.Tag = SQLQueryOrders;
            btnEmployees.Tag = SQLQueryEmployees;
            btnProducts.Tag = SQLQueryProducts;
            btnCountClients.Tag = SQLQueryCountClients;
            btnClientOrderInfo.Tag = SQLQueryClientOrderInfo;
        }
    }
}
