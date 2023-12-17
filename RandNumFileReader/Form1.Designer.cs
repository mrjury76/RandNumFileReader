using System.IO;

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
            ((System.ComponentModel.ISupportInitialize)assignmentDescription).BeginInit();
            SuspendLayout();
            // 
            // writeToFile
            // 
            writeToFile.Location = new Point(273, 671);
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
            assignmentDescription.Location = new Point(191, 111);
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
            outputLabel.Location = new Point(570, 673);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(203, 193);
            outputLabel.TabIndex = 3;
            outputLabel.Click += outputLabel_Click;
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
            // randNumWriter
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 913);
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
    }
}
