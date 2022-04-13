using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;



namespace CRMSampleCode
{
    public class AccountPlugin : IPlugin
    {
        void IPlugin.Execute(IServiceProvider serviceProvider)
        {
              throw new NotImplementedException();
        }
    }
}
