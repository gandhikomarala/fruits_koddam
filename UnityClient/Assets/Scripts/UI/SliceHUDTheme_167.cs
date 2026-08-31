namespace SliceStorm.UI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing HUD Visual Skin #167
    /// Renders combo streaks, strike badges, and neon splatters.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceHUDTheme_167", menuName = "SliceStorm/UI/HUD Theme #167")]
    public class SliceHUDTheme_167 : ScriptableObject
    {
        [SerializeField] private string themeId = "THEME_167";
        [SerializeField] private Color neonGlow = new Color(0.95f, 0.2f, 0.4f, 1.0f);
        [SerializeField] private float splatterOpacity = 0.75f;

        public string ThemeId => themeId;
        public Color NeonGlow => neonGlow;
    }
}
