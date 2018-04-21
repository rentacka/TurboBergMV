public class DataTransferItem
{
    protected DataTransferItem()
    {

    }
    public string kind;
    public string type;
    public File getAsFile()
    {
        throw new System.NotImplementedException();
    }
    public void getAsString(FunctionStringCallback _callback)
    {
        throw new System.NotImplementedException();
    }
}
