using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A class to hold the specified information for a computer player.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class ComputerPlayer:Player //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    
    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public
    /// Declare and Define a function: 
    ///     permission returnType functionName (parameterType parameterName){...return variable_value}

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    private int _cdw_difficulty;
    

    //////////// Instance Methods ///////////////////
    /// Methods Permission Order: private, protected, public
    /// Declare and Define a function: 
    ///     permission returnType functionName (parameterType parameterName){...return variable_value}

    /////////// Input Functions ////////////////////////
    // If immutable use constructors to initialze class
        //  Constructors: default, parameter, copy
        //  default: permission className () {...//initialize all attributes}
        //  parameter: permission className (parameterType parameterName, ...){.../use parameter to initialize attributes}
        //  copy: permission className (className parameterName){.../use class getters/attributes to initialize attributes}
        
    
    // If mutable, use Setters to initialize class
    public void cdw_SetDifficulty(int cdw_difficulty)
    {
        _cdw_difficulty = cdw_difficulty;
    }

    ///////////  Process State Functions /////////////////
    /// if class is mutable, used process functions: map, filter, reduce types
    /// if class is immutable, the process functions should be done either with constructors or toString

    ////////// Output Functions ///////////////////////
    // default functions
        // If mutable
        //  public string toString(){...} //defines 
        // if immutable
        //  getters if class is mutable
    public string cdw_RPSAction(string cdw_playerChoice)
    {
        Random cdw_random = new Random();
        List<string> cdw_choiceList = new List<string>();

        if(_cdw_difficulty == 1)
        {
            if (cdw_playerChoice.ToUpper() == "SCISSORS")
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Scissors",
                    "Paper",
                    "Paper",
                    "Paper",
                    "Scissors"
                });
            }
            else if (cdw_playerChoice.ToUpper() == "ROCK")
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Rock",
                    "Paper",
                    "Scissors",
                    "Scissors",
                    "Scissors"
                });
            }
            else
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Rock",
                    "Rock",
                    "Paper",
                    "Paper",
                    "Scissors"
                });
            }
            
        }
        else if(_cdw_difficulty == 2)
        {
            cdw_choiceList.AddRange(new List<string>
            {
                "Rock",
                "Paper",
                "Scissors"
            });
        }
        else
        {
            if (cdw_playerChoice.ToUpper() == "ROCK")
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Rock",
                    "Rock",
                    "Paper",
                    "Paper",
                    "Paper",
                    "Paper",
                    "Scissors"
                });
            }
            else if (cdw_playerChoice.ToUpper() == "PAPER")
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Paper",
                    "Paper",
                    "Paper",
                    "Scissors",
                    "Scissors",
                    "Scissors",
                    "Scissors"
                });
            }
            else
            {
                cdw_choiceList.AddRange(new List<string>
                {
                    "Rock",
                    "Rock",
                    "Rock",
                    "Rock",
                    "Paper",
                    "Scissors",
                    "Scissors",
                    "Scissors"
                });
            }
        }
        return cdw_choiceList[cdw_random.Next(cdw_choiceList.Count)];
    }

    public int cdw_TTTAction(List<string> cdw_board = null)
    {
        Random cdw_random = new Random();
        if (_cdw_difficulty == 1)
        {
            if (cdw_board[4] == "5")
            {
                return 5;
            }
            else if(cdw_board[2] == "3")
            {
                return 3;
            }
            else if (cdw_board[6] == "7")
            {
                return 7;
            }
            else if (cdw_board[5] == "6")
            {
                return 6;
            }
            else if (cdw_board [3] == "4")
            {
                return 4;
            }
            else if (cdw_board [8] == "9")
            {
                return 9;
            }
            else if (cdw_board [0] == "1")
            {
                return 1;
            }
            else if (cdw_board [1] == "2")
            {
                return 2;
            }
            else
            {
                return 8;
            }
        }
        else if (_cdw_difficulty == 3)
        {
            if (cdw_board[2] == "3")
            {
                return 3;
            }
            else if (cdw_board[6] == "7")
            {
                return 7;
            }
            else if (cdw_board[4] == "5")
            {
                return 5;
            }
            else if (cdw_board[5] == "6")
            {
                return 6;
            }
            else if (cdw_board[3] == "4")
            {
                return 4;
            }
            else if (cdw_board[8] == "9")
            {
                return 9;
            }
            else if (cdw_board[0] == "1")
            {
                return 1;
            }
            else if (cdw_board[7] == "8")
            {
                return 8;
            }
            else
            {
                return 2;
            }
        }
        else
        {
            return cdw_random.Next(1,10);
        }
    }

}