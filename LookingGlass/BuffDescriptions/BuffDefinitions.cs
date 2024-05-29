﻿using LookingGlass.LookingGlassLanguage;
using System;
using System.Collections.Generic;
using System.Text;
using RoR2;
using System.Xml.Linq;

namespace LookingGlass.BuffDescriptions
{
    internal static class BuffDefinitions
    {
        internal static void SetupEnglishDefs()
        {
            string utilityString = "<style=\"cIsUtility>";
            string damageString = "<style=\"cIsDamage>";
            string healingString = "<style=\"cIsHealing>";
            string healthString = "<style=\"cIsHealth>";
            string voidString = "<style=\"cIsVoid>";
            string shrineString = "<style=\"cShrine>";
            string styleString = "</style>";


            //foreach (var item in Language.languagesByName.Keys)
            //{
            //    Log.Debug($"Language:   {item}");
            //}
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixRed.name}", $"Blazing");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixRed.name}", $"Leave a fire trail that hurts enemies, and apply a 50% total damage {healthString}burn{styleString} on hit.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixHaunted.name}", $"Celestine");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixHaunted.name}", $"{utilityString}Cloak{styleString} nearby allies, and apply an 80% {utilityString}slow{styleString} on hit. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixWhite.name}", $"Glacial");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixWhite.name}", $"Leave an ice explosion on death, and apply an 80% {utilityString}slow{styleString} on hit. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixPoison.name}", $"Malachite");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixPoison.name}", $"Shoot occassional urchins and apply {healthString}healing disabled{styleString} on hit. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.EliteEarth.name}", $"Mending");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.EliteEarth.name}", $"{healingString}Heal{styleString} nearby non-mending allies. Produce a {healingString}healing core{styleString} on death, which detonates and heals all nearby allies. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixBlue.name}", $"Overloading");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixBlue.name}", $"Attacks explode after a delay. 50% of {healingString}health{styleString} is replaced by {utilityString}shield{styleString}.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixLunar.name}", $"Perfected");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixLunar.name}", $"{utilityString}Cripple{styleString} on hit. Occasionally fire 5 bomb projectiles at enemies. Gain 35% increased {utilityString}movement speed{styleString}, and gain 25% {healthString}max health{styleString}. All health will be replaced with {utilityString}shields{styleString}.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.EliteVoid.name}", $"Voidtouched");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.EliteVoid.name}", $"{damageString}Collapse{styleString} on hit and {utilityString}block one hit{styleString} every 15 seconds. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.ArmorBoost.name}", $"Armor Boost");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.ArmorBoost.name}", $"Gain {utilityString}+200 armor.{styleString} ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AttackSpeedOnCrit.name}", $"Attack Speed On Crit");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AttackSpeedOnCrit.name}", $"Gain {utilityString}+12% attack speed{styleString} per stack.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.BanditSkull.name}", $"Bandit Skull");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.BanditSkull.name}", $"Desperado gains {damageString}10% damage{styleString} per stack.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.AffixHauntedRecipient.name}", $"Celestine Cloak");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.AffixHauntedRecipient.name}", $"{utilityString}Disappear{styleString}. Enemies cannot target invisible allies.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Cloak.name}", $"Cloak");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Cloak.name}", $"{utilityString}Disappear{styleString}. Enemies cannot target invisible allies.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.CloakSpeed.name}", $"Cloak Speed");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.CloakSpeed.name}", $"Gain {utilityString}+40% movement speed{styleString} while invisible. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.ImmuneToDebuffReady.name}", $"Debuff Immunity");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.ImmuneToDebuffReady.name}", $"Will {utilityString}prevent{styleString} the next debuff.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.ElementalRingsReady.name}", $"Elemental Rings Ready");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.ElementalRingsReady.name}", $"Elemental bands can be activated.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.ElephantArmorBoost.name}", $"Elephant Armor Boost");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.ElephantArmorBoost.name}", $"Gain {shrineString}+500 armor{styleString}, negating most attacks. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Energized.name}", $"Energized");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Energized.name}", $"Gain {utilityString}+70% attack speed{styleString}.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.FullCrit.name}", $"Full Crit");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.FullCrit.name}", $"Gain {damageString}100% critical strike{styleString} chance. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.HiddenInvincibility.name}", $"Hidden Invincibility");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.HiddenInvincibility.name}", $"Become immune to all attacks.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Immune.name}", $"Immune");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Immune.name}", $"Become immune to all attacks.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.KillMoveSpeed.name}", $"Kill Move Speed");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.KillMoveSpeed.name}", $"Gain {utilityString}+25% movement speed{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.LifeSteal.name}", $"Life Steal");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.LifeSteal.name}", $"{healingString}Heal{styleString} for 20% of {damageString}damage{styleString} dealt.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.MedkitHeal.name}", $"Medkit Heal");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.MedkitHeal.name}", $"Gain {healthString}health{styleString} after a 2-second delay. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.NoCooldowns.name}", $"No Cooldowns");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.NoCooldowns.name}", $"Ability cooldowns reduced to 0.5s. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.OutOfCombatArmorBuff.name}", $"Opal Armor");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.OutOfCombatArmorBuff.name}", $"Gain {shrineString}+100 armor{styleString}. Removed on hit.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.PowerBuff.name}", $"Power Buff");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.PowerBuff.name}", $"Gain {damageString}+50% damage{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.CrocoRegen.name}", $"Regenerative");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.CrocoRegen.name}", $"Gain {healthString}health regeneration{styleString} equal to 5% of your {healthString}maximum health{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.LaserTurbineKillCharge.name}", $"Resonance Disc Kill Charge");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.LaserTurbineKillCharge.name}", $"Gain a stack per kill that lasts for 7 seconds. At 4 stacks, the Resonance Disc fires, resetting all stacks. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.BearVoidReady.name}", $"Safer Spaces Ready");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.BearVoidReady.name}", $"Negates the next source of damage, then goes on cooldown. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.PrimarySkillShurikenBuff.name}", $"Shuriken");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.PrimarySkillShurikenBuff.name}", $"Consumes a charge to launch a shuriken upon primary skill activation. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.ElementalRingVoidReady.name}", $"Singularity Band Ready");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.ElementalRingVoidReady.name}", $"Singularity Band can be activated.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.SmallArmorBoost.name}", $"Small Armor Boost");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.SmallArmorBoost.name}", $"Gain {utilityString}+100 armor{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.TeamWarCry.name}", $"Team War Cry");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.TeamWarCry.name}", $"Gain {utilityString}+50% movement speed{styleString} and {utilityString}+100% attack speed{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.TeslaField.name}", $"Tesla Field");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.TeslaField.name}", $"Shock nearby enemies for {damageString}200% damage{styleString} every 0.5s.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.TonicBuff.name}", $"Tonic Buff");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.TonicBuff.name}", $"Gain the following boosts:\n{healthString}+150% max health{styleString}\n{utilityString}+150% max shield{styleString}\n{utilityString}+170% attack speed{styleString}\n{utilityString}+130% movement speed{styleString}\n{utilityString}+20 armor{styleString}\n{damageString}+200% base damage{styleString}\n{healingString}+400% health regeneration");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.VoidSurvivorCorruptMode.name}", $"Void Survivor Corruption ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.VoidSurvivorCorruptMode.name}", $"Corrupted, gain different skills.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.WarCryBuff.name}", $"War Cry Buff");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.WarCryBuff.name}", $"Gain {utilityString}+50% movement speed{styleString} and {utilityString}+100% attack speed{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Warbanner.name}", $"Warbanner");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Warbanner.name}", $"Gain {utilityString}+30% attack{styleString} and {utilityString}movement speed{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.MushroomVoidActive.name}", $"Weeping Fungus Regeneration");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.MushroomVoidActive.name}", $"{healingString}Heal{styleString} while sprinting. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.WhipBoost.name}", $"Whip Boost");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.WhipBoost.name}", $"Gain {utilityString}+30% movement speed{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.ImmuneToDebuffCooldown.name}", $"Debuff Immunity Cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.ImmuneToDebuffCooldown.name}", $"Debuff Immunity is on cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.ElementalRingsCooldown.name}", $"Elemental Rings Cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.ElementalRingsCooldown.name}", $"Elemental Bands are on cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.BearVoidCooldown.name}", $"Safer Spaces Cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.BearVoidCooldown.name}", $"Damage negation is on cooldown.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.ElementalRingVoidCooldown.name}", $"Singularity Band Cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.ElementalRingVoidCooldown.name}", $"Singularity Band is on cooldown");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Slow50.name}", $"50% Slow");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Slow50.name}", $"Reduces {utilityString}movement speed{styleString} by 50% ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Slow60.name}", $"60% Slow");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Slow60.name}", $"Reduces {utilityString}movement speed{styleString} by 60% ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Slow80.name}", $"80% Slow");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Slow80.name}", $"Reduces {utilityString}movement speed{styleString} by 80% ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.BeetleJuice.name}", $"Beetle Juice");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.BeetleJuice.name}", $"Reduce {damageString}movement speed{styleString}, {healingString}character damage{styleString}, and {damageString}attack speed{styleString} by 5%. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Bleeding.name}", $"Bleed");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Bleeding.name}", $"Deals {damageString}240% damage{styleString} over time");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Blight.name}", $"Blight");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Blight.name}", $"Deals {damageString}20% base damage stat{styleString} per tick");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.OnFire.name}", $"Burn");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.OnFire.name}", $"Applies a percent of {damageString}damage{styleString} over time, and {healthString}disables health regeneration.{styleString} ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.Fracture.name}", $"Collapse");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.Fracture.name}", $"3 seconds after the first stack is applied, deals 400% {damageString}damage{styleString} per stack and removes all stacks. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Cripple.name}", $"Cripple");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Cripple.name}", $"Reduces {utilityString}armor{styleString} by 20. Reduces {utilityString}movement speed{styleString} by 50%. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.DeathMark.name}", $"Death Mark");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.DeathMark.name}", $"Increases {damageString}damage taken{styleString} from {healthString}all sources{styleString} by 50% for 7 (+7 per stack) seconds. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Entangle.name}", $"Entangle");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Entangle.name}", $"Reduce {utilityString}movement speed{styleString} to 0. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.MercExpose.name}", $"Expose");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.MercExpose.name}", $"Will take {damageString}350% damage{styleString} from next attack.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Fruiting.name}", $"Fruiting");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Fruiting.name}", $"Spawn 2-8 {healthString}healing{styleString} fruits on death. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.HealingDisabled.name}", $"Healing Disabled");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.HealingDisabled.name}", $"Disables all healing, including base health regeneration and item regeneration. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.SuperBleed.name}", $"Hemorrhage");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.SuperBleed.name}", $"{damageString}2000% base damage{styleString} over 15s. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.LunarSecondaryRoot.name}", $"Lunar Root");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.LunarSecondaryRoot.name}", $"Reduce {utilityString}movement speed{styleString} to 0 for 3 seconds per stack. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Nullified.name}", $"Nullified ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Nullified.name}", $"Reduce {utilityString}movement speed{styleString} to 0.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.NullifyStack.name}", $"Nullify Stack");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.NullifyStack.name}", $"Upon getting 3 stacks, reset all stacks and apply the Nullified debuff. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Overheat.name}", $"Overheat");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Overheat.name}", $"Increases the duration of burn damage from Grandparent's sun attack. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.PermanentDebuff.name}", $"Permanent Armor Reduction");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.PermanentDebuff.name}", $"Reduces {utilityString}armor{styleString} by 2 (2 per stack) for the remainder of the stage, or until killed. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.PermanentCurse.name}", $"Permanent Curse");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.PermanentCurse.name}", $"Maximum health reduced");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Poisoned.name}", $"Poisoned");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Poisoned.name}", $"Deals 1% of the victim's {damageString}maximum health{styleString} per second");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.PulverizeBuildup.name}", $"Pulverize Buildup");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.PulverizeBuildup.name}", $"Upon getting 5 stacks, reset all stacks and apply the Pulverized debuff. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Pulverized.name}", $"Pulverized");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Pulverized.name}", $"Reduces {utilityString}armor{styleString} by 60.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.LunarDetonationCharge.name}", $"Ruin");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.LunarDetonationCharge.name}", $"Consumes Ruin stacks to deal 300% {damageString}damage{styleString} plus 120% {damageString}damage{styleString} per Ruin stack ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{DLC1Content.Buffs.StrongerBurn.name}", $"Stronger Burn");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{DLC1Content.Buffs.StrongerBurn.name}", $"Stronger variant of the Ignite effect. Increases {damageString}damage{styleString} taken from burning. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.ClayGoo.name}", $"Tar");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.ClayGoo.name}", $"Reduces {utilityString}movement speed{styleString} by 50%. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.VoidFogMild.name}", $"Void Fog");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.VoidFogMild.name}", $"Deals a small amount of {damageString}damage{styleString} multiple times per second, {healthString}increasing with each tick{styleString}. ");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.VoidFogStrong.name}", $"Void Fog");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.VoidFogStrong.name}", $"Deals a medium amount of {damageString}damage{styleString} multiple times per second, {healthString}increasing with each tick{styleString}.");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"NAME_{RoR2Content.Buffs.Weak.name}", $"Weak");
            LookingGlassLanguageAPI.SetupToken(Language.languagesByName["en"], $"DESCRIPTION_{RoR2Content.Buffs.Weak.name}", $"Reduces {utilityString}armor{styleString} by 30%, reduces {utilityString}movement speed and damage{styleString} by 40%. ");
        }
        public static void RegisterBuff(Language language, BuffDef buff, string name, string description) //coulda used this earlier, but w/e
        {
            LookingGlassLanguageAPI.SetupToken(language, $"NAME_{buff.name}", name);
            LookingGlassLanguageAPI.SetupToken(language, $"DESCRIPTION_{buff.name}", description);
        }
    }
}
