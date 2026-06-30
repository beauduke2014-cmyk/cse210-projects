using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: The class for quests that are to be completed a certain number of times with a bonus reward when all instances are completed.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
*/

public class Checklist:Quest //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    
    private int _cdw_completionCounter;
    private int _cdw_goal;
    private int _cdw_bonus;

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

    public void cdw_CreateChecklist(string cdw_name, string cdw_description, int cdw_reward, int cdw_userGoal, int cdw_userBonus, int cdw_completionCounter = 0, bool cdw_completed = false)
    {
        cdw_SetName(cdw_name);
        cdw_SetDescription(cdw_description);
        cdw_SetCompleted(cdw_completed);
        cdw_SetReward(cdw_reward);
        _cdw_completionCounter = cdw_completionCounter;
        _cdw_goal = cdw_userGoal;
        _cdw_bonus = cdw_userBonus;
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

    public override int cdw_CompleteQuest()
    {
        _cdw_completionCounter ++;
        if (_cdw_completionCounter == _cdw_goal)
        {
            cdw_SetCompleted(true);
            return cdw_GetReward() + _cdw_bonus;
        }
        else
        {
            return cdw_GetReward();
        }
    }

    public override string cdw_ToString()
    {
        string cdw_rtnString = "";
        bool cdw_completed = cdw_GetCompleted();
        if(cdw_completed == true)
        {
            cdw_rtnString += "[X]";
        }
        else
        {
            cdw_rtnString += "[ ]";
        }
        cdw_rtnString += $" {cdw_GetName()} ({cdw_GetDescription()})";
        cdw_rtnString += $" -- Currently completed {_cdw_completionCounter}/{_cdw_goal}";
        return cdw_rtnString;
    }

    public override string cdw_SaveGoals()
    {
        string cdw_rtnString = $"Checklist // {cdw_GetName()} // {cdw_GetDescription()} // {cdw_GetReward()} // {cdw_GetCompleted()} // {_cdw_completionCounter} // {_cdw_goal} // {_cdw_bonus}";
        return cdw_rtnString;
    }
}