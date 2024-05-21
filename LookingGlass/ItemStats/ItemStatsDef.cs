﻿using RoR2;
using System;
using System.Collections.Generic;

namespace LookingGlass.ItemStatsNameSpace
{
    public class ItemStatsDef
    {
        //Much thanks to https://github.com/ontrigger/ItemStatsMod for being a great guidline for setting item calculations up
        public enum ValueType
        {
            Healing,
            Damage,
            Utility,
            Health,
            Void,
            HumanObjective,
            LunarObjective,
            Stack,
            WorldEvent,
            Artifact,
            UserSetting,
            Death,
            Sub,
            Mono,
            Shrine,
            Event
        }
        public enum MeasurementUnits
        {
            Meters,
            Percentage,
            Health,
            Healing,
            Number,
            Seconds
        }
        public List<string> descriptions = new List<string>();
        public List<ValueType> valueTypes = new List<ValueType>();
        public List<MeasurementUnits> measurementUnits = new List<MeasurementUnits>();
        public Func<CharacterMaster, int, List<float>> calculateValues = null;
        public ItemStatsDef(List<string> descriptions, List<ValueType> valueTypes, List<MeasurementUnits> measurementUnits, Func<CharacterMaster, int, List<float>> calculateValues)
        {
            this.descriptions = descriptions;
            this.valueTypes = valueTypes;
            this.measurementUnits = measurementUnits;
            this.calculateValues = calculateValues;
        }
        public ItemStatsDef() { }
    }
}
