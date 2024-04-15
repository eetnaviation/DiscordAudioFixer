using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace DiscordAudioFixer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //int nProcessId = Process.GetCurrentProcess().Id;
            //Console.WriteLine(nProcessId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visualLog.ReadOnly = true;
            int selfProcessId = Process.GetCurrentProcess().Id;
            Process selfProcessName = Process.GetProcessById(selfProcessId);
            appendToVisualLog("'" + System.Reflection.Assembly.GetEntryAssembly().Location + "' , Run @ PID: " + selfProcessId.ToString() + ". pName: " + selfProcessName);
            PopulateRunningProcessesList();
            appendToVisualLog("Scan audio devices...");
            getAudioDevices();
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

        private void getAudioDevices()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_SoundDevice");
                int audioDeviceNum = 0;
                appendToVisualLog("-------------------------\n-------------------------\n-------------------------"); // This is needed so it displays the 3 lines before the first one as there may be other lines there.
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    inputChoices.Items.Add(queryObj["ProductName"]);
                    outputChoices.Items.Add(queryObj["ProductName"]);
                    appendToVisualLog("---Audio device " + audioDeviceNum + ", Name: " + queryObj["ProductName"] + "---");
                    appendToVisualLog("ProductName: " + queryObj["ProductName"]);
                    appendToVisualLog("Availability: " + queryObj["Availability"]);
                    appendToVisualLog("Description: " + queryObj["Description"]);
                    appendToVisualLog("DeviceID: " + queryObj["DeviceID"]);
                    appendToVisualLog("Manufacturer: " + queryObj["Manufacturer"]);
                    appendToVisualLog("Name: " + queryObj["Name"]);
                    appendToVisualLog("Status: " + queryObj["Status"]);
                    appendToVisualLog("SystemName: " + queryObj["SystemName"]);
                    // Show extra info about the device if in verbose mode
                    if (verboseMode.Checked == true) // It is easier to do this than to replace every single one with verbosePrint
                    {
                        appendToVisualLog("Caption: " + queryObj["Caption"]);
                        appendToVisualLog("ConfigManagerErrorCode: " + queryObj["ConfigManagerErrorCode"]);
                        appendToVisualLog("ConfigManagerUserConfig: " + queryObj["ConfigManagerUserConfig"]);
                        appendToVisualLog("CreationClassName: " + queryObj["CreationClassName"]);
                        appendToVisualLog("DMABufferSize: " + queryObj["DMABufferSize"]);
                        appendToVisualLog("ErrorCleared: " + queryObj["ErrorCleared"]);
                        appendToVisualLog("ErrorDescription: " + queryObj["ErrorDescription"]);
                        appendToVisualLog("InstallDate: " + queryObj["InstallDate"]);
                        appendToVisualLog("LastErrorCode: " + queryObj["LastErrorCode"]);
                        appendToVisualLog("MPU401Address: " + queryObj["MPU401Address"]);
                        appendToVisualLog("SystemCreationClassName: " + queryObj["SystemCreationClassName"]);
                        appendToVisualLog("StatusInfo: " + queryObj["StatusInfo"]);
                        appendToVisualLog("PNPDeviceID: " + queryObj["PNPDeviceID"]);
                        appendToVisualLog("PowerManagementSupported: " + queryObj["PowerManagementSupported"]);
                    }
                    appendToVisualLog("-------------------------\n-------------------------\n-------------------------");
                    audioDeviceNum++;
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An error occurred while querying for WMI data: " + e.Message);
            }


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
            verbosePrint("RunningProcesses selection: " + runningProcesses.SelectedIndex.ToString() + ", InputChoices selection: " + inputChoices.SelectedIndex.ToString() + ", OutputChoices selection: " + outputChoices.SelectedIndex.ToString());
            if (runningProcesses.SelectedIndex != -1 && inputChoices.SelectedIndex != -1 && outputChoices.SelectedIndex != -1)
            {
                int processId = GetProcessId(runningProcesses.SelectedItem.ToString());
                verbosePrint("ProcessSelection: " + runningProcesses.SelectedItem.ToString() + " running on PID " + processId.ToString());
                appendToVisualLog("Trying to attach to PID: " + processId.ToString());
                /*
                device.AudioSessionManager2.OnSessionCreated += (sender, session) =>
                {
                    if (session.GetProcessID == processId)
                    {
                        session.Disconnect(); // This should be moved so that it can fully mute audio
                    }
                };*/
            }
            else
            {
                appendToVisualLog("Unable to attach! Did you make a selection from the DropDownList?");
            }
        }

        private void scanDevicesBtn_Click(object sender, EventArgs e)
        {
            inputChoices.Items.Clear();
            outputChoices.Items.Clear();
            appendToVisualLog("Rescanning audio devices!");
            getAudioDevices();
        }

        private void verbosePrint(string printable)
        {
            if (verboseMode.Checked)
            {
                appendToVisualLog(printable);
            }
        }

        static int GetProcessId(string processName)
        {
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcesses())
            {
                if (process.ProcessName == processName)
                {
                    return process.Id;
                }
            }
            return -1; // Process not found
        }
    }
}