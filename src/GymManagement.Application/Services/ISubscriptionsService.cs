namespace GymManagement.Domain.Services;

public interface ISubscriptionsService
{
    Guid CreateSubscription(string subscriptionType, Guid adminId);
}