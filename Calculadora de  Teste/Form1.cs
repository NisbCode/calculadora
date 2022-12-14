using System.Drawing.Drawing2D;
using System.Globalization;

namespace Calculadora_de__Teste
{
    public partial class Calculadora : Form
    {
        int cursor = 0;                 // if(cursor == 0) LblOne else LblTwo
        int MAX_ENTRIES = 8;            // M?ximo de entradas que cada parte do display pode ter
        //BtnEnter.TabIndex = 1;        // travar o select do tab de sair do bot?o enter
        private int startLeft = -300;   // start position do painel
        private int endLeft = 0;        // end position do painel
        private int stepSize = 10;      // pixels para mover

        public static int HasHistValues = 0;
        public static string? SetValueForHist1;
        public static string? SetValueForHist2;
        public static string? SetValueForHistSign;
        public static string? SetValueForHistEquals;
        //public Control HistButton;

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
        const String divis    = "?";
        const String porc     = "%";
        public Calculadora()
        {
            InitializeComponent();
        }

        public void addButtonsHistoric(String lone, String ltwo, String lsign, String lequal)
        {
            HasHistValues += 1;
            // PASSAR DADOS PARA O HIST?RICO
            SetValueForHist1 = lone;
            SetValueForHist2 = ltwo;
            SetValueForHistSign = lsign;
            SetValueForHistEquals = lequal;

            /*
            Button btn = new Button();
            btn.Text = lone + " " + lsign + " " + ltwo + " = " + lequal;*/
            //LabelNoHistoric.Remove()
            // OndeVoceVaiAdicionar.Controls.Add(btn);
            // exemplo:
            //new Historic();
            /*
            (new Historic()).ShowDialog();
            (new Historic()).flowLayoutPanel1.Controls.Add(btn);*/
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, BtnHistoric.Width, BtnHistoric.Height);
            BtnHistoric.Region = new Region(forma);
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
                MessageBox.Show("Limite de valores poss?veis alcan?ado.");
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
            // P?r valor vazio j? que chegou no limite e Impedir de remover s?mbolo limite
            if (LblOne.Text.Length == 0 && cursor == 0)
                LblOne.Text = "X";
            else if (LblTwo.Text.Length == 0 && cursor == 1)
                LblTwo.Text = "X";
        }
        private void AddSign(String sign)
        {
            String equals = Convert.ToString(LblEquals.Text);

            // Supondo que j? tenha ocorrido um calculo antes, ao apertar pra adicionar um novo sinal, ele continua apartir do resultado gerado
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
                MessageBox.Show("S?mbolo inv?lido.");

            //Verificando o valor do resultado final
            if (equals.Length > MAX_ENTRIES)
            {
                float float_conv = float.Parse(equals, CultureInfo.InvariantCulture.NumberFormat);
                LblEquals.Text = Convert.ToString(Math.Round(float_conv, 1));
            }
            cursor = 0;

            addButtonsHistoric(LblOne.Text, LblTwo.Text, sign, LblEquals.Text);
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
                MessageBox.Show("Input n?o identificado.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PainelHistoric.Visible = false;
        }

        private void BtnHistoric_Click(object sender, EventArgs e)
        {
            TimerHistoric.Enabled = true;
        }

        private void TimerHistoric_Tick(object sender, EventArgs e)
        {
            if (PainelHistoric.Visible && PainelHistoric.Left == endLeft)
            {
                PainelHistoric.Left -= stepSize;
                if (PainelHistoric.Left > startLeft) PainelHistoric.Left = startLeft;
                if (PainelHistoric.Left == startLeft)
                {
                    TimerHistoric.Enabled = false;
                    PainelHistoric.Visible = false;
                }
            }

            // if just starting, move to start location and make visible
            if (!PainelHistoric.Visible)
            {
                PainelHistoric.Left = startLeft;
                PainelHistoric.Visible = true;
            }
            // incrementally move
            PainelHistoric.Left += stepSize;
            // make sure we didn't over shoot
            if (PainelHistoric.Left > endLeft) PainelHistoric.Left = endLeft;
            // have we arrived?
            if (PainelHistoric.Left == endLeft) TimerHistoric.Enabled = false;

            /*
            // if just starting, move to start location and make visible
            if (!PainelHistoric.Visible)
            {
                PainelHistoric.Left = startLeft;
                PainelHistoric.Visible = true;
            }

            // incrementally move
            PainelHistoric.Left += stepSize;
            // make sure we didn't over shoot
            if (PainelHistoric.Left > endLeft) PainelHistoric.Left = endLeft;

            // have we arrived?
            if (PainelHistoric.Left == endLeft)
            {
                TimerHistoric.Enabled = false;
            }
            */
        }
        private void BtnSwitchHist_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Historic()).ShowDialog();
            this.Close();
        }
    }
}