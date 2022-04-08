using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.UI
{
    public partial class SelectingValueExercisePage : ContentPage
    {
        public SelectingValueExercisePage()
        {
            InitializeComponent();
            picker.ItemsSource = Person.Factory.CreateRandom(10);
        }

        private void checkbox_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }
  
        private void stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var pic = sender as Picker;
            if (pic.SelectedIndex == -1) return;

            lblPropChanged.Text = pic.Items[pic.SelectedIndex];
        }
    }
}
