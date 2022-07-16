using System.Windows;
using Microsoft.EntityFrameworkCore;
using ProjektCSharp.Data;
using System;
using Wypożyczenia.Data;
using System.Linq;

namespace ProjektCSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationDbContext applicationDbContext;
        public MainWindow(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            InitializeComponent();
            GetWypożyczenia();
        }

        private void GetWypożyczenia()
        {
            WypożyczeniaDG.ItemsSource = applicationDbContext.Wypożyczenia.ToList();
        }
    }
}
