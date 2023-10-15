using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2FileReadWrite
{
    internal class File
    {
        private string fileText; //filed designed to hold to text for file 
        private string filePath;


        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }
        public string ReadFile() //method which implements a StreamReades class instance 
        {
            string fileName;// = @"C:\Users\lisow\Desktop\log.txt"; //string literal character
           

            try // try code block is used to capture any issues
            {
                MessageBox.Show(this.filePath);
                StreamReader sr = new StreamReader(this.filePath);

                string line = sr.ReadLine(); //string assigned ReadLince method 
                while (line != null) // while loop conditon test
                {
                    fileText += line; // assigns the value of line 
                    line = sr.ReadLine(); //reads next line in the file 
                }
                sr.Close(); // closes the sr instance 
            }
            catch (Exception ex) //catch block is used to cath any issues and class instance is called
            {
                return ex.Message.ToString(); //display an error message 
            }
            return fileText;


        }
        public string WriteFile(string fileText) //method which recives the text that needs to be written to the file. 
        {
            string fileName;// = @"C:\Users\lisow\Desktop\log.txt";

            try // try code block is used to capture any issues
            {
                StreamWriter sw = new StreamWriter(filePath); //class instance is called and associated with the "log.txt file 
                sw.WriteLine(fileText); //method used to wirite the code imputed 
                sw.Close(); //close method 
            }
            catch (Exception ex) //catch block is used to cath any issues and class instance is called
            {
                return ex.Message.ToString(); ////display an error message
            }
            return fileText;
        }
    }
}
