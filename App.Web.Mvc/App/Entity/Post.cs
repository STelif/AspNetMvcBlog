using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace App.Web.Mvc.App.Entity
{
	public class Post
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} boş geçilemez")]
		[DisplayName("Post Başlık")]
		[StringLength(25, ErrorMessage = "{0} enfazla {1} karakterden oluşmalı")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakterden oluşmalı")]
		public string PostTitle { get; set; }
		[Required(ErrorMessage = "{0} boş geçilemez.")]
		[DisplayName("Post İçeriği")]
		[StringLength(2000, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
		[MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir.")]
		public string PostContent { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime PostDate { get; set; }
		

		public int UserId { get; set; }
		public User User { get; set; }
		public List<CategoryPost> CategoryPosts { get; set; }


	}
}
