using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public delegate decimal Operation(decimal x,decimal y);
    public partial class MainWindow : Window
    {
        
        string operation;
        decimal firstNumberDec;
        string secoundNumber = "";
        decimal secoundNumberDec;
        decimal globalVariable = 0;
        bool setedFirstSimbol = false;
        bool setedMoreTime = false;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "0";
                secoundNumber += "0";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "0";
            }
            else
            {
                TextBoxResult.Text += "0";
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "1";
                secoundNumber += "1";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "1";
            }
            else
            {
                TextBoxResult.Text += "1";
            }

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "2";
                secoundNumber += "2";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "2";
            }
            else
            {
                TextBoxResult.Text += "2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "3";
                secoundNumber += "3";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "3";
            }
            else
            {
                TextBoxResult.Text += "3";
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "4";
                secoundNumber += "4";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "4";
            }
            else
            {
                TextBoxResult.Text += "4";
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "5";
                secoundNumber += "5";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "5";
            }
            else
            {
                TextBoxResult.Text += "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "6";
                secoundNumber += "6";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "6";
            }
            else
            {
                TextBoxResult.Text += "6";
            }
        }


        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "7";
                secoundNumber += "7";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "7";
            }
            else
            {
                TextBoxResult.Text += "7";
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (ContainsOperation())
            {
                TextBoxResult.Text += "8";
                secoundNumber += "8";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "8";
            }
            else
            {
                TextBoxResult.Text += "8";
            }
        }


        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if(ContainsOperation())
            {
                TextBoxResult.Text += "9";
                secoundNumber += "9";
                return;
            }
            if (IsEmpty())
            {
                TextBoxResult.Text = "9";
            }
            else
            {
                TextBoxResult.Text += "9";
            }
        }

        private bool ContainsOperation()
        {
            return TextBoxResult.Text.Contains("+") || 
                TextBoxResult.Text.Contains("*") || 
                TextBoxResult.Text.Contains("/") || 
                TextBoxResult.Text.Contains("-");
        }

        private bool IsEmpty()
        {
            return TextBoxResult == null || TextBoxResult.Text == "0";
        }

        private bool IsSpecialChar(char c)
        {
            return c == '+' || c == '-' || c == '/' || c == '*';
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                firstNumberDec = Convert.ToDecimal(TextBoxResult.Text);
                operation = "+";
                setedFirstSimbol = true;
                TextBoxResult.Text += operation;
            }
            else
            {
                if(IsSpecialChar(TextBoxResult.Text[index: TextBoxResult.Text.Length-1]))
                {
                    TextBoxResult.Text = null;
                    ClearVariable(0);
                    return;
                }
                if (operation.Equals("+"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "+";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x + y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "+";
                    return;
                }
                if (operation.Equals("-"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "+";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x - y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "+";
                    return;
                }
                if (operation.Equals("*"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "+";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x * y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "+";
                    return;
                }
                if (operation.Equals("/"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "+";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x / y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "+";
                    return;
                }
            }
        }



        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                firstNumberDec = Convert.ToDecimal(TextBoxResult.Text);
                operation = "-";
                TextBoxResult.Text += operation;
            }
            else
            {
                if (IsSpecialChar(TextBoxResult.Text[index: TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text = null;
                    ClearVariable(0);
                    return;
                }
                if (operation.Equals("+"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "-";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x + y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "-";
                    return;
                }
                if (operation.Equals("-"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "-";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x - y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "-";
                    return;
                }
                if (operation.Equals("*"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "-";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x * y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "-";
                    return;
                }
                if (operation.Equals("/"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "-";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x / y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "-";
                    return;
                }
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                firstNumberDec = Convert.ToDecimal(TextBoxResult.Text);
                operation = "*";
                TextBoxResult.Text += operation;
            }
            else
            {
                if (IsSpecialChar(TextBoxResult.Text[index: TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text = null;
                    ClearVariable(0);
                    return;
                }
                if (operation.Equals("+"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "*";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x + y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "*";
                    return;
                }
                if (operation.Equals("-"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "*";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x - y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "*";
                    return;
                }
                if (operation.Equals("*"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "*";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x * y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "*";
                    return;
                }
                if (operation.Equals("/"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "*";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x / y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "*";
                    return;
                }
            }
        }

        private void Divided_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                firstNumberDec = Convert.ToDecimal(TextBoxResult.Text);
                operation = "/";
                TextBoxResult.Text += operation;
            }
            else
            {
                if (IsSpecialChar(TextBoxResult.Text[index: TextBoxResult.Text.Length - 1]))
                {
                    TextBoxResult.Text = null;
                    ClearVariable(0);
                    return;
                }
                if (operation.Equals("+"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "/";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x + y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "/";
                    return;
                }
                if (operation.Equals("-"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "/";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x - y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "/";
                    return;
                }
                if (operation.Equals("*"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "/";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x * y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "/";
                    return;
                }
                if (operation.Equals("/"))
                {
                    setedMoreTime = true;
                    TextBoxResult.Text += "/";
                    secoundNumberDec = Convert.ToDecimal(secoundNumber);
                    secoundNumber = "";
                    Operation addDel = (x, y) => x / y;
                    firstNumberDec = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                    operation = "/";
                    return;
                }
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            secoundNumberDec = Convert.ToDecimal(secoundNumber);
            var result = 0.0m;
            if (operation.Equals("+"))
            {
                Operation addDel = (x, y) => x + y;
                result = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                History.Text = TextBoxResult.Text;
                TextBoxResult.Text = Convert.ToString(result);
                globalVariable = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                ClearVariable(result);
                return;
            }
            if (operation.Equals("-"))
            {
                Operation addDel = (x, y) => x - y;
                result = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                History.Text = TextBoxResult.Text;
                TextBoxResult.Text = Convert.ToString(result);
                globalVariable = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                ClearVariable(result);
                return;
            }
            if (operation.Equals("*"))
            {
                Operation addDel = (x, y) => x * y;
                result = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                History.Text = TextBoxResult.Text;
                TextBoxResult.Text = Convert.ToString(result);
                globalVariable = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                ClearVariable(result);
                return;
            }
            if(operation.Equals("/"))
            {
                Operation addDel = (x, y) => x / y;
                result = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                History.Text = TextBoxResult.Text;
                TextBoxResult.Text = Convert.ToString(result);
                globalVariable = ProcessData.Process(firstNumberDec, secoundNumberDec, addDel);
                ClearVariable(result);
                return;
            }

        }

        private void ClearVariable(decimal result)
        {
            firstNumberDec = result;
            secoundNumber = null;
            operation = null;
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            TextBoxResult.Text = null;
            ClearVariable(0);
            
        }

        
    }
}
