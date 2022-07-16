using System.Windows;
using Microsoft.EntityFrameworkCore;
using ProjektCSharp.Data;
using System;



namespace ProjektCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly DbContext dbContext;
        public MainWindow(DbContext dbContext)
        {
            this.dbContext = dbContext;
            InitializeComponent();
            GetWypożyczenia();
        }

        private void GetWypożyczenia()
        {
            WypożyczeniaDG.ItemsSource = dbContext.Wypożyczenie.ToList();
        }
    }
}
