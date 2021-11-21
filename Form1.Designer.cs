
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
            this.c_searchCheck = new System.Windows.Forms.CheckBox();
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
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l_changeMinorInjury = new System.Windows.Forms.Label();
            this.l_changeDead = new System.Windows.Forms.Label();
            this.l_changeSeverelyInjured = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l_changeAll = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.groupBox1.Controls.Add(this.c_searchCheck);
            this.groupBox1.Controls.Add(this.b_searchAll);
            this.groupBox1.Controls.Add(this.b_export);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.t_locationInput);
            this.groupBox1.Controls.Add(this.c_location1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // c_searchCheck
            // 
            this.c_searchCheck.AutoSize = true;
            this.c_searchCheck.Location = new System.Drawing.Point(222, 21);
            this.c_searchCheck.Name = "c_searchCheck";
            this.c_searchCheck.Size = new System.Drawing.Size(32, 16);
            this.c_searchCheck.TabIndex = 9;
            this.c_searchCheck.Text = "X";
            this.c_searchCheck.UseVisualStyleBackColor = true;
            // 
            // b_searchAll
            // 
            this.b_searchAll.Location = new System.Drawing.Point(68, 276);
            this.b_searchAll.Name = "b_searchAll";
            this.b_searchAll.Size = new System.Drawing.Size(83, 23);
            this.b_searchAll.TabIndex = 8;
            this.b_searchAll.Text = "전부 검색";
            this.b_searchAll.UseVisualStyleBackColor = true;
            this.b_searchAll.Click += new System.EventHandler(this.b_searchAll_Click);
            // 
            // b_export
            // 
            this.b_export.Location = new System.Drawing.Point(157, 276);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(97, 23);
            this.b_export.TabIndex = 7;
            this.b_export.Text = "내보내기 (xml)";
            this.b_export.UseVisualStyleBackColor = true;
            this.b_export.Click += new System.EventHandler(this.b_export_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(6, 276);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(56, 23);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "검색";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // t_locationInput
            // 
            this.t_locationInput.Location = new System.Drawing.Point(133, 19);
            this.t_locationInput.Name = "t_locationInput";
            this.t_locationInput.Size = new System.Drawing.Size(83, 21);
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
            "가평군",
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
            this.c_location1.Location = new System.Drawing.Point(6, 20);
            this.c_location1.Name = "c_location1";
            this.c_location1.Size = new System.Drawing.Size(121, 20);
            this.c_location1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(6, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 224);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1114, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // L_mainFromNameLabel
            // 
            this.L_mainFromNameLabel.AutoSize = true;
            this.L_mainFromNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.L_mainFromNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.L_mainFromNameLabel.Location = new System.Drawing.Point(10, 9);
            this.L_mainFromNameLabel.Name = "L_mainFromNameLabel";
            this.L_mainFromNameLabel.Size = new System.Drawing.Size(41, 12);
            this.L_mainFromNameLabel.TabIndex = 2;
            this.L_mainFromNameLabel.Text = "급식소";
            // 
            // l_exitLabel
            // 
            this.l_exitLabel.AutoSize = true;
            this.l_exitLabel.BackColor = System.Drawing.Color.DimGray;
            this.l_exitLabel.ForeColor = System.Drawing.Color.Transparent;
            this.l_exitLabel.Location = new System.Drawing.Point(1071, 9);
            this.l_exitLabel.Name = "l_exitLabel";
            this.l_exitLabel.Size = new System.Drawing.Size(13, 12);
            this.l_exitLabel.TabIndex = 3;
            this.l_exitLabel.Text = "X";
            this.l_exitLabel.Click += new System.EventHandler(this.l_exitLabel_Click);
            // 
            // l_windowMinimize
            // 
            this.l_windowMinimize.AutoSize = true;
            this.l_windowMinimize.BackColor = System.Drawing.Color.DimGray;
            this.l_windowMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.l_windowMinimize.Location = new System.Drawing.Point(1054, 9);
            this.l_windowMinimize.Name = "l_windowMinimize";
            this.l_windowMinimize.Size = new System.Drawing.Size(11, 12);
            this.l_windowMinimize.TabIndex = 4;
            this.l_windowMinimize.Text = "_";
            this.l_windowMinimize.Click += new System.EventHandler(this.l_windowMinimize_Click);
            // 
            // l_names
            // 
            this.l_names.FormattingEnabled = true;
            this.l_names.ItemHeight = 12;
            this.l_names.Location = new System.Drawing.Point(6, 20);
            this.l_names.Name = "l_names";
            this.l_names.Size = new System.Drawing.Size(162, 280);
            this.l_names.TabIndex = 5;
            this.l_names.SelectedIndexChanged += new System.EventHandler(this.l_names_SelectedIndexChanged);
            // 
            // g_data
            // 
            this.g_data.Controls.Add(this.groupBox4);
            this.g_data.Controls.Add(this.groupBox3);
            this.g_data.Controls.Add(this.webBrowser1);
            this.g_data.Controls.Add(this.l_names);
            this.g_data.Location = new System.Drawing.Point(281, 32);
            this.g_data.Name = "g_data";
            this.g_data.Size = new System.Drawing.Size(803, 306);
            this.g_data.TabIndex = 6;
            this.g_data.TabStop = false;
            this.g_data.Text = "결과 (검색 대기중)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.l_changeMinorInjury);
            this.groupBox4.Controls.Add(this.l_changeDead);
            this.groupBox4.Controls.Add(this.l_changeSeverelyInjured);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.l_changeAll);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(174, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 144);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "근처 사고 정보";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "이름";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 12);
            this.label17.TabIndex = 30;
            this.label17.Text = "위험 점수 : ";
            // 
            // l_changeMinorInjury
            // 
            this.l_changeMinorInjury.AutoSize = true;
            this.l_changeMinorInjury.Location = new System.Drawing.Point(73, 34);
            this.l_changeMinorInjury.Name = "l_changeMinorInjury";
            this.l_changeMinorInjury.Size = new System.Drawing.Size(29, 12);
            this.l_changeMinorInjury.TabIndex = 29;
            this.l_changeMinorInjury.Text = "이름";
            // 
            // l_changeDead
            // 
            this.l_changeDead.AutoSize = true;
            this.l_changeDead.Location = new System.Drawing.Point(73, 68);
            this.l_changeDead.Name = "l_changeDead";
            this.l_changeDead.Size = new System.Drawing.Size(29, 12);
            this.l_changeDead.TabIndex = 28;
            this.l_changeDead.Text = "이름";
            // 
            // l_changeSeverelyInjured
            // 
            this.l_changeSeverelyInjured.AutoSize = true;
            this.l_changeSeverelyInjured.Location = new System.Drawing.Point(73, 51);
            this.l_changeSeverelyInjured.Name = "l_changeSeverelyInjured";
            this.l_changeSeverelyInjured.Size = new System.Drawing.Size(29, 12);
            this.l_changeSeverelyInjured.TabIndex = 27;
            this.l_changeSeverelyInjured.Text = "이름";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "이름";
            // 
            // l_changeAll
            // 
            this.l_changeAll.AutoSize = true;
            this.l_changeAll.Location = new System.Drawing.Point(73, 17);
            this.l_changeAll.Name = "l_changeAll";
            this.l_changeAll.Size = new System.Drawing.Size(29, 12);
            this.l_changeAll.TabIndex = 25;
            this.l_changeAll.Text = "이름";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "경상자 : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "주소 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "사망자 : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "중상자 : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "총 사상자 : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "지도 >";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(174, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 130);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "위치 정보";
            // 
            // l_changeDayOfWeek
            // 
            this.l_changeDayOfWeek.AutoSize = true;
            this.l_changeDayOfWeek.Location = new System.Drawing.Point(73, 34);
            this.l_changeDayOfWeek.Name = "l_changeDayOfWeek";
            this.l_changeDayOfWeek.Size = new System.Drawing.Size(0, 12);
            this.l_changeDayOfWeek.TabIndex = 19;
            // 
            // l_changeTime
            // 
            this.l_changeTime.AutoSize = true;
            this.l_changeTime.Location = new System.Drawing.Point(73, 80);
            this.l_changeTime.Name = "l_changeTime";
            this.l_changeTime.Size = new System.Drawing.Size(0, 12);
            this.l_changeTime.TabIndex = 18;
            // 
            // l_changeTarget
            // 
            this.l_changeTarget.AutoSize = true;
            this.l_changeTarget.Location = new System.Drawing.Point(73, 51);
            this.l_changeTarget.Name = "l_changeTarget";
            this.l_changeTarget.Size = new System.Drawing.Size(0, 12);
            this.l_changeTarget.TabIndex = 17;
            // 
            // l_changeLocation
            // 
            this.l_changeLocation.AutoSize = true;
            this.l_changeLocation.Location = new System.Drawing.Point(73, 97);
            this.l_changeLocation.Name = "l_changeLocation";
            this.l_changeLocation.Size = new System.Drawing.Size(0, 12);
            this.l_changeLocation.TabIndex = 16;
            // 
            // l_changeInstitution
            // 
            this.l_changeInstitution.AutoSize = true;
            this.l_changeInstitution.Location = new System.Drawing.Point(73, 17);
            this.l_changeInstitution.Name = "l_changeInstitution";
            this.l_changeInstitution.Size = new System.Drawing.Size(0, 12);
            this.l_changeInstitution.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "날짜 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "주소 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "시간 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "대상 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "관리기관 :";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(499, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(293, 281);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 349);
            this.Controls.Add(this.g_data);
            this.Controls.Add(this.l_windowMinimize);
            this.Controls.Add(this.l_exitLabel);
            this.Controls.Add(this.L_mainFromNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.g_data.ResumeLayout(false);
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
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button b_searchAll;
        private System.Windows.Forms.CheckBox c_searchCheck;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_changeAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

