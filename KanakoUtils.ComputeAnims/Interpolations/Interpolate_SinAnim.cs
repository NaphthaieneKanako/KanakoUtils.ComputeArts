using System;

namespace KanakoUtils.ComputeAnims.Interpolations
{
    internal static class Interpolate_SinAnim
    {
        /// <summary>
        /// sin型插值
        /// </summary>
        /// <param name="currentTime">当前的运动时间（占用整体运动的时间）</param>
        /// <param name="distanceBetweenAtoB">两点之间的距离</param>
        /// <param name="speed">运动的速度</param>
        /// <returns>插值的位置，位于0，1之间</returns>        
        public static float GetInterpolateIndex(float currentTime, float distanceBetweenAtoB, float speed)
        {
            return (float)(0.5 + 0.5 * MathF.Sin(currentTime / distanceBetweenAtoB * speed * MathF.PI - MathF.PI / 2));
        }
    }
}
