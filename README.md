# EEIP.NET

## Disclaimer

- Original library: [rossmann-engineering/EEIP.NET](https://github.com/rossmann-engineering/EEIP.NET);
- Forked library: [scienta-scientific/EEIP.NET](https://github.com/scienta-scientific/EEIP.NET), base of our fork because of the porting to `netstandard2.0`;
- Our fork: [Omniaevo/EEIP.NET](https://github.com/Omniaevo/EEIP.NET), where we have adopted an event-based approach.

The general usage of the `rossmann-engineering/EEIP.NET` remains the same with an added event emitter `OnNewData`, you can subscribe to it by:

```c#
eeipClient.OnNewData += (sender, args) =>
{
  byte[] T_O_IOData = args.T_O_IOData;

  // Do something with "T_O_IOData" ...
};
```

## Description

Ethernet/IP compatible library for .NET implementations
Supports IO Scanner and Explicit Message Client functionality
For Data Exchange with Ethernet/IP Devices

- Support of Explicit Messaging and Implicit Messaging
- Object Library with CIP-Definined Objects
- Provides a simple way to access Ethernet/IP Devices without special knowledge about Ethernet/IP

[Implementation Guide and documentation](https://web.archive.org/web/20230327163405/http://eeip-library.de/)
