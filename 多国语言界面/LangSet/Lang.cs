using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;

namespace LangSet
{
    public class Lang
    {
        static ResourceManager m_ResourceManager;
        public static ResourceManager RM
        {
            get
            {
                if (m_ResourceManager == null)
                {
                    m_ResourceManager = GetResourceManager();
                }
                return m_ResourceManager;
            }
        }

        public static ResourceManager GetResourceManager()
        {
            return new ResourceManager("多国语言界面.Lang.Strings", Assembly.GetEntryAssembly());
        }
    }
}

