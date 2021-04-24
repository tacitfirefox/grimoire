namespace grimoire
{
    using System.Collections.Generic;

    public interface ISpellEffect
    {
        /// <summary>
        /// Gets the amount of ethereal work this spell requires.
        /// </summary>
        SpellWork Work { get; set; }

        /// <summary>
        /// Gets the collection of classifying tags that group and slice this effect with others.
        /// </summary>
        IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Gets the ethereal aspect data of this spell.
        /// </summary>
        ISpellAspect Aspect { get; }

        /// <summary>
        /// Gets the targeting boundary of this spell.
        /// </summary>
        ISpellEffectVolume TargetingVolume { get; }

        /// <summary>
        /// Gets the effectual boundary of this spell.
        /// </summary>
        ISpellEffectVolume EffectVolume { get; }

        /// <summary>
        /// Gets the name of this spell.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the descriptive lore text of this spell.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Gets the maximum range this spell can target.
        /// </summary>
        double TargetingRange { get; }

        /// <summary>
        /// Gets the numerical potency of this spell.
        /// </summary>
        uint Potency { get; }
    }
}