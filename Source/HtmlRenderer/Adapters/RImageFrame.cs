// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using System;
using System.Collections.Generic;

namespace TheArtOfDev.HtmlRenderer.Adapters
{
    /// <summary>
    /// Adapter for platform specific image frame object - used when rendering animated images.
    /// </summary>
    public abstract class RImageFrame
    {
        /// <summary>
        /// Gets the delay of this frame
        /// </summary>
        /// <value>The frame delay.</value>
        public abstract TimeSpan FrameDelay { get; }
    }
}