using System.Collections.Generic;

namespace Treats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinFlavors = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinFlavors { get; set; }
    
    public virtual ApplicationUser User { get; set; }

    
    // public static IOrderedEnumerable<Recipe> OrderBy<Recipe, Rating>(this IEnumerable<Recipe> recipe, Func<Recipe, Rating> keySelector);
  }
}