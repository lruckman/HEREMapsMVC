using System.Drawing;

namespace HEREMapsMVC.Extensions
{
    public static class Colors
    {
        /// <summary>
        /// Converts a System.Drawing.Color to a Alpha Hexidecimal format.
        /// </summary>
        /// <param name="color">The System.Drawing.Color to convert</param>
        /// <returns>Alpha Hexidecimal string</returns>
        public static string ToAlphaHexString(this Color color)
        {
            return string.Format("{0:x6}", color.ToArgb());
        }
    }
}