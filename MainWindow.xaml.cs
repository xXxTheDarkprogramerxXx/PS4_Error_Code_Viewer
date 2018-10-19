using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace PS4_Error_Code_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataTable dttemp = new DataTable();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load Error DB 

            //File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"\Error_Codes.txt", Properties.Resources.Error_Codes);

            //now load them all into the db 

            dttemp.Columns.Add("PS4 Code");
            dttemp.Columns.Add("Hex Code");
            dttemp.Columns.Add("SCE_Error");
            dttemp.Columns.Add("Description");


            StringReader sr = new StringReader(Properties.Resources.Error_Codes);

            while (sr.ReadLine() != null)
            {
                //Console.WriteLine(sr.ReadLine());
                var splittedstring = sr.ReadLine().Split(',');
                if(splittedstring.Length >1)
                {
                    dttemp.Rows.Add(splittedstring[0].ToString().Replace("\"", ""), splittedstring[1].ToString().Replace("\"", ""), splittedstring[2].ToString().Replace("\"", ""), splittedstring[4].ToString().Replace("\"", ""));
                }
            }
            dataGrid.DataContext = dttemp.DefaultView;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            StringBuilder filter = new StringBuilder();
            if (!(string.IsNullOrEmpty(txtSearch.Text)))
                filter.Append("[PS4 Code] Like '%" + txtSearch.Text + "%'");

            if (!(string.IsNullOrEmpty(txtSearch.Text)))
            {
                if (filter.Length > 0) filter.Append(" OR ");
                filter.Append("[Hex Code] Like '%" + txtSearch.Text + "%'");
            }

            if (!(string.IsNullOrEmpty(txtSearch.Text)))
            {
                if (filter.Length > 0) filter.Append(" OR ");
                filter.Append("SCE_Error Like '%" + txtSearch.Text + "%'");
            }
            if (!(string.IsNullOrEmpty(txtSearch.Text)))
            {
                if (filter.Length > 0) filter.Append(" OR ");
                filter.Append("Description Like '%" + txtSearch.Text + "%'");
            }
            DataView dv = dttemp.DefaultView;
            dv.RowFilter = filter.ToString();
        }

        private void lblCopy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Process.Start(@"https://github.com/xXxTheDarkprogramerxXx/"); 
        }
    }
}
