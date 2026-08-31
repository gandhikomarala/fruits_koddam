namespace SliceStorm.PowerUps
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Power-Up Modifier #196
    /// Controls Frenzy Storm spawning, Chrono Slow Motion, and Aegis Bomb Shields.
    /// </summary>
    [CreateAssetMenu(fileName = "PowerUpModifier_196", menuName = "SliceStorm/PowerUps/PowerUp #196")]
    public class PowerUpModifier_196 : ScriptableObject
    {
        public enum PowerUpType { FrenzyStorm, ChronoSlow, AegisShield, ScoreMultiplier, MagnetWave }

        [SerializeField] private string powerUpId = "POWERUP_196";
        [SerializeField] private PowerUpType type = PowerUpType.FrenzyStorm;
        [SerializeField] private float durationSeconds = 8.0f + (196 * 0.05f);
        [SerializeField] private float effectMultiplier = 2.0f;

        public string PowerUpId => powerUpId;
        public PowerUpType Type => type;
        public float DurationSeconds => durationSeconds;
        public float EffectMultiplier => effectMultiplier;
    }
}
