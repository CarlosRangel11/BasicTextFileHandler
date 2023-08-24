namespace myFirstForm {
    public partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            FileNameInput = new TextBox();
            FileNameLabel = new Label();
            saveInput = new Button();
            stringInput = new TextBox();
            stringLabel = new Label();
            SuspendLayout();
            // 
            // FileNameInput
            // 
            FileNameInput.Location = new Point(128, 150);
            FileNameInput.Margin = new Padding(6);
            FileNameInput.Name = "FileNameInput";
            FileNameInput.Size = new Size(310, 39);
            FileNameInput.TabIndex = 0;
            // 
            // FileNameLabel
            // 
            FileNameLabel.AutoSize = true;
            FileNameLabel.Location = new Point(128, 100);
            FileNameLabel.Margin = new Padding(6, 0, 6, 0);
            FileNameLabel.Name = "FileNameLabel";
            FileNameLabel.Size = new Size(536, 32);
            FileNameLabel.TabIndex = 1;
            FileNameLabel.Text = "Enter the name of the file you want to write into:";
            // 
            // stringInput
            // 
            stringInput.Location = new Point(128, 250);
            stringInput.Margin = new Padding(6);
            stringInput.Name = "stringInput";
            stringInput.Size = new Size(310, 39);
            stringInput.TabIndex = 3;
            // 
            // stringLabel
            // 
            stringLabel.AutoSize = true;
            stringLabel.Location = new Point(128, 200);
            stringLabel.Margin = new Padding(6, 0, 6, 0);
            stringLabel.Name = "stringLabel";
            stringLabel.Size = new Size(543, 32);
            stringLabel.TabIndex = 4;
            stringLabel.Text = "Enter the name of the file you want to write into: ";
            // 
            // saveInput
            // 
            saveInput.Location = new Point(128, 350);
            saveInput.Margin = new Padding(6);
            saveInput.Name = "saveInput";
            saveInput.Size = new Size(139, 49);
            saveInput.TabIndex = 2;
            saveInput.Text = "Enter";
            saveInput.UseVisualStyleBackColor = true;
            saveInput.Click += saveInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 960);
            Controls.Add(stringLabel);
            Controls.Add(stringInput);
            Controls.Add(saveInput);
            Controls.Add(FileNameLabel);
            Controls.Add(FileNameInput);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Test Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FileNameLabel;
        private TextBox FileNameInput;

        private Label stringLabel;
        private TextBox stringInput;


        private Button saveInput;
    }
}