﻿using Microsoft.Xna.Framework;
using StardewValley;
using StardewValley.Tools;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Objects;
using Rectangle = Microsoft.Xna.Framework.Rectangle;
using StardewValley.TerrainFeatures;

namespace CropWateringBubbles
{
    public partial class ModEntry
    {
        public class IndoorPot_draw_Patch {
            public static void Postfix(IndoorPot __instance, SpriteBatch spriteBatch, int x, int y, float alpha = 1f) {
                if (!Config.ModEnabled) return;
                if (!isEmoting && Config.RepeatInterval != 0) return;
                if (Config.OnlyWhenWatering && Game1.player.CurrentTool is not WateringCan) return;
                if (__instance.hoeDirt.Value.crop is null) return;

                var crop = __instance.hoeDirt.Value.crop;
                if (crop.indexOfHarvest.Value == "771") return;
                if (crop.dead.Value) return;
                if (__instance.hoeDirt.Value.state.Value != 0) return;
                if (crop.currentPhase.Value >= crop.phaseDays.Count - 1 && (!crop.fullyGrown.Value || crop.dayOfCurrentPhase.Value <= 0)) return;
                
                Vector2 tilePosition = __instance.TileLocation;
                Vector2 emotePosition = Game1.GlobalToLocal(tilePosition * 64);
                float movePercent = (100 - Config.SizePercent) / 100f;
                emotePosition.Y -= 72 - movePercent * 32;
                emotePosition += new Vector2(movePercent * 32, movePercent * 32);
                
                spriteBatch.Draw(Game1.emoteSpriteSheet,
                    emotePosition, 
                    new Rectangle(currentEmoteFrame * 16 % Game1.emoteSpriteSheet.Width, currentEmoteFrame * 16 / Game1.emoteSpriteSheet.Width * 16, 16, 16),
                    Color.White * (Config.OpacityPercent / 100f), 
                    0f,
                    Vector2.Zero, 
                    4f * Config.SizePercent / 100f, 
                    SpriteEffects.None, 
                    1f);
            }
        }
        
        public class HoeDirt_draw_Patch
        {
            public static void Postfix(HoeDirt __instance, SpriteBatch spriteBatch)
            {
                if (!Config.ModEnabled ||
                    (!isEmoting && Config.RepeatInterval != 0) || 
                    __instance.crop is null ||
                    __instance.crop.indexOfHarvest.Value == "771" || 
                    __instance.crop.dead.Value ||
                    __instance.state.Value != 0 ||
                    (__instance.crop.currentPhase.Value >= __instance.crop.phaseDays.Count - 1 && (!__instance.crop.fullyGrown.Value || __instance.crop.dayOfCurrentPhase.Value <= 0) && !CanBecomeGiant(__instance)) ||
                    (Config.OnlyWhenWatering && Game1.player.CurrentTool is not WateringCan))
                    return;

                Vector2 tilePosition = __instance.Tile;
                Vector2 emotePosition = Game1.GlobalToLocal(tilePosition * 64);
                float movePercent = (100 - Config.SizePercent) / 100f;
                emotePosition.Y -= 48 - movePercent * 32;
                emotePosition += new Vector2(movePercent * 32, movePercent * 32);
                
                spriteBatch.Draw(Game1.emoteSpriteSheet,
                    emotePosition, 
                    new Rectangle(currentEmoteFrame * 16 % Game1.emoteSpriteSheet.Width, currentEmoteFrame * 16 / Game1.emoteSpriteSheet.Width * 16, 16, 16),
                    Color.White * (Config.OpacityPercent / 100f), 
                    0f,
                    Vector2.Zero, 
                    4f * Config.SizePercent / 100f, 
                    SpriteEffects.None, 
                    (tilePosition.Y * 64 + 37) / 10000f);
            }

        }
    }
}