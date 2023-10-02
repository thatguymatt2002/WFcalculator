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
            SuspendLayout();
            // 
            // txtMain
            // 
            txtMain.BorderStyle = BorderStyle.None;
            txtMain.Enabled = false;
            txtMain.Font = new Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtMain.Location = new Point(31, 121);
            txtMain.Margin = new Padding(7, 8, 7, 8);
            txtMain.Name = "txtMain";
            txtMain.ReadOnly = true;
            txtMain.Size = new Size(580, 93);
            txtMain.TabIndex = 0;
            txtMain.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMmryClr
            // 
            btnMmryClr.BackColor = SystemColors.ActiveCaption;
            btnMmryClr.Location = new Point(31, 269);
            btnMmryClr.Margin = new Padding(7, 8, 7, 8);
            btnMmryClr.Name = "btnMmryClr";
            btnMmryClr.Size = new Size(104, 85);
            btnMmryClr.TabIndex = 1;
            btnMmryClr.Text = "MC";
            btnMmryClr.UseVisualStyleBackColor = false;
            // 
            // btnMmryRcll
            // 
            btnMmryRcll.BackColor = SystemColors.ActiveCaption;
            btnMmryRcll.Location = new Point(148, 269);
            btnMmryRcll.Margin = new Padding(7, 8, 7, 8);
            btnMmryRcll.Name = "btnMmryRcll";
            btnMmryRcll.Size = new Size(104, 85);
            btnMmryRcll.TabIndex = 2;
            btnMmryRcll.Text = "MR";
            btnMmryRcll.UseVisualStyleBackColor = false;
            // 
            // btnMmryStr
            // 
            btnMmryStr.BackColor = SystemColors.ActiveCaption;
            btnMmryStr.Location = new Point(270, 269);
            btnMmryStr.Margin = new Padding(7, 8, 7, 8);
            btnMmryStr.Name = "btnMmryStr";
            btnMmryStr.Size = new Size(104, 85);
            btnMmryStr.TabIndex = 3;
            btnMmryStr.Text = "MS";
            btnMmryStr.UseVisualStyleBackColor = false;
            // 
            // btnMmrySub
            // 
            btnMmrySub.BackColor = SystemColors.ActiveCaption;
            btnMmrySub.Location = new Point(504, 269);
            btnMmrySub.Margin = new Padding(7, 8, 7, 8);
            btnMmrySub.Name = "btnMmrySub";
            btnMmrySub.Size = new Size(104, 85);
            btnMmrySub.TabIndex = 4;
            btnMmrySub.Text = "M-";
            btnMmrySub.UseVisualStyleBackColor = false;
            // 
            // btnMmryAdd
            // 
            btnMmryAdd.BackColor = SystemColors.ActiveCaption;
            btnMmryAdd.Location = new Point(388, 269);
            btnMmryAdd.Margin = new Padding(7, 8, 7, 8);
            btnMmryAdd.Name = "btnMmryAdd";
            btnMmryAdd.Size = new Size(104, 85);
            btnMmryAdd.TabIndex = 5;
            btnMmryAdd.Text = "M+";
            btnMmryAdd.UseVisualStyleBackColor = false;
            // 
            // btnBckSpc
            // 
            btnBckSpc.BackColor = SystemColors.ActiveCaption;
            btnBckSpc.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBckSpc.Location = new Point(31, 370);
            btnBckSpc.Margin = new Padding(7, 8, 7, 8);
            btnBckSpc.Name = "btnBckSpc";
            btnBckSpc.Size = new Size(104, 85);
            btnBckSpc.TabIndex = 6;
            btnBckSpc.Text = "←";
            btnBckSpc.UseVisualStyleBackColor = false;
            // 
            // btnClrEntry
            // 
            btnClrEntry.BackColor = Color.Gold;
            btnClrEntry.Location = new Point(149, 370);
            btnClrEntry.Margin = new Padding(7, 8, 7, 8);
            btnClrEntry.Name = "btnClrEntry";
            btnClrEntry.Size = new Size(104, 85);
            btnClrEntry.TabIndex = 7;
            btnClrEntry.Text = "CE";
            btnClrEntry.UseVisualStyleBackColor = false;
            btnClrEntry.Click += btnClrEntry_Click;
            // 
            // btnClrAll
            // 
            btnClrAll.BackColor = Color.Gold;
            btnClrAll.Location = new Point(270, 370);
            btnClrAll.Margin = new Padding(7, 8, 7, 8);
            btnClrAll.Name = "btnClrAll";
            btnClrAll.Size = new Size(104, 85);
            btnClrAll.TabIndex = 8;
            btnClrAll.Text = "C";
            btnClrAll.UseVisualStyleBackColor = false;
            btnClrAll.Click += btnClrAll_Click;
            // 
            // btnNegation
            // 
            btnNegation.BackColor = SystemColors.ActiveCaption;
            btnNegation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegation.Location = new Point(388, 370);
            btnNegation.Margin = new Padding(7, 8, 7, 8);
            btnNegation.Name = "btnNegation";
            btnNegation.Size = new Size(104, 85);
            btnNegation.TabIndex = 9;
            btnNegation.Text = "±";
            btnNegation.UseVisualStyleBackColor = false;
            // 
            // btnSqrRoot
            // 
            btnSqrRoot.BackColor = SystemColors.ActiveCaption;
            btnSqrRoot.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrRoot.Location = new Point(504, 370);
            btnSqrRoot.Margin = new Padding(7, 8, 7, 8);
            btnSqrRoot.Name = "btnSqrRoot";
            btnSqrRoot.Size = new Size(104, 85);
            btnSqrRoot.TabIndex = 10;
            btnSqrRoot.Text = "√";
            btnSqrRoot.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(31, 471);
            btnSeven.Margin = new Padding(7, 8, 7, 8);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(104, 85);
            btnSeven.TabIndex = 11;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(265, 471);
            btnNine.Margin = new Padding(7, 8, 7, 8);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(104, 85);
            btnNine.TabIndex = 12;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.ActiveCaption;
            btnPercent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPercent.Location = new Point(504, 471);
            btnPercent.Margin = new Padding(7, 8, 7, 8);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(104, 85);
            btnPercent.TabIndex = 13;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ActiveCaption;
            btnDivide.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(388, 471);
            btnDivide.Margin = new Padding(7, 8, 7, 8);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(104, 85);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(148, 471);
            btnEight.Margin = new Padding(7, 8, 7, 8);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(104, 85);
            btnEight.TabIndex = 15;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(147, 572);
            btnFive.Margin = new Padding(7, 8, 7, 8);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(104, 85);
            btnFive.TabIndex = 16;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnFraction
            // 
            btnFraction.BackColor = SystemColors.ActiveCaption;
            btnFraction.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFraction.Location = new Point(504, 572);
            btnFraction.Margin = new Padding(7, 8, 7, 8);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(104, 85);
            btnFraction.TabIndex = 17;
            btnFraction.Text = "⅟";
            btnFraction.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ActiveCaption;
            btnMultiply.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(388, 572);
            btnMultiply.Margin = new Padding(7, 8, 7, 8);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(104, 85);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(265, 572);
            btnSix.Margin = new Padding(7, 8, 7, 8);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(104, 85);
            btnSix.TabIndex = 19;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(29, 572);
            btnFour.Margin = new Padding(7, 8, 7, 8);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(104, 85);
            btnFour.TabIndex = 20;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.ActiveCaption;
            btnSubtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(388, 673);
            btnSubtract.Margin = new Padding(7, 8, 7, 8);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(104, 85);
            btnSubtract.TabIndex = 21;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(267, 673);
            btnThree.Margin = new Padding(7, 8, 7, 8);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(104, 85);
            btnThree.TabIndex = 22;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(149, 673);
            btnTwo.Margin = new Padding(7, 8, 7, 8);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(104, 85);
            btnTwo.TabIndex = 23;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(31, 673);
            btnOne.Margin = new Padding(7, 8, 7, 8);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(104, 85);
            btnOne.TabIndex = 24;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightCoral;
            btnEquals.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquals.Location = new Point(505, 671);
            btnEquals.Margin = new Padding(7, 8, 7, 8);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(104, 186);
            btnEquals.TabIndex = 25;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(29, 774);
            btnZero.Margin = new Padding(7, 8, 7, 8);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(223, 85);
            btnZero.TabIndex = 26;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = SystemColors.ActiveCaption;
            btnAddition.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddition.Location = new Point(388, 772);
            btnAddition.Margin = new Padding(7, 8, 7, 8);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(104, 85);
            btnAddition.TabIndex = 27;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.Location = new Point(270, 774);
            btnDecimal.Margin = new Padding(7, 8, 7, 8);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(104, 85);
            btnDecimal.TabIndex = 28;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // txtSecondary
            // 
            txtSecondary.BackColor = SystemColors.Control;
            txtSecondary.BorderStyle = BorderStyle.None;
            txtSecondary.Enabled = false;
            txtSecondary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondary.Location = new Point(31, 67);
            txtSecondary.Name = "txtSecondary";
            txtSecondary.Size = new Size(580, 54);
            txtSecondary.TabIndex = 29;
            txtSecondary.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(644, 914);
            Controls.Add(txtSecondary);
            Controls.Add(btnDecimal);
            Controls.Add(btnAddition);
            Controls.Add(btnZero);
            Controls.Add(btnEquals);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnSubtract);
            Controls.Add(btnFour);
            Controls.Add(btnSix);
            Controls.Add(btnMultiply);
            Controls.Add(btnFraction);
            Controls.Add(btnFive);
            Controls.Add(btnEight);
            Controls.Add(btnDivide);
            Controls.Add(btnPercent);
            Controls.Add(btnNine);
            Controls.Add(btnSeven);
            Controls.Add(btnSqrRoot);
            Controls.Add(btnNegation);
            Controls.Add(btnClrAll);
            Controls.Add(btnClrEntry);
            Controls.Add(btnBckSpc);
            Controls.Add(btnMmryAdd);
            Controls.Add(btnMmrySub);
            Controls.Add(btnMmryStr);
            Controls.Add(btnMmryRcll);
            Controls.Add(btnMmryClr);
            Controls.Add(txtMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
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
    }
}