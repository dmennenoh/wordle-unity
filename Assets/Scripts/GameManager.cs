using UnityEngine;

namespace wordleUnity
{
    public class GameManager : MonoBehaviour
    {        
        [SerializeField] private int startYear;        
        [SerializeField] private InputManager inputManager;
        [SerializeField] private MessageManager messageManager;
        [SerializeField] private KeyboardManager keyboardManager;
        [SerializeField] private Board gameBoard;//empty parent containing the Board component/class

        private string todaysWord;
        private string userWord;
        private int guessIndex; //which word guess the user is on 0 - 5
        private int charIndex; //which letter in the word 0 - 4       
    

        private void Start()
        {
            todaysWord = WordUtilities.GetTodaysWord(startYear);            
            ResetGame();
        }


        private void processInput()  
        {            
            char userLetter = inputManager.LastChar;              

            //Check for backspace
            if(userLetter == '\b')
            {
                charIndex--;
                if (charIndex < 0)
                {
                    charIndex = 0;
                }
                gameBoard.Rows[guessIndex].Tiles[charIndex].Letter = "";
                gameBoard.Rows[guessIndex].Tiles[charIndex].SetDarkOutline();
            }
            else if(userLetter == '\n')
            {
                //User pressed enter/return - if all letters aren't in then we don't care
                if(charIndex == 5)
                {
                    userWord = gameBoard.Rows[guessIndex].Tiles[0].Letter + gameBoard.Rows[guessIndex].Tiles[1].Letter + gameBoard.Rows[guessIndex].Tiles[2].Letter + gameBoard.Rows[guessIndex].Tiles[3].Letter + gameBoard.Rows[guessIndex].Tiles[4].Letter;

                    if (!WordUtilities.IsInDictionary(userWord))
                    {
                        //show popup saying the word is not in the word list
                        messageManager.showMessage("not in word list");
                        gameBoard.Rows[guessIndex].Shake();
                    }
                    else
                    {
                        char[] tempWord = todaysWord.ToCharArray();
                        //word is in the list - do color checks - increment guessIndex                       
                        Tile[] guessWord = gameBoard.Rows[guessIndex].Tiles;
                        //first check for exact matches
                        for (int i = 0; i < 5; i++)
                        {
                            if (guessWord[i].Letter == tempWord[i].ToString())
                            {
                                guessWord[i].MarkGreen();
                                tempWord[i] = '.';
                            }
                        }

                        //check for the letter just being in the word
                        for (int i = 0; i < 5; i++)
                        {
                            string l = guessWord[i].Letter;
                            for(int j = 0; j < 5; j++)
                            {
                                if (tempWord[j].ToString() == l)
                                {
                                    tempWord[j] = '.';
                                    guessWord[i].MarkYellow();
                                    break;
                                }
                            }                            
                        }
                        
                        //other letters are just marked gray as they are not in the word
                        for (int i = 0; i < 5; i++)
                        {
                            if(!guessWord[i].IsInWord)
                            {
                                guessWord[i].MarkGray();
                            }
                        }

                        //tiles have been marked - call them in order with a slight delay for the reveal
                        float delay = 0;
                        for(int i = 0; i < userWord.Length; i++)
                        {
                            guessWord[i].SetColor(delay);
                            delay += .20f;

                            keyboardManager.SetKeyState(guessWord[i].Letter, guessWord[i].GetColorChar());
                        }

                        if(userWord == todaysWord)
                        {
                            switch (guessIndex)
                            {
                                case 0:
                                    messageManager.showMessage("Genius");
                                    break;
                                case 1:
                                    messageManager.showMessage("Magnificent");
                                    break;
                                case 2:
                                    messageManager.showMessage("Impressive");
                                    break;
                                case 3:
                                    messageManager.showMessage("Splendid");
                                    break;
                                case 4:
                                    messageManager.showMessage("Great");
                                    break;
                                case 5:
                                    messageManager.showMessage("PHEW");
                                    break;
                            }
                            InputManager.OnKeypress -= processInput;
                        }
                        else
                        {
                            guessIndex++;
                            charIndex = 0;
                            if(guessIndex > 5)
                            {
                                //game over - they failed to guess
                                InputManager.OnKeypress -= processInput;
                                messageManager.showMessage(todaysWord);
                            }
                        }                       
                     }
                }
                else
                {
                    messageManager.showMessage("not enough letters");
                    gameBoard.Rows[guessIndex].Shake();
                }
            }
            else if(charIndex < 5 && char.IsLetter(userLetter))
            {
                gameBoard.Rows[guessIndex].Tiles[charIndex].Letter = userLetter.ToString();
                gameBoard.Rows[guessIndex].Tiles[charIndex].SetLightOutline();
                charIndex++;
            }
        }


        //Resets all the letter tiles to blank and the panel background to the dark gray outline
        private void ResetGame()
        {
            guessIndex = 0; //row Index
            charIndex = 0; //column index
            userWord = "";

            Row[] rows = gameBoard.Rows;

            for(int i = 0; i < rows.Length; i++)
            {
                Tile[] tiles = rows[i].Tiles;
                for(int j = 0; j < tiles.Length; j++)
                {
                    tiles[j].Letter = "";
                    tiles[j].SetDarkOutline();
                }               
            }

            InputManager.OnKeypress += processInput;
        }       
    }
}
