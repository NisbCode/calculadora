namespace Calculadora_de__Teste
{
    public partial class Form1 : Form
    {
        String zero     = "0";
        String one      = "1";
        String two      = "2";
        String three    = "3";
        String four     = "4";
        String five     = "5";
        String six      = "6";
        String seven    = "7";
        String eight    = "8";
        String nine     = "9";
        String plus     = "+";
        String minus    = "-";
        String mult     = "*";
        String divis    = "�";
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("S�mbolo inv�lido.");
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = zero;
            else
                LblOne.Text = zero;
        }
        private void BtnOne_Click(object sender, EventArgs e)
        {
            LblOne.Text     = Convert.ToString(LblOne.Text);
            LblTwo.Text     = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = one;
            else
                LblOne.Text = one;
        }
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = two;
            else
                LblOne.Text = two;
        }
        private void BtnThree_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = three;
            else
                LblOne.Text = three;
        }
        private void BtnFour_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = four;
            else
                LblOne.Text = four;
        }
        private void BtnFive_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = five;
            else
                LblOne.Text = five;
        }
        private void BtnSix_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = six;
            else
                LblOne.Text = six;
        }
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = seven;
            else
                LblOne.Text = seven;
        }
        private void BtnEight_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = eight;
            else
                LblOne.Text = eight;
        }
        private void BtnNine_Click(object sender, EventArgs e)
        {
            LblOne.Text = Convert.ToString(LblOne.Text);
            LblTwo.Text = Convert.ToString(LblTwo.Text);

            if (LblOne.Text != "X")
                LblTwo.Text = nine;
            else
                LblOne.Text = nine;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            LblSign.Text = Convert.ToString(LblSign.Text);
            LblSign.Text = plus;
            String equals = Convert.ToString(LblEquals.Text);

            if (!(String.Equals(equals, "=")))
                LblOne.Text = equals;
        }  

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            LblSign.Text = Convert.ToString(LblSign.Text);
            LblSign.Text = minus;
            String equals = Convert.ToString(LblEquals.Text);

            if (!(String.Equals(equals, "=")))
                LblOne.Text = equals;
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            LblSign.Text = Convert.ToString(LblSign.Text);
            LblSign.Text = mult;
            String equals = Convert.ToString(LblEquals.Text);

            if (!(String.Equals(equals, "=")))
                LblOne.Text = equals;
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            LblSign.Text = Convert.ToString(LblSign.Text);
            LblSign.Text = divis;
            String equals = Convert.ToString(LblEquals.Text);

            if (!(String.Equals(equals, "=")))
                LblOne.Text = equals;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            LblOne.Text     = "X";
            LblTwo.Text     = "X";
            LblSign.Text    = "X";
            LblEquals.Text  = "=";
        }
    }
}