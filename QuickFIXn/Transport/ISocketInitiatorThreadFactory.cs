using System.Net;

namespace QuickFix.Transport
{
    public interface ISocketInitiatorThreadFactory
    {
        SocketInitiatorThread Create(Transport.SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings);
    }
}
