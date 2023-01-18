using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_NikitaBoborenko
{
    public partial class Form1 : Form
    {
        int random_number;
        int number_of_guesses;
        public Form1()
        {
            InitializeComponent();
        }
        public int generate_random_number()
        { 
            Random rnd = new Random();
            int random_number = rnd.Next(0, 101);
            return random_number;
        }

        public void start_new_game()
        {
            number_of_guesses = 0;
            random_number = generate_random_number();
            guesses_label.Text = "Number of guesses: " + Convert.ToString(number_of_guesses);
        }
        public void failed_attempt()
        {
            number_of_guesses++;
            guesses_label.Text = "Number of guesses: " + Convert.ToString(number_of_guesses);
        }
        private void guess_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(inputTextBox.Text) == random_number)
                {
                    MessageBox.Show("You guessed number "+ Convert.ToString(random_number) +" in "+ Convert.ToString(number_of_guesses) + " attempts");
                    start_new_game();
                }
                else if (Convert.ToInt32(inputTextBox.Text) < random_number)
                {
                    failed_attempt();
                    MessageBox.Show("Guess is less than random number");
                }
                else if (Convert.ToInt32(inputTextBox.Text) > random_number)
                {
                    failed_attempt();
                    MessageBox.Show("Guess is more than random number");
                }
                
            }
            catch
            {
                MessageBox.Show("Input is empty");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number_of_guesses = 0;
            random_number=generate_random_number();
            guesses_label.Text= "Number of guesses: "+Convert.ToString(number_of_guesses);

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numbers can be entered");
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
            }
        }

        private void guesses_label_Click(object sender, EventArgs e)
        {

        }
    }
}
