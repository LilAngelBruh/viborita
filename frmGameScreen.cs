using System;
using System.Drawing;
using System.Windows.Forms;

namespace viborita
{
    public partial class frmGameScreen : Form
    {
        Random randApple = new Random();
        Snake snake = new Snake();
        Apple apple;
        Graphics papel;
        int score = 0;
        bool jugando = false;
        int width = 0;
        int height = 0;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;

        public frmGameScreen()
        {
            InitializeComponent();
            boxGameScreen.Visible = false;
            lblStart.Visible = true;
            apple = new Apple(randApple);
            width = boxGameScreen.Width;
            height = boxGameScreen.Height;
        }

        private void boxGameScreen_Paint(object sender, PaintEventArgs e)
        {
            papel = e.Graphics;
            snake.DrawSnake(papel);
            apple.DrawApple(papel);
        }

        private void frmGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                jugando = true;
                lblStart.Visible = false;
                boxGameScreen.Visible = true;
                StartGame();
            }
            if (e.KeyData == Keys.Left && !right)
            {
                left = true;
                up = false;
                down = false;
            }
            if (e.KeyData == Keys.Right && !left)
            {
                right = true;
                up = false;
                down = false;
            }
            if (e.KeyData == Keys.Up && !down)
            {
                right = false;
                up = true;
                left = false;
            }
            if (e.KeyData == Keys.Down && !up)
            {
                right = false;
                down = true;
                left = false;
            }
        }

        private void StartGame()
        {
            if (jugando)
            {
                left = false;
                up = false;
                down = false;
                right = true;
                tmrJugando.Start();
            }
        }

        private void tmrJugando_Tick(object sender, EventArgs e)
        {
            MoveSnake();
            CheckCollision();
            boxGameScreen.Invalidate();
        }

        private void MoveSnake()
        {
            if (left)
                snake.MoveLeft();
            if (right)
                snake.MoveRight();
            if (up)
                snake.MoveUp();
            if (down)
                snake.MoveDown();
        }

        private void CheckCollision()
        {
            if (snake.SnakeCollision(width, height))
            {
                GameOver();
                return;
            }

            if (snake.SnakeBody[0].IntersectsWith(apple.AppleBody))
            {
                Score();
            }
        }

        private void Score()
        {
            score++;
            lblPuntaje.Text = score.ToString("000");
            snake.GrowSnake();
            apple = new Apple(randApple);
        }

        private void LastScore()
        {
            int LastScore = score;
            lblLastScore.Text = LastScore.ToString("000");
        }

        private void MaxScore()
        {
            int MaxScore = score;
            if (MaxScore > Convert.ToInt32(lblMaxScore.Text)){
                lblMaxScore.Text = MaxScore.ToString("000");
            }
        }

        private void GameOver()
        {
            jugando = false;
            tmrJugando.Stop();
            tmrJugando.Enabled = false;
            MessageBox.Show("¡Perdiste!");
            MaxScore();
            LastScore();
            score = 0;
            lblPuntaje.Text = "000";
            snake = new Snake();
            boxGameScreen.Visible = false;
            lblStart.Visible = true;
        }
    }
}
