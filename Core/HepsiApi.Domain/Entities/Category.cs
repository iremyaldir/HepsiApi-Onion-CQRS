using HepsiApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
	public class Category : EntityBase
	{
		public Category()
		{
		}
		//bu category constructlarını şu yüzden oluşturdum.
		//proje complicated hale geldiğinde ve bir category'i
		//new'lemek istediğimde entities kolay görmek için
		public Category(int parentId, string name, int priority)
		{
			ParentId = parentId;
			Name = name;
			Priority = priority;
		}
		public required int ParentId{ get; set; }
		public required string Name { get; set; }
		public required int Priority { get; set; }
		public ICollection<Detail> Details { get; set; }
		public ICollection<Product> Products { get; set; }
		//yukarıdaki işlem category ile many-to-many ilişkisi içinde olduğunu gösterir.
	}
}
