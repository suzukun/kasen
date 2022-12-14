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
        public static Func<TK, TR> Junction<TK, TR>(Dictionary<TK, Func<TR>> dictionary)
        {
            return (TK key) =>
            {
                return dictionary[key]();
            };
        }

        public static Func<TK, TV, TR> Junction<TK, TV, TR>(Dictionary<TK, Func<TV, TR>> dictionary)
        {
            return (TK key, TV value) =>
            {
                return dictionary[key](value);
            };
        }

        public static Func<TK, TR> Junction<TK, TR>(List<(TK, Func<TR>)> list)
        {
            Dictionary<TK, Func<TR>> dictionary = new Dictionary<TK, Func<TR>>();

            Each(list, item =>
            {
                dictionary.Add(item.Item1, item.Item2);
            });

            return Junction(dictionary);
        }

        public static Func<TK, TV, TR> Junction<TK, TV, TR>(List<(TK, Func<TV, TR>)> list)
        {
            Dictionary<TK, Func<TV, TR>> dictionary = new Dictionary<TK, Func<TV, TR>>();

            Each(list, item =>
            {
                dictionary.Add(item.Item1, item.Item2);
            });

            return Junction(dictionary);
        }

        public static Func<TK, TR> Junction<TK, TR>(params (TK, Func<TR>)[] actions)
        {
            return Junction(new List<(TK, Func<TR>)>(actions));
        }

        public static Func<TK, TV, TR> Junction<TK, TV, TR>(params (TK, Func<TV, TR>)[] actions)
        {
            return Junction(new List<(TK, Func<TV, TR>)>(actions));
        }

        public static Action<TK> Junction<TK>(Dictionary<TK, Action> dictionary)
        {
            return (TK key) =>
            {
                dictionary[key]();
            };
        }

        public static Action<TK, TV> Junction<TK, TV>(Dictionary<TK, Action<TV>> dictionary)
        {
            return (TK key, TV value) =>
            {
                dictionary[key](value);
            };
        }

        public static Action<TK> Junction<TK>(List<(TK, Action)> list)
        {
            Dictionary<TK, Action> dictionary = new Dictionary<TK, Action>();

            Each(list, item =>
            {
                dictionary.Add(item.Item1, item.Item2);
            });

            return Junction(dictionary);
        }

        public static Action<TK, TV> Junction<TK, TV>(List<(TK, Action<TV>)> list)
        {
            Dictionary<TK, Action<TV>> dictionary = new Dictionary<TK, Action<TV>>();

            Each(list, item =>
            {
                dictionary.Add(item.Item1, item.Item2);
            });

            return Junction(dictionary);
        }

        public static Action<TK> Junction<TK>(params (TK, Action)[] actions)
        {
            return Junction(new List<(TK, Action)>(actions));
        }

        public static Action<TK, TV> Junction<TK, TV>(params (TK, Action<TV>)[] actions)
        {
            return Junction(new List<(TK, Action<TV>)>(actions));
        }
    }
}
#pragma warning restore SA1300, SA1649
