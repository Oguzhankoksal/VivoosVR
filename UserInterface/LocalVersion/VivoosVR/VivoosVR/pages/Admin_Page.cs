﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Globalization;
using System.Diagnostics;

namespace VivoosVR
{
    public partial class Admin_Page : MasterForm
    {
        public Admin_Page()
        {
            string key = null;
            InitializeComponent();
            GlobalVariables.NewSessions_Search_Flag=0;
            fill_datagrid(key);
            PlaceSelfOnSecondMonitor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show(resourceManager.GetString("msgContinue", GlobalVariables.uiLanguage),resourceManager.GetString("msgWarning", GlobalVariables.uiLanguage), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Login_Page login_page = new Login_Page();
                this.Hide();
                login_page.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GlobalVariables.NewSessions_Search_Flag = 1;
            fill_datagrid(txtSearch.Text.ToString());
        }
        public void fill_datagrid(string key)
        {
            using (VivosEntities db = new VivosEntities())
            {
                scenarios_datagrid.Rows.Clear();
                scenarios_datagrid.ColumnCount = 4;
                scenarios_datagrid.Columns[0].Width = 300;
                scenarios_datagrid.Columns[1].Visible = false;
                scenarios_datagrid.Columns[2].Name = resourceManager.GetString("headerScenario", GlobalVariables.uiLanguage);
                scenarios_datagrid.Columns[3].Width = 400;
                scenarios_datagrid.Columns[3].Name = resourceManager.GetString("headerExplanation", GlobalVariables.uiLanguage);
                scenarios_datagrid.Columns[3].Width = 800;
                scenarios_datagrid.RowTemplate.Height = 100;

                scenarios_datagrid.BorderStyle = BorderStyle.None;
                scenarios_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                scenarios_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                scenarios_datagrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                scenarios_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                scenarios_datagrid.BackgroundColor = Color.White;

                scenarios_datagrid.EnableHeadersVisualStyles = false;
                scenarios_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                scenarios_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                scenarios_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                add_button();
                scenarios_datagrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < scenarios_datagrid.ColumnCount - 2; i++)
                {
                    scenarios_datagrid.Columns[i].DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                }
                List<Asset> assetlist = (from x in db.Assets orderby x.Name select x).ToList();
                List<Asset> assetlist2 = (from x in db.Assets where x.Name.StartsWith(key) orderby x.Name select x).ToList();
                List<AssetThumbnail> assetThumbnail = (from x in db.AssetThumbnails select x).ToList();
                List<Asset> keyList = null;
                if (GlobalVariables.NewSessions_Search_Flag == 0)
                    keyList = assetlist;
                else
                    keyList = assetlist2;
                for (int i = 0; i < keyList.Count; i++)
                {
                    i = scenarios_datagrid.Rows.Add();
                    scenarios_datagrid.Rows[i].Cells[1].Value = keyList[i].Id;

                    for (int j = 0; j < assetThumbnail.Count; j++)
                    {
                        if (assetThumbnail[j].AssetId == keyList[i].Id)
                        {
                            if (assetThumbnail[j].Thumbnail!=null)
                            {
                                using (MemoryStream memoryStream = new MemoryStream(assetThumbnail[j].Thumbnail))
                                {
                                    Bitmap bmp = new Bitmap(memoryStream);
                                    scenarios_datagrid.Rows[i].Cells[0].Value = bmp;
                                }
                            }
                            
                        }
                    }

                    if (Convert.ToString(GlobalVariables.uiLanguage) == "en-US")
                    {
                        scenarios_datagrid.Rows[i].Cells[2].Value = keyList[i].EnName;
                        scenarios_datagrid.Rows[i].Cells[3].Value = keyList[i].EnDescription;
                    }
                    else if (Convert.ToString(GlobalVariables.uiLanguage) == "tr-TR")
                    {
                        scenarios_datagrid.Rows[i].Cells[2].Value = keyList[i].Name;
                        scenarios_datagrid.Rows[i].Cells[3].Value = keyList[i].Description;
                    }
                    else if (Convert.ToString(GlobalVariables.uiLanguage) == "ar-SA")
                    {
                        scenarios_datagrid.Rows[i].Cells[2].Value = keyList[i].ArabicName;
                        scenarios_datagrid.Rows[i].Cells[3].Value = keyList[i].ArabicDescription;
                    }
                }
            }
        }
        public void add_button()
        {
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            scenarios_datagrid.Columns.Add(btnDelete);
            btnDelete.HeaderText = resourceManager.GetString("headerDelete", GlobalVariables.uiLanguage);
            btnDelete.Text = resourceManager.GetString("headerDelete", GlobalVariables.uiLanguage);
            btnDelete.Name = "deleteBtn";
            btnDelete.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            scenarios_datagrid.Columns.Add(btnEdit);
            btnEdit.HeaderText = resourceManager.GetString("headerEdit", GlobalVariables.uiLanguage);
            btnEdit.Text = resourceManager.GetString("headerEdit", GlobalVariables.uiLanguage);
            btnEdit.Name = "editBtn";
            btnEdit.UseColumnTextForButtonValue = true;
        }
        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var vivoosProc = Process.GetProcesses().Where(pr => pr.ProcessName.Contains("VivoosVR"));
            foreach (var procs in vivoosProc)
            {
                procs.Kill();
            }
        }
        private void admin_Load(object sender, EventArgs e)
        {
            lblSearch.Text = resourceManager.GetString("lblSearch", GlobalVariables.uiLanguage);
            btnExit.Text = resourceManager.GetString("btnExit", GlobalVariables.uiLanguage);
            btnSettings.Text = resourceManager.GetString("btnSettings", GlobalVariables.uiLanguage);
            btnNewUser.Text = resourceManager.GetString("btnNewUser", GlobalVariables.uiLanguage);
            btnNewScenario.Text = resourceManager.GetString("btnNewScenario", GlobalVariables.uiLanguage);
            this.Text = resourceManager.GetString("formAdmin", GlobalVariables.uiLanguage);
        }

        private void scenarios_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    DialogResult delete = new DialogResult();
                    delete = MessageBox.Show(resourceManager.GetString("msgIsScenarioDeleted", GlobalVariables.uiLanguage), resourceManager.GetString("msgWarning", GlobalVariables.uiLanguage), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (delete == DialogResult.Yes)
                    {
                        GlobalVariables.Asset_Start_ID = Guid.Parse(scenarios_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                        using (VivosEntities db = new VivosEntities())
                        {
                            List<AssetCommand> AssetCommandList = (from x in db.AssetCommands where x.AssetId == GlobalVariables.Asset_Start_ID select x).ToList();
                            AssetCommand[] asset_command = new AssetCommand[AssetCommandList.Count];

                            for (int i = 0; i < asset_command.Length; i++)
                            {
                                asset_command[i] = AssetCommandList[i];
                                db.AssetCommands.Remove(asset_command[i]);
                            }
                            AssetThumbnail asset_thumbnail = db.AssetThumbnails.First(x => x.AssetId == GlobalVariables.Asset_Start_ID);
                            Asset asset = db.Assets.First(x => x.Id == GlobalVariables.Asset_Start_ID);
                            db.AssetThumbnails.Remove(asset_thumbnail);
                            db.Assets.Remove(asset);
                            db.SaveChanges();
                            GlobalVariables.NewSessions_Search_Flag = 0;
                            string key = null;
                            fill_datagrid(key);
                            DialogResult information = new DialogResult();
                            information = MessageBox.Show(resourceManager.GetString("msgScenarioDeleted", GlobalVariables.uiLanguage), resourceManager.GetString("msgInformation", GlobalVariables.uiLanguage), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {

                   
                }
            }
            else if (e.ColumnIndex == 5)
            {
                try
                {
                    GlobalVariables.Asset_Start_ID = Guid.Parse(scenarios_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    GlobalVariables.Is_Edit = true;
                    New_Scenario_Page new_scenario = new New_Scenario_Page();
                    this.Hide();
                    new_scenario.Show();
                }
                catch (Exception)
                {

                    
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings_Page settings = new Settings_Page();
            this.Hide();
            settings.Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            New_User_Page new_user = new New_User_Page();
            this.Hide();
            new_user.Show();
        }

        private void btnNewScenario_Click(object sender, EventArgs e)
        {
            GlobalVariables.Is_Edit = false;
            New_Scenario_Page new_scenario = new New_Scenario_Page();
            this.Hide();
            new_scenario.Show();
        }
    }
}
