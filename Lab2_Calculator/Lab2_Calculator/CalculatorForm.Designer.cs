namespace Lab2_Calculator
{
    partial class CalculatorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnToggleSign = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btn10PowX = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnXpow3 = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnXpow2 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnXpowY = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblBinValue = new System.Windows.Forms.Label();
            this.lblOctValue = new System.Windows.Forms.Label();
            this.lblDecValue = new System.Windows.Forms.Label();
            this.lblHexValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.menuToolStripMenuItem.Text = "View";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.Location = new System.Drawing.Point(16, 37);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(311, 48);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(16, 106);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 46);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<--";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDevide.Location = new System.Drawing.Point(256, 318);
            this.btnDevide.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(72, 46);
            this.btnDevide.TabIndex = 3;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCE.Location = new System.Drawing.Point(176, 106);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(69, 46);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnToggleSign
            // 
            this.btnToggleSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToggleSign.Location = new System.Drawing.Point(256, 106);
            this.btnToggleSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnToggleSign.Name = "btnToggleSign";
            this.btnToggleSign.Size = new System.Drawing.Size(72, 46);
            this.btnToggleSign.TabIndex = 5;
            this.btnToggleSign.Text = "+ -";
            this.btnToggleSign.UseVisualStyleBackColor = true;
            this.btnToggleSign.Click += new System.EventHandler(this.btnToggleSign_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(256, 159);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(72, 46);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(176, 159);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 46);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(96, 159);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 46);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(16, 159);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 46);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(256, 212);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(72, 46);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(176, 212);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 46);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(96, 212);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 46);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(16, 212);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 46);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(256, 265);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(72, 46);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(176, 265);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 46);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(96, 265);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 46);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(16, 265);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 46);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPoint.Location = new System.Drawing.Point(176, 318);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(72, 46);
            this.btnPoint.TabIndex = 18;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(16, 318);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(152, 46);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquals.Location = new System.Drawing.Point(16, 370);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(312, 46);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(99, 106);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(69, 46);
            this.btnC.TabIndex = 21;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(436, 106);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(72, 46);
            this.btnSqrt.TabIndex = 40;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLn.Location = new System.Drawing.Point(516, 159);
            this.btnLn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(72, 46);
            this.btnLn.TabIndex = 38;
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btn10PowX
            // 
            this.btn10PowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn10PowX.Location = new System.Drawing.Point(596, 265);
            this.btn10PowX.Margin = new System.Windows.Forms.Padding(4);
            this.btn10PowX.Name = "btn10PowX";
            this.btn10PowX.Size = new System.Drawing.Size(72, 46);
            this.btn10PowX.TabIndex = 37;
            this.btn10PowX.Text = "10^x";
            this.btn10PowX.UseVisualStyleBackColor = true;
            this.btn10PowX.Click += new System.EventHandler(this.btn10PowX_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFactorial.Location = new System.Drawing.Point(516, 318);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(72, 46);
            this.btnFactorial.TabIndex = 36;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Tanh
            // 
            this.Tanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tanh.Location = new System.Drawing.Point(436, 318);
            this.Tanh.Margin = new System.Windows.Forms.Padding(4);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(72, 46);
            this.Tanh.TabIndex = 35;
            this.Tanh.Text = "Tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTan.Location = new System.Drawing.Point(356, 318);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(72, 46);
            this.btnTan.TabIndex = 34;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnXpow3
            // 
            this.btnXpow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpow3.Location = new System.Drawing.Point(596, 212);
            this.btnXpow3.Margin = new System.Windows.Forms.Padding(4);
            this.btnXpow3.Name = "btnXpow3";
            this.btnXpow3.Size = new System.Drawing.Size(72, 46);
            this.btnXpow3.TabIndex = 33;
            this.btnXpow3.Text = "x^3";
            this.btnXpow3.UseVisualStyleBackColor = true;
            this.btnXpow3.Click += new System.EventHandler(this.btnXpow3_Click);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInt.Location = new System.Drawing.Point(516, 265);
            this.btnInt.Margin = new System.Windows.Forms.Padding(4);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(72, 46);
            this.btnInt.TabIndex = 32;
            this.btnInt.Text = "Int";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCosh.Location = new System.Drawing.Point(436, 265);
            this.btnCosh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(72, 46);
            this.btnCosh.TabIndex = 31;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos.Location = new System.Drawing.Point(356, 265);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(72, 46);
            this.btnCos.TabIndex = 30;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnXpow2
            // 
            this.btnXpow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpow2.Location = new System.Drawing.Point(596, 159);
            this.btnXpow2.Margin = new System.Windows.Forms.Padding(4);
            this.btnXpow2.Name = "btnXpow2";
            this.btnXpow2.Size = new System.Drawing.Size(72, 46);
            this.btnXpow2.TabIndex = 29;
            this.btnXpow2.Text = "x^2";
            this.btnXpow2.UseVisualStyleBackColor = true;
            this.btnXpow2.Click += new System.EventHandler(this.btnXpow2_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(516, 212);
            this.btnE.Margin = new System.Windows.Forms.Padding(4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(72, 46);
            this.btnE.TabIndex = 28;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSinh.Location = new System.Drawing.Point(436, 212);
            this.btnSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(72, 46);
            this.btnSinh.TabIndex = 27;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new System.Drawing.Point(356, 212);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(72, 46);
            this.btnSin.TabIndex = 26;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnXpowY
            // 
            this.btnXpowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpowY.Location = new System.Drawing.Point(596, 106);
            this.btnXpowY.Margin = new System.Windows.Forms.Padding(4);
            this.btnXpowY.Name = "btnXpowY";
            this.btnXpowY.Size = new System.Drawing.Size(72, 46);
            this.btnXpowY.TabIndex = 25;
            this.btnXpowY.Text = "x^y";
            this.btnXpowY.UseVisualStyleBackColor = true;
            this.btnXpowY.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnInv
            // 
            this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInv.Location = new System.Drawing.Point(516, 106);
            this.btnInv.Margin = new System.Windows.Forms.Padding(4);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(72, 46);
            this.btnInv.TabIndex = 24;
            this.btnInv.Text = "1/x";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMod.Location = new System.Drawing.Point(596, 318);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(72, 46);
            this.btnMod.TabIndex = 23;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnPI
            // 
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPI.Location = new System.Drawing.Point(356, 106);
            this.btnPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(72, 46);
            this.btnPI.TabIndex = 22;
            this.btnPI.Text = "PI";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(436, 159);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(72, 46);
            this.btnLog.TabIndex = 41;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExp.Location = new System.Drawing.Point(356, 159);
            this.btnExp.Margin = new System.Windows.Forms.Padding(4);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(72, 46);
            this.btnExp.TabIndex = 42;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(17, 38);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 18);
            this.label.TabIndex = 43;
            this.label.Text = "0";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHex.Location = new System.Drawing.Point(694, 123);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(55, 29);
            this.lblHex.TabIndex = 44;
            this.lblHex.Text = "Hex";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDec.Location = new System.Drawing.Point(694, 176);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(56, 29);
            this.lblDec.TabIndex = 45;
            this.lblDec.Text = "Dec";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOct.Location = new System.Drawing.Point(694, 229);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(50, 29);
            this.lblOct.TabIndex = 46;
            this.lblOct.Text = "Oct";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBin.Location = new System.Drawing.Point(694, 282);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(48, 29);
            this.lblBin.TabIndex = 47;
            this.lblBin.Text = "Bin";
            // 
            // lblBinValue
            // 
            this.lblBinValue.AutoSize = true;
            this.lblBinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBinValue.Location = new System.Drawing.Point(756, 282);
            this.lblBinValue.Name = "lblBinValue";
            this.lblBinValue.Size = new System.Drawing.Size(26, 29);
            this.lblBinValue.TabIndex = 51;
            this.lblBinValue.Text = "0";
            // 
            // lblOctValue
            // 
            this.lblOctValue.AutoSize = true;
            this.lblOctValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOctValue.Location = new System.Drawing.Point(756, 229);
            this.lblOctValue.Name = "lblOctValue";
            this.lblOctValue.Size = new System.Drawing.Size(26, 29);
            this.lblOctValue.TabIndex = 50;
            this.lblOctValue.Text = "0";
            // 
            // lblDecValue
            // 
            this.lblDecValue.AutoSize = true;
            this.lblDecValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDecValue.Location = new System.Drawing.Point(756, 176);
            this.lblDecValue.Name = "lblDecValue";
            this.lblDecValue.Size = new System.Drawing.Size(26, 29);
            this.lblDecValue.TabIndex = 49;
            this.lblDecValue.Text = "0";
            // 
            // lblHexValue
            // 
            this.lblHexValue.AutoSize = true;
            this.lblHexValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHexValue.Location = new System.Drawing.Point(755, 123);
            this.lblHexValue.Name = "lblHexValue";
            this.lblHexValue.Size = new System.Drawing.Size(26, 29);
            this.lblHexValue.TabIndex = 48;
            this.lblHexValue.Text = "0";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 431);
            this.Controls.Add(this.lblBinValue);
            this.Controls.Add(this.lblOctValue);
            this.Controls.Add(this.lblDecValue);
            this.Controls.Add(this.lblHexValue);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(this.lblOct);
            this.Controls.Add(this.lblDec);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btn10PowX);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.Tanh);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnXpow3);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnXpow2);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnXpowY);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnPI);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnToggleSign);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnToggleSign;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btn10PowX;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnXpow3;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnXpow2;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnXpowY;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnPI;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblBinValue;
        private System.Windows.Forms.Label lblOctValue;
        private System.Windows.Forms.Label lblDecValue;
        private System.Windows.Forms.Label lblHexValue;
    }
}

