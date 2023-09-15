using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Web.Mvc.App.Entity
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} boş geçilemez")]
        [DisplayName("Kullanıcı Adı")]
        [StringLength(30,ErrorMessage ="{0} enfazla {1} karakterden oluşmalı")]
        [MinLength(3,ErrorMessage ="{0} en az {1} karakterden oluşmalı")]
        public string UserName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="boş geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage ="{0} boş geçilemez")]
        [DisplayName("Şifre")]
        [StringLength(16, ErrorMessage = "{0} enfazla {1} karakterden oluşmalı")]
        [MinLength(8, ErrorMessage = "{0} en az {1} karakterden oluşmalı")]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
