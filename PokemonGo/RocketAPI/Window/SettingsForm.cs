﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Configuration;

namespace PokemonGo.RocketAPI.Window
{
    partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            authTypeCb.Text = Settings.Instance.AuthType.ToString();
            ptcUserText.Text = Settings.Instance.PtcUsername;
            ptcPassText.Text = Settings.Instance.PtcPassword;
            latitudeText.Text = Settings.Instance.DefaultLatitude.ToString();
            longitudeText.Text = Settings.Instance.DefaultLongitude.ToString();
            razzmodeCb.Text = Settings.Instance.RazzBerryMode;
            razzSettingText.Text = Settings.Instance.RazzBerrySetting.ToString();
            transferTypeCb.Text = Settings.Instance.TransferType;
            pokestopRadius.Text = Settings.Instance.PokestopRadius.ToString();
            IVThreshold.Text = Settings.Instance.IVThreshold.ToString();
            transferCpThresText.Text = Settings.Instance.TransferCPThreshold.ToString();
            evolveAllChk.Checked = Settings.Instance.EvolveAllGivenPokemons;
            // Initialize map:
            //use google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            string lat = ConfigurationManager.AppSettings["DefaultLatitude"];
            string longit = ConfigurationManager.AppSettings["DefaultLongitude"];
            lat.Replace(',', '.');
            longit.Replace(',', '.'); 
            gMapControl1.Position = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(longit));
           


            //zoom min/max; default both = 2
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            //set zoom
            gMapControl1.Zoom = 10;
            label6.Text = "Right-Click and drag to move the map.";



        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Settings.Instance.SetSetting(authTypeCb.Text, "AuthType");
            Settings.Instance.SetSetting(ptcUserText.Text, "PtcUsername");
            Settings.Instance.SetSetting(ptcPassText.Text, "PtcPassword");
            Settings.Instance.SetSetting(latitudeText.Text.Replace(',', '.'), "DefaultLatitude");
            Settings.Instance.SetSetting(longitudeText.Text.Replace(',', '.'), "DefaultLongitude");

            string lat = ConfigurationManager.AppSettings["DefaultLatitude"];
            string longit = ConfigurationManager.AppSettings["DefaultLongitude"];
            lat.Replace(',', '.');
            longit.Replace(',', '.');


            Settings.Instance.SetSetting(razzmodeCb.Text, "RazzBerryMode");
            Settings.Instance.SetSetting(razzSettingText.Text, "RazzBerrySetting");
            Settings.Instance.SetSetting(transferTypeCb.Text, "TransferType");
            Settings.Instance.SetSetting(transferCpThresText.Text, "TransferCPThreshold");
            Settings.Instance.SetSetting(IVThreshold.Text, "IVThreshold");
            Settings.Instance.SetSetting(pokestopRadius.Text, "PokestopRadius");
            Settings.Instance.SetSetting(evolveAllChk.Checked ? "true" : "false", "EvolveAllGivenPokemons");
            Settings.Instance.Reload();
            Close();
        }

        private void authTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authTypeCb.Text == "Google")
            {
                ptcUserText.Visible = false;
                ptcPassText.Visible = false;
                ptcUserLabel.Visible = false;
                ptcPasswordLabel.Visible = false;
            }
            else
            {
                ptcUserText.Visible = true;
                ptcPassText.Visible = true;
                ptcUserLabel.Visible = true;
                ptcPasswordLabel.Visible = true;

            }
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double X = Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng, 6);
            double Y = Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat, 6);
            string longitude = X.ToString();
            string latitude = Y.ToString();
            latitudeText.Text = latitude;
            longitudeText.Text = longitude;









        }
    }
}
