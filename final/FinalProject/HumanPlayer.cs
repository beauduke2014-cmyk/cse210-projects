using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A class to hold the specified information for a human player.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class HumanPlayer:Player //: inherite from Base class
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

    ///////////  Process State Functions /////////////////
    /// if class is mutable, used process functions: map, filter, reduce types
    /// if class is immutable, the process functions should be done either with constructors or toString

    ////////// Output Functions ///////////////////////
    // default functions
    // If mutable
    //  public string toString(){...} //defines 
    // if immutable
    //  getters if class is mutable

    public override string cdw_ToString()
    {
        return base.cdw_ToString();
    }

    public override string cdw_SavePlayer()
    {
        return base.cdw_SavePlayer();
    }

    
}