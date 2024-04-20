namespace AdministratorWydarzen
{
    partial class EventView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventView));
            title = new Label();
            opis = new Label();
            typ = new Label();
            priorytet = new Label();
            data = new Label();
            textBoxTitle = new TextBox();
            add = new Button();
            delete = new Button();
            save = new Button();
            read = new Button();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            comboBox3 = new ComboBox();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            comboBox4 = new ComboBox();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            sort = new Button();
            filtr = new Button();
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            resources.ApplyResources(title, "title");
            title.Name = "title";
            // 
            // opis
            // 
            resources.ApplyResources(opis, "opis");
            opis.Name = "opis";
            // 
            // typ
            // 
            resources.ApplyResources(typ, "typ");
            typ.Name = "typ";
            // 
            // priorytet
            // 
            resources.ApplyResources(priorytet, "priorytet");
            priorytet.Name = "priorytet";
            // 
            // data
            // 
            resources.ApplyResources(data, "data");
            data.Name = "data";
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.Snow;
            resources.ApplyResources(textBoxTitle, "textBoxTitle");
            textBoxTitle.Name = "textBoxTitle";
            // 
            // add
            // 
            add.BackColor = Color.Thistle;
            add.FlatAppearance.BorderColor = Color.Purple;
            add.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(add, "add");
            add.Name = "add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Thistle;
            delete.FlatAppearance.BorderColor = Color.Purple;
            delete.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(delete, "delete");
            delete.Name = "delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // save
            // 
            save.BackColor = Color.Thistle;
            save.FlatAppearance.BorderColor = Color.Purple;
            save.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(save, "save");
            save.Name = "save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // read
            // 
            read.BackColor = Color.Thistle;
            read.FlatAppearance.BorderColor = Color.Purple;
            read.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(read, "read");
            read.Name = "read";
            read.UseVisualStyleBackColor = false;
            read.Click += read_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Snow;
            resources.ApplyResources(richTextBox1, "richTextBox1");
            richTextBox1.Name = "richTextBox1";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Snow;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.Snow;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { resources.GetString("comboBox2.Items"), resources.GetString("comboBox2.Items1"), resources.GetString("comboBox2.Items2") });
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.Name = "comboBox2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionChanged += loadDescription;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("comboBox3.AutoCompleteCustomSource"), resources.GetString("comboBox3.AutoCompleteCustomSource1"), resources.GetString("comboBox3.AutoCompleteCustomSource2") });
            comboBox3.BackColor = Color.Snow;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { resources.GetString("comboBox3.Items"), resources.GetString("comboBox3.Items1"), resources.GetString("comboBox3.Items2") });
            resources.ApplyResources(comboBox3, "comboBox3");
            comboBox3.Name = "comboBox3";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(monthCalendar1, "monthCalendar1");
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.ShowTodayCircle = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("comboBox4.AutoCompleteCustomSource"), resources.GetString("comboBox4.AutoCompleteCustomSource1"), resources.GetString("comboBox4.AutoCompleteCustomSource2") });
            comboBox4.BackColor = Color.Snow;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { resources.GetString("comboBox4.Items"), resources.GetString("comboBox4.Items1"), resources.GetString("comboBox4.Items2"), resources.GetString("comboBox4.Items3") });
            resources.ApplyResources(comboBox4, "comboBox4");
            comboBox4.Name = "comboBox4";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // panel5
            // 
            panel5.BackColor = Color.HotPink;
            resources.ApplyResources(panel5, "panel5");
            panel5.Name = "panel5";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // sort
            // 
            sort.BackColor = Color.Thistle;
            sort.FlatAppearance.BorderColor = Color.Purple;
            sort.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(sort, "sort");
            sort.Name = "sort";
            sort.UseVisualStyleBackColor = false;
            sort.Click += sort_Click;
            // 
            // filtr
            // 
            filtr.BackColor = Color.Thistle;
            filtr.FlatAppearance.BorderColor = Color.Purple;
            filtr.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(filtr, "filtr");
            filtr.Name = "filtr";
            filtr.UseVisualStyleBackColor = false;
            filtr.Click += filtr_Click;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Snow;
            resources.ApplyResources(richTextBox2, "richTextBox2");
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            // 
            // EventView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            Controls.Add(richTextBox2);
            Controls.Add(filtr);
            Controls.Add(sort);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(comboBox4);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(read);
            Controls.Add(save);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(textBoxTitle);
            Controls.Add(data);
            Controls.Add(priorytet);
            Controls.Add(typ);
            Controls.Add(opis);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EventView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label opis;
        private Label typ;
        private Label priorytet;
        private Label data;
        private TextBox textBoxTitle;
        private Button add;
        private Button delete;
        private Button save;
        private Button read;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label4;
        private ComboBox comboBox4;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private Button filtr;
        private Button sort;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private RichTextBox richTextBox2;
    }
}
