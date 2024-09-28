namespace KasenCS
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// __
    /// </summary>
    public abstract class SoundManager<T> : MonoBehaviour
        where T : Enum
    {
        [Range(0f, 1f)]
        [SerializeField]
        private float masterVolume = 1f;

        [Min(0)]
        [SerializeField]
        private float playInterval = 0.01f;

        [SerializeField]
        private List<Sound> sounds;

        private Dictionary<T, Sound> soundMap = new();
        private Dictionary<T, AudioSource> audioSourceMap = new();
        private Dictionary<T, float> lastPlayTimeMap = new();
        private Dictionary<T, __.Tween> fadeTweenMap = new();

        private __.Observe<float> masterVolumeObserve = null;

        protected List<Sound> Sounds
        {
            get => this.sounds;
            set => this.sounds = value;
        }

        public bool Check(T name)
        {
            return this.audioSourceMap[name].isPlaying;
        }

        public void FadeIn(T name, float duration, bool isLoop = false)
        {
            if (this.fadeTweenMap.ContainsKey(name))
            {
                return;
            }

            AudioSource source = this.audioSourceMap[name];
            float volume = this.GetRawVolume(name);
            __.Tween tween = __.Tween.To(0, volume, duration);

            tween.OnUpdate(() =>
            {
                this.SetVolume(name, tween.Value);
            });

            tween.OnComplete(() =>
            {
                this.fadeTweenMap.Remove(name);
            });

            this.SetVolume(name, 0);

            if (isLoop)
            {
                this.PlayLoop(name);
            }
            else
            {
                this.Play(name);
            }

            this.fadeTweenMap.Add(name, tween);
        }

        public void FadeOut(T name, float duration)
        {
            if (this.fadeTweenMap.ContainsKey(name))
            {
                return;
            }

            AudioSource source = this.audioSourceMap[name];
            float volume = this.GetRawVolume(name);
            __.Tween tween = __.Tween.To(volume, 0f, duration);

            tween.OnUpdate(() =>
            {
                this.SetVolume(name, tween.Value);
            });

            tween.OnComplete(() =>
            {
                this.fadeTweenMap.Remove(name);
                this.Stop(name);
                this.SetVolume(name, volume);
            });

            this.fadeTweenMap.Add(name, tween);
        }

        public float GetRawVolume(T name)
        {
            return this.soundMap[name].Volume;
        }

        public float GetVolume(T name)
        {
            return this.audioSourceMap[name].volume;
        }

        public virtual void Init()
        {
            this.sounds.ForEach((sound) =>
            {
                AudioSource source = this.gameObject.AddComponent<AudioSource>();

                source.clip = sound.Clip;

                this.soundMap.Add(sound.Name, sound);
                this.audioSourceMap.Add(sound.Name, source);

                this.SetVolume(sound.Name, sound.Volume);
            });

            this.masterVolumeObserve = new(this.masterVolume);
            this.masterVolumeObserve.OnChange += this.HandleChangeMasterVolume;
        }

        public void Mute()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.Mute(item.Key);
            }
        }

        public void Mute(T name)
        {
            this.audioSourceMap[name].mute = true;
        }

        public void Pause()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.Pause(item.Key);
            }
        }

        public void Pause(T name)
        {
            this.audioSourceMap[name].Pause();
        }

        public void Play(T name, bool isOverlapping = false)
        {
            if (this.audioSourceMap[name].isPlaying && !isOverlapping)
            {
                return;
            }

            if (this.lastPlayTimeMap.ContainsKey(name))
            {
                if (Time.time - this.lastPlayTimeMap[name] < this.playInterval)
                {
                    return;
                }
            }
            else
            {
                this.lastPlayTimeMap.Add(name, 0);
            }

            this.lastPlayTimeMap[name] = Time.time;
            this.audioSourceMap[name].loop = false;

            this.audioSourceMap[name].PlayOneShot(this.audioSourceMap[name].clip);
        }

        public void PlayLoop(T name, bool isOverlapping = false)
        {
            if (this.audioSourceMap[name].isPlaying && !isOverlapping)
            {
                return;
            }

            this.audioSourceMap[name].loop = true;

            this.audioSourceMap[name].Play();
        }

        public void SetVolume(T name, float volume)
        {
            this.soundMap[name] = new()
            {
                Name = this.soundMap[name].Name,
                Clip = this.soundMap[name].Clip,
                Volume = volume,
            };

            this.UpdateVolume(name);
        }

        public void Stop()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.Stop(item.Key);
            }
        }

        public void Stop(T name)
        {
            this.audioSourceMap[name].Stop();
        }

        public void UnMute()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.UnMute(item.Key);
            }
        }

        public void UnMute(T name)
        {
            this.audioSourceMap[name].mute = false;
        }

        public void UnPause()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.UnPause(item.Key);
            }
        }

        public void UnPause(T name)
        {
            this.audioSourceMap[name].UnPause();
        }

        private void HandleChangeMasterVolume(float value)
        {
            this.masterVolume = value;

            this.UpdateVolumes();
        }

        private void Update()
        {
            this.masterVolumeObserve.Value = this.masterVolume;

            foreach (KeyValuePair<T, __.Tween> item in this.fadeTweenMap)
            {
                item.Value.Update();
            }
        }

        private void UpdateVolume(T name)
        {
            this.audioSourceMap[name].volume = this.soundMap[name].Volume * this.masterVolume;
        }

        private void UpdateVolumes()
        {
            foreach (KeyValuePair<T, AudioSource> item in this.audioSourceMap)
            {
                this.UpdateVolume(item.Key);
            }
        }

        [Serializable]
        protected struct Sound
        {
            public T Name;
            public AudioClip Clip;
            public float Volume;
        }
    }
}
