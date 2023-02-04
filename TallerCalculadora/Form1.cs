using System.Reflection;

namespace TallerCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Valor 1";
            textBox2.PlaceholderText = "Valor 2";
           

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("suma");
            comboBox1.Items.Add("resta");
            comboBox1.Items.Add("division");
            comboBox1.Items.Add("multiplicacion");
          

        }

        public void limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            bool isNumeric = double.TryParse(textBox1.Text, out _);
           
        }

        private Boolean validarTipo()
        {
            bool isNumericA = double.TryParse(textBox1.Text, out _);
            bool isNumericB = double.TryParse(textBox2.Text, out _);
            if(isNumericA & isNumericB)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)

        {

            Calculadora calculadora = new Calculadora();



            if (!validarTipo())

            {
                MessageBox.Show("Campos Invalidos ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                calculadora.SetNumero1(double.Parse(textBox1.Text));
                calculadora.SetNumero2(double.Parse(textBox2.Text));
                switch (comboBox1.SelectedIndex)
                {
                    case 0:


                        MessageBox.Show("El Resultado es : " + calculadora.sumar().ToString());



                        break;
                    case 1:
                        MessageBox.Show("El Resultado es : " + calculadora.restar().ToString(),"",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:

                        
                       if (calculadora.validar(calculadora.GetNumero1(), calculadora.GetNumero2()))
                        {
                            MessageBox.Show("El Resultado es :  " + calculadora.dividir().ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            
                            MessageBox.Show("Division por '0' no permitida ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        

                        break;
                    case 3:
                        MessageBox.Show("El Resultado es : "+calculadora.multiplicacion().ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case -1:
                        MessageBox.Show("Seleccione el Tipo de Operación", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                limpiar();
            }

            




           

        }
    }
}