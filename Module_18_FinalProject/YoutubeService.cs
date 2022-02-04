using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module_18_FinalProject
{
    class YoutubeService
    {
        YoutubeClient youtubeClient;

        public YoutubeService(YoutubeClient youtubeClient)
        {
            this.youtubeClient = youtubeClient;
        }

        public async Task GetVideoDescriptionAsync()
        {
            Console.WriteLine("Введите ссылку на видео:");
            var link = Console.ReadLine();
            try
            {
                var information = await youtubeClient.Videos.GetAsync(link);
                Console.WriteLine("Название видео:" + information.Title);
                Console.WriteLine("Автор видео:" + information.Author.Title);
                Console.WriteLine("Продолжительность:" + information.Duration);
            }
            catch
            {
                Console.WriteLine("Неверная ссылка");
            }
        }

        public async Task LoadVideoAsync()
        {
            Console.WriteLine("Введите ссылку на видео:");
            var link = Console.ReadLine();
            try
            {
                await youtubeClient.Videos.DownloadAsync(link, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
                Console.WriteLine("Загрузка завершена");

            }
            catch
            {
                Console.WriteLine("Неверная ссылка");
            }
        }
    }
}
