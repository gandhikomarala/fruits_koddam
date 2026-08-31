namespace SliceStorm.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Arcade Slicing Mission & Mastery Contract #037
    /// Defines slice milestones, hazard dodge challenges, and blade unlock rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "SliceMissionDefinition_037", menuName = "SliceStorm/Missions/Mission #037")]
    public class SliceMissionDefinition_037 : ScriptableObject
    {
        public enum MissionObjective { SliceMelons, AchieveCombo, ScoreThreshold, DodgeBombs, FrenzySlices }

        [SerializeField] private string missionId = "MISSION_037";
        [SerializeField] private string title = "Plasma Storm #037";
        [SerializeField] private MissionObjective objective = MissionObjective.AchieveCombo;
        [SerializeField] private int requiredCount = 20 + (37 * 5);
        [SerializeField] private int rewardGems = 100 + (37 * 10);

        public string MissionId => missionId;
        public string Title => title;
        public int RequiredCount => requiredCount;
        public int RewardGems => rewardGems;
    }
}
