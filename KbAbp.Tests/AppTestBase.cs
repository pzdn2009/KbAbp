using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;
using Castle.MicroKernel.Registration;
using Effort;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Tests
{
    public abstract class AppTestBase : AbpIntegratedTestBase
    {
        public AppTestBase()
        {

        }

        /// <summary>
        /// 是否为真是DB
        /// </summary>
        /// <param name="isReal"></param>
        public AppTestBase(bool isReal)
        {
        
        }
    }
}
