using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: Store information and run the tic-tac-toe game

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes...
        3. Internet research...
*/

class TicTacToe:Game //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    private string _cdw_squareOne = "1";
    private string _cdw_squareTwo = "2";
    private string _cdw_squareThree = "3";
    private string _cdw_squareFour = "4";
    private string _cdw_squareFive = "5";
    private string _cdw_squareSix = "6";
    private string _cdw_squareSeven = "7";
    private string _cdw_squareEight = "8";
    private string _cdw_squareNine = "9";
    
    //////////// Static/Class Methods ///////////////////
    /// Methods Permission Order: private, protected, public
    /// Declare and Define a function: 
    ///     permission returnType functionName (parameterType parameterName){...return variable_value}

    //////////// Instance Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    

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
    public void cdw_SetSquareOne(string cdw_squareOne)
    {
        _cdw_squareOne = cdw_squareOne;
    }
    public void cdw_SetSquareTwo(string cdw_squareTwo)
    {
        _cdw_squareTwo = cdw_squareTwo;
    }
    public void cdw_SetSquareThree(string cdw_squareThree)
    {
        _cdw_squareThree = cdw_squareThree;
    }
    public void cdw_SetSquareFour(string cdw_squareFour)
    {
        _cdw_squareFour = cdw_squareFour;
    }
    public void cdw_SetSquareFive(string cdw_squareFive)
    {
        _cdw_squareFive = cdw_squareFive;
    }
    public void cdw_SetSquareSix(string cdw_squareSix)
    {
        _cdw_squareSix = cdw_squareSix;
    }
    public void cdw_SetSquareSeven(string cdw_squareSeven)
    {
        _cdw_squareSeven = cdw_squareSeven;
    }
    public void cdw_SetSquareEight(string cdw_squareEight)
    {
        _cdw_squareEight = cdw_squareEight;
    }
    public void cdw_SetSquareNine(string cdw_squareNine)
    {
        _cdw_squareNine = cdw_squareNine;
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
    public override string cdw_StartGame()
    {
        string cdw_rtnString = "";
        cdw_rtnString += cdw_AssembleBoard();
        cdw_rtnString += "\n\nSelect a square: ";
        return cdw_rtnString;
    }

    public string cdw_SelectSquare(int cdw_choice, int cdw_player)
    {
        if(cdw_player == 1)
        {
            if(cdw_choice == 1 && _cdw_squareOne == "1")
            {
                _cdw_squareOne = "X";
                return "Success";
            }
            else if(cdw_choice == 2 && _cdw_squareTwo == "2")
            {
                _cdw_squareTwo = "X";
                return "Success";
            }
            else if(cdw_choice == 3 && _cdw_squareThree == "3")
            {
                _cdw_squareThree = "X";
                return "Success";
            }
            else if(cdw_choice == 4 && _cdw_squareFour == "4")
            {
                _cdw_squareFour = "X";
                return "Success";
            }
            else if(cdw_choice == 5 && _cdw_squareFive == "5")
            {
                _cdw_squareFive = "X";
                return "Success";
            }
            else if(cdw_choice == 6 && _cdw_squareSix == "6")
            {
                _cdw_squareSix = "X";
                return "Success";
            }
            else if(cdw_choice == 7 && _cdw_squareSeven == "7")
            {
                _cdw_squareSeven = "X";
                return "Success";
            }
            else if(cdw_choice == 8 && _cdw_squareEight == "8")
            {
                _cdw_squareEight = "X";
                return "Success";
            }
            else if(cdw_choice == 9 && _cdw_squareNine == "9")
            {
                _cdw_squareNine = "X";
                return "Success";
            }
            else
            {
                return "Invalid";
            }
        }
        else if(cdw_player == 2)
        {
            if(cdw_choice == 1 && _cdw_squareOne == "1")
            {
                _cdw_squareOne = "O";
                return "Success";
            }
            else if(cdw_choice == 2 && _cdw_squareTwo == "2")
            {
                _cdw_squareTwo = "O";
                return "Success";
            }
            else if(cdw_choice == 3 && _cdw_squareThree == "3")
            {
                _cdw_squareThree = "O";
                return "Success";
            }
            else if(cdw_choice == 4 && _cdw_squareFour == "4")
            {
                _cdw_squareFour = "O";
                return "Success";
            }
            else if(cdw_choice == 5 && _cdw_squareFive == "5")
            {
                _cdw_squareFive = "O";
                return "Success";
            }
            else if(cdw_choice == 6 && _cdw_squareSix == "6")
            {
                _cdw_squareSix = "O";
                return "Success";
            }
            else if(cdw_choice == 7 && _cdw_squareSeven == "7")
            {
                _cdw_squareSeven = "O";
                return "Success";
            }
            else if(cdw_choice == 8 && _cdw_squareEight == "8")
            {
                _cdw_squareEight = "O";
                return "Success";
            }
            else if(cdw_choice == 9 && _cdw_squareNine == "9")
            {
                _cdw_squareNine = "O";
                return "Success";
            }
            else
            {
                return "Invalid";
            }
        }
        else
        {
            return "Invalid";
        }
    }

    public string cdw_AssembleBoard()
    {
        return $" {_cdw_squareOne} | {_cdw_squareTwo} | {_cdw_squareThree} \n-----------\n {_cdw_squareFour} | {_cdw_squareFive} | {_cdw_squareSix} \n-----------\n {_cdw_squareSeven} | {_cdw_squareEight} | {_cdw_squareNine} ";
    }
    public List<string> cdw_GetBoard()
    {
        List<string> cdw_boardList = new();
        cdw_boardList.Add(_cdw_squareOne);
        cdw_boardList.Add(_cdw_squareTwo);
        cdw_boardList.Add(_cdw_squareThree);
        cdw_boardList.Add(_cdw_squareFour);
        cdw_boardList.Add(_cdw_squareFive);
        cdw_boardList.Add(_cdw_squareSix);
        cdw_boardList.Add(_cdw_squareSeven);
        cdw_boardList.Add(_cdw_squareEight);
        cdw_boardList.Add(_cdw_squareNine);
        return cdw_boardList;
    }

    public bool cdw_CheckForWin()
    {
        if ((_cdw_squareOne == _cdw_squareTwo && _cdw_squareTwo == _cdw_squareThree) || (_cdw_squareOne == _cdw_squareFour && _cdw_squareFour == _cdw_squareSeven) || (_cdw_squareOne == _cdw_squareFive && _cdw_squareFive == _cdw_squareNine) || (_cdw_squareFour == _cdw_squareFive && _cdw_squareFive == _cdw_squareSix) || (_cdw_squareTwo == _cdw_squareFive && _cdw_squareFive == _cdw_squareEight) || (_cdw_squareThree == _cdw_squareFive && _cdw_squareFive == _cdw_squareSeven) || (_cdw_squareSeven == _cdw_squareEight && _cdw_squareEight == _cdw_squareNine) || (_cdw_squareThree == _cdw_squareSix && _cdw_squareSix == _cdw_squareNine))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}