using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook

{
    public class Notebook
    {
        private int _year;
        private string _brand;
        private string _OS;
        private string _processor;

        public Notebook()
        {
            this._year = 2016;
            this._brand = "samsung";
            this._OS = "Windows";
            this._processor = "core celeron";
        }
        public Notebook(int year, string OS, string processor)
        {
            this._year=year;
            this._OS = OS;
            this._processor = processor;
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        
        public string Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }
        
        public string OS
        {
            get { return _OS; }
            set { _OS = value; }
        }
        public string GetBrand()
        {
            return _brand;
        }
        public void SetBrand()
        {
            _brand = Brand;
        }

    }

}
