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

        public ApplicationDbContext ApplicationDbContext { get => applicationDbContext; set => applicationDbContext = value; }

        Wypożyczenie NoweWypożyczenie = new Wypożyczenie();

        public MainWindow(ApplicationDbContext applicationDbContext)
        {
            this.ApplicationDbContext = applicationDbContext;
            InitializeComponent();
            GetWypożyczenia();
            GetFilmy();
            GetReżyserzy();
            GetKlienci();

            DodajWypożyczenie.DataContext = NoweWypożyczenie;
        }

        private void GetWypożyczenia()
        {
            WypożyczeniaDG.ItemsSource = applicationDbContext.Wypożyczenia.ToList();
        }
        private void GetFilmy()
        {
            WypożyczeniaDG.ItemsSource = applicationDbContext.Filmy.ToList();
        }
        private void GetReżyserzy()
        {
            WypożyczeniaDG.ItemsSource = applicationDbContext.Reżyserzy.ToList();
        }
        private void GetKlienci()
        {
            WypożyczeniaDG.ItemsSource = applicationDbContext.Klienci.ToList();
        }
    }
}
