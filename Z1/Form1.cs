using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1
{
    public partial class Form1 : Form
    {
        string file;
        string fileName;
        string fileSource;
        ListView []fileNameType;
        public Form1()
        {

           
            InitializeComponent();
            tb1Path.Text = "C:\\";
            tb2Path.Text = "C:\\";
            string []allPartitions = Environment.GetLogicalDrives();
            DriveInfo di = new DriveInfo(@"C:\");
            tbLeftLV.Text = (di.TotalFreeSpace/1024).ToString()+" kB ";
            tbRightLV.Text= (di.TotalFreeSpace/1024).ToString()+ " kB ";
            tbLeftLV.Text +=" of "+ (di.TotalSize/1024).ToString()+ " kB free ";
            tbRightLV.Text += " of "+(di.TotalSize/1024).ToString()+ " kB free ";
            
                foreach (string d in allPartitions)
                {
                    //MessageBox.Show("Logical Drive: " + d);
                    cb1Drive.Items.Add(d);
                
                    cb2Drive.Items.Add(d);
                }

            cb1Drive.SelectedIndex = 0;
            cb2Drive.SelectedIndex = 0;

            //getDictionaries(lv1,cb1Drive);
           // getDictionaries(lv2, cb2Drive);

            getFiles(lv1, cb1Drive, tb1Path.Text, null);
            getFiles(lv2, cb2Drive, tb2Path.Text, null);
        }

        private void cb1Drive_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lv1.Items.Clear();
            DriveInfo di = new DriveInfo(cb1Drive.Text);
                if (di.IsReady == true)
                    {
                        tbLeftLV.Text = (di.TotalFreeSpace / 1024).ToString() + " kB ";
                        tbLeftLV.Text += " of " + (di.TotalSize / 1024).ToString() + " kB free ";
                //getDictionaries(lv1, cb1Drive);
                        tb1Path.Text = cb1Drive.Text;
                        getFiles(lv1,cb1Drive,tb1Path.Text,null);               
                    }
                else
                {
                    tbLeftLV.Text = ("0 kB");
              
                }
        }
        /*
        private void getDictionaries(ListView x,ComboBox c)
        {
            string[] files = Directory.GetDirectories (c.Text,"*.*");


            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
                x.Items.Add(files[i]);
                
            }
            //MessageBox.Show("Logical Drive: " + d);


        }


        private void getFiles(ListView x, ComboBox c)
        {
            string[] files = Directory.GetFiles(c.Text, "*.*");


            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
                x.Items.Add(files[i]);
            }
            //MessageBox.Show("Logical Drive: " + d);


        }
        */

        private void getFiles(ListView x, ComboBox c,string path, string file)
        {
            
            string[] names;
            ListViewItem buf;
            FileInfo files;
            DirectoryInfo dir;
            DateTime dt;
            FileAttributes fileAttributes;
            try
            {
                names = Directory.GetDirectories(path + "\\");




                for (int i = 0; i < names.Length; i++)
                {
                    dir = new DirectoryInfo(names[i]);
                    dt = File.GetLastWriteTime(names[i]);
                    fileAttributes = File.GetAttributes(names[i]);
                    buf = new ListViewItem(new string[] { dir.Name, "<DIR>", "", dt.ToString(), fileAttributes.ToString() });
                    x.Items.Add(buf);
                }

                string fileName;
                int dot;
                names = Directory.GetFiles(path);

                for (int i = 0; i < names.Length; i++)
                {
                    files = new FileInfo(names[i]);
                    fileName = files.Name;
                    dot = files.Name.LastIndexOf('.');
                    if (dot > 0)
                    {
                        fileName = fileName.Substring(0, files.Name.LastIndexOf('.'));
                        dt = File.GetLastWriteTime(names[i]);
                        fileAttributes = File.GetAttributes(names[i]);
                        buf = new ListViewItem(new string[] { fileName, files.Extension.Replace(".", ""), files.Length.ToString(), dt.ToString(), fileAttributes.ToString() });
                        x.Items.Add(buf);
                    }
                }
            }

            catch
            {
              MessageBox.Show("File access denied!","Error");
                
            }

        }

        private void cb2Drive_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                lv2.Items.Clear();
                DriveInfo di = new DriveInfo(cb2Drive.Text);
                    if (di.IsReady == true)
                    {
                        tbRightLV.Text = (di.TotalFreeSpace / 1024).ToString() + " kB ";
                        tbRightLV.Text += " of " + (di.TotalSize / 1024).ToString() + " kB free ";
                        tb2Path.Text = cb2Drive.Text;
                        getFiles(lv2, cb2Drive, tb2Path.Text, null);
                    }
                    else
                    {
                        tbRightLV.Text = ("0 kB");

                    }
            }
        }
        /*
        private void bCopy_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            for (int i=0; i<4; i++)
            {
                 item = lv1.SelectedItems[i];
                MessageBox.Show(item.Text);
                string p = item.SubItems[0].Text + "." + item.SubItems[1].Text;
                string filePath2 = item.Text;
                string filePath = cb1Drive.Text + p;
                MessageBox.Show(filePath);



                setFilePath(filePath);
                setFileName(p);

            }




        }
        */
        private void setFileName(string x)

        {
            fileName = x;
        }

        private string getFileName()

        {
            return fileName;
        }

        private void setFilePath(string x)

        {
            file = x;
        }

        private string getFilePath()

        {
            return file;
        }
        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lv2.SelectedItems[0];
                string filePathTarget = item.Text;
                string filePathTarget2 = cb2Drive.Text + filePathTarget + "\\" + getFileName();
                string fileStream = getFilePath();

                File.Copy(@fileStream, @filePathTarget2);
            }

            catch
            {
                MessageBox.Show("Incorrect operation!");
            }
           

        }
        /*
        private void bMove_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv2.SelectedItems[0];
            string filePathTarget = item.Text;
            string filePathTarget2 = cb2Drive.Text + filePathTarget + "\\" + getFileName();
            string fileStream = getFilePath();
            MessageBox.Show(filePathTarget2);
  
            File.Copy(@fileStream,@filePathTarget2,true);
            File.Delete(@fileStream);
            
        }
        */

        private void bMove_Click(object sender, EventArgs e)
        {
            int i = 0;
            ListViewItem[] itemName = new ListViewItem[lv1.SelectedItems.Count];
            ListViewItem[] itemType = new ListViewItem[lv1.SelectedItems.Count];

            if (itemName.Length<=0)
            {
                MessageBox.Show("Choose file to move!");
                return;
            }
            while (i < lv1.SelectedItems.Count)
            {
               
                    itemName[i] = lv1.SelectedItems[i];



                    fileSource = tb1Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString();
                    string filePath = tb2Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString();
                try
                {
                    File.Copy(@fileSource, @filePath, true);
                    File.Delete(fileSource);
                }

                catch
                {
                    MessageBox.Show("Access denied!");
                }
                    i++;

            }
            lv1.Items.Clear();
            lv2.Items.Clear();

            getFiles(lv1, cb1Drive, tb1Path.Text, null);
            getFiles(lv2, cb2Drive, tb2Path.Text, null);

        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            int i = 0;
            ListViewItem[] itemName = new ListViewItem[lv1.SelectedItems.Count];
            ListViewItem[] itemType = new ListViewItem[lv1.SelectedItems.Count];
            if (itemName.Length<=0)
            {
                MessageBox.Show("Choose file to copy!");
                return;
            }
            while (i < lv1.SelectedItems.Count)
            {
               
                    itemName[i] = lv1.SelectedItems[i];


                try
                {
                    fileSource = tb1Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString();
                    string filePath = tb2Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString();
                    File.Copy(@fileSource, @filePath, true);
                    i++;
                }
                catch
                {
                    MessageBox.Show("Access denied!");
                }
            }

            lv2.Items.Clear();
            getFiles(lv2, cb2Drive, tb2Path.Text, null);
        }

            private void OpenFile (ListViewItem x)
            {
            string path = tb1Path.Text + "\\" + x.SubItems[0].Text.ToString() + "." + x.SubItems[1].Text.ToString();
            if (x.SubItems[1].Text.ToString() == "txt")
            {
                Process.Start("notepad.exe", path);
            }

            if (x.SubItems[1].Text.ToString() == "pdf")
            {
                Process.Start("C:\\Users\\Kacper-PC\\Desktop\\Programy\\PDF X Change Viewer\\PDFXCview.exe", path);
            }
        }
            
           
        

        private void lv1_DoubleClick(object sender, EventArgs e)
        {
            
                ListViewItem itemName = new ListViewItem();
                itemName = lv1.SelectedItems[0];
                itemName.Text.ToString();

                if (itemName.SubItems[1].Text.ToString() == "txt" || itemName.SubItems[1].Text.ToString() == "pdf")
                {

                    OpenFile(itemName);
                    return;

                }

                
            lv1.Items.Clear();
            tb1Path.Text += "\\" + itemName.Text.ToString();
            getFiles(lv1, cb1Drive, tb1Path.Text, itemName.Text.ToString());
                
         }

            
        

        private void lv2_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem itemName = new ListViewItem();
            itemName = lv2.SelectedItems[0];
            itemName.Text.ToString();

            if (itemName.SubItems[1].Text.ToString() == "txt" || itemName.SubItems[1].Text.ToString() == "pdf")
            {

                OpenFile(itemName);
                return;


            }
            else
                lv2.Items.Clear();
                tb2Path.Text += "\\" + itemName.Text.ToString();
                getFiles(lv2, cb2Drive, tb2Path.Text, itemName.Text.ToString());
        }

        private void bView_Click(object sender, EventArgs e)
        {
            ListViewItem itemName = new ListViewItem();
            if (lv1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Choose file!");
                return;
            }

            else
            {
                itemName = lv1.SelectedItems[0];
                itemName.Text.ToString();
               
            }

            if (itemName.SubItems[1].Text.ToString() == "txt" || itemName.SubItems[1].Text.ToString() == "pdf")
            {

                OpenFile(itemName);
                return;

            }
          


            lv1.Items.Clear();
            tb1Path.Text += "\\" + itemName.Text.ToString();
            getFiles(lv1, cb1Drive, tb1Path.Text, itemName.Text.ToString());

        }
        private string getSelectedItem()
        {
          

            if (lv1.SelectedItems.Count>0)
            {
                return lv1.SelectedItems[0].Text.ToString();
            }

            if (lv2.SelectedItems.Count > 0)
            {
                return lv2.SelectedItems[0].Text.ToString();
            }

            return null;

        }

        private void bNewFolder_Click(object sender, EventArgs e)
        {

            string folderName = @tb1Path.Text;
            string folderName2 = @tb2Path.Text;
            DateTime value = new DateTime();
            value = DateTime.Now;
            Random rnd = new Random();


            int i= rnd.Next(1, 1000);
            string pathString = System.IO.Path.Combine(folderName, "New Folder "+i);
            try
            {
                Directory.CreateDirectory(pathString);
                lv1.Items.Clear();
                getFiles(lv1, cb1Drive, folderName, null);

                lv2.Items.Clear();
                getFiles(lv2, cb2Drive, folderName2, null);
            }
            catch
            {
                MessageBox.Show("Access denied!!");
            }

        }

        public bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }


        private void bDelete_Click(object sender, EventArgs e)
        {

            int i = 0;
            string deletedDIR;
            ListViewItem[] itemName = new ListViewItem[lv1.SelectedItems.Count];
            ListViewItem[] itemType = new ListViewItem[lv1.SelectedItems.Count];
      

            while (i < lv1.SelectedItems.Count)
            {
                itemName[i] = lv1.SelectedItems[i];

                if (itemName[i].SubItems[1].Text.ToString() != "<DIR>")
                {
                    
                    deletedDIR = tb1Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString();
                    try
                    {
                        File.Delete(deletedDIR);
                    }
                    catch
                    {
                        MessageBox.Show("Delete all files from directories!");
                        break;
                    }

                }

                if (itemName[i].SubItems[1].Text.ToString() == "<DIR>")
                {
                    deletedDIR = tb1Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString();
                    try
                    {
                        Directory.Delete(deletedDIR,true);
                    }

                    catch
                    {
                        MessageBox.Show("Delete all files from directories!");
                        break;
                    }
                }

                i++;


            }
            lv1.Items.Clear();
            getFiles(lv1, cb1Drive, tb1Path.Text, null);
        }

        private void bNewTxt_Click(object sender, EventArgs e)
        {
            string folderName = @tb1Path.Text;
            string folderName2 = @tb2Path.Text;
            DateTime value = new DateTime();
            value = DateTime.Now;
            Random rnd = new Random();


            int i = rnd.Next(1, 1000);
            string pathString = System.IO.Path.Combine(folderName, "New TXT " + i+".txt");
            try
            {
                File.Create(pathString);
            }
            catch
            {
                MessageBox.Show("Error! Access denied!");
            }
            lv1.Items.Clear();
            getFiles(lv1, cb1Drive, folderName, null);

            lv2.Items.Clear();
            getFiles(lv2, cb2Drive, folderName2, null);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            ListViewItem itemName = new ListViewItem();
            if (lv1.SelectedItems.Count > 0)
            {
                itemName = lv1.SelectedItems[0];

                itemName.Text.ToString();
            }
            else
            {
                MessageBox.Show("Choose file!");
                return;
            }

            if (itemName.SubItems[1].Text.ToString() == "txt" || itemName.SubItems[1].Text.ToString() == "pdf")
            {

                OpenFile(itemName);
                return;

            }


            lv1.Items.Clear();
            tb1Path.Text += "\\" + itemName.Text.ToString();
            getFiles(lv1, cb1Drive, tb1Path.Text, itemName.Text.ToString());

        }

        private void bFindTxt_Click(object sender, EventArgs e)
        {
            if (tbString.Text.Length>0)
            {
                Boolean checkFile = false;
                int counter=1;
                int i = 0;
                string line = null;
                StreamReader file;
                ListViewItem []itemName = new ListViewItem[lv1.SelectedItems.Count];

                if (lv1.SelectedItems.Count<=0)
                {
                    MessageBox.Show("Choose files!");
                    return;
                }
                    
                while (i < lv1.SelectedItems.Count)
                    {
                        itemName[i] = lv1.SelectedItems[i];
                    try
                    {
                        file = new StreamReader(tb1Path.Text + "\\" + itemName[i].SubItems[0].Text.ToString() + "." + itemName[i].SubItems[1].Text.ToString());
                    }
                    catch
                    {
                     MessageBox.Show("File can't be opened!");
                        return;
                    }
                    
                    if (file != null)
                    {
                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains(tbString.Text))
                            {
                                checkFile = true;
                                MessageBox.Show("File "+ itemName[i].SubItems[0].Text+" has a text in line: " + counter + ".");
                                break;
                            }

                            counter++;

                        }
                        if ((line = file.ReadLine()) == null && checkFile == false)
                        {
                            MessageBox.Show("File has not a text!");
                            return;
                        }
                        file.Close();
                        i++;
                    }
                }

            }
            else
            {
             MessageBox.Show("Type words to textfield!");
             return;
            }
        }

        private void bEditTXT_Click(object sender, EventArgs e)
        {
            int i = 0;
            string textToChange = tbString.Text;
            string textToReplace = tb2String.Text;
            string filePath;
            if (lv1.SelectedItems.Count == 0 && lv2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select file!");
                return;
            }
            ListViewItem[] itemNameLV2 = new ListViewItem[lv2.SelectedItems.Count];
            ListViewItem[] itemNameLV1 = new ListViewItem[lv1.SelectedItems.Count];

            while (i < lv1.SelectedItems.Count)
                {
                    itemNameLV1[i] = lv1.SelectedItems[i];
                    filePath = tb1Path.Text + "\\" + itemNameLV1[i].SubItems[0].Text.ToString() + "." + itemNameLV1[i].SubItems[1].Text.ToString();
                    File.WriteAllText(filePath, File.ReadAllText(filePath).Replace(textToChange, textToReplace));
                    i++;
                }

            i = 0;

            while (i < lv2.SelectedItems.Count)
            {
                itemNameLV2[i] = lv2.SelectedItems[i];
                filePath = tb2Path.Text + "\\" + itemNameLV2[i].SubItems[0].Text.ToString() + "." + itemNameLV2[i].SubItems[1].Text.ToString();
                File.WriteAllText(filePath, File.ReadAllText(filePath).Replace(textToChange, textToReplace));
                i++;
            }

            MessageBox.Show("Operation completed!","Success!");

        }

        private void bBackLV1_Click(object sender, EventArgs e)
        {
            char c = '\u005c';
            string backPath=null;
            int x = tb1Path.Text.Length-1;
            bool getNewPath = false;
            
            do
            {
                if (tb1Path.Text[x]==c && x>5)
                {
                    backPath=tb1Path.Text.Substring(0, x);
                    getNewPath = true;
                }

                x--;
            } while (getNewPath==false && x>5);
            if (backPath == null)
            {
                lv1.Items.Clear();
                tb1Path.Text=cb1Drive.Text;
                getFiles(lv1, cb1Drive, tb1Path.Text, null);
                return;
            }
            else
            {
                lv1.Items.Clear();
                tb1Path.Text = backPath;
                getFiles(lv1, cb1Drive, backPath, null);
            }
            


        }

        private void bBackLV2_Click(object sender, EventArgs e)
        {
            char c = '\u005c';
            string backPath = null;
            int x = tb2Path.Text.Length - 1;
            bool getNewPath = false;

            do
            {
                if (tb2Path.Text[x] == c && x > 5)
                {
                    backPath = tb2Path.Text.Substring(0, x);
                    getNewPath = true;
                }

                x--;
            } while (getNewPath == false && x > 5);
            if (backPath == null)
            {
                lv2.Items.Clear();
                tb2Path.Text = cb2Drive.Text;
                getFiles(lv2, cb2Drive, tb2Path.Text, null);
                return;
            }
            else
            {
                lv2.Items.Clear();
                tb2Path.Text = backPath;
                getFiles(lv2, cb2Drive, backPath, null);
            }



        }
    }
    }

