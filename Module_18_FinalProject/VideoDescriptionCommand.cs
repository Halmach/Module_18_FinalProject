using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_FinalProject
{
    class VideoDescriptionCommand : ICommand
    {
        YoutubeService Service;
        public VideoDescriptionCommand(YoutubeService service)
        {
            Service = service;
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            Service.GetVideoDescriptionAsync();
        }
    }
}
