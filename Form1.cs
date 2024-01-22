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



        }

    }
}
