using System;
using System.IO.Enumeration;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A class to oversee the saving and loading of files and data

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class FileManager //: inherite from Base class
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

    public void cdw_SaveData(List<Player> cdw_playerList, string cdw_fileName)
    {
        cdw_fileName += ".txt";
        using (StreamWriter outputFile = new StreamWriter(cdw_fileName))
        {
            foreach(Player cdw_player in cdw_playerList)
            {
                outputFile.WriteLine($"{cdw_player.cdw_SavePlayer()}");
            }
        }
    }

    public List<Player> cdw_LoadData(List<Player> cdw_playerList, string cdw_fileName)
    {
        cdw_fileName += ".txt";
        string[] cdw_lines = System.IO.File.ReadAllLines(cdw_fileName);
        foreach (string cdw_line in cdw_lines)
        {
            string[] cdw_parts = cdw_line.Split(" // ");
            Player cdw_newPlayer = new Player();
            cdw_newPlayer.cdw_Initialize(cdw_parts[0], int.Parse(cdw_parts[1]), int.Parse(cdw_parts[2]), int.Parse(cdw_parts[3]));
            cdw_playerList.Add(cdw_newPlayer);
        }
        return cdw_playerList;
    }

}