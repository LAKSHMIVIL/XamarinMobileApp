using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        bool m_BtnClicked;
        public MainPage()
        {
            InitializeComponent();

        }
        private void DashMyPolicies_Click(object sender, EventArgs e)
        {

            if (!m_BtnClicked)
            {
                m_BtnClicked = true;
                Navigation.PushAsync(new MyPolicies());

            }
            else
            {
                m_BtnClicked = false;
            }
        }

        protected override void OnAppearing()
        {
            m_BtnClicked = false;
        }
    }

}
