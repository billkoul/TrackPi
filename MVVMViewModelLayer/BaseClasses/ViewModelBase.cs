using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMViewModelLayer
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            EventCommand = string.Empty;
        }

        public string EventCommand { get; set; }
        public virtual void HandleRequest() { }
    }

}
