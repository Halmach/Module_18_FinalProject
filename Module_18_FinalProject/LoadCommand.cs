using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_FinalProject
{
    class LoadCommand : ICommand
    {
        YoutubeService Service;

        public LoadCommand(YoutubeService service)
        {
            Service = service;
        }

        public void Cancel()
        {
            
        }

        public void Execute()
        {
            Service.LoadVideoAsync();
        }
    }
}
