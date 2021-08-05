using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("My Family Dictionary");
      var myFamily = new Dictionary<string, Dictionary<string, string>>();
      myFamily.Add("Josh", new Dictionary<string, string>() { { "name", "Josh" }, { "age", "38" }, {"relationship", "Brother"} });
      myFamily.Add("Greg", new Dictionary<string, string>() { { "name", "Greg" }, { "age", "35" }, { "relationship", "Brother" } });
      myFamily.Add("Tori", new Dictionary<string, string>() { { "name", "Tori" }, { "age", "28" }, { "relationship", "Sister" } });
      myFamily.Add("Carol", new Dictionary<string, string>() { { "name", "Carol" }, { "age", "65" }, { "relationship", "Mother" } });
      myFamily.Add("Bill", new Dictionary<string, string>() { { "name", "Bill" }, { "age", "66" }, { "relationship", "Father" } });

      foreach (var (name, info) in myFamily)
      {
        var nameString = "";
        var relationshipString = "";
        var ageString = "";
        foreach (var (stat, value) in info)
        {
          if (stat == "name")
          {
            nameString += $"{value} is my ";
          } else if (stat == "relationship")
          {
            relationshipString += $"{value} and is ";
          } else if (stat == "age")
          {
            ageString += $"{value} years old.";
          }
        }
       Console.WriteLine(nameString + relationshipString + ageString);
      }
    }
  }
}
