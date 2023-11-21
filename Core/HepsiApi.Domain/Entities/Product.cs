using HepsiApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
	public class Product: EntityBase
	{
		public required string Title { get; set; }
		public required string Description { get; set; }
		public required int BrandId { get; set; }
		public required decimal Price { get; set; }
		public required decimal Discount { get; set; }
		//public required string ImagePath {get;set;}

		//Brand ve product arasında bire bir ilişki var.
		public Brand Brand { get; set; }
		public ICollection<Category> Categories { get; set; }
		//yukarıdaki işlem product ile many-to-many ilişkisi içinde olduğunu gösterir.
	}
}
