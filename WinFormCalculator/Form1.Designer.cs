namespace WinFormCalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPluseOrMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnDeu = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.lblEnterUser = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPluseOrMinus, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPoint, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDeu, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCe, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(100, 263);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(91, 61);
            this.btnZero.TabIndex = 19;
            this.btnZero.TabStop = false;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPluseOrMinus
            // 
            this.btnPluseOrMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPluseOrMinus.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnPluseOrMinus.Location = new System.Drawing.Point(3, 263);
            this.btnPluseOrMinus.Name = "btnPluseOrMinus";
            this.btnPluseOrMinus.Size = new System.Drawing.Size(91, 61);
            this.btnPluseOrMinus.TabIndex = 18;
            this.btnPluseOrMinus.TabStop = false;
            this.btnPluseOrMinus.Text = "+\r\n";
            this.btnPluseOrMinus.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(294, 263);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(91, 61);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.Enter += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.Location = new System.Drawing.Point(197, 263);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(91, 61);
            this.btnPoint.TabIndex = 16;
            this.btnPoint.TabStop = false;
            this.btnPoint.Text = ".";
            this.btnPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(294, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 59);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThree.Location = new System.Drawing.Point(197, 198);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(91, 59);
            this.btnThree.TabIndex = 14;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.Location = new System.Drawing.Point(100, 198);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(91, 59);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(3, 198);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(91, 59);
            this.btnOne.TabIndex = 12;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnDeu
            // 
            this.btnDeu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeu.Location = new System.Drawing.Point(294, 133);
            this.btnDeu.Name = "btnDeu";
            this.btnDeu.Size = new System.Drawing.Size(91, 59);
            this.btnDeu.TabIndex = 11;
            this.btnDeu.TabStop = false;
            this.btnDeu.Text = "__";
            this.btnDeu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeu.UseVisualStyleBackColor = false;
            this.btnDeu.Click += new System.EventHandler(this.btnDeu_Click);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSix.Location = new System.Drawing.Point(197, 133);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(91, 59);
            this.btnSix.TabIndex = 10;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFive.Location = new System.Drawing.Point(100, 133);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(91, 59);
            this.btnFive.TabIndex = 9;
            this.btnFive.TabStop = false;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFour.Location = new System.Drawing.Point(3, 133);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(91, 59);
            this.btnFour.TabIndex = 8;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnMult
            // 
            this.btnMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(294, 68);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(91, 59);
            this.btnMult.TabIndex = 7;
            this.btnMult.TabStop = false;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNine.Location = new System.Drawing.Point(197, 68);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(91, 59);
            this.btnNine.TabIndex = 6;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEight.Location = new System.Drawing.Point(100, 68);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(91, 59);
            this.btnEight.TabIndex = 5;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.Location = new System.Drawing.Point(3, 68);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(91, 59);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(294, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(91, 59);
            this.btnDiv.TabIndex = 3;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(197, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 59);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(100, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(91, 59);
            this.btnC.TabIndex = 1;
            this.btnC.TabStop = false;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCe
            // 
            this.btnCe.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCe.Location = new System.Drawing.Point(3, 3);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(91, 59);
            this.btnCe.TabIndex = 0;
            this.btnCe.TabStop = false;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = false;
            this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(25, 51);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(382, 27);
            this.txtEquation.TabIndex = 1;
            // 
            // lblEnterUser
            // 
            this.lblEnterUser.AutoSize = true;
            this.lblEnterUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterUser.Location = new System.Drawing.Point(12, 9);
            this.lblEnterUser.Name = "lblEnterUser";
            this.lblEnterUser.Size = new System.Drawing.Size(404, 28);
            this.lblEnterUser.TabIndex = 2;
            this.lblEnterUser.Text = "Please enter equation and press enter or =";
            this.lblEnterUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 490);
            this.Controls.Add(this.lblEnterUser);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnDeu;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMult;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnDiv;
        private Button btnDelete;
        private Button btnC;
        private Button btnCe;
        private Button btnZero;
        private Button btnPluseOrMinus;
        private Button btnEqual;
        private Button btnPoint;
        private TextBox txtEquation;
        private Label lblEnterUser;
    }
}