using System;

namespace FilesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "test.txt";
            FileManagement.CreateFile(filename);

            FileManagement.WriteFile(filename, "\nHello World!");

            FileManagement.ReadFile(filename);

            FileManagement.WriteFile(filename, "\nHello World! appended", true);

            FileManagement.ReadFile(filename);

            // delete the file
            FileManagement.DeleteFile(filename);
        }
    }
}
