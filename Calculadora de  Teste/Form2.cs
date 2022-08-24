using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de__Teste
{
    public partial class Historic : Form
    {
        private int startLeft = -300;   // start position do painel
        private int endLeft = 0;       // end position do painel
        private int stepSize = 10;      // pixels para mover
        public Historic()
        {
            InitializeComponent();
        }

        private void Historic_Load(object sender, EventArgs e)
        {
            /*
            Button btn = new Button();
            btn.Text = "DEADLY KISS";
            //Control panelHistoric = new Historic().Controls["flowLayoutPanel1"];
            flowLayoutPanel1.Controls.Add(btn);
            */
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, BtnHistoric2.Width, BtnHistoric2.Height);
            BtnHistoric2.Region = new Region(forma);
        }

        private void BtnHistoric2_Click(object sender, EventArgs e)
        {
            TimerHistoric2.Enabled = true;
        }

        private void TimerHistoric2_Tick(object sender, EventArgs e)
        {
            if (PainelHistoric.Visible && PainelHistoric.Left == endLeft)
            {
                PainelHistoric.Left -= stepSize;
                if (PainelHistoric.Left > startLeft) PainelHistoric.Left = startLeft;
                if (PainelHistoric.Left == startLeft)
                {
                    TimerHistoric2.Enabled = false;
                    PainelHistoric.Visible = false;
                }
            }
            if (!PainelHistoric.Visible)
            {
                PainelHistoric.Left = startLeft;
                PainelHistoric.Visible = true;
            }
            PainelHistoric.Left += stepSize;
            if (PainelHistoric.Left > endLeft) PainelHistoric.Left = endLeft;
            if (PainelHistoric.Left == endLeft) TimerHistoric2.Enabled = false;
        }

        private void BtnSwitchToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Calculadora()).ShowDialog();
            this.Close();
        }
    }
}
