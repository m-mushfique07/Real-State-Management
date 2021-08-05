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
    public partial class AddSociety : Form
    {
        public AddSociety()
        {
            InitializeComponent();
        }

        List<ResidentialSociety> lstSociety = new List<ResidentialSociety>();

        private void btnAddData_Click(object sender, EventArgs e)
        {

            var data = AddSocietyDetail();

            bool isEmpty = !lstSociety.Any();
            if (data == null)
            {
                MessageBox.Show("Please add appropriate data");
            }
            else
            {
                MessageBox.Show("Added Successfully");
            }
        }

        public List<ResidentialSociety> AddSocietyDetail()
        {
            var societyName = txtSocietyName.Text;
            var tower = txtTower.Text;
            var location = txtLocation.Text;
            lstSociety.Add(new ResidentialSociety() { Id = 1, SocietyName = societyName, Tower = tower, Location = location });

            DataTable dt = new DataTable();
            
            return lstSociety;
        }
    }
}
