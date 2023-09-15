using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Web.Mvc.App.Entity
{
	public class Page
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Sayfa Başlığı")]
		[StringLength(30, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir.")]
		public string PageTitle { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Sayfa İçeriği")]
		[StringLength(2000, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir.")]
		public string PageContent { get; set; }
    }
}
