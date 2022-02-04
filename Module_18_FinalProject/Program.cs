using System;
using YoutubeExplode;

namespace Module_18_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var youtube = new YoutubeService(new YoutubeClient());
            ICommand command = null;

            while (true)
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1 - Отобразить описание видео");
                Console.WriteLine("2 - Скачать видео");
                Console.WriteLine("3 - Выйти и программы");

                var selectedCommand = Console.ReadLine();
                switch(selectedCommand.Trim().ToLower())
                {
                    case "1": command = new VideoDescriptionCommand(youtube); break;
                    case "2": command = new LoadCommand(youtube); break;
                    case "3": Console.WriteLine("Программа завершена"); return;
                    default: Console.Clear(); continue;
                }

                client.PrepareCommand(command);
                client.Execute();

                Console.WriteLine("Команда завершена, нажмите любую клавишу");
                Console.ReadLine();
                Console.Clear();
            }
        }


    }
}
