using System.Collections.Generic;

namespace ListBindingErrorExample
{
	public class HomeHandler
	{
		public HomeViewModel get_home()
		{
			return new HomeViewModel();
		}

		public PostResultsModel post_album(AlbumModel input)
		{
			return new PostResultsModel {Album = input, SongCount = input.Songs.Count};
		}
	}

	public class HomeViewModel
	{
	}

	public class PostResultsModel
	{
		public AlbumModel Album { get; set; }
		public int SongCount { get; set; }
	}

	public class SongModel
	{
		public string Title { get; set; }
	}

	public class AlbumModel
	{
		public string Title { get; set; }
		public IList<SongModel> Songs { get; set; }
	}
}