using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LjusbolagetSyd.Core.Models;
using LjusbolagetSyd.Core.Repositories.Interfaces;

namespace LjusbolagetSyd.Core.Repositories
{
	public class ImageRepository : IImageRepository
	{
		public void Add(GalleryImageDto image)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<GalleryImageDto> GetAll(string path)
		{
			var images = new List<GalleryImageDto>();
			if (!Directory.Exists(path)) return images;
			var fileEntries = Directory.GetFiles(path);
			if (fileEntries.Length > 0)
				images.AddRange(fileEntries.Select(fileEntry => new GalleryImageDto { ImageUrl = fileEntry }));
			return images;
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
