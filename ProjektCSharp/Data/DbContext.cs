﻿using Microsoft.EntityFrameworkCore;
using ProjektCSharp.Data;


namespace Wypożyczenia
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        internal DbSet<Film> Filmy { get; set; }
        internal DbSet<Klient> Klienci { get; set; }
        internal DbSet<Reżyser> Reżyserzy { get; set; }
        internal DbSet<Wypożyczenie> Wypożyczenia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasData(GetFilmy());
            modelBuilder.Entity<Wypożyczenie>().HasData(GetWypożyczenia());
            modelBuilder.Entity<Reżyser>().HasData(GetReżyserzy());
            modelBuilder.Entity<Klient>().HasData(GetKlienci());

            base.OnModelCreating(modelBuilder);
        }

        private Film[] GetFilmy()
        {
            return new Film[]
            {
                new Film { Id_film = 1, Tytuł = "Nienawistna ósemka", Gatunek="Dramat", Reżyser="Quentin Tarantino"},
                new Film { Id_film = 2, Tytuł = "Contratiempo", Gatunek = "Kryminał", Reżyser = "Oriol Paulo" },
                new Film { Id_film = 3, Tytuł = "Skazani na Shawshank", Gatunek = "Dramat", Reżyser = "Frank Darabont" },
            };
        }

        private Wypożyczenie[] GetWypożyczenia()
        {
            return new Wypożyczenie[]
            {
                new Wypożyczenie{ Id_film = 2, Id_klient = 3},
                new Wypożyczenie{ Id_film = 1, Id_klient = 2},
                new Wypożyczenie{ Id_film = 3, Id_klient = 1},
            };
        }

        private Reżyser[] GetReżyserzy()
        {
            return new Reżyser[]
            {
                new Reżyser{ Id_reżyser = 1, Imię = "Quentin", Nazwisko="Tarantino", Kraj_pochodzenia= "Stany Zjednoczone"},
                new Reżyser{ Id_reżyser = 2, Imię = "Oriol", Nazwisko="Paulo", Kraj_pochodzenia= "Hiszpania"},
                new Reżyser{ Id_reżyser = 3, Imię = "Frank", Nazwisko="Darabont", Kraj_pochodzenia= "Francja"},
            };
        }
        private Klient[] GetKlienci()
        {
            return new Klient[]
            {
                new Klient{ Id_klient = 1, Imię = "Jan", Nazwisko = "Kowalski", Numer_telefonu = "222333444"},
                new Klient{ Id_klient = 2, Imię = "Mariusz", Nazwisko = "Czerwiński", Numer_telefonu = "222333444"},
                new Klient{ Id_klient = 3, Imię = "Korneliusz", Nazwisko = "Ostrowski", Numer_telefonu = "222333444"},

            };
        }

    }
}
