using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStateManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddSociety_Click(object sender, EventArgs e)
        {
            AddSociety addSociety = new AddSociety();
            addSociety.ShowDialog();
        }

        private void btnDispSociety_Click(object sender, EventArgs e)
        {

            AddSociety obj = new AddSociety();
            var data = obj.AddSocietyDetail();

            dgvSociety.DataSource = data;

        }
    }
}
