namespace Supertictactoe_Trial_1
{
    public partial class SuperTC1 : Form
    {

        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;

        List<Button> buttons;

        Button lastPlayerButton;
        Button lastCPUButton;

        bool CPUhasMOVED;
        bool topleft, topright, topmid, midleft, midmid, midright, botleft, botmid, botright;


        private List<Button> buttonGroup11;
        private List<Button> buttonGroup12;
        private List<Button> buttonGroup13;
        private List<Button> buttonGroup21;
        private List<Button> buttonGroup22;
        private List<Button> buttonGroup23;
        private List<Button> buttonGroup31;
        private List<Button> buttonGroup32;
        private List<Button> buttonGroup33;
        private List<List<Button>> buttonGroups;

        List<Button> buttonPermaGroup11;
        List<Button> buttonPermaGroup12;
        List<Button> buttonPermaGroup13;
        List<Button> buttonPermaGroup21;
        List<Button> buttonPermaGroup22;
        List<Button> buttonPermaGroup23;
        List<Button> buttonPermaGroup31;
        List<Button> buttonPermaGroup32;
        List<Button> buttonPermaGroup33;


        bool highlighted11;
        bool highlighted12;
        bool highlighted13;
        bool highlighted21;
        bool highlighted22;
        bool highlighted23;
        bool highlighted31;
        bool highlighted32;
        bool highlighted33;


        public void InitialButtonGroups()
        {
            buttonGroup11 = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            
            buttonGroup12 = new List<Button> { button10, button11, button12, button13, button14, button15, button16, button17, button18 };
            buttonGroup13 = new List<Button> { button19, button20, button21, button22, button23, button24, button25, button26, button27 };
            buttonGroup21 = new List<Button> { button29, button34, button31, button28, button43, button46, button40, button49, button52 };
            buttonGroup22 = new List<Button> { button30, button33, button37, button36, button44, button47, button41, button50, button53 };
            buttonGroup23 = new List<Button> { button32, button35, button39, button38, button45, button48, button42, button51, button54 };
            buttonGroup31 = new List<Button> { button55, button56, button61, button58, button70, button73, button67, button76, button79 };
            buttonGroup32 = new List<Button> { button57, button60, button64, button63, button71, button74, button68, button77, button80 };
            buttonGroup33 = new List<Button> { button59, button62, button66, button65, button72, button75, button69, button78, button81 };
            buttonGroups = new List<List<Button>> { buttonGroup11, buttonGroup12, buttonGroup13, buttonGroup21, buttonGroup22, buttonGroup23,
                buttonGroup31,
                buttonGroup32, buttonGroup33};


            buttonPermaGroup11 = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            buttonPermaGroup12 = new List<Button> { button10, button11, button12, button13, button14, button15, button16, button17, button18 };
            buttonPermaGroup13 = new List<Button> { button19, button20, button21, button22, button23, button24, button25, button26, button27 };
            buttonPermaGroup21 = new List<Button> { button29, button34, button31, button28, button43, button46, button40, button49, button52 };
            buttonPermaGroup22 = new List<Button> { button30, button33, button37, button36, button44, button47, button41, button50, button53 };
            buttonPermaGroup23 = new List<Button> { button32, button35, button39, button38, button45, button48, button42, button51, button54 };
            buttonPermaGroup31 = new List<Button> { button55, button56, button61, button58, button70, button73, button67, button76, button79 };
            buttonPermaGroup32 = new List<Button> { button57, button60, button64, button63, button71, button74, button68, button77, button80 };
            buttonPermaGroup33 = new List<Button> { button59, button62, button66, button65, button72, button75, button69, button78, button81 };

            highlighted11 = false;
            highlighted12 = false;
            highlighted13 = false;
            highlighted21 = false;
            highlighted22 = false;
            highlighted23 = false;
            highlighted31 = false;
            highlighted32 = false;
            highlighted33 = false;
        }


        public SuperTC1()
        {

            InitializeComponent();
            Tutorial_Text_Box();
            InitialButtonGroups();
            RestartGame();
        }

        public void Tutorial_Text_Box()
        {
            MessageBox.Show("Super Tic-Tac-Toe is an advanced version of the classic Tic-Tac-Toe game played on a 9x9 grid. \nThe grid is divided into 9 smaller 3x3 sub-grids, making a total of 81 spaces. \nPlayers take turns placing their mark (either X or O) on the board, and the goal is to win by getting three marks in a row in any of the sub-grids, just like in regular Tic-Tac-Toe.\nEach player must follow a special rule about where they can place their mark. On the first turn, Player 1 can place their mark anywhere on the board. \nAfter that, the location of each player’s move determines where the next player must play. \nFor example, if Player 1 places their mark in the top-right corner of a sub-grid, Player 2 must place their mark in the top-right sub-grid of the main board. This rule forces players to think ahead about their moves and their opponent’s possible moves.\r\n\r\nTo win a sub-grid, a player must get three marks in a row, just like in regular Tic-Tac-Toe. Once a player wins a sub-grid, it is considered controlled by that player, and no more marks can be placed there. \nThe overall goal of the game is to win three sub-grids in a row on the main 9x9 board, either horizontally, vertically, or diagonally.\nIf a player is directed to a sub-grid that is already full or has been won, they can place their mark in any open space in the corresponding sub-grid. \nThe game ends when a player wins three sub-grids in a row, and that player is declared the winner. The complexity of Super Tic-Tac-Toe comes from the need to manage both individual sub-grids and the larger 9x9 grid, requiring strategic planning and foresight.", "RULES of the SUPER TIC-TAC-TOE");
        }
        public void RestartGame()
        {
            buttons = new List<Button>{button1, button2, button3, button4, button5, button6, button7, button8, button9,
            button10, button11, button12, button13, button14, button15, button16, button17, button18,
            button19, button20, button21, button22, button23, button24, button25, button26, button27,
            button28, button29, button30, button31, button32, button33, button34, button35, button36,
            button37, button38, button39, button40, button41, button42, button43, button44, button45,
            button46, button47, button48, button49, button50, button51, button52, button53, button54,
            button55, button56, button57, button58, button59, button60, button61, button62, button63,
            button64, button65, button66, button67, button68, button69, button70, button71, button72,
            button73, button74, button75, button76, button77, button78, button79, button80, button81 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;
            }
            InitialButtonGroups();
            lastCPUButton = null;
            foreach(var x in buttonGroups)
            {
                foreach(Button y in x)
                {
                    y.Enabled = true;
                    y.Text = " ";
                    y.BackColor = DefaultBackColor;
                }
            }
        }

        private void CheckGame()
        {
            Console.WriteLine("Started Checking");

            //highlighting the small grids
            //for x in small tictactoe
            if (!highlighted11 &&

                (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
                button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup11)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;

                }
                highlighted11 = true;
                buttonGroup11.Clear();
            }
            else if (!highlighted12 &&
                button10.Text == "X" && button11.Text == "X" && button13.Text == "X" ||
                button12.Text == "X" && button15.Text == "X" && button16.Text == "X" ||
                button14.Text == "X" && button17.Text == "X" && button18.Text == "X" ||
                button10.Text == "X" && button12.Text == "X" && button14.Text == "X" ||
                button11.Text == "X" && button15.Text == "X" && button17.Text == "X" ||
                button13.Text == "X" && button16.Text == "X" && button18.Text == "X" ||
                button10.Text == "X" && button15.Text == "X" && button18.Text == "X" ||
                button13.Text == "X" && button15.Text == "X" && button14.Text == "X")
            {
                foreach (Button x in buttonPermaGroup12)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted12 = true;
                buttonGroup12.Clear();
            }
            else if (!highlighted13 && (
                button19.Text == "X" && button20.Text == "X" && button22.Text == "X" ||
                button21.Text == "X" && button24.Text == "X" && button25.Text == "X" ||
                button23.Text == "X" && button26.Text == "X" && button27.Text == "X" ||
                button19.Text == "X" && button21.Text == "X" && button23.Text == "X" ||
                button20.Text == "X" && button24.Text == "X" && button26.Text == "X" ||
                button22.Text == "X" && button25.Text == "X" && button27.Text == "X" ||
                button19.Text == "X" && button24.Text == "X" && button27.Text == "X" ||
                button22.Text == "X" && button24.Text == "X" && button23.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup13)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted13 = true;
                buttonGroup13.Clear();

            }
            else if (!highlighted21 && (
                button28.Text == "X" && button29.Text == "X" && button34.Text == "X" ||
                button31.Text == "X" && button43.Text == "X" && button46.Text == "X" ||
                button40.Text == "X" && button49.Text == "X" && button52.Text == "X" ||
                button28.Text == "X" && button31.Text == "X" && button40.Text == "X" ||
                button29.Text == "X" && button43.Text == "X" && button49.Text == "X" ||
                button34.Text == "X" && button46.Text == "X" && button52.Text == "X" ||
                button28.Text == "X" && button43.Text == "X" && button52.Text == "X" ||
                button34.Text == "X" && button43.Text == "X" && button40.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup21)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted21 = true;
                buttonGroup21.Clear();
            }
            else if (!highlighted22 && (
                button30.Text == "X" && button33.Text == "X" && button37.Text == "X" ||
                button36.Text == "X" && button44.Text == "X" && button47.Text == "X" ||
                button41.Text == "X" && button50.Text == "X" && button53.Text == "X" ||
                button30.Text == "X" && button36.Text == "X" && button41.Text == "X" ||
                button33.Text == "X" && button44.Text == "X" && button50.Text == "X" ||
                button37.Text == "X" && button47.Text == "X" && button53.Text == "X" ||
                button30.Text == "X" && button44.Text == "X" && button53.Text == "X" ||
                button37.Text == "X" && button44.Text == "X" && button41.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup22)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted22 = true;
                buttonGroup22.Clear();
            }
            else if (
                !highlighted23 && (
                button32.Text == "X" && button35.Text == "X" && button39.Text == "X" ||
                button38.Text == "X" && button45.Text == "X" && button48.Text == "X" ||
                button42.Text == "X" && button51.Text == "X" && button54.Text == "X" ||
                button32.Text == "X" && button38.Text == "X" && button42.Text == "X" ||
                button35.Text == "X" && button45.Text == "X" && button51.Text == "X" ||
                button39.Text == "X" && button48.Text == "X" && button54.Text == "X" ||
                button32.Text == "X" && button45.Text == "X" && button54.Text == "X" ||
                button39.Text == "X" && button45.Text == "X" && button42.Text == "X"
                ))
            {
                foreach (Button x in buttonPermaGroup23)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted23 = true;
                buttonGroup23.Clear();
            }
            else if (!highlighted31 && (
                button55.Text == "X" && button56.Text == "X" && button61.Text == "X" ||
                button58.Text == "X" && button70.Text == "X" && button73.Text == "X" ||
                button67.Text == "X" && button76.Text == "X" && button79.Text == "X" ||
                button55.Text == "X" && button58.Text == "X" && button67.Text == "X" ||
                button56.Text == "X" && button70.Text == "X" && button76.Text == "X" ||
                button61.Text == "X" && button73.Text == "X" && button79.Text == "X" ||
                button55.Text == "X" && button70.Text == "X" && button79.Text == "X" ||
                button61.Text == "X" && button70.Text == "X" && button67.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup31)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted31 = true;
                buttonGroup31.Clear();
            }
            else if (
                !highlighted32 && (
                button57.Text == "X" && button60.Text == "X" && button64.Text == "X" ||
                button63.Text == "X" && button71.Text == "X" && button74.Text == "X" ||
                button68.Text == "X" && button77.Text == "X" && button80.Text == "X" ||
                button57.Text == "X" && button63.Text == "X" && button68.Text == "X" ||
                button60.Text == "X" && button71.Text == "X" && button77.Text == "X" ||
                button64.Text == "X" && button74.Text == "X" && button80.Text == "X" ||
                button57.Text == "X" && button71.Text == "X" && button80.Text == "X" ||
                button64.Text == "X" && button71.Text == "X" && button68.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup32)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted32 = true;
                buttonGroup32.Clear();
            }
            else if (
                !highlighted33 && (
                button59.Text == "X" && button62.Text == "X" && button66.Text == "X" ||
                button65.Text == "X" && button72.Text == "X" && button75.Text == "X" ||
                button69.Text == "X" && button78.Text == "X" && button81.Text == "X" ||
                button59.Text == "X" && button65.Text == "X" && button69.Text == "X" ||
                button62.Text == "X" && button72.Text == "X" && button78.Text == "X" ||
                button66.Text == "X" && button75.Text == "X" && button81.Text == "X" ||
                button59.Text == "X" && button72.Text == "X" && button81.Text == "X" ||
                button66.Text == "X" && button72.Text == "X" && button69.Text == "X")
                )
            {
                foreach (Button x in buttonPermaGroup33)
                {
                    x.BackColor = Color.Cyan;
                    x.Text = "X";
                    x.Enabled = false;
                }
                highlighted33 = true;
                buttonGroup33.Clear();
            }

            //for o in small tic tac toe
            else if (!highlighted11 && (
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup11)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                buttonGroup11.Clear();
                highlighted11 = true;
            }
            else if (!highlighted12 && (
                button10.Text == "O" && button11.Text == "O" && button13.Text == "O" ||
                button12.Text == "O" && button15.Text == "O" && button16.Text == "O" ||
                button14.Text == "O" && button17.Text == "O" && button18.Text == "O" ||
                button10.Text == "O" && button12.Text == "O" && button14.Text == "O" ||
                button11.Text == "O" && button15.Text == "O" && button17.Text == "O" ||
                button13.Text == "O" && button16.Text == "O" && button18.Text == "O" ||
                button10.Text == "O" && button15.Text == "O" && button18.Text == "O" ||
                button13.Text == "O" && button15.Text == "O" && button14.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup12)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                highlighted12 = true;
                buttonGroup12.Clear();

            }
            else if (!highlighted13 && (
                button19.Text == "O" && button20.Text == "O" && button22.Text == "O" ||
                button21.Text == "O" && button24.Text == "O" && button25.Text == "O" ||
                button23.Text == "O" && button26.Text == "O" && button27.Text == "O" ||
                button19.Text == "O" && button21.Text == "O" && button23.Text == "O" ||
                button20.Text == "O" && button24.Text == "O" && button26.Text == "O" ||
                button22.Text == "O" && button25.Text == "O" && button27.Text == "O" ||
                button19.Text == "O" && button24.Text == "O" && button27.Text == "O" ||
                button22.Text == "O" && button24.Text == "O" && button23.Text == "O"))
            {
                foreach (Button x in buttonPermaGroup13)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                buttonGroup13.Clear();
                highlighted13 = true;


            }
            else if (!highlighted21 && (
                button28.Text == "O" && button29.Text == "O" && button34.Text == "O" ||
                button31.Text == "O" && button43.Text == "O" && button46.Text == "O" ||
                button40.Text == "O" && button49.Text == "O" && button52.Text == "O" ||
                button28.Text == "O" && button31.Text == "O" && button40.Text == "O" ||
                button29.Text == "O" && button43.Text == "O" && button49.Text == "O" ||
                button34.Text == "O" && button46.Text == "O" && button52.Text == "O" ||
                button28.Text == "O" && button43.Text == "O" && button52.Text == "O" ||
                button34.Text == "O" && button43.Text == "O" && button40.Text == "O"))
            {
                foreach (Button x in buttonPermaGroup21)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                buttonGroup21.Clear();
                highlighted21 = true;

            }
            else if (!highlighted22 && (
                button30.Text == "O" && button33.Text == "O" && button37.Text == "O" ||
                button36.Text == "O" && button44.Text == "O" && button47.Text == "O" ||
                button41.Text == "O" && button50.Text == "O" && button53.Text == "O" ||
                button30.Text == "O" && button36.Text == "O" && button41.Text == "O" ||
                button33.Text == "O" && button44.Text == "O" && button50.Text == "O" ||
                button37.Text == "O" && button47.Text == "O" && button53.Text == "O" ||
                button30.Text == "O" && button44.Text == "O" && button53.Text == "O" ||
                button37.Text == "O" && button44.Text == "O" && button41.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup22)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                buttonGroup22.Clear();
                highlighted22 = true;

            }
            else if (
                !highlighted23 && (
                button32.Text == "O" && button35.Text == "O" && button39.Text == "O" ||
                button38.Text == "O" && button45.Text == "O" && button48.Text == "O" ||
                button42.Text == "O" && button51.Text == "O" && button54.Text == "O" ||
                button32.Text == "O" && button38.Text == "O" && button42.Text == "O" ||
                button35.Text == "O" && button45.Text == "O" && button51.Text == "O" ||
                button39.Text == "O" && button48.Text == "O" && button54.Text == "O" ||
                button32.Text == "O" && button45.Text == "O" && button54.Text == "O" ||
                button39.Text == "O" && button45.Text == "O" && button42.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup23)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                buttonGroup23.Clear();
                highlighted23 = true ;

            }
            else if (
                !highlighted31 && (
                button55.Text == "O" && button56.Text == "O" && button61.Text == "O" ||
                button58.Text == "O" && button70.Text == "O" && button73.Text == "O" ||
                button67.Text == "O" && button76.Text == "O" && button79.Text == "O" ||
                button55.Text == "O" && button58.Text == "O" && button67.Text == "O" ||
                button56.Text == "O" && button70.Text == "O" && button76.Text == "O" ||
                button61.Text == "O" && button73.Text == "O" && button79.Text == "O" ||
                button55.Text == "O" && button70.Text == "O" && button79.Text == "O" ||
                button61.Text == "O" && button70.Text == "O" && button67.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup31)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                highlighted31 = true;
                buttonGroup31.Clear();

            }
            else if (
                !highlighted32 && (
                button57.Text == "O" && button60.Text == "O" && button64.Text == "O" ||
                button63.Text == "O" && button71.Text == "O" && button74.Text == "O" ||
                button68.Text == "O" && button77.Text == "O" && button80.Text == "O" ||
                button57.Text == "O" && button63.Text == "O" && button68.Text == "O" ||
                button60.Text == "O" && button71.Text == "O" && button77.Text == "O" ||
                button64.Text == "O" && button74.Text == "O" && button80.Text == "O" ||
                button57.Text == "O" && button71.Text == "O" && button80.Text == "O" ||
                button64.Text == "O" && button71.Text == "O" && button68.Text == "O")
                )
            {
                foreach (Button x in buttonPermaGroup32)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                highlighted32 = true;
                buttonGroup32.Clear();

            }
            else if (
                !highlighted33 && (
                button59.Text == "O" && button62.Text == "O" && button66.Text == "O" ||
                button65.Text == "O" && button72.Text == "O" && button75.Text == "O" ||
                button69.Text == "O" && button78.Text == "O" && button81.Text == "O" ||
                button59.Text == "O" && button65.Text == "O" && button69.Text == "O" ||
                button62.Text == "O" && button72.Text == "O" && button78.Text == "O" ||
                button66.Text == "O" && button75.Text == "O" && button81.Text == "O" ||
                button59.Text == "O" && button72.Text == "O" && button81.Text == "O" ||
                button66.Text == "O" && button72.Text == "O" && button69.Text == "O"
                ))
            {
                foreach (Button x in buttonPermaGroup33)
                {
                    x.BackColor = Color.Red;
                    x.Text = "O";
                    x.Enabled = false;
                }
                highlighted33 = true;
                buttonGroup33.Clear();
            }
            //highlightening stops here.



            //EndGameChecks
            if (button5.BackColor == Color.Red && button15.BackColor == Color.Red && button24.BackColor == Color.Red ||
                button43.BackColor == Color.Red && button44.BackColor == Color.Red && button45.BackColor == Color.Red ||
                button70.BackColor == Color.Red && button71.BackColor == Color.Red && button72.BackColor == Color.Red ||
                button5.BackColor == Color.Red && button43.BackColor == Color.Red && button70.BackColor == Color.Red ||
                button15.BackColor == Color.Red && button44.BackColor == Color.Red && button71.BackColor == Color.Red ||
                button24.BackColor == Color.Red && button45.BackColor == Color.Red && button72.BackColor == Color.Red ||
                button5.BackColor == Color.Red && button44.BackColor == Color.Red && button72.BackColor == Color.Red ||
                button24.BackColor == Color.Red && button44.BackColor == Color.Red && button70.BackColor == Color.Red
                )
            {
                CPUtimer.Stop();
                MessageBox.Show("CPU Wins", "Titans Says");
                CPUWinCount++;
                textBox1.Text = $"CPU Wins: {CPUWinCount}";
                RestartGame();
            }
            else if (button5.BackColor == Color.Cyan && button15.BackColor == Color.Cyan && button24.BackColor == Color.Cyan ||
                    button43.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button45.BackColor == Color.Cyan ||
                    button70.BackColor == Color.Cyan && button71.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button5.BackColor == Color.Cyan && button43.BackColor == Color.Cyan && button70.BackColor == Color.Cyan ||
                    button15.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button71.BackColor == Color.Cyan ||
                    button24.BackColor == Color.Cyan && button45.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button5.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button24.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button70.BackColor == Color.Cyan)

            {
                CPUtimer.Stop();
                MessageBox.Show("Player Wins ", "Titans Says");
                playerWinCount++;
                textBox2.Text = $"Player Wins: {playerWinCount}";
                RestartGame();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button81_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void CPUmove(object sender, EventArgs e)
        {
            lastCPUButton = null;
            int totalButtonCount = 0;

            foreach (List<Button> group in buttonGroups)
            {
                totalButtonCount += group.Count;
            }

            CPUhasMOVED = false;

            topleft = false;
            topright = false;
            topmid = false;
            midleft = false;
            midright = false;
            midmid = false;
            botleft = false;
            botright = false;
            botmid = false;
            if (lastPlayerButton == button1 || lastPlayerButton == button10 || lastPlayerButton == button19 ||
                lastPlayerButton == button28 || lastPlayerButton == button30 || lastPlayerButton == button32 ||
                lastPlayerButton == button55 || lastPlayerButton == button57 || lastPlayerButton == button59
                )
            {
                topleft = true;

                if (buttonGroup11.Count > 0 && !highlighted11)
                {
                    Button randomButton = buttonGroup11[random.Next(buttonGroup11.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup11.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach(List<Button> a in buttonGroups)
                    {
                        foreach(Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button2 || lastPlayerButton == button11 || lastPlayerButton == button20 ||
                lastPlayerButton == button29 || lastPlayerButton == button33 || lastPlayerButton == button35 ||
                lastPlayerButton == button56 || lastPlayerButton == button60 || lastPlayerButton == button62)
            {
                topmid = true;

                if (buttonGroup12.Count > 0 && !highlighted12)
                {
                    Button randomButton = buttonGroup12[random.Next(buttonGroup12.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup12.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button3 || lastPlayerButton == button13 || lastPlayerButton == button22 ||
                lastPlayerButton == button34 || lastPlayerButton == button37 || lastPlayerButton == button39 ||
                lastPlayerButton == button61 || lastPlayerButton == button64 || lastPlayerButton == button66)
            {
                topright = true;

                if (buttonGroup13.Count > 0)
                {
                    Button randomButton = buttonGroup13[random.Next(buttonGroup13.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup13.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }


            }
            else if (lastPlayerButton == button4 || lastPlayerButton == button12 || lastPlayerButton == button21 ||
                lastPlayerButton == button31 || lastPlayerButton == button36 || lastPlayerButton == button38 ||
                lastPlayerButton == button58 || lastPlayerButton == button63 || lastPlayerButton == button65)
            {
                midleft = true;

                if (buttonGroup21.Count > 0)
                {
                    Button randomButton = buttonGroup21[random.Next(buttonGroup21.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup21.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button5 || lastPlayerButton == button15 || lastPlayerButton == button24 ||
                lastPlayerButton == button43 || lastPlayerButton == button44 || lastPlayerButton == button45 ||
                lastPlayerButton == button70 || lastPlayerButton == button71 || lastPlayerButton == button72)
            {
                midmid = true;
                if (buttonGroup22.Count > 0)
                {
                    Button randomButton = buttonGroup22[random.Next(buttonGroup22.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup22.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button6 || lastPlayerButton == button16 || lastPlayerButton == button25 ||
                lastPlayerButton == button46 || lastPlayerButton == button47 || lastPlayerButton == button48 ||
                lastPlayerButton == button73 || lastPlayerButton == button74 || lastPlayerButton == button75)
            {
                midright = true;

                if (buttonGroup23.Count > 0)
                {
                    Button randomButton = buttonGroup23[random.Next(buttonGroup23.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup23.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button7 || lastPlayerButton == button14 || lastPlayerButton == button23 ||
                lastPlayerButton == button40 || lastPlayerButton == button41 || lastPlayerButton == button42 ||
                lastPlayerButton == button67 || lastPlayerButton == button68 || lastPlayerButton == button69)
            {
                botleft = true;

                if (buttonGroup31.Count > 0)
                {
                    Button randomButton = buttonGroup31[random.Next(buttonGroup31.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup31.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button8 || lastPlayerButton == button17 || lastPlayerButton == button26 ||
            lastPlayerButton == button49 || lastPlayerButton == button50 || lastPlayerButton == button51 ||
            lastPlayerButton == button76 || lastPlayerButton == button77 || lastPlayerButton == button78)
            {
                botmid = true;

                if (buttonGroup32.Count > 0)
                {
                    Button randomButton = buttonGroup32[random.Next(buttonGroup32.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup32.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if (lastPlayerButton == button9 || lastPlayerButton == button18 || lastPlayerButton == button27 ||
                lastPlayerButton == button52 || lastPlayerButton == button53 || lastPlayerButton == button54 ||
                lastPlayerButton == button79 || lastPlayerButton == button80 || lastPlayerButton == button81)
            {
                botright = true;

                if (buttonGroup33.Count > 0)
                {
                    Button randomButton = buttonGroup33[random.Next(buttonGroup33.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    buttonGroup33.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (totalButtonCount > 0)
                {
                    List<Button> BUTTONSS = new List<Button>();
                    foreach (List<Button> a in buttonGroups)
                    {
                        foreach (Button b in a)
                        {
                            BUTTONSS.Add(b);
                        }
                    }
                    Button randomButton = BUTTONSS[random.Next(BUTTONSS.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    lastCPUButton = randomButton;
                    CPUhasMOVED = true;
                    foreach (var a in buttonGroups)
                    {
                        if (a.Contains(randomButton))
                        {
                            a.Remove(randomButton);
                            break;
                        }
                    }
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }



        }

        private void PlayerClickButton(object sender, EventArgs e)
        {

            List<Button> TargettedGrid11 = new List<Button>() { button1, button10, button19, button28, button30, button32, button55, button57, button59 };
            List<Button> TargettedGrid12 = new List<Button>() { button2, button11, button20, button29, button33, button35, button56, button60, button62 };
            List<Button> TargettedGrid13 = new List<Button>() { button3, button13, button22, button34, button37, button39, button61, button64, button66 };
            List<Button> TargettedGrid21 = new List<Button>() { button4, button12, button21, button31, button36, button38, button58, button63, button65 };
            List<Button> TargettedGrid22 = new List<Button>() { button5, button15, button24, button43, button44, button45, button70, button71, button72 };
            List<Button> TargettedGrid23 = new List<Button>() { button6, button16, button25, button46, button47, button48, button73, button74, button75 };
            List<Button> TargettedGrid31 = new List<Button>() { button7, button14, button23, button40, button41, button42, button67, button68, button69 };
            List<Button> TargettedGrid32 = new List<Button>() { button8, button17, button26, button49, button50, button51, button76, button77, button78 };
            List<Button> TargettedGrid33 = new List<Button>() { button9, button18, button27, button52, button53, button54, button79, button80, button81 };



            var button = (Button)sender;

            currentPlayer = Player.X;
            //restricting players to click in a certain 3x3
            bool correctlyInputed = false;
            if (lastCPUButton != null)
            {
                if (TargettedGrid12.Contains(lastCPUButton) && !buttonGroup12.Contains(button) && !highlighted12||
                    TargettedGrid11.Contains(lastCPUButton) && !buttonGroup11.Contains(button) && !highlighted11||
                    TargettedGrid13.Contains(lastCPUButton) && !buttonGroup13.Contains(button) && !highlighted13||
                    TargettedGrid21.Contains(lastCPUButton) && !buttonGroup21.Contains(button) && !highlighted21||
                    TargettedGrid22.Contains(lastCPUButton) && !buttonGroup22.Contains(button) && !highlighted22||
                    TargettedGrid23.Contains(lastCPUButton) && !buttonGroup23.Contains(button) && !highlighted23||
                    TargettedGrid31.Contains(lastCPUButton) && !buttonGroup31.Contains(button) && !highlighted31||
                    TargettedGrid32.Contains(lastCPUButton) && !buttonGroup32.Contains(button) && !highlighted32||
                    TargettedGrid33.Contains(lastCPUButton) && !buttonGroup33.Contains(button) && !highlighted33)
                {
                    MessageBox.Show("Invalid Input.\nPlease Click the correct BUTTON in the correct 3x3 GRID", "Angry Titans");
                    return; 
                }
            }


            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.LightCyan;
            buttons.Remove(button);
            foreach (var a in buttonGroups)
            {
                if (a.Contains(button))
                {
                    a.Remove(button);
                    break;
                }
            }
            CheckGame();
            CPUtimer.Start();
            lastPlayerButton = button;
        }

        private List<Button> GetTargetGrid(Button lastMove)
        {
            if (buttonGroup11.Contains(lastMove)) return buttonGroup11;
            if (buttonGroup12.Contains(lastMove)) return buttonGroup12;
            if (buttonGroup13.Contains(lastMove)) return buttonGroup13;
            if (buttonGroup21.Contains(lastMove)) return buttonGroup21;
            if (buttonGroup22.Contains(lastMove)) return buttonGroup22;
            if (buttonGroup23.Contains(lastMove)) return buttonGroup23;
            if (buttonGroup31.Contains(lastMove)) return buttonGroup31;
            if (buttonGroup32.Contains(lastMove)) return buttonGroup32;
            if (buttonGroup33.Contains(lastMove)) return buttonGroup33;

            return null; 
        }

        private void RestartGAME(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
