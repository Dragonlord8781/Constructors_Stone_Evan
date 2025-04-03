using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Stone_Evan
{
    class Game
    {
        //creates public strings title and genre
        public string title, genre;
        
        //creates a public method creating the paramater strings titleParam and genreParam and giving them a default value
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            //connects the public strings title and genre to the paramater strings titleParam and genreParam
            title = titleParam;
            genre = genreParam; 

        }

    }
}
