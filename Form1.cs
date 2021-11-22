﻿/*
    318 번 줄 수정중. 지금 문제가 경상이랑 중상이랑 전부 같아 아마 db 업로드 할때 잘못된듯?
    보러간다
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;

using MySql.Data.MySqlClient;

namespace xmlOldViewer
{
    public partial class mainForm : Form
    {
        double latitude;
        double longtitude;
        string connectionString;
        public mainForm()
        {
            InitializeComponent();
            c_location1.SelectedIndex = 0;
            connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
        }
        private void getCounts()
        {
            if(l_names.Items.Count > 0)
            {
                g_data.Text = "결과 (" + l_names.Items.Count + "개 찾음)";
            }
        }

        private void l_exitLabel_Click(object sender, EventArgs e)
        {
            reallyExit forExit = new reallyExit();
            forExit.Show();
        }

        private void l_windowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void t_locationInput_Click(object sender, EventArgs e)
        {
            if(t_locationInput.Text =="추가 검색")
            {
                t_locationInput.Text = "";
            }
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            l_names.Items.Clear();
            this.Cursor = Cursors.WaitCursor;
            string[] searchString = new string[2];
            string query = null;
            searchString[0] = c_location1.Text; // 콤보박스
            searchString[1] = null; // 추가검색
            using(MySqlConnection DBconnection = new MySqlConnection())
            {
                using(MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        DBconnection.ConnectionString = connectionString;
                        cmd.Connection = DBconnection;
                        DBconnection.Open();
                        if (t_locationInput.Text != "추가 검색" || t_locationInput.Text == "" || t_locationInput.Text == " ") // 체크박스로 입력 안하고 검색 추가해야할걸
                        {
                            // 검색창에 검색한 것 db에서 찾아라 count를 찾는것이고 없다면 -1을 리턴할거야
                            searchString[1] = t_locationInput.Text;
                            query =
                                "SELECT COUNT(*) " +
                                "FROM 전국무료급식소 " +
                                "WHERE Si = '" + searchString[0] + "' and (Gun like '%" + searchString[1] + "%' or Other like '%" + searchString[1] + "');";
                            cmd.CommandText = query;
                            int isDataThere = Convert.ToInt32(cmd.ExecuteScalar());
                            if (isDataThere == 0)
                            {
                                MessageBox.Show("검색 결과가 없어요");
                                return;
                            }
                            if(g_data.Text == "결과 (검색 대기중)")
                            {
                                g_data.Text = "결과 (";
                            }
                            g_data.Text = g_data.Text + isDataThere.ToString() + "개 검색됨)";
                            query =
                               "SELECT * " +
                               "FROM 전국무료급식소 " +
                               "WHERE Si = '" + searchString[0] + "' and (Gun like '%" + searchString[1] + "%' or Other like '%" + searchString[1] + "');";
                            cmd.CommandText = query;
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double[] getDoubls = new double[2];
                                    string[] arr = new string[8];
                                    arr[0] = reader.GetString(0);
                                    for (int index = 1; index < 5; index++)
                                    {
                                        arr[1] += reader.GetString(index);
                                    }
                                    if (arr[1].Length > 22)
                                    {
                                        arr[1] = arr[1].Insert(22, "\n");
                                    }
                                    arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                    arr[3] = reader.GetString(6);
                                    arr[4] = reader.GetString(7);
                                    arr[5] = reader.GetString(8);
                                    if (arr[5].Length > 22)
                                    {
                                        arr[5] = arr[5].Insert(22, "\n"); // 대상 줄넘김
                                    }
                                    arr[6] = reader.GetString(9);
                                    arr[7] = reader.GetString(10);
                                    getDoubls[0] = reader.GetDouble(11);
                                    getDoubls[1] = reader.GetDouble(12);
                                    l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1]));
                                }
                            }

                            double ca = 0.002;
                            int[] counts = new int[3];
                            counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                            query =
                                "SELECT dead, severelyInjured, minorInjury, latitude, longtitude " +
                                "FROM 사고다발지현황";
                            cmd.CommandText = query;
                            forPrintClass getLoaction;

                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    l_names.SelectedIndex = index;
                                    getLoaction = (forPrintClass)l_names.SelectedItem;
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                                                         // 여기서 판별한다
                                                                         // 1 사분면
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                    counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                                }
                            }
                            query =
                                "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                                "FROM 보행노인사고다발지현황";
                            cmd.CommandText = query;
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                l_names.SelectedIndex = index;
                                getLoaction = (forPrintClass)l_names.SelectedItem;
                                counts[0] = getLoaction.dead;
                                counts[1] = getLoaction.severelyInjured;
                                counts[2] = getLoaction.minorInjury;
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4);
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                }
                            }
                            query =
                                "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                                "FROM 무단횡단사고다발지현황";
                            cmd.CommandText = query;
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    l_names.SelectedIndex = index;
                                    getLoaction = (forPrintClass)l_names.SelectedItem;
                                    counts[0] = getLoaction.dead;
                                    counts[1] = getLoaction.severelyInjured;
                                    counts[2] = getLoaction.minorInjury;
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                                                         // 여기서 판별한다
                                                                         // 1 사분면
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                }
                            }
                            getCounts();
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                double forRate = 0;
                                l_names.SelectedIndex = index;
                                forPrintClass getData = (forPrintClass)l_names.SelectedItem;
                                forRate += (0.8 * getData.dead) + (0.5 * getData.severelyInjured) + (0.2 * getData.minorInjury);
                                getData.rate = forRate;
                                l_names.SelectedItem = getData;
                            }
                            this.Cursor = Cursors.Default;
                        }
                        else // 텍스트가 추가입력일때
                        {
                            query =
                                "SELECT COUNT(*) " +
                                "FROM 전국무료급식소 " +
                                "WHERE Si = '" + searchString[0] + "';";
                            cmd.CommandText = query;
                            int isDataThere = Convert.ToInt32(cmd.ExecuteScalar());
                            if(isDataThere == 0)
                            {
                                MessageBox.Show("검색된 데이터가 없어요");
                                return;
                            }
                            if(g_data.Text == "결과 (검색 대기중)")
                            {
                                g_data.Text = "결과 (";
                            }
                            g_data.Text = g_data.Text + isDataThere.ToString() + "개 검색됨)";
                            query =
                               "SELECT * " +
                               "FROM 전국무료급식소 " +
                               "WHERE Si = '" + searchString[0] + "';";
                            cmd.CommandText = query;
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double[] getDoubls = new double[2];
                                    string[] arr = new string[8];
                                    arr[0] = reader.GetString(0);
                                    for (int index = 1; index < 5; index++)
                                    {
                                        arr[1] += reader.GetString(index);
                                    }
                                    if (arr[1].Length > 22)
                                    {
                                        arr[1] = arr[1].Insert(22, "\n");
                                    }
                                    arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                    arr[3] = reader.GetString(6);
                                    arr[4] = reader.GetString(7);
                                    arr[5] = reader.GetString(8);
                                    if (arr[5].Length > 22)
                                    {
                                        arr[5] = arr[5].Insert(22, "\n"); // 대상 줄넘김
                                    }
                                    arr[6] = reader.GetString(9);
                                    arr[7] = reader.GetString(10);
                                    getDoubls[0] = reader.GetDouble(11);
                                    getDoubls[1] = reader.GetDouble(12);
                                    l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1]));
                                }
                            }

                            double ca = 0.002;
                            int[] counts = new int[3];
                            counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                            query =
                                "SELECT dead, severelyInjured, minorInjury, latitude, longtitude " +
                                "FROM 사고다발지현황";
                            cmd.CommandText = query;
                            forPrintClass getLoaction;

                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    l_names.SelectedIndex = index;
                                    getLoaction = (forPrintClass)l_names.SelectedItem;
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                                                         // 여기서 판별한다
                                                                         // 1 사분면
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                    counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                                }
                            }
                            query =
                                "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                                "FROM 보행노인사고다발지현황";
                            cmd.CommandText = query;
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                l_names.SelectedIndex = index;
                                getLoaction = (forPrintClass)l_names.SelectedItem;
                                counts[0] = getLoaction.dead;
                                counts[1] = getLoaction.severelyInjured;
                                counts[2] = getLoaction.minorInjury;
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4);
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                }
                            }
                            query =
                                "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                                "FROM 무단횡단사고다발지현황";
                            cmd.CommandText = query;
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    l_names.SelectedIndex = index;
                                    getLoaction = (forPrintClass)l_names.SelectedItem;
                                    counts[0] = getLoaction.dead;
                                    counts[1] = getLoaction.severelyInjured;
                                    counts[2] = getLoaction.minorInjury;
                                    while (reader.Read())
                                    {
                                        double latitude; double longitude;
                                        latitude = reader.GetDouble(3);
                                        longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                                                         // 여기서 판별한다
                                                                         // 1 사분면
                                        if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 2 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        // 3 사분면
                                        if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                        if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                        {
                                            counts[0] += reader.GetInt32(0);
                                            counts[1] += reader.GetInt32(1);
                                            counts[2] += reader.GetInt32(2);
                                        }
                                    }
                                    forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                    setData.dead = counts[0];
                                    setData.severelyInjured = counts[1];
                                    setData.minorInjury = counts[2];
                                    l_names.SelectedItem = setData;
                                }
                            }
                            getCounts();
                            for (int index = 0; index < l_names.Items.Count; index++)
                            {
                                double forRate = 0;
                                l_names.SelectedIndex = index;
                                forPrintClass getData = (forPrintClass)l_names.SelectedItem;
                                forRate += (0.8 * getData.dead) + (0.5 * getData.severelyInjured) + (0.2 * getData.minorInjury);
                                getData.rate = forRate;
                                l_names.SelectedItem = getData;
                            }
                            this.Cursor = Cursors.Default;
                        }
                        DBconnection.Close();
                        l_names.ClearSelected();
                        if (l_names.Items.Count > 0)
                        {
                            l_names.SelectedIndex = 0;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (l_names.Items.Count == 0)
                {
                    MessageBox.Show("먼저 검색부터 해주세요.");
                    return;
                }
                string fileName = "xmlExport_";
                if (l_names.Items.Count == 221)
                {
                    fileName += "ALL_";
                    fileName += DateTime.Now;
                    fileName += ".xml";
                }
                else if (t_locationInput.Text == "추가 검색" || t_locationInput.Text == "" || t_locationInput.Text == " ")
                {
                    fileName += c_location1.SelectedItem + "_";
                    fileName += DateTime.Now;
                    fileName += ".xml";
                }
                else
                {
                    fileName += c_location1.SelectedItem + "_";
                    fileName += t_locationInput.Text + "_";
                    fileName += DateTime.Now;
                    fileName += ".xml";
                }
                string[] path = { @"C:\\Users\\user\\Desktop", fileName };
                string fullPath = Path.Combine(path);
                using (XmlWriter wr = XmlWriter.Create(fullPath))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("경기도무료급식소");

                    for (int index = 0; index < l_names.Items.Count; index++)
                    {
                        wr.WriteStartElement("급식소");
                        l_names.SelectedIndex = index;
                        forPrintClass getClass = (forPrintClass)l_names.SelectedItem;
                        wr.WriteElementString("주소", getClass.loaction);
                        wr.WriteEndElement();
                    }
                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                }
                this.Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("xml export \n\n" + ex);
            }
            
        }

        private void l_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            forPrintClass forShow;
            if(l_names.SelectedIndex != -1)
            {
                forShow = (forPrintClass)l_names.SelectedItem;
                forPrintClass getAndConvert = forShow;
                // 위치 정보 그룹박스 안의 라벨 변경
                l_changeInstitution.Text = forShow.institution;
                l_changeLocation.Text = forShow.loaction;
                l_changeDayOfWeek.Text = forShow.dayOfTheWeek;
                l_changeTarget.Text = forShow.target;
                l_changeTime.Text = forShow.time;
                // 사고정보 라벨 변경
                int[] forLabel = new int[3];
                forLabel[0] = forShow.dead;
                forLabel[1] = forShow.severelyInjured;
                forLabel[2] = forShow.minorInjury;
                l_changeDead.Text = forLabel[0].ToString();
                l_changeSeverelyInjured.Text = forLabel[1].ToString();
                l_changeMinorInjury.Text = forLabel[2].ToString();
                l_changeAll.Text = (forLabel[0] + forLabel[1] + forLabel[2]).ToString();
                l_changeRate.Text = forShow.rate.ToString();
            }
        }

        private void t_locationInput_Leave(object sender, EventArgs e)
        {
            if(t_locationInput.Text =="" || t_locationInput.Text==" ")
            {
                t_locationInput.Text = "추가 검색";
            }
        }

        private void b_searchAll_Click(object sender, EventArgs e)
        {
            l_names.Items.Clear();
            try
            {
                this.Cursor = Cursors.WaitCursor;
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlConnection DBconnection = new MySqlConnection())
                    {
                        DBconnection.ConnectionString = connectionString;
                        cmd.Connection = DBconnection;
                        DBconnection.Open();
                        string query;
                        query =
                            "SELECT * " +
                            "FROM 전국무료급식소";
                        cmd.CommandText = query;
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double[] getDoubls = new double[2];
                                string[] arr = new string[8];
                                arr[0] = reader.GetString(0);
                                for (int index = 1; index < 5; index++)
                                {
                                    arr[1] += reader.GetString(index);
                                }
                                if (arr[1].Length > 22)
                                {
                                    arr[1] = arr[1].Insert(22, "\n");
                                }
                                arr[2] = reader.GetString(5); // 여기서부터 10번까지
                                arr[3] = reader.GetString(6);
                                arr[4] = reader.GetString(7);
                                arr[5] = reader.GetString(8);
                                if (arr[5].Length > 22)
                                {
                                    arr[5] = arr[5].Insert(22, "\n"); // 대상 줄넘김
                                }
                                arr[6] = reader.GetString(9);
                                arr[7] = reader.GetString(10);
                                getDoubls[0] = reader.GetDouble(11);
                                getDoubls[1] = reader.GetDouble(12);
                                l_names.Items.Add(new forPrintClass(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], getDoubls[0], getDoubls[1]));
                            }
                        }

                        double ca = 0.002;
                        int[] counts = new int[3];
                        counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                        query =
                            "SELECT dead, severelyInjured, minorInjury, latitude, longtitude " +
                            "FROM 사고다발지현황";
                        cmd.CommandText = query;
                        forPrintClass getLoaction;

                        for (int index = 0; index < l_names.Items.Count; index++)
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                l_names.SelectedIndex = index;
                                getLoaction = (forPrintClass)l_names.SelectedItem;
                                while (reader.Read())
                                {
                                    double latitude; double longitude;
                                    latitude = reader.GetDouble(3);
                                    longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                    // 여기서 판별한다
                                    // 1 사분면
                                    if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 2 사분면
                                    if(((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 3 사분면
                                    if(((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    if(((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                }
                                forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                setData.dead = counts[0];
                                setData.severelyInjured = counts[1];
                                setData.minorInjury = counts[2];
                                l_names.SelectedItem = setData;
                                counts[0] = counts[1] = counts[2] = 0; // 0 : 사망 1 : 중상 2 : 경상
                            }
                        }
                        query =
                            "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                            "FROM 보행노인사고다발지현황";
                        cmd.CommandText = query;
                        for (int index = 0; index < l_names.Items.Count; index++)
                        {
                            l_names.SelectedIndex = index;
                            getLoaction = (forPrintClass)l_names.SelectedItem;
                            counts[0] = getLoaction.dead;
                            counts[1] = getLoaction.severelyInjured;
                            counts[2] = getLoaction.minorInjury;
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    double latitude; double longitude;
                                    latitude = reader.GetDouble(3);
                                    longitude = reader.GetDouble(4);
                                    if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 2 사분면
                                    if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 3 사분면
                                    if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                }
                                forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                setData.dead = counts[0];
                                setData.severelyInjured = counts[1];
                                setData.minorInjury = counts[2];
                                l_names.SelectedItem = setData;
                            }
                        }
                        query =
                            "SELECT dead, severelyInjured, minorInjury, Latitude, Longitude " +
                            "FROM 무단횡단사고다발지현황";
                        cmd.CommandText = query;
                        for (int index = 0; index < l_names.Items.Count; index++)
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                l_names.SelectedIndex = index;
                                getLoaction = (forPrintClass)l_names.SelectedItem;
                                counts[0] = getLoaction.dead;
                                counts[1] = getLoaction.severelyInjured;
                                counts[2] = getLoaction.minorInjury;
                                while (reader.Read())
                                {
                                    double latitude; double longitude;
                                    latitude = reader.GetDouble(3);
                                    longitude = reader.GetDouble(4); // 사고다발지의 위도경도
                                    // 여기서 판별한다
                                    // 1 사분면
                                    if (((latitude >= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 2 사분면
                                    if (((latitude <= getLoaction.latitude) && (longitude >= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) < ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    // 3 사분면
                                    if (((latitude <= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) > -ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                    if (((latitude >= getLoaction.latitude) && (longitude <= getLoaction.longtitude)) && (((latitude - getLoaction.latitude) < ca) && (longtitude - getLoaction.longtitude) > -ca))
                                    {
                                        counts[0] += reader.GetInt32(0);
                                        counts[1] += reader.GetInt32(1);
                                        counts[2] += reader.GetInt32(2);
                                    }
                                }
                                forPrintClass setData = (forPrintClass)l_names.SelectedItem;
                                setData.dead = counts[0];
                                setData.severelyInjured = counts[1];
                                setData.minorInjury = counts[2];
                                l_names.SelectedItem = setData;
                            }
                        }
                        DBconnection.Close();
                    }
                }
                getCounts();
                for(int index = 0; index < l_names.Items.Count; index++)
                {
                    double forRate = 0;
                    l_names.SelectedIndex = index;
                    forPrintClass getData = (forPrintClass)l_names.SelectedItem;
                    forRate += (0.8 * getData.dead) + (0.5 * getData.severelyInjured) + (0.2 * getData.minorInjury);
                    getData.rate = forRate;
                    l_names.SelectedItem = getData;
                }
                l_names.ClearSelected();
                if(l_names.Items.Count > 0)
                {
                    l_names.SelectedIndex = 0;
                }
                this.Cursor = Cursors.Default;
            }//asd
            catch(Exception ex)
            {
                MessageBox.Show("검색할때 오류생김\n\n" + ex);
                this.Cursor = Cursors.Default;
            }
        }
    }
}
