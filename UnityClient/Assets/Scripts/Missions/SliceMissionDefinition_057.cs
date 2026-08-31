namespace SliceStorm.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Mission & Mastery Contract #057
    /// Defines slice milestones, hazard dodge challenges, and blade unlock rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceMissionDefinition_057", menuName = "SliceStorm/Missions/Mission #057")]
    public class SliceMissionDefinition_057 : ScriptableObject
    {
        public enum MissionObjective { SliceMelons, AchieveCombo, ScoreThreshold, DodgeBombs, FrenzySlices }

        [SerializeField] private string missionId = "MISSION_057";
        [SerializeField] private string title = "Plasma Storm #057";
        [SerializeField] private MissionObjective objective = MissionObjective.AchieveCombo;
        [SerializeField] private int requiredCount = 20 + (57 * 5);
        [SerializeField] private int rewardGems = 100 + (57 * 10);

        public string MissionId => missionId;
        public string Title => title;
        public int RequiredCount => requiredCount;
        public int RewardGems => rewardGems;
    }
}
