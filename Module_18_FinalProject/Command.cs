using System;
using System.Collections.Generic;
using System.Text;

namespace Module_18_FinalProject
{
    abstract class Command
    {
        protected YoutubeService Service;

        public Command(YoutubeService service)
        {
            Service = service;
        }
    }
}
