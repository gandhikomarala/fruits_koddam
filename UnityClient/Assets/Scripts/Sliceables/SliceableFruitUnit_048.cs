namespace SliceStorm.Sliceables
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Sliceable Crystal Fruit Unit #048
    /// Handles parabolic launch trajectories, slice splitting, juice particle splatters, and score value.
    /// </summary>
    public class SliceableFruitUnit_048 : MonoBehaviour
    {
        public enum FruitArchetype { PlasmaMelon, NeonApple, CrystalBerry, EnergyPod, GoldenRelic }

        [Header("Fruit Configuration")]
        [SerializeField] private FruitArchetype archetype = FruitArchetype.PlasmaMelon;
        [SerializeField] private int baseScore = 10 + (48 % 5) * 5;
        [SerializeField] private Color juiceParticleColor = new Color(0.95f, 0.2f, 0.4f, 1.0f);
        [SerializeField] private float launchVelocityY = 12.0f + (48 * 0.04f);

        public FruitArchetype Archetype => archetype;
        public int BaseScore => baseScore;
        public Color JuiceColor => juiceParticleColor;

        public void ExecuteSliceSplit(Vector3 sliceVector, Vector3 sliceOrigin)
        {
            // Spawn split halves and apply radial separation torque
        }
    }
}
