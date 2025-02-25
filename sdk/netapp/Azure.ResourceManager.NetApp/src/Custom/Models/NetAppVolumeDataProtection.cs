﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
    public partial class NetAppVolumeDataProtection
    {
        /// <summary> Backup Properties. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NetAppVolumeBackupConfiguration Backup { get; set; }
    }
}
