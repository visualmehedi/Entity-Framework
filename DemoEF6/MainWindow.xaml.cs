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
using DemoEF6.Model;

namespace DemoEF6
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DemoEF6Context())
            {
                Customer customer = new Customer();
                customer.CustomerName = tbxCustomerName.Text;
                customer.OrderValue = decimal.Parse(tbxOrderValue.Text);

                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        private void btnSave_product_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DemoEF6Context())
            {
                Product product = new Product();
                product.ProductIName = tbxProductName.Text;
                product.ProductPrice = decimal.Parse(tbxProductPrice.Text);

                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        private void btnMainSave_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DemoEF6Context())
            {
                Order order = new Order();
                order.Name = tbxMainOrder.Text;
                order.Price = decimal.Parse(tbxPris.Text);
                order.Quantity = int.Parse(tbxOrderValue.Text);
                order.SubTotal = decimal.Parse(tbxSumma.Text);
                order.Description = "";

                string customername = tbxMainCustomer.Text;

                Customer customer = db.Customers.Where(c=> c.CustomerName == (string)tbxMainCustomer.Text).Select(c=> c).First();
                customer.Orders.Add(order);
                db.SaveChanges();
            }
        }
    }
}
