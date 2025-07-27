using Diary.Domain.Core;

namespace Diary.Domain.Entities
{
    public class DiaryEntry : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public int EmotionId { get; set; }
        public Emotion Emotion { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
