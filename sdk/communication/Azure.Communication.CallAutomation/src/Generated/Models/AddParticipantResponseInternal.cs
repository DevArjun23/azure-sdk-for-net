// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The response payload for adding participants to the call. </summary>
    internal partial class AddParticipantResponseInternal
    {
        /// <summary> Initializes a new instance of AddParticipantResponseInternal. </summary>
        internal AddParticipantResponseInternal()
        {
        }

        /// <summary> Initializes a new instance of AddParticipantResponseInternal. </summary>
        /// <param name="participant"> List of current participants in the call. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="invitationId"> Invitation ID used to add a participant. </param>
        internal AddParticipantResponseInternal(CallParticipantInternal participant, string operationContext, string invitationId)
        {
            Participant = participant;
            OperationContext = operationContext;
            InvitationId = invitationId;
        }

        /// <summary> List of current participants in the call. </summary>
        public CallParticipantInternal Participant { get; }
        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
        /// <summary> Invitation ID used to add a participant. </summary>
        public string InvitationId { get; }
    }
}
