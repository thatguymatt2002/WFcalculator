namespace calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtMain = new MaskedTextBox();
            btnMmryClr = new Button();
            btnMmryRcll = new Button();
            btnMmryStr = new Button();
            btnMmrySub = new Button();
            btnMmryAdd = new Button();
            btnBckSpc = new Button();
            btnClrEntry = new Button();
            btnClrAll = new Button();
            btnNegation = new Button();
            btnSqrRoot = new Button();
            btnSeven = new Button();
            btnNine = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btnEight = new Button();
            btnFive = new Button();
            btnFraction = new Button();
            btnMultiply = new Button();
            btnSix = new Button();
            btnFour = new Button();
            btnSubtract = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnEquals = new Button();
            btnZero = new Button();
            btnAddition = new Button();
            btnDecimal = new Button();
            txtSecondary = new MaskedTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMain
            // 
            txtMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMain.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(txtMain, 5);
            txtMain.Enabled = false;
            txtMain.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtMain.Location = new Point(7, 119);
            txtMain.Margin = new Padding(7, 8, 7, 8);
            txtMain.Name = "txtMain";
            txtMain.ReadOnly = true;
            txtMain.Size = new Size(625, 93);
            txtMain.TabIndex = 0;
            txtMain.Text = "0";
            txtMain.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMmryClr
            // 
            btnMmryClr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMmryClr.AutoSize = true;
            btnMmryClr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMmryClr.BackColor = SystemColors.ActiveCaption;
            btnMmryClr.Location = new Point(7, 230);
            btnMmryClr.Margin = new Padding(7, 8, 7, 8);
            btnMmryClr.Name = "btnMmryClr";
            btnMmryClr.Size = new Size(113, 95);
            btnMmryClr.TabIndex = 1;
            btnMmryClr.Text = "MC";
            btnMmryClr.UseVisualStyleBackColor = false;
            btnMmryClr.Click += btnMmryClr_Click;
            // 
            // btnMmryRcll
            // 
            btnMmryRcll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMmryRcll.AutoSize = true;
            btnMmryRcll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMmryRcll.BackColor = SystemColors.ActiveCaption;
            btnMmryRcll.Location = new Point(134, 230);
            btnMmryRcll.Margin = new Padding(7, 8, 7, 8);
            btnMmryRcll.Name = "btnMmryRcll";
            btnMmryRcll.Size = new Size(113, 95);
            btnMmryRcll.TabIndex = 2;
            btnMmryRcll.Text = "MR";
            btnMmryRcll.UseVisualStyleBackColor = false;
            btnMmryRcll.Click += btnMmryRcll_Click;
            // 
            // btnMmryStr
            // 
            btnMmryStr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMmryStr.AutoSize = true;
            btnMmryStr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMmryStr.BackColor = SystemColors.ActiveCaption;
            btnMmryStr.Location = new Point(261, 230);
            btnMmryStr.Margin = new Padding(7, 8, 7, 8);
            btnMmryStr.Name = "btnMmryStr";
            btnMmryStr.Size = new Size(113, 95);
            btnMmryStr.TabIndex = 3;
            btnMmryStr.Text = "MS";
            btnMmryStr.UseVisualStyleBackColor = false;
            btnMmryStr.Click += btnMmryStr_Click;
            // 
            // btnMmrySub
            // 
            btnMmrySub.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMmrySub.AutoSize = true;
            btnMmrySub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMmrySub.BackColor = SystemColors.ActiveCaption;
            btnMmrySub.Location = new Point(515, 230);
            btnMmrySub.Margin = new Padding(7, 8, 7, 8);
            btnMmrySub.Name = "btnMmrySub";
            btnMmrySub.Size = new Size(117, 95);
            btnMmrySub.TabIndex = 4;
            btnMmrySub.Text = "M-";
            btnMmrySub.UseVisualStyleBackColor = false;
            btnMmrySub.Click += btnMmrySub_Click;
            // 
            // btnMmryAdd
            // 
            btnMmryAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMmryAdd.AutoSize = true;
            btnMmryAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMmryAdd.BackColor = SystemColors.ActiveCaption;
            btnMmryAdd.Location = new Point(388, 230);
            btnMmryAdd.Margin = new Padding(7, 8, 7, 8);
            btnMmryAdd.Name = "btnMmryAdd";
            btnMmryAdd.Size = new Size(113, 95);
            btnMmryAdd.TabIndex = 5;
            btnMmryAdd.Text = "M+";
            btnMmryAdd.UseVisualStyleBackColor = false;
            btnMmryAdd.Click += btnMmryAdd_Click;
            // 
            // btnBckSpc
            // 
            btnBckSpc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBckSpc.AutoSize = true;
            btnBckSpc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBckSpc.BackColor = SystemColors.ActiveCaption;
            btnBckSpc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBckSpc.Location = new Point(7, 341);
            btnBckSpc.Margin = new Padding(7, 8, 7, 8);
            btnBckSpc.Name = "btnBckSpc";
            btnBckSpc.Size = new Size(113, 95);
            btnBckSpc.TabIndex = 6;
            btnBckSpc.Text = "←";
            btnBckSpc.UseVisualStyleBackColor = false;
            btnBckSpc.Click += btnBckSpc_Click;
            // 
            // btnClrEntry
            // 
            btnClrEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClrEntry.AutoSize = true;
            btnClrEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClrEntry.BackColor = Color.Gold;
            btnClrEntry.Location = new Point(134, 341);
            btnClrEntry.Margin = new Padding(7, 8, 7, 8);
            btnClrEntry.Name = "btnClrEntry";
            btnClrEntry.Size = new Size(113, 95);
            btnClrEntry.TabIndex = 7;
            btnClrEntry.Text = "CE";
            btnClrEntry.UseVisualStyleBackColor = false;
            btnClrEntry.Click += btnClrEntry_Click;
            // 
            // btnClrAll
            // 
            btnClrAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClrAll.AutoSize = true;
            btnClrAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClrAll.BackColor = Color.Gold;
            btnClrAll.Location = new Point(261, 341);
            btnClrAll.Margin = new Padding(7, 8, 7, 8);
            btnClrAll.Name = "btnClrAll";
            btnClrAll.Size = new Size(113, 95);
            btnClrAll.TabIndex = 8;
            btnClrAll.Text = "C";
            btnClrAll.UseVisualStyleBackColor = false;
            btnClrAll.Click += btnClrAll_Click;
            // 
            // btnNegation
            // 
            btnNegation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNegation.AutoSize = true;
            btnNegation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNegation.BackColor = SystemColors.ActiveCaption;
            btnNegation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegation.Location = new Point(388, 341);
            btnNegation.Margin = new Padding(7, 8, 7, 8);
            btnNegation.Name = "btnNegation";
            btnNegation.Size = new Size(113, 95);
            btnNegation.TabIndex = 9;
            btnNegation.Text = "±";
            btnNegation.UseVisualStyleBackColor = false;
            // 
            // btnSqrRoot
            // 
            btnSqrRoot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSqrRoot.AutoSize = true;
            btnSqrRoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSqrRoot.BackColor = SystemColors.ActiveCaption;
            btnSqrRoot.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrRoot.Location = new Point(515, 341);
            btnSqrRoot.Margin = new Padding(7, 8, 7, 8);
            btnSqrRoot.Name = "btnSqrRoot";
            btnSqrRoot.Size = new Size(117, 95);
            btnSqrRoot.TabIndex = 10;
            btnSqrRoot.Text = "√";
            btnSqrRoot.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSeven.AutoSize = true;
            btnSeven.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSeven.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(7, 452);
            btnSeven.Margin = new Padding(7, 8, 7, 8);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(113, 95);
            btnSeven.TabIndex = 11;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += digitClick;
            // 
            // btnNine
            // 
            btnNine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNine.AutoSize = true;
            btnNine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNine.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(261, 452);
            btnNine.Margin = new Padding(7, 8, 7, 8);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(113, 95);
            btnNine.TabIndex = 12;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += digitClick;
            // 
            // btnPercent
            // 
            btnPercent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPercent.AutoSize = true;
            btnPercent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPercent.BackColor = SystemColors.ActiveCaption;
            btnPercent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPercent.Location = new Point(515, 452);
            btnPercent.Margin = new Padding(7, 8, 7, 8);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(117, 95);
            btnPercent.TabIndex = 13;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDivide.AutoSize = true;
            btnDivide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(388, 452);
            btnDivide.Margin = new Padding(7, 8, 7, 8);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(113, 95);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEight
            // 
            btnEight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEight.AutoSize = true;
            btnEight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(134, 452);
            btnEight.Margin = new Padding(7, 8, 7, 8);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(113, 95);
            btnEight.TabIndex = 15;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += digitClick;
            // 
            // btnFive
            // 
            btnFive.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFive.AutoSize = true;
            btnFive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFive.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(134, 563);
            btnFive.Margin = new Padding(7, 8, 7, 8);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(113, 95);
            btnFive.TabIndex = 16;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += digitClick;
            // 
            // btnFraction
            // 
            btnFraction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFraction.AutoSize = true;
            btnFraction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFraction.BackColor = SystemColors.ActiveCaption;
            btnFraction.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFraction.Location = new Point(515, 563);
            btnFraction.Margin = new Padding(7, 8, 7, 8);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(117, 95);
            btnFraction.TabIndex = 17;
            btnFraction.Text = "⅟";
            btnFraction.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMultiply.AutoSize = true;
            btnMultiply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(388, 563);
            btnMultiply.Margin = new Padding(7, 8, 7, 8);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(113, 95);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSix
            // 
            btnSix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSix.AutoSize = true;
            btnSix.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSix.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(261, 563);
            btnSix.Margin = new Padding(7, 8, 7, 8);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(113, 95);
            btnSix.TabIndex = 19;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += digitClick;
            // 
            // btnFour
            // 
            btnFour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFour.AutoSize = true;
            btnFour.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(7, 563);
            btnFour.Margin = new Padding(7, 8, 7, 8);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(113, 95);
            btnFour.TabIndex = 20;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += digitClick;
            // 
            // btnSubtract
            // 
            btnSubtract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubtract.AutoSize = true;
            btnSubtract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubtract.BackColor = SystemColors.ActiveCaption;
            btnSubtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(388, 674);
            btnSubtract.Margin = new Padding(7, 8, 7, 8);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(113, 95);
            btnSubtract.TabIndex = 21;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnThree
            // 
            btnThree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThree.AutoSize = true;
            btnThree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThree.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(261, 674);
            btnThree.Margin = new Padding(7, 8, 7, 8);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(113, 95);
            btnThree.TabIndex = 22;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += digitClick;
            // 
            // btnTwo
            // 
            btnTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTwo.AutoSize = true;
            btnTwo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTwo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(134, 674);
            btnTwo.Margin = new Padding(7, 8, 7, 8);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(113, 95);
            btnTwo.TabIndex = 23;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += digitClick;
            // 
            // btnOne
            // 
            btnOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOne.AutoSize = true;
            btnOne.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOne.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(7, 674);
            btnOne.Margin = new Padding(7, 8, 7, 8);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(113, 95);
            btnOne.TabIndex = 24;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += digitClick;
            // 
            // btnEquals
            // 
            btnEquals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEquals.AutoSize = true;
            btnEquals.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEquals.BackColor = Color.LightCoral;
            btnEquals.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(515, 674);
            btnEquals.Margin = new Padding(7, 8, 7, 8);
            btnEquals.Name = "btnEquals";
            tableLayoutPanel1.SetRowSpan(btnEquals, 2);
            btnEquals.Size = new Size(117, 208);
            btnEquals.TabIndex = 25;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnZero
            // 
            btnZero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnZero.AutoSize = true;
            btnZero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(btnZero, 2);
            btnZero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(7, 785);
            btnZero.Margin = new Padding(7, 8, 7, 8);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(240, 97);
            btnZero.TabIndex = 26;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += digitClick;
            // 
            // btnAddition
            // 
            btnAddition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddition.AutoSize = true;
            btnAddition.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddition.BackColor = SystemColors.ActiveCaption;
            btnAddition.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddition.Location = new Point(388, 785);
            btnAddition.Margin = new Padding(7, 8, 7, 8);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(113, 97);
            btnAddition.TabIndex = 27;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDecimal.AutoSize = true;
            btnDecimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.Location = new Point(261, 785);
            btnDecimal.Margin = new Padding(7, 8, 7, 8);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(113, 97);
            btnDecimal.TabIndex = 28;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // txtSecondary
            // 
            txtSecondary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSecondary.BackColor = SystemColors.Control;
            txtSecondary.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(txtSecondary, 5);
            txtSecondary.Enabled = false;
            txtSecondary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondary.Location = new Point(3, 54);
            txtSecondary.Name = "txtSecondary";
            txtSecondary.Size = new Size(633, 54);
            txtSecondary.TabIndex = 29;
            txtSecondary.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnAddition, 3, 7);
            tableLayoutPanel1.Controls.Add(btnDecimal, 2, 7);
            tableLayoutPanel1.Controls.Add(txtSecondary, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMain, 0, 1);
            tableLayoutPanel1.Controls.Add(btnZero, 0, 7);
            tableLayoutPanel1.Controls.Add(btnMmryClr, 0, 2);
            tableLayoutPanel1.Controls.Add(btnOne, 0, 6);
            tableLayoutPanel1.Controls.Add(btnEquals, 4, 6);
            tableLayoutPanel1.Controls.Add(btnTwo, 1, 6);
            tableLayoutPanel1.Controls.Add(btnMmryRcll, 1, 2);
            tableLayoutPanel1.Controls.Add(btnThree, 2, 6);
            tableLayoutPanel1.Controls.Add(btnMmryStr, 2, 2);
            tableLayoutPanel1.Controls.Add(btnSubtract, 3, 6);
            tableLayoutPanel1.Controls.Add(btnMmryAdd, 3, 2);
            tableLayoutPanel1.Controls.Add(btnMmrySub, 4, 2);
            tableLayoutPanel1.Controls.Add(btnBckSpc, 0, 3);
            tableLayoutPanel1.Controls.Add(btnFraction, 4, 5);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 5);
            tableLayoutPanel1.Controls.Add(btnSix, 2, 5);
            tableLayoutPanel1.Controls.Add(btnFour, 0, 5);
            tableLayoutPanel1.Controls.Add(btnClrEntry, 1, 3);
            tableLayoutPanel1.Controls.Add(btnClrAll, 2, 3);
            tableLayoutPanel1.Controls.Add(btnFive, 1, 5);
            tableLayoutPanel1.Controls.Add(btnNegation, 3, 3);
            tableLayoutPanel1.Controls.Add(btnSqrRoot, 4, 3);
            tableLayoutPanel1.Controls.Add(btnSeven, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPercent, 4, 4);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 4);
            tableLayoutPanel1.Controls.Add(btnEight, 1, 4);
            tableLayoutPanel1.Controls.Add(btnNine, 2, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(639, 890);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(663, 914);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            MinimumSize = new Size(695, 1002);
            Name = "Form1";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox txtMain;
        private Button btnMmryClr;
        private Button btnMmryRcll;
        private Button btnMmryStr;
        private Button btnMmrySub;
        private Button btnMmryAdd;
        private Button btnBckSpc;
        private Button btnClrEntry;
        private Button btnClrAll;
        private Button btnNegation;
        private Button btnSqrRoot;
        private Button btnSeven;
        private Button btnNine;
        private Button btnPercent;
        private Button btnDivide;
        private Button btnEight;
        private Button btnFive;
        private Button btnFraction;
        private Button btnMultiply;
        private Button btnSix;
        private Button btnFour;
        private Button btnSubtract;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnEquals;
        private Button btnZero;
        private Button btnAddition;
        private Button btnDecimal;
        private MaskedTextBox txtSecondary;
        private TableLayoutPanel tableLayoutPanel1;
    }
}