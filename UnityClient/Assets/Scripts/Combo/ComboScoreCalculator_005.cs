namespace SliceStorm.Combo
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Multi-Slice Combo & Frenzy Calculator #005
    /// Evaluates simultaneous slice detections, combo chain streaks, and blitz score boosts.
    /// </summary>
    public class ComboScoreCalculator_005
    {
        public int CalculateComboScore(int slicedCount, float comboStreak)
        {
            int basePoints = slicedCount switch
            {
                1 => 10,
                2 => 25,
                3 => 50,
                4 => 80,
                _ => 120 + (slicedCount * 25)
            };
            float streakBonus = 1.0f + (comboStreak * 0.1f);
            return (int)(basePoints * streakBonus);
        }
    }
}
