using System.IO;
using System;
using System.Windows.Forms;

namespace RandNumFileReader
{
    public partial class randNumWriter : Form
    {
        public randNumWriter() 
        {
            InitializeComponent();
        }

        // global variables
        private Random rand = new Random();
        
        
        private int generateRandomNumber()
        {
            int randomNumber = rand.Next(1, 101); // generates a random number
            return randomNumber;
        }
        private void writeToFile_Click(object sender, EventArgs e)  // writes the random numbers to the file
        {
            StreamWriter outputFile = File.CreateText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");
            int count; // the number of random numbers to generate
            if (!int.TryParse(inputTextBox.Text, out count))  // if the input is not an integer
            {
                MessageBox.Show("Please enter an integer");
            }
            else // if the input is an integer
            {
                for (int i = 0; i < count; i++)  // generates the random numbers
                {
                    outputFile.WriteLine(generateRandomNumber());  // writes the random numbers to the file
                }
                outputFile.Close();  // closes the file
            }
        }

        private void readFromFile_Click(object sender, EventArgs e)  // reads the file and displays the contents
        {
            StreamReader inputFile = File.OpenText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");
            outputLabel.Text = inputFile.ReadToEnd();  // reads the file
            while (inputFile.EndOfStream == false)  // while the file has not reached the end
            {
                outputListBox.Items.Add(inputFile.Read());  // adds the contents of the file to the list box
            }
            inputFile.Close();  // closes the file
        }
    }
}
