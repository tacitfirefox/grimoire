namespace grimoire
{
    public interface ISpellEffectVolume
    {
        /// <summary>
        /// Gets the maximum boundary of this spell effect.
        /// </summary>
        Volume OuterBoundary { get; }

        /// <summary>
        /// Gets the minimum boundary of this spell effect.
        /// </summary>
        Volume InnerBoundary { get; }
    }
}