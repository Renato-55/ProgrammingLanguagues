using System.IO; // include the System.IO namespace

namespace FilesTest
{
    /* File Resume */
    /* The File class has many useful methods for creating and getting information about files. For example:

        Method	Description
        AppendText()	Appends text at the end of an existing file
        Copy()	Copies a file
        Create()	Creates or overwrites a file
        Delete()	Deletes a file
        Exists()	Tests whether the file exists
        ReadAllText()	Reads the contents of a file
        Replace()	Replaces the contents of a file with the contents of another file
        WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
    */
    class FileManagement
    {
        public static void CreateFile(string filename)
        {
            Console.WriteLine("\n[+] Creating file : " + filename);
            using (FileStream fs = File.Create(filename))
            {
                Console.WriteLine("[+] File created");
            }
        }

        public static void DeleteFile(string filename)
        {
            Console.WriteLine("\n[-] Deleting file : " + filename);

            try
            {
                File.Delete(filename);
                Console.WriteLine("[-] File deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Error deleting file: " + ex.Message);
            }
        }

        public static void WriteFile(string filename, string content, bool append = true)
        {
            Console.WriteLine("\n[+] Writing file : " + filename);

            try
            {
                if (append)
                    File.AppendAllText(filename, content);
                else
                    File.WriteAllText(filename, content);

                Console.WriteLine("[+] File written");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Error writing file: " + ex.Message);
            }
        }

        public static string ReadFile(string filename)
        {
            try
            {
                Console.WriteLine("\n[!] Reading file : " + filename);

                if (File.Exists(filename))
                {
                    string content = File.ReadAllText(filename);
                    Console.WriteLine("[!] File read successfully");
                    Console.WriteLine("[!] File content: " + content);
                    return content;
                }
                else
                {
                    Console.WriteLine("[-] File does not exist");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[-] Error reading file: " + ex.Message);
                return null;
            }
        }
    }
}
