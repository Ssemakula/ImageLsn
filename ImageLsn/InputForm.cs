using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLsn
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.users);

        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.FillAll(this.users._Users);
            ButtonController(false);

        }

        void ButtonController(bool _status = true)
        {

            if (_status) //Editing
            {
                this.newToolStripButton.Enabled = false;
                this.editToolStripButton.Enabled = false;
                this.deleteToolStripButton.Enabled = false;

                this.saveToolStripButton.Enabled = true;
                this.cancelToolStripButton.Enabled = true;
                this.exitToolStripButton.Enabled = false;
                this.groupBox.Enabled = true;
                this.uploadButton.Enabled = true; //Prevent random uploads
                this.usersDataGridView.Enabled = false; //Prevent inadvertent changes
            }
            else //Not editing
            {
                this.newToolStripButton.Enabled = true;
                this.editToolStripButton.Enabled = true;
                this.deleteToolStripButton.Enabled = true;

                this.saveToolStripButton.Enabled = false;
                this.cancelToolStripButton.Enabled = false;
                this.exitToolStripButton.Enabled = true;
                this.groupBox.Enabled = false;
                this.uploadButton.Enabled = false;
                this.usersDataGridView.Enabled = true;
            }
            BindingNav_Control(_status);
        }

        private void BindingNav_Control(bool _status = true)
        {
            /*---------------Onyo!-------------------------------------------
             * Should always appear after the update/add methods
             * as putting it earlier will lead to it's behaviour overwritten
             * And activating it where it is not needed
             * --------------------------------------------------------------
             */
            if (_status) //Editing
            {
                this.firstToolStripButton.Enabled = false;
                this.nextToolStripButton.Enabled = false;
                this.prevToolStripButton.Enabled = false;
                this.lastToolStripButton.Enabled = false;
            }
            else //Not editing
            {
                this.firstToolStripButton.Enabled = true;
                this.nextToolStripButton.Enabled = true;
                this.prevToolStripButton.Enabled = true;
                this.lastToolStripButton.Enabled = true;

                if (this.usersDataGridView.CurrentRow.Index <= 0)
                {
                    this.prevToolStripButton.Enabled = false;
                    this.firstToolStripButton.Enabled = false;
                }
                if (this.usersDataGridView.CurrentRow.Index == this.usersDataGridView.RowCount - 1)
                {
                    this.nextToolStripButton.Enabled = false;
                    this.lastToolStripButton.Enabled = false;
                }
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Image Files|*.jpg;*.tif;*.png;*.bmp;*.ico";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    this.userPictureBox.Image = Image.FromFile(this.openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.userPictureBox.Image = ImageLsn.Properties.Resources.image_circle_off_line_icon_128;
                }
            else
                this.userPictureBox.Image = ImageLsn.Properties.Resources.image_circle_off_line_icon_128;
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            
            this.usersBindingSource.AddNew();
            ButtonController(true);
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.users._Users.Count == 0)
            {
                return;
            }
            ButtonController(true);
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.users._Users.Count == 0)
            {
                return;
            }
            this.groupBox.Enabled = false;
            this.usersBindingSource.RemoveCurrent();
            ButtonController(true);
       }

        private void SaveToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                // this.goods_listTableAdapter.Update(this.market.goods_list);
                if (this.usersTableAdapter.Update(this.users) == 0)
                {
                    MessageBox.Show("Failed to update records");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ButtonController(false);
        }

        private void CancelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersBindingSource.CancelEdit();
                this.users.RejectChanges();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ButtonController(false);
        }

        private void ManualImageButton_Click(object sender, EventArgs e)
        {
            // Doesn't work well with the rest...
            string _filename;
            byte[] _image;

            this.openFileDialog.Filter = "All Files|*.*";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                _filename = this.openFileDialog.FileName;
            else
                return;
            _image = File.ReadAllBytes(_filename); //Read file to binary (other files?)
            //This usage requires the adapter to have defined inser/update/delete methods
            ////Allows any image even pdf
            if (this.usersTableAdapter.Insert(this.userNameTextBox.Text, this.fullNameTextBox.Text, 
                this.passwordTextBox.Text,this.passPhraseTextBox.Text, this.passTermTextBox.Text, _image) == 0)
                MessageBox.Show("Failed to update records"); 
            else
                MessageBox.Show("Updated records");
            ButtonController(false);
        }
        
    }
}
