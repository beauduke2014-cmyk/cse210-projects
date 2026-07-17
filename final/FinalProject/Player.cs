using System;
using System.Dynamic;
/* 
    Name: Carter Weber
    Class: CDE-210
    Description: The parent class to hold all the general information for human players and the computer players.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class Player //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    private int _cdw_score;
    private int _cdw_wins;
    private int _cdw_loses;
    private string _cdw_name;
    
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

    public void cdw_SetScore(int cdw_score)
    {
        _cdw_score = cdw_score;
    }

    public void cdw_SetWins(int cdw_wins)
    {
        _cdw_wins = cdw_wins;
    }

    public void cdw_SetLoses(int cdw_loses)
    {
        _cdw_loses = cdw_loses;
    }

    public void cdw_SetName(string cdw_name)
    {
        _cdw_name = cdw_name;
    }

    public void cdw_Initialize(string cdw_name, int cdw_score = 0, int cdw_wins = 0, int cdw_loses = 0)
    {
        _cdw_name = cdw_name;
        _cdw_score = cdw_score;
        _cdw_wins = cdw_wins;
        _cdw_loses = cdw_loses;
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
    public string cdw_GetName()
    {
        return _cdw_name;
    }
    public void cdw_addLose()
    {
        _cdw_loses ++;
    }
    public void cdw_addWin()
    {
        _cdw_wins ++;
    }
    public void cdw_addPoints(int cdw_reward)
    {
        _cdw_score += cdw_reward;
    }


    public virtual string cdw_ToString()
    {
        string cdw_rtnString = $"Player Name: {_cdw_name}\nWins: {_cdw_wins}\nLosses: {_cdw_loses}\nScore: {_cdw_score}\n";

        return cdw_rtnString;
    }

    public virtual string cdw_SavePlayer()
    {
        string cdw_rtnString = $"{_cdw_name} // {_cdw_score} // {_cdw_wins} // {_cdw_loses}";
        return cdw_rtnString;
    }
}