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
    /// The class representing a window for editing element
    /// </summary>

    public partial class EditWindow : Window
    {
        /// <summary>
        /// Editing equipment
        /// </summary>
        
        private Equipment equipment;

        // <summary>
        /// Creates an instance of the EditWindow class
        /// </summary>
        
        public EditWindow(Equipment equipment)
        {
            InitializeComponent();
            this.equipment = equipment;
            nameBox.Text = equipment.Name;
            ownerBox.SelectedItem = equipment.OwnerOrganization;
            costBox.Text = equipment.Cost.ToString();
            yearBox.Text = equipment.ProductionYear.ToString();
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
        /// Edits element by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            equipment.Name = nameBox.Text;
            equipment.OwnerOrganization = (Organizations)Enum.Parse(typeof(Organizations), ownerBox.Text);
            equipment.Cost = double.Parse(costBox.Text.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator),
                CultureInfo.InvariantCulture);
            equipment.ProductionYear = int.Parse(yearBox.Text);
            MessageBox.Show("Item has been edited.",
                    "Editing info", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
