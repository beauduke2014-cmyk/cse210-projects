using System;
/* 
    Name: Carter Weber
    Class: CSE-210
    Description: A class to hold the questions and answers for each trivia question and to run the trivia game.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. 
*/

class Trivia:Game //: inherite from Base class
{
    //////////// Static/Class Attributes ///////////////////
    /// Attribute Permission Order: private, protected, public
    /// Declare a attribute: permission type variableName = value;
    /// a static attribute does not use the constructor so it must be declared and initiallized 
    List<string> _cdw_questionList = new();
    List<List<string>> _cdw_answerList = new();
    int _cdw_currentQuestion;


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
    public void cdw_setQuestions(int cdw_difficulty)
    {
        if (cdw_difficulty == 1)
        {
            _cdw_questionList.AddRange(new[]
            {
                "What is the capital of the United States?",
                "How many days are there in a week?",
                "Which planet is known as the Red Planet?",
                "What is the largest ocean on earth?",
                "Which animal is known as the 'King of the Jungle'?",
                "What color do you get when you mix blue and yellow?"
            }
            );
            List<string> answers1 = new()
            {
                "New York City",
                "Los Angeles",
                "Washington D.C.",
                "Chicago"
            };
            List<string> answers2 = new()
            {
                "5",
                "6",
                "7",
                "8"
            };
            List<string> answers3 = new()
            {
                "Venus",
                "Mars",
                "Jupiter",
                "Saturn"
            };
            List<string> answers4 = new()
            {
                "Atlantic Ocean",
                "Pacific Ocean",
                "Indian Ocean",
                "Arctic Ocean"
            };
            List<string> answers5 = new()
            {
                "Tiger",
                "Lion",
                "Elephant",
                "Gorilla"
            };
            List<string> answers6 = new()
            {
                "Purple",
                "Green",
                "Orange",
                "Brown"
            };
            _cdw_answerList.AddRange(new[]
            {
                answers1,
                answers2,
                answers3,
                answers4,
                answers5,
                answers6
            }
            );
        }
        else if (cdw_difficulty == 2)
        {
            _cdw_questionList.AddRange(new[]
            {
                "Which country is home to the Great Barrier Reef?",
                "Who wrote the play Romeo and Juliet?",
                "What is the largest desert in the world?",
                "Which element has the chemical symbol 'Fe'?",
                "Which U.S. state is known as the 'Sunshine State'?",
                "In which year did the first human land on the moon?"
            }
            );
            List<string> answers1 = new()
            {
                "New Zealand",
                "South Africa",
                "Australia",
                "Indonesia"
            };
            List<string> answers2 = new()
            {
                "Charles Dickens",
                "Mark Twain",
                "William Shakespeare",
                "Jane Austen"
            };
            List<string> answers3 = new()
            {
                "Sahara Desert",
                "Antarctic Desert",
                "Arabian Desert",
                "Gobi Desert"
            };
            List<string> answers4 = new()
            {
                "Fluorine",
                "Iron",
                "Francium",
                "Fermium"
            };
            List<string> answers5 = new()
            {
                "California",
                "Florida",
                "Arizona",
                "Hawaii"
            };
            List<string> answers6 = new()
            {
                "1965",
                "1969",
                "1967",
                "1971"
            };
            _cdw_answerList.AddRange(new[]
            {
                answers1,
                answers2,
                answers3,
                answers4,
                answers5,
                answers6
            }
            );
        }
        else if (cdw_difficulty == 3)
        {
            _cdw_questionList.AddRange(new[]
            {
                "Which country has the most time zones (including its overseas territories)?",
                "What is the longest river in Europe?",
                "Who painted The Persistence of Memory, the famouse painting featuring melting clocks?",
                "What is the rarest natually occuring blood type in humans?",
                "Which scientist is credited with proposing the three laws of planetary motion?",
                "Which country was the first to grant women the right to vote in national elections?"
            }
            );
            List<string> answers1 = new()
            {
                "Russia",
                "United States",
                "France",
                "Canada"
            };
            List<string> answers2 = new()
            {
                "Danube",
                "Rhine",
                "Volga",
                "Dnieper"
            };
            List<string> answers3 = new()
            {
                "Pablo Picasso",
                "Salvador Dali",
                "Vincent van Gogh",
                "Claude Monet"
            };
            List<string> answers4 = new()
            {
                "O-",
                "AB-",
                "AB+",
                "B-"
            };
            List<string> answers5 = new()
            {
                "Isaac Newton",
                "Johannes Kepler",
                "Galileo Galilei",
                "Nicolaus Copernicus"
            };
            List<string> answers6 = new()
            {
                "Australia",
                "New Zealand",
                "Finland",
                "Norway"
            };
            _cdw_answerList.AddRange(new[]
            {
                answers1,
                answers2,
                answers3,
                answers4,
                answers5,
                answers6
            }
            );
        }
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
        int cdw_questionNumber = cdw_GetRandomQuestion();
        _cdw_currentQuestion = cdw_questionNumber;
        string cdw_rtnString = $"Question: {_cdw_questionList[cdw_questionNumber]}";
        string cdw_questionAnswers = cdw_GetOptions(cdw_questionNumber);
        cdw_rtnString += $"\n\n{cdw_questionAnswers}";
        return cdw_rtnString;
    }

    public int cdw_GetRandomQuestion()
    {
        Random cdw_random = new Random();
        int cdw_randomQuestion = cdw_random.Next(_cdw_questionList.Count);
        return cdw_randomQuestion;
    }

    public string cdw_GetOptions(int cdw_questionNumber)
    {
        int cdw_count = 0;
        string cdw_rtnString = "";
        foreach (string cdw_answer in _cdw_answerList[cdw_questionNumber])
        {
            cdw_count ++;
            cdw_rtnString += $"  {cdw_count}. {cdw_answer}\n";
        }
        return cdw_rtnString;
    }

    public bool cdw_CheckAnswer(int cdw_answer)
    {
        if(_cdw_currentQuestion == 0 || _cdw_currentQuestion == 1)
        {
            if (cdw_answer == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (cdw_answer == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}