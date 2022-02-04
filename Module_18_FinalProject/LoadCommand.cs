using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_FinalProject
{
    class LoadCommand : Command, ICommand 
    {
        public LoadCommand(YoutubeService service) : base(service)
        {
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public async Task ExecuteAsync()
        {
            await Service.LoadVideoAsync();
        }
    }
}
