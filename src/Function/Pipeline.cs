#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static PipelineObject<TParameter> Pipeline<TParameter>(TParameter parameter)
        {
            return new PipelineObject<TParameter>(parameter);
        }

        public sealed class PipelineObject<TParameter>
        {
            private TParameter value;

            internal PipelineObject(TParameter parameter)
            {
                this.value = parameter;
            }

            public PipelineObject<TReturn> Chain<TReturn>(Func<TParameter, TReturn> func)
            {
                return new PipelineObject<TReturn>(func(this.value));
            }

            public TParameter Value()
            {
                return this.value;
            }
        }
    }
}
#pragma warning restore SA1300, SA1649
