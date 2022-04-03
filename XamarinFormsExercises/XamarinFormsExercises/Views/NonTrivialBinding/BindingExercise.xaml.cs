using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsExercises.Views.NonTrivialBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingExercise : ContentPage
    {
        public BindingExercise()
        {
            InitializeComponent();
        }
    }

    #region Step 4
    /* Copy into  BindingExerciseViewModel and replace exisiting properties
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }
        float _steppervalue;
        public float StepperValue
        {
            set => Set<float>(ref _steppervalue, value, "StepperValue");
            get => _steppervalue;
        }
    */

    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    #endregion
}