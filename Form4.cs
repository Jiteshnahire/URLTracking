using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DeskTimeWindowsForms
{
    public partial class Form4 : Form
    {
        private string logFilePath = @"C:/log/logs.txt";
        private StreamWriter logStreamWriter;

        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader dr;
        private ManagementEventWatcher watcher;
        public Form4()
        {
            InitializeComponent();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form3 user_log = new Form3();
            user_log.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Open the log file in append mode
            logStreamWriter = File.AppendText(logFilePath);

            // Start tracking URL and app usage
            StartTracking();

        }
        private void StartTracking()
        {
            // Start a timer to periodically check the active process
            Timer timer = new Timer();
            timer.Interval = 1000; // Check every 1 second
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get the active process
            Process activeProcess = GetActiveProcess();

            if (activeProcess != null)
            {
                // Check if the active process is a browser
                if (IsBrowserProcess(activeProcess))
                {
                    // Get the URL being visited
                    string url = GetActiveBrowserURL(activeProcess);

                    // Log the URL
                    LogData("URL: " + url);
                }
                else
                {
                    // Log the active process name
                    LogData("Process: " + activeProcess.ProcessName);
                }
            }
        }


        private Process GetActiveProcess()
        {
            IntPtr foregroundWindowHandle = NativeMethods.GetForegroundWindow();
            int activeProcessId;
            NativeMethods.GetWindowThreadProcessId(foregroundWindowHandle, out activeProcessId);

            return Process.GetProcessById(activeProcessId);
        }
        private bool IsBrowserProcess(Process process)
        {
            string[] browserNames = { "chrome", "firefox", "iexplore", "edge" }; // Add more browser names as needed

            string processName = process.ProcessName.ToLower();
            foreach (string browserName in browserNames)
            {
                if (processName.Contains(browserName))
                    return true;
            }

            return false;
        }
        private string GetActiveBrowserURL(Process process)
        {
			// Check if the process is Chrome
			if (process.ProcessName.ToLower().Contains("chrome"))
			{
				try
				{
					ChromeOptions options = new ChromeOptions();
					options.AddArgument("--headless"); // Run Chrome in headless mode (no UI)
					IWebDriver driver = new ChromeDriver(options);
					// Execute JavaScript to get the active tab URL
					string script = "return window.location.href";
					string url = (string)((IJavaScriptExecutor)driver).ExecuteScript(script);

					// Close the driver
					driver.Quit();

					return url;
				}
				catch (Exception ex)
				{
					// Handle any exceptions
					MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
			return "https://example.com";
		}

		private void LogData(string data)
        {
            string logEntry = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {data}";

            // Write the log entry to the log file
            logStreamWriter.WriteLine(logEntry);
            logStreamWriter.Flush(); // Flush the stream to ensure data is written immediately

            // Optionally, display the log entry in a TextBox or ListBox in the Windows Form
            listBox1.Items.Add(logEntry + Environment.NewLine);
        }
    }

    internal static class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int processId);
    }
}


