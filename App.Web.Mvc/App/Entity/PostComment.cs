using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Web.Mvc.App.Entity
{
    public class PostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} boş geçilemez")]
        [DisplayName("Yorum İçeriği")]
        [StringLength(100, ErrorMessage = "{0} enfazla {1} karakterden oluşmalı")]
        [MinLength(1, ErrorMessage = "{0} en az {2} karakterden oluşmalı")]
        public string Yorum { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
