using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheDeploymentProject
{
    public partial class Form1 : Form
    {
        private Poem currentPoem;
        public Form1()
        {
            InitializeComponent();
        }

        private void whitmanButton_click(object sender, EventArgs e)
        {
            // create the whitman poem
            Poem Captain = new Poem(3, "O Captain! My Captain", "Walt Whitman");
            Captain.addVerse("O Captain! my Captain! our fearful trip is done,\n" +
                "The ship has weather’d every rack, the prize we sought is won,\n" +
                "The port is near, the bells I hear, the people all exulting,\n" +
                "While follow eyes the steady keel, the vessel grim and daring;\n" +
                "            But O heart!heart!heart!\n" +
                "             O the bleeding drops of red,\n" +
                "                Where on the deck my Captain lies,\n" +
                "                   Fallen cold and dead.");
            Captain.addVerse("O Captain! my Captain! rise up and hear the bells;\n" +
                "Rise up—for you the flag is flung—for you the bugle trills,\n" +
                "For you bouquets and ribbon’d wreaths—for you the shores a - crowding,\n" +
                "For you they call, the swaying mass, their eager faces turning;\n" +
                "            Here Captain!dear father!\n" +
                "              This arm beneath your head!\n" +
                "                 It is some dream that on the deck,\n" +
                "                   You’ve fallen cold and dead.");
            Captain.addVerse("My Captain does not answer, his lips are pale and still,\n" +
                "My father does not feel my arm, he has no pulse nor will,\n" +
                "The ship is anchor’d safe and sound, its voyage closed and done,\n" +
                "From fearful trip the victor ship comes in with object won;\n" +
                "            Exult O shores, and ring O bells!\n" +
                "               But I with mournful tread,\n" +
                "                  Walk the deck my Captain lies,\n" +
                "                     Fallen cold and dead.");

            // send the poem to be displayed on the form
            DisplayPoem(Captain);
        }
        public void DisplayPoem(Poem target)
        {
            // hide the text areas before we change the text
            this.titleLabel.Visible = false;
            this.authorLabel.Visible = false;
            this.poemTextbox.Visible = false;

            // set the form's current poem it is working with
            this.currentPoem = target;

            // populate the different text areas
            this.titleLabel.Text = target.Title;
            this.authorLabel.Text = target.Author;
            this.poemTextbox.Text = target.NextVerse;

            // make the text areas visible
            this.titleLabel.Visible = true;
            this.authorLabel.Visible = true;
            this.poemTextbox.Visible = true;

            // make the next verse button visible if the poem is not yet finished
            nextVerseButton.Visible = !currentPoem.EndOfPoem;

            if (!nextVerseButton.Visible)
            {
                this.panel1.Focus();
            }

            this.poemTextbox.Height = this.poemTextbox.Lines.Count() * 18;

            this.nextVerseButton.Top = this.poemTextbox.Height + this.poemTextbox.Top + 10;
        }

        private void nextVerseButton_Click(object sender, EventArgs e)
        {
            // display the next verse of the current poem
            //this.poemTextbox.Text = this.currentPoem.NextVerse;

            // if there are no more verses, hide the button
            //((Button)sender).Visible = !currentPoem.EndOfPoem;

            DisplayPoem(currentPoem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // make the poem's background colour match that of the form
            this.poemTextbox.BackColor = this.BackColor;
        }

        private void RoberFrostButton_Click(object sender, EventArgs e)
        {
            Poem travelling = new Poem(4, "The Road Not Taken", "Robert Frost");
            travelling.addVerse("Two roads diverged in a yellow wood,\n" +
                "And sorry I could not travel both\n" +
                "And be one traveler, long I stood\n" +
                "And looked down one as far as I could\n" +
                "To where it bent in the undergrowth; ");
            travelling.addVerse("Then took the other, as just as fair,\n" +
                "And having perhaps the better claim,\n" +
                "Because it was grassy and wanted wear;\n" +
                "Though as for that the passing there\n" +
                "Had worn them really about the same, ");
            travelling.addVerse("And both that morning equally lay\n" +
                "In leaves no step had trodden black.\n" +
                "Oh, I kept the first for another day!\n" +
                "Yet knowing how way leads on to way,\n" +
                "I doubted if I should ever come back.");
            travelling.addVerse("I shall be telling this with a sigh\n" +
                "Somewhere ages and ages hence:\n" +
                "Two roads diverged in a wood, and I—\n" +
                "I took the one less traveled by,\n" +
                "And that has made all the difference.");

            // send the poem to be displayed on the form
            DisplayPoem(travelling);
        }

        private void RWServiceButton_Click(object sender, EventArgs e)
        {          
            //@ symbol in front of a string to create a “verbatim string literal”
            string fileLoc = @"poems\sam.txt";

            // set up the poem object
            Poem sam = new Poem(CountVerses(fileLoc), "The Cremation of Sam McGee", "Robert W. Service");

            // load the poem's verses, as they are found  in the file
            LoadPoem(sam,fileLoc);

            // display this poem on the form
            DisplayPoem(sam);
            
        }
        private int CountVerses (string poemFileLocation)
        {
            int count = 0;

            using (StreamReader content = new StreamReader(poemFileLocation, Encoding.GetEncoding("iso-8859-1")))
            {
                string line;

                // counting blank lines. each blank line is a space between verses
                while (content.Peek() >= 0)
                {
                    line = content.ReadLine();
                    if ( string.IsNullOrEmpty(line) )
                    {
                        count++;
                    }
                }
            }
            //increment the counter one last time for the final verse that is not 
            //  being caught in the check above
            return ++count;
        }
        private bool LoadPoem(Poem target, string poemFileLocation)
        {
            string line;
            StringBuilder verse = new StringBuilder() ;
                       
            // encoding bit is so that it recognizes the accents found on some of the text
            using (StreamReader content = new StreamReader(poemFileLocation, Encoding.GetEncoding("iso-8859-1")) )
            {
                //while (content.Peek() >= 0)
                while (!content.EndOfStream)
                {
                    line = content.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        // if we do not see a blank line, then we are still building the verse
                        //  add this new line to the current string we are building
                        verse.AppendLine(line);
                    }
                    else
                    {
                        // the verse is now done, let's add it to the poem
                        //Console.WriteLine(verse.ToString());
                        target.addVerse(verse.ToString());
                        Console.WriteLine(verse.ToString());

                        // reset the string (verse) we are building for the next verse in the file
                        verse.Clear();
                    }
                }

                // load the last verse which was created, but not inserted
                //  due to logic flow (kicked out before load by the peek)
                target.addVerse(verse.ToString());
            }
            return true;
        }

        private void RJoeButton_Click(object sender, EventArgs e)
        {
            //@ symbol in front of a string to create a “verbatim string literal”
            string fileLoc = @"poems\ILostMyTalk.txt";

            // set up the poem object
            Poem lost = new Poem(CountVerses(fileLoc), "I Lost My Talk", "Rita Joe");

            // load the poem's verses, as they are found  in the file
            LoadPoem(lost, fileLoc);

            // display this poem on the form
            DisplayPoem(lost);
        }

        private void LWallaceButton_Click_1(object sender, EventArgs e)
        {
            //@ symbol in front of a string to create a “verbatim string literal”
            string fileLoc = @"poems\nightAir.txt";

            // set up the poem object
            Poem nightAir = new Poem(CountVerses(fileLoc), "Statl’limx Fishing: Night Air", "Lila Wallace");

            // load the poem's verses, as they are found  in the file
            LoadPoem(nightAir, fileLoc);

            // display this poem on the form
            DisplayPoem(nightAir);
        }
    }

}


