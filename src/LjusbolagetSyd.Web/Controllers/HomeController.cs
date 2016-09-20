using System.Web.Mvc;
using LjusbolagetSyd.Core.Services.Interfaces;

namespace LjusbolagetSyd.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly IImageService _imageService;
		private string _galleryPath = "~/Content/Images/Gallery";

		public HomeController(IImageService imageService)
		{
			_imageService = imageService;
		}

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult References()
		{
			var relativeGalleryPath = Server.MapPath(_galleryPath);
			var images = _imageService.GetImagesFromContentFolder(relativeGalleryPath);

			foreach (var image in images)
			{
				var strippedImageUrl = image.ImageUrl.Split('\\');
				var imageNameFromUrl = strippedImageUrl[strippedImageUrl.Length - 1];
				image.ImageUrl = _galleryPath.Remove(0, 1) + '/' + imageNameFromUrl;
			}

			return View("References", images);
		}

		public ActionResult Services()
		{
			return View("Services");
		}

		public ActionResult Contact()
		{
			return View("Contact");
		}
	}
}