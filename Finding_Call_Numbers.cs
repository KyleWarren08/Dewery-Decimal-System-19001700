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
    public partial class Finding_Call_Numbers : Form
    {
        public Finding_Call_Numbers()
        {
            InitializeComponent();
            LoadDataIntoMemory();
            lbCallNumPopulation();
            storeUseButtons();
        }
        bool nodefound = false;

        int leafenum1 = 0;
        int leafenum2 = 0;
        int leafenum3 = 0;

        int potentialAnswer1 = 0;
        int potentialAnswer2 = 0;
        int potentialAnswer3 = 0;

        //For the first group of buttons
        String AnswerPotential1 = null;
        String AnswerPotential2 = null;
        String AnswerPotential3 = null;

        //For the second group of buttons 
        String answer2potential1 = null;
        String answer2potential2 = null;
        String answer2potential3 = null;

        //For the Third group of buttons 
        String answer3potential1 = null;
        String answer3potential2 = null;
        String answer3potential3 = null;

        List<int> potentialAnswers = new List<int>();
        List<int> potentialAnswers2 = new List<int>();
        List<int> potentialAnswers3 = new List<int>();

        String answer1 = null;
        String answer2 = null;
        String answer3 = null;


        int expTotal = 0;
        int expBar = 0;
        int levelAdd = 0;
        int level = 0;

        int coin = 0;

        public void LoadDataIntoMemory()
        {


            string applicationDirectory = Application.ExecutablePath;
            //Using my student number as an index to get the file path of the application.
            string editedApplicationDirectory = applicationDirectory.Substring(0, applicationDirectory.IndexOf("19001700"));

            string[] lines = System.IO.File.ReadAllLines(editedApplicationDirectory + "19001700" + "\\Dewery Decimal System 19001700\\Resources\\Dewery_Decimal_System_Classes.txt");

            foreach (string line in lines)
            {
                // All "$" signes make up the first node of the data tree.
                if (line.StartsWith("$"))
                {
                    TreeNode tNode;
                    tNode = DataTreeView.Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#00"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*00"))
                {
                    DataTreeView.Nodes[0].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#01"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*01"))
                {
                    DataTreeView.Nodes[0].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#02"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*02"))
                {
                    DataTreeView.Nodes[0].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#03"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*03"))
                {
                    DataTreeView.Nodes[0].Nodes[3].Nodes.Add(line);
                }

                //There are no "#04" entries
                //There are no "*04" entries

                if (line.StartsWith("#05"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*05"))
                {
                    DataTreeView.Nodes[0].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#06"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*06"))
                {
                    DataTreeView.Nodes[0].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#07"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*07"))
                {
                    DataTreeView.Nodes[0].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#08"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*08"))
                {
                    DataTreeView.Nodes[0].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#09"))
                {
                    DataTreeView.Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("*09"))
                {
                    DataTreeView.Nodes[0].Nodes[8].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#10"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*10"))
                {
                    DataTreeView.Nodes[1].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#11"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*11"))
                {
                    DataTreeView.Nodes[1].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#12"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*12"))
                {
                    DataTreeView.Nodes[1].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#13"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*13"))
                {
                    DataTreeView.Nodes[1].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#14"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*14"))
                {
                    DataTreeView.Nodes[1].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#15"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*15"))
                {
                    DataTreeView.Nodes[1].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#16"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*16"))
                {
                    DataTreeView.Nodes[1].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#17"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*17"))
                {
                    DataTreeView.Nodes[1].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#18"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*18"))
                {
                    DataTreeView.Nodes[1].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#19"))
                {
                    DataTreeView.Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("*19"))
                {
                    DataTreeView.Nodes[1].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#20"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*20"))
                {
                    DataTreeView.Nodes[2].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#21"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*21"))
                {
                    DataTreeView.Nodes[2].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#22"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*22"))
                {
                    DataTreeView.Nodes[2].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#23"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*23"))
                {
                    DataTreeView.Nodes[2].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#24"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*24"))
                {
                    DataTreeView.Nodes[2].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#25"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*25"))
                {
                    DataTreeView.Nodes[2].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#26"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*26"))
                {
                    DataTreeView.Nodes[2].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#27"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*27"))
                {
                    DataTreeView.Nodes[2].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#28"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*28"))
                {
                    DataTreeView.Nodes[2].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#29"))
                {
                    DataTreeView.Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("*29"))
                {
                    DataTreeView.Nodes[2].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#30"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*30"))
                {
                    DataTreeView.Nodes[3].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#31"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*31"))
                {
                    DataTreeView.Nodes[3].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#32"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*32"))
                {
                    DataTreeView.Nodes[3].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#33"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*33"))
                {
                    DataTreeView.Nodes[3].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#34"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*34"))
                {
                    DataTreeView.Nodes[3].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#35"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*35"))
                {
                    DataTreeView.Nodes[3].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#36"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*36"))
                {
                    DataTreeView.Nodes[3].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#37"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*37"))
                {
                    DataTreeView.Nodes[3].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#38"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*38"))
                {
                    DataTreeView.Nodes[3].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#39"))
                {
                    DataTreeView.Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("*39"))
                {
                    DataTreeView.Nodes[3].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#40"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*40"))
                {
                    DataTreeView.Nodes[4].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#41"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*41"))
                {
                    DataTreeView.Nodes[4].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#42"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*42"))
                {
                    DataTreeView.Nodes[4].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#43"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*43"))
                {
                    DataTreeView.Nodes[4].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#44"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*44"))
                {
                    DataTreeView.Nodes[4].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#45"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*45"))
                {
                    DataTreeView.Nodes[4].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#46"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*46"))
                {
                    DataTreeView.Nodes[4].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#47"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*47"))
                {
                    DataTreeView.Nodes[4].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#48"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*48"))
                {
                    DataTreeView.Nodes[4].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#49"))
                {
                    DataTreeView.Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("*49"))
                {
                    DataTreeView.Nodes[4].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#50"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*50"))
                {
                    DataTreeView.Nodes[5].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#51"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*51"))
                {
                    DataTreeView.Nodes[5].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#52"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*52"))
                {
                    DataTreeView.Nodes[5].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#53"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*53"))
                {
                    DataTreeView.Nodes[5].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#54"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*54"))
                {
                    DataTreeView.Nodes[5].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#55"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*55"))
                {
                    DataTreeView.Nodes[5].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#56"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*56"))
                {
                    DataTreeView.Nodes[5].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#57"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*57"))
                {
                    DataTreeView.Nodes[5].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#58"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*58"))
                {
                    DataTreeView.Nodes[5].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#59"))
                {
                    DataTreeView.Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("*59"))
                {
                    DataTreeView.Nodes[5].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#60"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*60"))
                {
                    DataTreeView.Nodes[6].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#61"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*61"))
                {
                    DataTreeView.Nodes[6].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#62"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*62"))
                {
                    DataTreeView.Nodes[6].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#63"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*63"))
                {
                    DataTreeView.Nodes[6].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#64"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*64"))
                {
                    DataTreeView.Nodes[6].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#65"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*65"))
                {
                    DataTreeView.Nodes[6].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#66"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*66"))
                {
                    DataTreeView.Nodes[6].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#67"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*67"))
                {
                    DataTreeView.Nodes[6].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#68"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*68"))
                {
                    DataTreeView.Nodes[6].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#69"))
                {
                    DataTreeView.Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("*69"))
                {
                    DataTreeView.Nodes[6].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#70"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*70"))
                {
                    DataTreeView.Nodes[7].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#71"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*71"))
                {
                    DataTreeView.Nodes[7].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#72"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*72"))
                {
                    DataTreeView.Nodes[7].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#73"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*73"))
                {
                    DataTreeView.Nodes[7].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#74"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*74"))
                {
                    DataTreeView.Nodes[7].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#75"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*75"))
                {
                    DataTreeView.Nodes[7].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#76"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*76"))
                {
                    DataTreeView.Nodes[7].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#77"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*77"))
                {
                    DataTreeView.Nodes[7].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#78"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*78"))
                {
                    DataTreeView.Nodes[7].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#79"))
                {
                    DataTreeView.Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("*79"))
                {
                    DataTreeView.Nodes[7].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#80"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*80"))
                {
                    DataTreeView.Nodes[8].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#81"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*81"))
                {
                    DataTreeView.Nodes[8].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#82"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*82"))
                {
                    DataTreeView.Nodes[8].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#83"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*83"))
                {
                    DataTreeView.Nodes[8].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#84"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*84"))
                {
                    DataTreeView.Nodes[8].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#85"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*85"))
                {
                    DataTreeView.Nodes[8].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#86"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*86"))
                {
                    DataTreeView.Nodes[8].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#87"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*87"))
                {
                    DataTreeView.Nodes[8].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#88"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*88"))
                {
                    DataTreeView.Nodes[8].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#89"))
                {
                    DataTreeView.Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("*89"))
                {
                    DataTreeView.Nodes[8].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------
                if (line.StartsWith("#90"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*90"))
                {
                    DataTreeView.Nodes[9].Nodes[0].Nodes.Add(line);
                }
                if (line.StartsWith("#91"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*91"))
                {
                    DataTreeView.Nodes[9].Nodes[1].Nodes.Add(line);
                }
                if (line.StartsWith("#92"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*92"))
                {
                    DataTreeView.Nodes[9].Nodes[2].Nodes.Add(line);
                }
                if (line.StartsWith("#93"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*93"))
                {
                    DataTreeView.Nodes[9].Nodes[3].Nodes.Add(line);
                }
                if (line.StartsWith("#94"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*94"))
                {
                    DataTreeView.Nodes[9].Nodes[4].Nodes.Add(line);
                }
                if (line.StartsWith("#95"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*95"))
                {
                    DataTreeView.Nodes[9].Nodes[5].Nodes.Add(line);
                }
                if (line.StartsWith("#96"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*96"))
                {
                    DataTreeView.Nodes[9].Nodes[6].Nodes.Add(line);
                }
                if (line.StartsWith("#97"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*97"))
                {
                    DataTreeView.Nodes[9].Nodes[7].Nodes.Add(line);
                }
                if (line.StartsWith("#98"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*98"))
                {
                    DataTreeView.Nodes[9].Nodes[8].Nodes.Add(line);
                }
                if (line.StartsWith("#99"))
                {
                    DataTreeView.Nodes[9].Nodes.Add(line);
                }
                if (line.StartsWith("*99"))
                {
                    DataTreeView.Nodes[9].Nodes[9].Nodes.Add(line);
                }
                //------------------------------------------------------------------------------------------------

            }

            //https://social.msdn.microsoft.com/Forums/en-US/e38a67aa-33e5-4aac-97fa-e465090b9e77/c-how-to-search-a-text-in-all-parent-amp-child-nodes-of-treeview-control-winform?forum=winformsdatacontrols
        }


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

        private void SelectSearched(TreeNode treeNode)
        {
            if (treeNode.Text.ToUpper().Contains(textBox1.Text.ToUpper().ToString()))
            {
                DataTreeView.SelectedNode = treeNode;
                DataTreeView.SelectedNode.Expand();
                DataTreeView.Focus();
                nodefound = true;
                return;
            }

            foreach (TreeNode tn in treeNode.Nodes)
            {
                SelectSearched(tn);
            }
        }

        public void GetRandomLeafe()
        {

            string leafe = null;

            Random rnd = new Random();
            leafenum1 = rnd.Next(1, 10);
            leafenum2 = rnd.Next(1, 10);
            leafenum3 = rnd.Next(1, 10);

            if (leafenum1 == 10)
            {
                leafenum1 = 0;
            }
            else if (leafenum2 == 10)
            {
                leafenum2 = 0;
            }
            else if (leafenum3 == 10)
            {
                leafenum3 = 0;
            }

            leafe = "*" + leafenum1.ToString() + leafenum2.ToString() + leafenum3.ToString();

            textBox1.Text = leafe;
            lbCallNumber.Text = leafenum1.ToString() + leafenum2.ToString() + leafenum3.ToString();
        }

        public void NextQusetion()
        {
            potentialAnswers.Clear();
            potentialAnswers2.Clear();
            potentialAnswers3.Clear();
            textBox1.Clear();
            GetRandomLeafe();

            UpperLevelAnswers();
            MiddleLevelAnswers();
            LowerLevelAnswers();

            label1.Visible = true;
            btnAnswer1.Visible = true;
            btnAnswer2.Visible = true;
            btnAnswer3.Visible = true;
            btnAnswer4.Visible = true;
            label3.Visible = false;
            btn2Answer1.Visible = false;
            btn2Answer2.Visible = false;
            btn2Answer3.Visible = false;
            btn2Answer4.Visible = false;
            label2.Visible = false;
            btn3Answer1.Visible = false;
            btn3Answer2.Visible = false;
            btn3Answer3.Visible = false;
            btn3Answer4.Visible = false;

            if (textBox1.Text.Trim() != "")
            {
                if (DataTreeView.Nodes.Count > 0)
                {
                    nodefound = false;

                    TreeNodeCollection nodes = DataTreeView.Nodes;
                    foreach (TreeNode n in nodes)
                    {
                        if (!nodefound)
                        {
                            SelectSearched(n);
                        }
                        else
                        {
                            return;
                        }

                    }
                }
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            NextQusetion();
        }

        private void btnBeginQuiz_Click(object sender, EventArgs e)
        {


            btnBeginQuiz.Visible = false;
            btnNextQuestion.Visible = true;
            lbQuestion.Visible = true;
            label1.Visible = true;
            btnAnswer1.Visible = true;
            btnAnswer2.Visible = true;
            btnAnswer3.Visible = true;
            btnAnswer4.Visible = true;

            Random rnd = new Random();
            potentialAnswer1 = rnd.Next(1, 10);
            potentialAnswer2 = rnd.Next(1, 10);
            potentialAnswer3 = rnd.Next(1, 10);

            if (potentialAnswer1 == 10)
            {
                potentialAnswer1 = 0;
            }

            if (potentialAnswer2 == 10)
            {
                potentialAnswer2 = 0;
            }

            if (potentialAnswer3 == 10)
            {
                potentialAnswer3 = 0;
            }

            lbCallNumber.Text = "";
            textBox1.Clear();
            GetRandomLeafe();

            UpperLevelAnswers();
            MiddleLevelAnswers();
            LowerLevelAnswers();

            if (textBox1.Text.Trim() != "")
            {
                if (DataTreeView.Nodes.Count > 0)
                {
                    nodefound = false;

                    TreeNodeCollection nodes = DataTreeView.Nodes;
                    foreach (TreeNode n in nodes)
                    {
                        if (!nodefound)
                        {
                            SelectSearched(n);
                        }
                        else
                        {
                            return;
                        }

                    }
                }
            }

        }

        public void lbCallNumPopulation()
        {
            lbCallNumber.Text = textBox1.Text;
        }

        public void UpperLevelAnswers()
        {
            answer1 = leafenum1.ToString() + "00";
            AnswerPotential1 = potentialAnswer1.ToString() + "00";
            AnswerPotential2 = potentialAnswer2.ToString() + "00";
            AnswerPotential3 = potentialAnswer3.ToString() + "00";

            potentialAnswers.Add(int.Parse(answer1));
            potentialAnswers.Add(int.Parse(AnswerPotential1));
            potentialAnswers.Add(int.Parse(AnswerPotential2));
            potentialAnswers.Add(int.Parse(AnswerPotential3));

            potentialAnswers.Sort();

            btnAnswer1.Text = potentialAnswers.ElementAt(0).ToString();
            btnAnswer2.Text = potentialAnswers.ElementAt(1).ToString();
            btnAnswer3.Text = potentialAnswers.ElementAt(2).ToString();
            btnAnswer4.Text = potentialAnswers.ElementAt(3).ToString();
        }

        public void MiddleLevelAnswers()
        {
            answer2 = leafenum1.ToString() + leafenum2.ToString() + "0";
            answer2potential1 = potentialAnswer2.ToString() + potentialAnswer1.ToString() + "0";
            answer2potential2 = potentialAnswer3.ToString() + potentialAnswer2.ToString() + "0";
            answer2potential3 = potentialAnswer1.ToString() + potentialAnswer3.ToString() + "0";

            potentialAnswers2.Add(int.Parse(answer2));
            potentialAnswers2.Add(int.Parse(answer2potential1));
            potentialAnswers2.Add(int.Parse(answer2potential2));
            potentialAnswers2.Add(int.Parse(answer2potential3));

            potentialAnswers2.Sort();

            btn2Answer1.Text = potentialAnswers2.ElementAt(0).ToString();
            btn2Answer2.Text = potentialAnswers2.ElementAt(1).ToString();
            btn2Answer3.Text = potentialAnswers2.ElementAt(2).ToString();
            btn2Answer4.Text = potentialAnswers2.ElementAt(3).ToString();
        }

        public void LowerLevelAnswers()
        {
            answer3 = leafenum1.ToString() + leafenum2.ToString() + leafenum3.ToString();
            answer3potential1 = potentialAnswer1.ToString() + potentialAnswer3.ToString() + potentialAnswer2.ToString();
            answer3potential2 = potentialAnswer2.ToString() + potentialAnswer1.ToString() + potentialAnswer3.ToString();
            answer3potential3 = potentialAnswer3.ToString() + potentialAnswer2.ToString() + potentialAnswer1.ToString();

            potentialAnswers3.Add(int.Parse(answer3));
            potentialAnswers3.Add(int.Parse(answer3potential1));
            potentialAnswers3.Add(int.Parse(answer3potential2));
            potentialAnswers3.Add(int.Parse(answer3potential3));

            potentialAnswers3.Sort();

            btn3Answer1.Text = potentialAnswers3.ElementAt(0).ToString();
            btn3Answer2.Text = potentialAnswers3.ElementAt(1).ToString();
            btn3Answer3.Text = potentialAnswers3.ElementAt(2).ToString();
            btn3Answer4.Text = potentialAnswers3.ElementAt(3).ToString();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (btnAnswer1.Text.ToString() == answer1)
            {
                MessageBox.Show("That Answer is Correct! :)");
                btnAnswer1.Visible = false;
                btnAnswer2.Visible = false;
                btnAnswer3.Visible = false;
                btnAnswer4.Visible = false;
                label1.Visible = false;
                label3.Visible = true;
                btn2Answer1.Visible = true;
                btn2Answer2.Visible = true;
                btn2Answer3.Visible = true;
                btn2Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {

            if (btnAnswer2.Text.ToString() == answer1)
            {
                MessageBox.Show("That Answer is Correct! :)");
                btnAnswer1.Visible = false;
                btnAnswer2.Visible = false;
                btnAnswer3.Visible = false;
                btnAnswer4.Visible = false;
                label1.Visible = false;
                label3.Visible = true;
                btn2Answer1.Visible = true;
                btn2Answer2.Visible = true;
                btn2Answer3.Visible = true;
                btn2Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {

            if (btnAnswer3.Text.ToString() == answer1)
            {
                MessageBox.Show("That Answer is Correct! :)");
                btnAnswer1.Visible = false;
                btnAnswer2.Visible = false;
                btnAnswer3.Visible = false;
                btnAnswer4.Visible = false;
                label1.Visible = false;
                label3.Visible = true;
                btn2Answer1.Visible = true;
                btn2Answer2.Visible = true;
                btn2Answer3.Visible = true;
                btn2Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (btnAnswer4.Text.ToString() == answer1)
            {
                MessageBox.Show("That Answer is Correct! :)");
                btnAnswer1.Visible = false;
                btnAnswer2.Visible = false;
                btnAnswer3.Visible = false;
                btnAnswer4.Visible = false;
                label1.Visible = false;
                label3.Visible = true;
                btn2Answer1.Visible = true;
                btn2Answer2.Visible = true;
                btn2Answer3.Visible = true;
                btn2Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn2Answer1_Click(object sender, EventArgs e)
        {
            if (btn2Answer1.Text.ToString() == answer2)
            {
                MessageBox.Show("That Answer is Correct! :)");

                btn2Answer1.Visible = false;
                btn2Answer2.Visible = false;
                btn2Answer3.Visible = false;
                btn2Answer4.Visible = false;
                label3.Visible = false;
                label2.Visible = true;
                btn3Answer1.Visible = true;
                btn3Answer2.Visible = true;
                btn3Answer3.Visible = true;
                btn3Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn2Answer2_Click(object sender, EventArgs e)
        {
            if (btn2Answer2.Text.ToString() == answer2)
            {
                MessageBox.Show("That Answer is Correct! :)");

                btn2Answer1.Visible = false;
                btn2Answer2.Visible = false;
                btn2Answer3.Visible = false;
                btn2Answer4.Visible = false;
                label3.Visible = false;
                label2.Visible = true;
                btn3Answer1.Visible = true;
                btn3Answer2.Visible = true;
                btn3Answer3.Visible = true;
                btn3Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn2Answer3_Click(object sender, EventArgs e)
        {
            if (btn2Answer3.Text.ToString() == answer2)
            {
                MessageBox.Show("That Answer is Correct! :)");

                btn2Answer1.Visible = false;
                btn2Answer2.Visible = false;
                btn2Answer3.Visible = false;
                btn2Answer4.Visible = false;
                label3.Visible = false;
                label2.Visible = true;
                btn3Answer1.Visible = true;
                btn3Answer2.Visible = true;
                btn3Answer3.Visible = true;
                btn3Answer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn2Answer4_Click(object sender, EventArgs e)
        {
            if (btn2Answer4.Text.ToString() == answer2)
            {
                MessageBox.Show("That Answer is Correct! :)");

                NextQusetion();

                btn3Answer1.Visible = false;
                btn3Answer2.Visible = false;
                btn3Answer3.Visible = false;
                btn3Answer4.Visible = false;
                label3.Visible = false;
                label2.Visible = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn3Answer1_Click(object sender, EventArgs e)
        {
            if (btn3Answer1.Text.ToString() == answer3)
            {
                MessageBox.Show("That Answer is Correct! :)");

                NextQusetion();

                btn3Answer1.Visible = false;
                btn3Answer2.Visible = false;
                btn3Answer3.Visible = false;
                btn3Answer4.Visible = false;
                label2.Visible = false;
                label1.Visible = true;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn3Answer2_Click(object sender, EventArgs e)
        {
            if (btn3Answer2.Text.ToString() == answer3)
            {
                MessageBox.Show("That Answer is Correct! :)");

                NextQusetion();

                btn3Answer1.Visible = false;
                btn3Answer2.Visible = false;
                btn3Answer3.Visible = false;
                btn3Answer4.Visible = false;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn3Answer3_Click(object sender, EventArgs e)
        {
            if (btn3Answer3.Text.ToString() == answer3)
            {
                MessageBox.Show("That Answer is Correct! :)");

                NextQusetion();

                btn3Answer1.Visible = false;
                btn3Answer2.Visible = false;
                btn3Answer3.Visible = false;
                btn3Answer4.Visible = false;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void btn3Answer4_Click(object sender, EventArgs e)
        {
            if (btn3Answer4.Text.ToString() == answer3)
            {
                MessageBox.Show("That Answer is Correct! :)");

                NextQusetion();

                btn3Answer1.Visible = false;
                btn3Answer2.Visible = false;
                btn3Answer3.Visible = false;
                btn3Answer4.Visible = false;
                btnAnswer1.Visible = true;
                btnAnswer2.Visible = true;
                btnAnswer3.Visible = true;
                btnAnswer4.Visible = true;
                coinAndExp();
            }
            else
            {
                MessageBox.Show("That Answer is Incorrect :(");
                NextQusetion();
            }
        }

        private void viewAnswer_Click(object sender, EventArgs e)
        {
            if (DataTreeView.Visible == false)
            {
                DataTreeView.Visible = true;
            }
            else if (DataTreeView.Visible == true)
            {
                DataTreeView.Visible = false;
            }
        }


        //Store code--------------------------------------------------------
        //------------------------------------------------------------------

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
