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
            NameLabel = new Label();
            AgeLabel = new Label();
            GradeLabel = new Label();
            AgeTextBox = new TextBox();
            GradeTextBox = new TextBox();
            NameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            AnswerLabel = new Label();
            TwoNumLabel = new Label();
            OneNumLabel = new Label();
            OneNumTextBox = new TextBox();
            AnswerTextBox = new TextBox();
            TwoNumTextBox = new TextBox();
            groupBox3 = new GroupBox();
            DivideButton = new RadioButton();
            MultiplyButton = new RadioButton();
            SubtractButton = new RadioButton();
            AddButton = new RadioButton();
            groupBox4 = new GroupBox();
            ExitButton = new Button();
            SummaryButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Controls.Add(AgeLabel);
            groupBox1.Controls.Add(GradeLabel);
            groupBox1.Controls.Add(AgeTextBox);
            groupBox1.Controls.Add(GradeTextBox);
            groupBox1.Controls.Add(NameTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(30, 28);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(262, 28);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 3;
            AgeLabel.Text = "Age";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(366, 28);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(49, 20);
            GradeLabel.TabIndex = 3;
            GradeLabel.Text = "Grade";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(262, 50);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(53, 27);
            AgeTextBox.TabIndex = 1;
            AgeTextBox.TextChanged += Text_Changed;
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(364, 50);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(53, 27);
            GradeTextBox.TabIndex = 2;
            GradeTextBox.TextChanged += Text_Changed;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(30, 50);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(169, 27);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += Text_Changed;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AnswerLabel);
            groupBox2.Controls.Add(TwoNumLabel);
            groupBox2.Controls.Add(OneNumLabel);
            groupBox2.Controls.Add(OneNumTextBox);
            groupBox2.Controls.Add(AnswerTextBox);
            groupBox2.Controls.Add(TwoNumTextBox);
            groupBox2.Location = new Point(12, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 306);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Math Problem";
            // 
            // AnswerLabel
            // 
            AnswerLabel.AutoSize = true;
            AnswerLabel.Location = new Point(30, 195);
            AnswerLabel.Name = "AnswerLabel";
            AnswerLabel.Size = new Size(57, 20);
            AnswerLabel.TabIndex = 3;
            AnswerLabel.Text = "Answer";
            // 
            // TwoNumLabel
            // 
            TwoNumLabel.AutoSize = true;
            TwoNumLabel.Location = new Point(30, 140);
            TwoNumLabel.Name = "TwoNumLabel";
            TwoNumLabel.Size = new Size(116, 20);
            TwoNumLabel.TabIndex = 3;
            TwoNumLabel.Text = "Second Number";
            // 
            // OneNumLabel
            // 
            OneNumLabel.AutoSize = true;
            OneNumLabel.Location = new Point(30, 77);
            OneNumLabel.Name = "OneNumLabel";
            OneNumLabel.Size = new Size(94, 20);
            OneNumLabel.TabIndex = 3;
            OneNumLabel.Text = "First Number";
            // 
            // OneNumTextBox
            // 
            OneNumTextBox.Location = new Point(30, 100);
            OneNumTextBox.Name = "OneNumTextBox";
            OneNumTextBox.ReadOnly = true;
            OneNumTextBox.Size = new Size(222, 27);
            OneNumTextBox.TabIndex = 0;
            // 
            // AnswerTextBox
            // 
            AnswerTextBox.Location = new Point(30, 218);
            AnswerTextBox.Name = "AnswerTextBox";
            AnswerTextBox.Size = new Size(222, 27);
            AnswerTextBox.TabIndex = 2;
            // 
            // TwoNumTextBox
            // 
            TwoNumTextBox.Location = new Point(30, 159);
            TwoNumTextBox.Name = "TwoNumTextBox";
            TwoNumTextBox.ReadOnly = true;
            TwoNumTextBox.Size = new Size(222, 27);
            TwoNumTextBox.TabIndex = 1;
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
            DivideButton.CheckedChanged += Button_Changed;
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
            MultiplyButton.CheckedChanged += Button_Changed;
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
            SubtractButton.CheckedChanged += Button_Changed;
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
            AddButton.CheckedChanged += Button_Changed;
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
            // ExitButton
            // 
            ExitButton.Location = new Point(33, 248);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(169, 64);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(33, 178);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(169, 64);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(33, 108);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(169, 64);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(33, 38);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(169, 64);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TextBox AgeTextBox;
        private TextBox GradeTextBox;
        private TextBox NameTextBox;
        private TextBox OneNumTextBox;
        private TextBox AnswerTextBox;
        private TextBox TwoNumTextBox;
        private Label NameLabel;
        private Label AgeLabel;
        private Label GradeLabel;
        private Label AnswerLabel;
        private Label TwoNumLabel;
        private Label OneNumLabel;
    }
}
