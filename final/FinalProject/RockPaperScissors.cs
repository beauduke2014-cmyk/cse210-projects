using System;
using System.IO.Compression;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A program to run the game Rock Paper Scissors

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class RockPaperScissors:Game //: inherite from Base class
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
    private string _cdw_optionOne = "Rock";
    private string _cdw_optionTwo = "Paper";
    private string _cdw_optionThree = "Scissors";


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
        return $"Which do you choose (Enter the name of the item): \n 1. {_cdw_optionOne}\n 2. {_cdw_optionTwo}\n 3. {_cdw_optionThree}\n";
    }
    public string cdw_CheckWinner(string cdw_player1, string cdw_player2)
    {
        if (cdw_player1 == cdw_player2)
            return "Tie";

        if ((cdw_player1 == "rock" && cdw_player2 == "scissors") ||
            (cdw_player1 == "paper" && cdw_player2 == "rock") ||
            (cdw_player1 == "scissors" && cdw_player2 == "paper"))
            return "Win";
        else
        {
            return "Loss";
        }

        
    }
    
    

}