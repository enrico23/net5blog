using System.ComponentModel.DataAnnotations;

namespace Blog.Utility.Options
{
    public class DatabaseOptions
    {
         public const string Database = "Configuration:DATABASE";
         
        [Required]
        public string BlogDb{ get; set; }
    }
}