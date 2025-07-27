using Diary.Domain.Entities;
using Diary.Domain.Repository;
using Diary.Infrastructure.Context;
using Diary.Infrastructure.Core;

namespace Diary.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DiaryContext context) : base(context) { }
    }
}
