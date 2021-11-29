
namespace xmlOldViewer
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_searchAll = new System.Windows.Forms.Button();
            this.b_export = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.t_locationInput = new System.Windows.Forms.TextBox();
            this.c_location1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_mainFromNameLabel = new System.Windows.Forms.Label();
            this.l_exitLabel = new System.Windows.Forms.Label();
            this.l_windowMinimize = new System.Windows.Forms.Label();
            this.l_names = new System.Windows.Forms.ListBox();
            this.g_data = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.l_changeRate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l_changeMinorInjury = new System.Windows.Forms.Label();
            this.l_changeDead = new System.Windows.Forms.Label();
            this.l_changeSeverelyInjured = new System.Windows.Forms.Label();
            this.l_changeAll = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.l_changeDayOfWeek = new System.Windows.Forms.Label();
            this.l_changeTime = new System.Windows.Forms.Label();
            this.l_changeTarget = new System.Windows.Forms.Label();
            this.l_changeLocation = new System.Windows.Forms.Label();
            this.l_changeInstitution = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_locations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.g_data.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_searchAll);
            this.groupBox1.Controls.Add(this.b_export);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.t_locationInput);
            this.groupBox1.Controls.Add(this.c_location1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // b_searchAll
            // 
            this.b_searchAll.Location = new System.Drawing.Point(97, 414);
            this.b_searchAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_searchAll.Name = "b_searchAll";
            this.b_searchAll.Size = new System.Drawing.Size(119, 34);
            this.b_searchAll.TabIndex = 8;
            this.b_searchAll.Text = "전부 검색";
            this.b_searchAll.UseVisualStyleBackColor = true;
            this.b_searchAll.Click += new System.EventHandler(this.b_searchAll_Click);
            // 
            // b_export
            // 
            this.b_export.Location = new System.Drawing.Point(224, 414);
            this.b_export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(139, 34);
            this.b_export.TabIndex = 7;
            this.b_export.Text = "내보내기 (xml)";
            this.b_export.UseVisualStyleBackColor = true;
            this.b_export.Click += new System.EventHandler(this.b_export_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(9, 414);
            this.b_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(80, 34);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "검색";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // t_locationInput
            // 
            this.t_locationInput.Location = new System.Drawing.Point(246, 28);
            this.t_locationInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_locationInput.Name = "t_locationInput";
            this.t_locationInput.Size = new System.Drawing.Size(117, 28);
            this.t_locationInput.TabIndex = 3;
            this.t_locationInput.Text = "추가 검색";
            this.t_locationInput.Click += new System.EventHandler(this.t_locationInput_Click);
            this.t_locationInput.Leave += new System.EventHandler(this.t_locationInput_Leave);
            // 
            // c_location1
            // 
            this.c_location1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_location1.FormattingEnabled = true;
            this.c_location1.Items.AddRange(new object[] {
            "고양시",
            "과천시",
            "광명시",
            "광주시",
            "구리시",
            "군포시",
            "김포시",
            "남양주시",
            "동두천시",
            "부천시",
            "성남시",
            "수원시",
            "시흥시",
            "안산시",
            "안성시",
            "안양시",
            "양주시",
            "양평군",
            "여주시",
            "오산시",
            "용인시",
            "의왕시",
            "의정부시",
            "이천시",
            "파주시",
            "평택시",
            "포천시",
            "하남시",
            "화성시"});
            this.c_location1.Location = new System.Drawing.Point(9, 30);
            this.c_location1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_location1.Name = "c_location1";
            this.c_location1.Size = new System.Drawing.Size(229, 26);
            this.c_location1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(9, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 336);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1591, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // L_mainFromNameLabel
            // 
            this.L_mainFromNameLabel.AutoSize = true;
            this.L_mainFromNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.L_mainFromNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.L_mainFromNameLabel.Location = new System.Drawing.Point(14, 14);
            this.L_mainFromNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_mainFromNameLabel.Name = "L_mainFromNameLabel";
            this.L_mainFromNameLabel.Size = new System.Drawing.Size(62, 18);
            this.L_mainFromNameLabel.TabIndex = 2;
            this.L_mainFromNameLabel.Text = "급식소";
            // 
            // l_exitLabel
            // 
            this.l_exitLabel.AutoSize = true;
            this.l_exitLabel.BackColor = System.Drawing.Color.DimGray;
            this.l_exitLabel.ForeColor = System.Drawing.Color.Transparent;
            this.l_exitLabel.Location = new System.Drawing.Point(1099, 14);
            this.l_exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_exitLabel.Name = "l_exitLabel";
            this.l_exitLabel.Size = new System.Drawing.Size(19, 18);
            this.l_exitLabel.TabIndex = 3;
            this.l_exitLabel.Text = "X";
            this.l_exitLabel.Click += new System.EventHandler(this.l_exitLabel_Click);
            // 
            // l_windowMinimize
            // 
            this.l_windowMinimize.AutoSize = true;
            this.l_windowMinimize.BackColor = System.Drawing.Color.DimGray;
            this.l_windowMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.l_windowMinimize.Location = new System.Drawing.Point(1074, 14);
            this.l_windowMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_windowMinimize.Name = "l_windowMinimize";
            this.l_windowMinimize.Size = new System.Drawing.Size(17, 18);
            this.l_windowMinimize.TabIndex = 4;
            this.l_windowMinimize.Text = "_";
            this.l_windowMinimize.Click += new System.EventHandler(this.l_windowMinimize_Click);
            // 
            // l_names
            // 
            this.l_names.FormattingEnabled = true;
            this.l_names.ItemHeight = 18;
            this.l_names.Location = new System.Drawing.Point(9, 30);
            this.l_names.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.l_names.Name = "l_names";
            this.l_names.Size = new System.Drawing.Size(230, 418);
            this.l_names.TabIndex = 5;
            this.l_names.SelectedIndexChanged += new System.EventHandler(this.l_names_SelectedIndexChanged);
            // 
            // g_data
            // 
            this.g_data.Controls.Add(this.label1);
            this.g_data.Controls.Add(this.l_locations);
            this.g_data.Controls.Add(this.groupBox4);
            this.g_data.Controls.Add(this.groupBox3);
            this.g_data.Controls.Add(this.l_names);
            this.g_data.Location = new System.Drawing.Point(401, 48);
            this.g_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g_data.Name = "g_data";
            this.g_data.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g_data.Size = new System.Drawing.Size(955, 459);
            this.g_data.TabIndex = 6;
            this.g_data.TabStop = false;
            this.g_data.Text = "결과 (검색 대기중)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.l_changeRate);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.l_changeMinorInjury);
            this.groupBox4.Controls.Add(this.l_changeDead);
            this.groupBox4.Controls.Add(this.l_changeSeverelyInjured);
            this.groupBox4.Controls.Add(this.l_changeAll);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(249, 232);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(456, 216);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "근처 사고 정보";
            // 
            // l_changeRate
            // 
            this.l_changeRate.AutoSize = true;
            this.l_changeRate.Location = new System.Drawing.Point(104, 160);
            this.l_changeRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeRate.Name = "l_changeRate";
            this.l_changeRate.Size = new System.Drawing.Size(44, 18);
            this.l_changeRate.TabIndex = 31;
            this.l_changeRate.Text = "이름";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "위험 점수 : ";
            // 
            // l_changeMinorInjury
            // 
            this.l_changeMinorInjury.AutoSize = true;
            this.l_changeMinorInjury.Location = new System.Drawing.Point(104, 51);
            this.l_changeMinorInjury.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeMinorInjury.Name = "l_changeMinorInjury";
            this.l_changeMinorInjury.Size = new System.Drawing.Size(44, 18);
            this.l_changeMinorInjury.TabIndex = 29;
            this.l_changeMinorInjury.Text = "이름";
            // 
            // l_changeDead
            // 
            this.l_changeDead.AutoSize = true;
            this.l_changeDead.Location = new System.Drawing.Point(104, 102);
            this.l_changeDead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeDead.Name = "l_changeDead";
            this.l_changeDead.Size = new System.Drawing.Size(44, 18);
            this.l_changeDead.TabIndex = 28;
            this.l_changeDead.Text = "이름";
            // 
            // l_changeSeverelyInjured
            // 
            this.l_changeSeverelyInjured.AutoSize = true;
            this.l_changeSeverelyInjured.Location = new System.Drawing.Point(104, 76);
            this.l_changeSeverelyInjured.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeSeverelyInjured.Name = "l_changeSeverelyInjured";
            this.l_changeSeverelyInjured.Size = new System.Drawing.Size(44, 18);
            this.l_changeSeverelyInjured.TabIndex = 27;
            this.l_changeSeverelyInjured.Text = "이름";
            // 
            // l_changeAll
            // 
            this.l_changeAll.AutoSize = true;
            this.l_changeAll.Location = new System.Drawing.Point(104, 26);
            this.l_changeAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeAll.Name = "l_changeAll";
            this.l_changeAll.Size = new System.Drawing.Size(44, 18);
            this.l_changeAll.TabIndex = 25;
            this.l_changeAll.Text = "이름";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "경상자 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "사망자 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "중상자 : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "총 사상자 : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.l_changeDayOfWeek);
            this.groupBox3.Controls.Add(this.l_changeTime);
            this.groupBox3.Controls.Add(this.l_changeTarget);
            this.groupBox3.Controls.Add(this.l_changeLocation);
            this.groupBox3.Controls.Add(this.l_changeInstitution);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(249, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(456, 195);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "위치 정보";
            // 
            // l_changeDayOfWeek
            // 
            this.l_changeDayOfWeek.AutoSize = true;
            this.l_changeDayOfWeek.Location = new System.Drawing.Point(104, 51);
            this.l_changeDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeDayOfWeek.Name = "l_changeDayOfWeek";
            this.l_changeDayOfWeek.Size = new System.Drawing.Size(0, 18);
            this.l_changeDayOfWeek.TabIndex = 19;
            // 
            // l_changeTime
            // 
            this.l_changeTime.AutoSize = true;
            this.l_changeTime.Location = new System.Drawing.Point(104, 120);
            this.l_changeTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeTime.Name = "l_changeTime";
            this.l_changeTime.Size = new System.Drawing.Size(0, 18);
            this.l_changeTime.TabIndex = 18;
            // 
            // l_changeTarget
            // 
            this.l_changeTarget.AutoSize = true;
            this.l_changeTarget.Location = new System.Drawing.Point(104, 76);
            this.l_changeTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeTarget.Name = "l_changeTarget";
            this.l_changeTarget.Size = new System.Drawing.Size(0, 18);
            this.l_changeTarget.TabIndex = 17;
            // 
            // l_changeLocation
            // 
            this.l_changeLocation.AutoSize = true;
            this.l_changeLocation.Location = new System.Drawing.Point(104, 146);
            this.l_changeLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeLocation.Name = "l_changeLocation";
            this.l_changeLocation.Size = new System.Drawing.Size(0, 18);
            this.l_changeLocation.TabIndex = 16;
            // 
            // l_changeInstitution
            // 
            this.l_changeInstitution.AutoSize = true;
            this.l_changeInstitution.Location = new System.Drawing.Point(104, 26);
            this.l_changeInstitution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeInstitution.Name = "l_changeInstitution";
            this.l_changeInstitution.Size = new System.Drawing.Size(0, 18);
            this.l_changeInstitution.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "날짜 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "주소 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "시간 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "대상 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "관리기관 :";
            // 
            // l_locations
            // 
            this.l_locations.FormattingEnabled = true;
            this.l_locations.ItemHeight = 18;
            this.l_locations.Location = new System.Drawing.Point(713, 51);
            this.l_locations.Margin = new System.Windows.Forms.Padding(4);
            this.l_locations.Name = "l_locations";
            this.l_locations.Size = new System.Drawing.Size(230, 400);
            this.l_locations.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "선택 급식소 주변 사고위치";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 524);
            this.Controls.Add(this.g_data);
            this.Controls.Add(this.l_windowMinimize);
            this.Controls.Add(this.l_exitLabel);
            this.Controls.Add(this.L_mainFromNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.g_data.ResumeLayout(false);
            this.g_data.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_mainFromNameLabel;
        private System.Windows.Forms.Label l_exitLabel;
        private System.Windows.Forms.Label l_windowMinimize;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.TextBox t_locationInput;
        private System.Windows.Forms.ComboBox c_location1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox l_names;
        private System.Windows.Forms.GroupBox g_data;
        private System.Windows.Forms.Button b_export;
        private System.Windows.Forms.Button b_searchAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label l_changeDayOfWeek;
        private System.Windows.Forms.Label l_changeTime;
        private System.Windows.Forms.Label l_changeTarget;
        private System.Windows.Forms.Label l_changeLocation;
        private System.Windows.Forms.Label l_changeInstitution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label l_changeMinorInjury;
        private System.Windows.Forms.Label l_changeDead;
        private System.Windows.Forms.Label l_changeSeverelyInjured;
        private System.Windows.Forms.Label l_changeAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l_changeRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox l_locations;
    }
}

