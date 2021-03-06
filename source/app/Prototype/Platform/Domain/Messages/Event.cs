using System;

namespace Prototype.Platform.Domain
{
    /// <summary>
    /// Domain event
    /// </summary>
    public abstract class Event : IEvent
    {
        /// <summary>
        /// Metadata of event
        /// </summary>
        private EventMetadata _metadata = new EventMetadata();

        /// <summary>
        /// ID of aggregate
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// Metadata of event
        /// </summary>
        public EventMetadata Metadata
        {
            get { return _metadata; }
            set { _metadata = value; }
        }
    }

    /// <summary>
    /// Metadata of particular event
    /// </summary>
    public class EventMetadata : IEventMetadata
    {
        /// <summary>
        /// Unique Id of event
        /// </summary>
        public String EventId { get; set; }

        /// <summary>
        /// Command Id of command that initiate this event
        /// </summary>
        public String CommandId { get; set; }

        /// <summary>
        /// User Id of user who initiated this event
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// Datetime when event was stored in Event Store.
        /// </summary>
        public DateTime StoredDate { get; set; }

        /// <summary>
        /// Assembly qualified Event Type name
        /// </summary>
        public String TypeName { get; set; }
    }
}
