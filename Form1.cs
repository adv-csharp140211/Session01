using App01.UI;
using Microsoft.VisualBasic;

namespace App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Variable
            <type> <name> = <value>;
            int a = 1;
            int b;

            type: 
                Value Type:
                    int, bool, float, double, structure, *string 
                        Stack
                Refrence Type:
                    `new`
                    Object
                        Heap       


               Product p1 = new Product();
               p1.Price = 1000;

               Product p2 = p1;
               p2.Price = 2000;

               p1.Price ? 2000
             */

            //Explicit - صریح
            int a = 10;

            //Implicit - ضمنی
            var b = 20;

            //var d; 🐞  ctrl+k c (vs 2022)
            //var c;  ctrl+/ (vscode)

            /*
             *  Naming Case
             *      PascalCase -> interface, class, method (public), property, record, struct
             *      camelCase -> variable, method private
             *      train_case ❌
             *      kebab-case ❌ css
             *      CONST_CASE -> const 
             */

            //Boxing
            var name = "ali";
            object obj = name;

            //Unboxing
            var name2 = (string)obj;
            /*
             * Runtime Error 
             * Readablily 
             */

            //Convert
            var name3 = Convert.ToString(obj);
            /*
             * Runtime Error 
             * Readablily 
             * Performance
             */
            //Genrics


            var p1 = new Product();
            p1.Name = "xyz";

            var p2 = new Product("abc", 100);

            //bject Initializer
            var p3 = new Product
            {
                Name = "monitor",
                Price = 1000
            };


            var p4 = new Product2("keyboard", 2000);


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.ADD).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.SUB).ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.MUL).ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.DIV).ToString();
        }

        //Refactoring
        //بهینه کردن ساختار کد بدون تغییر در رفتار کد


        private double calc(string strA, string strB, string op)
        {
            var a = Convert.ToInt32(strA);
            var b = Convert.ToInt32(strB);
            //double result = 0;
            //switch (op)
            //{
            //    case "+": 
            //        result = a + b; 
            //        break;
            //    case "-":
            //        result = a - b;
            //        break;
            //    case "*":
            //        result = a * b;
            //        break;
            //    case "/":
            //        result = a / b;
            //        break;
            //    default: throw new ArgumentException("op is not defined");
            //}
            //return result;

            switch (op)
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                default: throw new ArgumentException("op is not defined");
            }
        }


        //Overload
        private double calc(string strA, string strB, CalcOp op)
        {
            var a = Convert.ToInt32(strA);
            var b = Convert.ToInt32(strB);
            switch (op)
            {
                case CalcOp.ADD: return a + b;
                case CalcOp.SUB: return a - b;
                case CalcOp.MUL: return a * b;
                case CalcOp.DIV: return a / b;
                default: throw new ArgumentException("op is not defined");
            }
        }

        private double calcPattern(string strA, string strB, CalcOp op)
        {
            var a = Convert.ToInt32(strA);
            var b = Convert.ToInt32(strB);
            return op switch
            {
                CalcOp.ADD => a + b,
                CalcOp.SUB => a - b,
                CalcOp.MUL => a * b,
                CalcOp.DIV => (double)(a / b),
                _ => throw new ArgumentException("op is not defined"),
            };
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            var form = new FormUser();
            form.ShowDialog();
            //WPF
            //MAUI (win, linux, osx, android)
        }
    }

    enum CalcOp
    {
        ADD,
        SUB,
        MUL,
        DIV
    }

    //Acces level

    public class Product
    {
        //property -> snippet
        //prop, propfull
        public string Name { get; set; }
        public int Price { get; set; }


        public Product()
        {
            
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        //field
        int xyz = 0;
        int _xyz = 0;

        //method
        //method / function

        private int Add(int a, int b)
        {           
            return a + b;
        }


        private int calc(int a, int b, string op)
        {
            return a + b;
        }


        //delgate
        //event

    }

    //Record - 
    //C# 12 - .net 8
    class Product2(string Name, int Price)
    {
    }
}
