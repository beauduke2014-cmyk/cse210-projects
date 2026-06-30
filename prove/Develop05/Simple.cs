using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: The class for simple quests that are completed and rewarded once.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
*/

public class Simple:Quest //: inherite from Base class
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

    public void cdw_CreateSimple(string cdw_name, string cdw_description, int cdw_reward, bool cdw_completed = false)
    {
        cdw_SetName(cdw_name);
        cdw_SetDescription(cdw_description);
        cdw_SetReward(cdw_reward);
        cdw_SetCompleted(cdw_completed);
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
        bool cdw_completed = cdw_GetCompleted();
        cdw_completed = true;
        cdw_SetCompleted(cdw_completed);
        return cdw_GetReward();
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
        return cdw_rtnString;
    }
    
    public override string cdw_SaveGoals()
    {
        string cdw_rtnString = $"Simple // {cdw_GetName()} // {cdw_GetDescription()} // {cdw_GetReward()} // {cdw_GetCompleted()}";
        return cdw_rtnString;
    }
}