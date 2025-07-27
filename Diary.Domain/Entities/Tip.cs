using Diary.Domain.Core;

namespace Diary.Domain.Entities
{
    public class Tip : BaseEntity
    {
        public string Content { get; set; }

        public int EmotionId { get; set; }
        public Emotion Emotion { get; set; }
    }
}
