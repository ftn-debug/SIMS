using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.model
{
    
        public class BaseExponentExpression : INotifyPropertyChanged
        {
            private double baseNum;
            private double exponent;


            public double BaseNum
            {
                get { return baseNum; }
                set
                {
                    baseNum = value;
                    OnPropertyChanged("BaseNum");
                }
            }
            public double Exponent
            {
                get { return exponent; }
                set
                {
                    exponent = value;
                    OnPropertyChanged("Exponent");
                }
            }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public BaseExponentExpression() { }
            public BaseExponentExpression(double basenum, double exp)
            {
                this.BaseNum = basenum;
                this.Exponent = exp;
            }

        }
    public class Exp : ObservableCollection<BaseExponentExpression> { }
}

