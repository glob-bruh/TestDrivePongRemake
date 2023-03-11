using System.Diagnostics;
using System.Media;

namespace graphics2
{
    public partial class Form1 : Form
    {
        // GLOBALS:
        int RPLAYSCORE = 0;
        int LPLAYSCORE = 0;
        bool TMRLOADDONE = false;
        bool TMRFLASH = true;

        Ball ball;
        Paddle lPaddle;
        Paddle rPaddle;
        SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.song);
        Scoreboard scoreL;
        Scoreboard scoreR;

        public enum KeyMove { none, up, down }
        KeyMove leftKeyMove = KeyMove.none;
        KeyMove rightKeyMove = KeyMove.none;
        
        public Form1()
        {
            InitializeComponent();
            if (Debugger.IsAttached) {
                lblDebug.Enabled = true;
                lblDebug.Visible = true;
            }
            Ball.mainForm = this;
            Paddle.mainForm = this;
            Scoreboard.mainForm = this;

            // add the following commands to any program that is drawing graphics
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Paint += Form1_Paint;
            timer1.Enabled = true;

            ball = new Ball(ClientSize.Width / 2, 200);
            lPaddle = new Paddle(80, 166);
            rPaddle = new Paddle(this.ClientSize.Width - 80, 166);
            scoreL = new Scoreboard(300, 155, 35, 50);
            scoreR = new Scoreboard(490, 155, 35, 50);
        }

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            scoreL.Draw(e.Graphics, LPLAYSCORE);
            scoreR.Draw(e.Graphics, RPLAYSCORE);
            ball.Draw(e.Graphics);
            lPaddle.Draw(e.Graphics);
            rPaddle.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Invalidate(false);   // this will force the Paint event to fire

            // WINDETECT - In the original game, both scores are reset to 0 once 10 has been reached.
            if (ball.X < 25 || ball.X > ClientSize.Width - 25) {
                if (ball.X < 25) {
                    RPLAYSCORE++;
                }
                if (ball.X > ClientSize.Width - 25) {
                    LPLAYSCORE++;
                }
                if (LPLAYSCORE == 10 || RPLAYSCORE == 10) {
                    LPLAYSCORE = 0;
                    RPLAYSCORE = 0;
                }
                ball.WinReset();
            }
            lblDebug.Text = $"BallX: {ball.X}\nBallY: {ball.Y}\nClientWidth: {ClientSize.Width} (/2={ClientSize.Width / 2})\nClientHeight: {ClientSize.Height}\nScoreL: {LPLAYSCORE}\nScoreR: {RPLAYSCORE}";


            if (leftKeyMove == KeyMove.up) lPaddle.MoveUp();
            else if (leftKeyMove == KeyMove.down) lPaddle.MoveDown();
            if (rightKeyMove == KeyMove.up) rPaddle.MoveUp();
            else if (rightKeyMove == KeyMove.down) rPaddle.MoveDown();
            // LPADDLE COLLISION
            if (CollisionTest(lPaddle, ball)) {
                double slice = (ball.Y + (ball.Height / 2)) - lPaddle.Y;
                slice /= lPaddle.Height;
                if (slice < 0) {
                    slice = 0;
                }
                if (slice > 1) {
                    slice = 1;
                }
                slice -= 0.5;
                ball.ChangeDirection(slice);
            }
            // RPADDLE COLLISION
            if (CollisionTest(rPaddle, ball)) {
                double slice = (ball.Y + (ball.Height / 2)) - rPaddle.Y;
                slice /= rPaddle.Height;
                if (slice < 0) {
                    slice = 0;
                }
                if (slice > 1) {
                    slice = 1;
                }
                slice -= 0.5;
                ball.ChangeDirection(slice);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.W) leftKeyMove = KeyMove.up;
            else if (e.KeyCode == Keys.S) leftKeyMove = KeyMove.down;
            if (e.KeyCode == Keys.Up) rightKeyMove = KeyMove.up;
            else if (e.KeyCode == Keys.Down) rightKeyMove = KeyMove.down;
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) leftKeyMove = KeyMove.none;
            else if (e.KeyCode == Keys.S) leftKeyMove = KeyMove.none;
            if (e.KeyCode == Keys.Up) rightKeyMove = KeyMove.none;
            else if (e.KeyCode == Keys.Down) rightKeyMove = KeyMove.none;
        }

        private bool CollisionTest(Paddle myPaddle, Ball myBall)
        {
            if (myPaddle.X + myPaddle.Width < myBall.X)
                return false;
            if (myBall.X + myBall.Width < myPaddle.X)
                return false;
            if (myPaddle.Y + myPaddle.Height < myBall.Y)
                return false;
            if (myBall.Y + myBall.Height < myPaddle.Y)
                return false;
            return true;
        }

        private void tmrLoader_Tick(object sender, EventArgs e) {
            if (TMRLOADDONE == true) {
                if (TMRFLASH == true) {
                    picPressStart.Visible = false;
                    TMRFLASH = false;
                } else {
                    picPressStart.Visible = true;
                    TMRFLASH = true;
                }
            } else {
                picLoading.Visible = false;
                picPressStart.Visible = true;
                tmrLoader.Interval = 1000;
                musicPlayer.PlayLooping();
                TMRLOADDONE = true;
            }
        }
    }
}