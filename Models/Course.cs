using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Tasks;
using System;
using System.ComponentModel.DataAnnotations; 

namespace University.Models;


public class Course
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(Name = "Number")]
    public int CourseID { get; set; }
    [StringLength(50, MinimumLength = 3)]
    public string Title { get; set; }
    [Range(0, 5)]
    public int Credits { get; set; }
    public int DepartmentID { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateEdited { get; set; }
    public ApplicationUser? Owner { get; set; }
    public Department Department { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
    public ICollection<CourseAssignment> CourseAssignments { get; set; }
}
