namespace SportEvents
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("First Item", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxOrganization = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDedlete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEventOrganization = new System.Windows.Forms.Label();
            this.labelEventEndDate = new System.Windows.Forms.Label();
            this.labelEventStartDate = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelEventName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.listBoxOrganizations = new System.Windows.Forms.ListBox();
            this.buttonDeleteOrganization = new System.Windows.Forms.Button();
            this.buttonEditOrganization = new System.Windows.Forms.Button();
            this.buttonAddOrganization = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(906, 423);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxOrganization);
            this.tabPage1.Controls.Add(this.dateTimePickerEnd);
            this.tabPage1.Controls.Add(this.dateTimePickerStart);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonDedlete);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelEventOrganization);
            this.tabPage1.Controls.Add(this.labelEventEndDate);
            this.tabPage1.Controls.Add(this.labelEventStartDate);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.listViewEvents);
            this.tabPage1.Controls.Add(this.labelEventName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrganization
            // 
            this.comboBoxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganization.FormattingEnabled = true;
            this.comboBoxOrganization.Items.AddRange(new object[] {
            "Football",
            "Basketball"});
            this.comboBoxOrganization.Location = new System.Drawing.Point(709, 306);
            this.comboBoxOrganization.Name = "comboBoxOrganization";
            this.comboBoxOrganization.Size = new System.Drawing.Size(178, 23);
            this.comboBoxOrganization.TabIndex = 24;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(687, 270);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEnd.TabIndex = 23;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(687, 230);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerStart.TabIndex = 22;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(599, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(224, 132);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(829, 44);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 20);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDedlete
            // 
            this.buttonDedlete.Location = new System.Drawing.Point(828, 156);
            this.buttonDedlete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDedlete.Name = "buttonDedlete";
            this.buttonDedlete.Size = new System.Drawing.Size(53, 20);
            this.buttonDedlete.TabIndex = 19;
            this.buttonDedlete.Text = "Delete";
            this.buttonDedlete.UseVisualStyleBackColor = true;
            this.buttonDedlete.Click += new System.EventHandler(this.ButtonDedlete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(709, 199);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 23);
            this.textBoxName.TabIndex = 13;
            // 
            // labelEventOrganization
            // 
            this.labelEventOrganization.AutoSize = true;
            this.labelEventOrganization.Location = new System.Drawing.Point(599, 309);
            this.labelEventOrganization.Name = "labelEventOrganization";
            this.labelEventOrganization.Size = new System.Drawing.Size(75, 15);
            this.labelEventOrganization.TabIndex = 12;
            this.labelEventOrganization.Text = "Organization";
            // 
            // labelEventEndDate
            // 
            this.labelEventEndDate.AutoSize = true;
            this.labelEventEndDate.Location = new System.Drawing.Point(599, 276);
            this.labelEventEndDate.Name = "labelEventEndDate";
            this.labelEventEndDate.Size = new System.Drawing.Size(54, 15);
            this.labelEventEndDate.TabIndex = 10;
            this.labelEventEndDate.Text = "End Date";
            // 
            // labelEventStartDate
            // 
            this.labelEventStartDate.AutoSize = true;
            this.labelEventStartDate.Location = new System.Drawing.Point(599, 236);
            this.labelEventStartDate.Name = "labelEventStartDate";
            this.labelEventStartDate.Size = new System.Drawing.Size(58, 15);
            this.labelEventStartDate.TabIndex = 8;
            this.labelEventStartDate.Text = "Start Date";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(829, 86);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(53, 20);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackColor = System.Drawing.Color.LightCoral;
            this.listViewEvents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewEvents.LargeImageList = this.imageList;
            this.listViewEvents.Location = new System.Drawing.Point(8, 6);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(574, 386);
            this.listViewEvents.TabIndex = 4;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.SelectedIndexChanged += new System.EventHandler(this.ListViewEvents_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "baby-yoda.jpg");
            this.imageList.Images.SetKeyName(1, "tree-736885__480.jpg");
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(599, 202);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(39, 15);
            this.labelEventName.TabIndex = 2;
            this.labelEventName.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxOrganization);
            this.tabPage2.Controls.Add(this.listBoxOrganizations);
            this.tabPage2.Controls.Add(this.buttonDeleteOrganization);
            this.tabPage2.Controls.Add(this.buttonEditOrganization);
            this.tabPage2.Controls.Add(this.buttonAddOrganization);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Organiaztions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(141, 67);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(189, 23);
            this.textBoxOrganization.TabIndex = 4;
            // 
            // listBoxOrganizations
            // 
            this.listBoxOrganizations.FormattingEnabled = true;
            this.listBoxOrganizations.ItemHeight = 15;
            this.listBoxOrganizations.Location = new System.Drawing.Point(144, 96);
            this.listBoxOrganizations.Name = "listBoxOrganizations";
            this.listBoxOrganizations.Size = new System.Drawing.Size(186, 199);
            this.listBoxOrganizations.TabIndex = 3;
            // 
            // buttonDeleteOrganization
            // 
            this.buttonDeleteOrganization.Location = new System.Drawing.Point(32, 185);
            this.buttonDeleteOrganization.Name = "buttonDeleteOrganization";
            this.buttonDeleteOrganization.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOrganization.TabIndex = 2;
            this.buttonDeleteOrganization.Text = "Delete";
            this.buttonDeleteOrganization.UseVisualStyleBackColor = true;
            this.buttonDeleteOrganization.Click += new System.EventHandler(this.ButtonDeleteOrganization_Click);
            // 
            // buttonEditOrganization
            // 
            this.buttonEditOrganization.Location = new System.Drawing.Point(32, 140);
            this.buttonEditOrganization.Name = "buttonEditOrganization";
            this.buttonEditOrganization.Size = new System.Drawing.Size(75, 23);
            this.buttonEditOrganization.TabIndex = 1;
            this.buttonEditOrganization.Text = "Edit";
            this.buttonEditOrganization.UseVisualStyleBackColor = true;
            this.buttonEditOrganization.Click += new System.EventHandler(this.ButtonEditOrganization_Click);
            // 
            // buttonAddOrganization
            // 
            this.buttonAddOrganization.Location = new System.Drawing.Point(32, 96);
            this.buttonAddOrganization.Name = "buttonAddOrganization";
            this.buttonAddOrganization.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrganization.TabIndex = 0;
            this.buttonAddOrganization.Text = "Add";
            this.buttonAddOrganization.UseVisualStyleBackColor = true;
            this.buttonAddOrganization.Click += new System.EventHandler(this.ButtonAddOrganization_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select the image";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 423);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sport Events";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl;
        private TabPage tabPage1;
        private Label labelEventName;
        private TabPage tabPage2;
        private ImageList imageList;
        private ListView listViewEvents;
        private Label labelEventEndDate;
        private Label labelEventStartDate;
        private Button buttonEdit;
        private Label labelEventOrganization;
        private TextBox textBoxName;
        private Button buttonDedlete;
        private Button buttonAdd;
        private PictureBox pictureBox;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private ComboBox comboBoxOrganization;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxOrganization;
        private ListBox listBoxOrganizations;
        private Button buttonDeleteOrganization;
        private Button buttonEditOrganization;
        private Button buttonAddOrganization;
    }
}