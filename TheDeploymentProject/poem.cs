using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDeploymentProject
{
    public class Poem
    {
        private string _author;
        private string _title;
        private string[] _poem;
        private int _verseCount;
        private int _currentVerse = -1;

        public Poem(int numVerses, string title, string author)
        {
            _verseCount = -1;
            _poem = new string[numVerses];
            _author = author;
            _title = title;
        }

        public string Author
        {
            //set
            //{
            //    _author = value;
            //}
            get
            {
                return _author;
            }
        }
        public string Title
        {
            //set
            //{
            //    _title = value;
            //}
            get
            {
                return _title;
            }
        }
        public void addVerse(string text)
        {
            _poem[++_verseCount] = text;
        }
        public string NextVerse
        {
            get
            {
                // string value = _poem[++_currentVerse];
                return _poem[++_currentVerse]; 
            }
        }
        public void resetVerseIndex()
        {
            // maxVerseCount = 0
            _currentVerse = 0;
        }

        public Boolean EndOfPoem
        {
            get
            {
                return _currentVerse == _poem.Length-1;
            }
        }
    }
}
