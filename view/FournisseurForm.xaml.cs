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
using System.Windows.Shapes;
using GestionStock.model;


namespace GestionStock.view
{
    /// <summary>
    /// Logique d'interaction pour FournisseurForm.xaml
    /// </summary>
    public partial class FournisseurForm : Window
    {
        public FournisseurForm()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Fournisseur fournisseur = new Fournisseur();
        }

        private void ajouterBtn_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
    }
}
