using System;
using System.Collections.Generic;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewImageExercisePage : ContentPage
    {
        public ListViewImageExercisePage()
        {
            InitializeComponent();
            //use CityPicture.List;
        }

        private async void ImageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CityPicture item = (CityPicture)e.Item;
        }
    }
}

