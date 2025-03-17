namespace PostmanCloneModels;

public class Request
{
    public Guid Id { get; set; }

    /// <summary>
    /// The URL of the API to call
    /// </summary>
    public Uri? Url { get; set; }

    /// <summary>
    /// The body of the request
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// The HTTP method to use
    /// </summary>
    public required string Method { get; set; }

    /// <summary>
    /// The title of the request
    /// </summary>
    public string? Title { get; set; }
}
