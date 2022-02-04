namespace Module_18_FinalProject
{
    internal interface ICommand
    {
        public void Execute();

        public void Cancel();
    }
}