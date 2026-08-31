namespace SliceStorm.UI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing HUD Visual Skin #040
    /// Renders combo streaks, strike badges, and neon splatters.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceHUDTheme_040", menuName = "SliceStorm/UI/HUD Theme #040")]
    public class SliceHUDTheme_040 : ScriptableObject
    {
        [SerializeField] private string themeId = "THEME_040";
        [SerializeField] private Color neonGlow = new Color(0.95f, 0.2f, 0.4f, 1.0f);
        [SerializeField] private float splatterOpacity = 0.75f;

        public string ThemeId => themeId;
        public Color NeonGlow => neonGlow;
    }
}
