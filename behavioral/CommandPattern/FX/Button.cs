namespace CommandPattern.FX
{
    public class Button(ICommand command)
    {
        private readonly ICommand command = command;
        public string label = null!;

        public void Click()
        {
            command.Execute();
        }

        public string GetLabel()
        {
            return label;
        }
        public void SetLabel(string label)
        {
            this.label = label;
        }
    }
}
