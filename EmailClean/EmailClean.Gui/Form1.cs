using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailClean;
using EmailClean.Data;


namespace EmailClean.Gui
{
    public partial class Form1 : Form
    {
        private EmailClean _emailClean = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _emailClean.DomainID = (int)DomainComboBox.SelectedValue;
            _emailClean.Folder = FolderTextBox.Text;
            _emailClean.Days = (int)DaysNumberBox.Value;

            try
            {
                MessageBox.Show(_emailClean.StartCleaning().ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _emailClean = new EmailClean();
            List<hmail.hm_domain> domains = _emailClean.GetDomains();
            DomainComboBox.DataSource = domains;
            DomainComboBox.DisplayMember = "domainname";
            DomainComboBox.ValueMember = "domainid";
        }
    }
}
