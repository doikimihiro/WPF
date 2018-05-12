namespace WpfApplication.ViewModels
{
    using WpfApplication.Commands;
    using WpfApplication.Models;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.OpenMessageDialogCommand = new OpenMessageDialogCommand();
            this.UserModel = new UserModel();
        }

        public OpenMessageDialogCommand OpenMessageDialogCommand { get; set; }

        public UserModel UserModel { get; set; }
    }
}
//ViewはCommandの具体的な中身を知らなくて良い
//そうすることでViewはロジックを気にせずUIに専念できる