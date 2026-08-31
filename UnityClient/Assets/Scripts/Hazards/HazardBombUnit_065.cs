namespace SliceStorm.Hazards
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Hazard Energy Bomb Unit #065
    /// Handles fuse ticking, proximity detonation, player health penalty, and EMP blast effects.
    /// </summary>
    public class HazardBombUnit_065 : MonoBehaviour
    {
        public enum BombClass { EnergyBomb, ToxicSpore, ElectricMine, EMPCluster }

        [Header("Hazard Attributes")]
        [SerializeField] private BombClass bombClass = BombClass.EnergyBomb;
        [SerializeField] private float fuseDurationSeconds = 4.0f;
        [SerializeField] private int strikePenalty = 1;
        [SerializeField] private bool causesInstantDefeat = false;

        public BombClass Type => bombClass;
        public int StrikePenalty => strikePenalty;
        public bool CausesInstantDefeat => causesInstantDefeat;

        public void TriggerDetonation(Vector3 slicePoint)
        {
            // Trigger shockwave particles and screen shake
        }
    }
}
