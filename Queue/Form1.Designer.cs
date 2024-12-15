namespace Queue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtLambda = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLambda = new System.Windows.Forms.Label();
            this.lblMu = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtT = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblELqValue = new System.Windows.Forms.Label();
            this.lblTrafficIntensityValue = new System.Windows.Forms.Label();
            this.lblELValue = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPnFormula = new System.Windows.Forms.Label();
            this.lblESValue = new System.Windows.Forms.Label();
            this.lblPWgtTValue = new System.Windows.Forms.Label();
            this.lblEWValue = new System.Windows.Forms.Label();
            this.lblPWgtTConditionalValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBufferValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "M/M/1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(675, 92);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Red;
            this.richTextBox2.Location = new System.Drawing.Point(11, 140);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(588, 30);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = " performance measures for the queue in the steady state.?";
            // 
            // txtLambda
            // 
            this.txtLambda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLambda.DefaultText = "";
            this.txtLambda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLambda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLambda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLambda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLambda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLambda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLambda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLambda.Location = new System.Drawing.Point(75, 181);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.PasswordChar = '\0';
            this.txtLambda.PlaceholderText = "";
            this.txtLambda.SelectedText = "";
            this.txtLambda.Size = new System.Drawing.Size(200, 36);
            this.txtLambda.TabIndex = 5;
            // 
            // txtMu
            // 
            this.txtMu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMu.DefaultText = "";
            this.txtMu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMu.Location = new System.Drawing.Point(75, 223);
            this.txtMu.Name = "txtMu";
            this.txtMu.PasswordChar = '\0';
            this.txtMu.PlaceholderText = "";
            this.txtMu.SelectedText = "";
            this.txtMu.Size = new System.Drawing.Size(200, 36);
            this.txtMu.TabIndex = 6;
            // 
            // lblLambda
            // 
            this.lblLambda.AutoSize = true;
            this.lblLambda.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLambda.Location = new System.Drawing.Point(19, 181);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(50, 31);
            this.lblLambda.TabIndex = 7;
            this.lblLambda.Text = " λ :";
            // 
            // lblMu
            // 
            this.lblMu.AutoSize = true;
            this.lblMu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMu.Location = new System.Drawing.Point(18, 223);
            this.lblMu.Name = "lblMu";
            this.lblMu.Size = new System.Drawing.Size(52, 31);
            this.lblMu.TabIndex = 8;
            this.lblMu.Text = " μ :";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(361, 176);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(39, 31);
            this.lblT.TabIndex = 9;
            this.lblT.Text = "t :";
            // 
            // txtT
            // 
            this.txtT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtT.DefaultText = "";
            this.txtT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtT.Location = new System.Drawing.Point(406, 176);
            this.txtT.Name = "txtT";
            this.txtT.PasswordChar = '\0';
            this.txtT.PlaceholderText = "";
            this.txtT.SelectedText = "";
            this.txtT.Size = new System.Drawing.Size(200, 36);
            this.txtT.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Animated = true;
            this.btnCalculate.AutoRoundedCorners = true;
            this.btnCalculate.BorderRadius = 21;
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(396, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(197, 45);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "3. Expected number of customers in the queue (E(Lq)):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "2.  Probability distribution of number of customers \r\nin the system (Pn, n = 0,1," +
    "2,...).";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "1. Traffic intensity (ρ):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "7. Mean waiting time in the queue (E(W)):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = " 6. Mean time in the system (E(S)):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(558, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = " 5. Expected number of customers in the system (E(L)):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "8. Probability P(W > {t}):";
            // 
            // lblELqValue
            // 
            this.lblELqValue.AutoSize = true;
            this.lblELqValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblELqValue.ForeColor = System.Drawing.Color.Green;
            this.lblELqValue.Location = new System.Drawing.Point(588, 443);
            this.lblELqValue.Name = "lblELqValue";
            this.lblELqValue.Size = new System.Drawing.Size(18, 28);
            this.lblELqValue.TabIndex = 19;
            this.lblELqValue.Text = " ";
            // 
            // lblTrafficIntensityValue
            // 
            this.lblTrafficIntensityValue.AutoSize = true;
            this.lblTrafficIntensityValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrafficIntensityValue.ForeColor = System.Drawing.Color.Green;
            this.lblTrafficIntensityValue.Location = new System.Drawing.Point(285, 339);
            this.lblTrafficIntensityValue.Name = "lblTrafficIntensityValue";
            this.lblTrafficIntensityValue.Size = new System.Drawing.Size(0, 28);
            this.lblTrafficIntensityValue.TabIndex = 23;
            // 
            // lblELValue
            // 
            this.lblELValue.AutoSize = true;
            this.lblELValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblELValue.ForeColor = System.Drawing.Color.Green;
            this.lblELValue.Location = new System.Drawing.Point(570, 528);
            this.lblELValue.Name = "lblELValue";
            this.lblELValue.Size = new System.Drawing.Size(18, 28);
            this.lblELValue.TabIndex = 22;
            this.lblELValue.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(6, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(430, 28);
            this.label13.TabIndex = 21;
            this.label13.Text = "Performance Measures for M/M/1 Queue:";
            // 
            // lblPnFormula
            // 
            this.lblPnFormula.AutoSize = true;
            this.lblPnFormula.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnFormula.ForeColor = System.Drawing.Color.Green;
            this.lblPnFormula.Location = new System.Drawing.Point(363, 405);
            this.lblPnFormula.Name = "lblPnFormula";
            this.lblPnFormula.Size = new System.Drawing.Size(0, 28);
            this.lblPnFormula.TabIndex = 24;
            this.lblPnFormula.Click += new System.EventHandler(this.lblP0Value_Click);
            // 
            // lblESValue
            // 
            this.lblESValue.AutoSize = true;
            this.lblESValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESValue.ForeColor = System.Drawing.Color.Green;
            this.lblESValue.Location = new System.Drawing.Point(388, 569);
            this.lblESValue.Name = "lblESValue";
            this.lblESValue.Size = new System.Drawing.Size(18, 28);
            this.lblESValue.TabIndex = 25;
            this.lblESValue.Text = " ";
            // 
            // lblPWgtTValue
            // 
            this.lblPWgtTValue.AutoSize = true;
            this.lblPWgtTValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWgtTValue.ForeColor = System.Drawing.Color.Green;
            this.lblPWgtTValue.Location = new System.Drawing.Point(274, 651);
            this.lblPWgtTValue.Name = "lblPWgtTValue";
            this.lblPWgtTValue.Size = new System.Drawing.Size(18, 28);
            this.lblPWgtTValue.TabIndex = 26;
            this.lblPWgtTValue.Text = " ";
            // 
            // lblEWValue
            // 
            this.lblEWValue.AutoSize = true;
            this.lblEWValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEWValue.ForeColor = System.Drawing.Color.Green;
            this.lblEWValue.Location = new System.Drawing.Point(461, 610);
            this.lblEWValue.Name = "lblEWValue";
            this.lblEWValue.Size = new System.Drawing.Size(0, 28);
            this.lblEWValue.TabIndex = 27;
            // 
            // lblPWgtTConditionalValue
            // 
            this.lblPWgtTConditionalValue.AutoSize = true;
            this.lblPWgtTConditionalValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWgtTConditionalValue.ForeColor = System.Drawing.Color.Green;
            this.lblPWgtTConditionalValue.Location = new System.Drawing.Point(267, 689);
            this.lblPWgtTConditionalValue.Name = "lblPWgtTConditionalValue";
            this.lblPWgtTConditionalValue.Size = new System.Drawing.Size(18, 28);
            this.lblPWgtTConditionalValue.TabIndex = 29;
            this.lblPWgtTConditionalValue.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 689);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = " 9.  P( W > t  ∣  W > 0 ):";
            // 
            // lblBufferValue
            // 
            this.lblBufferValue.AutoSize = true;
            this.lblBufferValue.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferValue.ForeColor = System.Drawing.Color.Green;
            this.lblBufferValue.Location = new System.Drawing.Point(349, 490);
            this.lblBufferValue.Name = "lblBufferValue";
            this.lblBufferValue.Size = new System.Drawing.Size(18, 28);
            this.lblBufferValue.TabIndex = 31;
            this.lblBufferValue.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "4.bufferCustomers(Non Empty):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 749);
            this.Controls.Add(this.lblBufferValue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPWgtTConditionalValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEWValue);
            this.Controls.Add(this.lblPWgtTValue);
            this.Controls.Add(this.lblESValue);
            this.Controls.Add(this.lblPnFormula);
            this.Controls.Add(this.lblTrafficIntensityValue);
            this.Controls.Add(this.lblELValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblELqValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblMu);
            this.Controls.Add(this.lblLambda);
            this.Controls.Add(this.txtMu);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtLambda;
        private Guna.UI2.WinForms.Guna2TextBox txtMu;
        private System.Windows.Forms.Label lblLambda;
        private System.Windows.Forms.Label lblMu;
        private System.Windows.Forms.Label lblT;
        private Guna.UI2.WinForms.Guna2TextBox txtT;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblELqValue;
        private System.Windows.Forms.Label lblTrafficIntensityValue;
        private System.Windows.Forms.Label lblELValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPnFormula;
        private System.Windows.Forms.Label lblESValue;
        private System.Windows.Forms.Label lblPWgtTValue;
        private System.Windows.Forms.Label lblEWValue;
        private System.Windows.Forms.Label lblPWgtTConditionalValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBufferValue;
        private System.Windows.Forms.Label label11;
    }
}

