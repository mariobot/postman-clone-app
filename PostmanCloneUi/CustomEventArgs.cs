using PostmanCloneModels;

namespace PostmanCloneUi
{
    public class CustomEventArgs : EventArgs
    {
        public Request Request { get; }

        public CustomEventArgs(Request request)
        {
            Request = request;
        }
    }
}
