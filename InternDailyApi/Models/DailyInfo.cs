using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InternDailyApi.Models;

[Table("dailyinfos")]
public partial class Dailyinfo
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("internname")]
    [StringLength(50)]
    public string? Internname { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }
}
