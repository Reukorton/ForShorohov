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
            label9 = new Label();
            Cr_TextBox = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            ChartOpenWindowButton = new Button();
            VinMax_TextBox = new TextBox();
            label24 = new Label();
            label5 = new Label();
            label33 = new Label();
            label1 = new Label();
            VinMin_TextBox = new TextBox();
            label3 = new Label();
            label34 = new Label();
            label2 = new Label();
            Vout_TextBox = new TextBox();
            Iout_TextBox = new TextBox();
            label20 = new Label();
            label4 = new Label();
            label7 = new Label();
            label13 = new Label();
            label8 = new Label();
            label21 = new Label();
            label22 = new Label();
            F_TextBox = new TextBox();
            Calculate_Button = new Button();
            label25 = new Label();
            M_TextBox = new TextBox();
            label26 = new Label();
            groupBox2 = new GroupBox();
            Lm_Label = new Label();
            label31 = new Label();
            label32 = new Label();
            Lr_Label = new Label();
            label27 = new Label();
            label28 = new Label();
            Rac_Label = new Label();
            label18 = new Label();
            label19 = new Label();
            Rn_Label = new Label();
            label16 = new Label();
            label17 = new Label();
            Q_Label = new Label();
            label14 = new Label();
            label15 = new Label();
            NpNs_Label = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Cr_TextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(Calculate_Button);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(M_TextBox);
            groupBox1.Controls.Add(label26);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 479);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Технические параметры ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(143, 361);
            label23.Name = "label23";
            label23.Size = new Size(37, 25);
            label23.TabIndex = 46;
            label23.Text = "нФ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 345);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 43;
            label9.Text = "Резонансная емкость:";
            // 
            // Cr_TextBox
            // 
            Cr_TextBox.BackColor = SystemColors.Window;
            Cr_TextBox.Location = new Point(44, 363);
            Cr_TextBox.Name = "Cr_TextBox";
            Cr_TextBox.Size = new Size(94, 23);
            Cr_TextBox.TabIndex = 45;
            Cr_TextBox.TabStop = false;
            Cr_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 366);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 44;
            label10.Text = "Cr = ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(ChartOpenWindowButton);
            groupBox3.Controls.Add(VinMax_TextBox);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label33);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(VinMin_TextBox);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(Vout_TextBox);
            groupBox3.Controls.Add(Iout_TextBox);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(F_TextBox);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 320);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные для построения графика";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 27);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 6;
            label6.Text = "Выходное напряжение:";
            // 
            // ChartOpenWindowButton
            // 
            ChartOpenWindowButton.Location = new Point(249, 278);
            ChartOpenWindowButton.Name = "ChartOpenWindowButton";
            ChartOpenWindowButton.Size = new Size(102, 36);
            ChartOpenWindowButton.TabIndex = 41;
            ChartOpenWindowButton.Text = "График";
            ChartOpenWindowButton.UseVisualStyleBackColor = true;
            ChartOpenWindowButton.Click += ChartOpenWindowButton_Click;
            // 
            // VinMax_TextBox
            // 
            VinMax_TextBox.BackColor = SystemColors.Window;
            VinMax_TextBox.Location = new Point(76, 156);
            VinMax_TextBox.Name = "VinMax_TextBox";
            VinMax_TextBox.Size = new Size(139, 23);
            VinMax_TextBox.TabIndex = 5;
            VinMax_TextBox.TabStop = false;
            VinMax_TextBox.TextChanged += TextChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(199, 210);
            label24.Name = "label24";
            label24.Size = new Size(24, 25);
            label24.TabIndex = 40;
            label24.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 48);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Vout = \r\n";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 192);
            label33.Name = "label33";
            label33.Size = new Size(87, 15);
            label33.TabIndex = 37;
            label33.Text = "Выходной ток:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 84);
            label1.Name = "label1";
            label1.Size = new Size(209, 15);
            label1.TabIndex = 0;
            label1.Text = "Минимальное входное напряжение:";
            // 
            // VinMin_TextBox
            // 
            VinMin_TextBox.BackColor = SystemColors.Window;
            VinMin_TextBox.Location = new Point(76, 102);
            VinMin_TextBox.Name = "VinMin_TextBox";
            VinMin_TextBox.Size = new Size(139, 23);
            VinMin_TextBox.TabIndex = 2;
            VinMin_TextBox.TabStop = false;
            VinMin_TextBox.TextChanged += TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 159);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Vin_max = ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(6, 213);
            label34.Name = "label34";
            label34.Size = new Size(42, 15);
            label34.TabIndex = 38;
            label34.Text = "Iout = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 105);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Vin_min = ";
            // 
            // Vout_TextBox
            // 
            Vout_TextBox.BackColor = SystemColors.Window;
            Vout_TextBox.Location = new Point(57, 45);
            Vout_TextBox.Name = "Vout_TextBox";
            Vout_TextBox.Size = new Size(139, 23);
            Vout_TextBox.TabIndex = 8;
            Vout_TextBox.TabStop = false;
            Vout_TextBox.TextChanged += TextChanged;
            // 
            // Iout_TextBox
            // 
            Iout_TextBox.BackColor = SystemColors.Window;
            Iout_TextBox.Location = new Point(54, 210);
            Iout_TextBox.Name = "Iout_TextBox";
            Iout_TextBox.Size = new Size(139, 23);
            Iout_TextBox.TabIndex = 39;
            Iout_TextBox.TabStop = false;
            Iout_TextBox.TextChanged += TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(212, 102);
            label20.Name = "label20";
            label20.Size = new Size(23, 25);
            label20.TabIndex = 26;
            label20.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(213, 15);
            label4.TabIndex = 3;
            label4.Text = "Максимальное входное напряжение:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(182, 260);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 33;
            label7.Text = "Гц";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(192, 45);
            label13.Name = "label13";
            label13.Size = new Size(23, 25);
            label13.TabIndex = 25;
            label13.Text = "B";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 244);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 30;
            label8.Text = "Резонансная частота:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(212, 156);
            label21.Name = "label21";
            label21.Size = new Size(23, 25);
            label21.TabIndex = 27;
            label21.Text = "B";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 265);
            label22.Name = "label22";
            label22.Size = new Size(25, 15);
            label22.TabIndex = 31;
            label22.Text = "f = ";
            // 
            // F_TextBox
            // 
            F_TextBox.BackColor = SystemColors.Window;
            F_TextBox.Location = new Point(37, 262);
            F_TextBox.Name = "F_TextBox";
            F_TextBox.Size = new Size(139, 23);
            F_TextBox.TabIndex = 32;
            F_TextBox.TabStop = false;
            F_TextBox.TextChanged += TextChanged;
            // 
            // Calculate_Button
            // 
            Calculate_Button.Enabled = false;
            Calculate_Button.Location = new Point(261, 437);
            Calculate_Button.Name = "Calculate_Button";
            Calculate_Button.Size = new Size(102, 36);
            Calculate_Button.TabIndex = 18;
            Calculate_Button.Text = "Рассчитать";
            Calculate_Button.UseVisualStyleBackColor = true;
            Calculate_Button.Click += Calculate_Button_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 403);
            label25.Name = "label25";
            label25.Size = new Size(101, 15);
            label25.TabIndex = 34;
            label25.Text = "Коэффициент m:";
            // 
            // M_TextBox
            // 
            M_TextBox.BackColor = SystemColors.Window;
            M_TextBox.Location = new Point(37, 421);
            M_TextBox.Name = "M_TextBox";
            M_TextBox.Size = new Size(94, 23);
            M_TextBox.TabIndex = 36;
            M_TextBox.TabStop = false;
            M_TextBox.TextAlign = HorizontalAlignment.Center;
            M_TextBox.TextChanged += TextChanged;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 424);
            label26.Name = "label26";
            label26.Size = new Size(32, 15);
            label26.TabIndex = 35;
            label26.Text = "m = ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Lm_Label);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(Lr_Label);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(Rac_Label);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(Rn_Label);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(Q_Label);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(NpNs_Label);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(387, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 479);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Рассчитанные параметры";
            // 
            // Lm_Label
            // 
            Lm_Label.AutoSize = true;
            Lm_Label.Location = new Point(39, 286);
            Lm_Label.Name = "Lm_Label";
            Lm_Label.Size = new Size(24, 15);
            Lm_Label.TabIndex = 20;
            Lm_Label.Text = "Lm";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(6, 286);
            label31.Name = "label31";
            label31.Size = new Size(38, 15);
            label31.TabIndex = 19;
            label31.Text = "Lm = ";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(6, 265);
            label32.Name = "label32";
            label32.Size = new Size(189, 15);
            label32.TabIndex = 18;
            label32.Text = "Индуктивность намагничивания:";
            // 
            // Lr_Label
            // 
            Lr_Label.AutoSize = true;
            Lr_Label.Location = new Point(37, 237);
            Lr_Label.Name = "Lr_Label";
            Lr_Label.Size = new Size(17, 15);
            Lr_Label.TabIndex = 14;
            Lr_Label.Text = "Lr";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 237);
            label27.Name = "label27";
            label27.Size = new Size(31, 15);
            label27.TabIndex = 13;
            label27.Text = "Lr = ";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(6, 216);
            label28.Name = "label28";
            label28.Size = new Size(164, 15);
            label28.TabIndex = 12;
            label28.Text = "Резонансная индуктинвость:";
            // 
            // Rac_Label
            // 
            Rac_Label.AutoSize = true;
            Rac_Label.Location = new Point(43, 190);
            Rac_Label.Name = "Rac_Label";
            Rac_Label.Size = new Size(26, 15);
            Rac_Label.TabIndex = 11;
            Rac_Label.Text = "Rac";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 190);
            label18.Name = "label18";
            label18.Size = new Size(40, 15);
            label18.TabIndex = 10;
            label18.Text = "Rac = ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 169);
            label19.Name = "label19";
            label19.Size = new Size(273, 15);
            label19.TabIndex = 9;
            label19.Text = "Сопротивление нагрузки по переменному току:";
            // 
            // Rn_Label
            // 
            Rn_Label.AutoSize = true;
            Rn_Label.Location = new Point(41, 140);
            Rn_Label.Name = "Rn_Label";
            Rn_Label.Size = new Size(21, 15);
            Rn_Label.TabIndex = 8;
            Rn_Label.Text = "Rn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 140);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 7;
            label16.Text = "Rn = ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 119);
            label17.Name = "label17";
            label17.Size = new Size(149, 15);
            label17.TabIndex = 6;
            label17.Text = "Сопротивление нагрузки:";
            // 
            // Q_Label
            // 
            Q_Label.AutoSize = true;
            Q_Label.Location = new Point(35, 94);
            Q_Label.Name = "Q_Label";
            Q_Label.Size = new Size(16, 15);
            Q_Label.TabIndex = 5;
            Q_Label.Text = "Q";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 94);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 4;
            label14.Text = "Q = ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 73);
            label15.Name = "label15";
            label15.Size = new Size(161, 15);
            label15.TabIndex = 3;
            label15.Text = "Коэффициент добротности:";
            // 
            // NpNs_Label
            // 
            NpNs_Label.AutoSize = true;
            NpNs_Label.Location = new Point(58, 49);
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
            ClientSize = new Size(800, 503);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Расчет резонансного LLC контура преобразователя напряжения";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Label label11;
        private Label NpNs_Label;
        private Label label12;
        private Label Q_Label;
        private Label label14;
        private Label label15;
        private Label Rac_Label;
        private Label label18;
        private Label label19;
        private Label Rn_Label;
        private Label label16;
        private Label label17;
        private Label label21;
        private Label label20;
        private Label label13;

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        private Label label7;
        private Label label8;
        private Label label22;
        private TextBox F_TextBox;
        private Label label25;
        private Label label26;
        private TextBox M_TextBox;
        private Label Lr_Label;
        private Label label27;
        private Label label28;
        private Label Lm_Label;
        private Label label31;
        private Label label32;
        private Label label24;
        private Label label33;
        private Label label34;
        private TextBox Iout_TextBox;
        private Button ChartOpenWindowButton;
        private GroupBox groupBox3;
        private Label label9;
        private TextBox Cr_TextBox;
        private Label label10;
        private Label label23;
    }
}
