using System.Collections.Generic;

namespace aspnetcookbook.Models
{
  public class ListModel<T>
  {
    public string ModelName { get; set; }
    public List<T> Items { get; set; }
  }
}