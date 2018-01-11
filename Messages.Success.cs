namespace akka_sandbox_1.Messages.Success 
{
    public class InputSuccess
    {
        public string Reason {get; internal set;}
        public InputSuccess(string reason)
        {
            this.Reason = reason;
        }

    }
}