using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TestApp
{
    public partial class colToUse : Form
    {
        List<List<string>> writableContent = new List<List<string>>();
        public colToUse()
        {
            InitializeComponent();
        }

        private void chseDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDialog = new FolderBrowserDialog();
                folderDialog.ShowDialog();
                dirLabel.Text = folderDialog.SelectedPath;
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fndFiles_Click(object sender, EventArgs e)
        {
            try
            {
                FindData(dirLabel.Text);
                //string[] files = Directory.GetFiles(dirLabel.Text);
                //System.Windows.Forms.MessageBox.Show("Files found: " + files[0], "Message");
                //Recursivly find all files ending in .file extension
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region RecursiveAnalysis
        public void FindData(string Path)
        {
            var args = Directory.EnumerateFileSystemEntries(dirLabel.Text);
            foreach (string path in args)
            {
                if (File.Exists(path))
                {
                    // This path is a file
                    ProcessFile(path);
                }
                else if (Directory.Exists(path))
                {
                    // This path is a directory
                    ProcessDirectory(path);
                }
            }
        }

        public void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }
        public void ProcessFile(string path)
        {
            if (path.Substring(path.Length - (flType.Text.Length + 1)) == "." + flType.Text)
            {
                FileFnd.Items.Add(path);
                LstOfNames.Items.Add(path.Substring(path.Length - 10));
            }
        }
        #endregion

        private void cngName_Click(object sender, EventArgs e)
        {
            try
            {
                LstOfNames.Items[LstOfNames.SelectedIndex] = nametxtbx.Text;
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void addColomn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(coltxtbox.Text))
                    MessageBox.Show("An Error Occured");
                else
                    lstofColoumns.Items.Add(coltxtbox.Text);
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void rmvCol_Click(object sender, EventArgs e)
        {
            try
            {
                lstofColoumns.Items.RemoveAt(lstofColoumns.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void columnsConcatonation()
        {
            try
            {
                string sep;
                switch (cmboBxSepVal.SelectedItem.ToString())
                {
                    case "  -  Tabs":
                        sep = "\t";
                        break;
                    case ", -Comma":
                        sep = ",";
                        break;
                    case ". - Period":
                        sep = ".";
                        break;
                    default:
                        throw new System.ArgumentException("Parameter cannot be null", "original");
                }
                //foreach (string path in FileFnd.Items) {
                for (int o = 0; o < FileFnd.Items.Count; o++)
                {
                    readFile(FileFnd.Items[o].ToString(), sep, LstOfNames.Items[o].ToString());
                }
                int max_count = 0;
                foreach (List<string> ls in writableContent)
                {
                    if (ls.Count > max_count)
                    {
                        max_count = ls.Count;
                    }
                }
                //wipe file if around
                if (File.Exists(dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv"))
                {
                    var confirmResult = MessageBox.Show("File Already Exists",
                                     "Confirm Overwrite",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        File.Delete(dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv");
                    }
                    else
                    {
                        return;
                    }

                }
                //
                string content = "";
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv"))
                {
                    //writable content correct
                    for (int i = 0; i < max_count; i++)
                    {
                        foreach (List<string> ls in writableContent)
                        {
                            if (i < ls.Count)
                                content += ls[i];
                            else
                            {
                                for (int h = 0; h <= lstofColoumns.Items.Count; h++)
                                {
                                    content += ",";
                                }
                            }
                        }
                        file.WriteLine(content);
                        content = "";
                    }
                }
                MessageBox.Show("Content written to \"" + dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv" + "\"");
                writableContent = new List<List<string>>();
            }
            catch
            {
                writableContent = new List<List<string>>();
                MessageBox.Show("An Error Occured");
            }
        }

        private void rowsConcatonation()
        {
            try
            {
                string sep;
                switch (cmboBxSepVal.SelectedItem.ToString())
                {
                    case "  -  Tabs":
                        sep = "\t";
                        break;
                    case ", -Comma":
                        sep = ",";
                        break;
                    case ". - Period":
                        sep = ".";
                        break;
                    default:
                        throw new System.ArgumentException("Parameter cannot be null", "original");
                }
                //foreach (string path in FileFnd.Items) {
                for (int o = 0; o < FileFnd.Items.Count; o++)
                {
                    readFile(FileFnd.Items[o].ToString(), sep, LstOfNames.Items[o].ToString(),true);
                }
                int max_count = 0;
                foreach (List<string> ls in writableContent)
                {
                    if (ls.Count > max_count)
                    {
                        max_count = ls.Count;
                    }
                }
                //wipe file if around
                if (File.Exists(dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv"))
                {
                    //concatonate data
                }
                else
                {
                    //write to a new file
                    string content = "";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv"))
                    {
                        //writable content correct
                        foreach (List<string> ls in writableContent)
                        {

                            foreach (string line in ls) {

                            }
                        }
                        file.WriteLine(content);
                        content = "";

                    }
                }
                MessageBox.Show("Content written to \"" + dirLabel.Text + "\\" + OutptFileTxt.Text + ".csv" + "\"");
                writableContent = new List<List<string>>();
            }
            catch
            {
                writableContent = new List<List<string>>();
                MessageBox.Show("An Error Occured");
            }
        }

        private void gencsv_Click(object sender, EventArgs e)
        {
            if (genCSVVert.Checked == true)
            {
                columnsConcatonation();
            }
            else if (GenFileHoriz.Checked == true)
            {
                rowsConcatonation();
            }
        }

        private void readFile(string path, string separator, string name,bool ReadAll=false)
        {
            try
            {
                string line;
                bool foundHeaders = false;
                int counter = 0;
                List<string> analysisData = new List<string>();
                List<int> indices = new List<int>();
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    List<string> structureAnalysis = line.Split(separator.ToCharArray()).ToList();
                    if (line.Contains(lstofColoumns.Items[0].ToString()) && foundHeaders == false)
                    {
                        foundHeaders = true;
                        //foreach (var obj in lstofColoumns.Items) {
                        for (int i = 0; i < lstofColoumns.Items.Count; i++)
                        {
                            var obj = lstofColoumns.Items[i];
                            if (!line.Contains(obj.ToString()))
                            {
                                foundHeaders = false;
                                break;
                            }
                            else
                            {
                                indices.Add(structureAnalysis.IndexOf(obj.ToString()));
                            }
                        }
                        if (foundHeaders == true)
                        {
                            //adds name with titles
                            string titleLine = "," + name;
                            for (int i = 0; i < lstofColoumns.Items.Count; i++)
                            {
                                titleLine += ",";
                            }
                            analysisData.Add(titleLine);
                            titleLine = ",";
                            foreach (int q in indices)
                            {
                                titleLine += structureAnalysis[q] + ",";
                            }
                            analysisData.Add(titleLine);
                        }
                    }
                    else if (foundHeaders == true)
                    {
                        string inputline = ",";
                        foreach (int q in indices)
                        {
                            inputline += structureAnalysis[q] + ",";
                        }
                        analysisData.Add(inputline);
                    }
                    counter++;
                }
                writableContent.Add(analysisData);
                file.Close();
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void rmFileRef_Click(object sender, EventArgs e)
        {
            try
            {
                LstOfNames.Items.RemoveAt(FileFnd.SelectedIndex);
                FileFnd.Items.RemoveAt(FileFnd.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void GenFileHoriz_CheckedChanged(object sender, EventArgs e)
        {
            if (GenFileHoriz.Checked == true)
            {
                partnumTxtBox.Enabled = true;
                paticipantTxtBox.Enabled = true;
                mvmntTxtBox.Enabled = true;
                helcondTxtBox.Enabled = true;
                trialnumTxtBox.Enabled = true;
            }
        }

        private void genCSVVert_CheckedChanged(object sender, EventArgs e)
        {
            if (genCSVVert.Checked == true)
            {
                partnumTxtBox.Enabled = false;
                paticipantTxtBox.Enabled = false;
                mvmntTxtBox.Enabled = false;
                helcondTxtBox.Enabled = false;
                trialnumTxtBox.Enabled = false;
            }
        }
    }

}
