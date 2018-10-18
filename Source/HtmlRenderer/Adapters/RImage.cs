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
    /// Adapter for platform specific image object - used to render images.
    /// </summary>
    public abstract class RImage : IDisposable
    {
        /// <summary>
        /// Get the width, in pixels, of the image.
        /// </summary>
        public abstract double Width { get; }

        /// <summary>
        /// Get the height, in pixels, of the image.
        /// </summary>
        public abstract double Height { get; }

        /// <summary>
        /// Gets the frames of the image, or null if animation is not supported.
        /// </summary>
        /// <remarks>
        /// Non-animated images may return a single frame.
        /// </remarks>
        /// <value>The frames.</value>
        public virtual IList<RImageFrame> Frames => null;

        /// <summary>
        /// Sets the active frame to display when painted.
        /// </summary>
        /// <param name="frame">Frame to display for this image.</param>
        public virtual void SetActiveFrame(int frame)
        {
        }

        public abstract void Dispose();
    }
}
