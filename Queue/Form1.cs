using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values
                double lambda = double.Parse(txtLambda.Text); // Arrival rate (λ)
                double mu = double.Parse(txtMu.Text);    // Service rate (μ)

                // Validate input
                if (lambda >= mu)
                {
                    MessageBox.Show("λ must be less than μ for the queue to be stable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Constants and inputs
                double rho = lambda / mu; // Traffic intensity
                double P0 = 1 - rho; // Probability system is empty

                // Performance measures
                double ELq = (lambda * lambda) / mu*(mu - lambda); // Expected number in queue
                double EL = lambda / (mu - lambda); // Expected number in the system
                double ES = 1 / (mu - lambda); // Average time in the system
                double EW = ELq / lambda; // Average waiting time in queue

                // Probability P(W > t)
                double t = double.Parse(txtT.Text); // Example time input
                double P_W_gt_t = rho * Math.Exp(-mu * (1 - rho) * t); // P(W > t)

                // Conditional waiting time P(W > t | W > 0)
                double P_W_gt_t_given_gt_0 = Math.Exp(-mu * (1 - rho) * t); // P(W > t | W > 0)

                // Display results
                lblTrafficIntensityValue.Text = $"{rho:F4}";
                double val = 1 - rho;
                lblPnFormula.Text = $"P(n) = {val} · ({rho:F4})ⁿ";

                lblELqValue.Text = $"{ELq:F4}";
                lblELValue.Text = $"{EL:F4}";
                lblESValue.Text = $"{ES:F4} hours";
                lblEWValue.Text = $"{EW:F4} hours";
           
                // Average number of customers in buffer (calculated)
                double bufferCustomers = ELq;
                lblBufferValue.Text = $"{bufferCustomers:F4}";
                ///
                // Display symbolic formulas

                // Constants and inputs
                double rhoo = lambda / mu; // Traffic intensity
                double k = mu * (1 - rho); // Precomputed constant for simplicity

                // Display simplified formulas
                lblPWgtTValue.Text = $"P(W > t) = {rho:F4} · e^(-{k:F4} · t)";
                lblPWgtTConditionalValue.Text = $"P(W > t | W > 0) = e^(-{k:F4} · t)";
                //

                //lblPWgtTValue.Text = $"P(W > t) = {rho:F4} · e^(-{mu:F4}(1 - {rho:F4}) · t)";
                //lblPWgtTConditionalValue.Text = $"P(W > t | W > 0) = e^(-{mu:F4}(1 - {rho:F4}) · t)";
                // Probability the buffer is non-empty (Pn for n >= 2)
                // double Pn_buffer_non_empty = Math.Pow(rho, 2);
                //// lblBufferNonEmptyValue.Text = $"{Pn_buffer_non_empty:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for λ, μ, and t.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

    
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblP0Value_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 