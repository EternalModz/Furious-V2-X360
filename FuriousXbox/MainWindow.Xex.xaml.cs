﻿using System.Windows;
using System.Windows.Controls;

using FuriousXbox.XboxLib.MW2;

namespace FuriousXbox;

public sealed partial class MainWindow
{
    private void NonHostAimbotCheckBox_Checked(object sender, RoutedEventArgs e)
    {
        if (xboxConsole is null)
            return;

        XexManager.call(xboxConsole, (int)CB_Index.aimbot, call_on);
    }

    private void NonHostAimbotCheckBox_UnChecked(object sender, RoutedEventArgs e)
    {
        if (xboxConsole is null)
            return;

        XexManager.call(xboxConsole, (int)CB_Index.aimbot, call_off);
    }

    private void RGBCheckBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        ((ComboBox)sender).SelectedIndex = -1;
    }

    enum CB_Index
    {
        fog = 0,
        light = 1,
        hud = 2,
        aimbot = 3
    }

    private int call_on = 2;
    private int call_off = 1;
    private bool comboBoxEnabled = false;

    private void Internal_InitRGBComboBox()
    {
        if(comboBoxEnabled)
            return;

        comboBoxEnabled = true;

        var checkBox_RGB_fog = new CheckBox()
        {
            Content = "Fog"
        };
        var checkBox_RGB_light = new CheckBox()
        {
            Content = "Light"
        };
        var checkBox_RGB_hud = new CheckBox()
        {
            Content = "HUD"
        };
        checkBox_RGB_fog.Checked += checkBox_RGB_fog_Checked;
        checkBox_RGB_fog.Unchecked += checkBox_RGB_fog_UnChecked;

        checkBox_RGB_light.Checked += checkBox_RGB_light_Checked;
        checkBox_RGB_light.Unchecked += checkBox_RGB_light_UnChecked;

        checkBox_RGB_hud.Checked += checkBox_RGB_hud_Checked;
        checkBox_RGB_hud.Unchecked += checkBox_RGB_hud_UnChecked;

        RGBComboBox.Items.Add(checkBox_RGB_fog);
        RGBComboBox.Items.Add(checkBox_RGB_light);
        RGBComboBox.Items.Add(checkBox_RGB_hud);
    }

    private void checkBox_RGB_fog_Checked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.fog, call_on);
    }

    private void checkBox_RGB_fog_UnChecked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.fog, call_off);
    }
    private void checkBox_RGB_light_Checked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.light, call_on);
    }

    private void checkBox_RGB_light_UnChecked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.light, call_off);
    }
    private void checkBox_RGB_hud_Checked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.hud, call_on);
    }

    private void checkBox_RGB_hud_UnChecked(object? sender, EventArgs e)
    {
        if (xboxConsole is null)
            return;
        XexManager.call(xboxConsole, (int)CB_Index.hud, call_off);
    }
}
