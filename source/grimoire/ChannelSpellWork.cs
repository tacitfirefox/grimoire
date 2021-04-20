using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grimoire
{
    public class ChannelSpellWork : SpellWork
    {
        /// <summary>
        /// Gets or sets the amount of energy required to channel this spell per unit of channel time.
        /// </summary>
        public double Rate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gets or sets the potency per <see cref="Rate" /> this spell can channel.
        /// </summary>
        public uint Strength
        {
            get => default;
            set
            {
            }
        }
    }
}