namespace Shorohov
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label13 = new Label();
            label9 = new Label();
            label10 = new Label();
            Pout_TextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            VinNom_TextBox = new TextBox();
            Calculate_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            VinMin_TextBox = new TextBox();
            label4 = new Label();
            Vout_TextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            VinMax_TextBox = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            RacMin_Label = new Label();
            label18 = new Label();
            label19 = new Label();
            MMin_Label = new Label();
            label16 = new Label();
            label17 = new Label();
            MMax_Label = new Label();
            label14 = new Label();
            label15 = new Label();
            NpNs_Label = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Pout_TextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(VinNom_TextBox);
            groupBox1.Controls.Add(Calculate_Button);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(VinMin_TextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Vout_TextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(VinMax_TextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Технические характеристики";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F);
            label23.Location = new Point(196, 267);
            label23.Name = "label23";
            label23.Size = new Size(31, 25);
            label23.TabIndex = 29;
            label23.Text = "Вт";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14F);
            label22.Location = new Point(212, 209);
            label22.Name = "label22";
            label22.Size = new Size(23, 25);
            label22.TabIndex = 28;
            label22.Text = "B";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F);
            label21.Location = new Point(212, 154);
            label21.Name = "label21";
            label21.Size = new Size(23, 25);
            label21.TabIndex = 27;
            label21.Text = "B";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F);
            label20.Location = new Point(212, 100);
            label20.Name = "label20";
            label20.Size = new Size(23, 25);
            label20.TabIndex = 26;
            label20.Text = "B";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F);
            label13.Location = new Point(192, 46);
            label13.Name = "label13";
            label13.Size = new Size(23, 25);
            label13.TabIndex = 25;
            label13.Text = "B";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 251);
            label9.Name = "label9";
            label9.Size = new Size(125, 15);
            label9.TabIndex = 22;
            label9.Text = "Выходная мощность:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 272);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 23;
            label10.Text = "Pout = ";
            // 
            // Pout_TextBox
            // 
            Pout_TextBox.BackColor = Color.White;
            Pout_TextBox.Location = new Point(58, 269);
            Pout_TextBox.Name = "Pout_TextBox";
            Pout_TextBox.Size = new Size(139, 23);
            Pout_TextBox.TabIndex = 24;
            Pout_TextBox.TabStop = false;
            Pout_TextBox.Text = "250";
            Pout_TextBox.TextChanged += TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 191);
            label7.Name = "label7";
            label7.Size = new Size(207, 15);
            label7.TabIndex = 19;
            label7.Text = "Номинальное входное напряжение:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 212);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 20;
            label8.Text = "Vin_nom = ";
            // 
            // VinNom_TextBox
            // 
            VinNom_TextBox.BackColor = Color.White;
            VinNom_TextBox.Location = new Point(76, 209);
            VinNom_TextBox.Name = "VinNom_TextBox";
            VinNom_TextBox.Size = new Size(139, 23);
            VinNom_TextBox.TabIndex = 21;
            VinNom_TextBox.TabStop = false;
            VinNom_TextBox.Text = "33";
            VinNom_TextBox.TextChanged += TextChanged;
            // 
            // Calculate_Button
            // 
            Calculate_Button.Location = new Point(261, 323);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(102, 36);
            Calculate_Button.TabIndex = 18;
            Calculate_Button.Text = "Рассчитать";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 82);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 0;
            label1.Text = "Минимальное входное напряжение:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Vin_min = ";
            // 
            // VinMin_TextBox
            // 
            VinMin_TextBox.BackColor = Color.White;
            VinMin_TextBox.Location = new Point(76, 100);
            VinMin_TextBox.Name = "VinMin_TextBox";
            VinMin_TextBox.Size = new Size(139, 23);
            VinMin_TextBox.TabIndex = 2;
            VinMin_TextBox.TabStop = false;
            VinMin_TextBox.Text = "18";
            VinMin_TextBox.TextChanged += TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(213, 15);
            label4.TabIndex = 3;
            label4.Text = "Максимальное входное напряжение:";
            // 
            // Vout_TextBox
            // 
            Vout_TextBox.BackColor = Color.White;
            Vout_TextBox.Location = new Point(57, 46);
            Vout_TextBox.Name = "Vout_TextBox";
            Vout_TextBox.Size = new Size(139, 23);
            Vout_TextBox.TabIndex = 8;
            Vout_TextBox.TabStop = false;
            Vout_TextBox.Text = "400";
            Vout_TextBox.TextChanged += TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Vin_max = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 49);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Vout = \r\n";
            // 
            // VinMax_TextBox
            // 
            VinMax_TextBox.BackColor = Color.White;
            VinMax_TextBox.Location = new Point(76, 154);
            VinMax_TextBox.Name = "VinMax_TextBox";
            VinMax_TextBox.Size = new Size(139, 23);
            VinMax_TextBox.TabIndex = 5;
            VinMax_TextBox.TabStop = false;
            VinMax_TextBox.Text = "36";
            VinMax_TextBox.TextChanged += TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 6;
            label6.Text = "Выходное напряжение:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RacMin_Label);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(MMin_Label);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(MMax_Label);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(NpNs_Label);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(387, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 365);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выходные параметры";
            // 
            // RacMin_Label
            // 
            RacMin_Label.AutoSize = true;
            RacMin_Label.Location = new Point(67, 190);
            RacMin_Label.Name = "RacMin_Label";
            RacMin_Label.Size = new Size(47, 15);
            RacMin_Label.TabIndex = 11;
            RacMin_Label.Text = "RacMin";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 190);
            label18.Name = "label18";
            label18.Size = new Size(66, 15);
            label18.TabIndex = 10;
            label18.Text = "Rac_min = ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 169);
            label19.Name = "label19";
            label19.Size = new Size(220, 15);
            label19.TabIndex = 9;
            label19.Text = "Сопротивление отраженной нагрузки:";
            // 
            // MMin_Label
            // 
            MMin_Label.AutoSize = true;
            MMin_Label.Location = new Point(57, 140);
            MMin_Label.Name = "MMin_Label";
            MMin_Label.Size = new Size(39, 15);
            MMin_Label.TabIndex = 8;
            MMin_Label.Text = "MMin";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 140);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 7;
            label16.Text = "Mmin = ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 119);
            label17.Name = "label17";
            label17.Size = new Size(298, 15);
            label17.TabIndex = 6;
            label17.Text = "Минимальный коэффициент усиления напряжения:";
            // 
            // MMax_Label
            // 
            MMax_Label.AutoSize = true;
            MMax_Label.Location = new Point(57, 94);
            MMax_Label.Name = "MMax_Label";
            MMax_Label.Size = new Size(41, 15);
            MMax_Label.TabIndex = 5;
            MMax_Label.Text = "MMax";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 94);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 4;
            label14.Text = "Mmax = ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 73);
            label15.Name = "label15";
            label15.Size = new Size(302, 15);
            label15.TabIndex = 3;
            label15.Text = "Максимальный коэффициент усиления напряжения:";
            // 
            // NpNs_Label
            // 
            NpNs_Label.AutoSize = true;
            NpNs_Label.Location = new Point(57, 49);
            NpNs_Label.Name = "NpNs_Label";
            NpNs_Label.Size = new Size(37, 15);
            NpNs_Label.TabIndex = 2;
            NpNs_Label.Text = "NpNs";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 49);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 1;
            label12.Text = "Np/Ns = ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 28);
            label11.Name = "label11";
            label11.Size = new Size(277, 15);
            label11.TabIndex = 0;
            label11.Text = "Коэффициент трансформации трансформатора:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Расчет инвертора напряжения с последовательным резонансным LLC контуром";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox VinMin_TextBox;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox VinMax_TextBox;
        private Label label3;
        private Label label4;
        private TextBox Vout_TextBox;
        private Label label5;
        private Label label6;
        private Button Calculate_Button;
        private Label label9;
        private Label label10;
        private TextBox Pout_TextBox;
        private Label label7;
        private Label label8;
        private TextBox VinNom_TextBox;
        private Label label11;
        private Label NpNs_Label;
        private Label label12;
        private Label MMax_Label;
        private Label label14;
        private Label label15;
        private Label RacMin_Label;
        private Label label18;
        private Label label19;
        private Label MMin_Label;
        private Label label16;
        private Label label17;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label13;

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
