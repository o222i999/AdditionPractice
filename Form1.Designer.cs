namespace AdditionPractice
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.problemTB = new System.Windows.Forms.TextBox();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.correctAnswersTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(257, 75);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // problemTB
            // 
            this.problemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTB.Location = new System.Drawing.Point(39, 35);
            this.problemTB.Name = "problemTB";
            this.problemTB.ReadOnly = true;
            this.problemTB.Size = new System.Drawing.Size(200, 26);
            this.problemTB.TabIndex = 4;
            this.problemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.problemTB.Visible = false;
            // 
            // inputTB
            // 
            this.inputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.Location = new System.Drawing.Point(272, 35);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(47, 26);
            this.inputTB.TabIndex = 5;
            this.inputTB.Visible = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(257, 112);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 6;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // resultTB
            // 
            this.resultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTB.Location = new System.Drawing.Point(39, 75);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.Size = new System.Drawing.Size(200, 26);
            this.resultTB.TabIndex = 7;
            this.resultTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resultTB.Visible = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(144, 70);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // correctAnswersTB
            // 
            this.correctAnswersTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswersTB.Location = new System.Drawing.Point(192, 109);
            this.correctAnswersTB.Name = "correctAnswersTB";
            this.correctAnswersTB.ReadOnly = true;
            this.correctAnswersTB.Size = new System.Drawing.Size(47, 26);
            this.correctAnswersTB.TabIndex = 9;
            this.correctAnswersTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correctAnswersTB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "correct answers:";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctAnswersTB);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.problemTB);
            this.Controls.Add(this.submitBtn);
            this.Name = "Form1";
            this.Text = "addition practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox problemTB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox correctAnswersTB;
        private System.Windows.Forms.Label label1;
    }
}

