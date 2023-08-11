using Maui.Apps.Framework.Services;
using MonkeyCache;
using UPlayer.IServices;

namespace UPlayer.Services;

public class YoutubeServices : RestServiceBase, IApiService
{
	public YoutubeServices(IConnectivity connectivity, IBarrel cacheBarrel) : base(connectivity, cacheBarrel)
	{
	}
}

