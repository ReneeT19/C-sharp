using System;


namespace OOPDemo
{
 public abstract class Vehicle
    {
        public string Start()
        {
            return "Startting vehicle";
        }
        public string Stop()
        {
            return "Stopping vehicle";
        }
        public abstract string Stroke();
    }
    class TwoWheeler : Vehicle
    {
        public override string Stroke()
        {
            return "This is four stroke vehicle";
        }
    }
    class ThreeWheeler : TwoWheeler
    {
        public override string Stroke()
        {
            return "This is three stroke vehicle";
        }
    }
  sealed  class FourWheeler : ThreeWheeler
    {
        public sealed override string Stroke()
        {
            return "This is five stroke vehicle";
        }
    }
    class SixWheeler //: FourWheeler
    {
        //public sealed override string Stroke()
        //{
        //    return "This is five stroke vehicle";
        //}
    }
    //class SixWheeler : FourWheeler
    //{

    //}
}
