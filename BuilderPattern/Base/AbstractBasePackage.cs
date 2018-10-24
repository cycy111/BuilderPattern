using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Model;
namespace BuilderPattern.Base
{
    public class AbstractBasePackage
    {
        protected MobilePackage mobilePackage;
        public AbstractBasePackage()
        {
            this.mobilePackage = new MobilePackage();
        }
    }
}
