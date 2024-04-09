using System.ComponentModel.DataAnnotations;

namespace WebApiEndPoints.Model
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

    }
}
