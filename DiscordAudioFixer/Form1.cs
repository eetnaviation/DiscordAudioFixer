using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace DiscordAudioFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int nProcessId = Process.GetCurrentProcess().Id;
            //Console.WriteLine(nProcessId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int selfProcessId = Process.GetCurrentProcess().Id;
            Process selfProcessName = Process.GetProcessById(selfProcessId);
            appendToVisualLog("'" + System.Reflection.Assembly.GetEntryAssembly().Location + "' , Run @ PID: " + selfProcessId.ToString() + ". pName: " + selfProcessName);
            PopulateRunningProcessesList();
        }

        private void runningProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visualLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void appendToVisualLog(string text)
        {
            visualLog.Text = visualLog.Text + text + "\n";
        }

        private void PopulateRunningProcessesList()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                Console.WriteLine(p.ProcessName);
                runningProcesses.Items.Add(p.ProcessName);
            }
            appendToVisualLog("Populated runningProcessesList");
        }

        private void attachToProcessBtn_Click(object sender, EventArgs e)
        {
            appendToVisualLog("Clicked attachToProcessBtn, runningProcesses.SelectedIndex val: " + runningProcesses.SelectedIndex);
            if (runningProcesses.SelectedIndex != -1)
            {
                // Continue with stuff to attach to discord process
            }
            else
            {
                appendToVisualLog("Unable to attach! Did you make a selection from the DropDownList?");
            }
        }
    }
}