namespace grimoire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ISpellEffect
    {
        /// <summary>
        /// Gets the name of this spell.
        /// </summary>
        string Name { get; }

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
        /// Gets the numerical potency of this spell.
        /// </summary>
        uint Potency { get; }

        /// <summary>
        /// Gets the maximum range this spell can target.
        /// </summary>
        double TargetingRange { get; }
        /// <summary>
        /// Gets the amount of ethereal work this spell requires.
        /// </summary>
        SpellWork Work { get; set; }
    }
}