using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Hardware : Product, ISize
    {
        public float Weight { get; set; }
        public EHardwareType Type { get; set; }
        public Warranty Warranty { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }

        public Hardware(float _weight, EHardwareType _type, Warranty _warranty, float _width, float _height, float _length, int _id, string _productName, string _description, double _priceExclBTW)
            :base(_id, _productName, _description, _priceExclBTW)
        {
            Weight = _weight;
            Type = _type;
            Warranty = _warranty;
            Width = _width;
            Height = _height;
            Length = _length;
        }
    }
}
