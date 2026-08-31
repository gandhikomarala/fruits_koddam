namespace SliceStorm.UI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing HUD Visual Skin #045
    /// Renders combo streaks, strike badges, and neon splatters.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceHUDTheme_045", menuName = "SliceStorm/UI/HUD Theme #045")]
    public class SliceHUDTheme_045 : ScriptableObject
    {
        [SerializeField] private string themeId = "THEME_045";
        [SerializeField] private Color neonGlow = new Color(0.95f, 0.2f, 0.4f, 1.0f);
        [SerializeField] private float splatterOpacity = 0.75f;

        public string ThemeId => themeId;
        public Color NeonGlow => neonGlow;
    }
}
