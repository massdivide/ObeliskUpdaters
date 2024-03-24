



namespace ObeliskUpdaters
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
            zomboidToolStripMenuItem = new ToolStripMenuItem();
            arkASAToolStripMenuItem = new ToolStripMenuItem();
            daysToDieToolStripMenuItem = new ToolStripMenuItem();
            valheimToolStripMenuItem = new ToolStripMenuItem();
            gMODToolStripMenuItem = new ToolStripMenuItem();
            arkSEToolStripMenuItem = new ToolStripMenuItem();
            dayZSAToolStripMenuItem = new ToolStripMenuItem();
            craftopiaToolStripMenuItem = new ToolStripMenuItem();
            pixArkToolStripMenuItem = new ToolStripMenuItem();
            spaceEngineersToolStripMenuItem = new ToolStripMenuItem();
            LogBox = new ListBox();
            SkipValidate = new CheckBox();
            Obelisk = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Obelisk).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uPDATEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zomboidToolStripMenuItem, arkASAToolStripMenuItem, daysToDieToolStripMenuItem, valheimToolStripMenuItem, gMODToolStripMenuItem, arkSEToolStripMenuItem, dayZSAToolStripMenuItem, craftopiaToolStripMenuItem, pixArkToolStripMenuItem, spaceEngineersToolStripMenuItem });
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(144, 20);
            uPDATEToolStripMenuItem.Text = "STEAMCMD -> UPDATE";
            // 
            // zomboidToolStripMenuItem
            // 
            zomboidToolStripMenuItem.Name = "zomboidToolStripMenuItem";
            zomboidToolStripMenuItem.Size = new Size(180, 22);
            zomboidToolStripMenuItem.Text = "Zomboid";
            zomboidToolStripMenuItem.Click += zomboidToolStripMenuItem_Click;
            // 
            // arkASAToolStripMenuItem
            // 
            arkASAToolStripMenuItem.Name = "arkASAToolStripMenuItem";
            arkASAToolStripMenuItem.Size = new Size(180, 22);
            arkASAToolStripMenuItem.Text = "ArkASA";
            arkASAToolStripMenuItem.Click += arkASAToolStripMenuItem_Click;
            // 
            // daysToDieToolStripMenuItem
            // 
            daysToDieToolStripMenuItem.Name = "daysToDieToolStripMenuItem";
            daysToDieToolStripMenuItem.Size = new Size(180, 22);
            daysToDieToolStripMenuItem.Text = "7DaysToDie";
            daysToDieToolStripMenuItem.Click += SevenDaystoDieToolStripMenuItem_Click;
            // 
            // valheimToolStripMenuItem
            // 
            valheimToolStripMenuItem.Name = "valheimToolStripMenuItem";
            valheimToolStripMenuItem.Size = new Size(180, 22);
            valheimToolStripMenuItem.Text = "Valheim";
            valheimToolStripMenuItem.Click += valheimToolStripMenuItem_Click;
            // 
            // gMODToolStripMenuItem
            // 
            gMODToolStripMenuItem.Name = "gMODToolStripMenuItem";
            gMODToolStripMenuItem.Size = new Size(180, 22);
            gMODToolStripMenuItem.Text = "GMOD";
            gMODToolStripMenuItem.Click += gMODToolStripMenuItem_Click;
            // 
            // arkSEToolStripMenuItem
            // 
            arkSEToolStripMenuItem.Name = "arkSEToolStripMenuItem";
            arkSEToolStripMenuItem.Size = new Size(180, 22);
            arkSEToolStripMenuItem.Text = "ArkSE";
            arkSEToolStripMenuItem.Click += arkSEToolStripMenuItem_Click;
            // 
            // dayZSAToolStripMenuItem
            // 
            dayZSAToolStripMenuItem.Name = "dayZSAToolStripMenuItem";
            dayZSAToolStripMenuItem.Size = new Size(180, 22);
            dayZSAToolStripMenuItem.Text = "DayZSA";
            dayZSAToolStripMenuItem.Click += dayZSAToolStripMenuItem_Click;
            // 
            // craftopiaToolStripMenuItem
            // 
            craftopiaToolStripMenuItem.Name = "craftopiaToolStripMenuItem";
            craftopiaToolStripMenuItem.Size = new Size(180, 22);
            craftopiaToolStripMenuItem.Text = "Craftopia";
            craftopiaToolStripMenuItem.Click += craftopiaToolStripMenuItem_Click;
            // 
            // pixArkToolStripMenuItem
            // 
            pixArkToolStripMenuItem.Name = "pixArkToolStripMenuItem";
            pixArkToolStripMenuItem.Size = new Size(180, 22);
            pixArkToolStripMenuItem.Text = "PixArk";
            pixArkToolStripMenuItem.Click += pixArkToolStripMenuItem_Click;
            // 
            // spaceEngineersToolStripMenuItem
            // 
            spaceEngineersToolStripMenuItem.Name = "spaceEngineersToolStripMenuItem";
            spaceEngineersToolStripMenuItem.Size = new Size(180, 22);
            spaceEngineersToolStripMenuItem.Text = "SpaceEngineers";
            spaceEngineersToolStripMenuItem.Click += spaceEngineersToolStripMenuItem_Click;
            // 
            // LogBox
            // 
            LogBox.FormattingEnabled = true;
            LogBox.ItemHeight = 15;
            LogBox.Location = new Point(0, 344);
            LogBox.Name = "LogBox";
            LogBox.Size = new Size(788, 94);
            LogBox.TabIndex = 1;
            LogBox.SelectedIndexChanged += LogBox_SelectedIndexChanged;
            // 
            // SkipValidate
            // 
            SkipValidate.AutoSize = true;
            SkipValidate.Location = new Point(705, 319);
            SkipValidate.Name = "SkipValidate";
            SkipValidate.Size = new Size(90, 19);
            SkipValidate.TabIndex = 2;
            SkipValidate.Text = "Skip Valiate?";
            SkipValidate.UseVisualStyleBackColor = true;
            SkipValidate.CheckedChanged += SkipValidate_CheckedChanged;
            // 
            // Obelisk
            // 
            Obelisk.Image = Properties.Resources.og;
            Obelisk.Location = new Point(100, 140);
            Obelisk.Name = "Obelisk";
            Obelisk.Size = new Size(599, 198);
            Obelisk.TabIndex = 3;
            Obelisk.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Obelisk);
            Controls.Add(SkipValidate);
            Controls.Add(LogBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Obelisk Gaming - SteamCMD GUI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Obelisk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }







        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem zomboidToolStripMenuItem;
        private ListBox LogBox;
        private ToolStripMenuItem arkASAToolStripMenuItem;
        private ToolStripMenuItem daysToDieToolStripMenuItem;
        private ToolStripMenuItem valheimToolStripMenuItem;
        private ToolStripMenuItem gMODToolStripMenuItem;
        private ToolStripMenuItem arkSEToolStripMenuItem;
        private ToolStripMenuItem dayZSAToolStripMenuItem;
        private ToolStripMenuItem craftopiaToolStripMenuItem;
        private ToolStripMenuItem pixArkToolStripMenuItem;
        private ToolStripMenuItem spaceEngineersToolStripMenuItem;
        private CheckBox SkipValidate;
        private PictureBox Obelisk;
    }
}
