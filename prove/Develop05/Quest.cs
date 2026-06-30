using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: The base class for all quests(goals) to be created.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
*/

public class Quest
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    private string _cdw_name;
    private string _cdw_description;
    private bool _cdw_completed;
    private int _cdw_reward;
    
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
    public void cdw_SetCompleted(bool cdw_completed)
    {
        _cdw_completed = cdw_completed;
    }
    public void cdw_SetReward(int cdw_reward)
    {
        _cdw_reward = cdw_reward;
    }
    public void cdw_SetName(string cdw_name)
    {
        _cdw_name = cdw_name;
    }
    public void cdw_SetDescription(string cdw_description)
    {
        _cdw_description = cdw_description;
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
    public int cdw_GetReward()
    {
        return _cdw_reward;
    }
    public bool cdw_GetCompleted()
    {
        return _cdw_completed;
    }
    public string cdw_GetName()
    {
        return _cdw_name;
    }
    public string cdw_GetDescription()
    {
        return _cdw_description;
    }
    public virtual int cdw_CompleteQuest()
    {
        _cdw_completed = true;
        return _cdw_reward;
    }
    public virtual string cdw_ToString()
    {
        string cdw_rtnString = "";
        if(_cdw_completed == true)
        {
            cdw_rtnString += "[X]";
        }
        else
        {
            cdw_rtnString += "[ ]";
        }
        cdw_rtnString += $" {cdw_GetName()} ({cdw_GetDescription()})";
        return cdw_rtnString;
    }
    public virtual string cdw_SaveGoals()
    {
        string cdw_rtnString = $"{cdw_GetName()} // {cdw_GetDescription()} // {cdw_GetReward()} // {cdw_GetCompleted()}";
        return cdw_rtnString;
    }
    

}