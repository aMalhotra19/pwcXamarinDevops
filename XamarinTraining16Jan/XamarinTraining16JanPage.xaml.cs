using Xamarin.Forms;

namespace XamarinTraining16Jan
{
    public partial class XamarinTraining16JanPage : ContentPage
    {
        public XamarinTraining16JanPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var inputA = int.Parse(this.txtEntryA.Text);
            var inputB = int.Parse(this.txtEntryB.Text);
            var result = inputA + inputB;
            this.txtOutput.Text = result.ToString();
        }
    }
}
