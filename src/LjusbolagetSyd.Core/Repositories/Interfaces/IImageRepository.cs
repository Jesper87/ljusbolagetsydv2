using System.Collections.Generic;
using LjusbolagetSyd.Core.Models;

namespace LjusbolagetSyd.Core.Repositories.Interfaces
{
	public interface IImageRepository
	{
		void Add(GalleryImageDto image);
		IEnumerable<GalleryImageDto> GetAll(string path);
		GalleryImageDto Get(int id);
		void Delete(int id);
		void Edit(GalleryImageDto image);
	}
}
