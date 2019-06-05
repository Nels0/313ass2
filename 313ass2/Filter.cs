using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _313ass2
{
    enum FilterType { Avg, Linear, Exponential }
    class Filter
    {
        private FilterType _type;
        private int _length;
        public double[] FilterArray;

        public FilterType Type
        {
            get { return _type; }
            set { generateFilter(value, this._length); }
        }


        public int Length
        {
            get { return _length; }
            set { generateFilter(this._type, value); }
        }


        public Filter()
        {
            generateFilter(FilterType.Avg, 10);
        }

        public Filter(FilterType genType, int genLength)
        {
            generateFilter(genType, genLength);
        }
        private void generateFilter(FilterType genType, int genLength)
        {
            if (genLength < 0 || genLength > 10000) //Check length
            {
                throw new System.ArgumentException("Filter length out of range");
            }


            FilterArray = new double[genLength];
            double dLength = (double)genLength;
            _length = genLength;
            _type = genType;

            switch (genType)
            {
                case FilterType.Avg:
                    for (int i = 0; i < genLength; i++)
                    {
                        FilterArray[i] = 1 / dLength;
                    }
                    break;

                case FilterType.Linear:
                    for (int i = 0; i < genLength; i++)
                    {
                        FilterArray[i] = 2 / dLength - (2 * i) / (dLength * dLength);
                    }
                    break;

                case FilterType.Exponential:
                    throw new System.ArgumentException("Filter not implemented");

                //break;

                default:
                    throw new System.ArgumentException("Invalid Filter Type Specified");

            }

            //Array.Reverse(FilterArray); done in convolution


        }
    }
}
