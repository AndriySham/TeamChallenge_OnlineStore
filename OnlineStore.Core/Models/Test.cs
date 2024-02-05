using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Core.Models
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        public string TestData { get; set; } = null!;

    }
}
