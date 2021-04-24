namespace grimoire
{
    using System.Collections.Generic;

    public interface ISpellAspect
    {
        /// <summary>
        /// Gets the dominant ethereal aspect of this spell aspect.
        /// </summary>
        DominantAspects DominantAspect { get; }

        /// <summary>
        /// Gets the collection of eminent ethereal aspects and their related variances of this spell aspect.
        /// </summary>
        IDictionary<ISpellAspect, Variances> AspectVariances { get; }

        /// <summary>
        /// Gets the name of this spell aspect.
        /// </summary>
        string Name { get; }
    }
}