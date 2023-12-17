namespace RandNumFileWriter
{
    partial class randNumWriter
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
            writeToFile = new Button();
            inputTextBox = new TextBox();
            inputPrompt = new Label();
            clearListBox = new Button();
            SuspendLayout();
            // 
            // writeToFile
            // 
            writeToFile.Location = new Point(203, 147);
            writeToFile.Name = "writeToFile";
            writeToFile.Size = new Size(175, 66);
            writeToFile.TabIndex = 0;
            writeToFile.Text = "Write To File";
            writeToFile.UseVisualStyleBackColor = true;
            writeToFile.Click += writeToFile_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(203, 78);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(175, 35);
            inputTextBox.TabIndex = 5;
            // 
            // inputPrompt
            // 
            inputPrompt.AutoSize = true;
            inputPrompt.Location = new Point(12, 25);
            inputPrompt.Name = "inputPrompt";
            inputPrompt.Size = new Size(546, 30);
            inputPrompt.TabIndex = 6;
            inputPrompt.Text = "Please enter how many random numbers the file will hold";
            // 
            // clearListBox
            // 
            clearListBox.Location = new Point(238, 240);
            clearListBox.Name = "clearListBox";
            clearListBox.Size = new Size(110, 39);
            clearListBox.TabIndex = 9;
            clearListBox.Text = "Clear";
            clearListBox.UseVisualStyleBackColor = true;
            clearListBox.Click += clearListBox_Click;
            // 
            // randNumWriter
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 310);
            Controls.Add(clearListBox);
            Controls.Add(inputPrompt);
            Controls.Add(inputTextBox);
            Controls.Add(writeToFile);
            Name = "randNumWriter";
            Text = "Random Number Writer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button writeToFile;
        private TextBox inputTextBox;
        private Label inputPrompt;
        private Button clearListBox;
    }
}
