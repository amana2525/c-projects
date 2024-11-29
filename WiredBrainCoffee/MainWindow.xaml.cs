using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the current column index of CustomerList
            var currentColumn = (int)CustomerList.GetValue(Grid.ColumnProperty);

            // Swap the columns (0 <-> 1)
            int newColumn = currentColumn == 0 ? 1 : 0;

            // Apply the new column index to CustomerList
            CustomerList.SetValue(Grid.ColumnProperty, newColumn);
        }



        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Add a new customer to the list
            if (!string.IsNullOrWhiteSpace(FirstnameBox.Text) && !string.IsNullOrWhiteSpace(LastnameBox.Text))
            {
                string newCustomer = $"{FirstnameBox.Text} {LastnameBox.Text}";
                CustomerList.Items.Add(newCustomer);
                FirstnameBox.Clear();
                LastnameBox.Clear();
                IsDeveloper.IsChecked = false;
            }
            else
            {
                MessageBox.Show("Please enter both first and last names.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Remove selected customer from the list
            if (CustomerList.SelectedItem != null)
            {
                CustomerList.Items.Remove(CustomerList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}