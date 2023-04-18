using System;
using System.Windows.Forms;

namespace FarmCompanies
{
    public partial class MainForm : Form
    {
        private readonly string[] _companyNames = 
        {
            "AgroTech", "AgroPro", "FarmTech", "EcoFarm", "GreenFields", "GoldenHarvest",
            "FreshFarms", "Nature'sBest", "HarvestKing", "PrimeProduce", "FarmersCoop",
            "GreenAcres", "CountryFields", "OrganicHarvest", "FreshProduce", "FarmToTable"
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowCompany_Click(object sender, EventArgs e)
        {
            int companyNumber = (int)numUpDownCompanyNumber.Value;

            if (companyNumber < 1 || companyNumber > _companyNames.Length)
            {
                cmbBoxCompanyName.Text = "Invalid company number";
            }
            else
            {
                cmbBoxCompanyName.Text = _companyNames[companyNumber - 1];
            }
        }
    }
}
