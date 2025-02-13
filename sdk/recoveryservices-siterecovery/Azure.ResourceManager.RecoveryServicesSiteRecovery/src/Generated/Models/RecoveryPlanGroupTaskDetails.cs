// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// This class represents the recovery plan group task.
    /// Please note <see cref="RecoveryPlanGroupTaskDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RecoveryPlanShutdownGroupTaskDetails"/>.
    /// </summary>
    public partial class RecoveryPlanGroupTaskDetails : SiteRecoveryGroupTaskDetails
    {
        /// <summary> Initializes a new instance of RecoveryPlanGroupTaskDetails. </summary>
        internal RecoveryPlanGroupTaskDetails()
        {
            InstanceType = "RecoveryPlanGroupTaskDetails";
        }

        /// <summary> Initializes a new instance of RecoveryPlanGroupTaskDetails. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="childTasks"> The child tasks. </param>
        /// <param name="name"> The name. </param>
        /// <param name="groupId"> The group identifier. </param>
        /// <param name="rpGroupType"> The group type. </param>
        internal RecoveryPlanGroupTaskDetails(string instanceType, IReadOnlyList<AsrTask> childTasks, string name, string groupId, string rpGroupType) : base(instanceType, childTasks)
        {
            Name = name;
            GroupId = groupId;
            RpGroupType = rpGroupType;
            InstanceType = instanceType ?? "RecoveryPlanGroupTaskDetails";
        }

        /// <summary> The name. </summary>
        public string Name { get; }
        /// <summary> The group identifier. </summary>
        public string GroupId { get; }
        /// <summary> The group type. </summary>
        public string RpGroupType { get; }
    }
}
