﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTeach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alexander : ContentPage
    {
        public Alexander()
        {
            InitializeComponent();
            btncontinuar.Clicked += Btncontinuar_Clicked;
        }

        private void Btncontinuar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Agendar());
        }
    }
}