namespace SliceStorm.PowerUps
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Power-Up Modifier #122
    /// Controls Frenzy Storm spawning, Chrono Slow Motion, and Aegis Bomb Shields.
    /// </summary>
    [CreateAssetMenu(fileName = "PowerUpModifier_122", menuName = "SliceStorm/PowerUps/PowerUp #122")]
    public class PowerUpModifier_122 : ScriptableObject
    {
        public enum PowerUpType { FrenzyStorm, ChronoSlow, AegisShield, ScoreMultiplier, MagnetWave }

        [SerializeField] private string powerUpId = "POWERUP_122";
        [SerializeField] private PowerUpType type = PowerUpType.FrenzyStorm;
        [SerializeField] private float durationSeconds = 8.0f + (122 * 0.05f);
        [SerializeField] private float effectMultiplier = 2.0f;

        public string PowerUpId => powerUpId;
        public PowerUpType Type => type;
        public float DurationSeconds => durationSeconds;
        public float EffectMultiplier => effectMultiplier;
    }
}
