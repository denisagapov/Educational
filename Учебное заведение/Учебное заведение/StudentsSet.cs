//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Учебное_заведение
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentsSet()
        {
            this.PointsSet = new HashSet<PointsSet>();
        }
    
        public int Id { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdGroup { get; set; }
        public int YearReceipt { get; set; }
    
        public virtual GroupsSet GroupsSet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointsSet> PointsSet { get; set; }
    }
}
