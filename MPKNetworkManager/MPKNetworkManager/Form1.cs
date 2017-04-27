using MPKNetworkManager.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPKNetworkManager
{
    public partial class Form1 : Form
    {
        private IPValidator validator;
        public Form1()
        {
            InitializeComponent();
            validator = new IPValidator();
            lbIpAddresses.DataSource = Registration.NetworkManagement.IPAddresses;
            lbGateways.DataSource = Registration.NetworkManagement.Gateways;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Registration.PingChecker.DoPingCommand("192.168.1.1");
            //}
            //catch (NotImplementedException ex)
            //{
            //    MessageBox.Show("O rety! nie zaimplementowany");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Fajnie że się wywaliło");
            //}
            //finally
            //{
                
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            var ipaddressValidationResult = validator.DoValidation(mtbIPAddress.Text);
            if (!ipaddressValidationResult.IsValid)
            {
                errorProvider1.SetError(mtbIPAddress, ipaddressValidationResult.ValidationMessage);
            }

            var subnetValidationResult = validator.DoValidation(mtbSubnet.Text);
            if (!subnetValidationResult.IsValid)
            {
                errorProvider1.SetError(mtbSubnet, subnetValidationResult.ValidationMessage);
            }

            var gatewayValidationResult = validator.DoValidation(mtbGateway.Text);
            if (!gatewayValidationResult.IsValid)
            {
                errorProvider1.SetError(mtbGateway, subnetValidationResult.ValidationMessage);
            }

            Registration.NetworkManagement.ChangeIP(mtbIPAddress.Text, mtbSubnet.Text);
            Registration.NetworkManagement.ChangeGateway(mtbGateway.Text);

            lbIpAddresses.DataSource = Registration.NetworkManagement.IPAddresses;
            lbGateways.DataSource = Registration.NetworkManagement.Gateways;
        }
    }
}
