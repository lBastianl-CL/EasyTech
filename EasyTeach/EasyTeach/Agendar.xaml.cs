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
    public partial class Agendar : ContentPage
    {
        public Agendar()
        {
            InitializeComponent();
            InitApp();
            btn10.Clicked += Btn10_Clicked;
            btn11.Clicked += Btn11_Clicked;
            btn13.Clicked += Btn13_Clicked;
            btn14.Clicked += Btn14_Clicked;
        }

        private void Btn14_Clicked(object sender, EventArgs e)
        {
            btn14.Text = "Registrado";
        }

        private void Btn13_Clicked(object sender, EventArgs e)
        {
            btn13.Clicked += Btn13_Clicked1;
        }

        private void Btn13_Clicked1(object sender, EventArgs e)
        {
            btn13.Text = "Registrado";
        }

        private void Btn11_Clicked(object sender, EventArgs e)
        {
            btn11.Text = "Registrado";
        }

        private void Btn10_Clicked(object sender, EventArgs e)
        {
            btn10.Text = "Registrado";
        }

        void InitApp()
        {
            List<String> opcion = new List<string>
            {
                "Biblioteca",
                "Fábrica, Universidad Mayor",
                "Otro Lugar"
                
            };
            foreach(var p in opcion)
            {
                pickeragendar.Items.Add(p);
            }
        }
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}