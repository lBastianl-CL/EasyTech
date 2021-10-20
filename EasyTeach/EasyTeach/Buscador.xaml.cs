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
    public partial class Buscador : ContentPage
    {
        public Buscador()
        {
            InitializeComponent();
            btnBuscar.Clicked += BtnBuscar_Clicked;
            InitApp();
            Asignatura();
            Tematicas();

        }

        private void BtnBuscar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Escogertutor());
        }

        void Tematicas()
        {
            List<String> opcion = new List<string>
            {
                "Inecuaciones",
                "Limites",
                "Derivadas",
                "Matrices",
                "Estática",
                "Dinámica",
                "C# for POO"
            };
            foreach (var opciones in opcion)
            {
                Tematicalist.Items.Add(opciones);
            }
        }
        void Asignatura()
        {
            List<String> opcion = new List<string>
            {
                "Cálculo I",
                "Álgebra Lineal",
                "Micro-economía",
                "Física",
                "Electro-Magnetismo",
                "Termodinámica",
                "Estadísticas"
            };
            foreach (var opciones in opcion)
            {
                Asignaturadlist.Items.Add(opciones);
            }
        }
        void InitApp()
        {
            List<String> opcion = new List<string>
            {
                "Universidad de Chile",
                "Universidad Mayor",
                "Universidad Andrés Bello",
                "Universidad del Desarrollo",
                "Universidad de las Américas",
                "Universidad Bernando O'Higgins"
            };
            foreach (var opciones in opcion)
            {
                universidadlist.Items.Add(opciones);
            }
        }

        private void Universidadlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}