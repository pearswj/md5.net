# md5.net

Testing the performance of MD5 hashing in .NET.

## Windows

```
C:\Users\Will\Desktop\Md5>Md5\bin\Debug\Md5.exe test\1m.file
test\1m.file    b6d81b360a5672d80c27430f39153e2c        18ms

C:\Users\Will\Desktop\Md5>Md5\bin\Debug\Md5.exe test\10m.file
test\10m.file   f1c9645dbc14efddc7d8a322685f26eb        38ms

C:\Users\Will\Desktop\Md5>Md5\bin\Debug\Md5.exe test\100m.file
test\100m.file  2f282b84e7e608d5852449ed940bfc51        326ms

C:\Users\Will\Desktop\Md5>Md5\bin\Debug\Md5.exe test\200m.file
test\200m.file  3566de3a97906edb98d004d6b947ae9b        625ms

C:\Users\Will\Desktop\Md5>Md5\bin\Debug\Md5.exe test\1g.file
test\1g.file    cd573cfaace07e7949bc0c46028904ff        3083ms
```

## Mac OS X

```
Wills-MacBook-Pro-Retina:Md5 will (master)$ mono Md5/bin/Debug/Md5.exe test/*
test/100m.file	2f282b84e7e608d5852449ed940bfc51	690ms
test/10m.file	f1c9645dbc14efddc7d8a322685f26eb	68ms
test/1g.file	cd573cfaace07e7949bc0c46028904ff	6154ms
test/1m.file	b6d81b360a5672d80c27430f39153e2c	8ms
test/200m.file	3566de3a97906edb98d004d6b947ae9b	1164ms
```
