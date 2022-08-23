namespace Calculadora_de__Teste
{
    partial class Historic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelNoHistoric = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnHistoric2 = new System.Windows.Forms.Button();
            this.TimerHistoric2 = new System.Windows.Forms.Timer(this.components);
            this.BtnSwitchHist = new System.Windows.Forms.Button();
            this.BtnSwitchHome = new System.Windows.Forms.Button();
            this.PainelHistoric = new System.Windows.Forms.Panel();
            this.PainelHistoric.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelNoHistoric
            // 
            this.LabelNoHistoric.AutoSize = true;
            this.LabelNoHistoric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNoHistoric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelNoHistoric.Location = new System.Drawing.Point(12, 9);
            this.LabelNoHistoric.Name = "LabelNoHistoric";
            this.LabelNoHistoric.Size = new System.Drawing.Size(184, 25);
            this.LabelNoHistoric.TabIndex = 0;
            this.LabelNoHistoric.Text = "Não há valores aqui.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 509);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnHistoric2
            // 
            this.BtnHistoric2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnHistoric2.FlatAppearance.BorderSize = 0;
            this.BtnHistoric2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistoric2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnHistoric2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHistoric2.Location = new System.Drawing.Point(382, 22);
            this.BtnHistoric2.Name = "BtnHistoric2";
            this.BtnHistoric2.Size = new System.Drawing.Size(50, 50);
            this.BtnHistoric2.TabIndex = 5;
            this.BtnHistoric2.Text = " H";
            this.BtnHistoric2.UseVisualStyleBackColor = false;
            this.BtnHistoric2.Click += new System.EventHandler(this.BtnHistoric2_Click);
            // 
            // TimerHistoric2
            // 
            this.TimerHistoric2.Interval = 10;
            this.TimerHistoric2.Tick += new System.EventHandler(this.TimerHistoric2_Tick);
            // 
            // BtnSwitchHist
            // 
            this.BtnSwitchHist.AutoSize = true;
            this.BtnSwitchHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSwitchHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitchHist.Enabled = false;
            this.BtnSwitchHist.FlatAppearance.BorderSize = 0;
            this.BtnSwitchHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSwitchHist.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchHist.ForeColor = System.Drawing.Color.White;
            this.BtnSwitchHist.Location = new System.Drawing.Point(0, 60);
            this.BtnSwitchHist.Name = "BtnSwitchHist";
            this.BtnSwitchHist.Size = new System.Drawing.Size(250, 60);
            this.BtnSwitchHist.TabIndex = 1;
            this.BtnSwitchHist.Text = "HISTÓRICO";
            this.BtnSwitchHist.UseVisualStyleBackColor = false;
            // 
            // BtnSwitchHome
            // 
            this.BtnSwitchHome.AutoSize = true;
            this.BtnSwitchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSwitchHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitchHome.FlatAppearance.BorderSize = 0;
            this.BtnSwitchHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSwitchHome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchHome.ForeColor = System.Drawing.Color.White;
            this.BtnSwitchHome.Location = new System.Drawing.Point(0, 0);
            this.BtnSwitchHome.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSwitchHome.Name = "BtnSwitchHome";
            this.BtnSwitchHome.Size = new System.Drawing.Size(250, 60);
            this.BtnSwitchHome.TabIndex = 0;
            this.BtnSwitchHome.Text = "HOME";
            this.BtnSwitchHome.UseVisualStyleBackColor = false;
            this.BtnSwitchHome.Click += new System.EventHandler(this.BtnSwitchHome_Click);
            // 
            // PainelHistoric
            // 
            this.PainelHistoric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelHistoric.AutoSize = true;
            this.PainelHistoric.Controls.Add(this.BtnSwitchHist);
            this.PainelHistoric.Controls.Add(this.BtnSwitchHome);
            this.PainelHistoric.Location = new System.Drawing.Point(0, -1);
            this.PainelHistoric.MaximumSize = new System.Drawing.Size(250, 570);
            this.PainelHistoric.MinimumSize = new System.Drawing.Size(250, 570);
            this.PainelHistoric.Name = "PainelHistoric";
            this.PainelHistoric.Size = new System.Drawing.Size(250, 570);
            this.PainelHistoric.TabIndex = 6;
            this.PainelHistoric.Visible = false;
            // 
            // Historic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(454, 561);
            this.Controls.Add(this.PainelHistoric);
            this.Controls.Add(this.BtnHistoric2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LabelNoHistoric);
            this.Name = "Historic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historic";
            this.Load += new System.EventHandler(this.Historic_Load);
            this.PainelHistoric.ResumeLayout(false);
            this.PainelHistoric.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNoHistoric;
        public FlowLayoutPanel flowLayoutPanel1;
        private Button BtnHistoric2;
        private System.Windows.Forms.Timer TimerHistoric2;
        private Button BtnSwitchHist;
        private Button BtnSwitchHome;
        private Panel PainelHistoric;
    }
}