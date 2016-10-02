using System.Collections.Generic;
using System.IO;
using System.Linq;
using LjusbolagetSyd.Core.Models;
using LjusbolagetSyd.Core.Repositories.Interfaces;
using LjusbolagetSyd.Core.Services.Interfaces;

namespace LjusbolagetSyd.Core.Services
{
	public class ImageService : IImageService
	{
		private readonly IImageRepository _imageRepository;

		public ImageService(IImageRepository imageRepository)
		{
			_imageRepository = imageRepository;
		}

		public IEnumerable<GalleryImageDto> GetImagesFromContentFolder(string path)
		{
			var images = _imageRepository.GetAll(path);
			return images ?? Enumerable.Empty<GalleryImageDto>();
			
		}
	}
}
