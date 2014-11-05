namespace SqlMerger
{
    partial class FormSqlMerger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.chkRemoveUse = new System.Windows.Forms.CheckBox();
            this.chkAddGo = new System.Windows.Forms.CheckBox();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblTargetFile = new System.Windows.Forms.Label();
            this.txtTargetFile = new System.Windows.Forms.TextBox();
            this.btnBrowseTargetFile = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(12, 33);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(540, 22);
            this.txtSourceDirectory.TabIndex = 0;
            this.txtSourceDirectory.TextChanged += new System.EventHandler(this.txtSourceDirectory_TextChanged);
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Location = new System.Drawing.Point(12, 13);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(114, 17);
            this.lblSourceDirectory.TabIndex = 1;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.Location = new System.Drawing.Point(558, 33);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "...";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // chkRemoveUse
            // 
            this.chkRemoveUse.AutoSize = true;
            this.chkRemoveUse.Location = new System.Drawing.Point(12, 61);
            this.chkRemoveUse.Name = "chkRemoveUse";
            this.chkRemoveUse.Size = new System.Drawing.Size(200, 21);
            this.chkRemoveUse.TabIndex = 3;
            this.chkRemoveUse.Text = "Remove USE[*] statements";
            this.chkRemoveUse.UseVisualStyleBackColor = true;
            // 
            // chkAddGo
            // 
            this.chkAddGo.AutoSize = true;
            this.chkAddGo.Location = new System.Drawing.Point(219, 62);
            this.chkAddGo.Name = "chkAddGo";
            this.chkAddGo.Size = new System.Drawing.Size(183, 21);
            this.chkAddGo.TabIndex = 4;
            this.chkAddGo.Text = "Add GO between scripts";
            this.chkAddGo.UseVisualStyleBackColor = true;
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiles.Location = new System.Drawing.Point(12, 188);
            this.txtFiles.Multiline = true;
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            this.txtFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFiles.Size = new System.Drawing.Size(608, 154);
            this.txtFiles.TabIndex = 5;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(12, 168);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(37, 17);
            this.lblFiles.TabIndex = 6;
            this.lblFiles.Text = "Files";
            // 
            // lblTargetFile
            // 
            this.lblTargetFile.AutoSize = true;
            this.lblTargetFile.Location = new System.Drawing.Point(12, 86);
            this.lblTargetFile.Name = "lblTargetFile";
            this.lblTargetFile.Size = new System.Drawing.Size(76, 17);
            this.lblTargetFile.TabIndex = 7;
            this.lblTargetFile.Text = "Target File";
            // 
            // txtTargetFile
            // 
            this.txtTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetFile.Location = new System.Drawing.Point(13, 106);
            this.txtTargetFile.Name = "txtTargetFile";
            this.txtTargetFile.Size = new System.Drawing.Size(539, 22);
            this.txtTargetFile.TabIndex = 8;
            // 
            // btnBrowseTargetFile
            // 
            this.btnBrowseTargetFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTargetFile.Location = new System.Drawing.Point(558, 106);
            this.btnBrowseTargetFile.Name = "btnBrowseTargetFile";
            this.btnBrowseTargetFile.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseTargetFile.TabIndex = 9;
            this.btnBrowseTargetFile.Text = "...";
            this.btnBrowseTargetFile.UseVisualStyleBackColor = true;
            this.btnBrowseTargetFile.Click += new System.EventHandler(this.btnBrowseTargetFile_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(13, 135);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(608, 30);
            this.btnMerge.TabIndex = 10;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            // 
            // FormSqlMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 354);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnBrowseTargetFile);
            this.Controls.Add(this.txtTargetFile);
            this.Controls.Add(this.lblTargetFile);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.chkAddGo);
            this.Controls.Add(this.chkRemoveUse);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Name = "FormSqlMerger";
            this.Text = "Sql Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.CheckBox chkRemoveUse;
        private System.Windows.Forms.CheckBox chkAddGo;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblTargetFile;
        private System.Windows.Forms.TextBox txtTargetFile;
        private System.Windows.Forms.Button btnBrowseTargetFile;
        private System.Windows.Forms.Button btnMerge;
    }
}

