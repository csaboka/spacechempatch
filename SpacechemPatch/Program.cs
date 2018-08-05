using System;
using System.Collections.Generic;
using System.IO;
using Mono.Cecil;
using System.Windows.Forms;

namespace SpacechemPatch
{
    class Program : Form
    {
        private Label labelPath;
        private TextBox textBoxPath;
        private Button buttonBrowse;
        private Button buttonPatch;
        private OpenFileDialog openFileDialogSCExe;
        private DataGridView dataGridViewPatches;
        private LinkLabel linkLabelGithub;
        private Button buttonRestore;
        private CheckBox checkBoxParanoia;

        private string currentExePath;
        private string originalExePath;
        private DataGridViewCheckBoxColumn ColumnEnabled;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDescr;
        private string patchedExePath;

        Program()
        {
            InitializeComponent();
            textBoxPath.Text = GetDefaultPath();
            foreach (Patch patch in Enum.GetValues(typeof(Patch)))
            {
                PatchInfo info = PatchInfo.allPatches[patch];
                dataGridViewPatches.Rows.Add(false, info.Type, patch, info.Description);
            }
#if DEBUG
            checkBoxParanoia.Checked = true;
#endif
        }

        private static string GetDefaultPath()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                    {
                        return @"C:\Program Files (x86)\Steam\steamapps\common\SpaceChem";
                    }
                case PlatformID.Unix:
                    {
                        return Path.Combine(Environment.GetEnvironmentVariable("HOME"), ".steam/steam/steamapps/common/SpaceChem");
                    }
                default:
                    throw new Exception("Unsupported platform: " + Environment.OSVersion.Platform);
            }
        }

        private void PatchExe(ICollection<Patch> enabledPatches)
        {
            if (enabledPatches.Count == 0)
            {
                MessageBox.Show("No patch selected");
                return;
            }

            if (!File.Exists(currentExePath))
            {
                MessageBox.Show("Can't find game executable in \"" + currentExePath + "\"!" + Environment.NewLine +
                    "Please execute this program from the SpaceChem game folder, or give the path of the game folder as a command line argument. Exiting...");
                return;
            }
            if (!File.Exists(originalExePath))
            {
                File.Copy(currentExePath, originalExePath);
            }

            using (ModuleDefinition spacechemAssembly = ModuleDefinition.ReadModule(originalExePath))
            using (ModuleDefinition ownAssembly = ModuleDefinition.ReadModule(System.Reflection.Assembly.GetExecutingAssembly().Location))
            {
                Patcher patcher = new Patcher(ownAssembly, spacechemAssembly);
                patcher.ApplyPatches(enabledPatches);
                spacechemAssembly.Write(patchedExePath);
            }

            File.Delete(currentExePath);
            File.Move(patchedExePath, currentExePath);

            string message = "Patching executed successfully, added:" + Environment.NewLine;
            foreach (Patch p in enabledPatches)
            {
                message += Environment.NewLine + p.ToString();
            }
            MessageBox.Show(message);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.checkBoxParanoia = new System.Windows.Forms.CheckBox();
            this.openFileDialogSCExe = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewPatches = new System.Windows.Forms.DataGridView();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatches)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 32);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(41, 17);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(59, 29);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(462, 22);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(527, 29);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 22);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonPatch
            // 
            this.buttonPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPatch.Enabled = false;
            this.buttonPatch.Location = new System.Drawing.Point(12, 385);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(205, 27);
            this.buttonPatch.TabIndex = 3;
            this.buttonPatch.Text = "PATCH!";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonPatch_Click);
            // 
            // checkBoxParanoia
            // 
            this.checkBoxParanoia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxParanoia.Location = new System.Drawing.Point(12, 273);
            this.checkBoxParanoia.Name = "checkBoxParanoia";
            this.checkBoxParanoia.Size = new System.Drawing.Size(590, 106);
            this.checkBoxParanoia.TabIndex = 4;
            this.checkBoxParanoia.Text = resources.GetString("checkBoxParanoia.Text");
            this.checkBoxParanoia.UseVisualStyleBackColor = true;
            this.checkBoxParanoia.CheckedChanged += new System.EventHandler(this.checkBoxParanoia_CheckedChanged);
            // 
            // openFileDialogSCExe
            // 
            this.openFileDialogSCExe.FileName = "SpaceChem.exe";
            this.openFileDialogSCExe.Filter = "SpaceChem Executable|SpaceChem.exe";
            this.openFileDialogSCExe.Title = "Select the SpaceChem executable";
            // 
            // dataGridViewPatches
            // 
            this.dataGridViewPatches.AllowUserToAddRows = false;
            this.dataGridViewPatches.AllowUserToDeleteRows = false;
            this.dataGridViewPatches.AllowUserToOrderColumns = true;
            this.dataGridViewPatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatches.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEnabled,
            this.ColumnType,
            this.ColumnName,
            this.ColumnDescr});
            this.dataGridViewPatches.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewPatches.Name = "dataGridViewPatches";
            this.dataGridViewPatches.RowHeadersVisible = false;
            this.dataGridViewPatches.RowTemplate.Height = 24;
            this.dataGridViewPatches.Size = new System.Drawing.Size(590, 198);
            this.dataGridViewPatches.TabIndex = 5;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(483, 390);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(119, 17);
            this.linkLabelGithub.TabIndex = 6;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub repository";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.Location = new System.Drawing.Point(223, 385);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(205, 27);
            this.buttonRestore.TabIndex = 3;
            this.buttonRestore.Text = "Restore from backup";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.HeaderText = "Enabled";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 66;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 80;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnDescr
            // 
            this.ColumnDescr.HeaderText = "Description";
            this.ColumnDescr.Name = "ColumnDescr";
            this.ColumnDescr.ReadOnly = true;
            this.ColumnDescr.Width = 300;
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(614, 424);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.dataGridViewPatches);
            this.Controls.Add(this.checkBoxParanoia);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Name = "Program";
            this.Text = "SpaceChem Patcher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBoxParanoia_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            buttonPatch.Enabled = cb.Checked;
        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {
            ICollection<Patch> enabledPatches = new List<Patch>();
            foreach (DataGridViewRow row in dataGridViewPatches.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumnEnabled"].Value) == true)
                {
                    enabledPatches.Add((Patch)row.Cells["ColumnName"].Value);
                }
            }

            // game time started
            this.Enabled = false;
            PatchExe(enabledPatches);
            this.Enabled = true;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialogSCExe.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = Path.GetDirectoryName(openFileDialogSCExe.FileName);
            }
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/csaboka/spacechempatch");
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (File.Exists(originalExePath))
            {
                File.Delete(currentExePath);
                File.Move(originalExePath, currentExePath);
                MessageBox.Show("Original exe restored successfully");
            }
            else
            {
                // TODO: do an hash check to see if current==original
                MessageBox.Show("It was not possible to restore the original exe");
            }
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            string gameFolder = textBoxPath.Text;
            currentExePath = Path.Combine(gameFolder, "SpaceChem.exe");
            originalExePath = Path.Combine(gameFolder, "SpaceChem.exe.original");
            patchedExePath = Path.Combine(gameFolder, "SpaceChem.exe.patched");
        }
    }
}
