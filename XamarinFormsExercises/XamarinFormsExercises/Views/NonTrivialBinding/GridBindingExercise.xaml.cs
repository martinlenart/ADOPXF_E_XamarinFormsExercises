using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsExercises.ViewModels;

namespace XamarinFormsExercises.Views.NonTrivialBinding
{
	public partial class GridBindingExercise : ContentPage
	{
		public GridBindingExercise()
		{
			InitializeComponent();
			BindingContext = new GridBindingExerciseViewModel();
		}
	}
}

