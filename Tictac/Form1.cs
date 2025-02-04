using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Final_
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }




        int turn = 1;

        int[,] Box = new int[3, 3];

        int score1 = 0;
        int score2 = 0;


        private void Button1_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            {
                button1.Text = "X";

                Box[0, 0] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;

            }

            else
            {
                button1.Text = "O";

                Box[0, 0] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;

            }
            getScore();

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button11.Text = "X";

                Box[0, 1] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button11.Text = "O";

                Box[0, 1] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;

            }
            getScore();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button10.Text = "X";

                Box[0, 2] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button10.Text = "O";

                Box[0, 2] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }

            getScore();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button9.Text = "X";

                Box[1, 0] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button9.Text = "O";

                Box[1, 0] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }

            getScore();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button8.Text = "X";

                Box[1, 1] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button8.Text = "O";

                Box[1, 1] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }
            getScore();

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button7.Text = "X";

                Box[1, 2] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button7.Text = "O";

                Box[1, 2] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }
            getScore();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button6.Text = "X";

                Box[2, 0] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button6.Text = "O";

                Box[2, 0] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }
            getScore();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button5.Text = "X";

                Box[2, 1] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button5.Text = "O";

                Box[2, 1] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;
            }
            getScore();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button4.Text = "X";

                Box[2, 2] = 1;

                label3.Text = "Player 2[O]";

                turn = 0;
            }

            else
            {
                button4.Text = "O";

                Box[2, 2] = 0;

                label3.Text = "Player 1[X]";

                turn = 1;

            }
            getScore();
        }


        private void getScore()
        {

            if (Box[0, 0] == 1 && Box[0, 1] == 1 && Box[0, 2] == 1 || Box[0, 0] == 1 && Box[1, 0] == 1 && Box[2, 0] == 1 || Box[1, 0] == 1 && Box[1, 1] == 1 && Box[1, 2] == 1

                || Box[2, 0] == 1 && Box[2, 1] == 1 && Box[2, 2] == 1 || Box[0, 1] == 1 && Box[1, 1] == 1 && Box[2, 1] == 1 || Box[0, 2] == 1 && Box[1, 2] == 1 && Box[2, 2] == 1

                || Box[0, 0] == 1 && Box[1, 1] == 1 && Box[2, 2] == 1 || Box[0, 2] == 1 && Box[1, 1] == 1 && Box[2, 0] == 1)
            {
                button1.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;

                score1++;

                string s1 = score1.ToString();

                textBox4.Text = s1;

                MessageBox.Show("Player 1 Wins");


                button1.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;

            }
                
            
            else if
                (button1.Text=="O" && button11.Text == "O" && button10.Text == "O" ||
                 button9.Text == "O" && button8.Text == "O" && button7.Text == "O" ||
                 button6.Text == "O" && button5.Text == "O" && button4.Text == "O" ||
                 button1.Text == "O" && button9.Text == "O" && button6.Text == "O" ||
                 button11.Text == "O" && button8.Text == "O" && button5.Text == "O" ||
                 button10.Text == "O" && button7.Text == "O" && button4.Text == "O"||
                 button1.Text == "O" && button8.Text == "O" && button4.Text == "O" ||
                 button6.Text == "O" && button8.Text == "O" && button10.Text == "O"
                )


            {
                
                button1.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                score2++;

                string s2 = score2.ToString();

                textBox5.Text = s2;  
                
                MessageBox.Show("Player 2 Wins");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playAgain();
            
        }

        private void playAgain() 
        {
            
            button1.Text= " ";
            button4.Text= " ";
            button5.Text= " ";
            button6.Text= " ";
            button7.Text= " ";
            button8.Text= " ";
            button9.Text= " ";
            button10.Text= " ";
            button11.Text= " ";
            
            Box[0, 0] = 0;
            Box[0, 1] = 0;
            Box[0, 2] = 0;
            Box[1, 0] = 0;
            Box[1, 1] = 0;
            Box[1, 2] = 0;
            Box[2, 0] = 0;
            Box[2, 1] = 0;
            Box[2, 2] = 0;

            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            playAgain();
            score1 = 0;
            score2 = 0;
           string s1 = score1.ToString();

           textBox4.Text = s1;


           string s2 = score2.ToString();

            textBox5.Text = s2;

        }
    }
}
