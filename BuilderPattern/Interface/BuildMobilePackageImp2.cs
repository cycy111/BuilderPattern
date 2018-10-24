using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Model;
using BuilderPattern.Base;
namespace BuilderPattern.Interface
{
    class BuildMobilePackageImp2 : AbstractBasePackage, IBuildMobilePackage
    {
        public void SetShortMsg()
        {
            this.mobilePackage.SetMsg(200);
        }
        public void SetMusice()
        {
            this.mobilePackage.SetMusic("天使");
        }
        void IBuildMobilePackage.SetMoney()
        {
            this.mobilePackage.SetMoney(70f);
        }
        public MobilePackage GetMobilePackage()
        {
            return this.mobilePackage;
        }
    }
}
