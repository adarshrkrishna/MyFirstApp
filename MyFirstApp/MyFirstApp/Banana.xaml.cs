﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Banana : ContentPage
    {
        public Banana()
        {
            InitializeComponent();
        }
    }
}