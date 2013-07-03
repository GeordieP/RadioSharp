namespace RadioSharp {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.StationsBox = new System.Windows.Forms.ListBox();
            this.ControlsContainer = new System.Windows.Forms.GroupBox();
            this.StreamInfoBackdrop = new System.Windows.Forms.Panel();
            this.StreamInfoLabel = new System.Windows.Forms.Label();
            this.FavBtn = new System.Windows.Forms.Button();
            this.PlayStopBtn = new System.Windows.Forms.Button();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.StationsBrowser = new System.Windows.Forms.TabControl();
            this.StationsTab = new System.Windows.Forms.TabPage();
            this.FavesTab = new System.Windows.Forms.TabPage();
            this.FavesBox = new System.Windows.Forms.ListBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlsContainer.SuspendLayout();
            this.StreamInfoBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.StationsBrowser.SuspendLayout();
            this.StationsTab.SuspendLayout();
            this.FavesTab.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StationsBox
            // 
            this.StationsBox.FormattingEnabled = true;
            this.StationsBox.Location = new System.Drawing.Point(6, 6);
            this.StationsBox.Name = "StationsBox";
            this.StationsBox.Size = new System.Drawing.Size(608, 121);
            this.StationsBox.TabIndex = 1;
            // 
            // ControlsContainer
            // 
            this.ControlsContainer.Controls.Add(this.StreamInfoBackdrop);
            this.ControlsContainer.Controls.Add(this.FavBtn);
            this.ControlsContainer.Controls.Add(this.PlayStopBtn);
            this.ControlsContainer.Controls.Add(this.VolumeSlider);
            this.ControlsContainer.Location = new System.Drawing.Point(12, 203);
            this.ControlsContainer.Name = "ControlsContainer";
            this.ControlsContainer.Size = new System.Drawing.Size(628, 99);
            this.ControlsContainer.TabIndex = 3;
            this.ControlsContainer.TabStop = false;
            // 
            // StreamInfoBackdrop
            // 
            this.StreamInfoBackdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.StreamInfoBackdrop.Controls.Add(this.StreamInfoLabel);
            this.StreamInfoBackdrop.Location = new System.Drawing.Point(185, 13);
            this.StreamInfoBackdrop.Name = "StreamInfoBackdrop";
            this.StreamInfoBackdrop.Size = new System.Drawing.Size(433, 76);
            this.StreamInfoBackdrop.TabIndex = 6;
            // 
            // StreamInfoLabel
            // 
            this.StreamInfoLabel.BackColor = System.Drawing.Color.Black;
            this.StreamInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StreamInfoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StreamInfoLabel.Location = new System.Drawing.Point(2, 2);
            this.StreamInfoLabel.Name = "StreamInfoLabel";
            this.StreamInfoLabel.Padding = new System.Windows.Forms.Padding(2);
            this.StreamInfoLabel.Size = new System.Drawing.Size(429, 72);
            this.StreamInfoLabel.TabIndex = 0;
            this.StreamInfoLabel.Text = "Live E09\r\nHysterical\r\nLiquid DnB - DIGITALLY IMPORTED\r\n(dummy text - stream info " +
    "reading not yet implemented)";
            // 
            // FavBtn
            // 
            this.FavBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FavBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavBtn.Location = new System.Drawing.Point(90, 61);
            this.FavBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Size = new System.Drawing.Size(70, 28);
            this.FavBtn.TabIndex = 4;
            this.FavBtn.Text = "♥";
            this.FavBtn.UseVisualStyleBackColor = true;
            // 
            // PlayStopBtn
            // 
            this.PlayStopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayStopBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayStopBtn.Location = new System.Drawing.Point(10, 61);
            this.PlayStopBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayStopBtn.Name = "PlayStopBtn";
            this.PlayStopBtn.Size = new System.Drawing.Size(70, 28);
            this.PlayStopBtn.TabIndex = 3;
            this.PlayStopBtn.Text = "►■";
            this.PlayStopBtn.UseVisualStyleBackColor = true;
            this.PlayStopBtn.Click += new System.EventHandler(this.PlayStopBtn_Click);
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.AutoSize = false;
            this.VolumeSlider.LargeChange = 1;
            this.VolumeSlider.Location = new System.Drawing.Point(10, 16);
            this.VolumeSlider.Margin = new System.Windows.Forms.Padding(0);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(150, 43);
            this.VolumeSlider.TabIndex = 2;
            this.VolumeSlider.TickFrequency = 50;
            this.VolumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.VolumeSlider.Value = 70;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // StationsBrowser
            // 
            this.StationsBrowser.Controls.Add(this.StationsTab);
            this.StationsBrowser.Controls.Add(this.FavesTab);
            this.StationsBrowser.Location = new System.Drawing.Point(12, 38);
            this.StationsBrowser.Name = "StationsBrowser";
            this.StationsBrowser.SelectedIndex = 0;
            this.StationsBrowser.Size = new System.Drawing.Size(628, 159);
            this.StationsBrowser.TabIndex = 4;
            // 
            // StationsTab
            // 
            this.StationsTab.Controls.Add(this.StationsBox);
            this.StationsTab.Location = new System.Drawing.Point(4, 22);
            this.StationsTab.Name = "StationsTab";
            this.StationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StationsTab.Size = new System.Drawing.Size(620, 133);
            this.StationsTab.TabIndex = 0;
            this.StationsTab.Text = "Stations";
            this.StationsTab.UseVisualStyleBackColor = true;
            // 
            // FavesTab
            // 
            this.FavesTab.Controls.Add(this.FavesBox);
            this.FavesTab.Location = new System.Drawing.Point(4, 22);
            this.FavesTab.Name = "FavesTab";
            this.FavesTab.Padding = new System.Windows.Forms.Padding(3);
            this.FavesTab.Size = new System.Drawing.Size(620, 133);
            this.FavesTab.TabIndex = 1;
            this.FavesTab.Text = "Favorites";
            this.FavesTab.UseVisualStyleBackColor = true;
            // 
            // FavesBox
            // 
            this.FavesBox.FormattingEnabled = true;
            this.FavesBox.Location = new System.Drawing.Point(6, 6);
            this.FavesBox.Name = "FavesBox";
            this.FavesBox.Size = new System.Drawing.Size(608, 121);
            this.FavesBox.TabIndex = 5;
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenu,
            this.HelpMenu});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(652, 24);
            this.MenuBar.TabIndex = 5;
            this.MenuBar.Text = "menuStrip1";
            // 
            // MenuMenu
            // 
            this.MenuMenu.Name = "MenuMenu";
            this.MenuMenu.Size = new System.Drawing.Size(50, 20);
            this.MenuMenu.Text = "Menu";
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(107, 22);
            this.HelpAbout.Text = "About";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 313);
            this.Controls.Add(this.StationsBrowser);
            this.Controls.Add(this.ControlsContainer);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio#";
            this.ControlsContainer.ResumeLayout(false);
            this.StreamInfoBackdrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.StationsBrowser.ResumeLayout(false);
            this.StationsTab.ResumeLayout(false);
            this.FavesTab.ResumeLayout(false);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StationsBox;
        private System.Windows.Forms.GroupBox ControlsContainer;
        private System.Windows.Forms.TabControl StationsBrowser;
        private System.Windows.Forms.TabPage StationsTab;
        private System.Windows.Forms.TabPage FavesTab;
        private System.Windows.Forms.ListBox FavesBox;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuMenu;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Button FavBtn;
        private System.Windows.Forms.Button PlayStopBtn;
        private System.Windows.Forms.Panel StreamInfoBackdrop;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.Label StreamInfoLabel;
    }
}

