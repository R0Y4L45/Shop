using ShopProgramWpf.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace ShopProgramWpf.UserControls
{
    public partial class Uc_Control : UserControl, INotifyPropertyChanged
    {
        public Product? product { get; set; }
        public int count { get; set; }
        public float cost { get; set; }
        public bool isAdd { get; set; }
        public float Sum { get; set; }



        public Uc_Control(int count,float cost)
        {
            InitializeComponent();
            DataContext = this;
            this.count = count;
            this.cost = cost;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged(string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (product!.Count == 0)
                return;
            isAdd = true;
            product.Count--;
            Sum += product.Cost;
            lblConutProduct.Content = product.Count.ToString();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (product!.Count == count)
                return;
            isAdd = false;
            product.Count++;
            Sum -= product.Cost;
            lblConutProduct.Content = product.Count.ToString();
        }

        
    }
}
