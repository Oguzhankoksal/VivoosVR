//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Common.DataModel.Market
{
    
    using System.Runtime.Serialization;
    
    
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    public partial class Problem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Problem()
        {
            this.Sessions = new HashSet<Session>();
        }
    
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public System.Guid PatientId { get; set; }
    	[DataMember]
        public string Subject { get; set; }
    	[DataMember]
        public string SymptomDescription { get; set; }
    	[DataMember]
        public string SymptomType { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> SymptomStartDate { get; set; }
    	[DataMember]
        public string SymptomResults { get; set; }
    	[DataMember]
        public Nullable<int> IGDPoints { get; set; }
    	[DataMember]
        public string Avoidance { get; set; }
    	[DataMember]
        public string Precaution { get; set; }
    	[DataMember]
        public string History { get; set; }
    	[DataMember]
        public System.DateTime EntryDate { get; set; }
    	[DataMember]
        public string PlaceOfFullSecure { get; set; }
    	[DataMember]
        public string PlaceOfSecure { get; set; }
    	[DataMember]
        public string PlaceOfHesitant { get; set; }
    	[DataMember]
        public string PlaceOfUnsecure { get; set; }
    	[DataMember]
        public string PlaceOfFullUnsecure { get; set; }
    
    	[DataMember]
        public virtual Patient Patient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[DataMember]
        public virtual ICollection<Session> Sessions { get; set; }
    
    }
}