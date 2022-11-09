﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppMinhasCompras.Helper;
using System.IO;

namespace AppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper database;

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "arquivo.db3"
                         );

                    database = new SQLiteDatabaseHelper(path);  
                }

                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
