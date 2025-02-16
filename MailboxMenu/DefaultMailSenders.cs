﻿using System.Collections.Generic;

namespace MailboxMenu
{
    public partial class ModEntry {
        
        private readonly Dictionary<string, EnvelopeData> defaultMailSenders = new()
        {
            { "Robin", new EnvelopeData() { sender = "Robin" } },
            { "Demetrius", new EnvelopeData() { sender = "Demetrius" } },
            { "Linus", new EnvelopeData() { sender = "Linus" } },
            { "Pierre", new EnvelopeData() { sender = "Pierre" } },
            { "Caroline", new EnvelopeData() { sender = "Caroline" } },
            { "George", new EnvelopeData() { sender = "George" } },
            { "Evelyn", new EnvelopeData() { sender = "Evelyn" } },
            { "Pam", new EnvelopeData() { sender = "Pam" } },
            { "Lewis", new EnvelopeData() { sender = "Lewis" } },
            { "Gus", new EnvelopeData() { sender = "Gus" } },
            { "Clint", new EnvelopeData() { sender = "Clint" } },
            { "Jodi", new EnvelopeData() { sender = "Jodi" } },
            { "Kent", new EnvelopeData() { sender = "Kent" } },
            { "Emily", new EnvelopeData() { sender = "Emily" } },
            { "Marnie", new EnvelopeData() { sender = "Marnie" } },
            { "Shane", new EnvelopeData() { sender = "Shane" } },
            { "Wizard", new EnvelopeData() { sender = "Wizard" } },
            { "Sandy", new EnvelopeData() { sender = "Sandy" } },
            { "afterSamShow", new EnvelopeData() { sender = "Sam" } },
            { "afterArtShow", new EnvelopeData() { sender = "Leah" } },
            { "haleyGarden", new EnvelopeData() { sender = "Haley" } },
            { "PennyCleanTrailer", new EnvelopeData() { sender = "Penny" } },
            { "Duck", new EnvelopeData() { sender = "Marnie" } },
            { "Rabbits", new EnvelopeData() { sender = "Marnie" } },
            { "Sheep", new EnvelopeData() { sender = "Marnie" } },
            { "Goats", new EnvelopeData() { sender = "Marnie" } },
            { "Pigs", new EnvelopeData() { sender = "Marnie" } },
            { "SeaAmulet", new EnvelopeData() { sender = "Lewis" } },
            { "Bouquet", new EnvelopeData() { sender = "Pierre" } },
            { "RobinCooking", new EnvelopeData() { sender = "Robin" } },
            { "DemetriusCooking", new EnvelopeData() { sender = "Demetrius" } },
            { "LinusCooking", new EnvelopeData() { sender = "Linus" } },
            { "PierreCooking", new EnvelopeData() { sender = "Pierre" } },
            { "CarolineCooking", new EnvelopeData() { sender = "Caroline" } },
            { "GeorgeCooking", new EnvelopeData() { sender = "George" } },
            { "EvelynCooking", new EnvelopeData() { sender = "Evelyn" } },
            { "PamCooking", new EnvelopeData() { sender = "Pam" } },
            { "LewisCooking", new EnvelopeData() { sender = "Lewis" } },
            { "GusCooking", new EnvelopeData() { sender = "Gus" } },
            { "ClintCooking", new EnvelopeData() { sender = "Clint" } },
            { "JodiCooking", new EnvelopeData() { sender = "Jodi" } },
            { "KentCooking", new EnvelopeData() { sender = "Kent" } },
            { "EmilyCooking", new EnvelopeData() { sender = "Emily" } },
            { "MarnieCooking", new EnvelopeData() { sender = "Marnie" } },
            { "ShaneCooking", new EnvelopeData() { sender = "Shane" } },
            { "SandyCooking", new EnvelopeData() { sender = "Sandy" } },
            { "WillyCooking", new EnvelopeData() { sender = "Willy" } },
            { "mom1", new EnvelopeData() { sender = "Mom" } },
            { "mom2", new EnvelopeData() { sender = "Mom" } },
            { "mom3", new EnvelopeData() { sender = "Mom" } },
            { "mom4", new EnvelopeData() { sender = "Mom" } },
            { "dad1", new EnvelopeData() { sender = "Dad" } },
            { "dad2", new EnvelopeData() { sender = "Dad" } },
            { "dad3", new EnvelopeData() { sender = "Dad" } },
            { "dad4", new EnvelopeData() { sender = "Dad" } },
            { "newsstory", new EnvelopeData() { sender = "Stardew Valley Tribune" } },
            { "pierreBackpack", new EnvelopeData() { sender = "Pierre" } },
            { "pierreHours", new EnvelopeData() { sender = "Pierre" } },
            { "robinKitchenLetter", new EnvelopeData() { sender = "Robin" } },
            { "taxPassed", new EnvelopeData() { sender = "Lewis" } },
            { "taxRejected", new EnvelopeData() { sender = "Lewis" } },
            { "quest10", new EnvelopeData() { sender = "Lewis" } },
            { "quest35", new EnvelopeData() { sender = "Lewis" } },
            { "quest100", new EnvelopeData() { sender = "Lewis" } },
            { "hero_update", new EnvelopeData() { sender = "Lewis" } },
            { "CF_Fish", new EnvelopeData() { sender = "Willy" } },
            { "adoptionLetter", new EnvelopeData() { sender = "Ferngill Adoption Agency" } },
            { "fertilizers", new EnvelopeData() { sender = "Pierre" } },
            { "fertilizers2", new EnvelopeData() { sender = "Pierre" } },
            { "abbySpiritBoard", new EnvelopeData() { sender = "Abigail" } },
            { "pennySpa", new EnvelopeData() { sender = "Penny" } },
            { "incubator", new EnvelopeData() { sender = "Robin" } },
            { "hatter", new EnvelopeData() { sender = "Hat Mouse" } },
            { "Beat_PK", new EnvelopeData() { sender = "Prairie King Development Team" } },
            { "JunimoKart", new EnvelopeData() { sender = "Junimo Kart Development Team" } },
            { "elliottReading", new EnvelopeData() { sender = "Elliott" } },
            { "elliottBoat", new EnvelopeData() { sender = "Elliott" } },
            { "harveyBalloon", new EnvelopeData() { sender = "Harvey" } },
            { "samMessage", new EnvelopeData() { sender = "Sam" } },
            { "joshMessage", new EnvelopeData() { sender = "Alex" } },
            { "lewisStatue", new EnvelopeData() { sender = "Lewis" } },
            { "marnieAutoGrabber", new EnvelopeData() { sender = "Marnie" } },
            { "EmilyClothingTherapy", new EnvelopeData() { sender = "Emily" } },
            { "EmilyCamping", new EnvelopeData() { sender = "Emily" } },
            { "EmilyDoneCamping", new EnvelopeData() { sender = "Emily" } },
            { "foundLostTools", new EnvelopeData() { sender = "Lewis" } },
            { "fishing2", new EnvelopeData() { sender = "Willy" } },
            { "fishing6", new EnvelopeData() { sender = "Willy" } },
            { "wizardJunimoNote", new EnvelopeData() { sender = "Wizard" } },
            { "winter_18", new EnvelopeData() { sender = "Lewis" } },
            { "ccBulletinThankYou", new EnvelopeData() { sender = "Lewis" } },
            { "guildQuest", new EnvelopeData() { sender = "Marlon" } },
            { "skullCave", new EnvelopeData() { sender = "Qi" } },
            { "robinWell", new EnvelopeData() { sender = "Robin" } },
            { "landslideDone", new EnvelopeData() { sender = "Morris" } },
            { "QiChallengeComplete", new EnvelopeData() { sender = "Qi" } },
            { "spring_2_1", new EnvelopeData() { sender = "Willy" } },
            { "spring_12", new EnvelopeData() { sender = "Lewis" } },
            { "spring_15_1", new EnvelopeData() { sender = "Evelyn" } },
            { "spring_23", new EnvelopeData() { sender = "Lewis" } },
            { "summer_10", new EnvelopeData() { sender = "Lewis" } },
            { "summer_28", new EnvelopeData() { sender = "Demetrius" } },
            { "fall_9", new EnvelopeData() { sender = "Lewis" } },
            { "fall_15", new EnvelopeData() { sender = "Lewis" } },
            { "fall_26", new EnvelopeData() { sender = "Lewis" } },
            { "winter_7", new EnvelopeData() { sender = "Lewis" } },
            { "spring_11_1", new EnvelopeData() { sender = "Robin" } },
            { "spring_19_1", new EnvelopeData() { sender = "Jodi" } },
            { "summer_3_1", new EnvelopeData() { sender = "Lewis" } },
            { "summer_14_1", new EnvelopeData() { sender = "Pam" } },
            { "summer_20_1", new EnvelopeData() { sender = "Demetrius" } },
            { "summer_25_1", new EnvelopeData() { sender = "George" } },
            { "fall_3_1", new EnvelopeData() { sender = "Marnie" } },
            { "fall_8_1", new EnvelopeData() { sender = "Linus" } },
            { "fall_19_1", new EnvelopeData() { sender = "Caroline" } },
            { "winter_2_1", new EnvelopeData() { sender = "Willy" } },
            { "winter_6_1", new EnvelopeData() { sender = "Clint" } },
            { "winter_12_1", new EnvelopeData() { sender = "Wizard" } },
            { "winter_17_1", new EnvelopeData() { sender = "Clint" } },
            { "winter_21_1", new EnvelopeData() { sender = "Robin" } },
            { "winter_26_1", new EnvelopeData() { sender = "Gus" } },
            { "spring_1_2", new EnvelopeData() { sender = "Clint" } },
            { "spring_6_2", new EnvelopeData() { sender = "Emily" } },
            { "spring_15_2", new EnvelopeData() { sender = "Evelyn" } },
            { "spring_21_2", new EnvelopeData() { sender = "Pierre" } },
            { "summer_6_2", new EnvelopeData() { sender = "Demetrius" } },
            { "summer_15_2", new EnvelopeData() { sender = "Kent" } },
            { "summer_21_2", new EnvelopeData() { sender = "Lewis" } },
            { "fall_6_2", new EnvelopeData() { sender = "Gus" } },
            { "fall_19_2", new EnvelopeData() { sender = "Pam" } },
            { "winter_5_2", new EnvelopeData() { sender = "Wizard" } },
            { "winter_13_2", new EnvelopeData() { sender = "Willy" } },
            { "winter_19_2", new EnvelopeData() { sender = "Gus" } },
            { "winter_24", new EnvelopeData() { sender = "Lewis" } },
            { "passedOut1_Billed_Male", new EnvelopeData() { sender = "Morris" } },
            { "passedOut1_Billed_Female", new EnvelopeData() { sender = "Morris" } },
            { "passedOut1_NotBilled_Male", new EnvelopeData() { sender = "Morris" } },
            { "passedOut1_NotBilled_Female", new EnvelopeData() { sender = "Morris" } },
            { "passedOut2", new EnvelopeData() { sender = "Linus" } },
            { "passedOut3_Billed", new EnvelopeData() { sender = "Harvey" } },
            { "passedOut3_NotBilled", new EnvelopeData() { sender = "Harvey" } },
            { "passedOut4", new EnvelopeData() { sender = "Marlon" } },
            { "elliottLetter1", new EnvelopeData() { sender = "Elliott" } },
            { "elliottLetter2", new EnvelopeData() { sender = "Elliott" } },
            { "elliottLetter3", new EnvelopeData() { sender = "Elliott" } },
            { "elliottLetter4", new EnvelopeData() { sender = "Elliott" } },
            { "elliottLetter5", new EnvelopeData() { sender = "Elliott" } },
            { "elliottLetter6", new EnvelopeData() { sender = "Elliott" } },
            { "MarlonRecovery", new EnvelopeData() { sender = "Marlon" } },
            { "RarecrowSociety", new EnvelopeData() { sender = "Rarecrow Society" } },
            { "CarolineTea", new EnvelopeData() { sender = "Caroline" } },
            { "WoodChipper", new EnvelopeData() { sender = "Robin" } },
            { "willyBackRoomInvitation", new EnvelopeData() { sender = "Willy" } },
            { "KrobusCrafting", new EnvelopeData() { sender = "Krobus" } },
            { "georgeGifts", new EnvelopeData() { sender = "Evelyn" } },
            { "robinResource", new EnvelopeData() { sender = "Robin" } },
            { "ClintReward", new EnvelopeData() { sender = "Clint" } },
            { "ClintReward2", new EnvelopeData() { sender = "Clint" } },
            { "willyBugWadCutscene", new EnvelopeData() { sender = "Willy" } },
            { "MSB_Pierre", new EnvelopeData() { sender = "Pierre" } },
            { "MSB_Lewis", new EnvelopeData() { sender = "Lewis" } },
            { "WizardReward", new EnvelopeData() { sender = "Wizard" } },
            { "WizardReward2", new EnvelopeData() { sender = "Wizard" } },
            { "DemetriusReward", new EnvelopeData() { sender = "Demetrius" } },
            { "willyHours", new EnvelopeData() { sender = "Willy" } },
            { "linusTrashCleanup", new EnvelopeData() { sender = "Linus" } },
            { "gusGiantOmelet", new EnvelopeData() { sender = "Gus" } },
            { "pamNewChannel", new EnvelopeData() { sender = "Pam" } },
            { "emilyStones", new EnvelopeData() { sender = "Emily" } },
            { "carolineSO", new EnvelopeData() { sender = "Caroline" } },
            { "WillyTropicalFish", new EnvelopeData() { sender = "Willy" } },
            { "passedOutIsland", new EnvelopeData() { sender = "Willy" } },
            { "passedOutIsland_Leo", new EnvelopeData() { sender = "Willy" } },
            { "guntherBones", new EnvelopeData() { sender = "Gunther" } },
            { "LeoCooking", new EnvelopeData() { sender = "Willy" } },
            { "GreenRainGus", new EnvelopeData() { sender = "Gus" } },
            { "DesertFestival", new EnvelopeData() { sender = "Lewis" } },
            { "MarniePetAdoption", new EnvelopeData() { sender = "Marnie" } },
            { "MarniePetRejectedAdoption", new EnvelopeData() { sender = "Marnie" } },
        };
    }
}