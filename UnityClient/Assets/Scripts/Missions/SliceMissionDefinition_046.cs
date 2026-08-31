namespace SliceStorm.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Mission & Mastery Contract #046
    /// Defines slice milestones, hazard dodge challenges, and blade unlock rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceMissionDefinition_046", menuName = "SliceStorm/Missions/Mission #046")]
    public class SliceMissionDefinition_046 : ScriptableObject
    {
        public enum MissionObjective { SliceMelons, AchieveCombo, ScoreThreshold, DodgeBombs, FrenzySlices }

        [SerializeField] private string missionId = "MISSION_046";
        [SerializeField] private string title = "Plasma Storm #046";
        [SerializeField] private MissionObjective objective = MissionObjective.AchieveCombo;
        [SerializeField] private int requiredCount = 20 + (46 * 5);
        [SerializeField] private int rewardGems = 100 + (46 * 10);

        public string MissionId => missionId;
        public string Title => title;
        public int RequiredCount => requiredCount;
        public int RewardGems => rewardGems;
    }
}
