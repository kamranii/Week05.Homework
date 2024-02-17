using System;
using System.Collections.Generic;
using System.IO;
using Week05.Homework.Task3;
using Week05.Homework.Task4;
using Week05.Homework.Task2;

namespace Week05.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////Path of the folder
            //const string folderPath = "/Users/kamranimranli/desktop/testfolder/";
            ////Name of the file
            //string fileName = "TestFile.odt";
            ////Create a file
            //string filePath = folderPath + fileName;
            ////Ask number of lines
            //Console.Write("Input number of lines: ");
            //byte input = byte.Parse(Console.ReadLine());
            ////Array to store all input lines
            //string[] inputLines = new string[input];
            //Console.WriteLine($"Input {input} strings below: ");
            ////Ask each line
            //for(int i = 0; i < input; i++)
            //{
            //    //Ask for each line
            //    Console.Write($"Input line {i + 1}: ");
            //    inputLines[i] = Console.ReadLine();
            //}
            //Console.WriteLine("");
            ////Write the text to the file
            //File.WriteAllLines(filePath, inputLines);
            ////Read all lines of the file and store in a string array
            //string[] allLines = File.ReadAllLines(filePath);
            //Console.WriteLine($"The content of the last line of the file {fileName} is: {allLines[allLines.Length - 1]}");

            //Resources
            //https://www.c-sharpcorner.com/article/c-sharp-write-to-file/
            #endregion
            #region Task2
            //const string path = "/Users/kamranimranli/desktop/testfolder";
            //Calculate calculator = new Calculate(path);
            //Console.WriteLine(calculator.FileAndSubdirectoryCount());

            //Resources:
            //https://www.tutorialspoint.com/how-to-get-all-the-directories-and-sub-directories-inside-a-path-in-chash
            //https://www.delftstack.com/howto/csharp/get-all-files-in-a-directory-in-csharp/
            #endregion
            #region Task3
            //Example of using "MyList"
            MyList<string> stringList = new MyList<string>(10);
            //Adding elements
            stringList.Add("Region");
            stringList.Add("Grand");
            stringList.Add("Dumble");
            stringList.Add("Crunch");
            //Checking existance of an element
            Console.WriteLine(stringList.Contains("Crunch"));
            Console.WriteLine("*****");
            //Get number of elements
            Console.WriteLine(stringList.GetCount());
            Console.WriteLine("*****");
            //Removing an element
            stringList.Remove("Crunch");
            Console.WriteLine(stringList.Contains("Crunch"));
            Console.WriteLine("*****");
            //Iterating through the list
            foreach (var item in stringList.GetValues())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stringList.GetCount());
            //Deleting all elements from the list
            stringList.Clear();
            Console.WriteLine("****");
            foreach (var item in stringList.GetValues())
            {
                Console.WriteLine(item);
            }

            //Resources
            //https://www.tutorialsteacher.com/csharp/csharp-generics
            //https://www.c-sharpcorner.com/article/defaultt-in-generics/
            #endregion
            #region Task4
            ////Initalize the "process" list
            //List<string> process = new List<string>();
            ////Number of elements to get from the user
            //int elementNumber = 3;
            ////Get the list elements
            //for (int i = 0; i < elementNumber; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    process.Add(Console.ReadLine());
            //}
            //ListStub.ProcessToKill(process);
            #endregion
            #region Task5
            ////Initialize the dictionary
            //Dictionary<string, bool> characters = new Dictionary<string, bool>()
            //{
            //    { "Luke", true },
            //    { "Han", false },
            //    { "Chewbacca", false }
            //};
            ////Remove the value of the "Han"
            //characters.Remove("Han");
            ////Print out the elements
            //foreach (KeyValuePair<string, bool> kV in characters)
            //{
            //    Console.WriteLine($"Key: {kV.Key}, Value: {kV.Value}");
            //}
            #endregion
        }
    }
}

