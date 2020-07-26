using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiffusionBallGameWindowsFormsApp
{
    public partial class diffusionMainForm : Form
    {
        List<GasMoleculePictureBoxBall> allMoleculeBalls;
        List<RedGasMoleculeBall> redGasMoleculeBalls;
        List<BlueGasMoleculeBall> blueGasMoleculeBalls;
        int quantityOfBalls = 10;
        int numberOfRedBallsRightBorder = 0;
        int numberOfRedBallsLeftBorder = 0;
        int numberOfRedBallsUpperBorder = 0;
        int numberOfRedBallsDownBorder = 0;
        int numberOfBlueBallsRightBorder = 0;
        int numberOfBlueBallsLeftBorder = 0;
        int numberOfBlueBallsUpperBorder = 0;
        int numberOfBlueBallsDownBorder = 0;
        int counterIsMovingOnOrOff;
        int counterOfRedBallsOnOppositeSide = 0;
        int counterOfBlueBallsOnOppositeSide = 0;


        public diffusionMainForm()
        {
            InitializeComponent();
        }        
   
        private void diffusionMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
            foreach (var ball in allMoleculeBalls)
            {
                ball.ChangeBallsMoving();
                if (ball.IsBallAlreadyStopped())
                {
                    counterIsMovingOnOrOff = 2;
                }
                else
                {
                    counterIsMovingOnOrOff = 1;
                }                
            }          
            
            if (counterIsMovingOnOrOff == 2)
            {
                MessageBox.Show("Давление красного газа на стенки сосудов: "
                    + (numberOfRedBallsRightBorder + numberOfRedBallsLeftBorder + numberOfRedBallsUpperBorder + numberOfRedBallsDownBorder)
                    + ". Давление синего газа на стенки сосудов: "
                    + (numberOfBlueBallsLeftBorder + numberOfBlueBallsRightBorder + numberOfBlueBallsUpperBorder + numberOfBlueBallsDownBorder)
                    + ".");
            }
        }


        private void BlueGasMoleculeBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Left:
                    numberOfBlueBallsLeftBorder++;
                    break;
                case HitType.Right:
                    numberOfBlueBallsRightBorder++;
                    break;
                case HitType.Up:
                    numberOfBlueBallsUpperBorder++;
                    break;
                case HitType.Down:
                    numberOfBlueBallsDownBorder++;
                    break;
            }
        }

        private void RedGasMoleculeBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Left:
                    numberOfRedBallsLeftBorder++;
                    break;
                case HitType.Right:
                    numberOfRedBallsRightBorder++;
                    break;
                case HitType.Up:
                    numberOfRedBallsUpperBorder++;
                    break;
                case HitType.Down:
                    numberOfRedBallsDownBorder++;
                    break;
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in redGasMoleculeBalls)
            {
                if (ball.IsRedMoleculeBallOnOppositeSide(this))
                {
                    counterOfRedBallsOnOppositeSide++;
                }
            }
            foreach (var ball in blueGasMoleculeBalls)
            {
                if (ball.IsBlueMoleculeBallOnOppositeSide(this))
                {
                    counterOfBlueBallsOnOppositeSide++;
                }
            }
            if (counterOfBlueBallsOnOppositeSide == (quantityOfBalls / 2) && counterOfBlueBallsOnOppositeSide == counterOfRedBallsOnOppositeSide)
            {
                foreach (var ball in allMoleculeBalls)
                {
                    ball.Stop();
                }
                MainTimer.Enabled = false;                
            }
            else
            {
                counterOfBlueBallsOnOppositeSide = 0;
                counterOfRedBallsOnOppositeSide = 0;
            }
            if (!MainTimer.Enabled)
            {
                MessageBox.Show("Перемешивание завершено!");
            }

        }

        private void diffusionMainForm_Load(object sender, EventArgs e)
        {
            blueGasMoleculeBalls = new List<BlueGasMoleculeBall>();
            redGasMoleculeBalls = new List<RedGasMoleculeBall>();
            allMoleculeBalls = new List<GasMoleculePictureBoxBall>();
            for (int i = 0; i < quantityOfBalls; i++)
            {
                var redGasMoleculeBall = new RedGasMoleculeBall(this);
                redGasMoleculeBall.OnHited += RedGasMoleculeBall_OnHited;
                redGasMoleculeBalls.Add(redGasMoleculeBall);
                allMoleculeBalls.Add(redGasMoleculeBall);
                redGasMoleculeBall.Show();
                var blueGasMoleculeBall = new BlueGasMoleculeBall(this);
                blueGasMoleculeBall.OnHited += BlueGasMoleculeBall_OnHited;
                blueGasMoleculeBalls.Add(blueGasMoleculeBall);
                allMoleculeBalls.Add(blueGasMoleculeBall);
                blueGasMoleculeBall.Show();
            }
        }
    }
}
