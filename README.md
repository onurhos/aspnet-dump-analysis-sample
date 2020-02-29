# aspnet-dump-analysis-sample
asp.net dump analizi ornek site

# Kurulum

## Dump alma

```
adplus.exe -p [processId] -hang -o c:\dumps
```

veya

```
procdump -accepteula  -m 200 -ma -64 6968
```

veya

```
Task manager -> Process -> Create Dump File
```

## Windbg

```
.symfix
.reload
.loadby sos clr
```

### Memory Analiz

```
!dumpheap -stat
!dumpheap -type System.IO.MemoryStream
!do [address]
!do [object address]
!gcroot [address to object]
```