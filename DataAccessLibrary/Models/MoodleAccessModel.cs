using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models;

public class MoodleAccess

public class MoodleAccessRecordModel
{
    public int Id { get; set; }
    public string? StudentReferenceNumber { get; set; }
    public string? ClassReference { get; set; }
    public DateOnly DateLastAccess { get; set; }
}
