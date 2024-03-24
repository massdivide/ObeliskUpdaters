using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Reflection;

namespace ObeliskUpdaters
{
    public partial class MainForm : Form
    {
        public bool SkipValidation { get; set; }
        // Enum to represent different application IDs
        public enum AppId
        {
            Zomboid = 380870,
            ArkASA = 2430930,
            SevenDaysToDie = 294420,
            Valheim = 896660,
            Gmod = 4020,
            ArkSE = 376030,
            DayZSA = 223350,
            Craftopia = 1670340,
            PixArk = 824360,
            SpaceEngineers = 298740,
        }

        public MainForm()
        {
            InitializeComponent();
            SkipValidation = false;
         
            Log("Obelisk Gaming Updater - Version 1.38 © 2014 MassDivide");
        }

        

        // Event handler for the "zomboidToolStripMenuItem" click event
        private void zomboidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for Zomboid server
            Log("Updating " + GetGameTitle(AppId.Zomboid) + " server");
            // Begin the update process for Zomboid server
            BeginUpdate(AppId.Zomboid);
        }


        private void SevenDaystoDieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for 7 Days to Die server
            Log("Updating " + GetGameTitle(AppId.SevenDaysToDie) + " server");
            // Begin the update process for 7 Days to Die server
            BeginUpdate(AppId.SevenDaysToDie);
        }
        private void valheimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for Valheim server
            Log("Updating " + GetGameTitle(AppId.Valheim) + " server");
            // Begin the update process for Valheim server
            BeginUpdate(AppId.Valheim);
        }

        private void gMODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for Gmod server
            Log("Updating " + GetGameTitle(AppId.Gmod) + " server");
            // Begin the update process for Gmod server
            BeginUpdate(AppId.Gmod);
        }
        private void arkSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for ArkSE server
            Log("Updating " + GetGameTitle(AppId.ArkSE) + " server");
            // Begin the update process for ArkSE server
            BeginUpdate(AppId.ArkSE);
        }
        private void dayZSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for DayZSA server
            Log("Updating " + GetGameTitle(AppId.DayZSA) + " server");
            // Begin the update process for DayZSA server
            BeginUpdate(AppId.DayZSA);
        }
        // Event handler for the "arkASAToolStripMenuItem" click event
        private void arkASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for ArkASA server
            Log("Updating " + GetGameTitle(AppId.ArkASA) + " server");
            // Begin the update process for ArkASA server
            BeginUpdate(AppId.ArkASA);
        }
        private void craftopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for Craftopia server
            Log("Updating " + GetGameTitle(AppId.Craftopia) + " server");
            // Begin the update process for Craftopia server
            BeginUpdate(AppId.Craftopia);
        }
        private void pixArkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for PixArk server
            Log("Updating " + GetGameTitle(AppId.PixArk) + " server");
            // Begin the update process for PixArk server
            BeginUpdate(AppId.PixArk);
        }
        private void spaceEngineersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Log the update process for SpaceEngineers server
            Log("Updating " + GetGameTitle(AppId.SpaceEngineers) + " server");
            // Begin the update process for SpaceEngineers server
            BeginUpdate(AppId.SpaceEngineers);
        }
        private void LogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No implementation needed for this event handler
        }

        private void SkipValidate_CheckedChanged(object sender, EventArgs e)
        {
            SkipValidation = SkipValidate.Checked;
            Log(SkipValidation ? "Validation skipped" : "Validation enabled");
        }

        /// <summary>
        /// Get the game title based on the provided AppId.
        /// </summary>
        /// <param name="appid">The AppId of the game.</param>
        /// <returns>The game title as a string.</returns>
        public string GetGameTitle(AppId appid)
        {
            var enumDisplayStatus = (AppId)appid;
            string stringValue = enumDisplayStatus.ToString();
            return stringValue;
        }

        /// <summary>
        /// Generate the game template command for updating the server.
        /// </summary>
        /// <param name="GameTitle">The title of the game.</param>
        /// <param name="appid">The AppId of the game.</param>
        /// <param name="installpath">The installation path of the game.</param>
        /// <returns>The generated game template command as a string.</returns>
        public string Gametemplate(string GameTitle, string appid, string installpath)
        {
            string steamcmdDir = "cd C:\\steamcmd";
            string ShouldValidate = SkipValidation ? "" : "validate";
            string gameTemplate = "steamcmd +login anonymous +force_install_dir " + installpath + " +app_update " + appid + ShouldValidate + " +quit";
            return "Title Updating: " + GameTitle + " appid:: " + appid+ " && " +steamcmdDir + " && " + gameTemplate;
        }

        /// <summary>
        /// Get the AppId as an integer.
        /// </summary>
        /// <param name="appid">The AppId of the game.</param>
        /// <returns>The AppId as an integer.</returns>
        public int GetAppId(AppId appid)
        {
            return (int)appid;
        }

        /// <summary>
        /// Begin the update process for the specified AppId.
        /// </summary>
        /// <param name="appid">The AppId of the game.</param>
        public void BeginUpdate(AppId appid)
        {
            string appzid = GetAppId(appid).ToString();
            string GameTitle = GetGameTitle(appid);

            string installpath = "C:\\" + GameTitle;

            // Log the update process details
            Log("Updating " + GameTitle + " server to install path " + installpath);
            string command = Gametemplate(GameTitle, appzid, installpath);
            //Log(command);
            if (ExecuteCommand(command))
            {
                //Log("Update of " + GameTitle+" complete");
            }
            else
            {
               // Log("Update of " + GameTitle + " failed");
            }
        }

        /// <summary>
        /// Setup the console title for updating the server.
        /// </summary>
        /// <param name="GameTitle">The title of the game.</param>
        /// <returns>The console title setup command as a string.</returns>
        public string SetupConsole(string GameTitle)
        {
            return "Title UPDATING " + GameTitle + " Server";
        }

        /// <summary>
        /// Setup the SteamCMD directory for updating the server.
        /// </summary>
        /// <param name="GameTitle">The title of the game.</param>
        /// <returns>The SteamCMD directory setup command as a string.</returns>
        public string SetupSteamCMDDir(string GameTitle)
        {
            return "cd C:\\steamcmd";
        }

        /// <summary>
        /// Generate the ECHO command for updating the server.
        /// </summary>
        /// <param name="GameTitle">The title of the game.</param>
        /// <returns>The ECHO command as a string.</returns>
        public string ECHO(string GameTitle)
        {
            return "echo UPDATING " + GameTitle + " Server";
        }

        public void UpdateServer(string GameTitle)
        {
            // No implementation needed for this method
        }

        /// <summary>
        /// Execute the provided command in the command prompt.
        /// </summary>
        /// <param name="command">The command to execute.</param>
        /// <returns>True if the command execution is successful, otherwise false.</returns>
        private bool ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.Arguments = "/k " + command; // Use "/k" instead of "/c" to keep the command prompt open
                processStartInfo.RedirectStandardOutput = false;
                processStartInfo.UseShellExecute = false;
                processStartInfo.CreateNoWindow = false;

                Process process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Check the exit code of the process
                bool success = process.ExitCode == 0;

                // Do something with the output
                // Console.WriteLine(output);

                Log("Task Completed.");
                return success;
            }
            catch (Exception)
            {
                // Handle any exceptions that occurred during the execution
                return false;
            }
        }

        /// <summary>
        /// Log the provided message to the LogBox.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public void Log(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}";
            LogBox.Items.Add(logMessage);
        }

        /// <summary>
        /// Open the command prompt.
        /// </summary>
        public void OpenCommandPrompt()
        {
            Process.Start("cmd.exe");
        }
    }
}

