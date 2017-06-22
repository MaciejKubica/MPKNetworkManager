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

            lbCommands.DataSource = Registration.Commands;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbCommands.SelectedItem != null)
            {
                string stdOutput;
                string stdError;
                Registration.ProcessManager.StartProcess(lbCommands.SelectedItem.ToString(), out stdOutput, out stdError);
                MessageBox.Show(stdOutput, "Result");
            }
        }

        private async void btnPing_Click(object sender, EventArgs e)
        {
            lvPingResult.Items.Clear();
            var result =  await Registration.PingChecker.DoPingCommandAsync(tbPingAddress.Text, (int)nudPort.Value, (int)nudTimes.Value);

            foreach (var item in result.PingReplaies)
            {
                lvPingResult.Items.Add(item.Address + " " + item.Status.ToString() + " " + item.RoundtripTime + " " + item.TimeToLive);
            }

            MessageBox.Show($"Result: \n\r Positive percent: {result.PositivePercent} \n\r Avarage round trip: {result.RoundTripAverageTime} \n\r Max round trip: {result.RoundTripMaximumTime} \n\r Min round trip: {result.RoundTripMinimumTime}", "Result");
            
        }
    }
}
