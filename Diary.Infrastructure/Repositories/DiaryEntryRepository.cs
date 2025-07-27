using Diary.Domain.Entities;
using Diary.Domain.Repository;
using Diary.Infrastructure.Context;
using Diary.Infrastructure.Core;

namespace Diary.Infrastructure.Repositories
{
    public class DiaryEntryRepository : BaseRepository<DiaryEntry>, IDiaryEntryRepository
    {
        public DiaryEntryRepository(DiaryContext context) : base(context) { }
    }
}
