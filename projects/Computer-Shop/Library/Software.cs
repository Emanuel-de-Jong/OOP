using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Software : Product
    {
        public byte FileSize { get; set; }
        public Type SoftwareType { get; set; }

        public Software(byte _fileSize, Type _SoftwareType, int _id, string _productName, string _description, double _priceExclBTW) 
            :base(_id, _productName, _description, _priceExclBTW)
        {
            FileSize = _fileSize;
            SoftwareType = _SoftwareType;
        }
    }
}
