using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.UI
{
    public partial class SelectingValueExercisePage : ContentPage
    {
        public SelectingValueExercisePage()
        {
            InitializeComponent();
        }

        private void checkbox_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var chk = sender as CheckBox;
            lblPropChanged.IsVisible = chk.IsChecked;
           
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var sld = sender as Slider;
            lblPropChanged.Opacity = sld.Value / 100;
        }
  
        private void stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var dt = sender as DatePicker;
            lblPropChanged.Text = $"{dt.Date:F}";
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void picker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var pic = sender as Picker;
            if (pic.SelectedIndex != -1)
            {
                lblPropChanged.Text = pic.Items[pic.SelectedIndex];
            }
        }
    }
}
