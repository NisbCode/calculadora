using System.Globalization;

namespace Calculadora_de__Teste
{
    public partial class Form1 : Form
    {
        int cursor = 0;             // if(cursor == 0) LblOne else LblTwo
        int MAX_ENTRIES = 8;             // Máximo de entradas que cada parte do display pode ter
        //BtnEnter.TabIndex = 1;        // travar o selct do tab de sair do botão enter

        const String zero     = "0";
        const String one      = "1";
        const String two      = "2";
        const String three    = "3";
        const String four     = "4";
        const String five     = "5";
        const String six      = "6";
        const String seven    = "7";
        const String eight    = "8";
        const String nine     = "9";
        const String plus     = "+";
        const String minus    = "-";
        const String mult     = "*";
        const String divis    = "÷";
        const String porc     = "%";
        public Form1()
        {
            InitializeComponent();
        }
        private void AppendNumbers(String number)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);
            if (LblOne.Text != "X" && cursor == 0 && LblOne.Text.Length < MAX_ENTRIES)
                LblOne.Text += number;
            else if(LblOne.Text == "X" && cursor == 0)
                LblOne.Text = number;
            else if (LblTwo.Text != "X" && cursor == 1 && LblTwo.Text.Length < MAX_ENTRIES)
                LblTwo.Text += number;
            else if(LblTwo.Text == "X" && cursor == 1)
                LblTwo.Text = number;
            else
                MessageBox.Show("Limite de valores possíveis alcançado.");
        }
        private void DeleteNumbers()
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);
            int tam_one = LblOne.Text.Length, tam_two = LblTwo.Text.Length;
            if (LblOne.Text.Length > 0 && cursor == 0)
                LblOne.Text = LblOne.Text.Remove(tam_one - 1);
            else if (LblTwo.Text.Length > 0 && cursor == 1)
                LblTwo.Text = LblTwo.Text.Remove(tam_two - 1);
            else
                MessageBox.Show("Ocorreu um erro interno.");
            // Pôr valor vazio já que chegou no limite e Impedir de remover símbolo limite
            if (LblOne.Text.Length == 0 && cursor == 0)
                LblOne.Text = "X";
            else if (LblTwo.Text.Length == 0 && cursor == 1)
                LblTwo.Text = "X";
        }
        private void AddSign(String sign)
        {
            String equals = Convert.ToString(LblEquals.Text);

            // Supondo que já tenha ocorrido um calculo antes, ao apertar pra adicionar um novo sinal, ele continua apartir do resultado gerado
            if (!(String.Equals(equals, "=")))
            {
                resetAll();
                LblOne.Text = equals;
            }
            LblSign.Text = sign;
            cursor = 1;
        }

        private void Send()
        {
            float n1 = Convert.ToInt32(LblOne.Text);
            float n2 = Convert.ToInt32(LblTwo.Text);
            String sign = Convert.ToString(LblSign.Text);
            String equals = Convert.ToString(LblEquals.Text);

            if (String.Equals(sign, plus))
                LblEquals.Text = Convert.ToString(n1 + n2);
            else if (String.Equals(sign, minus))
                LblEquals.Text = Convert.ToString(n1 - n2);
            else if (String.Equals(sign, mult))
                LblEquals.Text = Convert.ToString(n1 * n2);
            else if (String.Equals(sign, divis) || String.Equals(sign, porc))
                LblEquals.Text = Convert.ToString(n1 / n2);
            else
                MessageBox.Show("Símbolo inválido.");

            //Verificando o valor do resultado final
            if (equals.Length > MAX_ENTRIES)
            {
                float float_conv = float.Parse(equals, CultureInfo.InvariantCulture.NumberFormat);
                LblEquals.Text = Convert.ToString(Math.Round(float_conv, 1));
            }
            cursor = 0;
        }
        private void BtnEnter_Click(object sender, EventArgs e) {Send();}
        private void resetAll()
        {
            LblOne.Text = "X";
            LblTwo.Text = "X";
            LblSign.Text = "X";
            LblEquals.Text = "=";
            cursor = 0;
        }

        private void BtnZero_Click(object sender, EventArgs e) {AppendNumbers(zero);}
        private void BtnOne_Click(object sender, EventArgs e) {AppendNumbers(one);}
        private void BtnTwo_Click(object sender, EventArgs e) {AppendNumbers(two);}
        private void BtnThree_Click(object sender, EventArgs e) {AppendNumbers(three);}
        private void BtnFour_Click(object sender, EventArgs e) {AppendNumbers(four);}
        private void BtnFive_Click(object sender, EventArgs e) {AppendNumbers(five);}
        private void BtnSix_Click(object sender, EventArgs e) {AppendNumbers(six);}
        private void BtnSeven_Click(object sender, EventArgs e) {AppendNumbers(seven);}
        private void BtnEight_Click(object sender, EventArgs e) {AppendNumbers(eight);}
        private void BtnNine_Click(object sender, EventArgs e) {AppendNumbers(nine);}

        private void BtnPlus_Click(object sender, EventArgs e) {AddSign(plus);}  
        private void BtnMinus_Click(object sender, EventArgs e) {AddSign(minus);}
        private void BtnMultiplication_Click(object sender, EventArgs e) {AddSign(mult);}
        private void BtnDivision_Click(object sender, EventArgs e) {AddSign(divis);}
        private void BtnPorc_Click(object sender, EventArgs e) {LblTwo.Text = Convert.ToString(100); AddSign(porc);}

        private void BtnC_Click(object sender, EventArgs e) {resetAll();}
        private void BtnBackspace_Click(object sender, EventArgs e) {DeleteNumbers();}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)      AppendNumbers(zero);
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) AppendNumbers(one);
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) AppendNumbers(two);
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) AppendNumbers(three);
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) AppendNumbers(four);
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) AppendNumbers(five);
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) AppendNumbers(six);
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) AppendNumbers(seven);
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) AppendNumbers(eight);
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) AppendNumbers(nine);
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)        AddSign(plus);
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)  AddSign(minus);
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Multiply) AddSign(mult);
            else if (e.KeyCode == Keys.OemPipe || e.KeyCode == Keys.Divide)     AddSign(divis);
            else if (e.KeyCode == Keys.Back)    DeleteNumbers();
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)   Send();
            else
                MessageBox.Show("Input não identificado.");
        }
    }
}