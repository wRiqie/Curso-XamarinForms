using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirContentPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirNavigationPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage (new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirCarouselPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirTabbedPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirMasterDetailPage(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirPaginaModal(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirStackLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.PilhaLayout.Pilha();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirGrid(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.GradeLayout.Grade();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void VoltarParaHome(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new AppBase.Inicio();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirAbsoluteLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.AbsolutoLayout.Absoluto();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirRelativeLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.RelativoLayout.Relativo();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirFlexLayout(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Leiautes.FlexivelLayout.Flexivel();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }

        private void AbrirLabel(object sender, EventArgs e)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Controles.RotuloControle.Rotulo();
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}