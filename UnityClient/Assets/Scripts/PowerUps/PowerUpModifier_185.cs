namespace SliceStorm.PowerUps
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Power-Up Modifier #185
    /// Controls Frenzy Storm spawning, Chrono Slow Motion, and Aegis Bomb Shields.
    /// </summary>
    [CreateAssetMenu(fileName = "PowerUpModifier_185", menuName = "SliceStorm/PowerUps/PowerUp #185")]
    public class PowerUpModifier_185 : ScriptableObject
    {
        public enum PowerUpType { FrenzyStorm, ChronoSlow, AegisShield, ScoreMultiplier, MagnetWave }

        [SerializeField] private string powerUpId = "POWERUP_185";
        [SerializeField] private PowerUpType type = PowerUpType.FrenzyStorm;
        [SerializeField] private float durationSeconds = 8.0f + (185 * 0.05f);
        [SerializeField] private float effectMultiplier = 2.0f;

        public string PowerUpId => powerUpId;
        public PowerUpType Type => type;
        public float DurationSeconds => durationSeconds;
        public float EffectMultiplier => effectMultiplier;
    }
}
