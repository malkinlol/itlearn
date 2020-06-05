using itlearn.bll.Interfaces;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(NotificationVM model)
        {
            return await _unitOfWork.Notifications
                .Create(new dal.Entities.Notification
                {
                    Language = model.Language,
                    Message = model.Message,
                    NotificationDate = DateTime.Now
                });
        }

        public async Task<bool> Delete(int id)
        {
            var notification = await _unitOfWork.Notifications
                .GetById(id);

            if (notification == null)
                return false;

            return await _unitOfWork.Notifications
                .Delete(notification);
        }

        public async Task<List<NotificationVM>> GetAll()
        {
            var notifications = await _unitOfWork.Notifications.GetAlll();

            return notifications.Select(x => new NotificationVM
            {
                Message = x.Message,
                Language = x.Language,
                NotificationDate = x.NotificationDate,
                NotificationId = x.NotificationId
            }).ToList();
        }

        public async Task<NotificationVM> GetById(int id)
        {
            var notification = await _unitOfWork.Notifications
               .GetById(id);

            if (notification == null)
                return null;

            return new NotificationVM
            {
                NotificationId = notification.NotificationId,
                Message = notification.Message,
                Language = notification.Language,
                NotificationDate = notification.NotificationDate
            };
        }

        public Task<bool> Update(NotificationVM model)
        {
            throw new NotImplementedException();
        }
    }
}
