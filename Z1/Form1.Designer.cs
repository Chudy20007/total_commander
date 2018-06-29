namespace Z1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bView = new System.Windows.Forms.Button();
            this.bMove = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lv1 = new System.Windows.Forms.ListView();
            this.lv1Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv1Ext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv1Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv1Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv1Attr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2 = new System.Windows.Forms.ListView();
            this.lv2Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2Ext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv2Attr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbLeftLV = new System.Windows.Forms.TextBox();
            this.tbRightLV = new System.Windows.Forms.TextBox();
            this.cb1Drive = new System.Windows.Forms.ComboBox();
            this.cb2Drive = new System.Windows.Forms.ComboBox();
            this.bPaste = new System.Windows.Forms.Button();
            this.tb1Path = new System.Windows.Forms.TextBox();
            this.tb2Path = new System.Windows.Forms.TextBox();
            this.bNewFolder = new System.Windows.Forms.Button();
            this.bNewTxt = new System.Windows.Forms.Button();
            this.bFindTxt = new System.Windows.Forms.Button();
            this.tbString = new System.Windows.Forms.TextBox();
            this.bEditTXT = new System.Windows.Forms.Button();
            this.tb2String = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBackLV2 = new System.Windows.Forms.Button();
            this.bBackLV1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bView
            // 
            this.bView.Location = new System.Drawing.Point(38, 441);
            this.bView.Name = "bView";
            this.bView.Size = new System.Drawing.Size(83, 33);
            this.bView.TabIndex = 3;
            this.bView.Text = "View";
            this.bView.UseVisualStyleBackColor = true;
            this.bView.Click += new System.EventHandler(this.bView_Click);
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(1056, 441);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(83, 33);
            this.bMove.TabIndex = 4;
            this.bMove.Text = "Move";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.bMove_Click);
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(246, 441);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(83, 33);
            this.bCopy.TabIndex = 5;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(145, 441);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(83, 33);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(1156, 441);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(83, 33);
            this.bDelete.TabIndex = 9;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv1Name,
            this.lv1Ext,
            this.lv1Size,
            this.lv1Date,
            this.lv1Attr});
            this.lv1.FullRowSelect = true;
            this.lv1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv1.Location = new System.Drawing.Point(38, 76);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(540, 348);
            this.lv1.TabIndex = 16;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            this.lv1.DoubleClick += new System.EventHandler(this.lv1_DoubleClick);
            // 
            // lv1Name
            // 
            this.lv1Name.Text = "Name";
            this.lv1Name.Width = 100;
            // 
            // lv1Ext
            // 
            this.lv1Ext.Text = "Ext";
            // 
            // lv1Size
            // 
            this.lv1Size.Text = "Size";
            this.lv1Size.Width = 80;
            // 
            // lv1Date
            // 
            this.lv1Date.Text = "Date";
            this.lv1Date.Width = 80;
            // 
            // lv1Attr
            // 
            this.lv1Attr.Text = "Attr";
            this.lv1Attr.Width = 90;
            // 
            // lv2
            // 
            this.lv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lv2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv2Name,
            this.lv2Ext,
            this.lv2Size,
            this.lv2Date,
            this.lv2Attr});
            this.lv2.FullRowSelect = true;
            this.lv2.Location = new System.Drawing.Point(697, 76);
            this.lv2.Name = "lv2";
            this.lv2.Size = new System.Drawing.Size(542, 348);
            this.lv2.TabIndex = 17;
            this.lv2.UseCompatibleStateImageBehavior = false;
            this.lv2.View = System.Windows.Forms.View.Details;
            this.lv2.DoubleClick += new System.EventHandler(this.lv2_DoubleClick);
            // 
            // lv2Name
            // 
            this.lv2Name.Text = "Name";
            this.lv2Name.Width = 100;
            // 
            // lv2Ext
            // 
            this.lv2Ext.Text = "Ext";
            this.lv2Ext.Width = 70;
            // 
            // lv2Size
            // 
            this.lv2Size.Text = "Size";
            this.lv2Size.Width = 80;
            // 
            // lv2Date
            // 
            this.lv2Date.Text = "Date";
            this.lv2Date.Width = 80;
            // 
            // lv2Attr
            // 
            this.lv2Attr.Text = "Attr";
            this.lv2Attr.Width = 90;
            // 
            // tbLeftLV
            // 
            this.tbLeftLV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbLeftLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLeftLV.Location = new System.Drawing.Point(106, 50);
            this.tbLeftLV.Name = "tbLeftLV";
            this.tbLeftLV.ReadOnly = true;
            this.tbLeftLV.Size = new System.Drawing.Size(472, 13);
            this.tbLeftLV.TabIndex = 18;
            // 
            // tbRightLV
            // 
            this.tbRightLV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRightLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRightLV.Location = new System.Drawing.Point(765, 50);
            this.tbRightLV.Name = "tbRightLV";
            this.tbRightLV.ReadOnly = true;
            this.tbRightLV.Size = new System.Drawing.Size(474, 13);
            this.tbRightLV.TabIndex = 19;
            // 
            // cb1Drive
            // 
            this.cb1Drive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1Drive.FormattingEnabled = true;
            this.cb1Drive.Location = new System.Drawing.Point(38, 50);
            this.cb1Drive.Name = "cb1Drive";
            this.cb1Drive.Size = new System.Drawing.Size(59, 21);
            this.cb1Drive.TabIndex = 20;
            this.cb1Drive.SelectionChangeCommitted += new System.EventHandler(this.cb1Drive_SelectionChangeCommitted);
            // 
            // cb2Drive
            // 
            this.cb2Drive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb2Drive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2Drive.FormattingEnabled = true;
            this.cb2Drive.Location = new System.Drawing.Point(697, 50);
            this.cb2Drive.Name = "cb2Drive";
            this.cb2Drive.Size = new System.Drawing.Size(59, 21);
            this.cb2Drive.Sorted = true;
            this.cb2Drive.TabIndex = 21;
            this.cb2Drive.SelectionChangeCommitted += new System.EventHandler(this.cb2Drive_SelectionChangeCommitted);
            // 
            // bPaste
            // 
            this.bPaste.Location = new System.Drawing.Point(346, 441);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(83, 33);
            this.bPaste.TabIndex = 22;
            this.bPaste.Text = "Paste";
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // tb1Path
            // 
            this.tb1Path.BackColor = System.Drawing.SystemColors.Window;
            this.tb1Path.Location = new System.Drawing.Point(38, 24);
            this.tb1Path.Name = "tb1Path";
            this.tb1Path.ReadOnly = true;
            this.tb1Path.Size = new System.Drawing.Size(540, 20);
            this.tb1Path.TabIndex = 23;
            // 
            // tb2Path
            // 
            this.tb2Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb2Path.BackColor = System.Drawing.SystemColors.Window;
            this.tb2Path.Location = new System.Drawing.Point(697, 24);
            this.tb2Path.Name = "tb2Path";
            this.tb2Path.ReadOnly = true;
            this.tb2Path.Size = new System.Drawing.Size(542, 20);
            this.tb2Path.TabIndex = 24;
            // 
            // bNewFolder
            // 
            this.bNewFolder.Location = new System.Drawing.Point(848, 441);
            this.bNewFolder.Name = "bNewFolder";
            this.bNewFolder.Size = new System.Drawing.Size(83, 33);
            this.bNewFolder.TabIndex = 25;
            this.bNewFolder.Text = "New Folder";
            this.bNewFolder.UseVisualStyleBackColor = true;
            this.bNewFolder.Click += new System.EventHandler(this.bNewFolder_Click);
            // 
            // bNewTxt
            // 
            this.bNewTxt.Location = new System.Drawing.Point(955, 441);
            this.bNewTxt.Name = "bNewTxt";
            this.bNewTxt.Size = new System.Drawing.Size(83, 33);
            this.bNewTxt.TabIndex = 26;
            this.bNewTxt.Text = "New TXT";
            this.bNewTxt.UseVisualStyleBackColor = true;
            this.bNewTxt.Click += new System.EventHandler(this.bNewTxt_Click);
            // 
            // bFindTxt
            // 
            this.bFindTxt.Location = new System.Drawing.Point(594, 441);
            this.bFindTxt.Name = "bFindTxt";
            this.bFindTxt.Size = new System.Drawing.Size(83, 33);
            this.bFindTxt.TabIndex = 27;
            this.bFindTxt.Text = "Find TXT";
            this.bFindTxt.UseVisualStyleBackColor = true;
            this.bFindTxt.Click += new System.EventHandler(this.bFindTxt_Click);
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(549, 490);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(167, 20);
            this.tbString.TabIndex = 28;
            // 
            // bEditTXT
            // 
            this.bEditTXT.Location = new System.Drawing.Point(446, 441);
            this.bEditTXT.Name = "bEditTXT";
            this.bEditTXT.Size = new System.Drawing.Size(83, 33);
            this.bEditTXT.TabIndex = 29;
            this.bEditTXT.Text = "Edit TXT";
            this.bEditTXT.UseVisualStyleBackColor = true;
            this.bEditTXT.Click += new System.EventHandler(this.bEditTXT_Click);
            // 
            // tb2String
            // 
            this.tb2String.Location = new System.Drawing.Point(549, 534);
            this.tb2String.Name = "tb2String";
            this.tb2String.Size = new System.Drawing.Size(167, 20);
            this.tb2String.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Text to search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Text to replace";
            // 
            // bBackLV2
            // 
            this.bBackLV2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBackLV2.BackgroundImage")));
            this.bBackLV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBackLV2.Image = ((System.Drawing.Image)(resources.GetObject("bBackLV2.Image")));
            this.bBackLV2.Location = new System.Drawing.Point(657, 24);
            this.bBackLV2.Name = "bBackLV2";
            this.bBackLV2.Size = new System.Drawing.Size(34, 33);
            this.bBackLV2.TabIndex = 34;
            this.bBackLV2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBackLV2.UseVisualStyleBackColor = true;
            this.bBackLV2.Click += new System.EventHandler(this.bBackLV2_Click);
            // 
            // bBackLV1
            // 
            this.bBackLV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBackLV1.BackgroundImage")));
            this.bBackLV1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBackLV1.Image = ((System.Drawing.Image)(resources.GetObject("bBackLV1.Image")));
            this.bBackLV1.Location = new System.Drawing.Point(584, 24);
            this.bBackLV1.Name = "bBackLV1";
            this.bBackLV1.Size = new System.Drawing.Size(34, 33);
            this.bBackLV1.TabIndex = 35;
            this.bBackLV1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBackLV1.UseVisualStyleBackColor = true;
            this.bBackLV1.Click += new System.EventHandler(this.bBackLV1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 556);
            this.Controls.Add(this.bBackLV1);
            this.Controls.Add(this.bBackLV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2String);
            this.Controls.Add(this.bEditTXT);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.bFindTxt);
            this.Controls.Add(this.bNewTxt);
            this.Controls.Add(this.bNewFolder);
            this.Controls.Add(this.tb2Path);
            this.Controls.Add(this.tb1Path);
            this.Controls.Add(this.bPaste);
            this.Controls.Add(this.cb2Drive);
            this.Controls.Add(this.cb1Drive);
            this.Controls.Add(this.tbRightLV);
            this.Controls.Add(this.tbLeftLV);
            this.Controls.Add(this.lv2);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bMove);
            this.Controls.Add(this.bView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bView;
        private System.Windows.Forms.Button bMove;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ListView lv2;
        private System.Windows.Forms.ColumnHeader lv1Name;
        private System.Windows.Forms.ColumnHeader lv1Ext;
        private System.Windows.Forms.ColumnHeader lv1Size;
        private System.Windows.Forms.ColumnHeader lv1Date;
        private System.Windows.Forms.ColumnHeader lv1Attr;
        private System.Windows.Forms.ColumnHeader lv2Name;
        private System.Windows.Forms.ColumnHeader lv2Ext;
        private System.Windows.Forms.ColumnHeader lv2Size;
        private System.Windows.Forms.ColumnHeader lv2Date;
        private System.Windows.Forms.ColumnHeader lv2Attr;
        private System.Windows.Forms.TextBox tbLeftLV;
        private System.Windows.Forms.TextBox tbRightLV;
        private System.Windows.Forms.ComboBox cb1Drive;
        private System.Windows.Forms.ComboBox cb2Drive;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.TextBox tb1Path;
        private System.Windows.Forms.TextBox tb2Path;
        private System.Windows.Forms.Button bNewFolder;
        private System.Windows.Forms.Button bNewTxt;
        private System.Windows.Forms.Button bFindTxt;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button bEditTXT;
        private System.Windows.Forms.TextBox tb2String;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBackLV2;
        private System.Windows.Forms.Button bBackLV1;
    }
}

