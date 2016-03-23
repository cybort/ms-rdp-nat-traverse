﻿namespace MSRDPNatTraverseClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RDPPortTextBox = new System.Windows.Forms.TextBox();
            this.machineIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.machineDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverStatusTextBox = new System.Windows.Forms.TextBox();
            this.serverIPTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.closeWithoutQuitCheckBox = new System.Windows.Forms.CheckBox();
            this.autoStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.tabPageRemote = new System.Windows.Forms.TabPage();
            this.EditLocalMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLocalMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOnlineMachine = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.upddateRemteMachineListButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.tabPageRemote.SuspendLayout();
            this.groupBoxOnlineMachine.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.服务器ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 服务器ToolStripMenuItem
            // 
            this.服务器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditServerToolStripMenuItem,
            this.ChangeServerToolStripMenuItem,
            this.EditLocalMachineToolStripMenuItem,
            this.SaveLocalMachineToolStripMenuItem});
            this.服务器ToolStripMenuItem.Name = "服务器ToolStripMenuItem";
            resources.ApplyResources(this.服务器ToolStripMenuItem, "服务器ToolStripMenuItem");
            // 
            // EditServerToolStripMenuItem
            // 
            this.EditServerToolStripMenuItem.Name = "EditServerToolStripMenuItem";
            resources.ApplyResources(this.EditServerToolStripMenuItem, "EditServerToolStripMenuItem");
            this.EditServerToolStripMenuItem.Click += new System.EventHandler(this.EditServerToolStripMenuItem_Click);
            // 
            // ChangeServerToolStripMenuItem
            // 
            this.ChangeServerToolStripMenuItem.Name = "ChangeServerToolStripMenuItem";
            resources.ApplyResources(this.ChangeServerToolStripMenuItem, "ChangeServerToolStripMenuItem");
            this.ChangeServerToolStripMenuItem.Click += new System.EventHandler(this.ChangeServerToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            resources.ApplyResources(this.AboutProgramToolStripMenuItem, "AboutProgramToolStripMenuItem");
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // machineNameTextBox
            // 
            this.machineNameTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.machineNameTextBox, "machineNameTextBox");
            this.machineNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.ReadOnly = true;
            this.machineNameTextBox.TabStop = false;
            this.machineNameTextBox.Tag = "name";
            this.machineNameTextBox.ReadOnlyChanged += new System.EventHandler(this.machineInfoTextBox_ReadOnlyChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // RDPPortTextBox
            // 
            this.RDPPortTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.RDPPortTextBox, "RDPPortTextBox");
            this.RDPPortTextBox.ForeColor = System.Drawing.Color.Black;
            this.RDPPortTextBox.Name = "RDPPortTextBox";
            this.RDPPortTextBox.ReadOnly = true;
            this.RDPPortTextBox.TabStop = false;
            this.RDPPortTextBox.Tag = "rdpPort";
            this.RDPPortTextBox.ReadOnlyChanged += new System.EventHandler(this.machineInfoTextBox_ReadOnlyChanged);
            // 
            // machineIDTextBox
            // 
            this.machineIDTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.machineIDTextBox, "machineIDTextBox");
            this.machineIDTextBox.ForeColor = System.Drawing.Color.Black;
            this.machineIDTextBox.Name = "machineIDTextBox";
            this.machineIDTextBox.ReadOnly = true;
            this.machineIDTextBox.TabStop = false;
            this.machineIDTextBox.Tag = "id";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // machineDescriptionTextBox
            // 
            this.machineDescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.machineDescriptionTextBox.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.machineDescriptionTextBox, "machineDescriptionTextBox");
            this.machineDescriptionTextBox.Name = "machineDescriptionTextBox";
            this.machineDescriptionTextBox.ReadOnly = true;
            this.machineDescriptionTextBox.TabStop = false;
            this.machineDescriptionTextBox.Tag = "desc";
            this.machineDescriptionTextBox.ReadOnlyChanged += new System.EventHandler(this.machineInfoTextBox_ReadOnlyChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.serverNameTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.serverStatusTextBox);
            this.groupBox2.Controls.Add(this.serverIPTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // serverNameTextBox
            // 
            resources.ApplyResources(this.serverNameTextBox, "serverNameTextBox");
            this.serverNameTextBox.ForeColor = System.Drawing.Color.Blue;
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.ReadOnly = true;
            this.serverNameTextBox.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // serverStatusTextBox
            // 
            resources.ApplyResources(this.serverStatusTextBox, "serverStatusTextBox");
            this.serverStatusTextBox.ForeColor = System.Drawing.Color.Blue;
            this.serverStatusTextBox.Name = "serverStatusTextBox";
            this.serverStatusTextBox.ReadOnly = true;
            this.serverStatusTextBox.TabStop = false;
            // 
            // serverIPTextBox
            // 
            resources.ApplyResources(this.serverIPTextBox, "serverIPTextBox");
            this.serverIPTextBox.ForeColor = System.Drawing.Color.Blue;
            this.serverIPTextBox.Name = "serverIPTextBox";
            this.serverIPTextBox.ReadOnly = true;
            this.serverIPTextBox.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quitButton);
            this.groupBox3.Controls.Add(this.stopButton);
            this.groupBox3.Controls.Add(this.startButton);
            this.groupBox3.Controls.Add(this.closeWithoutQuitCheckBox);
            this.groupBox3.Controls.Add(this.autoStartupCheckBox);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // quitButton
            // 
            resources.ApplyResources(this.quitButton, "quitButton");
            this.quitButton.Name = "quitButton";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeWithoutQuitCheckBox
            // 
            resources.ApplyResources(this.closeWithoutQuitCheckBox, "closeWithoutQuitCheckBox");
            this.closeWithoutQuitCheckBox.Name = "closeWithoutQuitCheckBox";
            this.closeWithoutQuitCheckBox.UseVisualStyleBackColor = true;
            this.closeWithoutQuitCheckBox.CheckedChanged += new System.EventHandler(this.closeWithoutQuitCheckBox_CheckedChanged);
            // 
            // autoStartupCheckBox
            // 
            resources.ApplyResources(this.autoStartupCheckBox, "autoStartupCheckBox");
            this.autoStartupCheckBox.Name = "autoStartupCheckBox";
            this.autoStartupCheckBox.UseVisualStyleBackColor = true;
            this.autoStartupCheckBox.CheckedChanged += new System.EventHandler(this.autoStartupCheckBox_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLocal);
            this.tabControl.Controls.Add(this.tabPageRemote);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.BackColor = System.Drawing.Color.White;
            this.tabPageLocal.Controls.Add(this.machineDescriptionTextBox);
            this.tabPageLocal.Controls.Add(this.label4);
            this.tabPageLocal.Controls.Add(this.RDPPortTextBox);
            this.tabPageLocal.Controls.Add(this.machineNameTextBox);
            this.tabPageLocal.Controls.Add(this.machineIDTextBox);
            this.tabPageLocal.Controls.Add(this.label3);
            this.tabPageLocal.Controls.Add(this.label5);
            this.tabPageLocal.Controls.Add(this.label1);
            resources.ApplyResources(this.tabPageLocal, "tabPageLocal");
            this.tabPageLocal.Name = "tabPageLocal";
            // 
            // tabPageRemote
            // 
            this.tabPageRemote.Controls.Add(this.controlButton);
            this.tabPageRemote.Controls.Add(this.upddateRemteMachineListButton);
            this.tabPageRemote.Controls.Add(this.groupBoxOnlineMachine);
            resources.ApplyResources(this.tabPageRemote, "tabPageRemote");
            this.tabPageRemote.Name = "tabPageRemote";
            this.tabPageRemote.UseVisualStyleBackColor = true;
            // 
            // EditLocalMachineToolStripMenuItem
            // 
            this.EditLocalMachineToolStripMenuItem.Name = "EditLocalMachineToolStripMenuItem";
            resources.ApplyResources(this.EditLocalMachineToolStripMenuItem, "EditLocalMachineToolStripMenuItem");
            this.EditLocalMachineToolStripMenuItem.Click += new System.EventHandler(this.EditLocalMachineToolStripMenuItem_Click_1);
            // 
            // SaveLocalMachineToolStripMenuItem
            // 
            this.SaveLocalMachineToolStripMenuItem.Name = "SaveLocalMachineToolStripMenuItem";
            resources.ApplyResources(this.SaveLocalMachineToolStripMenuItem, "SaveLocalMachineToolStripMenuItem");
            this.SaveLocalMachineToolStripMenuItem.Click += new System.EventHandler(this.SaveLocalMachineToolStripMenuItem_Click);
            // 
            // groupBoxOnlineMachine
            // 
            this.groupBoxOnlineMachine.Controls.Add(this.listBox1);
            resources.ApplyResources(this.groupBoxOnlineMachine, "groupBoxOnlineMachine");
            this.groupBoxOnlineMachine.Name = "groupBoxOnlineMachine";
            this.groupBoxOnlineMachine.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1")});
            this.listBox1.Name = "listBox1";
            // 
            // upddateRemteMachineListButton
            // 
            resources.ApplyResources(this.upddateRemteMachineListButton, "upddateRemteMachineListButton");
            this.upddateRemteMachineListButton.Name = "upddateRemteMachineListButton";
            this.upddateRemteMachineListButton.UseVisualStyleBackColor = true;
            this.upddateRemteMachineListButton.Click += new System.EventHandler(this.upddateRemteMachineListButton_Click);
            // 
            // controlButton
            // 
            resources.ApplyResources(this.controlButton, "controlButton");
            this.controlButton.Name = "controlButton";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.tabPageLocal.PerformLayout();
            this.tabPageRemote.ResumeLayout(false);
            this.groupBoxOnlineMachine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeServerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox machineDescriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverIPTextBox;
        private System.Windows.Forms.TextBox serverStatusTextBox;
        private System.Windows.Forms.TextBox RDPPortTextBox;
        private System.Windows.Forms.TextBox machineIDTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox closeWithoutQuitCheckBox;
        private System.Windows.Forms.CheckBox autoStartupCheckBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.TextBox machineNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.TabPage tabPageRemote;
        private System.Windows.Forms.ToolStripMenuItem EditLocalMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveLocalMachineToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOnlineMachine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Button upddateRemteMachineListButton;
    }
}

