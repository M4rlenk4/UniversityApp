using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Tasks;
using System; 

namespace University.Models;


public class Course
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseID { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateEdited { get; set; }
    public ApplicationUser? Owner { get; set; }

}
