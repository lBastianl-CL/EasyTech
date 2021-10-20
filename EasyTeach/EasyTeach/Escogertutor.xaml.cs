using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyTeach
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Escogertutor : ContentPage
    {
        public Escogertutor()
        {
            InitializeComponent();
            btncamilo.Clicked += Btncamilo_Clicked;
            btnadriana.Clicked += Btnadriana_Clicked;
            btnalexander.Clicked += Btnalexander_Clicked;
        }

        private void Btnalexander_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Alexander());
        }

        private void Btnadriana_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Adriana());
        }

        private void Btncamilo_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Camilo());
        }
    }
}