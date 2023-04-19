#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static void MultiEach(int xLength, int yLength, Action<int, int> callback)
        {
            for (int y = 0; y < yLength; y++)
            {
                for (int x = 0; x < xLength; x++)
                {
                    callback(x, y);
                }
            }
        }

        public static void MultiEach(int xLength, int yLength, int zLength, Action<int, int, int> callback)
        {
            for (int z = 0; z < zLength; z++)
            {
                for (int y = 0; y < yLength; y++)
                {
                    for (int x = 0; x < xLength; x++)
                    {
                        callback(x, y, z);
                    }
                }
            }
        }

        public static void MultiEach(int xLength, int yLength, int zLength, int wLength, Action<int, int, int, int> callback)
        {
            for (int w = 0; w < wLength; w++)
            {
                for (int z = 0; z < zLength; z++)
                {
                    for (int y = 0; y < yLength; y++)
                    {
                        for (int x = 0; x < xLength; x++)
                        {
                            callback(x, y, z, w);
                        }
                    }
                }
            }
        }
    }
}
#pragma warning restore SA1300, SA1649
