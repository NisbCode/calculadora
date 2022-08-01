namespace Calculadora_de__Teste
{
    public partial class Form1 : Form
    {
        int cursor = 0;             // if(cursor == 0) LblOne else LblTwo
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
        public Form1()
        {
            InitializeComponent();
        }

        private void appendNumbers(String number)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);
            if (LblOne.Text != "X" && cursor == 0)
                LblOne.Text = LblOne.Text + number;
            else if(LblOne.Text == "X" && cursor == 0)
                LblOne.Text = number;
            else if (LblTwo.Text != "X" && cursor == 1)
                LblTwo.Text = LblTwo.Text + number;
            else if(LblTwo.Text == "X" && cursor == 1)
                LblTwo.Text = number;
            else
                MessageBox.Show("Ocorreu um erro interno.");
        }
        private void addSign(String sign)
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

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            n1 = Convert.ToInt32(LblOne.Text);
            n2 = Convert.ToInt32(LblTwo.Text);
            String sign = Convert.ToString(LblSign.Text);

            if (String.Equals(sign, plus))
                LblEquals.Text = Convert.ToString(n1 + n2);
            else if (String.Equals(sign, minus))
                LblEquals.Text = Convert.ToString(n1 - n2);
            else if (String.Equals(sign, mult))
                LblEquals.Text = Convert.ToString(n1 * n2);
            else if (String.Equals(sign, divis))
                LblEquals.Text = Convert.ToString(n1 / n2);
            else
                MessageBox.Show("Símbolo inválido.");
            cursor = 0;
        }
        private void resetAll()
        {
            LblOne.Text = "X";
            LblTwo.Text = "X";
            LblSign.Text = "X";
            LblEquals.Text = "=";
            cursor = 0;
        }

        private void BtnZero_Click(object sender, EventArgs e) {appendNumbers(zero);}
        private void BtnOne_Click(object sender, EventArgs e) {appendNumbers(one);}
        private void BtnTwo_Click(object sender, EventArgs e) {appendNumbers(two);}
        private void BtnThree_Click(object sender, EventArgs e) {appendNumbers(three);}
        private void BtnFour_Click(object sender, EventArgs e) {appendNumbers(four);}
        private void BtnFive_Click(object sender, EventArgs e) {appendNumbers(five);}
        private void BtnSix_Click(object sender, EventArgs e) {appendNumbers(six);}
        private void BtnSeven_Click(object sender, EventArgs e) {appendNumbers(seven);}
        private void BtnEight_Click(object sender, EventArgs e) {appendNumbers(eight);}
        private void BtnNine_Click(object sender, EventArgs e) {appendNumbers(nine);}

        private void BtnPlus_Click(object sender, EventArgs e) {addSign(plus);}  
        private void BtnMinus_Click(object sender, EventArgs e) {addSign(minus);}
        private void BtnMultiplication_Click(object sender, EventArgs e) {addSign(mult);}
        private void BtnDivision_Click(object sender, EventArgs e) {addSign(divis);}

        private void BtnC_Click(object sender, EventArgs e)
        {
            resetAll();
        }
    }
}