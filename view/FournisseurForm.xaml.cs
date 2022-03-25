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
<<<<<<< HEAD
using GestionStock.model;
=======
>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60


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
<<<<<<< HEAD
            Fournisseur fournisseur = new Fournisseur();
=======
            
>>>>>>> 9e1dfd95c19a77a2f2a3df4a328cb94a1b3b6e60
        }

        private void ajouterBtn_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
    }
}
