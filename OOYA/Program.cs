using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile moi = new Profile("Justine Charonnat", 23, "Nogent-sur-Oise", "France", "she/her");

      moi.SetHobbies(new string[] {"Dessiner", "Jouer aux jeux vidéos", "Marcher", "Ecouter de la musique", "Animaux"});
      
      string result = moi.ViewProfile();
      Console.WriteLine(result);

      Profile beubeu = new Profile("Benoît Prevost", 24);
      
      string result2 = beubeu.ViewProfile();
      Console.WriteLine(result2);

      Profile pilou = new Profile("Flambeau", 12);
      pilou.SetHobbies(new string[] {"Manger", "Dormir", "Jouer", "Faire du bruit", "Embêter ma maman"});

      string result3 = pilou.ViewProfile();
      Console.WriteLine(result3);


    }
  }
}