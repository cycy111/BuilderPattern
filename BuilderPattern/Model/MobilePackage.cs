using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Model
{
    public class MobilePackage
    {
        private int shortessage;
        private string music;
        private float moneny;

        public float GetMoney()
        {
            return this.moneny;
        }
        public void SetMoney(float num)
        {
            this.moneny = num;
        }
        public int Getmsg( )
        {
            return shortessage;
        }
        public void SetMsg( int msg)
        {
            this.shortessage = msg;
        }
        public string GetMusic()
        {
            return music;
        }
        public void SetMusic(string msc)
        {
            this.music = msc;
        }
    }
}
