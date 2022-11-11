#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Func<TV, TR> Memoize<TV, TR>(Func<TV, TR> action)
        {
            Dictionary<TV, TR> dictionary = new Dictionary<TV, TR>();

            return (TV value) =>
            {
                if (dictionary.ContainsKey(value))
                {
                    return dictionary[value];
                }

                TR result = action(value);

                dictionary.Add(value, result);

                return result;
            };
        }
    }
}
#pragma warning restore SA1300, SA1649
