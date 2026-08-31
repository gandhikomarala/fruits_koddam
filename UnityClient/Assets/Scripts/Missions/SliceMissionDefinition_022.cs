namespace SliceStorm.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Mission & Mastery Contract #022
    /// Defines slice milestones, hazard dodge challenges, and blade unlock rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceMissionDefinition_022", menuName = "SliceStorm/Missions/Mission #022")]
    public class SliceMissionDefinition_022 : ScriptableObject
    {
        public enum MissionObjective { SliceMelons, AchieveCombo, ScoreThreshold, DodgeBombs, FrenzySlices }

        [SerializeField] private string missionId = "MISSION_022";
        [SerializeField] private string title = "Plasma Storm #022";
        [SerializeField] private MissionObjective objective = MissionObjective.AchieveCombo;
        [SerializeField] private int requiredCount = 20 + (22 * 5);
        [SerializeField] private int rewardGems = 100 + (22 * 10);

        public string MissionId => missionId;
        public string Title => title;
        public int RequiredCount => requiredCount;
        public int RewardGems => rewardGems;
    }
}
