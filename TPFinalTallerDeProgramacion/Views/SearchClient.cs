using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinalTallerDeProgramacion.Controllers;
using TPFinalTallerDeProgramacion.DAL.Repositories;
using TPFinalTallerDeProgramacion.Views;

namespace TPFinalTallerDeProgramacion.Vista
{
    public partial class SearchClient : Form
    {
        SearchController iSearchController;
        public SearchClient()
        {
            InitializeComponent();
            iSearchController = new SearchController(UnitOfWork.Instance);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cancel(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void search(object sender, MouseEventArgs e)
        {
            //Evento para buscar cliente
        }

        private void searchJuanAmador(object sender, MouseEventArgs e)
        {
            iSearchController.getClientData(Convert.ToInt32(textBoxDNI.Text), Convert.ToInt32(textBoxPIN.Text));
        }

        private void openSearchProducts(object sender, MouseEventArgs e)
        {
            SearchProductOfClient mSearchProductsOfClientView = new SearchProductOfClient();
            mSearchProductsOfClientView.Show();
        }

        private void openGetBalanceView(object sender, EventArgs e)
        {
            GetBalance mGetBalanceViwe = new GetBalance();
            mGetBalanceViwe.Show();
        }

        private void openLastTransactions(object sender, EventArgs e)
        {
            LastTransactions mGetLastTransactionsView = new LastTransactions();
            mGetLastTransactionsView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
