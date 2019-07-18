using System.IO.Compression;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\Stefan\\Desktop\\Test.ini");
        static string[] p2l = System.IO.File.ReadAllLines(@"C:\\Users\\Stefan\\Desktop\\Problema2.ini");
        static string[] newlocation = System.IO.File.ReadAllLines(@"C:\\Users\\Stefan\\Desktop\\Problema3\\");

        //static void Problema1()
        //{

        //    foreach (var line in lines)
        //    {
        //        Console.WriteLine(line);
        //    }

        //    ZipFile.CreateFromDirectory(lines[0], lines[1]);
        //}

        //static void Problema2()
        //{
        //    List<string> myList = new List<string>();

        //    foreach (var cm in p2l)
        //    {
        //        var textFromFile = System.IO.File.ReadAllText(cm);
        //        myList.Add(textFromFile);
        //    }
        //    System.IO.File.WriteAllLines(@"C:\\Users\\Stefan\\Desktop\\outputFile.txt", myList);
        //}

        static void Problema3()
        {
            string fileName = "outputFile.txt";
            string sourcePath = @"C:\\Users\\Stefan\\Desktop";
            string targetPath = @"C:\\Users\\Stefan\\Desktop\\Problema3";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (var file in files)
                {
                    fileName = System.IO.Path.GetFileName(file);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(file, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path not found");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Problema2();
            //Problema3();

            Console.ReadKey();
        }
    }
}
