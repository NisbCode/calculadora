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
            this.BtnHistoric2 = new System.Windows.Forms.Button();
            this.TimerHistoric2 = new System.Windows.Forms.Timer(this.components);
            this.TlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSwitchHist = new System.Windows.Forms.Button();
            this.BtnSwitchHome = new System.Windows.Forms.Button();
            this.PainelHistoric = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSwitchToHome = new System.Windows.Forms.Button();
            this.TlpButtons.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PainelHistoric.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // TlpButtons
            // 
            this.TlpButtons.ColumnCount = 1;
            this.TlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpButtons.Controls.Add(this.button1, 0, 0);
            this.TlpButtons.Location = new System.Drawing.Point(2, 51);
            this.TlpButtons.Name = "TlpButtons";
            this.TlpButtons.RowCount = 2;
            this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpButtons.Size = new System.Drawing.Size(457, 513);
            this.TlpButtons.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "example";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.BtnSwitchHist, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnSwitchHist
            // 
            this.BtnSwitchHist.AutoSize = true;
            this.BtnSwitchHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSwitchHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitchHist.FlatAppearance.BorderSize = 0;
            this.BtnSwitchHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSwitchHist.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchHist.ForeColor = System.Drawing.Color.White;
            this.BtnSwitchHist.Location = new System.Drawing.Point(0, 40);
            this.BtnSwitchHist.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSwitchHist.Name = "BtnSwitchHist";
            this.BtnSwitchHist.Size = new System.Drawing.Size(200, 60);
            this.BtnSwitchHist.TabIndex = 2;
            this.BtnSwitchHist.Text = "HISTÓRICO";
            this.BtnSwitchHist.UseVisualStyleBackColor = false;
            // 
            // BtnSwitchHome
            // 
            this.BtnSwitchHome.AutoSize = true;
            this.BtnSwitchHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSwitchHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitchHome.Enabled = false;
            this.BtnSwitchHome.FlatAppearance.BorderSize = 0;
            this.BtnSwitchHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSwitchHome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchHome.ForeColor = System.Drawing.Color.White;
            this.BtnSwitchHome.Location = new System.Drawing.Point(0, 0);
            this.BtnSwitchHome.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSwitchHome.Name = "BtnSwitchHome";
            this.BtnSwitchHome.Size = new System.Drawing.Size(200, 60);
            this.BtnSwitchHome.TabIndex = 1;
            this.BtnSwitchHome.Text = "HOME";
            this.BtnSwitchHome.UseVisualStyleBackColor = false;
            // 
            // PainelHistoric
            // 
            this.PainelHistoric.AutoSize = true;
            this.PainelHistoric.Controls.Add(this.tableLayoutPanel3);
            this.PainelHistoric.Location = new System.Drawing.Point(0, 0);
            this.PainelHistoric.Margin = new System.Windows.Forms.Padding(0);
            this.PainelHistoric.Name = "PainelHistoric";
            this.PainelHistoric.Size = new System.Drawing.Size(253, 565);
            this.PainelHistoric.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BtnSwitchToHome, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 565);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "HISTÓRICO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnSwitchToHome
            // 
            this.BtnSwitchToHome.AutoSize = true;
            this.BtnSwitchToHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BtnSwitchToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSwitchToHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitchToHome.FlatAppearance.BorderSize = 0;
            this.BtnSwitchToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSwitchToHome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSwitchToHome.ForeColor = System.Drawing.Color.White;
            this.BtnSwitchToHome.Location = new System.Drawing.Point(0, 0);
            this.BtnSwitchToHome.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSwitchToHome.Name = "BtnSwitchToHome";
            this.BtnSwitchToHome.Size = new System.Drawing.Size(253, 60);
            this.BtnSwitchToHome.TabIndex = 1;
            this.BtnSwitchToHome.Text = "HOME";
            this.BtnSwitchToHome.UseVisualStyleBackColor = false;
            this.BtnSwitchToHome.Click += new System.EventHandler(this.BtnSwitchToHome_Click);
            // 
            // Historic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(454, 561);
            this.Controls.Add(this.PainelHistoric);
            this.Controls.Add(this.BtnHistoric2);
            this.Controls.Add(this.TlpButtons);
            this.Controls.Add(this.LabelNoHistoric);
            this.Name = "Historic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historic";
            this.Load += new System.EventHandler(this.Historic_Load);
            this.TlpButtons.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PainelHistoric.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNoHistoric;
        private Button BtnHistoric2;
        private System.Windows.Forms.Timer TimerHistoric2;
        private TableLayoutPanel TlpButtons;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnSwitchHist;
        private Button BtnSwitchHome;
        private Panel PainelHistoric;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button2;
        private Button BtnSwitchToHome;
    }
}