// -----------------------------------------------------------------------
// <copyright file="ApplicationGroupDeviation.cs" company="ALM | DevOps Rangers">
//    This code is licensed under the MIT License.
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF
//    ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
//    TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR
//    A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// </copyright>
// -----------------------------------------------------------------------

namespace Rangers.Antidrift.Drift.Core
{
    public class ApplicationGroupDeviation : Deviation
    {
        public ApplicationGroup ApplicationGroup { get; set; }

        public DeviationType Type { get; set; }

        public override string ToString()
        {
            return $"{this.ApplicationGroup.Name} is {this.Type} in Team Project {this.TeamProject.Name}.";
        }
    }
}