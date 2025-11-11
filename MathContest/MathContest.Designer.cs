namespace MathContest
{
    partial class MathContest
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            SubmitButton = new Button();
            ClearButton = new Button();
            SummaryButton = new Button();
            ExitButton = new Button();
            AddButton = new RadioButton();
            SubtractButton = new RadioButton();
            MultiplyButton = new RadioButton();
            DivideButton = new RadioButton();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 306);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Math Problem";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DivideButton);
            groupBox3.Controls.Add(MultiplyButton);
            groupBox3.Controls.Add(SubtractButton);
            groupBox3.Controls.Add(AddButton);
            groupBox3.Location = new Point(323, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(218, 306);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Math Problem Type";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ExitButton);
            groupBox4.Controls.Add(SummaryButton);
            groupBox4.Controls.Add(ClearButton);
            groupBox4.Controls.Add(SubmitButton);
            groupBox4.Location = new Point(552, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(226, 400);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(33, 38);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(169, 64);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(33, 108);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(169, 64);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(33, 178);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(169, 64);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(33, 248);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(169, 64);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.Location = new Point(6, 40);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(58, 24);
            AddButton.TabIndex = 0;
            AddButton.TabStop = true;
            AddButton.Text = "&Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // SubtractButton
            // 
            SubtractButton.AutoSize = true;
            SubtractButton.Location = new Point(6, 70);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(85, 24);
            SubtractButton.TabIndex = 1;
            SubtractButton.TabStop = true;
            SubtractButton.Text = "S&ubtract";
            SubtractButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyButton
            // 
            MultiplyButton.AutoSize = true;
            MultiplyButton.Location = new Point(6, 100);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(84, 24);
            MultiplyButton.TabIndex = 2;
            MultiplyButton.TabStop = true;
            MultiplyButton.Text = "&Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            // 
            // DivideButton
            // 
            DivideButton.AutoSize = true;
            DivideButton.Location = new Point(6, 130);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(73, 24);
            DivideButton.TabIndex = 3;
            DivideButton.TabStop = true;
            DivideButton.Text = "&Divide";
            DivideButton.UseVisualStyleBackColor = true;
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MathContest";
            Text = "Math Contest";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button ClearButton;
        private Button SubmitButton;
        private Button ExitButton;
        private Button SummaryButton;
        private RadioButton DivideButton;
        private RadioButton MultiplyButton;
        private RadioButton SubtractButton;
        private RadioButton AddButton;
    }
}
