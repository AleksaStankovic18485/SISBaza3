using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using SisBaza2.Entiteti;

namespace SisBaza2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLoadBaze_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void narodnaSkupstina_Click(object sender, EventArgs e)
        {

        }
    }
}
