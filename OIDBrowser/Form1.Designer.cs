namespace OIDBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baseTree = new System.Windows.Forms.TreeView();
            this.dataBaseCombo = new System.Windows.Forms.ComboBox();
            this.userNameCombo = new System.Windows.Forms.ComboBox();
            this.passWord = new System.Windows.Forms.MaskedTextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkLogRequest = new System.Windows.Forms.CheckBox();
            this.displayText = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.hostCombo = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.menuTree = new System.Windows.Forms.MenuStrip();
            this.storeWord = new System.Windows.Forms.ToolStripMenuItem();
            this.storeCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.listWords = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.listObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.recurseWords = new System.Windows.Forms.ToolStripMenuItem();
            this.recurseCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.recurseObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.showWord = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWords = new System.Windows.Forms.ToolStripMenuItem();
            this.panelText = new System.Windows.Forms.Panel();
            this.panelDialog = new System.Windows.Forms.Panel();
            this.textWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuTree.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTree
            // 
            this.baseTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseTree.CheckBoxes = true;
            this.baseTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseTree.Location = new System.Drawing.Point(12, 12);
            this.baseTree.Name = "baseTree";
            this.baseTree.Size = new System.Drawing.Size(518, 537);
            this.baseTree.TabIndex = 0;
            this.baseTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.baseTree_AfterSelect);
            this.baseTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.baseTree_MouseUp);
            // 
            // dataBaseCombo
            // 
            this.dataBaseCombo.FormattingEnabled = true;
            this.dataBaseCombo.Location = new System.Drawing.Point(550, 49);
            this.dataBaseCombo.Name = "dataBaseCombo";
            this.dataBaseCombo.Size = new System.Drawing.Size(224, 21);
            this.dataBaseCombo.TabIndex = 1;
            this.dataBaseCombo.SelectedIndexChanged += new System.EventHandler(this.dataBaseCombo_SelectedIndexChanged);
            this.dataBaseCombo.SelectedValueChanged += new System.EventHandler(this.dataBaseCombo_SelectedValueChanged);
            // 
            // userNameCombo
            // 
            this.userNameCombo.FormattingEnabled = true;
            this.userNameCombo.Location = new System.Drawing.Point(550, 88);
            this.userNameCombo.Name = "userNameCombo";
            this.userNameCombo.Size = new System.Drawing.Size(224, 21);
            this.userNameCombo.TabIndex = 2;
            this.userNameCombo.SelectionChangeCommitted += new System.EventHandler(this.userNameCombo_SelectionChangeCommitted);
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(550, 132);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(224, 20);
            this.passWord.TabIndex = 3;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(803, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(114, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Get";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.checkLogRequest);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Location = new System.Drawing.Point(550, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OID Services";
            // 
            // checkLogRequest
            // 
            this.checkLogRequest.AutoSize = true;
            this.checkLogRequest.Location = new System.Drawing.Point(281, 19);
            this.checkLogRequest.Name = "checkLogRequest";
            this.checkLogRequest.Size = new System.Drawing.Size(78, 17);
            this.checkLogRequest.TabIndex = 2;
            this.checkLogRequest.Text = "log request";
            this.checkLogRequest.UseVisualStyleBackColor = true;
            // 
            // displayText
            // 
            this.displayText.AcceptsReturn = true;
            this.displayText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayText.Location = new System.Drawing.Point(14, 18);
            this.displayText.Multiline = true;
            this.displayText.Name = "displayText";
            this.displayText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.displayText.Size = new System.Drawing.Size(345, 284);
            this.displayText.TabIndex = 1;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(6, 19);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New Object";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // hostCombo
            // 
            this.hostCombo.FormattingEnabled = true;
            this.hostCombo.Location = new System.Drawing.Point(550, 12);
            this.hostCombo.Name = "hostCombo";
            this.hostCombo.Size = new System.Drawing.Size(224, 21);
            this.hostCombo.TabIndex = 6;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(803, 49);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(114, 23);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(803, 88);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(803, 132);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(114, 23);
            this.buttonPut.TabIndex = 9;
            this.buttonPut.Text = "Put";
            this.buttonPut.UseVisualStyleBackColor = true;
            this.buttonPut.Click += new System.EventHandler(this.buttonPut_Click);
            // 
            // menuTree
            // 
            this.menuTree.Location = new System.Drawing.Point(0, 0);
            this.menuTree.Name = "menuTree";
            this.menuTree.Size = new System.Drawing.Size(944, 24);
            this.menuTree.TabIndex = 10;
            this.menuTree.Text = "Oido";
            // 
            // storeWord
            // 
            this.storeWord.Name = "storeWord";
            this.storeWord.Size = new System.Drawing.Size(168, 22);
            this.storeWord.Text = "storeWord";
            this.storeWord.Click += new System.EventHandler(this.storeWord_Click);
            // 
            // storeCategory
            // 
            this.storeCategory.Name = "storeCategory";
            this.storeCategory.Size = new System.Drawing.Size(168, 22);
            this.storeCategory.Text = "storeCategory";
            this.storeCategory.Click += new System.EventHandler(this.storeCategory_Click);
            // 
            // listWords
            // 
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(168, 22);
            this.listWords.Text = "listWords";
            this.listWords.Click += new System.EventHandler(this.listWords_Click);
            // 
            // listCategories
            // 
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(168, 22);
            this.listCategories.Text = "listCategories";
            this.listCategories.Click += new System.EventHandler(this.listCategories_Click);
            // 
            // listObjects
            // 
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(168, 22);
            this.listObjects.Text = "listObjects";
            this.listObjects.Click += new System.EventHandler(this.listObjects_Click);
            // 
            // recurseWords
            // 
            this.recurseWords.Name = "recurseWords";
            this.recurseWords.Size = new System.Drawing.Size(168, 22);
            this.recurseWords.Text = "recurseWords";
            this.recurseWords.Click += new System.EventHandler(this.recurseWords_Click);
            // 
            // recurseCategories
            // 
            this.recurseCategories.Name = "recurseCategories";
            this.recurseCategories.Size = new System.Drawing.Size(168, 22);
            this.recurseCategories.Text = "recurseCategories";
            this.recurseCategories.Click += new System.EventHandler(this.recurseCategories_Click);
            // 
            // recurseObjects
            // 
            this.recurseObjects.Name = "recurseObjects";
            this.recurseObjects.Size = new System.Drawing.Size(168, 22);
            this.recurseObjects.Text = "recurseObjects";
            this.recurseObjects.Click += new System.EventHandler(this.recurseObjects_Click);
            // 
            // showWord
            // 
            this.showWord.Name = "showWord";
            this.showWord.Size = new System.Drawing.Size(168, 22);
            this.showWord.Text = "showWord";
            this.showWord.Click += new System.EventHandler(this.showWord_Click);
            // 
            // contextMenuTree
            // 
            this.contextMenuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWord,
            this.storeWord,
            this.storeCategory,
            this.listWords,
            this.listCategories,
            this.listObjects,
            this.recurseWords,
            this.recurseCategories,
            this.recurseObjects});
            this.contextMenuTree.Name = "contextMenuStrip1";
            this.contextMenuTree.Size = new System.Drawing.Size(169, 202);
            // 
            // showWords
            // 
            this.showWords.Name = "showWords";
            this.showWords.Size = new System.Drawing.Size(152, 22);
            this.showWords.Text = "showWords";
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.displayText);
            this.panelText.Location = new System.Drawing.Point(550, 220);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(367, 323);
            this.panelText.TabIndex = 11;
            this.panelText.Visible = false;
            // 
            // panelDialog
            // 
            this.panelDialog.Controls.Add(this.label3);
            this.panelDialog.Controls.Add(this.comboCategory);
            this.panelDialog.Controls.Add(this.label2);
            this.panelDialog.Controls.Add(this.textBox1);
            this.panelDialog.Controls.Add(this.label1);
            this.panelDialog.Controls.Add(this.textWord);
            this.panelDialog.Location = new System.Drawing.Point(550, 220);
            this.panelDialog.Name = "panelDialog";
            this.panelDialog.Size = new System.Drawing.Size(367, 323);
            this.panelDialog.TabIndex = 12;
            this.panelDialog.Visible = false;
            // 
            // textWord
            // 
            this.textWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWord.Location = new System.Drawing.Point(16, 93);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(343, 24);
            this.textWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idea";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 145);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(343, 157);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(16, 40);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(343, 21);
            this.comboCategory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(99, 19);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(144, 21);
            this.comboType.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 546);
            this.Controls.Add(this.panelDialog);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.hostCombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userNameCombo);
            this.Controls.Add(this.dataBaseCombo);
            this.Controls.Add(this.baseTree);
            this.Controls.Add(this.menuTree);
            this.MainMenuStrip = this.menuTree;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuTree.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panelDialog.ResumeLayout(false);
            this.panelDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView baseTree;
        private System.Windows.Forms.ComboBox dataBaseCombo;
        private System.Windows.Forms.ComboBox userNameCombo;
        private System.Windows.Forms.MaskedTextBox passWord;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ComboBox hostCombo;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.CheckBox checkLogRequest;
        private System.Windows.Forms.MenuStrip menuTree;
        private System.Windows.Forms.ToolStripMenuItem storeWord;
        private System.Windows.Forms.ToolStripMenuItem storeCategory;
        private System.Windows.Forms.ToolStripMenuItem showWord;
        private System.Windows.Forms.ToolStripMenuItem listWords;
        private System.Windows.Forms.ToolStripMenuItem listCategories;
        private System.Windows.Forms.ToolStripMenuItem listObjects;
        private System.Windows.Forms.ToolStripMenuItem recurseWords;
        private System.Windows.Forms.ToolStripMenuItem recurseCategories;
        private System.Windows.Forms.ToolStripMenuItem recurseObjects;
        private System.Windows.Forms.ContextMenuStrip contextMenuTree;
        private System.Windows.Forms.ToolStripMenuItem showWords;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboType;
    }
}

