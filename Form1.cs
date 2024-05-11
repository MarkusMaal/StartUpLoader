using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace StartUpLoader
{
    public partial class Form1 : Form
    {
        bool developer_mode = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (developer_mode == true) { devcon.Visible = true; }
            if (File.Exists("C:\\mas\\finish.log")) {
                File.Delete("C:\\mas\\finish.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati finish.log"); }
            }
            if (File.Exists("C:\\mas\\start1.log")) { File.Delete("C:\\mas\\start1.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start1.log"); }
            }
            if (File.Exists("C:\\mas\\start2.log")) { File.Delete("C:\\mas\\start2.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start2.log"); }
            }
            if (File.Exists("C:\\mas\\start3.log")) { File.Delete("C:\\mas\\start3.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start3.log"); }
            }
            if (File.Exists("C:\\mas\\start4.log")) { File.Delete("C:\\mas\\start4.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start4.log"); }
            }
            if (File.Exists("C:\\mas\\start5.log")) { File.Delete("C:\\mas\\start5.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start5.log"); }
            }
            if (File.Exists("C:\\mas\\start6.log")) { File.Delete("C:\\mas\\start6.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start6.log"); }
            }
            if (File.Exists("C:\\mas\\start7.log")) { File.Delete("C:\\mas\\start7.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start7.log"); }
            }
            if (developer_mode == true)
            {
                Process.Start("C:\\mas\\servicestart_simulated.bat");
                if (developer_mode == true) { devcon.Items.Add("Teenused laaditud"); }
                Process cmd = new Process();
                cmd.StartInfo.FileName = "C:\\mas\\startup_optimize_simulate.bat";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.Start();
                if (developer_mode == true) { devcon.Items.Add("Simulatsiooni alustamine..."); }
            }
            else if (developer_mode == false)
            {

            }
            progressBar1.Value = 1;
            if (developer_mode == true) { label6.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        timer2.Enabled = false;
            timer3.Enabled = false;
            if (developer_mode == true) { devcon.Items.Add("Taimerid peatatud"); }
            if (MessageBox.Show("See võib laadimata jätta olulised programmid." + "Kas olete kindel, et soovite jätkata?" + "Soovitatav ainult arendamiseks", "HOIATUS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                label5.Text = "Praegune toiming: Valmis";
                this.Close();
            }
        else
            {

                if (developer_mode == true) { devcon.Items.Add("Taimerid jätkuvad"); }
                timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists("C:\\mas\\service.log"))
            {
                if (developer_mode == false)
                {
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "C:\\mas\\startup_optimize.bat";
                    cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    cmd.Start();
                }
                File.Delete("C:\\mas\\service.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati service.log"); }
                progressBar1.Increment(4);
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Viirusetõrje laadimine...";
                this.TopMost = false;
                this.TopMost = true;
                timer3.Interval = 130;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 1 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start1.log"))
            {
                progressBar1.Increment(10);
                File.Delete("C:\\mas\\start1.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start1.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: CameraMonitor Application käivitamine...";
                timer3.Interval = 30;
                this.TopMost = false;
                this.TopMost = true;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 2 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start2.log"))
            {
                progressBar1.Increment(10);
                File.Delete("C:\\mas\\start2.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start2.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Helidraiverite laadimine...";
                timer3.Interval = 80;
                this.TopMost = false;
                this.TopMost = true;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 3 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start3.log"))
            {
                progressBar1.Increment(15);
                File.Delete("C:\\mas\\start3.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start3.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: ATI CCC laadimine...";
                label5.Text = "Praegune toiming: Valmis";
                this.Close();
                timer3.Interval = 75;
                this.TopMost = false;
                this.TopMost = true;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 4 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start4.log"))
            {
                progressBar1.Increment(10);
                File.Delete("C:\\mas\\start4.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start4.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: LiveTuneriga optimeerimine...";
                timer3.Interval = 220;
                this.TopMost = false;
                this.TopMost = true;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 5 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start5.log"))
            {
                progressBar1.Increment(20);
                File.Delete("C:\\mas\\start5.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start5.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Markuse arvuti integratsiooni laadimine...";
                timer3.Interval = 100;
                this.TopMost = false;
                this.TopMost = true;
                progressBar2.Value = 0;
                if (developer_mode == true) { devcon.Items.Add("Start 6 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start6.log"))
            {
                progressBar1.Increment(20);
                File.Delete("C:\\mas\\start6.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start6.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Markuse arvuti integratsiooni laadimine...";
                if (developer_mode == true) { devcon.Items.Add("Start 7 logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\start7.log"))
            {
                progressBar1.Value = 95;
                this.TopMost = false;
                this.TopMost = true;
                File.Delete("C:\\mas\\start7.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati start7.log"); }
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Töölaua keskkonna laadimine...";
                timer3.Interval = 40;
                progressBar2.Value = 0;
                this.TopMost = false;
                this.TopMost = true;
                if (developer_mode == true) { devcon.Items.Add("Lõpetuse logi otsimine"); }
            }
            else if (File.Exists("C:\\mas\\finish.log"))
            {
                progressBar1.Value = progressBar1.Maximum;
                label4.Text = "Kõik toimingud (" + progressBar1.Value + "%)";
                label5.Text = "Praegune toiming: Valmis";
                File.Delete("C:\\mas\\finish.log");
                if (developer_mode == true) { devcon.Items.Add("Kustutati finish.log"); }
                timer2.Enabled = true;
                if (developer_mode == true) { devcon.Items.Add("Lõpetamine..."); }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                if( checkBox1.Checked == true)
                {
                    this.Close();
                }
                else
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Enabled = true;
                    progressBar1.Visible = false;
                    progressBar2.Visible = false;
                    checkBox1.Visible = false;
                    label1.Text = "Arvuti on kasutamiseks valmis";
                    label2.Text = "Noh, eemaldasid selle linnukese? Kas oled nüüd rahul? Programmide saladuste tegemine on vahel ka lõbus. Tegelikult pole sul nüüd selle programmiga enam midagi teha. Nii et olge rahulikud ja vajutage Valmis nupule, et väljuda";
                    label5.Visible = false;
                    label4.Text = "Protsess on lõpule viidud. Palun vajutage 'Valmis', et jätkata.";
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    timer3.Enabled = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == progressBar2.Maximum)
            {
                
            }
            else
            {
                progressBar2.Increment(1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                button1.Enabled = false;
            }
        }

        private void colortimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.ForeColor == Color.DodgerBlue) {
                progressBar1.ForeColor = Color.Red;
                progressBar2.ForeColor = Color.Red;

            }
            else if (progressBar1.ForeColor == Color.Red)
            {
                progressBar1.ForeColor = Color.Green;
                progressBar2.ForeColor = Color.Green;

            }
            else if (progressBar1.ForeColor == Color.Green)
            {
                progressBar1.ForeColor = Color.Yellow;
                progressBar2.ForeColor = Color.Yellow;

            }
            else if (progressBar1.ForeColor == Color.Yellow)
            {
                progressBar1.ForeColor = Color.Purple;
                progressBar2.ForeColor = Color.Purple;

            }
            else if (progressBar1.ForeColor == Color.Purple)
            {
                progressBar1.ForeColor = Color.Orange;
                progressBar2.ForeColor = Color.Orange;

            }
            else if (progressBar1.ForeColor == Color.Orange)
            {
                progressBar1.ForeColor = Color.DarkBlue;
                progressBar2.ForeColor = Color.DarkBlue;

            }
            else if (progressBar1.ForeColor == Color.DarkBlue)
            {
                progressBar1.ForeColor = Color.DodgerBlue;
                progressBar2.ForeColor = Color.DodgerBlue;

            }
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            colortimer.Enabled = true;
        }

        private void iniTimer_Tick(object sender, EventArgs e)
        {
            if (File.Exists("C:\\mas\\service.log"))
            {
                timer3.Enabled = true;
                timer1.Enabled = true;
                //iniImage.Visible = false;
                //iniText.Visible = false;
                //iniBG.Visible = false;
                iniTimer.Enabled = false;
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(label5.Text != "Praegune toiming: Valmis")
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
