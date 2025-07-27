using Diary.Domain.Core;

namespace Diary.Domain.Entities
{
    public class Emotion : BaseEntity
    {
        public string Name { get; set; }   // Example: Happy, Sad, Anxious
        public string Icon { get; set; }   // Could be an emoji or path to image

        public ICollection<DiaryEntry> Entries { get; set; }
        public ICollection<Tip> Tips { get; set; }
    }
}
