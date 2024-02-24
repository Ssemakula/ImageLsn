namespace ImageLsn
{
    partial class InputForm
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
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passTermLabel;
            System.Windows.Forms.Label passPhraseLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.users = new ImageLsn.Users();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ImageLsn.UsersTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new ImageLsn.UsersTableAdapters.TableAdapterManager();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.posToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.firstToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.prevToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.countToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passPhraseTextBox = new System.Windows.Forms.TextBox();
            this.passTermTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassPhrase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImage = new System.Windows.Forms.DataGridViewImageColumn();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            passTermLabel = new System.Windows.Forms.Label();
            passPhraseLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(33, 58);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "User ID:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(33, 84);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User Name:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(33, 110);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // passTermLabel
            // 
            passTermLabel.AutoSize = true;
            passTermLabel.Location = new System.Drawing.Point(33, 188);
            passTermLabel.Name = "passTermLabel";
            passTermLabel.Size = new System.Drawing.Size(60, 13);
            passTermLabel.TabIndex = 10;
            passTermLabel.Text = "Pass Term:";
            // 
            // passPhraseLabel
            // 
            passPhraseLabel.AutoSize = true;
            passPhraseLabel.Location = new System.Drawing.Point(33, 162);
            passPhraseLabel.Name = "passPhraseLabel";
            passPhraseLabel.Size = new System.Drawing.Size(69, 13);
            passPhraseLabel.TabIndex = 8;
            passPhraseLabel.Text = "Pass Phrase:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(33, 136);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.users;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ImageLsn.UsersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = null;
            this.usersBindingNavigator.AutoSize = false;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.posToolStripLabel;
            this.usersBindingNavigator.DeleteItem = null;
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripButton,
            this.prevToolStripButton,
            this.bindingNavigatorSeparator,
            this.countToolStripTextBox,
            this.posToolStripLabel,
            this.bindingNavigatorSeparator1,
            this.nextToolStripButton,
            this.lastToolStripButton,
            this.bindingNavigatorSeparator2,
            this.newToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.saveToolStripButton,
            this.exitToolStripButton,
            this.cancelToolStripButton});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.firstToolStripButton;
            this.usersBindingNavigator.MoveLastItem = this.lastToolStripButton;
            this.usersBindingNavigator.MoveNextItem = this.nextToolStripButton;
            this.usersBindingNavigator.MovePreviousItem = this.prevToolStripButton;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.countToolStripTextBox;
            this.usersBindingNavigator.Size = new System.Drawing.Size(800, 36);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // posToolStripLabel
            // 
            this.posToolStripLabel.Name = "posToolStripLabel";
            this.posToolStripLabel.Size = new System.Drawing.Size(35, 33);
            this.posToolStripLabel.Text = "of {0}";
            this.posToolStripLabel.ToolTipText = "Total number of items";
            // 
            // firstToolStripButton
            // 
            this.firstToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("firstToolStripButton.Image")));
            this.firstToolStripButton.Name = "firstToolStripButton";
            this.firstToolStripButton.RightToLeftAutoMirrorImage = true;
            this.firstToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.firstToolStripButton.Text = "Move first";
            // 
            // prevToolStripButton
            // 
            this.prevToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("prevToolStripButton.Image")));
            this.prevToolStripButton.Name = "prevToolStripButton";
            this.prevToolStripButton.RightToLeftAutoMirrorImage = true;
            this.prevToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.prevToolStripButton.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 36);
            // 
            // countToolStripTextBox
            // 
            this.countToolStripTextBox.AccessibleName = "Position";
            this.countToolStripTextBox.AutoSize = false;
            this.countToolStripTextBox.Name = "countToolStripTextBox";
            this.countToolStripTextBox.Size = new System.Drawing.Size(50, 23);
            this.countToolStripTextBox.Text = "0";
            this.countToolStripTextBox.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripButton.Image")));
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.RightToLeftAutoMirrorImage = true;
            this.nextToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.nextToolStripButton.Text = "Move next";
            // 
            // lastToolStripButton
            // 
            this.lastToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("lastToolStripButton.Image")));
            this.lastToolStripButton.Name = "lastToolStripButton";
            this.lastToolStripButton.RightToLeftAutoMirrorImage = true;
            this.lastToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.lastToolStripButton.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.RightToLeftAutoMirrorImage = true;
            this.newToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.newToolStripButton.Text = "Add new";
            this.newToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::ImageLsn.Properties.Resources.add_memo;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.RightToLeftAutoMirrorImage = true;
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.saveToolStripButton.Text = "Save Data";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click_1);
            // 
            // exitToolStripButton
            // 
            this.exitToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStripButton.Image = global::ImageLsn.Properties.Resources.exit;
            this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStripButton.Name = "exitToolStripButton";
            this.exitToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.exitToolStripButton.Text = "Exit";
            this.exitToolStripButton.ToolTipText = "Exit";
            this.exitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.Image = global::ImageLsn.Properties.Resources.cancel_butt;
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 33);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.Click += new System.EventHandler(this.CancelToolStripButton_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.FullName,
            this.Password,
            this.PassPhrase,
            this.PassTerm,
            this.UserImage});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 295);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersWidth = 21;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataGridView.RowTemplate.Height = 55;
            this.usersDataGridView.Size = new System.Drawing.Size(776, 220);
            this.usersDataGridView.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.uploadButton);
            this.groupBox.Controls.Add(this.userPictureBox);
            this.groupBox.Controls.Add(userIDLabel);
            this.groupBox.Controls.Add(this.userIDTextBox);
            this.groupBox.Controls.Add(userNameLabel);
            this.groupBox.Controls.Add(this.userNameTextBox);
            this.groupBox.Controls.Add(fullNameLabel);
            this.groupBox.Controls.Add(this.fullNameTextBox);
            this.groupBox.Controls.Add(passwordLabel);
            this.groupBox.Controls.Add(this.passwordTextBox);
            this.groupBox.Controls.Add(passPhraseLabel);
            this.groupBox.Controls.Add(this.passPhraseTextBox);
            this.groupBox.Controls.Add(passTermLabel);
            this.groupBox.Controls.Add(this.passTermTextBox);
            this.groupBox.Location = new System.Drawing.Point(12, 39);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 250);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(461, 188);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(288, 23);
            this.uploadButton.TabIndex = 13;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "UserImage", true));
            this.userPictureBox.Location = new System.Drawing.Point(461, 58);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(288, 121);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 12;
            this.userPictureBox.TabStop = false;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(108, 55);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 1;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(108, 81);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(307, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(108, 107);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(307, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(108, 133);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(307, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // passPhraseTextBox
            // 
            this.passPhraseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "PassPhrase", true));
            this.passPhraseTextBox.Location = new System.Drawing.Point(108, 159);
            this.passPhraseTextBox.Name = "passPhraseTextBox";
            this.passPhraseTextBox.Size = new System.Drawing.Size(307, 20);
            this.passPhraseTextBox.TabIndex = 9;
            // 
            // passTermTextBox
            // 
            this.passTermTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "PassTerm", true));
            this.passTermTextBox.Location = new System.Drawing.Point(108, 185);
            this.passTermTextBox.Name = "passTermTextBox";
            this.passTermTextBox.Size = new System.Drawing.Size(307, 20);
            this.passTermTextBox.TabIndex = 11;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 300;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // PassPhrase
            // 
            this.PassPhrase.DataPropertyName = "PassPhrase";
            this.PassPhrase.HeaderText = "PassPhrase";
            this.PassPhrase.Name = "PassPhrase";
            this.PassPhrase.ReadOnly = true;
            this.PassPhrase.Visible = false;
            // 
            // PassTerm
            // 
            this.PassTerm.DataPropertyName = "PassTerm";
            this.PassTerm.HeaderText = "PassTerm";
            this.PassTerm.Name = "PassTerm";
            this.PassTerm.ReadOnly = true;
            this.PassTerm.Visible = false;
            // 
            // UserImage
            // 
            this.UserImage.DataPropertyName = "UserImage";
            this.UserImage.HeaderText = "UserImage";
            this.UserImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UserImage.Name = "UserImage";
            this.UserImage.ReadOnly = true;
            this.UserImage.Width = 150;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.usersBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Users users;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private UsersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripLabel posToolStripLabel;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton firstToolStripButton;
        private System.Windows.Forms.ToolStripButton prevToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox countToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private System.Windows.Forms.ToolStripButton lastToolStripButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passPhraseTextBox;
        private System.Windows.Forms.TextBox passTermTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton exitToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassPhrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassTerm;
        private System.Windows.Forms.DataGridViewImageColumn UserImage;
    }
}

