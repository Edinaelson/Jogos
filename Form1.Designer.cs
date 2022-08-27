namespace pedraPapelTesoura
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtPedra = new System.Windows.Forms.Button();
            this.BtPapel = new System.Windows.Forms.Button();
            this.BtTesoura = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicCpu = new System.Windows.Forms.PictureBox();
            this.LbDescricaoJogador = new System.Windows.Forms.Label();
            this.LbDescricaoCpu = new System.Windows.Forms.Label();
            this.LbPtJogador = new System.Windows.Forms.Label();
            this.LbPtCpu = new System.Windows.Forms.Label();
            this.LbText = new System.Windows.Forms.Label();
            this.LbEmpate = new System.Windows.Forms.Label();
            this.LbPedra = new System.Windows.Forms.Label();
            this.LbPapel = new System.Windows.Forms.Label();
            this.LbTesoura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPedra
            // 
            this.BtPedra.BackColor = System.Drawing.Color.White;
            this.BtPedra.BackgroundImage = global::pedraPapelTesoura.Properties.Resources.PedraJ;
            this.BtPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPedra.Location = new System.Drawing.Point(21, 231);
            this.BtPedra.Name = "BtPedra";
            this.BtPedra.Size = new System.Drawing.Size(120, 120);
            this.BtPedra.TabIndex = 0;
            this.BtPedra.Tag = "0";
            this.BtPedra.UseVisualStyleBackColor = false;
            this.BtPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtPapel
            // 
            this.BtPapel.BackColor = System.Drawing.Color.White;
            this.BtPapel.BackgroundImage = global::pedraPapelTesoura.Properties.Resources.PapelJ;
            this.BtPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPapel.Location = new System.Drawing.Point(171, 231);
            this.BtPapel.Name = "BtPapel";
            this.BtPapel.Size = new System.Drawing.Size(120, 120);
            this.BtPapel.TabIndex = 1;
            this.BtPapel.Tag = "1";
            this.BtPapel.UseVisualStyleBackColor = false;
            this.BtPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtTesoura
            // 
            this.BtTesoura.BackColor = System.Drawing.Color.White;
            this.BtTesoura.BackgroundImage = global::pedraPapelTesoura.Properties.Resources.TesouraJ;
            this.BtTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtTesoura.Location = new System.Drawing.Point(333, 231);
            this.BtTesoura.Name = "BtTesoura";
            this.BtTesoura.Size = new System.Drawing.Size(120, 120);
            this.BtTesoura.TabIndex = 2;
            this.BtTesoura.Tag = "2";
            this.BtTesoura.UseVisualStyleBackColor = false;
            this.BtTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(12, 21);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            this.PicJogador.Click += new System.EventHandler(this.PicJogador_Click);
            // 
            // PicCpu
            // 
            this.PicCpu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCpu.Location = new System.Drawing.Point(303, 21);
            this.PicCpu.Name = "PicCpu";
            this.PicCpu.Size = new System.Drawing.Size(150, 150);
            this.PicCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCpu.TabIndex = 4;
            this.PicCpu.TabStop = false;
            this.PicCpu.Click += new System.EventHandler(this.PicCpu_Click);
            // 
            // LbDescricaoJogador
            // 
            this.LbDescricaoJogador.AutoSize = true;
            this.LbDescricaoJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDescricaoJogador.Location = new System.Drawing.Point(171, 84);
            this.LbDescricaoJogador.Name = "LbDescricaoJogador";
            this.LbDescricaoJogador.Size = new System.Drawing.Size(66, 21);
            this.LbDescricaoJogador.TabIndex = 5;
            this.LbDescricaoJogador.Text = "Jogador";
            // 
            // LbDescricaoCpu
            // 
            this.LbDescricaoCpu.AutoSize = true;
            this.LbDescricaoCpu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDescricaoCpu.Location = new System.Drawing.Point(262, 84);
            this.LbDescricaoCpu.Name = "LbDescricaoCpu";
            this.LbDescricaoCpu.Size = new System.Drawing.Size(38, 21);
            this.LbDescricaoCpu.TabIndex = 6;
            this.LbDescricaoCpu.Text = "Cpu";
            // 
            // LbPtJogador
            // 
            this.LbPtJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPtJogador.Location = new System.Drawing.Point(181, 114);
            this.LbPtJogador.Name = "LbPtJogador";
            this.LbPtJogador.Size = new System.Drawing.Size(40, 20);
            this.LbPtJogador.TabIndex = 8;
            this.LbPtJogador.Text = "0";
            this.LbPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPtJogador.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbPtCpu
            // 
            this.LbPtCpu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPtCpu.Location = new System.Drawing.Point(257, 114);
            this.LbPtCpu.Name = "LbPtCpu";
            this.LbPtCpu.Size = new System.Drawing.Size(40, 20);
            this.LbPtCpu.TabIndex = 8;
            this.LbPtCpu.Text = "0";
            this.LbPtCpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPtCpu.Click += new System.EventHandler(this.label4_Click);
            // 
            // LbText
            // 
            this.LbText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbText.Location = new System.Drawing.Point(181, 175);
            this.LbText.Name = "LbText";
            this.LbText.Size = new System.Drawing.Size(100, 23);
            this.LbText.TabIndex = 9;
            this.LbText.Text = "Empates";
            this.LbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbText.Click += new System.EventHandler(this.LbText_Click);
            // 
            // LbEmpate
            // 
            this.LbEmpate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmpate.Location = new System.Drawing.Point(181, 198);
            this.LbEmpate.Name = "LbEmpate";
            this.LbEmpate.Size = new System.Drawing.Size(100, 23);
            this.LbEmpate.TabIndex = 10;
            this.LbEmpate.Text = "0";
            this.LbEmpate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbEmpate.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbPedra
            // 
            this.LbPedra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPedra.Location = new System.Drawing.Point(30, 354);
            this.LbPedra.Name = "LbPedra";
            this.LbPedra.Size = new System.Drawing.Size(100, 23);
            this.LbPedra.TabIndex = 11;
            this.LbPedra.Text = "Pedra";
            this.LbPedra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPapel
            // 
            this.LbPapel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPapel.Location = new System.Drawing.Point(181, 354);
            this.LbPapel.Name = "LbPapel";
            this.LbPapel.Size = new System.Drawing.Size(100, 23);
            this.LbPapel.TabIndex = 12;
            this.LbPapel.Text = "Pepel";
            this.LbPapel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbPapel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbTesoura
            // 
            this.LbTesoura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTesoura.Location = new System.Drawing.Point(344, 354);
            this.LbTesoura.Name = "LbTesoura";
            this.LbTesoura.Size = new System.Drawing.Size(100, 23);
            this.LbTesoura.TabIndex = 13;
            this.LbTesoura.Text = "Tesoura";
            this.LbTesoura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(465, 401);
            this.Controls.Add(this.LbTesoura);
            this.Controls.Add(this.LbPapel);
            this.Controls.Add(this.LbPedra);
            this.Controls.Add(this.LbEmpate);
            this.Controls.Add(this.LbText);
            this.Controls.Add(this.LbPtCpu);
            this.Controls.Add(this.LbPtJogador);
            this.Controls.Add(this.LbDescricaoCpu);
            this.Controls.Add(this.LbDescricaoJogador);
            this.Controls.Add(this.PicCpu);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.BtTesoura);
            this.Controls.Add(this.BtPapel);
            this.Controls.Add(this.BtPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Game";
            this.Text = "PedraPapelTesoura";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtPedra;
        private Button BtPapel;
        private Button BtTesoura;
        private PictureBox PicJogador;
        private PictureBox PicCpu;
        private Label LbDescricaoJogador;
        private Label LbDescricaoCpu;
        private Label LbPtJogador;
        private Label LbPtCpu;
        private Label LbText;
        private Label LbEmpate;
        private Label LbPedra;
        private Label LbPapel;
        private Label LbTesoura;
    }
}