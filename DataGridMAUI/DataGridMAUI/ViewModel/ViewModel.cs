using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class ViewModel
    {
        public DataTable EmployeeCollection { get; set; }

        public ViewModel()
        {
            this.CreateDataTable();
        }

        /// <summary>
        /// Create the DataTable
        /// </summary>
        private void CreateDataTable()
        {
            EmployeeCollection = new DataTable();
            EmployeeCollection.Columns.Add("CustomerID", typeof(string));
            EmployeeCollection.Columns.Add("Company", typeof(string));
            EmployeeCollection.Columns.Add("ContactName", typeof(string));
            EmployeeCollection.Columns.Add("City", typeof(string));
            EmployeeCollection.Rows.Add("ALFKI", "Alferds Futterkiste", "Maria Anders", "Berlin");
            EmployeeCollection.Rows.Add("ANATR", "Ana Trujilo Emparedados y Hela", "Ana Trujilo", "Mexico D.F.");
            EmployeeCollection.Rows.Add("ANTON", "Antonio Moreno Taqueria", "Antonio Moreno", "Mexico D.F.");
            EmployeeCollection.Rows.Add("AROUT", "Around the Horn", "Thomas Hardy", "London");
            EmployeeCollection.Rows.Add("BERGS", "Berglunds Snabbkop", "Christina Berglund", "Lulea");
            EmployeeCollection.Rows.Add("BLAUS", "Blauer see Delikatessen", "Hanna Moss", "Mannheim");
            EmployeeCollection.Rows.Add("BLONP", "Blondel Pere et Fils", "Erederique Citeaux", "Strasbourg");
            EmployeeCollection.Rows.Add("BOLID", "Bolids Comidas Preparadas", "Martin Sommer", "Madrid");
            EmployeeCollection.Rows.Add("BONP", "Bon App", "Laurence Lebihan", "Marseille");
            EmployeeCollection.Rows.Add("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Tsawassen");
            EmployeeCollection.Rows.Add("BSBEV", "B's Beverages", "Victoria Ashworth", "London");
            EmployeeCollection.Rows.Add("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Bueno Aires");
            EmployeeCollection.Rows.Add("CENTC", "Centro Comercial Moctezuma", "Francisco Chang", "Mexico D.F.");
            EmployeeCollection.Rows.Add("CHOPS", "Chop-Suey Chinese", "Yang Wang", "Bern");
            EmployeeCollection.Rows.Add("COMMI", "Comercio Minerio", "Pedro Afonso", "Sao Paulo");
            EmployeeCollection.Rows.Add("CONSH", "Consolidated Holdings", "Elizabeth Brown", "London");
            EmployeeCollection.Rows.Add("DRACD", "Drachenblut Entier", "Sven Ottlieb", "Aachen");
            EmployeeCollection.Rows.Add("DUMON", "Dumonde Entier", "Janine Labrune", "Nantes");
            EmployeeCollection.Rows.Add("EASTC", "Eastern Connection", "Ann Devon", "London");
            EmployeeCollection.Rows.Add("ERNSH", "Ernst Handel", "Roland Mendel", "Graz");
        }
    }
}
