using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
  public class Post
  {
    [ScaffoldColumn(false)]
    public int PostId { get; set; }

    [Required, StringLength(10000)]
    public string title { get; set; }

    [Required, StringLength(10000), DataType(DataType.MultilineText)]
    public string text { get; set; }

    public System.DateTime date { get; set; }
  }
}