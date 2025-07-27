using Diary.Domain.Entities;
using Diary.Domain.Repository;
using Diary.Infrastructure.Context;
using Diary.Infrastructure.Core;

namespace Diary.Infrastructure.Repositories
{
    public class TipRepository : BaseRepository<Tip>, ITipRepository
    {
        public TipRepository(DiaryContext context) : base(context) { }
    }
}
