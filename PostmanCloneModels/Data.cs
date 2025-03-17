
using System.Collections.ObjectModel;

namespace PostmanCloneModels;

public class Data
{
    public ObservableCollection<Request> Requests { get; set; } = new();    
}
