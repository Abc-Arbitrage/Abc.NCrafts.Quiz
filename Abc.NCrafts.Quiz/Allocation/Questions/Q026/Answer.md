A little bit of noise in this one... But the answer is quite simple: `DateTime.Now` is performing a conversion from **UTC time** to local time, and allocates intermediary objects in the process of computing the time offset.

`DateTime.UtcNow` is a much simpler method, and does not allocate. It directly invokes some native code to get the current system time.