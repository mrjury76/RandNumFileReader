namespace RandNumFileReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randNumWriter));
            writeToFile = new Button();
            assignmentDescription = new PictureBox();
            readFromFile = new Button();
            outputLabel = new Label();
            outputListBox = new ListBox();
            inputTextBox = new TextBox();
            inputPrompt = new Label();
            ((System.ComponentModel.ISupportInitialize)assignmentDescription).BeginInit();
            SuspendLayout();
            // 
            // writeToFile
            // 
            writeToFile.Location = new Point(528, 601);
            writeToFile.Name = "writeToFile";
            writeToFile.Size = new Size(172, 66);
            writeToFile.TabIndex = 0;
            writeToFile.Text = "Write To File";
            writeToFile.UseVisualStyleBackColor = true;
            writeToFile.Click += writeToFile_Click;
            // 
            // assignmentDescription
            // 
            assignmentDescription.Image = (Image)resources.GetObject("assignmentDescription.Image");
            assignmentDescription.Location = new Point(36, 12);
            assignmentDescription.Name = "assignmentDescription";
            assignmentDescription.Size = new Size(925, 444);
            assignmentDescription.SizeMode = PictureBoxSizeMode.AutoSize;
            assignmentDescription.TabIndex = 1;
            assignmentDescription.TabStop = false;
            // 
            // readFromFile
            // 
            readFromFile.Location = new Point(944, 601);
            readFromFile.Name = "readFromFile";
            readFromFile.Size = new Size(172, 66);
            readFromFile.TabIndex = 2;
            readFromFile.Text = "Read From File";
            readFromFile.UseVisualStyleBackColor = true;
            readFromFile.Click += readFromFile_Click;
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(301, 673);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(203, 193);
            outputLabel.TabIndex = 3;
            // 
            // outputListBox
            // 
            outputListBox.FormattingEnabled = true;
            outputListBox.ItemHeight = 30;
            outputListBox.Location = new Point(21, 577);
            outputListBox.Name = "outputListBox";
            outputListBox.Size = new Size(228, 244);
            outputListBox.TabIndex = 4;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(528, 537);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(175, 35);
            inputTextBox.TabIndex = 5;
            // 
            // inputPrompt
            // 
            inputPrompt.AutoSize = true;
            inputPrompt.Location = new Point(351, 483);
            inputPrompt.Name = "inputPrompt";
            inputPrompt.Size = new Size(546, 30);
            inputPrompt.TabIndex = 6;
            inputPrompt.Text = "Please enter how many random numbers the file will hold";
            // 
            // randNumWriter
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 913);
            Controls.Add(inputPrompt);
            Controls.Add(inputTextBox);
            Controls.Add(outputListBox);
            Controls.Add(outputLabel);
            Controls.Add(readFromFile);
            Controls.Add(assignmentDescription);
            Controls.Add(writeToFile);
            Name = "randNumWriter";
            Text = "Random Number Writer";
            ((System.ComponentModel.ISupportInitialize)assignmentDescription).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button writeToFile;
        private PictureBox assignmentDescription;
        private Button readFromFile;
        private Label outputLabel;
        private ListBox outputListBox;
        private TextBox inputTextBox;
        private Label inputPrompt;
    }
}
