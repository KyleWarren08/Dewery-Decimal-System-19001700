using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewery_Decimal_System_19001700
{
    public partial class Replaceing_Books : Form
    {
        public Replaceing_Books()
        {
            InitializeComponent();
            Populate_Buttons();
            storeUseButtons();
        }

        //------------------------------------ORDER BOOK GAME CODE------------------------------------------------------------------------------------------//

        //List<Tuple<decimal, string>> numberList = new List<Tuple<decimal, string>>();
        List<Books> bookList = new List<Books>();

        List<string> userList = new List<string>();
        List<string> sortedUserList = new List<string>();

        //This array can be used to test aphabetical soring.
        //double[] testArray = { 9.7, 9.7, 9.7, 9.7, 9.7, 9.7, 9.7, 9.7, 9.7, 9.7, 9.7 };

        string[] arrayAuth = new string[10];
        decimal[] arrayNumbers = new decimal[10];

        int expTotal = 0;
        int expBar = 0;
        int levelAdd = 0;
        int level = 0;

        int coin = 0;

        private bool swap;
        Books temp;

        string zeroPlace2 = "00";
        string zeroPlace1 = "0";

        public void Populate_Buttons()
        {            

            Random randomNumbers = new Random();
            Random randomLetters = new Random();

            int length = 3;
            decimal numbers;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                //Picks a random number from 0 to 1000 including numbers with up to 2 decimal places.
                //Decimal places can be increased as needed.
                //numbers = (decimal)randomNumbers.Next(100_000) / 100m; This line can be altered to give desired decimal places for demonstration purposes im using 3 decimal places.
                numbers = (decimal)randomNumbers.Next(100_0000) / 1000m;
                arrayNumbers[i] = numbers;

                //Pick 3 random letters from the alphabet and adds it to the arrayAuth array
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                arrayAuth[i] = new string(Enumerable.Repeat(chars, length).Select(s => s[randomLetters.Next(s.Length)]).ToArray());

                //numberList.Add(Tuple.Create(arrayNumbers[i], arrayAuth[i]));
                bookList.Add(new Books(arrayNumbers[i], arrayAuth[i]));
               
                //list is sorted in asscending order numerically and alphabetically
                //numberList.Sort();
                /*bookList.Sort(delegate(Books x, Books y){
                    return x.Number.CompareTo(y.Number);
                });*/
            }
            //sorting algorithim used to sort the call numbers.
            for (int i = 0; i < bookList.Count; i++)
            {
                for (int j = 0; j < bookList.Count - 1; j++)
                {
                    int book1int = (int)bookList[j].GetNumber();    
                    int book2int = (int)bookList[j + 1].GetNumber();      

                    if (book1int > book2int)
                    {
                        swap = true;
                    }
                    else if (book1int == book2int)
                    {
                        decimal book1Decimal = bookList[j].GetNumber() - book1int;         
                        decimal book2Decimal = bookList[j + 1].GetNumber() - book2int;     
                        
                        if (book1Decimal > book2Decimal)
                        {
                            swap = true;
                        }
                    }
                    else
                    {
                        swap = false;
                    }

                    if (swap == true)
                    {
                        temp = bookList[j];
                        bookList[j] = bookList[j + 1];
                        bookList[j + 1] = temp;                        
                    }                   
                }
            }


            for (int i = 0; i < bookList.Count; i++)
            {
                string sortedUserListAdd = bookList[i].ToString();
                //richTextBox1.Text = richTextBox1.Text + "\n" + bookList[i].ToString(); 
                sortedUserList.Add(sortedUserListAdd);
            }

                richTextBox1.Lines = sortedUserList.ToArray();

            //Making use of the arrays to ensure that the buttons are always random.           
            //--------------------------------------------Button 1--------------------------------------------
            if (arrayNumbers[0] <= 9)
            {
                btn1.Text = zeroPlace2 + arrayNumbers[0].ToString() + "\n " + arrayAuth[0].ToString();
            }
            else if (arrayNumbers[0] <= 99)
            {
                btn1.Text = zeroPlace1 + arrayNumbers[0].ToString() + "\n " + arrayAuth[0].ToString();
            }
            else if (arrayNumbers[0] <= 999)
            {
                btn1.Text = arrayNumbers[0].ToString() + "\n " + arrayAuth[0].ToString();
            }
            //--------------------------------------------Button 2--------------------------------------------
            if (arrayNumbers[1] <= 9)
            {
                btn2.Text = zeroPlace2 + arrayNumbers[1].ToString() + "\n " + arrayAuth[1].ToString();
            }
            else if (arrayNumbers[1] <= 99)
            {
                btn2.Text = zeroPlace1 + arrayNumbers[1].ToString() + "\n " + arrayAuth[1].ToString();
            }
            else if (arrayNumbers[1] <= 999)
            {
                btn2.Text = arrayNumbers[1].ToString() + "\n " + arrayAuth[1].ToString();
            }
            //--------------------------------------------Button 3--------------------------------------------
            if (arrayNumbers[2] <= 9)
            {
                btn3.Text = zeroPlace2 + arrayNumbers[2].ToString() + "\n " + arrayAuth[2].ToString();
            }
            else if (arrayNumbers[2] <= 99)
            {
                btn3.Text = zeroPlace1 + arrayNumbers[2].ToString() + "\n " + arrayAuth[2].ToString();
            }
            else if (arrayNumbers[2] <= 999)
            {
                btn3.Text = arrayNumbers[2].ToString() + "\n " + arrayAuth[2].ToString();
            }
            //--------------------------------------------Button 4--------------------------------------------
            if (arrayNumbers[3] <= 9)
            {
                btn4.Text = zeroPlace2 + arrayNumbers[3].ToString() + "\n " + arrayAuth[3].ToString();
            }
            else if (arrayNumbers[3] <= 99)
            {
                btn4.Text = zeroPlace1 + arrayNumbers[3].ToString() + "\n " + arrayAuth[3].ToString();
            }
            else if (arrayNumbers[3] <= 999)
            {
                btn4.Text = arrayNumbers[3].ToString() + "\n " + arrayAuth[3].ToString();
            }
            //--------------------------------------------Button 5--------------------------------------------
            if (arrayNumbers[4] <= 9)
            {
                btn5.Text = zeroPlace2 + arrayNumbers[4].ToString() + "\n " + arrayAuth[4].ToString();
            }
            else if (arrayNumbers[4] <= 99)
            {
                btn5.Text = zeroPlace1 + arrayNumbers[4].ToString() + "\n " + arrayAuth[4].ToString();
            }
            else if (arrayNumbers[4] <= 999)
            {
                btn5.Text = arrayNumbers[4].ToString() + "\n " + arrayAuth[4].ToString();
            }
            //--------------------------------------------Button 6--------------------------------------------
            if (arrayNumbers[5] <= 9)
            {
                btn6.Text = zeroPlace2 + arrayNumbers[5].ToString() + "\n " + arrayAuth[5].ToString();
            }
            else if (arrayNumbers[5] <= 99)
            {
                btn6.Text = zeroPlace1 + arrayNumbers[5].ToString() + "\n " + arrayAuth[5].ToString();
            }
            else if (arrayNumbers[5] <= 999)
            {
                btn6.Text = arrayNumbers[5].ToString() + "\n " + arrayAuth[5].ToString();
            }
            //--------------------------------------------Button 7--------------------------------------------
            if (arrayNumbers[6] <= 9)
            {
                btn7.Text = zeroPlace2 + arrayNumbers[6].ToString() + "\n " + arrayAuth[6].ToString();
            }
            else if (arrayNumbers[6] <= 99)
            {
                btn7.Text = zeroPlace1 + arrayNumbers[6].ToString() + "\n " + arrayAuth[6].ToString();
            }
            else if (arrayNumbers[6] <= 999)
            {
                btn7.Text = arrayNumbers[6].ToString() + "\n " + arrayAuth[6].ToString();
            }
            //--------------------------------------------Button 8--------------------------------------------
            if (arrayNumbers[7] <= 9)
            {
                btn8.Text = zeroPlace2 + arrayNumbers[7].ToString() + "\n " + arrayAuth[7].ToString();
            }
            else if (arrayNumbers[7] <= 99)
            {
                btn8.Text = zeroPlace1 + arrayNumbers[7].ToString() + "\n " + arrayAuth[7].ToString();
            }
            else if (arrayNumbers[7] <= 999)
            {
                btn8.Text = arrayNumbers[7].ToString() + "\n " + arrayAuth[7].ToString();
            }
            //--------------------------------------------Button 9--------------------------------------------
            if (arrayNumbers[8] <= 9)
            {
                btn9.Text = zeroPlace2 + arrayNumbers[8].ToString() + "\n " + arrayAuth[8].ToString();
            }
            else if (arrayNumbers[8] <= 99)
            {
                btn9.Text = zeroPlace1 + arrayNumbers[8].ToString() + "\n " + arrayAuth[8].ToString();
            }
            else if (arrayNumbers[8] <= 999)
            {
                btn9.Text = arrayNumbers[8].ToString() + "\n " + arrayAuth[8].ToString();
            }
            //--------------------------------------------Button 10--------------------------------------------
            if (arrayNumbers[9] <= 9)
            {
                btn10.Text = zeroPlace2 + arrayNumbers[9].ToString() + "\n " + arrayAuth[9].ToString();
            }
            else if (arrayNumbers[9] <= 99)
            {
                btn10.Text = zeroPlace1 + arrayNumbers[9].ToString() + "\n " + arrayAuth[9].ToString();
            }
            else if (arrayNumbers[9] <= 999)
            {
                btn10.Text = arrayNumbers[9].ToString() + "\n " + arrayAuth[9].ToString();
            }

        }

      
        //This method enbles buttons when a user would like to reatry or coninue to the next question.
        public void ResetButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
        }

        public void disableAwards()
        {

        }
        //----------------------------------------------------10 buttons to interact with------------------------------------
        private void btn1_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[0] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[0].ToString() + " " + arrayAuth[0].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[0].ToString() + "\n" + arrayAuth[0].ToString();
            }
            else if (arrayNumbers[1] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[0].ToString() + " " + arrayAuth[0].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[0].ToString() + "\n" + arrayAuth[0].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[0].ToString() + " " + arrayAuth[0].ToString();
                spineAdd = arrayNumbers[0].ToString() + "\n" + arrayAuth[0].ToString();
            }
            
            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[1] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[1].ToString() + " " + arrayAuth[1].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[1].ToString() + "\n" + arrayAuth[1].ToString();
            }
            else if (arrayNumbers[1] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[1].ToString() + " " + arrayAuth[1].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[1].ToString() + "\n" + arrayAuth[1].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[1].ToString() + " " + arrayAuth[1].ToString();
                spineAdd = arrayNumbers[1].ToString() + "\n" + arrayAuth[1].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[2] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[2].ToString() + " " + arrayAuth[2].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[2].ToString() + "\n" + arrayAuth[2].ToString();
            }
            else if (arrayNumbers[2] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[2].ToString() + " " + arrayAuth[2].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[2].ToString() + "\n" + arrayAuth[2].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[2].ToString() + " " + arrayAuth[2].ToString();
                spineAdd = arrayNumbers[2].ToString() + "\n" + arrayAuth[2].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[3] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[3].ToString() + " " + arrayAuth[3].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[3].ToString() + "\n" + arrayAuth[3].ToString();
            }
            else if (arrayNumbers[3] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[3].ToString() + " " + arrayAuth[3].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[3].ToString() + "\n" + arrayAuth[3].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[3].ToString() + " " + arrayAuth[3].ToString();
                spineAdd = arrayNumbers[3].ToString() + "\n" + arrayAuth[3].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[4] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[4].ToString() + " " + arrayAuth[4].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[4].ToString() + "\n" + arrayAuth[4].ToString();
            }
            else if (arrayNumbers[4] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[4].ToString() + " " + arrayAuth[4].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[4].ToString() + "\n" + arrayAuth[4].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[4].ToString() + " " + arrayAuth[4].ToString();
                spineAdd = arrayNumbers[4].ToString() + "\n" + arrayAuth[4].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[5] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[5].ToString() + " " + arrayAuth[5].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[5].ToString() + "\n" + arrayAuth[5].ToString();
            }
            else if (arrayNumbers[5] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[5].ToString() + " " + arrayAuth[5].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[5].ToString() + "\n" + arrayAuth[5].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[5].ToString() + " " + arrayAuth[5].ToString();
                spineAdd = arrayNumbers[5].ToString() + "\n" + arrayAuth[5].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[6] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[6].ToString() + " " + arrayAuth[6].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[6].ToString() + "\n" + arrayAuth[6].ToString();
            }
            else if (arrayNumbers[6] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[6].ToString() + " " + arrayAuth[6].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[6].ToString() + "\n" + arrayAuth[6].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[6].ToString() + " " + arrayAuth[6].ToString();
                spineAdd = arrayNumbers[6].ToString() + "\n" + arrayAuth[6].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[7] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[7].ToString() + " " + arrayAuth[7].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[7].ToString() + "\n" + arrayAuth[7].ToString();
            }
            else if (arrayNumbers[7] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[7].ToString() + " " + arrayAuth[7].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[7].ToString() + "\n" + arrayAuth[7].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[7].ToString() + " " + arrayAuth[7].ToString();
                spineAdd = arrayNumbers[7].ToString() + "\n" + arrayAuth[7].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[8] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[8].ToString() + " " + arrayAuth[8].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[8].ToString() + "\n" + arrayAuth[8].ToString();
            }
            else if (arrayNumbers[8] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[8].ToString() + " " + arrayAuth[8].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[8].ToString() + "\n" + arrayAuth[8].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[8].ToString() + " " + arrayAuth[8].ToString();
                spineAdd = arrayNumbers[8].ToString() + "\n" + arrayAuth[8].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn9.Enabled = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string userListAdd = string.Empty;
            string spineAdd = string.Empty;

            if (arrayNumbers[9] <= 9)
            {
                userListAdd = zeroPlace2 + arrayNumbers[9].ToString() + " " + arrayAuth[9].ToString();
                spineAdd = zeroPlace2 + arrayNumbers[9].ToString() + "\n" + arrayAuth[9].ToString();
            }
            else if (arrayNumbers[9] <= 99)
            {
                userListAdd = zeroPlace1 + arrayNumbers[9].ToString() + " " + arrayAuth[9].ToString();
                spineAdd = zeroPlace1 + arrayNumbers[9].ToString() + "\n" + arrayAuth[9].ToString();
            }
            else
            {
                userListAdd = arrayNumbers[9].ToString() + " " + arrayAuth[9].ToString();
                spineAdd = arrayNumbers[9].ToString() + "\n" + arrayAuth[9].ToString();
            }

            pickRichTextBox(spineAdd);

            richTextBox2.Text = richTextBox2.Text + "\n" + userListAdd;
            userList.Add(userListAdd);

            btn10.Enabled = false;
        }

        //---------------------------------------------------------------------------------------------------------

        //----------------------------------------Adding call numbers to book spines-------------------------------
        public void pickRichTextBox(string spineAdd)
        {
            if (rtxtSpine1.Text == "")
            {
                rtxtSpine1.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine1.Text = spineAdd;
            }
            else if (rtxtSpine2.Text == "")
            {
                rtxtSpine2.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine2.Text = spineAdd;
            }
            else if (rtxtSpine3.Text == "")
            {
                rtxtSpine3.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine3.Text = spineAdd;
            }
            else if (rtxtSpine4.Text == "")
            {
                rtxtSpine4.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine4.Text = spineAdd;
            }
            else if (rtxtSpine5.Text == "")
            {
                rtxtSpine5.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine5.Text = spineAdd;
            }
            else if (rtxtSpine6.Text == "")
            {
                rtxtSpine6.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine6.Text = spineAdd;
            }
            else if (rtxtSpine7.Text == "")
            {
                rtxtSpine7.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine7.Text = spineAdd;
            }
            else if (rtxtSpine8.Text == "")
            {
                rtxtSpine8.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine8.Text = spineAdd;
            }
            else if (rtxtSpine9.Text == "")
            {
                rtxtSpine9.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine9.Text = spineAdd;
            }
            else if (rtxtSpine10.Text == "")
            {
                rtxtSpine10.SelectionAlignment = HorizontalAlignment.Center;
                rtxtSpine10.Text = spineAdd;
            }
        }
        //-------------------------------------------------------------------------------------------------

        //Clear text boxes that are on the book spines
        public void clearTextBoxes()
        {
            rtxtSpine1.Clear();
            rtxtSpine2.Clear();
            rtxtSpine3.Clear();
            rtxtSpine4.Clear();
            rtxtSpine5.Clear();
            rtxtSpine6.Clear();
            rtxtSpine7.Clear();
            rtxtSpine8.Clear();
            rtxtSpine9.Clear();
            rtxtSpine10.Clear();
        }

        //Submit btton
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (userList.SequenceEqual(sortedUserList))
            {
                MessageBox.Show("Your answer is correct");
            }
            else
            {
                MessageBox.Show("Your answer is incorrect");
            }

            richTextBox1.Visible = false;           
        }

        //Retry the same question
        private void btnReatry_Click(object sender, EventArgs e)
        {
            userList.Clear();
            clearTextBoxes();
            ResetButtons();

            richTextBox2.Clear();
            richTextBox1.Visible = false;
        }

        //Generate a new question to answer
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            Array.Clear(arrayNumbers, 0, arrayNumbers.Length);
            Array.Clear(arrayAuth, 0, arrayAuth.Length);
            
            //numberList.Clear();
            bookList.Clear();           
            clearTextBoxes();
                      
            ResetButtons();
            
                                 
            if (userList.SequenceEqual(sortedUserList))
            {
                expTotal = expTotal + 200;
                expBar = expBar + 200;
                coin = coin + 100;

                lbCoinAmount.Text = coin.ToString();
                lbCoinAmountStore.Text = coin.ToString();

                this.timer.Start();

                if (expBar > 1000)
                {
                    expBar = 200;

                    levelAdd = (expTotal % 1000) / 200;

                    level = level + levelAdd;

                    lbLevel.Text = "Level " + level.ToString();
                }

                progExperience.Value = expBar / 10;
                lbExpNextLevel.Text = expBar.ToString() + "/" + "1000";

                if (expTotal == 3200)
                {
                    MessageBox.Show("Congratulations you have just earned the BRONZE award.");
                    lbNoAwards.Visible = false;
                    pbBronze.Visible = true;
                    lbBronze.Visible = true;
                }
                if (expTotal == 6200)
                {
                    MessageBox.Show("Congratulations you have just earned the SILVER award.");
                    lbNoAwards.Visible = false;
                    pbSilver.Visible = true;
                    lbSilver.Visible = true;
                }
                if (expTotal == 9200)
                {
                    MessageBox.Show("Congratulations you have just earned the GOLD award.");
                    lbNoAwards.Visible = false;
                    pbGold.Visible = true;
                    lbGold.Visible = true;
                }
                if (expTotal == 12200)
                {
                    MessageBox.Show("Congratulations you have just earned the PLATINUM award.");
                    lbNoAwards.Visible = false;
                    pbPlatinum.Visible = true;
                    lbPlatinum.Visible = true;
                }
                if (expTotal == 15200)
                {
                    MessageBox.Show("Congratulations you have just earned the DIAMOND award.");
                    lbNoAwards.Visible = false;
                    pbDiamond.Visible = true;
                    lbDiamond.Visible = true;
                }
                if (expTotal == 18200)
                {
                    MessageBox.Show("Congratulations you have just earned the MASTER award. \n You are now a MASTER!!!");
                    lbNoAwards.Visible = false;
                    pbMaster.Visible = true;
                    lbMaster.Visible = true;
                }

                richTextBox1.Visible = false;
                
            }
            richTextBox1.Clear();
            richTextBox2.Clear();           

            userList.Clear();
            sortedUserList.Clear();
            Populate_Buttons();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progExperience.Increment(expBar / 1000);

            bool isMultiple = expBar % 1000 == 0;

            if (isMultiple == true)
            {
                this.progExperience.Increment(0 / 1000);
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------STORE CODE----------------------------------------------------------------------------------------------//

        public void storeUseButtons()
        { 
            btnUse1.Enabled = false;
            btnUse2.Enabled = false;
            btnUse3.Enabled = false;
            btnUse4.Enabled = false;
            btnUse5.Enabled = false;
            btnUse6.Enabled = false;
            btnUse7.Enabled = false;
            btnUse8.Enabled = false;
            btnUse9.Enabled = false;

            btnUse10.Enabled = false;
            btnUse11.Enabled = false;
            btnUse12.Enabled = false;
            btnUse13.Enabled = false;
            btnUse14.Enabled = false;
            btnUse15.Enabled = false;
            btnUse16.Enabled = false;
            btnUse17.Enabled = false;
            btnUse18.Enabled = false;

            btnUse19.Enabled = false;
            btnUse20.Enabled = false;
            btnUse21.Enabled = false;
            btnUse22.Enabled = false;
            btnUse23.Enabled = false;
            btnUse24.Enabled = false;
            btnUse25.Enabled = false;
        }

        //-----------------------------Change Book Spines------------------------------//

        //---------Use Buttons--------------//
        bool spine1 = true;
        bool spine2 = false;
        bool spine3 = false;
        bool spine4 = false;
        bool spine5 = false;
        bool spine6 = false;
        bool spine7 = false;

        private void useSpineButtonsActive()
        {
            if (spine1 == true)
            {
                btnUse19.Enabled = true;
            }
            if (spine2 == true)
            {
                btnUse20.Enabled = true;
            }
            if (spine3 == true)
            {
                btnUse21.Enabled = true;
            }
            if (spine4 == true)
            {
                btnUse22.Enabled = true;
            }
            if (spine5 == true)
            {
                btnUse23.Enabled = true;
            }
            if (spine6 == true)
            {
                btnUse24.Enabled = true;
            }
            if (spine7 == true)
            {
                btnUse25.Enabled = true;
            }
        }

        private void btnUse19_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 1.png");

            MessageBox.Show("Book Spine Changed!");

            useSpineButtonsActive();
            btnUse19.Enabled = false; 
        }

        private void btnUse20_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 2.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse20.Enabled = false;           
        }

        private void btnUse21_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 3.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse21.Enabled = false;
        }

        private void btnUse22_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 4.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse22.Enabled = false;
        }

        private void btnUse23_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 5.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse23.Enabled = false;
        }

        private void btnUse24_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 6.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse24.Enabled = false;
        }

        private void btnUse25_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbSpine1.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine2.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine3.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine4.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine5.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine6.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine7.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine8.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine9.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");
            pbSpine10.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Spine 7.png");

            MessageBox.Show("Book Spine Changed!");
            useSpineButtonsActive();
            btnUse25.Enabled = false;
        }


        //---------Buy Buttons--------------//

        private void btnBuy19_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice2.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine2 = true;
                btnUse20.Enabled = true;
                btnBuy19.Enabled = false;
                btnBuy19.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy20_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice3.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine3 = true;
                btnUse21.Enabled = true;
                btnBuy20.Enabled = false;
                btnBuy20.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy21_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice4.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine4 = true;
                btnUse22.Enabled = true;
                btnBuy21.Enabled = false;
                btnBuy21.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy22_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice5.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine5 = true;
                btnUse23.Enabled = true;
                btnBuy22.Enabled = false;
                btnBuy22.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy23_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice6.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine6 = true;
                btnUse24.Enabled = true;
                btnBuy23.Enabled = false;
                btnBuy23.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy24_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbSpinePrice7.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                spine7 = true;
                btnUse25.Enabled = true;
                btnBuy24.Enabled = false;
                btnBuy24.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        //-----------------------------Change Profile Pictures------------------------------//

        //---------Use Buttons--------------//
        //Non-Animated prifile pictures
        bool proPic1 = false;
        bool proPic2 = false;
        bool proPic3 = false;
        bool proPic4 = false;
        bool proPic5 = false;
        bool proPic6 = false;
        bool proPic7 = false;
        bool proPic8 = false;
        bool proPic9 = false;

        //Animated prifile pictures
        bool proPic10 = false;
        bool proPic11 = false;
        bool proPic12 = false;
        bool proPic13 = false;
        bool proPic14 = false;
        bool proPic15 = false;
        bool proPic16 = false;
        bool proPic17 = false;
        bool proPic18 = false;

        private void useProfileButtonsActive()
        {
            //Non-Animated prifile pictures
            if (proPic1 == true)
            {
                btnUse1.Enabled = true;
            }
            if (proPic2 == true)
            {
                btnUse2.Enabled = true;
            }
            if (proPic3 == true)
            {
                btnUse3.Enabled = true;
            }
            if (proPic4 == true)
            {
                btnUse4.Enabled = true;
            }
            if (proPic5 == true)
            {
                btnUse5.Enabled = true;
            }
            if (proPic6 == true)
            {
                btnUse6.Enabled = true;
            }
            if (proPic7 == true)
            {
                btnUse7.Enabled = true;
            }
            if (proPic8 == true)
            {
                btnUse8.Enabled = true;
            }
            if (proPic9 == true)
            {
                btnUse9.Enabled = true;
            }

            //Animated prifile pictures
            if (proPic10 == true)
            {
                btnUse10.Enabled = true;
            }
            if (proPic11 == true)
            {
                btnUse11.Enabled = true;
            }
            if (proPic12 == true)
            {
                btnUse12.Enabled = true;
            }
            if (proPic13 == true)
            {
                btnUse13.Enabled = true;
            }
            if (proPic14 == true)
            {
                btnUse14.Enabled = true;
            }
            if (proPic15 == true)
            {
                btnUse15.Enabled = true;
            }
            if (proPic16 == true)
            {
                btnUse16.Enabled = true;
            }
            if (proPic17 == true)
            {
                btnUse17.Enabled = true;
            }
            if (proPic18 == true)
            {
                btnUse18.Enabled = true;
            }
        }

        private void btnUse1_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Nyan cat.png");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse1.Enabled = false;
        }

        private void btnUse2_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Asuna.jpg");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse2.Enabled = false;
        }

        private void btnUse3_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Inosuke.jpg");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse3.Enabled = false;
        }

        private void btnUse4_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Mai Sakurajima.jpg");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse4.Enabled = false;
        }

        private void btnUse5_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Levi.png");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse5.Enabled = false;
        }

        private void btnUse6_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Rem.png");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse6.Enabled = false;
        }

        private void btnUse7_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Shiro.jpg");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse7.Enabled = false;
        }

        private void btnUse8_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\002.png");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse8.Enabled = false;
        }

        private void btnUse9_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Gawr Gura.jpg");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse9.Enabled = false;
        }

        private void btnUse10_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Goku.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse10.Enabled = false;
        }

        private void btnUse11_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Kiara.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse11.Enabled = false;
        }

        private void btnUse12_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Megumin.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse12.Enabled = false;
        }

        private void btnUse13_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Nagatoro.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse13.Enabled = false;
        }

        private void btnUse14_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Nanachi.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse14.Enabled = false;
        }

        private void btnUse15_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Mikasa.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse15.Enabled = false;
        }

        private void btnUse16_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Tanjiro.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse16.Enabled = false;
        }

        private void btnUse17_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Gura Gif.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse17.Enabled = false;
        }

        private void btnUse18_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            pbProfile.Image = Image.FromFile(editedApplicationDirectory + "19001700" + "\\Resources\\Nezuko.gif");

            MessageBox.Show("Profile Picture has been changed!");
            useProfileButtonsActive();
            btnUse18.Enabled = false;
        }

        //------------------------------------------------Buy Buttons-------------------------------------------------------//

        private void btnBuy1_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice1.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic1 = true;
                btnUse1.Enabled = true;
                btnBuy1.Enabled = false;
                btnBuy1.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy2_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice2.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic2 = true;
                btnUse2.Enabled = true;
                btnBuy2.Enabled = false;
                btnBuy2.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy3_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice3.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic3 = true;
                btnUse3.Enabled = true;
                btnBuy3.Enabled = false;
                btnBuy3.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy4_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice4.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic4 = true;
                btnUse4.Enabled = true;
                btnBuy4.Enabled = false;
                btnBuy4.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy5_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice5.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic5 = true;
                btnUse5.Enabled = true;
                btnBuy5.Enabled = false;
                btnBuy5.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy6_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice6.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic6 = true;
                btnUse6.Enabled = true;
                btnBuy6.Enabled = false;
                btnBuy6.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy7_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice7.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic7 = true;
                btnUse7.Enabled = true;
                btnBuy7.Enabled = false;
                btnBuy7.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy8_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice8.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic8 = true;
                btnUse8.Enabled = true;
                btnBuy8.Enabled = false;
                btnBuy8.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy9_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice9.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic9 = true;
                btnUse9.Enabled = true;
                btnBuy9.Enabled = false;
                btnBuy9.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy10_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice10.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic10 = true;
                btnUse10.Enabled = true;
                btnBuy10.Enabled = false;
                btnBuy10.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy11_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice11.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic11 = true;
                btnUse11.Enabled = true;
                btnBuy11.Enabled = false;
                btnBuy11.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy12_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice12.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic12 = true;
                btnUse12.Enabled = true;
                btnBuy12.Enabled = false;
                btnBuy12.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy13_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice13.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic13 = true;
                btnUse13.Enabled = true;
                btnBuy13.Enabled = false;
                btnBuy13.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy14_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice14.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic14 = true;
                btnUse14.Enabled = true;
                btnBuy14.Enabled = false;
                btnBuy14.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy15_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice15.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic15 = true;
                btnUse15.Enabled = true;
                btnBuy15.Enabled = false;
                btnBuy15.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy16_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice16.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic16 = true;
                btnUse16.Enabled = true;
                btnBuy16.Enabled = false;
                btnBuy16.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy17_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice17.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic17 = true;
                btnUse17.Enabled = true;
                btnBuy17.Enabled = false;
                btnBuy17.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }

        private void btnBuy18_Click(object sender, EventArgs e)
        {
            int price = Int32.Parse(lbPicPrice18.Text);

            if (coin >= price)
            {
                coin = coin - price;
                lbCoinAmountStore.Text = coin.ToString();
                lbCoinAmount.Text = coin.ToString();

                proPic18 = true;
                btnUse18.Enabled = true;
                btnBuy18.Enabled = false;
                btnBuy18.Text = "Owned";
            }
            else
            {
                MessageBox.Show("You do not have enough money to buy this item. \n" +
                                "Keep playing to earn more coins.");
            }
        }
    //---------------------------Text box visabilty on button for question answer-----------------------
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }
    //---------------------------------------------------------------------------------------------------
    }
}
