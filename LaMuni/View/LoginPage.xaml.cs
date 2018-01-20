using System.Linq;
using LaMuni.Model;
using LaMuni.ViewModel;
using Realms;
using Xamarin.Forms;

namespace LaMuni.View
{
    public partial class LoginPage : ContentPage
    {

        private Realm _realm;

        private InicioModel _inicioParam { get; set; }


        public InicioModel InicioParam
        {
            get
            {
                return _inicioParam;
            }
            set
            {
                _inicioParam = value;
                OnPropertyChanged("InicioParam");
            }
        }


        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel();
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {

            _realm = Helpers.UtilDB.GetInstanceRealm();

            InicioParam = new InicioModel();

            if (RemSwitch.IsToggled)
            {
                _realm.Write(() =>
                {
                    InicioParam.RecuerdaUser = true;

                    _realm.Add<InicioModel>(InicioParam, true);
                });
            }
            else
            {
                _realm.Write(() =>
               {
                    InicioParam.RecuerdaUser = false;

                    _realm.Add<InicioModel>(InicioParam, true);

                    txtEmail.Text = "";

                    txtPass.Text = "";
               });
            }

        }
    }
}
