using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewDataModelExercisePage : ContentPage
    {
        public string Greetings { get; } = "Hello";
        public IEnumerable<CityPopulation> CityList { get; }
        public ListViewDataModelExercisePage()
        {
            InitializeComponent();

            CityList = CityPopulation.List;

            //DataModelList.ItemsSource = CityPopulation.List;
            BindingContext = this;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");

            ((ListView)sender).SelectedItem = null;
        }



        /*
              public ListViewDataModelExercisePage()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
        */
    }
}

