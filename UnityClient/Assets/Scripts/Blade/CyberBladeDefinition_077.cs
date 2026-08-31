namespace SliceStorm.Blade
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyber Blade & Particle Trail Definition #077
    /// Controls blade sharpness, trail neon shaders, and combo bonus multipliers.
    /// </summary>
    [CreateAssetMenu(fileName = "CyberBladeDefinition_077", menuName = "SliceStorm/Blade #077")]
    public class CyberBladeDefinition_077 : ScriptableObject
    {
        public enum BladeRarity { Standard, Rare, Epic, Legendary }

        [Header("Blade Attributes")]
        [SerializeField] private string bladeId = "BLADE_077";
        [SerializeField] private string bladeName = "Plasma Katana #077";
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
            return swipeSpeed * 1.5f + (77 * 0.05f);
        }
    }
}
