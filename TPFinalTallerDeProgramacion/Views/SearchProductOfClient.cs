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

namespace TPFinalTallerDeProgramacion.Views
{
    public partial class SearchProductOfClient : Form
    {
        SearchController iSearchController;
        public SearchProductOfClient()
        {
            InitializeComponent();
            iSearchController = new SearchController(UnitOfWork.Instance);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void searchProducts(object sender, MouseEventArgs e)
        {
            int mDNIPrueba = 12345679; //SE DEBE UTILIZAR EL DNI CON EL CUAL SE HIZO EL LOGIN
            this.iSearchController.searchProducts(mDNIPrueba);
        }
    }
}
