using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Factorial function


        private double Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Inputs: Lambda, Mu, s
                double lambda = double.Parse(txtArrivalRate.Text); // Arrival rate (λ)
                double mu = double.Parse(txtServiceRate.Text);         // Service rate (μ)
                int s = int.Parse(txtServers.Text);           // Number of servers

                // Step 1: Traffic Intensity (ρ)
                double rho = lambda / (s * mu);
                lblTrafficIntensity.Text = $"ρ = {rho:F4}";

                // Step 2: Calculate P0 (Erlang's formula for M/M/s system)
                double sum = 0;
                for (int n = 0; n < s; n++)
                {
                    sum += Math.Pow(lambda / mu, n) / Factorial(n);
                }
                double p0_denom = sum + (Math.Pow(lambda / mu, s) / (Factorial(s) * (1 - rho)));
                double P0 = 1 / p0_denom;
                lblP0.Text = $" {P0:F4}";

                // Step 3: Pn (Probability distribution for n customers in the system)

                // Simplified formula for Pₙ without substituting n
                lblPn.Text = $"({lambda}/{s*mu})^{"n"} ";


                double Pw = (Math.Pow(lambda / mu, s) * P0) / (s * (1 - rho));
                lblPiW.Text = $" {Pw:F4}";

                // Step 4: Expected Customers in Queue (E(Lq))
                double ELq = (P0 * Math.Pow(lambda / mu, s) * rho) / (Factorial(s) * Math.Pow(1 - rho, 2));
                lblELq.Text = $" {ELq:F4}";

                // Step 5: Expected Customers in System (E(L))
                double EL = ELq + (lambda / mu);
                lblEL.Text = $"{EL:F4}";

                // Step 6: Mean Waiting Time in Queue (E(Wq))
                double EWq = ELq / lambda;
                lblEWq.Text = $" {EWq:F4} hours";

                // Step 7: Mean Time in System (E(W))
                double EW = EWq + (1 / mu);
                lblEW.Text = $" {EW:F4} hours";

                // Step 8: Probability W > 0
                double PWgt0 = Math.Exp(-mu *s* (1 - rho) * 0);
                lblPWgt0.Text = $"{Pw * PWgt0:F4}";

                // Step 9: Probability W > 0.5
                double t1 = 0.5;
                double PWgt05 = Math.Exp(-mu *s* (1 - rho) * t1);
                lblPWgt05.Text = $"{Pw * PWgt05:F4}";

                // Step 10: Probability W > 1
                double t2 = 1;
                double PWgt1 = Math.Exp(-mu *s*(1 - rho) * t2);
                lblPWgt1.Text = $" {Pw * PWgt1:F4}";

                // Step 11: General Probability P(W > t)
                double k =  s*mu * (1 - rho); // Precomputed constant for simplicity

                // Display simplified formulas
                lblPWgtT.Text = $"P(W > t) = {Pw:F4} · e^(-{k:F4} · t)";
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check the values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}







