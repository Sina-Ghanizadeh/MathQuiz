
namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.LeftPlus = new System.Windows.Forms.Label();
            this.rightPlus = new System.Windows.Forms.Label();
            this.leftMinus = new System.Windows.Forms.Label();
            this.rightMinus = new System.Windows.Forms.Label();
            this.leftMultiple = new System.Windows.Forms.Label();
            this.rightMultiple = new System.Windows.Forms.Label();
            this.leftDiv = new System.Windows.Forms.Label();
            this.rightDiv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minus = new System.Windows.Forms.NumericUpDown();
            this.multiple = new System.Windows.Forms.NumericUpDown();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sumLabel = new System.Windows.Forms.Label();
            this.divLabel = new System.Windows.Forms.Label();
            this.multilabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left";
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(302, 17);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(211, 53);
            this.timeLabel.TabIndex = 1;
            // 
            // LeftPlus
            // 
            this.LeftPlus.AutoSize = true;
            this.LeftPlus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftPlus.Location = new System.Drawing.Point(79, 112);
            this.LeftPlus.Name = "LeftPlus";
            this.LeftPlus.Size = new System.Drawing.Size(35, 46);
            this.LeftPlus.TabIndex = 2;
            this.LeftPlus.Text = "?";
            // 
            // rightPlus
            // 
            this.rightPlus.AutoSize = true;
            this.rightPlus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightPlus.Location = new System.Drawing.Point(289, 109);
            this.rightPlus.Name = "rightPlus";
            this.rightPlus.Size = new System.Drawing.Size(35, 46);
            this.rightPlus.TabIndex = 3;
            this.rightPlus.Text = "?";
            // 
            // leftMinus
            // 
            this.leftMinus.AutoSize = true;
            this.leftMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftMinus.Location = new System.Drawing.Point(79, 201);
            this.leftMinus.Name = "leftMinus";
            this.leftMinus.Size = new System.Drawing.Size(35, 46);
            this.leftMinus.TabIndex = 4;
            this.leftMinus.Text = "?";
            // 
            // rightMinus
            // 
            this.rightMinus.AutoSize = true;
            this.rightMinus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightMinus.Location = new System.Drawing.Point(289, 200);
            this.rightMinus.Name = "rightMinus";
            this.rightMinus.Size = new System.Drawing.Size(35, 46);
            this.rightMinus.TabIndex = 5;
            this.rightMinus.Text = "?";
            // 
            // leftMultiple
            // 
            this.leftMultiple.AutoSize = true;
            this.leftMultiple.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftMultiple.Location = new System.Drawing.Point(79, 293);
            this.leftMultiple.Name = "leftMultiple";
            this.leftMultiple.Size = new System.Drawing.Size(35, 46);
            this.leftMultiple.TabIndex = 6;
            this.leftMultiple.Text = "?";
            // 
            // rightMultiple
            // 
            this.rightMultiple.AutoSize = true;
            this.rightMultiple.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightMultiple.Location = new System.Drawing.Point(289, 294);
            this.rightMultiple.Name = "rightMultiple";
            this.rightMultiple.Size = new System.Drawing.Size(35, 46);
            this.rightMultiple.TabIndex = 7;
            this.rightMultiple.Text = "?";
            // 
            // leftDiv
            // 
            this.leftDiv.AutoSize = true;
            this.leftDiv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftDiv.Location = new System.Drawing.Point(79, 397);
            this.leftDiv.Name = "leftDiv";
            this.leftDiv.Size = new System.Drawing.Size(35, 46);
            this.leftDiv.TabIndex = 8;
            this.leftDiv.Text = "?";
            // 
            // rightDiv
            // 
            this.rightDiv.AutoSize = true;
            this.rightDiv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightDiv.Location = new System.Drawing.Point(289, 391);
            this.rightDiv.Name = "rightDiv";
            this.rightDiv.Size = new System.Drawing.Size(35, 46);
            this.rightDiv.TabIndex = 9;
            this.rightDiv.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(165, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 46);
            this.label11.TabIndex = 10;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(167, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 46);
            this.label12.TabIndex = 11;
            this.label12.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(167, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 46);
            this.label14.TabIndex = 12;
            this.label14.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(165, 397);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 46);
            this.label15.TabIndex = 13;
            this.label15.Text = "÷";
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(750, 477);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(94, 29);
            this.btnEnd.TabIndex = 17;
            this.btnEnd.Text = "EndGame";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(750, 430);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "StartGame";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(441, 128);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(54, 27);
            this.sum.TabIndex = 19;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(441, 219);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(54, 27);
            this.minus.TabIndex = 20;
            // 
            // multiple
            // 
            this.multiple.Location = new System.Drawing.Point(441, 312);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(54, 27);
            this.multiple.TabIndex = 21;
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(441, 410);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(54, 27);
            this.div.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(355, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 46);
            this.label13.TabIndex = 12;
            this.label13.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 46);
            this.label2.TabIndex = 23;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(355, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 46);
            this.label3.TabIndex = 24;
            this.label3.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(355, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 46);
            this.label16.TabIndex = 25;
            this.label16.Text = "=";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumLabel.Location = new System.Drawing.Point(544, 112);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 46);
            this.sumLabel.TabIndex = 26;
            // 
            // divLabel
            // 
            this.divLabel.AutoSize = true;
            this.divLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divLabel.Location = new System.Drawing.Point(544, 391);
            this.divLabel.Name = "divLabel";
            this.divLabel.Size = new System.Drawing.Size(0, 46);
            this.divLabel.TabIndex = 27;
            // 
            // multilabel
            // 
            this.multilabel.AutoSize = true;
            this.multilabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multilabel.Location = new System.Drawing.Point(544, 303);
            this.multilabel.Name = "multilabel";
            this.multilabel.Size = new System.Drawing.Size(0, 46);
            this.multilabel.TabIndex = 28;
            // 
            // minusLabel
            // 
            this.minusLabel.AutoSize = true;
            this.minusLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusLabel.Location = new System.Drawing.Point(544, 219);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(0, 46);
            this.minusLabel.TabIndex = 29;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(837, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 46);
            this.lblScore.TabIndex = 30;
            this.lblScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(560, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 46);
            this.label4.TabIndex = 31;
            this.label4.Text = "Correct Answer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(887, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.multilabel);
            this.Controls.Add(this.divLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rightDiv);
            this.Controls.Add(this.leftDiv);
            this.Controls.Add(this.rightMultiple);
            this.Controls.Add(this.leftMultiple);
            this.Controls.Add(this.rightMinus);
            this.Controls.Add(this.leftMinus);
            this.Controls.Add(this.rightPlus);
            this.Controls.Add(this.LeftPlus);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label LeftPlus;
        private System.Windows.Forms.Label rightPlus;
        private System.Windows.Forms.Label leftMinus;
        private System.Windows.Forms.Label rightMinus;
        private System.Windows.Forms.Label leftMultiple;
        private System.Windows.Forms.Label rightMultiple;
        private System.Windows.Forms.Label leftDiv;
        private System.Windows.Forms.Label rightDiv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown minus;
        private System.Windows.Forms.NumericUpDown multiple;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label divLabel;
        private System.Windows.Forms.Label multilabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
    }
}

