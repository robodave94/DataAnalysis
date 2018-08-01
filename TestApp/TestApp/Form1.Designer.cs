namespace TestApp
{
    partial class colToUse
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
            this.chseDirectory = new System.Windows.Forms.Button();
            this.flType = new System.Windows.Forms.TextBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileFnd = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findFiles = new System.Windows.Forms.Button();
            this.genCSVclc = new System.Windows.Forms.Button();
            this.LstOfNames = new System.Windows.Forms.ListBox();
            this.lstofColoumns = new System.Windows.Forms.ListBox();
            this.cngName = new System.Windows.Forms.Button();
            this.addColomn = new System.Windows.Forms.Button();
            this.nametxtbx = new System.Windows.Forms.TextBox();
            this.coltxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rmvCol = new System.Windows.Forms.Button();
            this.rmFileRef = new System.Windows.Forms.Button();
            this.cmboBxSepVal = new System.Windows.Forms.ComboBox();
            this.slctSepVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutptFileTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chseDirectory
            // 
            this.chseDirectory.Location = new System.Drawing.Point(12, 12);
            this.chseDirectory.Name = "chseDirectory";
            this.chseDirectory.Size = new System.Drawing.Size(155, 23);
            this.chseDirectory.TabIndex = 0;
            this.chseDirectory.Text = "Choose Directory";
            this.chseDirectory.UseVisualStyleBackColor = true;
            this.chseDirectory.Click += new System.EventHandler(this.chseDirectory_Click);
            // 
            // flType
            // 
            this.flType.Location = new System.Drawing.Point(68, 43);
            this.flType.Name = "flType";
            this.flType.Size = new System.Drawing.Size(99, 20);
            this.flType.TabIndex = 1;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(173, 17);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(111, 13);
            this.dirLabel.TabIndex = 2;
            this.dirLabel.Text = "No Directory Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Type";
            // 
            // FileFnd
            // 
            this.FileFnd.FormattingEnabled = true;
            this.FileFnd.Location = new System.Drawing.Point(13, 133);
            this.FileFnd.Name = "FileFnd";
            this.FileFnd.Size = new System.Drawing.Size(709, 342);
            this.FileFnd.TabIndex = 4;
            this.FileFnd.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Files Found";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // findFiles
            // 
            this.findFiles.Location = new System.Drawing.Point(18, 69);
            this.findFiles.Name = "findFiles";
            this.findFiles.Size = new System.Drawing.Size(149, 36);
            this.findFiles.TabIndex = 6;
            this.findFiles.Text = "Find Files";
            this.findFiles.UseVisualStyleBackColor = true;
            this.findFiles.Click += new System.EventHandler(this.fndFiles_Click);
            // 
            // genCSVclc
            // 
            this.genCSVclc.Location = new System.Drawing.Point(728, 7);
            this.genCSVclc.Name = "genCSVclc";
            this.genCSVclc.Size = new System.Drawing.Size(150, 39);
            this.genCSVclc.TabIndex = 7;
            this.genCSVclc.Text = "Generate CSV";
            this.genCSVclc.UseVisualStyleBackColor = true;
            this.genCSVclc.Click += new System.EventHandler(this.gencsv_Click);
            // 
            // LstOfNames
            // 
            this.LstOfNames.FormattingEnabled = true;
            this.LstOfNames.Location = new System.Drawing.Point(728, 133);
            this.LstOfNames.Name = "LstOfNames";
            this.LstOfNames.Size = new System.Drawing.Size(150, 342);
            this.LstOfNames.TabIndex = 8;
            // 
            // lstofColoumns
            // 
            this.lstofColoumns.FormattingEnabled = true;
            this.lstofColoumns.Location = new System.Drawing.Point(884, 172);
            this.lstofColoumns.Name = "lstofColoumns";
            this.lstofColoumns.Size = new System.Drawing.Size(150, 303);
            this.lstofColoumns.TabIndex = 9;
            // 
            // cngName
            // 
            this.cngName.Location = new System.Drawing.Point(728, 105);
            this.cngName.Name = "cngName";
            this.cngName.Size = new System.Drawing.Size(150, 23);
            this.cngName.TabIndex = 10;
            this.cngName.Text = "Click to change Name";
            this.cngName.UseVisualStyleBackColor = true;
            this.cngName.Click += new System.EventHandler(this.cngName_Click);
            // 
            // addColomn
            // 
            this.addColomn.Location = new System.Drawing.Point(884, 104);
            this.addColomn.Name = "addColomn";
            this.addColomn.Size = new System.Drawing.Size(73, 62);
            this.addColomn.TabIndex = 11;
            this.addColomn.Text = "Click to add column";
            this.addColomn.UseVisualStyleBackColor = true;
            this.addColomn.Click += new System.EventHandler(this.addColomn_Click);
            // 
            // nametxtbx
            // 
            this.nametxtbx.Location = new System.Drawing.Point(728, 79);
            this.nametxtbx.Name = "nametxtbx";
            this.nametxtbx.Size = new System.Drawing.Size(150, 20);
            this.nametxtbx.TabIndex = 12;
            // 
            // coltxtbox
            // 
            this.coltxtbox.Location = new System.Drawing.Point(884, 78);
            this.coltxtbox.Name = "coltxtbox";
            this.coltxtbox.Size = new System.Drawing.Size(150, 20);
            this.coltxtbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Names for files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(881, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Columns to Read";
            // 
            // rmvCol
            // 
            this.rmvCol.Location = new System.Drawing.Point(961, 104);
            this.rmvCol.Name = "rmvCol";
            this.rmvCol.Size = new System.Drawing.Size(73, 62);
            this.rmvCol.TabIndex = 16;
            this.rmvCol.Text = "Click to remove column";
            this.rmvCol.UseVisualStyleBackColor = true;
            this.rmvCol.Click += new System.EventHandler(this.rmvCol_Click);
            // 
            // rmFileRef
            // 
            this.rmFileRef.Location = new System.Drawing.Point(532, 105);
            this.rmFileRef.Name = "rmFileRef";
            this.rmFileRef.Size = new System.Drawing.Size(189, 23);
            this.rmFileRef.TabIndex = 17;
            this.rmFileRef.Text = "Remove File From Concationation";
            this.rmFileRef.UseVisualStyleBackColor = true;
            this.rmFileRef.Click += new System.EventHandler(this.rmFileRef_Click);
            // 
            // cmboBxSepVal
            // 
            this.cmboBxSepVal.FormattingEnabled = true;
            this.cmboBxSepVal.Items.AddRange(new object[] {
            "  -  Tabs",
            ", -  Comma",
            ". -  Period"});
            this.cmboBxSepVal.Location = new System.Drawing.Point(348, 54);
            this.cmboBxSepVal.Name = "cmboBxSepVal";
            this.cmboBxSepVal.Size = new System.Drawing.Size(126, 21);
            this.cmboBxSepVal.TabIndex = 18;
            // 
            // slctSepVal
            // 
            this.slctSepVal.AutoSize = true;
            this.slctSepVal.Location = new System.Drawing.Point(348, 36);
            this.slctSepVal.Name = "slctSepVal";
            this.slctSepVal.Size = new System.Drawing.Size(126, 13);
            this.slctSepVal.TabIndex = 19;
            this.slctSepVal.Text = "Select Separation Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(885, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Generated File Name";
            // 
            // OutptFileTxt
            // 
            this.OutptFileTxt.Location = new System.Drawing.Point(884, 27);
            this.OutptFileTxt.Name = "OutptFileTxt";
            this.OutptFileTxt.Size = new System.Drawing.Size(150, 20);
            this.OutptFileTxt.TabIndex = 21;
            // 
            // colToUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 485);
            this.Controls.Add(this.OutptFileTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.slctSepVal);
            this.Controls.Add(this.cmboBxSepVal);
            this.Controls.Add(this.rmFileRef);
            this.Controls.Add(this.rmvCol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coltxtbox);
            this.Controls.Add(this.nametxtbx);
            this.Controls.Add(this.addColomn);
            this.Controls.Add(this.cngName);
            this.Controls.Add(this.lstofColoumns);
            this.Controls.Add(this.LstOfNames);
            this.Controls.Add(this.genCSVclc);
            this.Controls.Add(this.findFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileFnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.flType);
            this.Controls.Add(this.chseDirectory);
            this.Name = "colToUse";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chseDirectory;
        private System.Windows.Forms.TextBox flType;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FileFnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findFiles;
        private System.Windows.Forms.Button genCSVclc;
        private System.Windows.Forms.ListBox LstOfNames;
        private System.Windows.Forms.ListBox lstofColoumns;
        private System.Windows.Forms.Button cngName;
        private System.Windows.Forms.Button addColomn;
        private System.Windows.Forms.TextBox nametxtbx;
        private System.Windows.Forms.TextBox coltxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rmvCol;
        private System.Windows.Forms.Button rmFileRef;
        private System.Windows.Forms.ComboBox cmboBxSepVal;
        private System.Windows.Forms.Label slctSepVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OutptFileTxt;
    }
}

