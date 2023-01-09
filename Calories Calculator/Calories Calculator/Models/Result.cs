using System.ComponentModel.DataAnnotations;

namespace Calories_Calculator.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
