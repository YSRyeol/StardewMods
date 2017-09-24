using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using StardewValley;

namespace Pathoschild.Stardew.Automate.Framework
{
    /// <summary>A machine instance with metadata.</summary>
    internal class MachineMetadata
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The location containing the machine.</summary>
        public GameLocation Location { get; }

        /// <summary>The machine instance.</summary>
        public IMachine Machine { get; }

        /// <summary>The IO pipes connected to the machine.</summary>
        public IPipe[] Connected { get; }

        /// <summary>The tiles the machine stand on.</summary>
        public Rectangle TileBounds { get; }

        /// <summary>Construct an instance.</summary>
        /// <param name="machine">The machine instance.</param>
        /// <param name="location">The location containing the machine.</param>
        /// <param name="connected">The IO pipes connected to the machine.</param>
        /// <param name="tileBounds">The tiles the machine stand on.</param>
        public MachineMetadata(IMachine machine, GameLocation location, IEnumerable<IPipe> connected, Rectangle tileBounds)
        {
            this.Location = location;
            this.Machine = machine;
            this.Connected = connected.ToArray();
            this.TileBounds = tileBounds;
        }
    }
}
