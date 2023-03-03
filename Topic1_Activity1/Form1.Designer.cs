namespace Topic1_Activity1
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
            buttonLabel = new Label();
            clickHereButton = new Button();
            surpriseLabel = new Label();
            SuspendLayout();
            // 
            // buttonLabel
            // 
            buttonLabel.AutoSize = true;
            buttonLabel.Location = new Point(171, 41);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(159, 20);
            buttonLabel.TabIndex = 0;
            buttonLabel.Text = "Press to reveal surprise";
            // 
            // clickHereButton
            // 
            clickHereButton.Location = new Point(196, 75);
            clickHereButton.Name = "clickHereButton";
            clickHereButton.Size = new Size(94, 29);
            clickHereButton.TabIndex = 1;
            clickHereButton.Text = "Click here";
            clickHereButton.UseVisualStyleBackColor = true;
            clickHereButton.Click += clickHereButton_Click;
            // 
            // surpriseLabel
            // 
            surpriseLabel.BorderStyle = BorderStyle.FixedSingle;
            surpriseLabel.Location = new Point(185, 127);
            surpriseLabel.Name = "surpriseLabel";
            surpriseLabel.Size = new Size(120, 25);
            surpriseLabel.TabIndex = 2;
            surpriseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 245);
            Controls.Add(surpriseLabel);
            Controls.Add(clickHereButton);
            Controls.Add(buttonLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buttonLabel;
        private Button clickHereButton;
        private Label surpriseLabel;
    }
}