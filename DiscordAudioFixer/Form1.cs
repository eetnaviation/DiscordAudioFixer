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

        private void getAudioDevices()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_SoundDevice");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    appendToVisualLog("-----------------------------------");
                    appendToVisualLog("List of sound cards installed");
                    appendToVisualLog("-----------------------------------");
                    appendToVisualLog("ProductName: {0}" + queryObj["ProductName"]);
                    appendToVisualLog("Availability: {0}" + queryObj["Availability"]);
                    appendToVisualLog("Caption: {0}" + queryObj["Caption"]);
                    appendToVisualLog("ConfigManagerErrorCode: {0}" + queryObj["ConfigManagerErrorCode"]);
                    appendToVisualLog("ConfigManagerUserConfig: {0}" + queryObj["ConfigManagerUserConfig"]);
                    appendToVisualLog("CreationClassName: {0}" + queryObj["CreationClassName"]);
                    appendToVisualLog("Description: {0}" + queryObj["Description"]);
                    appendToVisualLog("DeviceID: {0}" + queryObj["DeviceID"]);
                    appendToVisualLog("DMABufferSize: {0}" + queryObj["DMABufferSize"]);
                    appendToVisualLog("ErrorCleared: {0}" + queryObj["ErrorCleared"]);
                    appendToVisualLog("ErrorDescription: {0}" + queryObj["ErrorDescription"]);
                    appendToVisualLog("InstallDate: {0}" + queryObj["InstallDate"]);
                    appendToVisualLog("LastErrorCode: {0}" + queryObj["LastErrorCode"]);
                    appendToVisualLog("Manufacturer: {0}" + queryObj["Manufacturer"]);
                    appendToVisualLog("MPU401Address: {0}" + queryObj["MPU401Address"]);
                    appendToVisualLog("Name: {0}" + queryObj["Name"]);
                    appendToVisualLog("PNPDeviceID: {0}" + queryObj["PNPDeviceID"]);
                    appendToVisualLog("PowerManagementSupported: {0}" + queryObj["PowerManagementSupported"]);
                    appendToVisualLog("Status: {0}" + queryObj["Status"]);
                    appendToVisualLog("StatusInfo: {0}" + queryObj["StatusInfo"]);
                    appendToVisualLog("SystemCreationClassName: {0}" + queryObj["SystemCreationClassName"]);
                    appendToVisualLog("SystemName: {0}" + queryObj["SystemName"]);
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
            getAudioDevices();
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