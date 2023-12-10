namespace CS311_FinalProject_PV
{
    partial class UnitConverter
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
            lblTitle = new Label();
            pnlBorderMiddle = new Panel();
            lblUpperOutput = new Label();
            groupBox1 = new GroupBox();
            rdoOuncesNew = new RadioButton();
            rdoPoundsNew = new RadioButton();
            rdoFahrenheitNew = new RadioButton();
            rdoMilesNew = new RadioButton();
            rdoFeetNew = new RadioButton();
            rdoGramsNew = new RadioButton();
            rdoKilogramsNew = new RadioButton();
            rdoCelsiusNew = new RadioButton();
            rdoKilometersNew = new RadioButton();
            rdoMetersNew = new RadioButton();
            grpOriginal = new GroupBox();
            rdoOuncesOG = new RadioButton();
            rdoPoundsOG = new RadioButton();
            rdoFahrenheitOG = new RadioButton();
            rdoMilesOG = new RadioButton();
            rdoFeetOG = new RadioButton();
            rdoGramsOG = new RadioButton();
            rdoKilogramsOG = new RadioButton();
            rdoCelsiusOG = new RadioButton();
            rdoKilometersOG = new RadioButton();
            rdoMetersOG = new RadioButton();
            lblUpperInput = new Label();
            lblInput = new Label();
            lblOutput = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnConvert = new Button();
            lblInstructions = new Label();
            lblInstructions2 = new Label();
            lblInstructions3 = new Label();
            pnlBorderTop = new Panel();
            pnlBorderMiddle.SuspendLayout();
            groupBox1.SuspendLayout();
            grpOriginal.SuspendLayout();
            pnlBorderTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(254, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(227, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit Converter";
            // 
            // pnlBorderMiddle
            // 
            pnlBorderMiddle.BorderStyle = BorderStyle.FixedSingle;
            pnlBorderMiddle.Controls.Add(lblUpperOutput);
            pnlBorderMiddle.Controls.Add(groupBox1);
            pnlBorderMiddle.Controls.Add(grpOriginal);
            pnlBorderMiddle.Controls.Add(lblUpperInput);
            pnlBorderMiddle.Location = new Point(63, 132);
            pnlBorderMiddle.Name = "pnlBorderMiddle";
            pnlBorderMiddle.Size = new Size(676, 212);
            pnlBorderMiddle.TabIndex = 1;
            // 
            // lblUpperOutput
            // 
            lblUpperOutput.AutoSize = true;
            lblUpperOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpperOutput.Location = new Point(403, 11);
            lblUpperOutput.Name = "lblUpperOutput";
            lblUpperOutput.Size = new Size(62, 21);
            lblUpperOutput.TabIndex = 11;
            lblUpperOutput.Text = "Output:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoOuncesNew);
            groupBox1.Controls.Add(rdoPoundsNew);
            groupBox1.Controls.Add(rdoFahrenheitNew);
            groupBox1.Controls.Add(rdoMilesNew);
            groupBox1.Controls.Add(rdoFeetNew);
            groupBox1.Controls.Add(rdoGramsNew);
            groupBox1.Controls.Add(rdoKilogramsNew);
            groupBox1.Controls.Add(rdoCelsiusNew);
            groupBox1.Controls.Add(rdoKilometersNew);
            groupBox1.Controls.Add(rdoMetersNew);
            groupBox1.Location = new Point(403, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 161);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // rdoOuncesNew
            // 
            rdoOuncesNew.AutoSize = true;
            rdoOuncesNew.Location = new Point(122, 122);
            rdoOuncesNew.Name = "rdoOuncesNew";
            rdoOuncesNew.Size = new Size(65, 19);
            rdoOuncesNew.TabIndex = 9;
            rdoOuncesNew.TabStop = true;
            rdoOuncesNew.Text = "Ounces";
            rdoOuncesNew.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsNew
            // 
            rdoPoundsNew.AutoSize = true;
            rdoPoundsNew.Location = new Point(122, 97);
            rdoPoundsNew.Name = "rdoPoundsNew";
            rdoPoundsNew.Size = new Size(65, 19);
            rdoPoundsNew.TabIndex = 8;
            rdoPoundsNew.TabStop = true;
            rdoPoundsNew.Text = "Pounds";
            rdoPoundsNew.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheitNew
            // 
            rdoFahrenheitNew.AutoSize = true;
            rdoFahrenheitNew.Location = new Point(122, 72);
            rdoFahrenheitNew.Name = "rdoFahrenheitNew";
            rdoFahrenheitNew.Size = new Size(81, 19);
            rdoFahrenheitNew.TabIndex = 7;
            rdoFahrenheitNew.TabStop = true;
            rdoFahrenheitNew.Text = "Fahrenheit";
            rdoFahrenheitNew.UseVisualStyleBackColor = true;
            // 
            // rdoMilesNew
            // 
            rdoMilesNew.AutoSize = true;
            rdoMilesNew.Location = new Point(122, 47);
            rdoMilesNew.Name = "rdoMilesNew";
            rdoMilesNew.Size = new Size(53, 19);
            rdoMilesNew.TabIndex = 6;
            rdoMilesNew.TabStop = true;
            rdoMilesNew.Text = "Miles";
            rdoMilesNew.UseVisualStyleBackColor = true;
            // 
            // rdoFeetNew
            // 
            rdoFeetNew.AutoSize = true;
            rdoFeetNew.Location = new Point(122, 22);
            rdoFeetNew.Name = "rdoFeetNew";
            rdoFeetNew.Size = new Size(47, 19);
            rdoFeetNew.TabIndex = 5;
            rdoFeetNew.TabStop = true;
            rdoFeetNew.Text = "Feet";
            rdoFeetNew.UseVisualStyleBackColor = true;
            // 
            // rdoGramsNew
            // 
            rdoGramsNew.AutoSize = true;
            rdoGramsNew.Location = new Point(18, 122);
            rdoGramsNew.Name = "rdoGramsNew";
            rdoGramsNew.Size = new Size(59, 19);
            rdoGramsNew.TabIndex = 4;
            rdoGramsNew.TabStop = true;
            rdoGramsNew.Text = "Grams";
            rdoGramsNew.UseVisualStyleBackColor = true;
            // 
            // rdoKilogramsNew
            // 
            rdoKilogramsNew.AutoSize = true;
            rdoKilogramsNew.Location = new Point(18, 97);
            rdoKilogramsNew.Name = "rdoKilogramsNew";
            rdoKilogramsNew.Size = new Size(78, 19);
            rdoKilogramsNew.TabIndex = 3;
            rdoKilogramsNew.TabStop = true;
            rdoKilogramsNew.Text = "Kilograms";
            rdoKilogramsNew.UseVisualStyleBackColor = true;
            // 
            // rdoCelsiusNew
            // 
            rdoCelsiusNew.AutoSize = true;
            rdoCelsiusNew.Location = new Point(18, 72);
            rdoCelsiusNew.Name = "rdoCelsiusNew";
            rdoCelsiusNew.Size = new Size(62, 19);
            rdoCelsiusNew.TabIndex = 2;
            rdoCelsiusNew.TabStop = true;
            rdoCelsiusNew.Text = "Celsius";
            rdoCelsiusNew.UseVisualStyleBackColor = true;
            // 
            // rdoKilometersNew
            // 
            rdoKilometersNew.AutoSize = true;
            rdoKilometersNew.Location = new Point(18, 47);
            rdoKilometersNew.Name = "rdoKilometersNew";
            rdoKilometersNew.Size = new Size(81, 19);
            rdoKilometersNew.TabIndex = 1;
            rdoKilometersNew.TabStop = true;
            rdoKilometersNew.Text = "Kilometers";
            rdoKilometersNew.UseVisualStyleBackColor = true;
            // 
            // rdoMetersNew
            // 
            rdoMetersNew.AutoSize = true;
            rdoMetersNew.Location = new Point(18, 22);
            rdoMetersNew.Name = "rdoMetersNew";
            rdoMetersNew.Size = new Size(61, 19);
            rdoMetersNew.TabIndex = 0;
            rdoMetersNew.TabStop = true;
            rdoMetersNew.Text = "Meters";
            rdoMetersNew.UseVisualStyleBackColor = true;
            // 
            // grpOriginal
            // 
            grpOriginal.Controls.Add(rdoOuncesOG);
            grpOriginal.Controls.Add(rdoPoundsOG);
            grpOriginal.Controls.Add(rdoFahrenheitOG);
            grpOriginal.Controls.Add(rdoMilesOG);
            grpOriginal.Controls.Add(rdoFeetOG);
            grpOriginal.Controls.Add(rdoGramsOG);
            grpOriginal.Controls.Add(rdoKilogramsOG);
            grpOriginal.Controls.Add(rdoCelsiusOG);
            grpOriginal.Controls.Add(rdoKilometersOG);
            grpOriginal.Controls.Add(rdoMetersOG);
            grpOriginal.Location = new Point(13, 35);
            grpOriginal.Name = "grpOriginal";
            grpOriginal.Size = new Size(255, 161);
            grpOriginal.TabIndex = 1;
            grpOriginal.TabStop = false;
            // 
            // rdoOuncesOG
            // 
            rdoOuncesOG.AutoSize = true;
            rdoOuncesOG.Location = new Point(122, 122);
            rdoOuncesOG.Name = "rdoOuncesOG";
            rdoOuncesOG.Size = new Size(65, 19);
            rdoOuncesOG.TabIndex = 9;
            rdoOuncesOG.TabStop = true;
            rdoOuncesOG.Text = "Ounces";
            rdoOuncesOG.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsOG
            // 
            rdoPoundsOG.AutoSize = true;
            rdoPoundsOG.Location = new Point(122, 97);
            rdoPoundsOG.Name = "rdoPoundsOG";
            rdoPoundsOG.Size = new Size(65, 19);
            rdoPoundsOG.TabIndex = 8;
            rdoPoundsOG.TabStop = true;
            rdoPoundsOG.Text = "Pounds";
            rdoPoundsOG.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenheitOG
            // 
            rdoFahrenheitOG.AutoSize = true;
            rdoFahrenheitOG.Location = new Point(122, 72);
            rdoFahrenheitOG.Name = "rdoFahrenheitOG";
            rdoFahrenheitOG.Size = new Size(81, 19);
            rdoFahrenheitOG.TabIndex = 7;
            rdoFahrenheitOG.TabStop = true;
            rdoFahrenheitOG.Text = "Fahrenheit";
            rdoFahrenheitOG.UseVisualStyleBackColor = true;
            // 
            // rdoMilesOG
            // 
            rdoMilesOG.AutoSize = true;
            rdoMilesOG.Location = new Point(122, 47);
            rdoMilesOG.Name = "rdoMilesOG";
            rdoMilesOG.Size = new Size(53, 19);
            rdoMilesOG.TabIndex = 6;
            rdoMilesOG.TabStop = true;
            rdoMilesOG.Text = "Miles";
            rdoMilesOG.UseVisualStyleBackColor = true;
            // 
            // rdoFeetOG
            // 
            rdoFeetOG.AutoSize = true;
            rdoFeetOG.Location = new Point(122, 22);
            rdoFeetOG.Name = "rdoFeetOG";
            rdoFeetOG.Size = new Size(47, 19);
            rdoFeetOG.TabIndex = 5;
            rdoFeetOG.TabStop = true;
            rdoFeetOG.Text = "Feet";
            rdoFeetOG.UseVisualStyleBackColor = true;
            // 
            // rdoGramsOG
            // 
            rdoGramsOG.AutoSize = true;
            rdoGramsOG.Location = new Point(16, 122);
            rdoGramsOG.Name = "rdoGramsOG";
            rdoGramsOG.Size = new Size(59, 19);
            rdoGramsOG.TabIndex = 4;
            rdoGramsOG.TabStop = true;
            rdoGramsOG.Text = "Grams";
            rdoGramsOG.UseVisualStyleBackColor = true;
            // 
            // rdoKilogramsOG
            // 
            rdoKilogramsOG.AutoSize = true;
            rdoKilogramsOG.Location = new Point(16, 97);
            rdoKilogramsOG.Name = "rdoKilogramsOG";
            rdoKilogramsOG.Size = new Size(78, 19);
            rdoKilogramsOG.TabIndex = 3;
            rdoKilogramsOG.TabStop = true;
            rdoKilogramsOG.Text = "Kilograms";
            rdoKilogramsOG.UseVisualStyleBackColor = true;
            // 
            // rdoCelsiusOG
            // 
            rdoCelsiusOG.AutoSize = true;
            rdoCelsiusOG.Location = new Point(16, 72);
            rdoCelsiusOG.Name = "rdoCelsiusOG";
            rdoCelsiusOG.Size = new Size(62, 19);
            rdoCelsiusOG.TabIndex = 2;
            rdoCelsiusOG.TabStop = true;
            rdoCelsiusOG.Text = "Celsius";
            rdoCelsiusOG.UseVisualStyleBackColor = true;
            // 
            // rdoKilometersOG
            // 
            rdoKilometersOG.AutoSize = true;
            rdoKilometersOG.Location = new Point(16, 47);
            rdoKilometersOG.Name = "rdoKilometersOG";
            rdoKilometersOG.Size = new Size(81, 19);
            rdoKilometersOG.TabIndex = 1;
            rdoKilometersOG.TabStop = true;
            rdoKilometersOG.Text = "Kilometers";
            rdoKilometersOG.UseVisualStyleBackColor = true;
            // 
            // rdoMetersOG
            // 
            rdoMetersOG.AutoSize = true;
            rdoMetersOG.BackColor = SystemColors.Control;
            rdoMetersOG.ForeColor = Color.Black;
            rdoMetersOG.Location = new Point(16, 22);
            rdoMetersOG.Name = "rdoMetersOG";
            rdoMetersOG.Size = new Size(61, 19);
            rdoMetersOG.TabIndex = 0;
            rdoMetersOG.TabStop = true;
            rdoMetersOG.Text = "Meters";
            rdoMetersOG.UseVisualStyleBackColor = false;
            // 
            // lblUpperInput
            // 
            lblUpperInput.AutoSize = true;
            lblUpperInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpperInput.Location = new Point(13, 11);
            lblUpperInput.Name = "lblUpperInput";
            lblUpperInput.Size = new Size(49, 21);
            lblUpperInput.TabIndex = 0;
            lblUpperInput.Text = "Input:";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblInput.Location = new Point(167, 358);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(68, 30);
            lblInput.TabIndex = 2;
            lblInput.Text = "Input:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblOutput.Location = new Point(149, 400);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(86, 30);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "Output:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(241, 359);
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Enter the number you want to convert";
            txtInput.Size = new Size(277, 29);
            txtInput.TabIndex = 4;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOutput.Location = new Point(241, 404);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(277, 29);
            txtOutput.TabIndex = 5;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(536, 371);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(149, 49);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(128, 59);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(471, 15);
            lblInstructions.TabIndex = 7;
            lblInstructions.Text = "To make a conversion, select a unit of measurement in both the input and output boxes.";
            // 
            // lblInstructions2
            // 
            lblInstructions2.AutoSize = true;
            lblInstructions2.Location = new Point(69, 74);
            lblInstructions2.Name = "lblInstructions2";
            lblInstructions2.Size = new Size(596, 15);
            lblInstructions2.TabIndex = 8;
            lblInstructions2.Text = "Valid conversion options are on the same row, so if you select one unit, select the one next to it in the other box.";
            // 
            // lblInstructions3
            // 
            lblInstructions3.AutoSize = true;
            lblInstructions3.Location = new Point(3, 89);
            lblInstructions3.Name = "lblInstructions3";
            lblInstructions3.Size = new Size(714, 15);
            lblInstructions3.TabIndex = 9;
            lblInstructions3.Text = "Then, enter just the numeric value for the unit you are converting and hit the \"Convert\" button. The converted value will appear below.";
            // 
            // pnlBorderTop
            // 
            pnlBorderTop.BorderStyle = BorderStyle.FixedSingle;
            pnlBorderTop.Controls.Add(lblInstructions);
            pnlBorderTop.Controls.Add(lblInstructions2);
            pnlBorderTop.Controls.Add(lblInstructions3);
            pnlBorderTop.Controls.Add(lblTitle);
            pnlBorderTop.Location = new Point(37, 12);
            pnlBorderTop.Name = "pnlBorderTop";
            pnlBorderTop.Size = new Size(727, 114);
            pnlBorderTop.TabIndex = 10;
            // 
            // UnitConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 643);
            Controls.Add(pnlBorderTop);
            Controls.Add(btnConvert);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(pnlBorderMiddle);
            Name = "UnitConverter";
            Text = "Unit Converter";
            pnlBorderMiddle.ResumeLayout(false);
            pnlBorderMiddle.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpOriginal.ResumeLayout(false);
            grpOriginal.PerformLayout();
            pnlBorderTop.ResumeLayout(false);
            pnlBorderTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlBorderMiddle;
        private GroupBox grpOriginal;
        private Label lblUpperInput;
        private Label lblUpperOutput;
        private GroupBox groupBox1;
        private RadioButton rdoOuncesNew;
        private RadioButton rdoPoundsNew;
        private RadioButton rdoFahrenheitNew;
        private RadioButton rdoMilesNew;
        private RadioButton rdoFeetNew;
        private RadioButton rdoGramsNew;
        private RadioButton rdoKilogramsNew;
        private RadioButton rdoCelsiusNew;
        private RadioButton rdoKilometersNew;
        private RadioButton rdoMetersNew;
        private RadioButton rdoOuncesOG;
        private RadioButton rdoPoundsOG;
        private RadioButton rdoFahrenheitOG;
        private RadioButton rdoMilesOG;
        private RadioButton rdoFeetOG;
        private RadioButton rdoGramsOG;
        private RadioButton rdoKilogramsOG;
        private RadioButton rdoCelsiusOG;
        private RadioButton rdoKilometersOG;
        private RadioButton rdoMetersOG;
        private Label lblInput;
        private Label lblOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnConvert;
        private Label lblInstructions;
        private Label lblInstructions2;
        private Label lblInstructions3;
        private Panel pnlBorderTop;
    }
}