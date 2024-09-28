namespace KasenCS
{
    using UnityEngine;
    using UnityEngine.Events;

    /// <summary>
    /// __
    /// </summary>
    public partial class __
    {
        public sealed class Tween
        {
            private static readonly AnimationCurve LINEAR = AnimationCurve.Linear(0, 0, 1, 1);

            private bool isStarted = false;
            private bool isCompleted = false;
            private bool isReverse = false;
            private int repeatCount = 0;

            private Clock clock = new();
            private UnityEvent onStart = new();
            private UnityEvent onUpdate = new();
            private UnityEvent onRepeat = new();
            private UnityEvent onComplete = new();

            private Tween(float from, float to, float duration)
            {
                this.FromParameter = from;
                this.ToParameter = to;
                this.DurationParameter = duration;
            }

            public float FromParameter { get; private set; } = 0f;

            public float ToParameter { get; private set; } = 1f;

            public float DurationParameter { get; private set; } = 0f;

            public float TimeScaleParameter { get; private set; } = 1f;

            public int RepeatParameter { get; private set; } = 0;

            public bool IsAlternate { get; private set; } = false;

            public AnimationCurve CurveParameter { get; private set; } = LINEAR;

            public float Value { get; private set; } = 0f;

            public float RawValue { get; private set; } = 0f;

            public float Progress { get; private set; } = 0f;

            public static Tween To(float fromValue, float toValue, float duration)
            {
                return new Tween(fromValue, toValue, duration);
            }

            public Tween Alternate(bool isAlternate = true)
            {
                if (this.isStarted)
                {
                    return this;
                }

                this.IsAlternate = isAlternate;

                return this;
            }

            public void Clear(bool isLeaveEvents = false)
            {
                this.isStarted = false;
                this.isCompleted = false;
                this.repeatCount = 0;

                this.ClearOneShots();

                if (isLeaveEvents)
                {
                    this.ClearEvents();
                }
            }

            public Tween Repeat(int repeat)
            {
                if (this.isStarted)
                {
                    return this;
                }

                this.RepeatParameter = repeat;

                return this;
            }

            public Tween Curve(AnimationCurve curve)
            {
                if (this.isStarted)
                {
                    return this;
                }

                this.CurveParameter = curve;

                return this;
            }

            public void OffComplete(UnityAction callback)
            {
                this.onComplete.RemoveListener(callback);
            }

            public void OffRepeat(UnityAction callback)
            {
                this.onRepeat.RemoveListener(callback);
            }

            public void OffStart(UnityAction callback)
            {
                this.onStart.RemoveListener(callback);
            }

            public void OffUpdate(UnityAction callback)
            {
                this.onUpdate.RemoveListener(callback);
            }

            public void OnComplete(UnityAction callback)
            {
                this.onComplete.AddListener(callback);
            }

            public void OnRepeat(UnityAction callback)
            {
                this.onRepeat.AddListener(callback);
            }

            public void OnStart(UnityAction callback)
            {
                this.onStart.AddListener(callback);
            }

            public void OnUpdate(UnityAction callback)
            {
                this.onUpdate.AddListener(callback);
            }

            public Tween TimeScale(float timeScale)
            {
                if (this.isStarted)
                {
                    return this;
                }

                this.TimeScaleParameter = timeScale;

                return this;
            }

            public void Update()
            {
                this.Update(Time.time);
            }

            public void Update(float time)
            {
                if (this.isCompleted)
                {
                    return;
                }

                if (!this.isStarted)
                {
                    this.isStarted = true;

                    this.onStart.Invoke();
                }

                this.clock.Update(time * this.TimeScaleParameter);

                this.Progress = Mathf.Clamp01(this.clock.ElapsedTime / this.DurationParameter);
                this.RawValue = this.CurveParameter.Evaluate(this.Progress);
                this.Value = Mathf.Lerp(this.FromParameter, this.ToParameter, this.isReverse ? 1 - this.RawValue : this.RawValue);

                this.onUpdate.Invoke();

                bool isEnded = this.Progress >= 1f;

                if (isEnded && (this.RepeatParameter < 0 || this.repeatCount < this.RepeatParameter))
                {
                    this.onRepeat.Invoke();
                    this.ClearOneShots();

                    this.repeatCount++;
                    this.isReverse = this.IsAlternate && !this.isReverse;
                }
                else if (isEnded)
                {
                    this.isCompleted = true;

                    this.onComplete.Invoke();
                }
            }

            private void ClearEvents()
            {
                this.onStart.RemoveAllListeners();
                this.onUpdate.RemoveAllListeners();
                this.onRepeat.RemoveAllListeners();
                this.onComplete.RemoveAllListeners();
            }

            private void ClearOneShots()
            {
                this.Value = 0f;
                this.RawValue = 0f;
                this.Progress = 0f;

                this.clock.Clear();
            }
        }
    }
}
