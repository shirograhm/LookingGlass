﻿using BepInEx.Configuration;
using LookingGlass.Base;
using RiskOfOptions.OptionConfigs;
using RiskOfOptions.Options;
using RiskOfOptions;
using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using RoR2.UI;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace LookingGlass.ResizeCommandWindow
{
    internal class ModifyCommandWindow : BaseThing
    {
        public static ConfigEntry<bool> resize;
        public static ConfigEntry<float> opacity;


        public ModifyCommandWindow()
        {
            Setup();
        }
        public void Setup()
        {
            resize = BasePlugin.instance.Config.Bind<bool>("Command Settings", "Resize Command Window", true, "Resizes the command window to fit modded items");
            opacity = BasePlugin.instance.Config.Bind<float>("Command Settings", "Command Window Opacity", 50f, "Changes the Opacity of the regular command window");
            SetupRiskOfOptions();
        }
        public void SetupRiskOfOptions()
        {
            ModSettingsManager.AddOption(new CheckBoxOption(resize, new CheckBoxConfig() { restartRequired = false }));
            ModSettingsManager.AddOption(new SliderOption(opacity, new SliderConfig() { restartRequired = false }));
        }
        internal void ResizeWindow(PickupPickerController controller)
        {
            Transform t = controller.panelInstance.transform.Find("MainPanel");
            if (t is not null)
            {
                Transform background = t.Find("Juice/BG");
                if (background is not null)
                {
                    Color originalColor = background.GetComponent<Image>().color;
                    background.GetComponent<Image>().color = new Color(originalColor.r, originalColor.g, originalColor.b, opacity.Value / 100f);
                }
            }
            if (!resize.Value || !controller.name.StartsWith("CommandCube"))
                return;

            GridLayoutGroup gridLayoutGroup = controller.panelInstance.transform.GetComponentInChildren<GridLayoutGroup>();
            int itemCount = gridLayoutGroup.transform.childCount - 1;
            gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedRowCount;
            if (t is not null)
            {
                RectTransform r = t.GetComponent<RectTransform>();//I'm not reading this section, congratulations or I'm sorry that happened...
                int maxHeight = 12;
                int value = Mathf.CeilToInt((Mathf.Sqrt(itemCount) + 2));
                gridLayoutGroup.constraintCount = Mathf.Min(maxHeight, value) - 2;
                float height = Mathf.Min(value, maxHeight) * (r.sizeDelta.x / 8f);
                int columnReduction = value <= maxHeight ? 0 : 1;
                value = value <= maxHeight ? value : value + 1 + value - maxHeight;
                float width = (value) * (r.sizeDelta.x / 8f);
                r.sizeDelta = new Vector2(width, height); //Ugh, this is all kinda jank but it works 95%, just come back to this at some point

                Run.instance.StartCoroutine(FixColumnCountAndStuff(gridLayoutGroup, controller));
            }
        }
        public static IEnumerator FixColumnCountAndStuff(GridLayoutGroup gridLayoutGroup, PickupPickerController panel)
        {
            yield return new WaitForEndOfFrame();
            int columnCount = 1;
            float firstY = gridLayoutGroup.transform.GetChild(1).GetComponent<RectTransform>().anchoredPosition.y;
            for (int i = 2; i < gridLayoutGroup.transform.childCount; i++)
            {
                if (gridLayoutGroup.transform.GetChild(i).GetComponent<RectTransform>().anchoredPosition.y == firstY)
                {
                    columnCount++;
                }
            }
            panel.panelInstanceController.maxColumnCount = columnCount;
            panel.panelInstanceController.SetPickupOptions(panel.options);
        }
    }
}
