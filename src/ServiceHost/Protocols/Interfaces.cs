﻿using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace MiningCore.Protocols
{
    public interface IJsonRpcConnection
    {
        /// <summary>
        /// Observable sequence representing incoming JsonRpc messages from remote peer
        /// </summary>
        IObservable<JObject> Input { get; }

        /// <summary>
        /// Observer for sending outgoing JsonRpc messages to remote peer
        /// </summary>
        IObserver<JObject> Output { get; }

        /// <summary>
        /// Endpoint of remote peer (proxied from underlying IConnection)
        /// </summary>
        IPEndPoint RemoteEndPoint { get; }

        /// <summary>
        /// Unique connection id (proxied from underlying IConnection)
        /// </summary>
        string ConnectionId { get; }

        /// <summary>
        /// Closes the connection (can be called from any thread)
        /// </summary>
        void Close();
    }

    public interface IStratumConnection
    {
    }
}
