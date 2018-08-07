using System;
using System.Collections.Generic;
using System.IO;
using Mono.Cecil;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace SpacechemPatch
{
    class Program : Form
    {
        private string currentExePath;
        private string originalExePath;
        private string patchedExePath;
        HashSet<Patch> enabledPatches = new HashSet<Patch>();

        private Label labelPath;
        private TextBox textBoxPath;
        private Button buttonBrowse;
        private Button buttonPatch;
        private OpenFileDialog openFileDialogSCExe;
        private DataGridView dataGridViewPatches;
        private LinkLabel linkLabelGithub;
        private Button buttonRestore;
        private CheckBox checkBoxParanoia;
        private DataGridViewCheckBoxColumn ColumnEnabled;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDescr;
        private DataGridViewTextBoxColumn ColumnInternalConflicts;
        private DataGridViewTextBoxColumn ColumnConflicts;
        private Label explanation;
        private Label disclaimer;

        Program()
        {
            InitializeComponent();
            textBoxPath.Text = ExecutableUtils.GetDefaultPath();
            foreach (Patch patch in Enum.GetValues(typeof(Patch)))
            {
                PatchInfo info = PatchInfo.allPatches[patch];
                string conflicts = String.Join(", ", info.ConflictingPatches.Select(p => p.ToString()).ToArray());
                dataGridViewPatches.Rows.Add(false, info.Type, patch, info.Description, info.ConflictingPatches, conflicts);
            }
#if DEBUG
            checkBoxParanoia.Checked = true;
#endif
        }

        private void PatchExe()
        {
            if (enabledPatches.Count == 0)
            {
                MessageBox.Show("No patch selected");
                return;
            }

            if (!File.Exists(currentExePath))
            {
                MessageBox.Show("Can't find game executable in \"" + currentExePath + "\"!" + Environment.NewLine +
                                "Please give the correct path in the \"Path\" box");
                return;
            }

            if (!File.Exists(originalExePath) && ExecutableUtils.IsOriginalExe(currentExePath))
            {
                File.Copy(currentExePath, originalExePath);
            }

            if (!ExecutableUtils.IsOriginalExe(originalExePath))
            {
                MessageBox.Show("Unrecognized SpaceChem executable, patching will not be executed");
                return;
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
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInternalConflicts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConflicts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.explanation = new System.Windows.Forms.Label();
            this.disclaimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatches)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 66);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(61, 63);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(460, 20);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(527, 63);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 22);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonPatch
            // 
            this.buttonPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPatch.Enabled = false;
            this.buttonPatch.Location = new System.Drawing.Point(12, 526);
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
            this.checkBoxParanoia.Location = new System.Drawing.Point(12, 484);
            this.checkBoxParanoia.Name = "checkBoxParanoia";
            this.checkBoxParanoia.Size = new System.Drawing.Size(590, 36);
            this.checkBoxParanoia.TabIndex = 4;
            this.checkBoxParanoia.Text = "I understand the risks, enable the PATCH button";
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
            this.ColumnDescr,
            this.ColumnInternalConflicts,
            this.ColumnConflicts});
            this.dataGridViewPatches.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewPatches.Name = "dataGridViewPatches";
            this.dataGridViewPatches.RowHeadersVisible = false;
            this.dataGridViewPatches.RowTemplate.Height = 24;
            this.dataGridViewPatches.Size = new System.Drawing.Size(590, 208);
            this.dataGridViewPatches.TabIndex = 5;
            this.dataGridViewPatches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatches_CellContentClick);
            this.dataGridViewPatches.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatches_CellValueChanged);
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.FillWeight = 51.10733F;
            this.ColumnEnabled.HeaderText = "Enabled";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 60;
            // 
            // ColumnType
            // 
            this.ColumnType.FillWeight = 69.49702F;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 82;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 85.43085F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnDescr
            // 
            this.ColumnDescr.FillWeight = 243.8279F;
            this.ColumnDescr.HeaderText = "Description";
            this.ColumnDescr.Name = "ColumnDescr";
            this.ColumnDescr.ReadOnly = true;
            this.ColumnDescr.Width = 286;
            // 
            // ColumnInternalConflicts
            // 
            this.ColumnInternalConflicts.HeaderText = "InternalConflicts";
            this.ColumnInternalConflicts.Name = "ColumnInternalConflicts";
            this.ColumnInternalConflicts.ReadOnly = true;
            this.ColumnInternalConflicts.Visible = false;
            // 
            // ColumnConflicts
            // 
            this.ColumnConflicts.FillWeight = 50.13692F;
            this.ColumnConflicts.HeaderText = "Conflicts";
            this.ColumnConflicts.Name = "ColumnConflicts";
            this.ColumnConflicts.ReadOnly = true;
            this.ColumnConflicts.Width = 59;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(483, 531);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(88, 13);
            this.linkLabelGithub.TabIndex = 6;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "GitHub repository";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRestore.Location = new System.Drawing.Point(223, 526);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(205, 27);
            this.buttonRestore.TabIndex = 3;
            this.buttonRestore.Text = "Restore from backup";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // explanation
            // 
            this.explanation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.explanation.Location = new System.Drawing.Point(12, 13);
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(590, 47);
            this.explanation.TabIndex = 7;
            this.explanation.Text = resources.GetString("explanation.Text");
            // 
            // disclaimer
            // 
            this.disclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disclaimer.Location = new System.Drawing.Point(12, 328);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(590, 153);
            this.disclaimer.TabIndex = 8;
            this.disclaimer.Text = resources.GetString("disclaimer.Text");
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(614, 565);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.explanation);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.dataGridViewPatches);
            this.Controls.Add(this.checkBoxParanoia);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonPatch);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.MinimumSize = new System.Drawing.Size(580, 455);
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
            // game time started
            this.Enabled = false;
            PatchExe();
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
            if (ExecutableUtils.IsOriginalExe(currentExePath))
            {
                MessageBox.Show("Original exe is already in place");
            }
            else if (ExecutableUtils.IsOriginalExe(originalExePath))
            {
                File.Delete(currentExePath);
                File.Move(originalExePath, currentExePath);
                MessageBox.Show("Original exe restored successfully");
            }
            else
            {
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

        // thanks https://stackoverflow.com/a/26225746/3288954
        private void dataGridViewPatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPatches.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewPatches_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // this can fire only for checkboxes, or init
            if (e.RowIndex < 0) return;

            // add patch to candidate patches
            Patch patch = (Patch)dataGridViewPatches["ColumnName", e.RowIndex].Value;
            if (Convert.ToBoolean(dataGridViewPatches[e.ColumnIndex, e.RowIndex].Value))
            {
                enabledPatches.Add(patch);
            }
            else
            {
                enabledPatches.Remove(patch);
            }

            // resolve conflicts
            foreach (DataGridViewRow row in dataGridViewPatches.Rows)
            {
                Patch[] conflictingPatches = (Patch[])row.Cells["ColumnInternalConflicts"].Value;
                DataGridViewCheckBoxCell CBCell = (DataGridViewCheckBoxCell)row.Cells["ColumnEnabled"];
                if (conflictingPatches != null && enabledPatches.Overlaps(conflictingPatches))
                {
                    CBCell.FlatStyle = FlatStyle.Flat;
                    CBCell.ReadOnly = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = Color.DarkGray;
                    }
                }
                else
                {
                    CBCell.FlatStyle = FlatStyle.System;
                    CBCell.ReadOnly = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.ForeColor = default;
                    }
                }
            }
        }
    }
}
