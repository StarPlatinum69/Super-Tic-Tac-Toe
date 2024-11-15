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
        int CPUWintCount = 0;

        List<Button> buttons;

        Button lastPlayerButton;

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



        public void InitialButtonGroups()
        {
             buttonGroup11 = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9};
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
                                                     buttonGroup32, buttonGroup33   };
        }
        

        public SuperTC1()
        {
            
            InitializeComponent();
            InitialButtonGroups();
            RestartGame();
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
        }

        private void CheckGame()
        {
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

            }
            else if(button5.BackColor == Color.Cyan && button15.BackColor == Color.Cyan && button24.BackColor == Color.Cyan ||
                    button43.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button45.BackColor == Color.Cyan ||
                    button70.BackColor == Color.Cyan && button71.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button5.BackColor == Color.Cyan && button43.BackColor == Color.Cyan && button70.BackColor == Color.Cyan ||
                    button15.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button71.BackColor == Color.Cyan ||
                    button24.BackColor == Color.Cyan && button45.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button5.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button72.BackColor == Color.Cyan ||
                    button24.BackColor == Color.Cyan && button44.BackColor == Color.Cyan && button70.BackColor == Color.Cyan)

            {
            
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
            bool available;
            bool topleft = false, topright = false, topmid = false, midleft = false, midright = false, midmid = false, botleft = false, botright = false, botmid = false;
            if(lastPlayerButton == button1 || lastPlayerButton == button10 || lastPlayerButton == button19 || 
                lastPlayerButton == button28 || lastPlayerButton == button30 || lastPlayerButton == button32 ||
                lastPlayerButton == button55 || lastPlayerButton == button57 || lastPlayerButton == button59
                )
            {
                topleft = true;

                if (buttonGroup11.Count > 0)
                {
                    Button randomButton = buttonGroup11[random.Next(buttonGroup11.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    buttonGroup11.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if(buttons.Count>0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button2 || lastPlayerButton == button11 || lastPlayerButton == button20 ||
                lastPlayerButton == button29 || lastPlayerButton == button33 || lastPlayerButton == button35 ||
                lastPlayerButton == button56 || lastPlayerButton == button60 || lastPlayerButton == button62)
            {
                topmid = true;

                if (buttonGroup12.Count > 0)
                {
                    Button randomButton = buttonGroup12[random.Next(buttonGroup12.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    buttonGroup12.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button3 || lastPlayerButton == button13 || lastPlayerButton == button22 ||
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
                    buttonGroup13.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }


            }
            else if(lastPlayerButton == button4 || lastPlayerButton == button12 || lastPlayerButton == button21 ||
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
                    buttonGroup21.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button5 || lastPlayerButton == button15 || lastPlayerButton == button24 ||
                lastPlayerButton == button43|| lastPlayerButton == button44 || lastPlayerButton == button45 ||
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
                    buttonGroup22.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button6 || lastPlayerButton == button16 || lastPlayerButton == button25 ||
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
                    buttonGroup23.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button7 || lastPlayerButton == button14 || lastPlayerButton == button23 ||
                lastPlayerButton == button40 || lastPlayerButton == button41 || lastPlayerButton == button42 ||
                lastPlayerButton == button67|| lastPlayerButton == button68 || lastPlayerButton == button69)
            {
                botleft = true;

                if (buttonGroup31.Count > 0)
                {
                    Button randomButton = buttonGroup31[random.Next(buttonGroup31.Count)];
                    randomButton.Enabled = false;
                    currentPlayer = Player.O;
                    randomButton.Text = currentPlayer.ToString();
                    randomButton.BackColor = Color.IndianRed;
                    buttonGroup31.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
                else if(lastPlayerButton == button8 || lastPlayerButton == button17 || lastPlayerButton == button26 ||
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
                    buttonGroup32.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }
            else if(lastPlayerButton == button9 || lastPlayerButton == button18 || lastPlayerButton == button27 ||
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
                    buttonGroup33.Remove(randomButton);
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
                else if (buttons.Count > 0)
                {
                    Button randomButton = buttons[random.Next(buttons.Count)];
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
                    buttons.Remove(randomButton);
                    CheckGame();
                    CPUtimer.Stop();
                }
            }



        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;

            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.LightCyan;
            buttons.Remove(button);
            foreach(var a in buttonGroups)
            {
                if(a.Contains(button))
                {
                    a.Remove(button);
                    break;
                }
            }
            CheckGame();
            CPUtimer.Start();
            lastPlayerButton = button;
        }

        private void RestartGAME(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
