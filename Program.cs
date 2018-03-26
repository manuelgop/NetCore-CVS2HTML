using System;

namespace cvstohtml
{
    class Program
    {
        static void Main(string[] args)
        {
            //@ means read that string literally
            string filepath = @"/Users/apple/Documents/cvstohtml/";
            int counter = 0;
            string line;
            string textToSend = @"<h1>Customers</h1>
            <table border=1>";

            System.IO.StreamReader file = new System.IO.StreamReader(filepath+ "test.csv");
            while ((line=file.ReadLine()) != null)
            {
                string[] tempLine = line.Split(',');
                textToSend += "<tr>\n";

                if (counter == 0){
                    textToSend += "<th>"+tempLine[0]+"</th>\n";
                    textToSend += "<th>"+tempLine[1]+"</th>\n";
                    textToSend += "<th>"+tempLine[2]+"</th>\n";
                    textToSend += "<th>"+tempLine[3]+"</th>\n";
                }else{
                    textToSend += "<td>"+tempLine[0]+"</td>\n";
                    textToSend += "<td>"+tempLine[1]+"</td>\n";
                    textToSend += "<td>"+tempLine[2]+"</td>\n";
                    textToSend += "<td>"+tempLine[3]+"</td>\n";

                }
                counter++;
                textToSend += "</tr>\n";
            }
            textToSend += "</table>";
            //System.Console.Write(textToSend);
            System.IO.File.WriteAllText(filepath+"test.html", textToSend);
            file.Close();
            System.Console.WriteLine("\n\nWrote {0} Customers to page", counter -1);
            //Console.WriteLine("Press something");
            //Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
