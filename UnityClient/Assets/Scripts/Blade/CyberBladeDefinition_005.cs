namespace SliceStorm.Blade
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyber Blade & Particle Trail Definition #005
    /// Controls blade sharpness, trail neon shaders, and combo bonus multipliers.
    /// </summary>
    [CreateAssetMenu(fileName = "CyberBladeDefinition_005", menuName = "SliceStorm/Blade #005")]
    public class CyberBladeDefinition_005 : ScriptableObject
    {
        public enum BladeRarity { Standard, Rare, Epic, Legendary }

        [Header("Blade Attributes")]
        [SerializeField] private string bladeId = "BLADE_005";
        [SerializeField] private string bladeName = "Plasma Katana #005";
        [SerializeField] private BladeRarity rarity = BladeRarity.Epic;
        [SerializeField] private Color trailGlow = new Color(0.0f, 0.95f, 1.0f, 1.0f);
        [SerializeField] private float sliceRadiusMeters = 0.45f;
        [SerializeField] private float comboWindowBonusSeconds = 0.25f;

        public string BladeId => bladeId;
        public string BladeName => bladeName;
        public Color TrailGlow => trailGlow;
        public float SliceRadiusMeters => sliceRadiusMeters;

        public float CalculateSliceForce(float swipeSpeed)
        {
            return swipeSpeed * 1.5f + (5 * 0.05f);
        }
    }
}
