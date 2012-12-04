using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 调试字符串
{
    public class Test
    {
        public string GetDebug()
        {
            return string.Format(LangSet.Lang.RM.GetString("Debug Output:{0}"), LangSet.Lang.RM.GetString("Right"));
        }
    }
}
