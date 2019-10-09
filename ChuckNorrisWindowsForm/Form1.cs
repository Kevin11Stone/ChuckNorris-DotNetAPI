using System;
using ChuckNorrisAPI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategoriesList();
        }

        /// <summary>
        /// Displays messageBox with random joke supplied by
        /// ChuckNorrisClientClasses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRandomJoke_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show($"{j.JokeText}");
        }

        /// <summary>
        /// Populates comboBox with categories supplied 
        /// by ChuckNorrisClientClasses
        /// </summary>
        private async void PopulateCategoriesList()
        {
            IEnumerable<string> categoryString = await ChuckNorrisClient.GetCategories();
            foreach (var s in categoryString)
            {
                cmbxCategories.Items.Add(s);
            }
        }
    }
}
