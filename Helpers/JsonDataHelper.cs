using System.Collections.Generic;
using aspnetcookbook.Models;
using Newtonsoft.Json;
using System.IO;

namespace aspnetcookbook
{
  public class JsonDataHelper
  {
    public List<Ingrediant> GetIngrediants()
    {
      return JsonConvert.DeserializeObject<List<Ingrediant>>(File.ReadAllText("./Data/ingrediants.json"));
    }

    public List<Recipe> GetRecipes()
    {
      return JsonConvert.DeserializeObject<List<Recipe>>(File.ReadAllText("../Data/recipes.json"));
    }

    public List<Kitchenware> GetKitchenware()
    {
      return JsonConvert.DeserializeObject<List<Kitchenware>>(File.ReadAllText("../Data/kitchenware.json"));
    }

    public List<Skill> GetSkills()
    {
      return JsonConvert.DeserializeObject<List<Skill>>(File.ReadAllText("../Data/skills.json"));
    }
  }
}