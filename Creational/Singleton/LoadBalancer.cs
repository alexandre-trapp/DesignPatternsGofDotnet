using System;
using System.Collections.Generic;

namespace DesignPatternsGofDotnet.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    class LoadBalancer
    {
        private static LoadBalancer _instance;
        private readonly List<string> _servers = new List<string>();
        private readonly Random _random = new Random();

        // Lock synchronization object
        private static object _syncLock = new object();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
            _servers.Add("Server 6");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}