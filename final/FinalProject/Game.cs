using System;
/* 
    Name: Carter Weber
    Class: CDE-210
    Description: The parent class to hold all the general information for the 5 minute games.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class Game //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    private string _cdw_title;
    private string _cdw_rules;
    private int _cdw_rewardPoints;
    private int _cdw_players;

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
    public void cdw_SetTitle(string cdw_title)
    {
        _cdw_title = cdw_title;
    }
    public void cdw_SetRules(string cdw_rules)
    {
        _cdw_rules = cdw_rules;
    }
    public void cdw_SetReward(int cdw_rewardPoints)
    {
        _cdw_rewardPoints = cdw_rewardPoints;
    }
    public void cdw_SetPlayerCount(int cdw_players)
    {
        _cdw_players = cdw_players;
    }
    public void cdw_Initialize(string cdw_title, string cdw_rules, int cdw_rewardPoints, int cdw_players)
    {
        _cdw_title = cdw_title;
        _cdw_rules = cdw_rules;
        _cdw_rewardPoints = cdw_rewardPoints;
        _cdw_players = cdw_players;
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

    public virtual string cdw_StartGame()
    {
        return " ";
    }

    public int cdw_getReward()
    {
        return _cdw_rewardPoints;
    }

    public virtual void cdw_CheckWinner()
    {
        
    }
}