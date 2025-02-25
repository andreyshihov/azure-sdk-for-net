// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Restore payload for Single File Backup Restore. </summary>
    public partial class NetAppVolumeBackupBackupRestoreFilesContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/>. </summary>
        /// <param name="fileList"> List of files to be restored. </param>
        /// <param name="destinationVolumeId"> Resource Id of the destination volume on which the files need to be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileList"/> or <paramref name="destinationVolumeId"/> is null. </exception>
        public NetAppVolumeBackupBackupRestoreFilesContent(IEnumerable<string> fileList, ResourceIdentifier destinationVolumeId)
        {
            Argument.AssertNotNull(fileList, nameof(fileList));
            Argument.AssertNotNull(destinationVolumeId, nameof(destinationVolumeId));

            FileList = fileList.ToList();
            DestinationVolumeId = destinationVolumeId;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/>. </summary>
        /// <param name="fileList"> List of files to be restored. </param>
        /// <param name="restoreFilePath"> Destination folder where the files will be restored. The path name should start with a forward slash. If it is omitted from request then restore is done at the root folder of the destination volume by default. </param>
        /// <param name="destinationVolumeId"> Resource Id of the destination volume on which the files need to be restored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupBackupRestoreFilesContent(IList<string> fileList, string restoreFilePath, ResourceIdentifier destinationVolumeId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileList = fileList;
            RestoreFilePath = restoreFilePath;
            DestinationVolumeId = destinationVolumeId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupBackupRestoreFilesContent"/> for deserialization. </summary>
        internal NetAppVolumeBackupBackupRestoreFilesContent()
        {
        }

        /// <summary> List of files to be restored. </summary>
        public IList<string> FileList { get; }
        /// <summary> Destination folder where the files will be restored. The path name should start with a forward slash. If it is omitted from request then restore is done at the root folder of the destination volume by default. </summary>
        public string RestoreFilePath { get; set; }
        /// <summary> Resource Id of the destination volume on which the files need to be restored. </summary>
        public ResourceIdentifier DestinationVolumeId { get; }
    }
}
