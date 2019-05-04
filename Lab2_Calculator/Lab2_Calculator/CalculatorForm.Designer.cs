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
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btn10PowX = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.Tanh = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnXpow3 = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnXpow2 = new System.Windows.Forms.Button();
            this.btnEconst = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnXpowY = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPI = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panelScientific = new System.Windows.Forms.Panel();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbDec = new System.Windows.Forms.RadioButton();
            this.rbOct = new System.Windows.Forms.RadioButton();
            this.rbBin = new System.Windows.Forms.RadioButton();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblOct = new System.Windows.Forms.Label();
            this.lblDec = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panelProgrammer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelScientific.SuspendLayout();
            this.panelProgrammer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.menuToolStripMenuItem.Text = "View";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 30);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(234, 40);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(12, 86);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(54, 37);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<--";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDevide.Location = new System.Drawing.Point(192, 258);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(54, 37);
            this.btnDevide.TabIndex = 3;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCE.Location = new System.Drawing.Point(132, 86);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(52, 37);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnToggleSign
            // 
            this.btnToggleSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToggleSign.Location = new System.Drawing.Point(192, 86);
            this.btnToggleSign.Name = "btnToggleSign";
            this.btnToggleSign.Size = new System.Drawing.Size(54, 37);
            this.btnToggleSign.TabIndex = 5;
            this.btnToggleSign.Text = "+ -";
            this.btnToggleSign.UseVisualStyleBackColor = true;
            this.btnToggleSign.Click += new System.EventHandler(this.btnToggleSign_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(192, 129);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(54, 37);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(132, 129);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 37);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(72, 129);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 37);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn7.Location = new System.Drawing.Point(12, 129);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 37);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(192, 172);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(54, 37);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(132, 172);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 37);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(72, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 37);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(12, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 37);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiply.Location = new System.Drawing.Point(192, 215);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(54, 37);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(132, 215);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 37);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(72, 215);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 37);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(12, 215);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 37);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPoint.Location = new System.Drawing.Point(132, 258);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(54, 37);
            this.btnPoint.TabIndex = 18;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(12, 258);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(114, 37);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquals.Location = new System.Drawing.Point(12, 301);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(234, 37);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(74, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 37);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(60, 0);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(54, 37);
            this.btnSqrt.TabIndex = 40;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLn.Location = new System.Drawing.Point(120, 43);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(54, 37);
            this.btnLn.TabIndex = 38;
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btn10PowX
            // 
            this.btn10PowX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn10PowX.Location = new System.Drawing.Point(180, 129);
            this.btn10PowX.Name = "btn10PowX";
            this.btn10PowX.Size = new System.Drawing.Size(54, 37);
            this.btn10PowX.TabIndex = 37;
            this.btn10PowX.Text = "10^x";
            this.btn10PowX.UseVisualStyleBackColor = true;
            this.btn10PowX.Click += new System.EventHandler(this.btn10PowX_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.Location = new System.Drawing.Point(120, 172);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(54, 37);
            this.btn.TabIndex = 36;
            this.btn.Text = "n!";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // Tanh
            // 
            this.Tanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tanh.Location = new System.Drawing.Point(60, 172);
            this.Tanh.Name = "Tanh";
            this.Tanh.Size = new System.Drawing.Size(54, 37);
            this.Tanh.TabIndex = 35;
            this.Tanh.Text = "Tanh";
            this.Tanh.UseVisualStyleBackColor = true;
            this.Tanh.Click += new System.EventHandler(this.Tanh_Click);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTan.Location = new System.Drawing.Point(0, 172);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(54, 37);
            this.btnTan.TabIndex = 34;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnXpow3
            // 
            this.btnXpow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpow3.Location = new System.Drawing.Point(180, 86);
            this.btnXpow3.Name = "btnXpow3";
            this.btnXpow3.Size = new System.Drawing.Size(54, 37);
            this.btnXpow3.TabIndex = 33;
            this.btnXpow3.Text = "x^3";
            this.btnXpow3.UseVisualStyleBackColor = true;
            this.btnXpow3.Click += new System.EventHandler(this.btnXpow3_Click);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInt.Location = new System.Drawing.Point(120, 129);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(54, 37);
            this.btnInt.TabIndex = 32;
            this.btnInt.Text = "Int";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCosh.Location = new System.Drawing.Point(60, 129);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(54, 37);
            this.btnCosh.TabIndex = 31;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = true;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCos.Location = new System.Drawing.Point(0, 129);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(54, 37);
            this.btnCos.TabIndex = 30;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnXpow2
            // 
            this.btnXpow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpow2.Location = new System.Drawing.Point(180, 43);
            this.btnXpow2.Name = "btnXpow2";
            this.btnXpow2.Size = new System.Drawing.Size(54, 37);
            this.btnXpow2.TabIndex = 29;
            this.btnXpow2.Text = "x^2";
            this.btnXpow2.UseVisualStyleBackColor = true;
            this.btnXpow2.Click += new System.EventHandler(this.btnXpow2_Click);
            // 
            // btnEconst
            // 
            this.btnEconst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEconst.Location = new System.Drawing.Point(120, 86);
            this.btnEconst.Name = "btnEconst";
            this.btnEconst.Size = new System.Drawing.Size(54, 37);
            this.btnEconst.TabIndex = 28;
            this.btnEconst.Text = "E";
            this.btnEconst.UseVisualStyleBackColor = true;
            this.btnEconst.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSinh.Location = new System.Drawing.Point(60, 86);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(54, 37);
            this.btnSinh.TabIndex = 27;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSin.Location = new System.Drawing.Point(0, 86);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(54, 37);
            this.btnSin.TabIndex = 26;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnXpowY
            // 
            this.btnXpowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXpowY.Location = new System.Drawing.Point(180, 0);
            this.btnXpowY.Name = "btnXpowY";
            this.btnXpowY.Size = new System.Drawing.Size(54, 37);
            this.btnXpowY.TabIndex = 25;
            this.btnXpowY.Text = "x^y";
            this.btnXpowY.UseVisualStyleBackColor = true;
            this.btnXpowY.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnInv
            // 
            this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInv.Location = new System.Drawing.Point(120, 0);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(54, 37);
            this.btnInv.TabIndex = 24;
            this.btnInv.Text = "1/x";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMod.Location = new System.Drawing.Point(180, 172);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(54, 37);
            this.btnMod.TabIndex = 23;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BasicOperation_Click);
            // 
            // btnPI
            // 
            this.btnPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPI.Location = new System.Drawing.Point(0, 0);
            this.btnPI.Name = "btnPI";
            this.btnPI.Size = new System.Drawing.Size(54, 37);
            this.btnPI.TabIndex = 22;
            this.btnPI.Text = "PI";
            this.btnPI.UseVisualStyleBackColor = true;
            this.btnPI.Click += new System.EventHandler(this.btnPI_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(60, 43);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(54, 37);
            this.btnLog.TabIndex = 41;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExp.Location = new System.Drawing.Point(0, 43);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(54, 37);
            this.btnExp.TabIndex = 42;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(13, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(14, 15);
            this.label.TabIndex = 43;
            this.label.Text = "0";
            // 
            // panelScientific
            // 
            this.panelScientific.Controls.Add(this.btnXpow2);
            this.panelScientific.Controls.Add(this.btnPI);
            this.panelScientific.Controls.Add(this.btnMod);
            this.panelScientific.Controls.Add(this.btnInv);
            this.panelScientific.Controls.Add(this.btnXpowY);
            this.panelScientific.Controls.Add(this.btnSin);
            this.panelScientific.Controls.Add(this.btnSinh);
            this.panelScientific.Controls.Add(this.btnEconst);
            this.panelScientific.Controls.Add(this.btnCos);
            this.panelScientific.Controls.Add(this.btnCosh);
            this.panelScientific.Controls.Add(this.btnExp);
            this.panelScientific.Controls.Add(this.btnInt);
            this.panelScientific.Controls.Add(this.btnLog);
            this.panelScientific.Controls.Add(this.btnXpow3);
            this.panelScientific.Controls.Add(this.btnSqrt);
            this.panelScientific.Controls.Add(this.btnTan);
            this.panelScientific.Controls.Add(this.btnLn);
            this.panelScientific.Controls.Add(this.Tanh);
            this.panelScientific.Controls.Add(this.btn10PowX);
            this.panelScientific.Controls.Add(this.btn);
            this.panelScientific.Location = new System.Drawing.Point(267, 86);
            this.panelScientific.Name = "panelScientific";
            this.panelScientific.Size = new System.Drawing.Size(234, 209);
            this.panelScientific.TabIndex = 52;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbHex.Location = new System.Drawing.Point(3, 3);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(63, 28);
            this.rbHex.TabIndex = 53;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbDec
            // 
            this.rbDec.AutoSize = true;
            this.rbDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDec.Location = new System.Drawing.Point(3, 46);
            this.rbDec.Name = "rbDec";
            this.rbDec.Size = new System.Drawing.Size(62, 28);
            this.rbDec.TabIndex = 54;
            this.rbDec.TabStop = true;
            this.rbDec.Text = "Dec";
            this.rbDec.UseVisualStyleBackColor = true;
            this.rbDec.CheckedChanged += new System.EventHandler(this.rbDec_CheckedChanged);
            // 
            // rbOct
            // 
            this.rbOct.AutoSize = true;
            this.rbOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOct.Location = new System.Drawing.Point(3, 89);
            this.rbOct.Name = "rbOct";
            this.rbOct.Size = new System.Drawing.Size(57, 28);
            this.rbOct.TabIndex = 55;
            this.rbOct.TabStop = true;
            this.rbOct.Text = "Oct";
            this.rbOct.UseVisualStyleBackColor = true;
            this.rbOct.CheckedChanged += new System.EventHandler(this.rbOct_CheckedChanged);
            // 
            // rbBin
            // 
            this.rbBin.AutoSize = true;
            this.rbBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbBin.Location = new System.Drawing.Point(3, 132);
            this.rbBin.Name = "rbBin";
            this.rbBin.Size = new System.Drawing.Size(55, 28);
            this.rbBin.TabIndex = 56;
            this.rbBin.TabStop = true;
            this.rbBin.Text = "Bin";
            this.rbBin.UseVisualStyleBackColor = true;
            this.rbBin.CheckedChanged += new System.EventHandler(this.rbBin_CheckedChanged);
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBin.Location = new System.Drawing.Point(70, 135);
            this.lblBin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(20, 24);
            this.lblBin.TabIndex = 60;
            this.lblBin.Text = "0";
            // 
            // lblOct
            // 
            this.lblOct.AutoSize = true;
            this.lblOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOct.Location = new System.Drawing.Point(70, 92);
            this.lblOct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOct.Name = "lblOct";
            this.lblOct.Size = new System.Drawing.Size(20, 24);
            this.lblOct.TabIndex = 59;
            this.lblOct.Text = "0";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDec.Location = new System.Drawing.Point(70, 50);
            this.lblDec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(20, 24);
            this.lblDec.TabIndex = 58;
            this.lblDec.Text = "0";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHex.Location = new System.Drawing.Point(70, 7);
            this.lblHex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(20, 24);
            this.lblHex.TabIndex = 57;
            this.lblHex.Text = "0";
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnD.Location = new System.Drawing.Point(3, 215);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(54, 37);
            this.btnD.TabIndex = 62;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnA.Location = new System.Drawing.Point(3, 172);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(54, 37);
            this.btnA.TabIndex = 61;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(63, 215);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(54, 37);
            this.btnE.TabIndex = 64;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(63, 172);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(54, 37);
            this.btnB.TabIndex = 63;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF.Location = new System.Drawing.Point(123, 215);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(54, 37);
            this.btnF.TabIndex = 66;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(123, 172);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(54, 37);
            this.btnC.TabIndex = 65;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // panelProgrammer
            // 
            this.panelProgrammer.Controls.Add(this.rbHex);
            this.panelProgrammer.Controls.Add(this.btnF);
            this.panelProgrammer.Controls.Add(this.rbDec);
            this.panelProgrammer.Controls.Add(this.btnC);
            this.panelProgrammer.Controls.Add(this.rbOct);
            this.panelProgrammer.Controls.Add(this.btnE);
            this.panelProgrammer.Controls.Add(this.rbBin);
            this.panelProgrammer.Controls.Add(this.btnB);
            this.panelProgrammer.Controls.Add(this.lblHex);
            this.panelProgrammer.Controls.Add(this.btnD);
            this.panelProgrammer.Controls.Add(this.lblDec);
            this.panelProgrammer.Controls.Add(this.btnA);
            this.panelProgrammer.Controls.Add(this.lblOct);
            this.panelProgrammer.Controls.Add(this.lblBin);
            this.panelProgrammer.Location = new System.Drawing.Point(542, 86);
            this.panelProgrammer.Name = "panelProgrammer";
            this.panelProgrammer.Size = new System.Drawing.Size(328, 252);
            this.panelProgrammer.TabIndex = 67;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 347);
            this.Controls.Add(this.panelProgrammer);
            this.Controls.Add(this.panelScientific);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCancel);
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
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelScientific.ResumeLayout(false);
            this.panelProgrammer.ResumeLayout(false);
            this.panelProgrammer.PerformLayout();
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btn10PowX;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button Tanh;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnXpow3;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnXpow2;
        private System.Windows.Forms.Button btnEconst;
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
        private System.Windows.Forms.Panel panelScientific;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbDec;
        private System.Windows.Forms.RadioButton rbOct;
        private System.Windows.Forms.RadioButton rbBin;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblOct;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Panel panelProgrammer;
    }
}

