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

        public AppTestBase(bool isReal)
        {

        }
    }
}
