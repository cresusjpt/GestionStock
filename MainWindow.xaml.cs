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
<<<<<<< HEAD
using GestionStock.model;
using GestionStock.controller;
=======
>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60

namespace GestionStock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
            FounisseurControl controller = new FounisseurControl();
            List<Fournisseur>  fournisseurs = controller.show();
            foreach (Fournisseur fournisseur in fournisseurs)
            {

            }
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
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
            fournisseur.nomF = nomF.Text;
=======
>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60
        }
    }
}
