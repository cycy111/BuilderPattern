using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Model;
using BuilderPattern.Interface;
using BuilderPattern.Director;
namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePkgDirector mobilePkgDirector = new MobilePkgDirector();

            BuildMobilePackageImp1 buildMobilePackageImp1 = new BuildMobilePackageImp1();
            MobilePackage mobilePackage= mobilePkgDirector.CreatMobilePkg(buildMobilePackageImp1);
            PrintMobilePkgMsg(mobilePackage);
            BuildMobilePackageImp2 buildMobilePackageImp2 = new BuildMobilePackageImp2();
            mobilePackage = mobilePkgDirector.CreatMobilePkg(buildMobilePackageImp2);
            PrintMobilePkgMsg(mobilePackage);


        }
        public static void PrintMobilePkgMsg(MobilePackage mobilePackage)
        {
            Console.WriteLine("--费用：{0}     短信：{1}      彩铃：{2}",mobilePackage.GetMoney(),mobilePackage.Getmsg(),mobilePackage.GetMusic());
        }
    }
}
