
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApi(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}