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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox1.Items.Add("1");
            combobox1.Items.Add("2");
            combobox1.Items.Add("3");
            combobox1.Items.Add("4");
            combobox1.Items.Add("5");



            Listbox1.Items.Insert(0, "COMP100");
            Listbox1.Items.Insert(1, "COMP213");
            Listbox1.Items.Insert(2, "COMP120");
            Listbox1.Items.Insert(3, "COMP125");

            Listbox1.SelectionMode = SelectionMode.Multiple;
        }

    }
}
