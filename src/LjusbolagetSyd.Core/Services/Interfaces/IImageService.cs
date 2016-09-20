using System.Collections.Generic;
using LjusbolagetSyd.Core.Models;

namespace LjusbolagetSyd.Core.Services.Interfaces
{
	public interface IImageService
	{
		IEnumerable<GalleryImageDto> GetImagesFromContentFolder(string path);
	}
}
