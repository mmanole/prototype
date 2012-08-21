using System;
using System.Collections.Generic;

namespace Prototype.Platform.Domain.Transitions.Interfaces
{
    public interface ITransitionRepository
    {
        void SaveTransition(Transition transition);
        List<Transition> GetTransitions(String streamId, Int32 fromVersion, Int32 toVersion);
        List<Transition> GetTransitions(Int32 startIndex, Int32 count);
        Int64 CountTransitions();

        /// <summary>
        /// Get all transitions ordered ascendantly by Timestamp of transiton
        /// Should be used only for testing and for very simple event replying 
        /// </summary>
        IEnumerable<Transition> GetTransitions();

        void RemoveTransition(String streamId, Int32 version);
        void RemoveStream(String streamId);

        /// <summary>
        /// Build indexes for transitions
        /// </summary>
        void EnsureIndexes();
    }
}
