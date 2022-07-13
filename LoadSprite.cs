using System.IO;

using UnityEngine;

namespace LoadSprite
{
    internal static class LoadSprite
    {
        internal static UnityEngine.Sprite LoadSpriteFromDisk(this string path)
        {
            byte[] array = File.ReadAllBytes(path);
            Texture2D texture2D = new Texture2D(256, 256);
            ImageConversion.LoadImage(texture2D, array);
            Rect rect = new Rect(0.0f, 0.0f, texture2D.width, texture2D.height);
            Vector2 vector = new Vector2(0.5f, 0.5f);
            Vector4 zero = Vector4.zero;
            return Sprite.CreateSprite_Injected(texture2D, ref rect, ref vector, 100f, 0, SpriteMeshType.Tight, ref zero, false);
        }
    } 
}
