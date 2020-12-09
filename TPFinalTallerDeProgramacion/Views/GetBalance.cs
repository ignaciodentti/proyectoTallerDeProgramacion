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
    public partial class GetBalance : Form
    {
        SearchController iSearchController;
        public GetBalance()
        {
            InitializeComponent();
            iSearchController = new SearchController(UnitOfWork.Instance);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void getBalance(object sender, EventArgs e)
        {
            int mDNI = 12345680;
            iSearchController.getBalance(mDNI);
        }
    }
}
