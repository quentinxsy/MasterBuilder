using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterBuilder
{
    public partial class Form2 : Form
    {
        // Set countdown Timer
        private Timer timer;
        private TimeSpan interval;
        private TimeSpan remaining;
        private bool closingRequested = false;

        public Form2()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; //Tick every second
            timer.Tick += Timer_Tick;
            TimerBox.Text = "00:00:00"; // Set default format
            CountdownBox.Text = "00:00:00"; 
        }

        // On button click
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Make sure its in right format
            string[] parts = TimerBox.Text.Split(':');
            if (parts.Length != 3 || !TimeSpan.TryParse(TimerBox.Text, out interval))
            {
                MessageBox.Show("Invalid time format. Please enter in HH:MM:SS format.");
                return;
            }
            // Start task
            remaining = interval;
            CountdownBox.Text = interval.ToString(@"hh\:mm\:ss");
            MessageBox.Show("AutoBuilding has Started.");
            timer.Start();
        }

        // Rest button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("AutoBuilding has Stopped.");
            TimerBox.Text = "00:00:00";
            CountdownBox.Text = "00:00:00";
        }

        // Start timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            remaining = remaining.Subtract(TimeSpan.FromSeconds(1));
            CountdownBox.Text = remaining.ToString(@"hh\:mm\:ss");

            // Repeating the action
            if (remaining <= TimeSpan.Zero)
            {
                timer.Stop();
                RunCommand();
                remaining = interval;
                timer.Start();
            }
        }

        // Search and run cmd file in the directory this app is placed in
        private void RunCommand()
        {
            string cmdPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AutoBuild.cmd");
            if (File.Exists(cmdPath))
            {
                Process.Start(cmdPath);
            }
            else
            {
                timer.Stop();
                MessageBox.Show("AutoBuild.cmd not found in the application directory!");
            }
        }

        // If accidentally closed the window, make sure the auto build will stop and not keep going
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingRequested = true; // Set the flag to indicate closing is requested
            if (timer != null)
            {
                timer.Stop(); // Stop the timer before closing
            }
        }

        // Make sure user cant change the countdown timer
        private void CountdownBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
        }
    }
}
