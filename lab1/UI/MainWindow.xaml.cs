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
using EquipmentGuides;
using Microsoft.Win32;
using XmlProcessing;

namespace UI
{
    /// <summary>
    /// The class representing a main window
    /// </summary>
    
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Equipment guide
        /// </summary>
        
        private EquipmentGuide equipmentGuide;

        /// <summary>
        /// /// Creates an instance of the MainWindow class
        /// </summary>
        
        public MainWindow()
        {
            InitializeComponent();
            equipmentGuide = new EquipmentGuide();
        }

        /// <summary>
        /// Fills the table
        /// </summary>
        
        private void FillTable()
        {
            showTable.Items.Clear();
            foreach (var equipment in equipmentGuide.EquipmentList)
            {
                showTable.Items.Add(equipment);
            }
        }

        /// <summary>
        /// Deletes elements by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Items deleted:{showTable.SelectedItems.Count}.",
                        "Deleting info", MessageBoxButton.OK, MessageBoxImage.Information);
            foreach (var item in showTable.SelectedItems)
            {
                equipmentGuide.EquipmentList.Remove((Equipment)item);
            }
            FillTable();
        }

        /// <summary>
        /// Selects a file by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                if (XmlValidator.ValidateXml(filePath, @"..\..\..\xsdSchema.xsd"))
                {
                    equipmentGuide = XmlReader.Read(filePath);
                    FillTable();
                    MessageBox.Show("The document has been uploaded successfully.",
                        "Uploading info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("The document don't match schema.", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("The file hasn't been uploaded.",
                    "Uploading info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Saves data to xml file by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            if (equipmentGuide.EquipmentList.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "xml files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == true)
                {
                    var path = saveFileDialog.FileName;
                    XmlWriter.Save(equipmentGuide, path);
                    MessageBox.Show("Data has been saved successfully.",
                        "Saving info", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Data hasn't been saved.",
                        "Saving info", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("No data to save.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        /// <summary>
        /// Opens the adding window by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            if (addWindow.Equipment != null)
            {
                equipmentGuide.EquipmentList.Add(addWindow.Equipment);
                MessageBox.Show("Item has been added successfully.",
                    "Adding info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Item hasn't been added.",
                    "Adding info", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            FillTable();
        }

        /// <summary>
        /// Opens the editing window for editing selected element by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (showTable.SelectedItems.Count == 1)
            {
                EditWindow editWindow = new EditWindow((Equipment)showTable.SelectedItems[0]);
                editWindow.ShowDialog();
                FillTable();
            }
            else
            {
                MessageBox.Show("Please select one item.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
