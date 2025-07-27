using Diary.Domain.Entities;
using Diary.Domain.Repository;
using Diary.Infrastructure.Context;
using Diary.Infrastructure.Core;

namespace Diary.Infrastructure.Repositories
{
    public class EmotionRepository : BaseRepository<Emotion>, IEmotionRepository
    {
        public EmotionRepository(DiaryContext context) : base(context) { }
    }
}
