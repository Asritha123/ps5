using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Eagles.EF.Models;

[Keyless]
public partial class MvCourseSection
{
    [Column("COURSE_ROWID", TypeName = "ROWID")]
    public string? CourseRowid { get; set; }

    [Column("COURSE_COURSE_NO")]
    [Precision(8)]
    public int CourseCourseNo { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("COST", TypeName = "NUMBER(9,2)")]
    public decimal? Cost { get; set; }

    [Column("PREREQUISITE")]
    [Precision(8)]
    public int? Prerequisite { get; set; }

    [Column("COURSE_SCHOOL_ID", TypeName = "NUMBER")]
    public decimal CourseSchoolId { get; set; }

    [Column("PREREQUISITE_SCHOOL_ID", TypeName = "NUMBER")]
    public decimal? PrerequisiteSchoolId { get; set; }

    [Column("SECTION_ROWID", TypeName = "ROWID")]
    public string? SectionRowid { get; set; }

    [Column("SECTION_ID")]
    [Precision(8)]
    public int SectionId { get; set; }

    [Column("SECTION_COURSE_NO")]
    [Precision(8)]
    public int SectionCourseNo { get; set; }

    [Column("SECTION_NO")]
    [Precision(3)]
    public byte SectionNo { get; set; }

    [Column("START_DATE_TIME", TypeName = "DATE")]
    public DateTime? StartDateTime { get; set; }

    [Column("LOCATION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("INSTRUCTOR_ID")]
    [Precision(8)]
    public int InstructorId { get; set; }

    [Column("CAPACITY")]
    [Precision(3)]
    public byte? Capacity { get; set; }

    [Column("SECTION_SCHOOL_ID", TypeName = "NUMBER")]
    public decimal SectionSchoolId { get; set; }
}
