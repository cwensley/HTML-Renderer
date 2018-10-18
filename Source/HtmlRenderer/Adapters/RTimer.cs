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

namespace TheArtOfDev.HtmlRenderer.Adapters
{
    /// <summary>
    /// Adapter for firing a timer on the UI thread.
    /// </summary>
    /// <remarks>
    /// The timer should call the <see cref="OnElapsed"/> method repeatedly at the
    /// specified <see cref="Interval"/>, until <see cref="Stop"/> is called.
    /// </remarks>
    public abstract class RTimer : IDisposable
    {
        /// <summary>
        /// Occurs when the timer has elapsed.
        /// </summary>
        public event EventHandler Elapsed;

        /// <summary>
        /// Invokes the <see cref="Elapsed"/> event.
        /// </summary>
        /// <param name="e">Event arguments</param>
        protected virtual void OnElapsed(EventArgs e) => Elapsed?.Invoke(this, e);

        /// <summary>
        /// Gets or sets the interval between timer invocations.
        /// </summary>
        /// <value>The interval for the timer.</value>
        public abstract TimeSpan Interval { get; set; }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Stops the timer.
        /// </summary>
        public abstract void Stop();

        /// <summary>
        /// Releases all resources used by the <see cref="T:TheArtOfDev.HtmlRenderer.Adapters.RTimer"/> object.
        /// </summary>
        public abstract void Dispose();
    }
}
