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
            var p3= new Product { 
                Name = "monitor",
                Price = 1000
            };


            var p4 = new Product2("keyboard", 2000);
            

        }

    }


    class Product
    {
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

    }

    //Record - 
    //C# 12 - .net 8
    class Product2(string Name, int Price)
    {
    }
}
