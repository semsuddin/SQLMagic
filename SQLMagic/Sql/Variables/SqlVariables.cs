﻿using System;
using System.Collections.Concurrent;
using System.Data.SqlClient;

namespace SqlMagic
{
    /// <summary>
    /// A fully managed SQL Server class that takes care of handling connections.
    /// </summary>
    public sealed partial class Sql : IDisposable
    {
        #region Variables

        /// <summary>
        /// This represents the default timeout value, in seconds, used by the Sql class
        /// </summary>
        public const Int32 ExecutionTimeout = 300;

        /// <summary>
        /// This represents the default connection timeout value, in seconds, used by the Sql class
        /// </summary>
        public const Int32 ConnectionTimeout = 5;

        private String iConnectionString = String.Empty;
        private Int32 iTimeout = 0;
        private Boolean iLogging = false;
        private ConcurrentDictionary<SqlConnection, Object> iOpenConnections = null;
        private ConcurrentDictionary<SqlTransaction, Object> iTransactions = null;

        #endregion Variables
    }
}