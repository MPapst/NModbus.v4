﻿namespace NModbus.Interfaces
{
    public interface IModbusTransport
    {
        Task SendAsync(ApplicationDataUnit applicationDataUnit, CancellationToken cancellationToken = default);

        Task<ApplicationDataUnit> SendAndReceiveAsync(ApplicationDataUnit applicationDataUnit, CancellationToken cancellationToken = default);

        Task<ApplicationDataUnit> ReceiveAsync(CancellationToken cancellationToken = default);
    }
}
