using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionStock.model;
using GestionStock.controller;

namespace GestionStock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FounisseurControl controllerF;
        private AnneExerciceControl controllerAE;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            controllerF = new FounisseurControl();
            controllerAE = new AnneExerciceControl();
            gridFournisseur.ItemsSource = controllerF.show();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Fournisseur fournisseur = new Fournisseur();
            fournisseur.nomF = nomF.Text;
            fournisseur.contact = contactF.Text;
            fournisseur.contactTitre = nomF.Text;
            fournisseur.adresse = adressF.Text;
            fournisseur.ville = villeF.Text;
            fournisseur.codePostal = Int32.Parse(codePF.Text);
            fournisseur.department = Int32.Parse(depF.Text);
            fournisseur.country = countryF.Text;
            fournisseur.condPaiement = condPF.Text;
            fournisseur.email = emailF.Text;
            fournisseur.observation = obsF.Text;

            controllerF.add(fournisseur);
            refresh();
        }

        private void gridFournisseur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void gridFournisseur_Initialized(object sender, EventArgs e)
        {
            refresh();
        }

        private void AeCancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addbtn_Click_1(object sender, RoutedEventArgs e)
        {
            controllerAE.add(new AnneeExercice(aeDate.SelectedDate.Value.ToString("yyyy-MM-dd")));
            gridAE_Initialized(sender, e);
        }

        private void gridAE_Initialized(object sender, EventArgs e)
        {
            gridAE.ItemsSource = controllerAE.show();
        }

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
