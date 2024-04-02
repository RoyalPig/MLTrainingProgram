namespace Assignment3OOPMMRIGHTONE
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
            FeedbackTextBox = new TextBox();
            FeedbackLabel = new Label();
            PredictButton = new Button();
            GuessLabel = new Label();
            RetrainComboBox = new ComboBox();
            ReTrainButton = new Button();
            ConfidenceLabel = new Label();
            GuessNumLabel = new Label();
            ConfidenceNumLabel = new Label();
            SuspendLayout();
            // 
            // FeedbackTextBox
            // 
            FeedbackTextBox.Location = new Point(310, 84);
            FeedbackTextBox.Name = "FeedbackTextBox";
            FeedbackTextBox.Size = new Size(299, 35);
            FeedbackTextBox.TabIndex = 0;
            // 
            // FeedbackLabel
            // 
            FeedbackLabel.AutoSize = true;
            FeedbackLabel.Location = new Point(177, 89);
            FeedbackLabel.Name = "FeedbackLabel";
            FeedbackLabel.Size = new Size(105, 30);
            FeedbackLabel.TabIndex = 2;
            FeedbackLabel.Text = "Feedback:";
            // 
            // PredictButton
            // 
            PredictButton.Location = new Point(227, 148);
            PredictButton.Name = "PredictButton";
            PredictButton.Size = new Size(131, 40);
            PredictButton.TabIndex = 3;
            PredictButton.Text = "Predict";
            PredictButton.UseVisualStyleBackColor = true;
            PredictButton.Click += PredictButton_Click;
            // 
            // GuessLabel
            // 
            GuessLabel.AutoSize = true;
            GuessLabel.Location = new Point(499, 156);
            GuessLabel.Name = "GuessLabel";
            GuessLabel.Size = new Size(73, 30);
            GuessLabel.TabIndex = 4;
            GuessLabel.Text = "Guess:";
            // 
            // RetrainComboBox
            // 
            RetrainComboBox.FlatStyle = FlatStyle.System;
            RetrainComboBox.FormattingEnabled = true;
            RetrainComboBox.Items.AddRange(new object[] { "0", "1" });
            RetrainComboBox.Location = new Point(208, 205);
            RetrainComboBox.Name = "RetrainComboBox";
            RetrainComboBox.Size = new Size(212, 38);
            RetrainComboBox.TabIndex = 5;
            // 
            // ReTrainButton
            // 
            ReTrainButton.Location = new Point(245, 266);
            ReTrainButton.Name = "ReTrainButton";
            ReTrainButton.Size = new Size(131, 40);
            ReTrainButton.TabIndex = 6;
            ReTrainButton.Text = "Re-Train";
            ReTrainButton.UseVisualStyleBackColor = true;
            ReTrainButton.Click += ReTrainButton_Click;
            // 
            // ConfidenceLabel
            // 
            ConfidenceLabel.AutoSize = true;
            ConfidenceLabel.Location = new Point(502, 195);
            ConfidenceLabel.Name = "ConfidenceLabel";
            ConfidenceLabel.Size = new Size(123, 30);
            ConfidenceLabel.TabIndex = 8;
            ConfidenceLabel.Text = "Confidence:";
            ConfidenceLabel.Click += label1_Click;
            // 
            // GuessNumLabel
            // 
            GuessNumLabel.AutoSize = true;
            GuessNumLabel.Location = new Point(579, 161);
            GuessNumLabel.Name = "GuessNumLabel";
            GuessNumLabel.Size = new Size(57, 30);
            GuessNumLabel.TabIndex = 9;
            GuessNumLabel.Text = "label";
            GuessNumLabel.Click += GuessNumLabel_Click;
            // 
            // ConfidenceNumLabel
            // 
            ConfidenceNumLabel.AutoSize = true;
            ConfidenceNumLabel.Location = new Point(631, 195);
            ConfidenceNumLabel.Name = "ConfidenceNumLabel";
            ConfidenceNumLabel.Size = new Size(57, 30);
            ConfidenceNumLabel.TabIndex = 10;
            ConfidenceNumLabel.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfidenceNumLabel);
            Controls.Add(GuessNumLabel);
            Controls.Add(ConfidenceLabel);
            Controls.Add(ReTrainButton);
            Controls.Add(RetrainComboBox);
            Controls.Add(GuessLabel);
            Controls.Add(PredictButton);
            Controls.Add(FeedbackLabel);
            Controls.Add(FeedbackTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FeedbackTextBox;
        private Label FeedbackLabel;
        private Button PredictButton;
        private Label GuessLabel;
        private ComboBox RetrainComboBox;
        private Button ReTrainButton;
        private Label ConfidenceLabel;
        private Label GuessNumLabel;
        private Label ConfidenceNumLabel;
    }
}