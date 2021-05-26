using System;

namespace DatingProfile
{ 

  // Champs
  class Profile {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

  // Constructeurs
    public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronouns = "they/them") {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

  // Méthodes

    public string ViewProfile() {
      string bio = $"Nom: {name}\nAge: {age}\nVille: {city}\nPays: {country}\nPronoms: {pronouns}\n";

      if (hobbies.Length > 0) {
        bio += "Hobbies:\n";
      foreach (string h in this.hobbies) {
        bio += $"_{h}\n";
      } 
      return bio;
      } else {
        return bio;
      }
    }

    public void SetHobbies(string[] hobbies) {
      this.hobbies = hobbies;
    }

  }


}