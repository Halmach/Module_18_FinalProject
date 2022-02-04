using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_FinalProject
{
    class VideoDescriptionCommand : Command, ICommand
    {
        public VideoDescriptionCommand(YoutubeService service) : base(service)
        {
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public async Task ExecuteAsync()
        {
            await Service.GetVideoDescriptionAsync();
        }
    }
}
