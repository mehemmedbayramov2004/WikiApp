﻿using System;
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
using WikiApp.Services;
using WikiApp.ViewModels;

namespace WikiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel mvm = new MainViewModel();
            mvm.MyStackPanel = MyStackPanel;
            mvm.MyListView = ListView1;
            DataContext = mvm;
            //Start();
        }



        //public async void Start()
        //{
        //    //var data = await WikipediaService.GetResult("c#");
        //    //var resultText = await WikipediaService.GetData(data.First().PageId);

        //    //MessageBox.Show(resultText);

        //}
    }
}
