using System.Collections.Generic;
using System.IO;
using System.Linq;
using LjusbolagetSyd.Core.Models;
using LjusbolagetSyd.Core.Services.Interfaces;

namespace LjusbolagetSyd.Core.Services
{
	public class ImageService : IImageService
	{
		public IEnumerable<GalleryImageDto> GetImagesFromContentFolder(string path)
		{
			var images = new List<GalleryImageDto>();

			if (!Directory.Exists(path)) return images;

			var fileEntries = Directory.GetFiles(path);
			images.AddRange(fileEntries.Select(fileEntry => new GalleryImageDto {ImageUrl = fileEntry}));

			return images;
		}
	}
}
