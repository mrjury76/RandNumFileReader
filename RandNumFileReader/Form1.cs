using System;

namespace RandNumFileReader
{
    public partial class randNumWriter : Form
    {
        public randNumWriter()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private void writeToFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile = File.CreateText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");
            outputFile.WriteLine("Hello");
            outputFile.WriteLine("World");
            outputFile.WriteLine("This is a penis");
            outputFile.Close();
        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = File.OpenText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");
            outputLabel.Text = inputFile.ReadToEnd();
            while (inputFile.EndOfStream == false)
            {
                outputListBox.Items.Add(inputFile.Read());
            }
            inputFile.Close();
        }

        private void generateRandomNumber()
        {
            int randomNumber = random.Next(); // generates a random number
            Console.WriteLine(randomNumber); // prints the random number to the console
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


    }
}
