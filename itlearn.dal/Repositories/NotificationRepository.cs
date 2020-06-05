using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Repositories
{
    public class NotificationRepository
              : BaseRepository<Notification>, INotificationRepository
    {
        private readonly ApplicationContext _context;

        public NotificationRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetAlll()
        {
            return await _context.Notifications
                .OrderByDescending(x => x.NotificationDate)
                 .ToListAsync();
        }
    }
}
