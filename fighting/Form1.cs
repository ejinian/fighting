using fighting.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighting
{
    public partial class fight : Form
    {
        //Form Editing
        public fight()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\showtime.wav");
            //begin.Play();
            //axWindowsMediaPlayer1.URL = (@"C:/\Users\Ernest\Music\combat.wav");
            //axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        //Variables
        bool turn = true;
        int ammoLeft = 1;
        int ammoRight = 1;
        int healingTimesLeft = 4;
        int healingTimesRight = 4;
        int specialLeft = 1;
        int specialRight = 1;
        TimeSpan left = new TimeSpan(0, 2, 30);
        TimeSpan right = new TimeSpan(0, 2, 30);

        private void ChangeTurn()
        {
            happiFac3StatusHeal.Text = string.Format("Healing: {0}", healingTimesLeft);
            happiFac3StatusAmmo.Text = string.Format("Ammo: {0}", ammoLeft);
            XTermintorStatusHeal.Text = string.Format("Healing: {0}", healingTimesRight);
            XTermintorStatusAmmo.Text = string.Format("Ammo: {0}", ammoRight);

            if (turn)
            {
                fireHappiFac3.Enabled = false;
                healingHappiFac3.Enabled = false;
                reloadHappiFac3.Enabled = false;
                happiFac3Special.Enabled = false;
                fireXTerminator.Enabled = true;
                healingXTerminator.Enabled = true;
                reloadXTerminator.Enabled = true;
                XTerminatorSpecial.Enabled = true;

                if (ammoRight <= 0)
                {
                    fireXTerminator.Enabled = false;
                }
                if (healingTimesRight <= 0)
                {
                    healingXTerminator.Enabled = false;
                }
                if (specialRight <= 0)
                {
                    XTerminatorSpecial.Enabled = false;
                }

            }
            else
            {
                fireHappiFac3.Enabled = true;
                healingHappiFac3.Enabled = true;
                reloadHappiFac3.Enabled = true;
                happiFac3Special.Enabled = true;
                fireXTerminator.Enabled = false;
                healingXTerminator.Enabled = false;
                reloadXTerminator.Enabled = false;
                XTerminatorSpecial.Enabled = false;

                if (ammoLeft <= 0)
                {
                    fireHappiFac3.Enabled = false;
                }
                else
                {
                    fireHappiFac3.Enabled = true;
                }
                if (healingTimesLeft <= 0)
                {
                    healingHappiFac3.Enabled = false;
                }
                if (specialLeft <= 0)
                {
                    happiFac3Special.Enabled = false;
                }
            }
            turn = !turn;
        }

        //Player moves

        private void fireHappiFac3_Click(object sender, EventArgs e)
        {
            ammoLeft--;
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\fire.wav");
            //begin.Play();

            if (progressBarXTerminator.Value - 17 <= 0)
            {
                deathLabel.Text = "☠☢☣☢☠";
                yourTurnLabel.Text = "";
                timer1.Start();
                int num = (progressBarXTerminator.Value - 17);
                progressBarXTerminator.Value -= (17 - Math.Abs(num));
                xHealthLabel.Text = progressBarXTerminator.Value.ToString();
                fireHappiFac3.Enabled = false;
                healingHappiFac3.Enabled = false;
                reloadHappiFac3.Enabled = false;
                happiFac3Special.Enabled = false;
                outoftime.Text = "DOCTOR SALT WINS";
                turnTimer.Enabled = false;
                return;
            }
            else
            {
                progressBarXTerminator.Value += -17;
                xHealthLabel.Text = progressBarXTerminator.Value.ToString();
            }
            if (progressBarXTerminator.Value <= 25)
            {
                
            }
            else if (progressBarXTerminator.Value <= 80)
            {

            }
           
            yourTurnLabel.Text = "It's your turn, X-Terminator!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void healingHappiFac3_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\heal.wav");
            //begin.Play();
            healingTimesLeft--;
            if (progressBarHappiFac3.Value <= 15)
            {
                progressBarHappiFac3.Value += 85;
                happiHealthLabel.Text = progressBarHappiFac3.Value.ToString();
            }
            else
            {
                progressBarHappiFac3.Value = 100;
                happiHealthLabel.Text = progressBarHappiFac3.Value.ToString();
            }
            if (progressBarHappiFac3.Value <= 25)
            {
                
            }
            if (progressBarHappiFac3.Value <= 80)
            {
                
            }
            if (progressBarHappiFac3.Value == 100)
            {
                
            }
            yourTurnLabel.Text = "It's your turn, X-Terminator!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void fireXTerminator_Click(object sender, EventArgs e)
        {
            ammoRight--;
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\fire.wav");
            //begin.Play();
            if (progressBarHappiFac3.Value - 19 <= 0)
            {
                deathLabel.Text = "☠☢☣☢☠";
                yourTurnLabel.Text = "";
                timer2.Start();
                int num = (progressBarHappiFac3.Value - 19);
                progressBarHappiFac3.Value -= (19 - Math.Abs(num));
                happiHealthLabel.Text = progressBarHappiFac3.Value.ToString();
                fireXTerminator.Enabled = false;
                healingXTerminator.Enabled = false;
                reloadXTerminator.Enabled = false;
                XTerminatorSpecial.Enabled = false;
                outoftime.Text = "X-TERMINATOR WINS";
                turnTimer.Enabled = false;
                return;
            }
            else
            {
                progressBarHappiFac3.Value += -19;
                happiHealthLabel.Text = progressBarHappiFac3.Value.ToString();
            }
            if (progressBarHappiFac3.Value <= 25)
            {
                
            }
            else if (progressBarHappiFac3.Value <= 80)
            {
                
            }
            
            yourTurnLabel.Text = "It's your turn, Doctor Salt!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void healingXTerminator_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\heal.wav");
            //begin.Play();
            healingTimesRight--;
            
            if (progressBarXTerminator.Value <= 50)
            {
                progressBarXTerminator.Value += 50;
                xHealthLabel.Text = progressBarXTerminator.Value.ToString();
            }
            else
            {
                progressBarXTerminator.Value = 100;
                xHealthLabel.Text = progressBarXTerminator.Value.ToString();
            }
            if (progressBarXTerminator.Value <= 25)
            {
                
            }
            if (progressBarXTerminator.Value <= 80)
            {
                
            }
            if (progressBarXTerminator.Value == 100)
            {

            }
            yourTurnLabel.Text = "It's your turn, Doctor Salt!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void reloadHappiFac3_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\reload.wav");
            //begin.Play();
            ammoLeft += 1;
            yourTurnLabel.Text = "It's your turn, X-Terminator!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void reloadXTerminator_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\reload.wav");
            //begin.Play();
            ammoRight += 2;
            yourTurnLabel.Text = "It's your turn, Doctor Salt!";
            ChangeTurn();
            specialLabel.Text = "";
        }

        private void happiFac3Special_Click(object sender, EventArgs e)
        {
            healingTimesLeft += 1;
            yourTurnLabel.Text = "It's your turn, X-Terminator!";
            specialLabel.Text = "☢ Doctor Salt can now heal once more! ☢";
            ChangeTurn();
            specialLeft--;
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\mystery_box.wav");
            //begin.Play();
            label5.Text = "No specials";
        }

        private void XTerminatorSpecial_Click(object sender, EventArgs e)
        {
            progressBarHappiFac3.Value = 10;
            happiHealthLabel.Text = progressBarHappiFac3.Value.ToString();
            progressBarXTerminator.Value += -6;
            xHealthLabel.Text = progressBarXTerminator.Value.ToString();
            yourTurnLabel.Text = "It's your turn, Doctor Salt";
            specialLabel.Text = "☢  X-terminator blew up Doctor Salt!  ☢";
            ChangeTurn();
            specialRight--;
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\explosion.wav");
            //begin.Play();
            label6.Text = "No Specials";
        }

        //Timer and Instructions

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            instructions form = new instructions();
            form.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;
        }
        private void turnTimer_Tick(object sender, EventArgs e)
        {
            if (turn)
            {
                left -= TimeSpan.FromSeconds(1);
                ticktock_left.Text = left.ToString();
                if (left.Seconds < 10 && left.Minutes < 1)
                {
                    ticktock_left.BackColor = Color.Red;
                    ticktock_left.ForeColor = Color.Black;
                }
                if (left.Seconds == 0 && left.Minutes < 1)
                {
                    left += TimeSpan.FromSeconds(1);
                    progressBarHappiFac3.Value = 0;
                    happiHealthLabel.Text = "0";
                    deathLabel.Text = "☠☢☣☢☠";
                    //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\creepy_noise.wav");
                    //begin.Play();
                    this.BackgroundImage = Resources.real_specimen_vic;
                    fireHappiFac3.Enabled = false;
                    healingHappiFac3.Enabled = false;
                    reloadHappiFac3.Enabled = false;
                    happiFac3Special.Enabled = false;
                    outoftime.Text = "X-TERMINATOR WINS";
                    yourTurnLabel.Text = "";
                }
            }
            else
            {
                right -= TimeSpan.FromSeconds(1);
                ticktock_right.Text = right.ToString();
                if (right.Seconds < 10 && right.Minutes < 1)
                {
                    ticktock_right.BackColor = Color.Red;
                    ticktock_right.ForeColor = Color.Black;
                }
                if (right.Seconds == 0 &&  right.Minutes < 1)
                {
                    right += TimeSpan.FromSeconds(1);
                    progressBarXTerminator.Value = 0;
                    xHealthLabel.Text = "0";
                    deathLabel.Text = "☠☢☣☢☠";
                    //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\creepy_noise.wav");
                    //begin.Play();
                    this.BackgroundImage = Resources.real_specimen_vic;
                    fireXTerminator.Enabled = false;
                    healingXTerminator.Enabled = false;
                    reloadXTerminator.Enabled = false;
                    XTerminatorSpecial.Enabled = false;
                    outoftime.Text = "DOCTOR SALT WINS";
                    yourTurnLabel.Text = "";
                }
            }
        }
    }
}
