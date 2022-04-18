using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsExercises.ViewModels
{
	public class GridBindingExerciseViewModel : BaseViewModelFinal
	{
		string _name;
		public string Name { get; set; } 

		string _email;
		public string Email { get; set; }

		ICommand _cityToggle;
		public ICommand CityToggle => _cityToggle;
        public GridBindingExerciseViewModel()
        {
			_cityToggle = new Command<string>(CityToggleCommand);
		}

		private void CityToggleCommand (string CommandParameters)
        {
		}
	}
}
