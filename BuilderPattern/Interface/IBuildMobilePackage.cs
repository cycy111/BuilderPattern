using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPattern.Model;

namespace BuilderPattern.Interface
{
    public interface IBuildMobilePackage
    {
        void SetShortMsg();
        void SetMusice();
        void SetMoney();

        MobilePackage GetMobilePackage();
    }
}
