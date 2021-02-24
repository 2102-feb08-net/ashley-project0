using System;
using System.Linq;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace SlithyToves.DataAccess
{
    public class Disposables : IDisposable
    {
        private bool _disposed = false;
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        private readonly List<IDisposable> _disposables = new List<IDisposable>();

        public SlithyTovesContext getConnectionContext()
        {
            string connectionString = File.ReadAllText("C:/revature/st-conn.txt");
            var options = new DbContextOptionsBuilder<SlithyTovesContext>()
                .UseSqlServer(connectionString)
                .LogTo(s => Debug.WriteLine(s), minimumLevel: LogLevel.Debug)
                .Options;
            var context = new SlithyTovesContext(options);

            return context;
        }

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) 
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _safeHandle?.Dispose();
            }
            _disposed = true;
        }
    }
}