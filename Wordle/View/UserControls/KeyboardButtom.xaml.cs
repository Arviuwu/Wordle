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

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for KeyboardButtom.xaml
    /// </summary>
    public partial class KeyboardButtom : UserControl
    {
        public KeyboardButtom()
        {
            InitializeComponent();
        }
        private int Content;

        public int content
        {
            get { return Content; }
            set { Content = value; }
            
        }

    }
}
