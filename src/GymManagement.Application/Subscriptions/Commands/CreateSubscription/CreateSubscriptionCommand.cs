using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription;

public record CreateSubscriptionCommand(
    string SubscriptionType, 
    Guid adminId) : IRequest<ErrorOr<Subscription>>;