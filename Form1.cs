namespace pedraPapelTesoura
{
    public partial class Game : Form
    {

        Image[] imgCpu = new Image[]
        {
            Properties.Resources.PedraC,
            Properties.Resources.PapelC,
            Properties.Resources.TesouraC
        };

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void PicJogador_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;

            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));//Jogador
            Jogada jogadaAdversario = RetornaJogadaDoAdversario();//CPU

            Resultado resultado = RetornaGanhador(jogadaJogador,jogadaAdversario);

            if (resultado == Resultado.VitoriaCpu)
            {
                LbPtCpu.Text = (int.Parse(LbPtCpu.Text) + 1).ToString();
            }
            else if(resultado == Resultado.VitoriaJogador){
                LbPtJogador.Text = (int.Parse(LbPtJogador.Text) + 1).ToString();
            }
            else
            {
                LbEmpate.Text = (int.Parse(LbEmpate.Text) + 1).ToString();
            }
        }

        private Resultado RetornaGanhador(Jogada jogador, Jogada adversario)
        {
            if (jogador == Jogada.Pedra)
            {
                if (adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaCpu;
                }

                else if (adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            else if (jogador == Jogada.Papel)
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }

                else if(adversario == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCpu;
                }
            }
            else
            {
                if (adversario == Jogada.Pedra)
                {
                    return Resultado.VitoriaCpu;
                }
                else if(adversario == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empate;

        }

        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDoAdversario()
        {
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            PicCpu.Image = imgCpu[escolha];
            return (Jogada)escolha;
        }

        private void PicCpu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }
    enum Resultado
    {
        VitoriaJogador,
        VitoriaCpu, 
        Empate
    }

}