using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Web.Mvc.App.Entity
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="{0} boş geçilemez.")]
        [DisplayName("Kategori Adı")]
        [StringLength(20,ErrorMessage ="{0} en fazla {1} karakterden oluşabilir.")]
        [MinLength(3,ErrorMessage = "{0} en az {2} karakterden oluşmalıdır.")]
        public string CategoryName { get; set; }
        
        public List<CategoryPost> CategoryPosts { get; set;}
    }
}
