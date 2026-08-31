namespace SliceStorm.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Mission & Mastery Contract #072
    /// Defines slice milestones, hazard dodge challenges, and blade unlock rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceMissionDefinition_072", menuName = "SliceStorm/Missions/Mission #072")]
    public class SliceMissionDefinition_072 : ScriptableObject
    {
        public enum MissionObjective { SliceMelons, AchieveCombo, ScoreThreshold, DodgeBombs, FrenzySlices }

        [SerializeField] private string missionId = "MISSION_072";
        [SerializeField] private string title = "Plasma Storm #072";
        [SerializeField] private MissionObjective objective = MissionObjective.AchieveCombo;
        [SerializeField] private int requiredCount = 20 + (72 * 5);
        [SerializeField] private int rewardGems = 100 + (72 * 10);

        public string MissionId => missionId;
        public string Title => title;
        public int RequiredCount => requiredCount;
        public int RewardGems => rewardGems;
    }
}
