using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //FLOW CONTROL


            // IF STATEMENTS 
            //Simplest form of control flow statements

            // if (someBooleanCondition)
            //{
            // The code to run if the condition above is TRUE
            // }
            // ELSE STATEMENTS: added code if the condition is false
            //{
            // Code that will run if the condition is FALSE
            //}
            var name1 = "jake";
            if (name1 == "paul")
            {
                Console.WriteLine($"Greetings");
            }
            else
            {
                Console.WriteLine($"Wait, who are you?");
            }

            //BOOLEAN CONDITIONS:
            //name == "paul" : equality; name is paul
            //name != "paul" : inequality; name is not paul
            //score > 90 : Greater than 90
            //score < 90 : Less than 90

            //MULTIPLE BOOLEANS: OR, AND:
            //Combine two conditions 
            // OR is || 
            //AND is &&

            //EXAMPLE MULTIPLE BOOLEANS:
            // if(score < 20 || score > 90)
            //{
            //  if score is LESS THAN 20 OR score is GREATER THAN 90:
            //  then print code 
            //}

            //if(name == "Pul" && score > 90)
            //{
            // if name equals Paul AND score is GREATER THAN 90:
            // then print code 
            //}














            //Flow Control (SWITCH)

            // Creating a switch statement for INT the correct grade to our scoreB
            // Checking our variable throughout our SWITCH STATEMENT 
            //Should give us back (A)
            var scoreB = 92;

            switch (scoreB)
            {
                case < 65:
                    Console.WriteLine($"");
                    break;

                case < 70:
                    Console.WriteLine($"D");
                    break;

                case < 80:
                    Console.WriteLine($"C");
                    break;

                case >= 90:
                    Console.WriteLine($"A");
                    break;

                default:
                    Console.WriteLine($"Non existent");


                    break;
            }

            //Another Example of SWITCH STATEMENT
            // It takes in the variable name1 and check if the name....
            //matches with any of the cases. If they do we print out the code in the case
            //Should print out (Didn't find the name you were looking for)
            switch (name1)
            {
                case "Paul":
                    Console.WriteLine("Here I am Paul");
                    break;
                case "Same":
                    Console.WriteLine($"Here I am");
                    break;
                case "Tyler":
                    Console.WriteLine("Hey there Tyler");
                    break;
                case "Jackie":
                    Console.WriteLine("Jackie ! Hey Girl");
                    break;
                default:
                    Console.WriteLine("Didn't find the name you were looking for");
                    break;
            }




            //LOOP (WHILE)

            //A WHILE STATEMENT loops the code inside the {} as long as the condition remains TRUE

            //Asking User (What their name is)
            Console.Write("Hi what is your name? ");
            //Creating a variable for the Users name 
            var name = Console.ReadLine();

            //WHILE STATEMENT (LOOP)
            // while name given by User is not equal to quit print out the code
            while (name != "quit")
            {

                Console.Write($"Hello, {name} how are you? ");
                string responseGiven;
                responseGiven = Console.ReadLine();

                Console.WriteLine($"That is great to hear that you are having a {responseGiven} day");
                break;
            }

            //WHILE STATEMENT:
            var counter = 0;
            //The WHILE STATEMENT prints out (printing out 10 things) 10 times
            while (counter < 10)
            {
                Console.WriteLine("printing out 10 things");
                counter++;
            }

            //FOR STATEMENT (LOOP)
            //FOR LOOP is like the while loop. Except it puts the variable in the FOR LOOP
            for (var counter1 = 0; counter1 < 5; counter1++)
            {
                Console.WriteLine("Printing things out 5 times");
            }

            //LOOPING A LIST
            //Creating the LIST with Student Names
            var studentNames = new List<string> { "Mark", "paula", "Sandy" };
            //Asking student for name and saving in the addingStudentName variable
            Console.Write("Hello student what is your name?");
            var addingStudentName = Console.ReadLine();

            //Creating out FOR LOOP: first we create a variable index for the loop to start at name [0]
            //Then we are telling the Index variable to go thru exactly StudentName List
            //and Index++ increments by one name until there are no more names in LIST
            //Putting the FOR LOOP  inside out WHILE LOOP 
            // the code reads.. while the name is not quit... code out the names of students from out LIST
            while (name != "quit")
            {
                for (var index = 0; index < studentNames.Count; index++)
                {
                    var studentNamesInList = studentNames[index];
                    Console.WriteLine($"Hello, students {studentNamesInList}");

                }
                //This code SAVES the NAMES of the NEW STUDENTS in our LIST of studentNames
                Console.Write($"What is your name? ");
                addingStudentName = Console.ReadLine();
                studentNames.Add(addingStudentName);

            }

            //LOOPING A LIST 
            // FOREACH STATEMENT 

            var cars = new List<string> { "Toyota", "Ford", "Lincoln" };
            Console.Write($"Hi what is your fav car");
            var carName = Console.ReadLine();

            while (carName != "Quit")
            {
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car}");
                }
                Console.WriteLine($"What is your favorite car name? ");
                var newCarName = Console.ReadLine();
                cars.Add(newCarName);
            }

        }
    }
}