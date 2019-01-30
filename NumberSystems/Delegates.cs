using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VariabelBegreb.Tools;

namespace VariabelBegreb.NumberSystems
{
    public delegate string ConvertFromRadix10ToSpecifiedRadix(int Radix10Number);
    public delegate int ConvertToRadix10(string RadixStringToConvert, RadixNumber_ENUM Radix);

    public class ConstRadixSystemAndDelegates
    {
        ConstRadixSystem ConstRadixSystem_Object { get; set; }
        ConvertFromRadix10ToSpecifiedRadix FunctionPointerFromRadix10 { get; set; }
        ConvertToRadix10 FunctionPointerToRadix10 { get; set; }
        TextBox TextBox_Object { get; set; }

        public ConstRadixSystemAndDelegates(ConstRadixSystem ConstRadixSystem_Object,
                                            TextBox TextBox_Object,
                                            ConvertFromRadix10ToSpecifiedRadix FunctionPointerFromRadix10,
                                            ConvertToRadix10 FunctionPointerToRadix10)
        {
            this.ConstRadixSystem_Object = ConstRadixSystem_Object;
            this.TextBox_Object = TextBox_Object;
            this.FunctionPointerFromRadix10 = FunctionPointerFromRadix10;
            this.FunctionPointerToRadix10 = FunctionPointerToRadix10;
        }
    }

    public class Delegates
    {
        // Denne klasse bruges ikke. Den er kun medtaget for, at der er et sted at samle
        // alle programmets Delegates !!!
    }
}
