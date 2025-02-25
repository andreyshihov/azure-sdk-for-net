// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes all the settings to be used when encoding the input video with the Standard Encoder. </summary>
    public partial class StandardEncoderPreset : MediaTransformPreset
    {
        /// <summary> Initializes a new instance of <see cref="StandardEncoderPreset"/>. </summary>
        /// <param name="codecs">
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="MediaCodecBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="MediaAudioBase"/>, <see cref="CodecCopyAudio"/>, <see cref="CodecCopyVideo"/>, <see cref="DDAudio"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="MediaVideoBase"/>.
        /// </param>
        /// <param name="formats">
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="MediaFormatBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="codecs"/> or <paramref name="formats"/> is null. </exception>
        public StandardEncoderPreset(IEnumerable<MediaCodecBase> codecs, IEnumerable<MediaFormatBase> formats)
        {
            Argument.AssertNotNull(codecs, nameof(codecs));
            Argument.AssertNotNull(formats, nameof(formats));

            ExperimentalOptions = new ChangeTrackingDictionary<string, string>();
            Codecs = codecs.ToList();
            Formats = formats.ToList();
            OdataType = "#Microsoft.Media.StandardEncoderPreset";
        }

        /// <summary> Initializes a new instance of <see cref="StandardEncoderPreset"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="experimentalOptions"> Dictionary containing key value pairs for parameters not exposed in the preset itself. </param>
        /// <param name="filters"> One or more filtering operations that are applied to the input media before encoding. </param>
        /// <param name="codecs">
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="MediaCodecBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="MediaAudioBase"/>, <see cref="CodecCopyAudio"/>, <see cref="CodecCopyVideo"/>, <see cref="DDAudio"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="MediaVideoBase"/>.
        /// </param>
        /// <param name="formats">
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="MediaFormatBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </param>
        internal StandardEncoderPreset(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, string> experimentalOptions, FilteringOperations filters, IList<MediaCodecBase> codecs, IList<MediaFormatBase> formats) : base(odataType, serializedAdditionalRawData)
        {
            ExperimentalOptions = experimentalOptions;
            Filters = filters;
            Codecs = codecs;
            Formats = formats;
            OdataType = odataType ?? "#Microsoft.Media.StandardEncoderPreset";
        }

        /// <summary> Initializes a new instance of <see cref="StandardEncoderPreset"/> for deserialization. </summary>
        internal StandardEncoderPreset()
        {
        }

        /// <summary> Dictionary containing key value pairs for parameters not exposed in the preset itself. </summary>
        public IDictionary<string, string> ExperimentalOptions { get; }
        /// <summary> One or more filtering operations that are applied to the input media before encoding. </summary>
        public FilteringOperations Filters { get; set; }
        /// <summary>
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="MediaCodecBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="MediaAudioBase"/>, <see cref="CodecCopyAudio"/>, <see cref="CodecCopyVideo"/>, <see cref="DDAudio"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="MediaImageBase"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="MediaVideoBase"/>.
        /// </summary>
        public IList<MediaCodecBase> Codecs { get; }
        /// <summary>
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="MediaFormatBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </summary>
        public IList<MediaFormatBase> Formats { get; }
    }
}
