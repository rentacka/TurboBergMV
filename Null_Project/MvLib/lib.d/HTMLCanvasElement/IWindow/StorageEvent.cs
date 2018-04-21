
public class StorageEvent : Event
{
    protected StorageEvent() : base()
    {

    }
    public string url;
    public string key;
    public string oldValue;
    public string newValue;
    public Storage storageArea;
}
