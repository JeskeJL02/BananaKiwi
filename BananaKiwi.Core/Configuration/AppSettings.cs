using System;

namespace BananaKiwi.Core.Configuration
{
    public interface IAppSettings
    {
        ISoundCloud SoundCloud { get; set; }
    }

    public interface ISoundCloud
    {
        string ClientId { get; set; }
    }

    public class AppSettings : IAppSettings
    {
        public SoundCloud SoundCloud { get; set; }
    }

    public class SoundCloud : ISoundCloud
    {
        public string ClientId { get; set; }
    }
}
