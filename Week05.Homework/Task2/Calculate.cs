using System;
using System.Collections.Generic;
using System.IO;
namespace Week05.Homework.Task2
{
    public class Calculate
    {
        public string Path { get; set; }
        public Calculate(string directoryPath)
        {
            //Assign the path to look for
            this.Path = directoryPath;
        }
        //Calculate number of subdirectories
        public int FileAndSubdirectoryCount()
        {
            //Store number of subdirectories
            int elementCount = 0;
            //Initialize an array to store the subdirectories
            string[] subDirectories = Directory.GetDirectories(Path);
            //Check if there are any subdirectories in the directory
            if(subDirectories.Length > 0)
            {
                foreach (var subDirectory in subDirectories)
                {
                    elementCount++;
                    //Check if there're files in each subdirectory
                    string[] files = Directory.GetFiles(subDirectory);
                    if (files.Length > 0)
                    {
                        //Add number of files in the current subdirectory to the element count
                        elementCount += FileCount(subDirectory);
                    }
                }
            }
            //Add number of files in the main directory
            elementCount += FileCount(Path);
            return elementCount;
        }
        //Calculate number of files
        public int FileCount(string path)
        {
            //Store number of files
            int numberOfFiles = 0;
            //Store all files in the given path
            string[] files = Directory.GetFiles(path);
            //Loop to count files
            foreach(var file in files)
            {
                numberOfFiles++;
            }
            return numberOfFiles;
        }
    }
}

