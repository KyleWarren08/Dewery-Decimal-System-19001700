using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewery_Decimal_System_19001700
{
    public partial class Identifying_Areas : Form
    {
        public Identifying_Areas()
        {
            InitializeComponent();
            SelectFromDataDictionary();
            storeUseButtons();
        }

        int expTotal = 0;
        int expBar = 0;
        int levelAdd = 0;
        int level = 0;

        int coin = 0;

        //Data dictionary    
        IDictionary<string, string> dataDict = new Dictionary<string, string>(){
             {"001 - 099", "Generalities : Encyclopedias, Computers, Libraries"},
             {"100 - 199", "Psychology/Philosophy: Ghosts, Dreams, Supernatural, Feelings"},
             {"200 - 299", "Religion: Bible Stories, Mythology, World Religions"},
             {"300 - 399", "Social Science: Money, Transportation, Government, Folklore"},
             {"400 - 499", "Language: Grammar, Dictionaries, Thesauri, Foreign Languages"},
             {"500 - 599", "Natural Science/Mathematics: Weather, Animals, Electricity"},
             {"600 - 699", "Applied Science/Technology: Machines, Pet Care, Medicine"},
             {"700 - 799", "Arts and Recreation: Drawing, Crafts, Music, Sports"},
             {"800 - 899", "Literature: Plays, Poetry, Short Stories"},
             {"900 - 999", "History/Geography: Explorers, Countries, Ancient Cultures"}
        };

        bool Swich = true;

        public void coinAndExp()
        {
            expTotal = expTotal + 200;
            expBar = expBar + 200;
            coin = coin + 50;

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
        }

        public void SelectFromDataDictionary()
        {
            //---------------------------------------------------------------First Question Form-----------------------------------------------------------------------
            if (Swich == true)
            {
                //Getting the 4 questions that will be compaired
                int[] answerIndexes = new int[4];
                Random rnd = new Random();
                int index = rnd.Next(dataDict.Count);
                label1.Text = dataDict.ElementAt(index).Key.ToString();
                answerIndexes[0] = index;

                bool isAns = false;
                do
                {
                    index = rnd.Next(dataDict.Count);
                    if (answerIndexes[0] == index)
                    {
                        isAns = true;
                    }
                    else
                    {
                        isAns = false;
                        label2.Text = dataDict.ElementAt(index).Key.ToString();
                        answerIndexes[1] = index;
                    }
                } while (isAns);


                do
                {
                    isAns = false;
                    index = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 2; i++)
                    {
                        if (answerIndexes[i] == index)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        label3.Text = dataDict.ElementAt(index).Key.ToString();
                        answerIndexes[2] = index;
                    }

                } while (isAns);

                do
                {
                    isAns = false;
                    index = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 3; i++)
                    {
                        if (answerIndexes[i] == index)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        label4.Text = dataDict.ElementAt(index).Key.ToString();
                        answerIndexes[3] = index;
                    }

                } while (isAns);


                //These are the 4 questions that will be compaired
                int[] colum2 = new int[7];
                colum2[0] = answerIndexes[0];
                colum2[1] = answerIndexes[1];
                colum2[2] = answerIndexes[2];
                colum2[3] = answerIndexes[3];

                int index22 = rnd.Next(dataDict.Count);

                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 4; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        colum2[4] = index22;
                    }

                } while (isAns);

                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 5; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {

                        colum2[5] = index22;
                    }

                } while (isAns);


                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 6; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {

                        colum2[6] = index22;
                    }

                } while (isAns);

                //Randomization of array values to get random output each time
                for (int i = 0; i < 30; i++)
                {
                    int index1 = rnd.Next(colum2.Length);
                    int index2 = rnd.Next(colum2.Length);

                    int temp = colum2[index1];
                    colum2[index1] = colum2[index2];
                    colum2[index2] = temp;
                }

                button2.Text = dataDict.ElementAt(colum2[0]).Value.ToString();
                button3.Text = dataDict.ElementAt(colum2[1]).Value.ToString();
                button4.Text = dataDict.ElementAt(colum2[2]).Value.ToString();
                button5.Text = dataDict.ElementAt(colum2[3]).Value.ToString();
                button6.Text = dataDict.ElementAt(colum2[4]).Value.ToString();
                button7.Text = dataDict.ElementAt(colum2[5]).Value.ToString();
                button8.Text = dataDict.ElementAt(colum2[6]).Value.ToString();
            }
            //-------------------------------------------------------Alternative question-----------------------------------------------------------------------------------------------------//

            if (Swich == false)
            {

                //Getting the 4 questions that will be compaired
                int[] answerIndexes = new int[4];
                Random rnd = new Random();
                int index = rnd.Next(dataDict.Count);
                label1.Text = dataDict.ElementAt(index).Value.ToString();
                answerIndexes[0] = index;

                bool isAns = false;
                do
                {
                    index = rnd.Next(dataDict.Count);
                    if (answerIndexes[0] == index)
                    {
                        isAns = true;
                    }
                    else
                    {
                        isAns = false;
                        label2.Text = dataDict.ElementAt(index).Value.ToString();
                        answerIndexes[1] = index;
                    }
                } while (isAns);


                do
                {
                    isAns = false;
                    index = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 2; i++)
                    {
                        if (answerIndexes[i] == index)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        label3.Text = dataDict.ElementAt(index).Value.ToString();
                        answerIndexes[2] = index;
                    }

                } while (isAns);



                do
                {
                    isAns = false;
                    index = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 3; i++)
                    {
                        if (answerIndexes[i] == index)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        label4.Text = dataDict.ElementAt(index).Value.ToString();
                        answerIndexes[3] = index;
                    }

                } while (isAns);

                //These are the 4 questions that will be compaired
                int[] colum2 = new int[7];
                colum2[0] = answerIndexes[0];
                colum2[1] = answerIndexes[1];
                colum2[2] = answerIndexes[2];
                colum2[3] = answerIndexes[3];


                int index22 = rnd.Next(dataDict.Count);

                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 4; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        colum2[4] = index22;
                    }

                } while (isAns);

                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 5; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {
                        colum2[5] = index22;
                    }

                } while (isAns);


                do
                {
                    isAns = false;
                    index22 = rnd.Next(dataDict.Count);
                    for (int i = 0; i < 6; i++)
                    {
                        if (colum2[i] == index22)
                        {
                            isAns = true;
                        }
                    }
                    if (!isAns)
                    {

                        colum2[6] = index22;
                    }

                } while (isAns);

                //Randomization of array values to get random output each time
                for (int i = 0; i < 30; i++)
                {
                    int index3 = rnd.Next(colum2.Length);
                    int index4 = rnd.Next(colum2.Length);

                    int temp = colum2[index3];
                    colum2[index3] = colum2[index4];
                    colum2[index4] = temp;
                }

                button2.Text = dataDict.ElementAt(colum2[0]).Key.ToString();
                button3.Text = dataDict.ElementAt(colum2[1]).Key.ToString();
                button4.Text = dataDict.ElementAt(colum2[2]).Key.ToString();
                button5.Text = dataDict.ElementAt(colum2[3]).Key.ToString();
                button6.Text = dataDict.ElementAt(colum2[4]).Key.ToString();
                button7.Text = dataDict.ElementAt(colum2[5]).Key.ToString();
                button8.Text = dataDict.ElementAt(colum2[6]).Key.ToString();
            }
        }

        //-----------------------------------------------------------Next Question Button-------------------------------------------------------------------------
        public void columnSwop()
        {
            Swich = !Swich;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            columnSwop();
            SelectFromDataDictionary();
            panel5.BackColor = Color.Silver;
            panel6.BackColor = Color.Silver;
            panel7.BackColor = Color.Silver;
            panel8.BackColor = Color.Silver;
        }

        //------------------------------------------------------------------Answer Buttons--------------------------------------------------------------------------
        //First Answer button
        private void button2_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button2.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }              
                else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
                {
                    if (Swich == true)
                    {
                        string answerValue = button2.Text;
                        string questionKey = label2.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Value.Equals(answerValue))
                            {
                                if (dataDict.ElementAt(i).Key.Equals(questionKey))
                                {
                                    panel6.BackColor = Color.Green;
                                    coinAndExp();
                                }
                                else
                                {
                                    panel6.BackColor = Color.Red;
                                }
                            }
                        }

                    }
                    if (Swich == false)
                    {
                        string questionValue2 = label2.Text;
                        string answerKey2 = button2.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                            {
                                if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                                {
                                    panel6.BackColor = Color.Green;
                                    coinAndExp();
                                }
                                else
                                {
                                    panel6.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                }
                else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
                {
                    if (Swich == true)
                    {
                        string answerValue = button2.Text;
                        string questionKey = label3.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Value.Equals(answerValue))
                            {
                                if (dataDict.ElementAt(i).Key.Equals(questionKey))
                                {
                                    panel7.BackColor = Color.Green;
                                    coinAndExp();
                            }
                                else
                                {
                                    panel7.BackColor = Color.Red;
                                }
                            }
                        }

                    }
                    if (Swich == false)
                    {
                        string questionValue2 = label3.Text;
                        string answerKey2 = button2.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                            {
                                if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                                {
                                    panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                                else
                                {
                                    panel7.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                }
                else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
                {
                    if (Swich == true)
                    {
                        string answerValue = button2.Text;
                        string questionKey = label4.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Value.Equals(answerValue))
                            {
                                if (dataDict.ElementAt(i).Key.Equals(questionKey))
                                {
                                    panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                                else
                                {
                                    panel8.BackColor = Color.Red;
                                }
                            }
                        }

                    }
                    if (Swich == false)
                    {
                        string questionValue2 = label4.Text;
                        string answerKey2 = button2.Text;

                        for (int i = 0; i < dataDict.Count; i++)
                        {
                            if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                            {
                                if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                                {
                                    panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                                else
                                {
                                    panel8.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                }                      
        }

        //Second Answer Button
        private void button3_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button3.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button3.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button3.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button3.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        //button 3
        private void button4_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button4.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button4.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button4.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button4.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        //button 4
        private void button5_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button5.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button5.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button5.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button5.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button5.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button5.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button5.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button5.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        //button 5
        private void button6_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button6.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button6.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button6.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button6.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button6.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button6.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button6.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button6.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        //button 6
        private void button7_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button7.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button7.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button7.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button7.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button7.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button7.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button7.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button7.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
        //button 7
        private void button8_Click(object sender, EventArgs e)
        {
            //If swich is true we are compairing the keys to the values
            if (panel5.BackColor == Color.Silver)
            {
                if (Swich == true)
                {
                    string answerValue = button8.Text;
                    string questionKey = label1.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label1.Text;
                    string answerKey2 = button8.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel5.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel5.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel6.BackColor == Color.Silver && (panel5.BackColor == Color.Green || panel5.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button8.Text;
                    string questionKey = label2.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label2.Text;
                    string answerKey2 = button8.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel6.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel6.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel7.BackColor == Color.Silver && (panel6.BackColor == Color.Green || panel6.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button8.Text;
                    string questionKey = label3.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label3.Text;
                    string answerKey2 = button8.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel7.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel7.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            else if (panel8.BackColor == Color.Silver && (panel7.BackColor == Color.Green || panel7.BackColor == Color.Red))
            {
                if (Swich == true)
                {
                    string answerValue = button8.Text;
                    string questionKey = label4.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Value.Equals(answerValue))
                        {
                            if (dataDict.ElementAt(i).Key.Equals(questionKey))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }

                }
                if (Swich == false)
                {
                    string questionValue2 = label4.Text;
                    string answerKey2 = button8.Text;

                    for (int i = 0; i < dataDict.Count; i++)
                    {
                        if (dataDict.ElementAt(i).Key.Equals(answerKey2))
                        {
                            if (dataDict.ElementAt(i).Value.Equals(questionValue2))
                            {
                                panel8.BackColor = Color.Green;
                                coinAndExp();
                            }
                            else
                            {
                                panel8.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        //Store code

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

    }
}
