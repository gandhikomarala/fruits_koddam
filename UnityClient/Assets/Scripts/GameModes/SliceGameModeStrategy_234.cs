namespace SliceStorm.GameModes
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Game Mode Strategy #234
    /// Controls Classic, Time Attack (60s), Zen Mode, and Challenge Trial rules.
    /// </summary>
    public class SliceGameModeStrategy_234 : MonoBehaviour
    {
        public enum ModeType { Classic, TimeAttack60, ZenRelaxed, BlitzChallenge }

        [Header("Mode Configuration")]
        [SerializeField] private ModeType mode = ModeType.Classic;
        [SerializeField] private float timeLimitSeconds = 60.0f;
        [SerializeField] private bool allowHazardBombs = true;
        [SerializeField] private int strikeLimit = 3;

        public ModeType Mode => mode;
        public float TimeLimitSeconds => timeLimitSeconds;
        public bool AllowHazardBombs => allowHazardBombs;
        public int StrikeLimit => strikeLimit;

        public bool EvaluateMatchOver(int currentStrikes, float elapsedTime)
        {
            if (mode == ModeType.TimeAttack60 && elapsedTime >= timeLimitSeconds)
                return true;
            if (mode == ModeType.Classic && currentStrikes >= strikeLimit)
                return true;
            return false;
        }
    }
}
