namespace super_skaičiuotuvas
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
            this.lblCalculator = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.grpboxAritmetika = new System.Windows.Forms.GroupBox();
            this.rdbDivide1 = new System.Windows.Forms.RadioButton();
            this.rdbPowerY = new System.Windows.Forms.RadioButton();
            this.rdbPercent = new System.Windows.Forms.RadioButton();
            this.rdbCbrt = new System.Windows.Forms.RadioButton();
            this.rdbRtY = new System.Windows.Forms.RadioButton();
            this.rdbPower2 = new System.Windows.Forms.RadioButton();
            this.rdbMultiply = new System.Windows.Forms.RadioButton();
            this.rdbMinus = new System.Windows.Forms.RadioButton();
            this.rdbSqrt = new System.Windows.Forms.RadioButton();
            this.rdbPower3 = new System.Windows.Forms.RadioButton();
            this.rdbDivide = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChoose = new System.Windows.Forms.ToolStripButton();
            this.lblEquation = new System.Windows.Forms.Label();
            this.grpboxAritmetika.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculator
            // 
            this.lblCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(12, 41);
            this.lblCalculator.MinimumSize = new System.Drawing.Size(454, 82);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(494, 132);
            this.lblCalculator.TabIndex = 0;
            this.lblCalculator.Text = "0";
            this.lblCalculator.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 176);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(121, 20);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(12, 202);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(121, 20);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(139, 179);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(79, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Pirmas skaicius";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(139, 205);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(78, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Antras skaicius";
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(6, 19);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(49, 17);
            this.rdbAdd.TabIndex = 5;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "a + b";
            this.rdbAdd.UseVisualStyleBackColor = true;
            this.rdbAdd.CheckedChanged += new System.EventHandler(this.rdbAdd_CheckedChanged);
            // 
            // grpboxAritmetika
            // 
            this.grpboxAritmetika.Controls.Add(this.rdbDivide1);
            this.grpboxAritmetika.Controls.Add(this.rdbPowerY);
            this.grpboxAritmetika.Controls.Add(this.rdbPercent);
            this.grpboxAritmetika.Controls.Add(this.rdbCbrt);
            this.grpboxAritmetika.Controls.Add(this.rdbRtY);
            this.grpboxAritmetika.Controls.Add(this.rdbPower2);
            this.grpboxAritmetika.Controls.Add(this.rdbMultiply);
            this.grpboxAritmetika.Controls.Add(this.rdbMinus);
            this.grpboxAritmetika.Controls.Add(this.rdbSqrt);
            this.grpboxAritmetika.Controls.Add(this.rdbPower3);
            this.grpboxAritmetika.Controls.Add(this.rdbDivide);
            this.grpboxAritmetika.Controls.Add(this.rdbAdd);
            this.grpboxAritmetika.Location = new System.Drawing.Point(307, 179);
            this.grpboxAritmetika.Name = "grpboxAritmetika";
            this.grpboxAritmetika.Size = new System.Drawing.Size(200, 155);
            this.grpboxAritmetika.TabIndex = 6;
            this.grpboxAritmetika.TabStop = false;
            this.grpboxAritmetika.Text = "Paprastoji aritmetika";
            // 
            // rdbDivide1
            // 
            this.rdbDivide1.AutoSize = true;
            this.rdbDivide1.Location = new System.Drawing.Point(6, 132);
            this.rdbDivide1.Name = "rdbDivide1";
            this.rdbDivide1.Size = new System.Drawing.Size(41, 17);
            this.rdbDivide1.TabIndex = 13;
            this.rdbDivide1.TabStop = true;
            this.rdbDivide1.Text = "1/x";
            this.rdbDivide1.UseVisualStyleBackColor = true;
            this.rdbDivide1.CheckedChanged += new System.EventHandler(this.rdbDivide1_CheckedChanged);
            // 
            // rdbPowerY
            // 
            this.rdbPowerY.AutoSize = true;
            this.rdbPowerY.Location = new System.Drawing.Point(6, 88);
            this.rdbPowerY.Name = "rdbPowerY";
            this.rdbPowerY.Size = new System.Drawing.Size(52, 17);
            this.rdbPowerY.TabIndex = 13;
            this.rdbPowerY.TabStop = true;
            this.rdbPowerY.Text = "x **  y";
            this.rdbPowerY.UseVisualStyleBackColor = true;
            this.rdbPowerY.CheckedChanged += new System.EventHandler(this.rdbPowerY_CheckedChanged);
            // 
            // rdbPercent
            // 
            this.rdbPercent.AutoSize = true;
            this.rdbPercent.Location = new System.Drawing.Point(97, 132);
            this.rdbPercent.Name = "rdbPercent";
            this.rdbPercent.Size = new System.Drawing.Size(33, 17);
            this.rdbPercent.TabIndex = 14;
            this.rdbPercent.TabStop = true;
            this.rdbPercent.Text = "%";
            this.rdbPercent.UseVisualStyleBackColor = true;
            this.rdbPercent.CheckedChanged += new System.EventHandler(this.rdbPercent_CheckedChanged);
            // 
            // rdbCbrt
            // 
            this.rdbCbrt.AutoSize = true;
            this.rdbCbrt.Location = new System.Drawing.Point(6, 111);
            this.rdbCbrt.Name = "rdbCbrt";
            this.rdbCbrt.Size = new System.Drawing.Size(52, 17);
            this.rdbCbrt.TabIndex = 11;
            this.rdbCbrt.TabStop = true;
            this.rdbCbrt.Text = "x // 3";
            this.rdbCbrt.UseVisualStyleBackColor = true;
            this.rdbCbrt.CheckedChanged += new System.EventHandler(this.rdbCbrt_CheckedChanged);
            // 
            // rdbRtY
            // 
            this.rdbRtY.AutoSize = true;
            this.rdbRtY.Location = new System.Drawing.Point(97, 111);
            this.rdbRtY.Name = "rdbRtY";
            this.rdbRtY.Size = new System.Drawing.Size(51, 17);
            this.rdbRtY.TabIndex = 12;
            this.rdbRtY.TabStop = true;
            this.rdbRtY.Text = "x // y";
            this.rdbRtY.UseVisualStyleBackColor = true;
            // 
            // rdbPower2
            // 
            this.rdbPower2.AutoSize = true;
            this.rdbPower2.Location = new System.Drawing.Point(6, 65);
            this.rdbPower2.Name = "rdbPower2";
            this.rdbPower2.Size = new System.Drawing.Size(50, 17);
            this.rdbPower2.TabIndex = 8;
            this.rdbPower2.TabStop = true;
            this.rdbPower2.Text = "x ** 2";
            this.rdbPower2.UseVisualStyleBackColor = true;
            this.rdbPower2.CheckedChanged += new System.EventHandler(this.rdbPower2_CheckedChanged);
            // 
            // rdbMultiply
            // 
            this.rdbMultiply.AutoSize = true;
            this.rdbMultiply.Location = new System.Drawing.Point(6, 42);
            this.rdbMultiply.Name = "rdbMultiply";
            this.rdbMultiply.Size = new System.Drawing.Size(47, 17);
            this.rdbMultiply.TabIndex = 8;
            this.rdbMultiply.TabStop = true;
            this.rdbMultiply.Text = "a * b";
            this.rdbMultiply.UseVisualStyleBackColor = true;
            this.rdbMultiply.CheckedChanged += new System.EventHandler(this.rdbMultiply_CheckedChanged);
            // 
            // rdbMinus
            // 
            this.rdbMinus.AutoSize = true;
            this.rdbMinus.Location = new System.Drawing.Point(97, 19);
            this.rdbMinus.Name = "rdbMinus";
            this.rdbMinus.Size = new System.Drawing.Size(46, 17);
            this.rdbMinus.TabIndex = 6;
            this.rdbMinus.TabStop = true;
            this.rdbMinus.Text = "a - b";
            this.rdbMinus.UseVisualStyleBackColor = true;
            this.rdbMinus.CheckedChanged += new System.EventHandler(this.rdbMinus_CheckedChanged);
            // 
            // rdbSqrt
            // 
            this.rdbSqrt.AutoSize = true;
            this.rdbSqrt.Location = new System.Drawing.Point(97, 88);
            this.rdbSqrt.Name = "rdbSqrt";
            this.rdbSqrt.Size = new System.Drawing.Size(52, 17);
            this.rdbSqrt.TabIndex = 14;
            this.rdbSqrt.TabStop = true;
            this.rdbSqrt.Text = "x // 2";
            this.rdbSqrt.UseVisualStyleBackColor = true;
            this.rdbSqrt.CheckedChanged += new System.EventHandler(this.rdbSqrt_CheckedChanged);
            // 
            // rdbPower3
            // 
            this.rdbPower3.AutoSize = true;
            this.rdbPower3.Location = new System.Drawing.Point(97, 65);
            this.rdbPower3.Name = "rdbPower3";
            this.rdbPower3.Size = new System.Drawing.Size(50, 17);
            this.rdbPower3.TabIndex = 7;
            this.rdbPower3.TabStop = true;
            this.rdbPower3.Text = "x ** 3";
            this.rdbPower3.UseVisualStyleBackColor = true;
            this.rdbPower3.CheckedChanged += new System.EventHandler(this.rdbPower3_CheckedChanged);
            // 
            // rdbDivide
            // 
            this.rdbDivide.AutoSize = true;
            this.rdbDivide.Location = new System.Drawing.Point(97, 40);
            this.rdbDivide.Name = "rdbDivide";
            this.rdbDivide.Size = new System.Drawing.Size(48, 17);
            this.rdbDivide.TabIndex = 7;
            this.rdbDivide.TabStop = true;
            this.rdbDivide.Text = "a / b";
            this.rdbDivide.UseVisualStyleBackColor = true;
            this.rdbDivide.CheckedChanged += new System.EventHandler(this.rdbDivide_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(226, 205);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(226, 234);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 49);
            this.btnEquals.TabIndex = 9;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChoose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(518, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChoose
            // 
            this.tsbChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChoose.Name = "tsbChoose";
            this.tsbChoose.Size = new System.Drawing.Size(119, 22);
            this.tsbChoose.Text = "Kitokie skaiciuotuvai";
            this.tsbChoose.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // lblEquation
            // 
            this.lblEquation.Location = new System.Drawing.Point(24, 47);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(476, 62);
            this.lblEquation.TabIndex = 12;
            this.lblEquation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 549);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpboxAritmetika);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblCalculator);
            this.MinimumSize = new System.Drawing.Size(494, 588);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxAritmetika.ResumeLayout(false);
            this.grpboxAritmetika.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.GroupBox grpboxAritmetika;
        private System.Windows.Forms.RadioButton rdbMinus;
        private System.Windows.Forms.RadioButton rdbPowerY;
        private System.Windows.Forms.RadioButton rdbCbrt;
        private System.Windows.Forms.RadioButton rdbRtY;
        private System.Windows.Forms.RadioButton rdbPower2;
        private System.Windows.Forms.RadioButton rdbMultiply;
        private System.Windows.Forms.RadioButton rdbSqrt;
        private System.Windows.Forms.RadioButton rdbPower3;
        private System.Windows.Forms.RadioButton rdbDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RadioButton rdbDivide1;
        private System.Windows.Forms.RadioButton rdbPercent;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChoose;
        private System.Windows.Forms.Label lblEquation;
    }
}

