using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataTransfer
{
    protected DataTransfer()
    {

    }
    public string dropEffect;
    public string effectAllowed;
    public FileList files;
    public DataTransferItemList items;
    public DOMStringList types;
    public bool clearData(string format = default(string))
    {
        throw new System.NotImplementedException();
    }
    public string getData(string format)
    {
        throw new System.NotImplementedException();
    }
    public bool setData(string format, string data)
    {
        throw new System.NotImplementedException();
    }
}

