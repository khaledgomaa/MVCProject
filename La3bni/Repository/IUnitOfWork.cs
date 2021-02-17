using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IUnitOfWork : IDisposable
    {
        public Repository<Playground> PlayGroundRepo { get; }

        public Repository<Booking> BookingRepo { get; }

        public Repository<BookingTeam> BookingTeamRepo { get; }

        public Repository<Subscriber> SubscriberRepo { get; }

        public Repository<PlaygroundRate> PlaygroundRateRepo { get; }

        public Repository<PlaygroundTimes> PlaygroundTimesRepo { get; }

        public Repository<News> NewsRepo { get; }

        public Repository<FeedBack> FeedBackRepo { get; }

        public Repository<Notification> NotificationRepo { get; }

        int Save();
    }
}