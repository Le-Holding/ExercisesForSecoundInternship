using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class DeclarationIndexersAccessorsLikeProperty
  {
    public string[] TheMusicApp()
    {
      var genres = new MusicGenres(); 
      int count = 0;

      var arr = new string[] { "Bluse", "Rock", "Hip Hop", "Contry", "Soul" };
      while (count < 5)
      {
        //genres[count] = Console.ReadLine();
        genres[count] = arr[count];
        count++;
      }

      string[] arrResult = new string[5];
      for (int i = 0; i < 5; i++)
      {
        arrResult[i] = "Following: " + genres[i];
      }
      return arrResult;
    }
  }

  internal class MusicGenres
  {
    private string[] genres = new string[5];

    //declare an indexer

    // Your code starts here
   
  }
}
