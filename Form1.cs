using System;
using System.Windows.Forms;
using System.IO;

namespace GUI_READ_WRITE_DATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetCountriesSA_Click(object sender, EventArgs e)
        {
            // EXAMPLE #1 *****************************************************
            try
            {
                string country;
                StreamReader myInputFile;
                // Rememeber, if no path is indicated the files are saved in the bin/debug/
                myInputFile = File.OpenText("Countries.txt");

                // Clear Listbox
                LBoxCountries.Items.Clear();

                // Read file content and add to listbox
                while (!myInputFile.EndOfStream)
                {
                    // Read from file
                    country = myInputFile.ReadLine();

                    // Add to listbox
                    LBoxCountries.Items.Add(country);
                }

                // Don't forget to close the file
                myInputFile.Close();


            } catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // EXAMPLE #2 *****************************************************
        private void BtnAddToList_Click(object sender, EventArgs e)
        {
            LBoxData.Items.Add(TxtData.Text);
            TxtData.Clear();
            TxtData.Focus();
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter myOutputFile;
                //Rememeber, if no path is indicated the files are saved in the bin/debug/
                myOutputFile = File.CreateText("Data.txt");

                foreach (string s in LBoxData.Items)
                {
                    myOutputFile.WriteLine(s);
                }

                myOutputFile.Close();
                MessageBox.Show("Data saved to file");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // EXAMPLE #3  *****************************************************
        private void BtnLoadToDoList_Click(object sender, EventArgs e)
        {
            // Edit the following path according to your environment
            openFileDialog1.InitialDirectory = "C:\\Users\\Jose\\Desktop\\App_Data";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process File (Similar to Example 1)
                try
                {
                    string toDoItem;
                    StreamReader myInputFile;
                    myInputFile = File.OpenText(openFileDialog1.FileName);

                    // Clear Listbox
                    LBoxToDoList.Items.Clear();

                    // Read file content and add to listbox
                    while (!myInputFile.EndOfStream)
                    {
                        // Read from file
                        toDoItem = myInputFile.ReadLine();

                        // Add to listbox
                        LBoxToDoList.Items.Add(toDoItem);
                    }

                    // Don't forget to close the file
                    myInputFile.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }
        }

        private void BtnSaveToDoList_Click(object sender, EventArgs e)
        {
            // Edit the following path according to your environment
            saveFileDialog1.InitialDirectory = "C:\\Users\\Jose\\Desktop\\App_Data";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process File (Similar to Example 1)
                try
                {

                    StreamWriter myOutputFile;
                    myOutputFile = File.CreateText(saveFileDialog1.FileName);

                    foreach (string s in LBoxToDoList.Items)
                    {
                        myOutputFile.WriteLine(s);
                    }

                    myOutputFile.Close();

                    MessageBox.Show("To-Do List saved to file");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operation Canceled");
            }
        }

        private void BtnAddItemToList_Click(object sender, EventArgs e)
        {
            LBoxToDoList.Items.Add(TxtToDoItem.Text);
            TxtToDoItem.Clear();
            TxtToDoItem.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = LBoxToDoList.SelectedIndex;
            LBoxToDoList.Items.RemoveAt(selectedItemIndex);
        }
    }
}
