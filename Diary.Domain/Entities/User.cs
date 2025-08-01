﻿using Diary.Domain.Core;

namespace Diary.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<DiaryEntry> Entries { get; set; }
    }
}
