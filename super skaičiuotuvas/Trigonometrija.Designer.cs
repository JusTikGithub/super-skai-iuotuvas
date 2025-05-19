namespace super_skaičiuotuvas
{
    partial class Trigonometrija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCos = new System.Windows.Forms.RadioButton();
            this.rbPrism = new System.Windows.Forms.RadioButton();
            this.rbAngle = new System.Windows.Forms.RadioButton();
            this.rbLength = new System.Windows.Forms.RadioButton();
            this.rbTan = new System.Windows.Forms.RadioButton();
            this.rbPiramid = new System.Windows.Forms.RadioButton();
            this.rbSin = new System.Windows.Forms.RadioButton();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbChoose = new System.Windows.Forms.ToolStripButton();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCos);
            this.groupBox1.Controls.Add(this.rbPrism);
            this.groupBox1.Controls.Add(this.rbAngle);
            this.groupBox1.Controls.Add(this.rbLength);
            this.groupBox1.Controls.Add(this.rbTan);
            this.groupBox1.Controls.Add(this.rbPiramid);
            this.groupBox1.Controls.Add(this.rbSin);
            this.groupBox1.Location = new System.Drawing.Point(452, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 278);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figūros";
            // 
            // rbCos
            // 
            this.rbCos.AutoSize = true;
            this.rbCos.Location = new System.Drawing.Point(18, 50);
            this.rbCos.Name = "rbCos";
            this.rbCos.Size = new System.Drawing.Size(43, 17);
            this.rbCos.TabIndex = 6;
            this.rbCos.TabStop = true;
            this.rbCos.Text = "Cos";
            this.rbCos.UseVisualStyleBackColor = true;
            this.rbCos.CheckedChanged += new System.EventHandler(this.rbCos_CheckedChanged);
            // 
            // rbPrism
            // 
            this.rbPrism.AutoSize = true;
            this.rbPrism.Location = new System.Drawing.Point(18, 142);
            this.rbPrism.Name = "rbPrism";
            this.rbPrism.Size = new System.Drawing.Size(56, 17);
            this.rbPrism.TabIndex = 5;
            this.rbPrism.TabStop = true;
            this.rbPrism.Text = "Prizmė";
            this.rbPrism.UseVisualStyleBackColor = true;
            this.rbPrism.Visible = false;
            // 
            // rbAngle
            // 
            this.rbAngle.AutoSize = true;
            this.rbAngle.Location = new System.Drawing.Point(18, 119);
            this.rbAngle.Name = "rbAngle";
            this.rbAngle.Size = new System.Drawing.Size(100, 17);
            this.rbAngle.TabIndex = 4;
            this.rbAngle.TabStop = true;
            this.rbAngle.Text = "Kampo didumas";
            this.rbAngle.UseVisualStyleBackColor = true;
            this.rbAngle.CheckedChanged += new System.EventHandler(this.rbAngle_CheckedChanged);
            // 
            // rbLength
            // 
            this.rbLength.AutoSize = true;
            this.rbLength.Location = new System.Drawing.Point(18, 96);
            this.rbLength.Name = "rbLength";
            this.rbLength.Size = new System.Drawing.Size(88, 17);
            this.rbLength.TabIndex = 3;
            this.rbLength.TabStop = true;
            this.rbLength.Text = "Kraštinės ilgis";
            this.rbLength.UseVisualStyleBackColor = true;
            this.rbLength.CheckedChanged += new System.EventHandler(this.rbLength_CheckedChanged);
            // 
            // rbTan
            // 
            this.rbTan.AutoSize = true;
            this.rbTan.Location = new System.Drawing.Point(18, 73);
            this.rbTan.Name = "rbTan";
            this.rbTan.Size = new System.Drawing.Size(44, 17);
            this.rbTan.TabIndex = 2;
            this.rbTan.TabStop = true;
            this.rbTan.Text = "Tan";
            this.rbTan.UseVisualStyleBackColor = true;
            this.rbTan.CheckedChanged += new System.EventHandler(this.rbTan_CheckedChanged);
            // 
            // rbPiramid
            // 
            this.rbPiramid.AutoSize = true;
            this.rbPiramid.Location = new System.Drawing.Point(18, 165);
            this.rbPiramid.Name = "rbPiramid";
            this.rbPiramid.Size = new System.Drawing.Size(65, 17);
            this.rbPiramid.TabIndex = 1;
            this.rbPiramid.TabStop = true;
            this.rbPiramid.Text = "Piramidė";
            this.rbPiramid.UseVisualStyleBackColor = true;
            this.rbPiramid.Visible = false;
            // 
            // rbSin
            // 
            this.rbSin.AutoSize = true;
            this.rbSin.Location = new System.Drawing.Point(18, 27);
            this.rbSin.Name = "rbSin";
            this.rbSin.Size = new System.Drawing.Size(40, 17);
            this.rbSin.TabIndex = 0;
            this.rbSin.TabStop = true;
            this.rbSin.Text = "Sin";
            this.rbSin.UseVisualStyleBackColor = true;
            this.rbSin.CheckedChanged += new System.EventHandler(this.rbSin_CheckedChanged);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(334, 224);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 49);
            this.btnEquals.TabIndex = 81;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 169);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 79;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(334, 195);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 80;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(139, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(78, 13);
            this.lbl2.TabIndex = 78;
            this.lbl2.Text = "Antras skaicius";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(139, 169);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(79, 13);
            this.lbl1.TabIndex = 77;
            this.lbl1.Text = "Pirmas skaicius";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(12, 192);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(121, 20);
            this.txtNum2.TabIndex = 76;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 166);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(121, 20);
            this.txtNum1.TabIndex = 75;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCalculator
            // 
            this.lblCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.lblCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(12, 31);
            this.lblCalculator.MinimumSize = new System.Drawing.Size(454, 82);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(616, 128);
            this.lblCalculator.TabIndex = 74;
            this.lblCalculator.Text = "0";
            this.lblCalculator.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChoose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 73;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbChoose
            // 
            this.tsbChoose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChoose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChoose.Name = "tsbChoose";
            this.tsbChoose.Size = new System.Drawing.Size(39, 22);
            this.tsbChoose.Text = "Atgal";
            this.tsbChoose.Click += new System.EventHandler(this.tsbChoose_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(139, 221);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(83, 13);
            this.lbl3.TabIndex = 92;
            this.lbl3.Text = "Trečias skaičius";
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(12, 218);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(121, 20);
            this.txtNum3.TabIndex = 91;
            this.txtNum3.Text = "0";
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(235, 308);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 60);
            this.btn3.TabIndex = 95;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(139, 308);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 60);
            this.btn2.TabIndex = 94;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(43, 308);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 60);
            this.btn1.TabIndex = 93;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(331, 308);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 60);
            this.btn4.TabIndex = 96;
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(186, 374);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 60);
            this.btn5.TabIndex = 97;
            this.btn5.Text = "button5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // Trigonometrija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblCalculator);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Trigonometrija";
            this.Text = "Trigonometrija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCos;
        private System.Windows.Forms.RadioButton rbPrism;
        private System.Windows.Forms.RadioButton rbAngle;
        private System.Windows.Forms.RadioButton rbLength;
        private System.Windows.Forms.RadioButton rbTan;
        private System.Windows.Forms.RadioButton rbPiramid;
        private System.Windows.Forms.RadioButton rbSin;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblCalculator;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbChoose;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
    }
}