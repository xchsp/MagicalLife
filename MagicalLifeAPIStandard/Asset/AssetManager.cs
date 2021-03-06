﻿using MagicalLifeAPI.Error.InternalExceptions;
using MagicalLifeAPI.Filing.Logging;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MagicalLifeAPI.Asset
{
    /// <summary>
    /// Used to handle assets.
    /// </summary>
    public static class AssetManager
    {
        internal static bool IsServerOnly { get; set; } = false;

        /// <summary>
        /// Holds all of the textures for the game.
        /// </summary>
        public static List<Texture2D> Textures { get; internal set; } = new List<Texture2D>();

        /// <summary>
        /// Holds information allowing tiles among other things to look up the texture ID for themselves.
        /// The string value is the name of the texture,
        /// while the int value is the index in the <see cref="Textures"/> list that the texture is stored at.
        /// </summary>
        public static Dictionary<string, int> NameToIndex { get; internal set; } = new Dictionary<string, int>();

        /// <summary>
        /// The name of the texture to find the index of.
        /// </summary>
        /// <param name="name"></param>
        public static int GetTextureIndex(string name)
        {
            foreach (KeyValuePair<string, int> item in NameToIndex)
            {
                if (item.Key == name)
                {
                    return item.Value;
                }
            }

            if (name == TextureLoader.Missing)
            {
                throw new ResourceMissingException("Texture index not found! Texture: " + name);
            }
            else
            {
                MasterLog.DebugWriteLine("Texture index not found! Texture: " + name);
                return GetTextureIndex(TextureLoader.Missing);
            }
        }
    }
}