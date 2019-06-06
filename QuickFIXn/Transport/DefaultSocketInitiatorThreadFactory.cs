using System.Net;

namespace QuickFix.Transport
{
    class DefaultSocketInitiatorThreadFactory : ISocketInitiatorThreadFactory
    {
        public SocketInitiatorThread Create(SocketInitiator initiator, Session session, IPEndPoint socketEndPoint, SocketSettings socketSettings)
            => new SocketInitiatorThread(initiator, session, socketEndPoint, socketSettings);
    }
}
