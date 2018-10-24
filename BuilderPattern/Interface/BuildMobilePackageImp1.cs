using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Model;
using BuilderPattern.Base;
namespace BuilderPattern.Interface
{
    public class BuildMobilePackageImp1 : AbstractBasePackage, IBuildMobilePackage
    {
        public void SetShortMsg(){
            this.mobilePackage.SetMsg(100);
        }
        public void SetMusice()
        {
            this.mobilePackage.SetMusic("Friend");
        }
        void IBuildMobilePackage.SetMoney()
        {
            this.mobilePackage.SetMoney(50f);
        }
        public MobilePackage GetMobilePackage()
        {
            return this.mobilePackage;
        }
    }
}
