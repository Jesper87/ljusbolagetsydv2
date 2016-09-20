using System;
using System.Collections.Generic;
using LjusbolagetSyd.Core.Models;
using LjusbolagetSyd.Core.Repositories.Interfaces;

namespace LjusbolagetSyd.Core.Repositories
{
	public class ImageRepository: IImageRepository
	{
		public void Add(GalleryImageDto image)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<GalleryImageDto> GetAll(string path)
		{
			throw new NotImplementedException();
		}

		public GalleryImageDto Get(int id)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public void Edit(GalleryImageDto image)
		{
			throw new NotImplementedException();
		}
	}
}
