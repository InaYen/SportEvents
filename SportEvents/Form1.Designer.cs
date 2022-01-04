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
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelEventEndDate = new System.Windows.Forms.Label();
            this.labelEventStartDate = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelEventName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelEventOrganization = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonDedlete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(587, 44);
            this.dataGridViewEvents.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 62;
            this.dataGridViewEvents.RowTemplate.Height = 33;
            this.dataGridViewEvents.Size = new System.Drawing.Size(238, 132);
            this.dataGridViewEvents.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 423);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.buttonDedlete);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.labelSearch);
            this.tabPage1.Controls.Add(this.textBoxOrganization);
            this.tabPage1.Controls.Add(this.textBoxEndDate);
            this.tabPage1.Controls.Add(this.textBoxStartDate);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.labelEventOrganization);
            this.tabPage1.Controls.Add(this.labelEventEndDate);
            this.tabPage1.Controls.Add(this.labelEventStartDate);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonEdit);
            this.tabPage1.Controls.Add(this.listViewEvents);
            this.tabPage1.Controls.Add(this.labelEventName);
            this.tabPage1.Controls.Add(this.dataGridViewEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of Events";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(829, 120);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(53, 20);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(709, 199);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(172, 23);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(709, 236);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(172, 23);
            this.textBoxStartDate.TabIndex = 14;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(709, 273);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.Size = new System.Drawing.Size(172, 23);
            this.textBoxEndDate.TabIndex = 15;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(709, 306);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(172, 23);
            this.textBoxOrganization.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 18;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(599, 13);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(42, 15);
            this.labelSearch.TabIndex = 17;
            this.labelSearch.Text = "Search";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 423);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridViewEvents;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelEventName;
        private TabPage tabPage2;
        private ImageList imageList;
        private ListView listViewEvents;
        private Label labelEventEndDate;
        private Label labelEventStartDate;
        private Button buttonSave;
        private Button buttonEdit;
        private Label labelEventOrganization;
        private TextBox textBoxOrganization;
        private TextBox textBoxEndDate;
        private TextBox textBoxStartDate;
        private TextBox textBoxName;
        private Button buttonDedlete;
        private TextBox textBox1;
        private Label labelSearch;
        private Button buttonAdd;
    }
}