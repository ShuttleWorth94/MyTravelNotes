﻿using System;
using System.Collections.Generic;

namespace TravelNotes.Models;

public partial class TagList
{
    public int LabelId { get; set; }

    public string? TagClass { get; set; }

    public string? TagName { get; set; }
}
