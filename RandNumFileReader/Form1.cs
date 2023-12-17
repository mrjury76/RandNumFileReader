namespace RandNumFileReader
{
    public partial class randNumWriter : Form
    {
        public randNumWriter()
        {
            InitializeComponent();
        }

        private Random rand = new Random();  // creates a Random object
        
        private int generateRandomNumber()  // generates a random number between 1 and 100
        {
            int randomNumber = rand.Next(1, 101);
            return randomNumber;
        }
        private void writeToFile_Click(object sender, EventArgs e)  // writes the random numbers to a file
        {
            int count; // the number of random numbers to generate

            SaveFileDialog saveFile = new SaveFileDialog();  // creates a SaveFileDialog object
            saveFile.InitialDirectory = @"C:\Users\mrjur\OneDrive\School\Comp2211-C#\RandNumFileReader";  // sets the initial directory
            saveFile.Title = "Save the Random Numbers File"; // sets the title of the dialog box

            if (saveFile.ShowDialog() == DialogResult.OK)  // if the user clicks OK
            {
                StreamWriter outputFile = File.CreateText(saveFile.FileName);  // creates the file

                if (!int.TryParse(inputTextBox.Text, out count))  // checks if the input is an integer
                {
                    MessageBox.Show("Please enter an integer");  // displays an error message
                    outputFile.Close();
                }
                else // if the input is an integer
                {
                    for (int i = 0; i < count; i++)  // writes the random numbers to the file
                    {
                        outputFile.WriteLine(generateRandomNumber());  // writes the random number to the file
                    }
                    outputFile.Close();
                }
            }
            else
            {
                MessageBox.Show("Operation canceled.");  // displays a message if the user clicks cancel
            }
        }

        private void clearListBox_Click(object sender, EventArgs e)  // clears the text box
        {
            inputTextBox.Clear();
        }

        //private void readFromFile_Click(object sender, EventArgs e)  // reads the file and displays the contents
        //{
        //    StreamReader inputFile = File.OpenText(@"C:\\Users\\mrjur\\OneDrive\\School\\Comp2211-C#\\RandNumFileReader\\randNums.txt");
        //    //outputLabel.Text = inputFile.ReadToEnd();  // reads the file
        //    while (!inputFile.EndOfStream)
        //        outputListBox.Items.Add(inputFile.ReadLine());  // adds the contents of the file to the list box
        //    inputFile.Close();  // closes the file
        //}

        //private void listBoxCounter_Click(object sender, EventArgs e)
        //{
        //    listBoxCount.Text = outputListBox.Items.Count.ToString();   // displays the number of items in the list box
        //}

        //private void clearListBox_Click(object sender, EventArgs e)
        //{
        //    outputListBox.Items.Clear();  // clears the list box
        //}
    }
}
