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
        int count; // the number of random numbers to generate


        private int generateRandomNumber()
        {
            int randomNumber = rand.Next(1, 101); // generates a random number between 1 and 100
            return randomNumber;
        }
        private void writeToFile_Click(object sender, EventArgs e)  // writes the random numbers to the file
        {
            StreamWriter outputFile = File.CreateText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");

            if (!int.TryParse(inputTextBox.Text, out count))  // if the input is not an integer
            {
                MessageBox.Show("Please enter an integer");
                outputFile.Close();  // closes the file
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
            //outputLabel.Text = inputFile.ReadToEnd();  // reads the file
            while (!inputFile.EndOfStream)
                outputListBox.Items.Add(inputFile.ReadLine());  // adds the contents of the file to the list box
            inputFile.Close();  // closes the file
        }

        private void testListBox_Click(object sender, EventArgs e)
        {
            listBoxCount.Text = outputListBox.Items.Count.ToString();   // displays the number of items in the list box
        }

        private void clearListBox_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();  // clears the list box
        }
    }
}
