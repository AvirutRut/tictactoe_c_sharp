using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TicTacToe : Form
    {
        //language of the game
        private int language = 0; //0:english, 1:french
        //level of the game
        private int level = 1; //0:easy, 1:medium, 2:hard
        //opponent of the X player
        private int opponent = 1; //0:other user, 1:computer
        private int turn = 0;
        private int playerXPts = 0;
        private int playerOPts = 0;
        //stores chosen button moves
        private long moves = 0;
        //how many times playerX clicked on the undo button
        private int undoUserX = 0;
        //how many times playerO clicked on the undo button
        private int undoUserO = 0;
        //terms when user finishes the round
        private String termsEng = "\nTo exit this game " +
                 "click on exit.\nTo start a new round" +
                 " click on start.";
        private String termsFr = "\nPour finir ce jeu " +
                 "ou commencer la nouvelle série " +
                 "cliquez le bouton correspondant.";

        public TicTacToe()
        {
            InitializeComponent();
        }

        /**
         * Examines whether there is a winning position.
         */
        private bool checkWin()
        {
            //check horizontally
            if (btn1.Text.Equals(btn2.Text)
                && btn1.Text.Equals(btn3.Text)
                && (isTaken(1)))
            {
                changeColor(1, 2, 3);
                return true;
            }
            if (btn4.Text.Equals(btn5.Text)
                && btn4.Text.Equals(btn6.Text)
                && (isTaken(4)))
            {
                changeColor(4, 5, 6);
                return true;
            }
            if (btn7.Text.Equals(btn8.Text)
                && btn7.Text.Equals(btn9.Text)
                && (isTaken(7)))
            {
                changeColor(7, 8, 9);
                return true;
            }
         
            //check vertically
            if (btn1.Text.Equals(btn4.Text)
                && btn1.Text.Equals(btn7.Text)
                && (isTaken(1)))
            {
                changeColor(1, 4, 7);
                return true;
            }
            if (btn2.Text.Equals(btn5.Text)
                && btn2.Text.Equals(btn8.Text)
                && (isTaken(2)))
            {
                changeColor(2, 5, 8);
                return true;
            }
            if (btn3.Text.Equals(btn6.Text)
                && btn3.Text.Equals(btn9.Text)
                && (isTaken(3)))
            {
                changeColor(3, 6, 9);
                return true;
            }

            //check diagonally
            if (btn1.Text.Equals(btn5.Text)
                && btn1.Text.Equals(btn9.Text)
                && (isTaken(1)))
            {
                changeColor(1, 5, 9);
                return true;
            }
            if (btn3.Text.Equals(btn5.Text)
                && btn3.Text.Equals(btn7.Text)
                && (isTaken(3)))
            {
                changeColor(3, 5, 7);
                return true;
            }

            return false;
        }

        /**
         * Changes the color of the winning row/column/diagonal.
         * 
         * @param b1 The integer number of the first button in a sequence.
         * @param b2 The integer number of the second button in a sequence.
         * @param b3 The integer number of the third button in a sequence.
         */
        private void changeColor(int b1, int b2, int b3)
        {
            ((Button)Controls["btn" + b1]).BackColor = Color.DarkOrange;
            ((Button)Controls["btn" + b2]).BackColor = Color.DarkOrange;
            ((Button)Controls["btn" + b3]).BackColor = Color.DarkOrange;
        }

        /**
         * Verifies whether given button is already taken.
         * 
         * @param num The integer number of the button.
         * 
         * @return true if button is already used;
         *         false otherwise.
         */
        private bool isTaken(int num)
        {
            Button btn = (Button)Controls["btn" + num];

            if (btn.Text.Equals("") || btn.Text.Equals("!"))
                return false;
            else
                return true;
        }

        /**
         * Performs tasks connected to user's choice of the button, i.e.
         * verifies whether the button is available, whether there is a winning
         * sequence for the player as a result of this choice, and indicates
         * player whose turn is the next one.
         */
        private void btn_Click(object sender, EventArgs e)
        {
            String currentPlayer = findPlayer(turn);
            
            var btn = (Button)sender;

            int b = (int)Char.GetNumericValue(btn.Name[3]);
            if (!isTaken(b))
            {
                moves = moves * 10 + b;
                btn.Text = currentPlayer;
                disableBoard();
                turn++;
                if (checkWin())
                {
                    btnUndo.Enabled = false;
                    if(language == 0)
                        MessageBox.Show("Player " + currentPlayer + " has won this game!" + termsEng);
                    else
                        MessageBox.Show("Joueur " + currentPlayer + " a gangné ce jeu!" + termsFr);
                    btnExit.Enabled = true;
                    if (currentPlayer.Equals("X"))
                        playerXPts++;
                    else
                        playerOPts++;
                    displayResults();
                }
                else
                {
                    if (turn > 8)
                    {
                        btnUndo.Enabled = false;
                        btnExit.Enabled = true;
                        if (language == 0)
                            MessageBox.Show("It's a draw!" + termsEng);
                        else
                            MessageBox.Show("Match nul!" + termsFr);
                        disableBoard();
                    }
                    else if (opponent == 0)
                    {
                        String player = findPlayer(turn);
                        if (language == 0)
                             MessageBox.Show("This is player " + player + " turn.");
                        else
                             MessageBox.Show("C'est la tour du joueur " + player + ".");

                        enableBoard();
                    }
                    else
                    {
                        computerTurn();
                        turn++;
                    }
                }
            }
            else
            {
                if(language == 0)
                    MessageBox.Show ("The position is already used!");
                else
                    MessageBox.Show ("Cette position est déjà utilisée!");
            }
        }

        /**
         * Finds current player according to the turn value.
         * 
         * @param turn Current turn value.
         * 
         * @return current player, which could be X or O.
         */
        private String findPlayer(int turn)
        {
            if (turn % 2 == 0)
                return "X";
            else
                return "O";
        }

        /**
         * Sets and displays computer's choice according to the chosen level
         * of difficulty. Checks whether this choice led to a win.
         */
        private void computerTurn()
        {
            int choice = 0;

            if (level == 0)
                choice = compEasy();
            else if (level == 1)
                choice = compMedium();
            else
                choice = compHard();
            
            ((Button)Controls["btn" + choice]).Text = "O";
            moves = moves * 10 + choice;

            if (checkWin())
            {
                btnUndo.Enabled = false;
                if(language == 0)
                    MessageBox.Show("Computer has won this game!" + termsEng);
                else
                    MessageBox.Show("L'ordinateur a gangé ce jeu!" + termsFr);
                playerOPts++;
                displayResults();
                btnExit.Enabled = true;
            }
            else
                enableBoard();

            
        }

        /**
         * Randomly assigns computer's choice.
         * 
         * @return computer's choice.
         */
        private int compEasy()
        {
            Random random = new Random();
            int choice = 0;
            do
            {
                choice = random.Next(1, 10);
            } while (isTaken(choice));

            return choice;
        }

        /**
         * Peforms tasks connected to the start of the game, i.e.
         * displays welcome message indicating the opponent and level
         * if this is a first game and clears the board.
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (turn == 0)
            {
                String oppStr;
                String str = "";
                if (language == 0)
                {
                    if (opponent == 0)
                    {
                        oppStr = "Human To Human game.";
                        str = " before the other player has made a choice";
                    }
                    else
                        oppStr = "Human To Computer game and " + levelToString() + " level.";

                    MessageBox.Show("You have chosen " + oppStr + "\nYou can undo your move only once per round" + str + ".");
                }
                else
                {
                    if (opponent == 0) 
                    {
                        oppStr = "Le Jouer comme l'adversaire.";
                        str = " avant que l'autre joueur choisisse son mouvement";
                    }
                    else
                        oppStr = "L'Ordinateur comme l'adversaire et " + "le niveau " + levelToString() + ".";

                    MessageBox.Show("Vous avez choisi " + oppStr + "\nVous pouvez annuler son choix seulement une fois par la série" + 
						str + ".");
                }
            }

            for (int i = 1; i < 10; i++)
                ((Button)Controls["btn" + i]).BackColor = Color.LimeGreen;
            clearBoard();
            moves = 0;
            undoUserX = 0;
            undoUserO = 0;
            turn = 0;
            if (language == 0)
                MessageBox.Show("Player X starts the game.");
            else
                MessageBox.Show("Joueur X commence le jeu.");
            enableBoard();
            btnExit.Enabled = false;
            btnUndo.Enabled = true;
        }

        /**
         * Clears the board.
         */
        private void clearBoard()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        /**
         * Disables board buttons.
         */
       private void disableBoard()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

       /**
        * Enables board buttons.
        */
       private void enableBoard()
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
       }

        /**
         * Converts integer level value to the word notation depending
         * on the previously chosen language.
         * 
         * @return level value as a string.
         */
        private String levelToString()
        {
            if (language == 0) {
                switch (level)
                {
                    case 1: return "Medium";
                    case 2: return "Hard";
                    default: return "Easy";
                }
            }
            else
            {
                switch (level)
                {
                    case 1: return "Médium";
                    case 2: return "Difficile";
                    default: return "Facile";
                }
            }
        }

        /**
         * Performs tasks connected to the exit button, that is
         * displays results and clears the board.
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(language == 0)
                MessageBox.Show("The results for this game:\n\nPlayer X:       " +
                    playerXPts + "\n\n" + 
                    (opponent == 0 ? "Player O:       " : "Computer:   ") + playerOPts);
            else
                MessageBox.Show("Les résultats pour ce jeu sont:\n\nJoueur X:         " +
                    playerXPts + "\n\n" +
                    (opponent == 0 ? "Joueur O:         " : "L'ordinateur:   ") + playerOPts);
            setDefault();
        }

        /**
         * Displays results to the text boxes on the form.
         */
        private void displayResults()
        {
            txtPlayerXResult.Text = playerXPts + "";
            txtPlayerOResult.Text = playerOPts + "";
        }

        /**
         * Sets all values to default.
         */
        private void setDefault()
        {
            clearBoard();
            turn = 0;
            moves = 0;
            playerXPts = 0;
            playerOPts = 0;
            undoUserX = 0;
            undoUserO = 0;
            displayResults();

            for (int i = 1; i < 10; i++)
                ((Button)Controls["btn" + i]).BackColor = Color.LimeGreen;
        }

        /**
         * Sets the opponent to be the user.
         */
        private void btnHumanToHuman_Click(object sender, EventArgs e)
        {
            opponent = 0;
            if(language == 0)
                lblPlayerO.Text = "   Player O: ";
            else
             lblPlayerO.Text = "   Joueur O: ";
            setDefault();
        }

        /**
         * Sets the opponent to be the computer.
         */
        private void btnHumanToComputer_Click(object sender, EventArgs e)
        {
            opponent = 1;
            if(language == 0)
                lblPlayerO.Text = "Computer: ";
            else
                lblPlayerO.Text = "L'ordinateur: ";
            setDefault();
        }

        /**
         * Sets game level to easy.
         */
        private void radioEasy_CheckedChanged(object sender, EventArgs e)
        {
            level = 0;
            opponent = 1;
            setDefault();
        }

        /**
         * Sets game level to medium.
         */
        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            level = 1;
            opponent = 1;
            setDefault();
        }

        /**
         * Sets game level to hard.
         */
        private void radioHard_CheckedChanged(object sender, EventArgs e)
        {
            level = 2;
            opponent = 1;
            setDefault();
        }

        /**
         * Undoes last user's move when the opponent is the other user and
         * undoes computer's move as well as user's last move when the opponent
         * is the computer.
         * The player is allowed only one undo per round.
         */
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (turn >= 1)
            {
                
                int user = 0;
                if (opponent == 1)
                {
                    //undo last computer and user moves
                    turn -= 2;
                    int comp = (int)(moves % 10);
                    user = (int)(moves / 10 % 10);
                    ((Button)Controls["btn" + comp]).Text = "";
                    ((Button)Controls["btn" + user]).Text = "";
                    btnUndo.Enabled = false;
                }
                else
                {
                    //undo last user move
                    if (turn % 2 != 0)
                    {
                        undoUserX++;
                        if (undoUserX < 2)
                            undoUser();
                        else
                        {
                            if (language == 0)
                                MessageBox.Show("Player X, you've already used this feature!");
                            else
                                MessageBox.Show("Joueur X, vous avez déjà utilisé ce bouton!");
                        }

                    }
                    else
                    {
                        undoUserO++;
                        if (undoUserO < 2)
                            undoUser();
                        else
                        {
                            if (language == 0)
                                MessageBox.Show("Player O, you've already used this feature!");
                            else
                                MessageBox.Show("Joueur O, vous avez déjà utilisé ce bouton!");
                        }
                    }

                    if (undoUserX >= 1 && undoUserO >= 1)
                        btnUndo.Enabled = false;
                }
                
            }
        }

        /**
         * Undoes user's move.
         */
        private void undoUser()
        {
            turn--;
            int user = (int)(moves % 10);
            ((Button)Controls["btn" + user]).Text = "";
        }

        /**
         * Displays an exlamation mark if user clicked on the unused button
         * with the right click.
         */
        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                if (b.Text.Equals(""))
                    b.Text = "!";
            }
        }

        /**
         * Returns computer's choice for the hard level.
         * 
         * @return computer's choice for the hard level.
         */
        private int compHard()
        {
            int choice = 0;
            if (turn >= 5)
            {
                //check if computer has 2 values to complete
                choice = checkTwoValuesInLine("O");
                if (choice != -1)
                    return choice;
            }
            if (turn >= 3)
            {
                //decides whether it's necessary to block the user
                choice = checkTwoValuesInLine("X");
                if (choice != -1)
                    return choice;
            }

            if(turn == 1 && !isTaken(5))
                return 5;

            //fork check
            if (turn == 1 && btn5.Text.Equals("X"))
				return fork5();
                
            choice = forkCorner();
            if (choice != -1)
                return choice;

            choice = forkEdge();
            if (choice != -1)
                return choice;

            //add second value to the computer row
            choice = addSecondValue();
            if (choice != -1)
                return choice;

            return compEasy();         
        }

        /**
         * Verifies whether user created a "fork" (i.e. 2 winning sequences 
         * at one time) and blocks it. Checks the possibility of fork
         * created from the corners.
         * 
         * @return the position to block user's fork; -1 if such fork is not found.
         */
        private int forkCorner()
        {
            if (btn9.Text.Equals("X") && btn2.Text.Equals("X")
                && (!isTaken(3)))
                return 3;

            if (btn3.Text.Equals("X") && btn4.Text.Equals("X")
                && (!isTaken(1)))
                return 1;

            if (btn1.Text.Equals("X") && btn9.Text.Equals("X")
               && (!isTaken(8)))
                return 8;

            if (btn3.Text.Equals("X") && btn7.Text.Equals("X")
               && (!isTaken(4)))
                return 4;

            return -1;
        }

        /**
         * Verifies whether user created a "fork" (i.e. 2 winning sequences 
         * at one time) and blocks it. Checks the possibility of fork
         * created from the edges.
         * 
         * @return the position to block user's fork; -1 if such fork is not found.
         */
        private int forkEdge()
        {
            if (btn8.Text.Equals("X") && btn6.Text.Equals("X")
                && (!isTaken(9)))
                return 9;

            if (btn2.Text.Equals("X") && btn4.Text.Equals("X")
                && (!isTaken(1)))
                return 1;

            if (btn6.Text.Equals("X") && btn2.Text.Equals("X")
                && (!isTaken(3)))
                return 3;

            return -1;
        }

        /**
         * Verifies whether user created a "fork" (i.e. 2 winning sequences 
         * at one time) and blocks it. Checks the possibility of fork created
         * from the center.
         * 
         * @return the position to block user's fork; -1 if such fork is not found.
         */
        private int fork5()
        {
			Random random = new Random();
			int i = 5;
			while (i == 5)
				i = random.Next(0, 5) * 2 + 1;
			return i;
        }

        /**
         * Returns computer's choice for the medium level.
         * 
         * @return computer's choice for the medium level.
         */
        private int compMedium()
        {
            int choice = checkTwoValuesInLine("X");
            if (choice != -1)
                return choice;
            else
                return compEasy();
        }

        /**
         * Verifies whether there are two positions with the same value.
         * 
         * @param str Indicates whose positions are investigated; X for the user
         *            and O for the computer.
         * 
         * @return the third position in such sequence; -1 if this is not
         *         the case.
         */
        private int checkTwoValuesInLine(String str)
        {
            //to check rows
            if (btn1.Text.Equals(btn2.Text)
               && (!isTaken(3))
               && btn1.Text.Equals(str))
                return 3;
            if (btn2.Text.Equals(btn3.Text)
               && (!isTaken(1))
               && btn2.Text.Equals(str))
                return 1;
            if (btn3.Text.Equals(btn1.Text)
               && (!isTaken(2))
               && btn1.Text.Equals(str))
                return 2;

            if (btn4.Text.Equals(btn5.Text)
              && (!isTaken(6))
              && btn4.Text.Equals(str))
                return 6;
            if (btn5.Text.Equals(btn6.Text)
               && (!isTaken(4))
               && btn5.Text.Equals(str))
                return 4;
            if (btn4.Text.Equals(btn6.Text)
               && (!isTaken(5))
               && btn4.Text.Equals(str))
                return 5;

            if (btn7.Text.Equals(btn8.Text)
              && (!isTaken(9))
              && btn7.Text.Equals(str))
                return 9;
            if (btn7.Text.Equals(btn9.Text)
               && (!isTaken(8))
               && btn7.Text.Equals(str))
                return 8;
            if (btn8.Text.Equals(btn9.Text)
               && (!isTaken(7))
               && btn8.Text.Equals(str))
                return 7;

            //to check columns
            if (btn1.Text.Equals(btn4.Text)
               && (!isTaken(7))
               && btn1.Text.Equals(str))
                return 7;
            if (btn4.Text.Equals(btn7.Text)
               && (!isTaken(1))
               && btn4.Text.Equals(str))
                return 1;
            if (btn7.Text.Equals(btn1.Text)
               && (!isTaken(4))
               && btn1.Text.Equals(str))
                return 4;

            if (btn2.Text.Equals(btn5.Text)
              && (!isTaken(8))
              && btn2.Text.Equals(str))
                return 8;
            if (btn5.Text.Equals(btn8.Text)
               && (!isTaken(2))
               && btn5.Text.Equals(str))
                return 2;
            if (btn2.Text.Equals(btn8.Text)
               && (!isTaken(5))
               && btn2.Text.Equals(str))
                return 5;

            if (btn3.Text.Equals(btn6.Text)
              && (!isTaken(9))
              && btn3.Text.Equals(str))
                return 9;
            if (btn3.Text.Equals(btn9.Text)
               && (!isTaken(6))
               && btn3.Text.Equals(str))
                return 6;
            if (btn6.Text.Equals(btn9.Text)
               && (!isTaken(3))
               && btn6.Text.Equals(str))
                return 3;

            //to check diagonally
            if (btn1.Text.Equals(btn5.Text)
              && (!isTaken(9))
              && btn1.Text.Equals(str))
                return 9;
            if (btn5.Text.Equals(btn9.Text)
               && (!isTaken(1))
               && btn5.Text.Equals(str))
                return 1;
            if (btn9.Text.Equals(btn1.Text)
               && (!isTaken(5))
               && btn9.Text.Equals(str))
                return 5;

            if (btn3.Text.Equals(btn5.Text)
              && (!isTaken(7))
              && btn3.Text.Equals(str))
                return 7;
            if (btn5.Text.Equals(btn7.Text)
               && (!isTaken(3))
               && btn5.Text.Equals(str))
                return 3;
            if (btn3.Text.Equals(btn7.Text)
               && (!isTaken(5))
               && btn3.Text.Equals(str))
                return 5;

            return -1;
        }

        /**
         * Displays english text.
         */
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            language = 0;
            level = 1;
            setDefault();
            //enable english text
            btnExit.Text = "Exit";
            btnHumanToComputer.Text = "Human To Computer";
            btnHumanToHuman.Text = "Human To Human";
            btnStart.Text = "Start new round";
            btnUndo.Text = "Undo";
            lblGameType.Text = "Choose opponent:";
            lblLevel.Text = "Choose level:";
            lblPlayerX.Text = "Player X: ";
            lblPlayerO.Text = "Computer: ";
            lblResults.Text = "Results for the game:";
            radioEasy.Text = "Easy";
            radioMedium.Text = "Medium";
            radioHard.Text = "Hard";
            radioMedium.Checked = true;
        }

        /**
         * Displays french text.
         */
        private void btnFrench_Click(object sender, EventArgs e)
        {
            language = 1;
            level = 1;
            setDefault();
            //enable french text
            btnExit.Text = "Finir le jeu";
            btnHumanToComputer.Text = "Contre l'ordinateur";
            btnHumanToHuman.Text = "Contre le joueur";
            btnStart.Text = "Commencer la nouvelle série";
            btnUndo.Text = "Annuler";
            lblGameType.Text = "Choisir l'adversaire:";
            lblLevel.Text = "Choisir la difficulté:";
            lblPlayerX.Text = "Joueur X: ";
            lblPlayerO.Text = "L'ordinateur: ";
            lblResults.Text = "Les résultats pour le jeu:";
            radioEasy.Text = "Facile";
            radioMedium.Text = "Médium";
            radioHard.Text = "Difficile";
            radioMedium.Checked = true;
        }

        /**
         * Adds second value to the sequence for the computer
         * in order to form a winning sequence.
         * 
         * @return such postion; -1 if none found.
         */
        private int addSecondValue()
        {
            //add second value to the row              
            //to check rows              
            if ((!isTaken(2))
                  && btn3.Text.Equals("O")
                  && (!isTaken(1)))
                return 1;
            if ((!isTaken(3))
                   && btn1.Text.Equals("O")
                   && (!isTaken(2)))
                return 3;
            if ((!isTaken(3))
                   && btn2.Text.Equals("O")
                   && (!isTaken(1)))
                return 1;
            if ((!isTaken(6))
                   && btn5.Text.Equals("O")
                   && (!isTaken(4)))
                return 6;
            if ((!isTaken(8))
                  && btn9.Text.Equals("O")
                  && (!isTaken(7)))
                return 7;
            if ((!isTaken(9))
                   && btn8.Text.Equals("O")
                   && (!isTaken(7)))
                return 7;
            if ((!isTaken(9))
                   && btn7.Text.Equals("O")
                   && (!isTaken(8)))
                return 9;
            //to check columns                
            if ((!isTaken(4))
                   && btn7.Text.Equals("O")
                   && (!isTaken(1)))
                return 1;
            if ((!isTaken(7))
                   && btn1.Text.Equals("O")
                   && (!isTaken(4)))
                return 7;
            if ((!isTaken(7))
                   && btn4.Text.Equals("O")
                   && (!isTaken(1)))
                return 1;
            if ((!isTaken(8))
                   && btn5.Text.Equals("O")
                   && (!isTaken(2)))
                return 2;
            if ((!isTaken(6))
                  && btn9.Text.Equals("O")
                  && (!isTaken(3)))
                return 3;
            if ((!isTaken(9))
                   && btn6.Text.Equals("O")
                   && (!isTaken(3)))
                return 3;
            if ((!isTaken(9))
                   && btn3.Text.Equals("O")
                   && (!isTaken(6)))
                return 9;
            //to check diagonally                
            if ((!isTaken(1))
                   && btn5.Text.Equals("O")
                   && (!isTaken(9)))
                return 1;
            if ((!isTaken(7))
                   && btn5.Text.Equals("O")
                   && (!isTaken(3)))
                return 3;

            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            language = 0;
            level = 1;
            setDefault();
            //enable english text
            btnExit.Text = "ออก";
            btnHumanToComputer.Text = "ผู้เล่น VS คอมพิวเตอร์";
            btnHumanToHuman.Text = "ผู้เล่น1 VS ผู้เล่น2";
            btnStart.Text = "เริ่มเกมส์";
            btnUndo.Text = "ย้อนกลับ";
            lblGameType.Text = "ตัวเลือก:";
            lblLevel.Text = "ระดับเลเวล:";
            lblPlayerX.Text = "ผู้เล่น x: ";
            lblPlayerO.Text = "คอมพิวเตอร์: ";
            lblResults.Text = "คะแนน:";
            radioEasy.Text = "ระดับกาก";
            radioMedium.Text = "ระดับกลาง";
            radioHard.Text = "ระดับยาก";
            radioMedium.Checked = true;
        }
    }

}
