using System.Threading.Tasks;

namespace Module_18_FinalProject
{
    internal interface ICommand
    {
        public  Task ExecuteAsync();

        public void Cancel();
    }
}