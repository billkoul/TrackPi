using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FormResponse
{
    public int Result { get; set; }
    public string Msg { get; set; }
    public object Data { get; set; }

    public FormResponse()
    {
        Result = 1;
        Msg = string.Empty;
        Data = null;
    }

}

