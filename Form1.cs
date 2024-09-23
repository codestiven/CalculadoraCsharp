namespace Calculadora
{
    public partial class Calculadora : Form
    {
        string operacion = "null";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void salida_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void entrada_numero(object sender, EventArgs e)
        {
            string entrada = ((Button)sender).Text;
            char x = salida.Text.Substring(0, 1)[0];
            if (x == '0') {

                salida.Text = salida.Text.Substring(1);
            }

            salida.Text += entrada;
        }


        private void operaciones(object sender, EventArgs e)
        {

            string entrada = ((Button)sender).Text;



            if (entrada == "%")
            {
                demo.Text = salida.Text;
                salida.Text = "0";
                operacion = "%";
            }


            if (entrada == "+")
            {
                demo.Text = salida.Text;
                salida.Text = "0";
                operacion = "+";
            }

            if (entrada == "-")
            {
                demo.Text = salida.Text;
                salida.Text = "0";
                operacion = "-";
            }

            if (entrada == "X")
            {
                demo.Text = salida.Text;
                salida.Text = "0";
                operacion = "x";
            }
            if (entrada == "/" || entrada == "1/x")
            {
                demo.Text = salida.Text;
                salida.Text = "0";
                operacion = "/";
            }
            if (entrada == "x^2")
            {
                demo.Text = salida.Text;

                float num1 = int.Parse(salida.Text);
                num1 = (float)Math.Pow(num1, 2);
                salida.Text = num1.ToString();
                operacion = "^2";
            }
            if (entrada == "2√x")
            {
                demo.Text = salida.Text;

                float num1 = int.Parse(salida.Text);
                num1 = (float)Math.Sqrt(num1);
                salida.Text = num1.ToString();
                operacion = "^2";
            }






        }
        private void resultado(object sender, EventArgs e)
        {
            if (operacion == "+")
            {
                string enum1 = demo.Text ;
                float num1 = float.Parse(enum1);


                float num2 = float.Parse(salida.Text);
                float total = num1 + num2;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }

            if (operacion == "-")
            {
                string enum1 = demo.Text;
                float num1 = float.Parse(enum1);


                float num2 = float.Parse(salida.Text);
                float total = num1 - num2;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }


            if (operacion == "x")
            {
                string enum1 = demo.Text;
                float num1 = float.Parse(enum1);


                float num2 = float.Parse(salida.Text);
                float total = num1 * num2;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }

            if (operacion == "/")
            {
                string enum1 = demo.Text;
                float num1 = float.Parse(enum1);


                float num2 = float.Parse(salida.Text);
                float total = num1 / num2;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }

            if (operacion == "%")
            {
                string enum1 = demo.Text;
                float num1 = float.Parse(enum1);


                float num2 = float.Parse(salida.Text);
                float total = (num1 * 100) / num2;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }

            if (operacion == "^2")
            {
                string enum1 = demo.Text;
                float num1 = float.Parse(enum1);


                float total = num1;
                salida.Text = "";
                salida.Text = total.ToString();

                demo.Text = salida.Text;
            }

        }

        private void CE_Click(object sender, EventArgs e)
        {
            salida.Text = "0";
            operacion = "";
            demo.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            salida.Text = "0";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (salida.TextLength != 0) { salida.Text = salida.Text.Substring(0, salida.Text.Length - 1); }
  
       
  

        }

        private void signo_Click(object sender, EventArgs e)
        {
            char x = salida.Text.Substring(0, 1)[0];
            if (x != '-') { 
            string c = salida.Text;
            salida.Text = $"-{c}";

            }
            else
            {
           
                    string c = salida.Text;
                    salida.Text = salida.Text.Substring(1);
                    

          
            }
        }
    }
}