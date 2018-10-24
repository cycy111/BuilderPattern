using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Interface;
using BuilderPattern.Model;
namespace BuilderPattern.Director
{
    class MobilePkgDirector
    {
        public MobilePackage CreatMobilePkg(IBuildMobilePackage buildMobilePackage)
        {
            //设置费用
            buildMobilePackage.SetMoney();
            //设置铃声
            buildMobilePackage.SetMusice();
            //设置短信
            buildMobilePackage.SetShortMsg();
            //返回套餐
           return buildMobilePackage.GetMobilePackage();
        }
    }
}
