// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecognizeOptions. </summary>
    internal partial class RecognizeOptionsInternal
    {
        /// <summary> Initializes a new instance of <see cref="RecognizeOptionsInternal"/>. </summary>
        /// <param name="targetParticipant"> Target participant of DTMF tone recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public RecognizeOptionsInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
        }

        /// <summary> Initializes a new instance of <see cref="RecognizeOptionsInternal"/>. </summary>
        /// <param name="interruptPrompt"> Determines if we interrupt the prompt and start recognizing. </param>
        /// <param name="initialSilenceTimeoutInSeconds"> Time to wait for first input after prompt (if any). </param>
        /// <param name="targetParticipant"> Target participant of DTMF tone recognition. </param>
        /// <param name="dtmfOptions"> Defines configurations for DTMF. </param>
        internal RecognizeOptionsInternal(bool? interruptPrompt, int? initialSilenceTimeoutInSeconds, CommunicationIdentifierModel targetParticipant, DtmfOptionsInternal dtmfOptions)
        {
            InterruptPrompt = interruptPrompt;
            InitialSilenceTimeoutInSeconds = initialSilenceTimeoutInSeconds;
            TargetParticipant = targetParticipant;
            DtmfOptions = dtmfOptions;
        }

        /// <summary> Determines if we interrupt the prompt and start recognizing. </summary>
        public bool? InterruptPrompt { get; set; }
        /// <summary> Time to wait for first input after prompt (if any). </summary>
        public int? InitialSilenceTimeoutInSeconds { get; set; }
        /// <summary> Target participant of DTMF tone recognition. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Defines configurations for DTMF. </summary>
        public DtmfOptionsInternal DtmfOptions { get; set; }
    }
}
