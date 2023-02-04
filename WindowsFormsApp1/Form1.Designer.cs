
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show_product = new System.Windows.Forms.CheckBox();
            this.show_issue = new System.Windows.Forms.CheckBox();
            this.show_company = new System.Windows.Forms.CheckBox();
            this.show_complaint = new System.Windows.Forms.CheckBox();
            this.show_state = new System.Windows.Forms.CheckBox();
            this.show_oran = new System.Windows.Forms.CheckBox();
            this.oran_goal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.same_product = new System.Windows.Forms.RadioButton();
            this.same_issue = new System.Windows.Forms.RadioButton();
            this.same_company = new System.Windows.Forms.RadioButton();
            this.same_state = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comp_product = new System.Windows.Forms.RadioButton();
            this.comp_issue = new System.Windows.Forms.RadioButton();
            this.comp_company = new System.Windows.Forms.RadioButton();
            this.comp_state = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_thr1 = new System.Windows.Forms.TextBox();
            this.box_thr0 = new System.Windows.Forms.TextBox();
            this.box_thr2 = new System.Windows.Forms.TextBox();
            this.box_thr14 = new System.Windows.Forms.TextBox();
            this.box_thr4 = new System.Windows.Forms.TextBox();
            this.box_thr5 = new System.Windows.Forms.TextBox();
            this.box_thr6 = new System.Windows.Forms.TextBox();
            this.box_thr7 = new System.Windows.Forms.TextBox();
            this.box_thr12 = new System.Windows.Forms.TextBox();
            this.box_thr13 = new System.Windows.Forms.TextBox();
            this.box_thr9 = new System.Windows.Forms.TextBox();
            this.box_thr10 = new System.Windows.Forms.TextBox();
            this.box_thr11 = new System.Windows.Forms.TextBox();
            this.box_thr8 = new System.Windows.Forms.TextBox();
            this.box_thr3 = new System.Windows.Forms.TextBox();
            this.box_run = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Thread0 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Normal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Same";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "by id";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 537);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thread sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "veri sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bulunan sonuçlardan hangi bölümler gösterilecek?";
            // 
            // show_product
            // 
            this.show_product.AutoSize = true;
            this.show_product.Location = new System.Drawing.Point(321, 77);
            this.show_product.Name = "show_product";
            this.show_product.Size = new System.Drawing.Size(90, 24);
            this.show_product.TabIndex = 11;
            this.show_product.Text = "Product";
            this.show_product.UseVisualStyleBackColor = true;
            // 
            // show_issue
            // 
            this.show_issue.AutoSize = true;
            this.show_issue.Location = new System.Drawing.Point(322, 119);
            this.show_issue.Name = "show_issue";
            this.show_issue.Size = new System.Drawing.Size(74, 24);
            this.show_issue.TabIndex = 12;
            this.show_issue.Text = "Issue";
            this.show_issue.UseVisualStyleBackColor = true;
            // 
            // show_company
            // 
            this.show_company.AutoSize = true;
            this.show_company.Location = new System.Drawing.Point(321, 163);
            this.show_company.Name = "show_company";
            this.show_company.Size = new System.Drawing.Size(102, 24);
            this.show_company.TabIndex = 13;
            this.show_company.Text = "Company";
            this.show_company.UseVisualStyleBackColor = true;
            // 
            // show_complaint
            // 
            this.show_complaint.AutoSize = true;
            this.show_complaint.Location = new System.Drawing.Point(321, 207);
            this.show_complaint.Name = "show_complaint";
            this.show_complaint.Size = new System.Drawing.Size(127, 24);
            this.show_complaint.TabIndex = 15;
            this.show_complaint.Text = "Complaint ID";
            this.show_complaint.UseVisualStyleBackColor = true;
            this.show_complaint.CheckedChanged += new System.EventHandler(this.show_complaint_CheckedChanged);
            // 
            // show_state
            // 
            this.show_state.AutoSize = true;
            this.show_state.Location = new System.Drawing.Point(321, 246);
            this.show_state.Name = "show_state";
            this.show_state.Size = new System.Drawing.Size(74, 24);
            this.show_state.TabIndex = 16;
            this.show_state.Text = "State";
            this.show_state.UseVisualStyleBackColor = true;
            // 
            // show_oran
            // 
            this.show_oran.AutoSize = true;
            this.show_oran.Location = new System.Drawing.Point(322, 290);
            this.show_oran.Name = "show_oran";
            this.show_oran.Size = new System.Drawing.Size(67, 24);
            this.show_oran.TabIndex = 17;
            this.show_oran.Text = "oran";
            this.show_oran.UseVisualStyleBackColor = true;
            // 
            // oran_goal
            // 
            this.oran_goal.Location = new System.Drawing.Point(275, 537);
            this.oran_goal.Name = "oran_goal";
            this.oran_goal.Size = new System.Drawing.Size(100, 26);
            this.oran_goal.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hedef Benzerlik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(793, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Same";
            // 
            // same_product
            // 
            this.same_product.AutoSize = true;
            this.same_product.Location = new System.Drawing.Point(16, 3);
            this.same_product.Name = "same_product";
            this.same_product.Size = new System.Drawing.Size(89, 24);
            this.same_product.TabIndex = 22;
            this.same_product.TabStop = true;
            this.same_product.Text = "Product";
            this.same_product.UseVisualStyleBackColor = true;
            this.same_product.CheckedChanged += new System.EventHandler(this.product_Same_CheckedChanged);
            // 
            // same_issue
            // 
            this.same_issue.AutoSize = true;
            this.same_issue.Location = new System.Drawing.Point(16, 33);
            this.same_issue.Name = "same_issue";
            this.same_issue.Size = new System.Drawing.Size(73, 24);
            this.same_issue.TabIndex = 23;
            this.same_issue.TabStop = true;
            this.same_issue.Text = "Issue";
            this.same_issue.UseVisualStyleBackColor = true;
            // 
            // same_company
            // 
            this.same_company.AutoSize = true;
            this.same_company.Location = new System.Drawing.Point(16, 61);
            this.same_company.Name = "same_company";
            this.same_company.Size = new System.Drawing.Size(101, 24);
            this.same_company.TabIndex = 24;
            this.same_company.TabStop = true;
            this.same_company.Text = "Company";
            this.same_company.UseVisualStyleBackColor = true;
            // 
            // same_state
            // 
            this.same_state.AutoSize = true;
            this.same_state.Location = new System.Drawing.Point(16, 91);
            this.same_state.Name = "same_state";
            this.same_state.Size = new System.Drawing.Size(73, 24);
            this.same_state.TabIndex = 25;
            this.same_state.TabStop = true;
            this.same_state.Text = "State";
            this.same_state.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(55, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 101);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.same_product);
            this.panel2.Controls.Add(this.same_issue);
            this.panel2.Controls.Add(this.same_state);
            this.panel2.Controls.Add(this.same_company);
            this.panel2.Location = new System.Drawing.Point(747, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 128);
            this.panel2.TabIndex = 27;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(275, 414);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 26);
            this.text_id.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(719, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Karşılaştırma hangi sütünda olacak";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comp_state);
            this.panel3.Controls.Add(this.comp_company);
            this.panel3.Controls.Add(this.comp_issue);
            this.panel3.Controls.Add(this.comp_product);
            this.panel3.Location = new System.Drawing.Point(747, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 127);
            this.panel3.TabIndex = 31;
            // 
            // comp_product
            // 
            this.comp_product.AutoSize = true;
            this.comp_product.Location = new System.Drawing.Point(19, 4);
            this.comp_product.Name = "comp_product";
            this.comp_product.Size = new System.Drawing.Size(89, 24);
            this.comp_product.TabIndex = 0;
            this.comp_product.TabStop = true;
            this.comp_product.Text = "Product";
            this.comp_product.UseVisualStyleBackColor = true;
            // 
            // comp_issue
            // 
            this.comp_issue.AutoSize = true;
            this.comp_issue.Location = new System.Drawing.Point(19, 34);
            this.comp_issue.Name = "comp_issue";
            this.comp_issue.Size = new System.Drawing.Size(73, 24);
            this.comp_issue.TabIndex = 1;
            this.comp_issue.TabStop = true;
            this.comp_issue.Text = "Issue";
            this.comp_issue.UseVisualStyleBackColor = true;
            // 
            // comp_company
            // 
            this.comp_company.AutoSize = true;
            this.comp_company.Location = new System.Drawing.Point(19, 65);
            this.comp_company.Name = "comp_company";
            this.comp_company.Size = new System.Drawing.Size(101, 24);
            this.comp_company.TabIndex = 2;
            this.comp_company.TabStop = true;
            this.comp_company.Text = "Company";
            this.comp_company.UseVisualStyleBackColor = true;
            // 
            // comp_state
            // 
            this.comp_state.AutoSize = true;
            this.comp_state.Location = new System.Drawing.Point(19, 96);
            this.comp_state.Name = "comp_state";
            this.comp_state.Size = new System.Drawing.Size(73, 24);
            this.comp_state.TabIndex = 3;
            this.comp_state.TabStop = true;
            this.comp_state.Text = "State";
            this.comp_state.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product1,
            this.issue1,
            this.company1,
            this.complaint1,
            this.state1,
            this.product2,
            this.issue2,
            this.company2,
            this.complaint2,
            this.state2,
            this.oran});
            this.dataGridView1.Location = new System.Drawing.Point(3, 595);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(2523, 687);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // product1
            // 
            this.product1.HeaderText = "product1";
            this.product1.MinimumWidth = 8;
            this.product1.Name = "product1";
            this.product1.Width = 150;
            // 
            // issue1
            // 
            this.issue1.HeaderText = "issue1";
            this.issue1.MinimumWidth = 8;
            this.issue1.Name = "issue1";
            this.issue1.Width = 150;
            // 
            // company1
            // 
            this.company1.HeaderText = "company1";
            this.company1.MinimumWidth = 8;
            this.company1.Name = "company1";
            this.company1.Width = 150;
            // 
            // complaint1
            // 
            this.complaint1.HeaderText = "complaint1";
            this.complaint1.MinimumWidth = 8;
            this.complaint1.Name = "complaint1";
            this.complaint1.Width = 150;
            // 
            // state1
            // 
            this.state1.HeaderText = "state1";
            this.state1.MinimumWidth = 8;
            this.state1.Name = "state1";
            this.state1.Width = 150;
            // 
            // product2
            // 
            this.product2.HeaderText = "product2";
            this.product2.MinimumWidth = 8;
            this.product2.Name = "product2";
            this.product2.Width = 150;
            // 
            // issue2
            // 
            this.issue2.HeaderText = "issue2";
            this.issue2.MinimumWidth = 8;
            this.issue2.Name = "issue2";
            this.issue2.Width = 150;
            // 
            // company2
            // 
            this.company2.HeaderText = "company2";
            this.company2.MinimumWidth = 8;
            this.company2.Name = "company2";
            this.company2.Width = 150;
            // 
            // complaint2
            // 
            this.complaint2.HeaderText = "complaint2";
            this.complaint2.MinimumWidth = 8;
            this.complaint2.Name = "complaint2";
            this.complaint2.Width = 150;
            // 
            // state2
            // 
            this.state2.HeaderText = "state2";
            this.state2.MinimumWidth = 8;
            this.state2.Name = "state2";
            this.state2.Width = 150;
            // 
            // oran
            // 
            this.oran.HeaderText = "oran";
            this.oran.MinimumWidth = 8;
            this.oran.Name = "oran";
            this.oran.Width = 150;
            // 
            // box_thr1
            // 
            this.box_thr1.Location = new System.Drawing.Point(0, 144);
            this.box_thr1.Name = "box_thr1";
            this.box_thr1.Size = new System.Drawing.Size(100, 26);
            this.box_thr1.TabIndex = 33;
            // 
            // box_thr0
            // 
            this.box_thr0.Location = new System.Drawing.Point(0, 75);
            this.box_thr0.Name = "box_thr0";
            this.box_thr0.Size = new System.Drawing.Size(100, 26);
            this.box_thr0.TabIndex = 34;
            // 
            // box_thr2
            // 
            this.box_thr2.Location = new System.Drawing.Point(0, 211);
            this.box_thr2.Name = "box_thr2";
            this.box_thr2.Size = new System.Drawing.Size(100, 26);
            this.box_thr2.TabIndex = 35;
            // 
            // box_thr14
            // 
            this.box_thr14.Location = new System.Drawing.Point(438, 211);
            this.box_thr14.Name = "box_thr14";
            this.box_thr14.Size = new System.Drawing.Size(100, 26);
            this.box_thr14.TabIndex = 36;
            this.box_thr14.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // box_thr4
            // 
            this.box_thr4.Location = new System.Drawing.Point(151, 77);
            this.box_thr4.Name = "box_thr4";
            this.box_thr4.Size = new System.Drawing.Size(100, 26);
            this.box_thr4.TabIndex = 37;
            // 
            // box_thr5
            // 
            this.box_thr5.Location = new System.Drawing.Point(151, 144);
            this.box_thr5.Name = "box_thr5";
            this.box_thr5.Size = new System.Drawing.Size(100, 26);
            this.box_thr5.TabIndex = 38;
            // 
            // box_thr6
            // 
            this.box_thr6.Location = new System.Drawing.Point(151, 211);
            this.box_thr6.Name = "box_thr6";
            this.box_thr6.Size = new System.Drawing.Size(100, 26);
            this.box_thr6.TabIndex = 39;
            // 
            // box_thr7
            // 
            this.box_thr7.Location = new System.Drawing.Point(151, 276);
            this.box_thr7.Name = "box_thr7";
            this.box_thr7.Size = new System.Drawing.Size(100, 26);
            this.box_thr7.TabIndex = 40;
            // 
            // box_thr12
            // 
            this.box_thr12.Location = new System.Drawing.Point(438, 80);
            this.box_thr12.Name = "box_thr12";
            this.box_thr12.Size = new System.Drawing.Size(100, 26);
            this.box_thr12.TabIndex = 41;
            // 
            // box_thr13
            // 
            this.box_thr13.Location = new System.Drawing.Point(438, 142);
            this.box_thr13.Name = "box_thr13";
            this.box_thr13.Size = new System.Drawing.Size(100, 26);
            this.box_thr13.TabIndex = 42;
            // 
            // box_thr9
            // 
            this.box_thr9.Location = new System.Drawing.Point(297, 144);
            this.box_thr9.Name = "box_thr9";
            this.box_thr9.Size = new System.Drawing.Size(100, 26);
            this.box_thr9.TabIndex = 43;
            this.box_thr9.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // box_thr10
            // 
            this.box_thr10.Location = new System.Drawing.Point(297, 211);
            this.box_thr10.Name = "box_thr10";
            this.box_thr10.Size = new System.Drawing.Size(100, 26);
            this.box_thr10.TabIndex = 44;
            this.box_thr10.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // box_thr11
            // 
            this.box_thr11.Location = new System.Drawing.Point(297, 276);
            this.box_thr11.Name = "box_thr11";
            this.box_thr11.Size = new System.Drawing.Size(100, 26);
            this.box_thr11.TabIndex = 45;
            this.box_thr11.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // box_thr8
            // 
            this.box_thr8.Location = new System.Drawing.Point(297, 80);
            this.box_thr8.Name = "box_thr8";
            this.box_thr8.Size = new System.Drawing.Size(100, 26);
            this.box_thr8.TabIndex = 46;
            // 
            // box_thr3
            // 
            this.box_thr3.Location = new System.Drawing.Point(0, 276);
            this.box_thr3.Name = "box_thr3";
            this.box_thr3.Size = new System.Drawing.Size(100, 26);
            this.box_thr3.TabIndex = 47;
            // 
            // box_run
            // 
            this.box_run.Location = new System.Drawing.Point(375, 433);
            this.box_run.Name = "box_run";
            this.box_run.Size = new System.Drawing.Size(100, 26);
            this.box_run.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.Thread0);
            this.panel4.Controls.Add(this.box_thr0);
            this.panel4.Controls.Add(this.box_thr13);
            this.panel4.Controls.Add(this.box_thr11);
            this.panel4.Controls.Add(this.box_thr12);
            this.panel4.Controls.Add(this.box_thr8);
            this.panel4.Controls.Add(this.box_thr10);
            this.panel4.Controls.Add(this.box_thr14);
            this.panel4.Controls.Add(this.box_run);
            this.panel4.Controls.Add(this.box_thr9);
            this.panel4.Controls.Add(this.box_thr1);
            this.panel4.Controls.Add(this.box_thr3);
            this.panel4.Controls.Add(this.box_thr2);
            this.panel4.Controls.Add(this.box_thr4);
            this.panel4.Controls.Add(this.box_thr6);
            this.panel4.Controls.Add(this.box_thr7);
            this.panel4.Controls.Add(this.box_thr5);
            this.panel4.Location = new System.Drawing.Point(1440, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 500);
            this.panel4.TabIndex = 49;
            // 
            // Thread0
            // 
            this.Thread0.AutoSize = true;
            this.Thread0.Location = new System.Drawing.Point(26, 40);
            this.Thread0.Name = "Thread0";
            this.Thread0.Size = new System.Drawing.Size(68, 20);
            this.Thread0.TabIndex = 49;
            this.Thread0.Text = "Thread0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Thread1";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Thread2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "Thread3";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 53;
            this.label13.Text = "Thread4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Thread5";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(173, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Thread6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(173, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 56;
            this.label16.Text = "Thread7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 57;
            this.label17.Text = "Thread8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(317, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 58;
            this.label18.Text = "Thread9";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(317, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 20);
            this.label19.TabIndex = 59;
            this.label19.Text = "Thread10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(317, 249);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 20);
            this.label20.TabIndex = 60;
            this.label20.Text = "Thread11";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(448, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 20);
            this.label21.TabIndex = 61;
            this.label21.Text = "Thread12";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(465, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 62;
            this.label22.Text = "Thread13";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(465, 183);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 20);
            this.label23.TabIndex = 63;
            this.label23.Text = "Thread14";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(371, 397);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 20);
            this.label24.TabIndex = 64;
            this.label24.Text = "Total Runtime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2538, 1384);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oran_goal);
            this.Controls.Add(this.show_oran);
            this.Controls.Add(this.show_state);
            this.Controls.Add(this.show_complaint);
            this.Controls.Add(this.show_company);
            this.Controls.Add(this.show_issue);
            this.Controls.Add(this.show_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox show_product;
        private System.Windows.Forms.CheckBox show_issue;
        private System.Windows.Forms.CheckBox show_company;
        private System.Windows.Forms.CheckBox show_complaint;
        private System.Windows.Forms.CheckBox show_state;
        private System.Windows.Forms.CheckBox show_oran;
        private System.Windows.Forms.TextBox oran_goal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton same_product;
        private System.Windows.Forms.RadioButton same_issue;
        private System.Windows.Forms.RadioButton same_company;
        private System.Windows.Forms.RadioButton same_state;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton comp_state;
        private System.Windows.Forms.RadioButton comp_company;
        private System.Windows.Forms.RadioButton comp_issue;
        private System.Windows.Forms.RadioButton comp_product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn company1;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaint1;
        private System.Windows.Forms.DataGridViewTextBoxColumn state1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product2;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn company2;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaint2;
        private System.Windows.Forms.DataGridViewTextBoxColumn state2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oran;
        private System.Windows.Forms.TextBox box_thr1;
        private System.Windows.Forms.TextBox box_thr0;
        private System.Windows.Forms.TextBox box_thr2;
        private System.Windows.Forms.TextBox box_thr14;
        private System.Windows.Forms.TextBox box_thr4;
        private System.Windows.Forms.TextBox box_thr5;
        private System.Windows.Forms.TextBox box_thr6;
        private System.Windows.Forms.TextBox box_thr7;
        private System.Windows.Forms.TextBox box_thr12;
        private System.Windows.Forms.TextBox box_thr13;
        private System.Windows.Forms.TextBox box_thr9;
        private System.Windows.Forms.TextBox box_thr10;
        private System.Windows.Forms.TextBox box_thr11;
        private System.Windows.Forms.TextBox box_thr8;
        private System.Windows.Forms.TextBox box_thr3;
        private System.Windows.Forms.TextBox box_run;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Thread0;
    }
}

