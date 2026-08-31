namespace SliceStorm.Audio
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Spatial Audio Emitter #150
    /// Generates blade whooshes, melon squishes, and bomb explosion sound waves.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SliceAudioSynthesizer_150 : MonoBehaviour
    {
        [SerializeField] private AudioSource source;
        [SerializeField] private float pitchVariation = 0.15f;

        public void PlaySliceSquish(float comboLevel)
        {
            if (source != null && source.isActiveAndEnabled)
            {
                source.pitch = 1.0f + (comboLevel * 0.05f);
                source.Play();
            }
        }
    }
}
