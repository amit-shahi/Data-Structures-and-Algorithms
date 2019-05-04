using System;
using System.IO;
using static System.Console;

namespace DirectoryRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Enter a folder path");
                string path = ReadLine();

                if(Directory.Exists(path))
                {
                    WriteLine($"Following folder(s) and file(s) found at : {path}");
                    WriteLine();

                    FindFolderAndFiles(path);                
                }
                else 
                {
                    WriteLine("Folder not found. Please choose correct path.");
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }

        }

        public static void FindFolderAndFiles(string path)
        {
            if(path != null)
            {
                foreach(var file in Directory.GetFiles(path))
                {
                    WriteLine(file);                                
                }

                foreach(var folder in Directory.GetDirectories(path))
                {
                    WriteLine(folder);
                    FindFolderAndFiles(folder);
                } 
               
            }
        }
    }
    
}
