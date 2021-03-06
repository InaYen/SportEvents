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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelEventInfromation = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.comboBoxOrganization = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelEventStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelEventEndDate = new System.Windows.Forms.Label();
            this.labelEventOrganization = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDedlete = new System.Windows.Forms.Button();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.listBoxOrganizations = new System.Windows.Forms.ListBox();
            this.buttonDeleteOrganization = new System.Windows.Forms.Button();
            this.buttonEditOrganization = new System.Windows.Forms.Button();
            this.buttonAddOrganization = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelEventInfromation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1634, 813);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.tableLayoutPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1626, 775);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Events";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Linen;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.panelEventInfromation, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.listViewEvents, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 757F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1618, 765);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panelEventInfromation
            // 
            this.panelEventInfromation.BackColor = System.Drawing.Color.Linen;
            this.panelEventInfromation.Controls.Add(this.pictureBox);
            this.panelEventInfromation.Controls.Add(this.labelEventName);
            this.panelEventInfromation.Controls.Add(this.comboBoxOrganization);
            this.panelEventInfromation.Controls.Add(this.buttonEdit);
            this.panelEventInfromation.Controls.Add(this.dateTimePickerEnd);
            this.panelEventInfromation.Controls.Add(this.labelEventStartDate);
            this.panelEventInfromation.Controls.Add(this.dateTimePickerStart);
            this.panelEventInfromation.Controls.Add(this.labelEventEndDate);
            this.panelEventInfromation.Controls.Add(this.labelEventOrganization);
            this.panelEventInfromation.Controls.Add(this.buttonAdd);
            this.panelEventInfromation.Controls.Add(this.textBoxName);
            this.panelEventInfromation.Controls.Add(this.buttonDedlete);
            this.panelEventInfromation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEventInfromation.Location = new System.Drawing.Point(1136, 5);
            this.panelEventInfromation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEventInfromation.Name = "panelEventInfromation";
            this.panelEventInfromation.Size = new System.Drawing.Size(478, 755);
            this.panelEventInfromation.TabIndex = 25;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = global::SportEvents.Properties.Resources.select;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(478, 402);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // labelEventName
            // 
            this.labelEventName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventName.Location = new System.Drawing.Point(29, 539);
            this.labelEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(75, 31);
            this.labelEventName.TabIndex = 2;
            this.labelEventName.Text = "Name";
            // 
            // comboBoxOrganization
            // 
            this.comboBoxOrganization.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganization.FormattingEnabled = true;
            this.comboBoxOrganization.Items.AddRange(new object[] {
            "Football",
            "Basketball"});
            this.comboBoxOrganization.Location = new System.Drawing.Point(202, 699);
            this.comboBoxOrganization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOrganization.Name = "comboBoxOrganization";
            this.comboBoxOrganization.Size = new System.Drawing.Size(253, 33);
            this.comboBoxOrganization.TabIndex = 24;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BackgroundImage = global::SportEvents.Properties.Resources.Edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(188, 402);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 117);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(171, 644);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(284, 31);
            this.dateTimePickerEnd.TabIndex = 23;
            // 
            // labelEventStartDate
            // 
            this.labelEventStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEventStartDate.AutoSize = true;
            this.labelEventStartDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventStartDate.Location = new System.Drawing.Point(29, 594);
            this.labelEventStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventStartDate.Name = "labelEventStartDate";
            this.labelEventStartDate.Size = new System.Drawing.Size(115, 31);
            this.labelEventStartDate.TabIndex = 8;
            this.labelEventStartDate.Text = "Start Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePickerStart.Location = new System.Drawing.Point(171, 589);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(284, 31);
            this.dateTimePickerStart.TabIndex = 22;
            // 
            // labelEventEndDate
            // 
            this.labelEventEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEventEndDate.AutoSize = true;
            this.labelEventEndDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventEndDate.Location = new System.Drawing.Point(29, 649);
            this.labelEventEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventEndDate.Name = "labelEventEndDate";
            this.labelEventEndDate.Size = new System.Drawing.Size(107, 31);
            this.labelEventEndDate.TabIndex = 10;
            this.labelEventEndDate.Text = "End Date";
            // 
            // labelEventOrganization
            // 
            this.labelEventOrganization.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEventOrganization.AutoSize = true;
            this.labelEventOrganization.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEventOrganization.Location = new System.Drawing.Point(29, 704);
            this.labelEventOrganization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventOrganization.Name = "labelEventOrganization";
            this.labelEventOrganization.Size = new System.Drawing.Size(146, 31);
            this.labelEventOrganization.TabIndex = 12;
            this.labelEventOrganization.Text = "Organization";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BackgroundImage = global::SportEvents.Properties.Resources.Add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(25, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 117);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxName.Location = new System.Drawing.Point(211, 534);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 31);
            this.textBoxName.TabIndex = 13;
            // 
            // buttonDedlete
            // 
            this.buttonDedlete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDedlete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDedlete.BackgroundImage = global::SportEvents.Properties.Resources.Remove;
            this.buttonDedlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDedlete.Location = new System.Drawing.Point(351, 402);
            this.buttonDedlete.Name = "buttonDedlete";
            this.buttonDedlete.Size = new System.Drawing.Size(100, 117);
            this.buttonDedlete.TabIndex = 19;
            this.buttonDedlete.UseVisualStyleBackColor = false;
            this.buttonDedlete.Click += new System.EventHandler(this.ButtonDedlete_Click);
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackColor = System.Drawing.Color.Azure;
            this.listViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEvents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewEvents.LargeImageList = this.imageList;
            this.listViewEvents.Location = new System.Drawing.Point(4, 5);
            this.listViewEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(1124, 755);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxOrganization);
            this.tabPage2.Controls.Add(this.listBoxOrganizations);
            this.tabPage2.Controls.Add(this.buttonDeleteOrganization);
            this.tabPage2.Controls.Add(this.buttonEditOrganization);
            this.tabPage2.Controls.Add(this.buttonAddOrganization);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1626, 775);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Organiaztions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(200, 63);
            this.textBoxOrganization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(268, 31);
            this.textBoxOrganization.TabIndex = 4;
            // 
            // listBoxOrganizations
            // 
            this.listBoxOrganizations.FormattingEnabled = true;
            this.listBoxOrganizations.ItemHeight = 25;
            this.listBoxOrganizations.Location = new System.Drawing.Point(204, 112);
            this.listBoxOrganizations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOrganizations.Name = "listBoxOrganizations";
            this.listBoxOrganizations.Size = new System.Drawing.Size(264, 329);
            this.listBoxOrganizations.TabIndex = 3;
            // 
            // buttonDeleteOrganization
            // 
            this.buttonDeleteOrganization.Location = new System.Drawing.Point(44, 260);
            this.buttonDeleteOrganization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteOrganization.Name = "buttonDeleteOrganization";
            this.buttonDeleteOrganization.Size = new System.Drawing.Size(107, 38);
            this.buttonDeleteOrganization.TabIndex = 2;
            this.buttonDeleteOrganization.Text = "Delete";
            this.buttonDeleteOrganization.UseVisualStyleBackColor = true;
            this.buttonDeleteOrganization.Click += new System.EventHandler(this.ButtonDeleteOrganization_Click);
            // 
            // buttonEditOrganization
            // 
            this.buttonEditOrganization.Location = new System.Drawing.Point(44, 185);
            this.buttonEditOrganization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditOrganization.Name = "buttonEditOrganization";
            this.buttonEditOrganization.Size = new System.Drawing.Size(107, 38);
            this.buttonEditOrganization.TabIndex = 1;
            this.buttonEditOrganization.Text = "Edit";
            this.buttonEditOrganization.UseVisualStyleBackColor = true;
            this.buttonEditOrganization.Click += new System.EventHandler(this.ButtonEditOrganization_Click);
            // 
            // buttonAddOrganization
            // 
            this.buttonAddOrganization.Location = new System.Drawing.Point(44, 112);
            this.buttonAddOrganization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddOrganization.Name = "buttonAddOrganization";
            this.buttonAddOrganization.Size = new System.Drawing.Size(107, 38);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1634, 813);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1648, 841);
            this.Name = "Form1";
            this.Text = "Sport Events";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelEventInfromation.ResumeLayout(false);
            this.panelEventInfromation.PerformLayout();
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
        private Label labelEventOrganization;
        private TextBox textBoxName;
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
        private Panel panelEventInfromation;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDedlete;
    }
}