﻿using classes_gezamelijke_opdracht.Game_Classes;
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

namespace classes_gezamelijke_opdracht
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

        Held Slikker = new Held();


        private void btnsimuleerxp_Click(object sender, RoutedEventArgs e)
        {
            Slikker.AddXp(5);

            string text = Slikker.GetNaam() + ": Level=" + Slikker.GetLevel() + " XP=" + Slikker.GetXp();

            labelInfo.Items.Insert(0, text);
        }
    }
}