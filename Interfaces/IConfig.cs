using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();

    }

    public class BrowserType
    {
    }
}
