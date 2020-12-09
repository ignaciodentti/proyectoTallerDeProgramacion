﻿using System;
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
            iSearchController.searchJuanAmador();
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
    }
}
