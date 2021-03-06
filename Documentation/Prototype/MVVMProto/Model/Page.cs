﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*The intended purpose of the Page class is to contain a list of text
  based on the Text.cs class.*/
namespace WonApplication {

    public class Page
    {
        //Instance Variables   
        private int pos{ get; set; }/* Page number (Position) */
        private List<Text> text = new List<Text>();/* A list based on Text.cs class */

        //Default Constructor
        public Page() {}

        //Librarian: To whom it may concern, please consider renaming this function to setPagePos, or setPos, as that is the convention.
        //           it is also concerning because adding and removing pages is the Document class's job, and is confusing in that context.
        //Pre-Condition: Input of variable pos. Pos is a given page number.
        //Post-Condition: Sets the pos variable. 
        public void addPage(int pos) { this.pos = pos;}

        //Deletes a Page object.
        //Pre-Condition: none
        //Post-Condition: Makes object null
        //public Page deletePage() { return null; }

        public string PassText() {
           string pass = "";
           foreach (Text add in text) pass = pass + add.ToString();
           return pass;
        }

        /* Author: Zachary Lowery
         * Date: 11/6/2017
         * Description: This function takes a string and converts it into a List<Text>, and then
         *              assigns it to the page. It should be noted this function does NOT overwrite 
         *              the List, but rather appends to it.
         *              
         * Pre-Condition: Don't try passing off a null pointer or something stupid like that.
         * Post-Condition: Takes a string and converts it to a text list, which is added to the contents
         *                 of the page.
         *                 
         * Implications: Please remember that this is NOT a SET function. . . 
         *               On loading very large files, creating a constructor and inserting manually into a Text<List> may get to be a terribly long business.
         *               We may need to consider only loading small portions of the document at a time, based on where in the UI they are looking. Just something
         *               to keep in mind.
         *               
         * Running-Time: O(n * Running-Time[Text Constructor(char)] * Running-Time[<Page>.Add()]), where n is the number of characters in the string.
         * Comments: I am not proud that so many Text constructors are called (one for each character)
         *           but I don't think I can get around that given how we have structured things.
         *  
         * 
        */
        public void appendTextList(string stringText){
            
            for(int stringPos = 0; stringPos < stringText.Length; stringPos++){
                Text newText = new Text(stringText[stringPos]);
                this.text.Add(newText); 
            }
        }

        /*
        static void Main(string[] args)
        {
            //Test Example 1 for Text
            Console.WriteLine("Starting Test");
            Text t1 = new Text('a');
            Console.WriteLine(t1.ToString());
            t1.setBold(true);
            t1.setItalics(true);
            t1.setUnderline(true);
            t1.setText('t');
            Console.WriteLine(t1.ToString());
            Text t2 = new Text('s', true, false, false);
            Console.WriteLine(t2.getText());
            Console.WriteLine(t2.getBold());
            Console.WriteLine(t2.getItalics());
            Console.WriteLine(t2.getUnderline());
            Console.WriteLine("Terminating Test \n");

            /*---------------------------------------*/

            /*
            Console.WriteLine("Starting Page Test ");

            //Test Example 1 for Page
            Console.WriteLine("Example 1 for Page \n");
            Page p1 = new Page();
            p1.addPage(1);
            p1.text.Add(t1);
            p1.text.Add(t2);
            Console.WriteLine($"    p1 page number: {p1.pos}");
            Console.Write("    p1 text: ");
            for (int i = 0; i < p1.text.Count; i++) {
                Console.Write(p1.text[i].getText());
            }
            Console.WriteLine("\n\nEnd of Page Example 1 \n");

            //Test Example 2 for Page
            Console.WriteLine("Example 2 for Page\n");
            Page p2 = new Page();
            p2.addPage(2);
            Text t3= new Text('a');
            string textentry = "Hello, this is Won Word Processor!";

            for (int i = 0; i < textentry.Length; i++) {
                char convertedText = textentry[i];
                t3.setText(convertedText);
                t3.setBold(true);
                t3.setItalics(false);
                t3.setUnderline(true);
                p2.text.Add(t3);
                Console.Write(p2.text[i].getText());
            }

            Console.WriteLine("\n     Page 2 Text Entry");
            Console.WriteLine($"     Page Number: {p2.pos}");
            Console.Write("     Fonts of Text Entry: ");
            for (int j = 0; j < p2.text.Count; j++) {
                if (j == 0){
                    Console.WriteLine($"Bold: {p2.text[j].getBold()}; Italics: {p2.text[j].getItalics()}; Underline: {p2.text[j].getUnderline()}");
                    Console.Write("     ");
                }
                Console.Write(p2.text[j].getText());
            }
            //Console.WriteLine("\n\nEnd of Page Example 2 \n");
        } */
    }
}