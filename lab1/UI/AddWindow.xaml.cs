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
using System.Windows.Shapes;
using System.Globalization;
using EquipmentGuides;

namespace UI
{
    /// <summary>
    /// The class representing a window for creating and adding element
    /// </summary>
    
    public partial class AddWindow : Window
    {
        /// <summary>
        /// Created equipment
        /// </summary>
        
        public Equipment Equipment;

        /// <summary>
        /// Creates an instance of the AddWindow class
        /// </summary>
        
        public AddWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks inputed character in year textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void yearBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        /// <summary>
        /// Checks inputed character in cost textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void costBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool result = (Char.IsDigit(e.Text, 0)) || ((e.Text == ".") && (SeparatorCount(((TextBox)sender).Text) < 1));
            e.Handled = !result;
        }

        /// <summary>
        /// Counts sepatator number
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Separator number</returns>
        
        private int SeparatorCount(string s)
        {
            string s1 = ".";
            int count = (s.Length - s.Replace(s1, "").Length);
            return count;
        }

        /// <summary>
        /// Creates element from inputed data by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var name = nameBox.Text;
            var owner = (Organizations)Enum.Parse(typeof(Organizations),ownerBox.Text);
            var cost = double.Parse(costBox.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                CultureInfo.InvariantCulture);
            var year = int.Parse(yearBox.Text);
            Equipment = new Equipment(name, owner, cost, year);
            this.Close();
        }
    }
}
