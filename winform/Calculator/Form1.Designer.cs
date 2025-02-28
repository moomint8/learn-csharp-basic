namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnAllClear = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(299, 44);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BtnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnPlus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnPoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSeven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 287);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnFour.Location = new System.Drawing.Point(3, 74);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(67, 65);
            this.BtnFour.TabIndex = 16;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnPlus.Location = new System.Drawing.Point(222, 216);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(67, 65);
            this.BtnPlus.TabIndex = 15;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnPoint.Location = new System.Drawing.Point(149, 216);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(67, 65);
            this.BtnPoint.TabIndex = 14;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnZero.Location = new System.Drawing.Point(76, 216);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(67, 65);
            this.BtnZero.TabIndex = 13;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnAllClear
            // 
            this.BtnAllClear.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnAllClear.Location = new System.Drawing.Point(3, 216);
            this.BtnAllClear.Name = "BtnAllClear";
            this.BtnAllClear.Size = new System.Drawing.Size(67, 65);
            this.BtnAllClear.TabIndex = 12;
            this.BtnAllClear.Text = "AC";
            this.BtnAllClear.UseVisualStyleBackColor = true;
            this.BtnAllClear.Click += new System.EventHandler(this.BtnAllClear_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnSubtract.Location = new System.Drawing.Point(222, 145);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(67, 65);
            this.BtnSubtract.TabIndex = 11;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnThree.Location = new System.Drawing.Point(149, 145);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(67, 65);
            this.BtnThree.TabIndex = 10;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnTwo.Location = new System.Drawing.Point(76, 145);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(67, 65);
            this.BtnTwo.TabIndex = 9;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnOne.Location = new System.Drawing.Point(3, 145);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(67, 65);
            this.BtnOne.TabIndex = 8;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnMultiply.Location = new System.Drawing.Point(222, 74);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(67, 65);
            this.BtnMultiply.TabIndex = 7;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnSix.Location = new System.Drawing.Point(149, 74);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(67, 65);
            this.BtnSix.TabIndex = 6;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnFive.Location = new System.Drawing.Point(76, 74);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(67, 65);
            this.BtnFive.TabIndex = 5;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnDivide.Location = new System.Drawing.Point(222, 3);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(67, 65);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnNine.Location = new System.Drawing.Point(149, 3);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(67, 65);
            this.BtnNine.TabIndex = 2;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnEight.Location = new System.Drawing.Point(76, 3);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(67, 65);
            this.BtnEight.TabIndex = 1;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnSeven.Location = new System.Drawing.Point(3, 3);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(67, 65);
            this.BtnSeven.TabIndex = 0;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.BtnResult.Location = new System.Drawing.Point(5, 334);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(294, 47);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 386);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnAllClear;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnResult;
    }
}

